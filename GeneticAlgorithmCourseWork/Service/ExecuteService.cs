using GeneticAlgorithmCourseWork.ChromosomeModel;
using GeneticAlgorithmCourseWork.Container;
using GeneticAlgorithmCourseWork.SpaceParam;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace GeneticAlgorithmCourseWork.Service
{
    class ExecuteService
    {
        private List<int> _radiusContainer;
        private Population _populationContainer;
        private List<ResultModel> _result;
        private static ParallelOptions parOps = new ParallelOptions();
        



        public event EventHandler WrongParams;
        public delegate void SendPopulation (Population population);
        public event SendPopulation callback;

        public ExecuteService (List<int> container)
        {
            _radiusContainer = container;
        }

        private static int getRandomValue(int from, int to)
        {
            Thread.Sleep(100);
            return new Random().Next(from, to);
        }

        public static void RefactorBadGene(Gene gene)
        {
            gene.OX = getRandomValue(0, SingleSpaceParams.getInstance().Width);
            gene.OY = getRandomValue(0, SingleSpaceParams.getInstance().Height);  
        }

        public void Start()
        {
            _populationContainer = new Population();
            parOps.MaxDegreeOfParallelism = Environment.ProcessorCount;

            for (int i=0; i<10; i++)
             {
                 Chromosome chromosome = new Chromosome();
                 int countOfPosition = 0;
                 foreach( int item in _radiusContainer)
                 {
                     Gene gene;

                     if (i == 0) {
                         gene = new Gene(item,
                         getRandomValue(0, SingleSpaceParams.getInstance().Width),
                         getRandomValue(0, SingleSpaceParams.getInstance().Height),
                         countOfPosition
                         );
                     } else {
                         gene = new Gene(item);
                     }
                     chromosome.Container.Add(gene);
                     countOfPosition++;
                 }
                 chromosome.AreaWidth = SingleSpaceParams.getInstance().Width;
                 chromosome.AreaHeight = SingleSpaceParams.getInstance().Height;
                 _populationContainer.GetSetPopulationContainer.Add(chromosome);
             }

            if (_populationContainer != null)
            { 
                Executing();
            }
        }

        public void Executing()
        {
            
           if(GeneticAlgorithm.GA.CheckToArea(
               _populationContainer.GetSetPopulationContainer.ElementAt(0)))
            {
                WrongParams(this, new EventArgs());
                return;
            }

            createFirstPopulation();
            
            _result = new List<ResultModel>();
            int counter = 0;
            while (true)
            {
                if (counter == 0)
                {
                    Parallel.ForEach(_populationContainer.GetSetPopulationContainer,parOps, chr =>
                     {
                         ResultModel resM = new ResultModel();

                         resM.Ratio = GeneticAlgorithm.GA.EvaluationOfFitenssFunc(chr);
                         resM.Chromosome = chr;

                         _result.Add(resM);
                     });
                }
                else
                {
                    Parallel.ForEach(_populationContainer.GetSetPopulationContainer, parOps, chr =>
                    {
                        GeneticAlgorithm.GA.GA_Encode(chr);
                    });
                    
                    //Селекция
                    _result.Sort((a, b) => b.Ratio.CompareTo(a.Ratio));

                    int count;
                    if ((_result.Count / 2) % 2 == 0)
                    {
                        count = _result.Count / 2;
                    }
                    else
                    {
                        count = (_result.Count / 2) + 1;
                    }

                    //Список хромосом для Кроссинговера
                    List<Chromosome> listForSelection = new List<Chromosome>();
                    Parallel.For(0, count, i =>
                     {
                         listForSelection.Add(_result.ElementAt(i).Chromosome);
                     });

                    //Кроссинговер
                    GeneticAlgorithm.GA.CrossingOver(listForSelection);
                }
                counter++;
            }
                    

        
            callback(_populationContainer);
        }

        private void createFirstPopulation()
        {
            GeneticAlgorithm.GA.CheckIntersection(_populationContainer.GetSetPopulationContainer.ElementAt(0));

            /*Хромосома с допустимыми координатами размещения*/
            Chromosome chromosome = _populationContainer.GetSetPopulationContainer.ElementAt(0);
            Coordinate coords;
            List<Coordinate> coordsList = new List<Coordinate>();
            foreach (Gene gene in chromosome.Container)
            {
                coords = new Coordinate();
                coords.CoordX = gene.OX;
                coords.CoordY = gene.OY;
                coords.Position = gene.NumOfPosition;
                coordsList.Add(coords);
            }

            //Cоздаем популяцию
            for (int i = 1; i < 10; i++)
            {
                List<Coordinate> lc = new List<Coordinate>(coordsList);
                Chromosome chr = _populationContainer.GetSetPopulationContainer.ElementAt(i);
                foreach (Gene gene in chr.Container)
                {

                    int randomPositionCoord = getRandomValue(0, lc.Count);
                    Coordinate coordinate = lc.ElementAt(randomPositionCoord);

                    gene.OX = coordinate.CoordX;
                    gene.OY = coordinate.CoordY;
                    gene.NumOfPosition = coordinate.Position;

                    lc.RemoveAt(randomPositionCoord);
                }

                if (GeneticAlgorithm.GA.CheckIntersection(chr, 0))
                {
                    i--;
                }

                chr.AreaWidth = SingleSpaceParams.getInstance().Width;
                chr.AreaHeight = SingleSpaceParams.getInstance().Height;
            }
        }
    }
}
