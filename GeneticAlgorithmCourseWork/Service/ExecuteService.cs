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

            for (int i = 0; i < 10; i++)
            {
                Chromosome chromosome = new Chromosome();

                foreach (var item in _radiusContainer)
                {
                    Gene gene;

                    if (i == 0) { 
                        gene = new Gene(item,
                        getRandomValue(0, SingleSpaceParams.getInstance().Width),
                        getRandomValue(0, SingleSpaceParams.getInstance().Height)
                        );
                }else{
                        gene = new Gene(item);
                }
                    chromosome.Container.Add(gene);
                }
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

         //   foreach (Chromosome chromosome in _populationContainer.GetSetPopulationContainer)
          //  {
                GeneticAlgorithm.GA.CheckIntersection( _populationContainer.GetSetPopulationContainer.ElementAt(0));
            //    }

            /*Хромосома с допустимыми координатами размещения*/
            Chromosome chromosome = _populationContainer.GetSetPopulationContainer.ElementAt(0);
            Coordinate coords;
            List<Coordinate> coordsList = new List<Coordinate>();
            foreach (Gene gene in chromosome.Container)
            {
                coords = new Coordinate();
                coords.CoordX = gene.OX;
                coords.CoordY = gene.OY;
                coordsList.Add(coords);
            }

            //Cоздаем популяцию
            for (int i = 1; i < 10; i++)
            {
                //ToDo Реализоват наполнение всей популяции координатами из эталонной хромосомы
            }

            callback(_populationContainer);
            int toch = 0; //Finally
        }

        
    }
}
