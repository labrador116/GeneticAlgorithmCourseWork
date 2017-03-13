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
        private ChromosomesContainer _container;

        public ExecuteService (List<int> container)
        {
            _radiusContainer = container;
        }

        public void Start()
        {
            _container = new ChromosomesContainer();

            foreach (var item in _radiusContainer)
            {
                Chromosome chromosome = new Chromosome(item,
                    getRandomValue(0, SingleSpaceParams.getInstance().Width),
                    getRandomValue(0, SingleSpaceParams.getInstance().Height)
                    );
                _container.Container.Add(chromosome);
                   
            }

            if (_container != null)
            { 
                Executing();
            }
        }

        public void Executing()
        {
            //ToDo
        }

        private int getRandomValue(int from, int to)
        {
            return new Random().Next(from,to);
        }
    }
}
