using GeneticAlgorithmCourseWork.ChromosomeModel;
using GeneticAlgorithmCourseWork.Container;
using GeneticAlgorithmCourseWork.SpaceParam;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeneticAlgorithmCourseWork.Service
{
    class ExecuteService
    {
        private List<int> _radiusContainer;
        private Population _populationContainer;

        public ExecuteService (List<int> container)
        {
            _radiusContainer = container;
        }

        private static int getRandomValue(int from, int to)
        {
            return new Random().Next(from, to);
        }

        public static void RefactorBadGene(Gene gene)
        {
            gene.OX = getRandomValue(0, SingleSpaceParams.getInstance().Width);
            gene.OX = getRandomValue(0, SingleSpaceParams.getInstance().Height);  
        }

        public void Start()
        {
            _populationContainer = new Population();

            for (int i = 0; i < 20; i++)
            {
                Chromosome population = new Chromosome();

                foreach (var item in _radiusContainer)
                {
                    Gene chromosome = new Gene(item,
                        getRandomValue(0, SingleSpaceParams.getInstance().Width),
                        getRandomValue(0, SingleSpaceParams.getInstance().Height)
                        );
                    population.Container.Add(chromosome);

                }
                _populationContainer.GetSetPopulationContainer.Add(population);
            }

            if (_populationContainer != null)
            { 
                Executing();
            }
        }

        public void Executing()
        {
            //ToDo
        }

        
    }
}
