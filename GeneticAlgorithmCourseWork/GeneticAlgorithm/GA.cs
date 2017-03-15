using GeneticAlgorithmCourseWork.ChromosomeModel;
using GeneticAlgorithmCourseWork.Container;
using GeneticAlgorithmCourseWork.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeneticAlgorithmCourseWork.GeneticAlgorithm
{
    class GA
    {

        public static void CheckIntersection(Chromosome chromosome)
        {
            int lenght = chromosome.Container.Count;

            for (int i = 0; i <lenght ; i++)
            {
                for (int j = lenght-1; j > i; j--)
                {
                    bool resultValue = AlgorithmOfCheckIntersection(
                        chromosome.Container.ElementAt(i),
                        chromosome.Container.ElementAt(j)
                        );

                    if (resultValue == true)
                    {
                         ExecuteService.RefactorBadGene(chromosome.Container.ElementAt(j));

                        //ToDo - Проверить работу замены плохого гена
                    }
                }
            }
        }

        private static bool AlgorithmOfCheckIntersection(Gene A, Gene B)
        {
            double radiusLenght=Math.Sqrt(
                (B.OX - A.OX)*(B.OX - A.OX)+
                (B.OY-A.OY)*(B.OY - A.OY)
                );

            if (Convert.ToInt32(radiusLenght) > A.Radius + B.Radius)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
    }
}
