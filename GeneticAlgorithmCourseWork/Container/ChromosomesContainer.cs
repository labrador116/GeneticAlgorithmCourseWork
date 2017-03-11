using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GeneticAlgorithmCourseWork.ChromosomeModel;

namespace GeneticAlgorithmCourseWork.Container
{
    class ChromosomesContainer
    {
        private List<ChromosomeModel.Chromosome> _container;
   
        public ChromosomesContainer()
        {
            _container = new List<Chromosome>();
        }

        public List<Chromosome> Container { get => _container; set => _container = value; }
    }
}
