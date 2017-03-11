using GeneticAlgorithmCourseWork.ChromosomeModel;
using GeneticAlgorithmCourseWork.Container;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeneticAlgorithmCourseWork.Service
{
    class ExecuteService
    {
        private int _CountOfDevices;

        public void CreatesDevices(int countOfDevices)
        {
            ChromosomesContainer container = new ChromosomesContainer();

            for (int i = 0; i < countOfDevices; i++)
            {
                //Chromosome chromosome = new Chromosome();
              
            }
        }
    }
}
