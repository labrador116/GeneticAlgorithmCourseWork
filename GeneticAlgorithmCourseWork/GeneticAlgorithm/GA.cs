using GeneticAlgorithmCourseWork.ChromosomeModel;
using GeneticAlgorithmCourseWork.Container;
using GeneticAlgorithmCourseWork.Service;
using GeneticAlgorithmCourseWork.SpaceParam;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeneticAlgorithmCourseWork.GeneticAlgorithm
{
    class GA
    {
        public static bool CheckToArea(Chromosome chromosome)
        {
            double sumCirclesArea = 0;

            List<Gene> genes = chromosome.Container;

            foreach (Gene item in genes)
            {
                sumCirclesArea += Math.PI * (item.Radius * item.Radius);
            }

            if ((SingleSpaceParams.getInstance().Width * SingleSpaceParams.getInstance().Height) / sumCirclesArea < 2)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static void CheckIntersection(Chromosome chromosome)
        {
            int length = chromosome.Container.Count;

            for (int i = 0; i <length ; i++)
            {
                for (int j = 0; j < length; j++)
                {
                    if (j != i)
                    {
                        bool resultValue = AlgorithmOfCheckIntersection(
                            chromosome.Container.ElementAt(i),
                            chromosome.Container.ElementAt(j)
                            );

                        if (resultValue == true )
                        {
                            ExecuteService.RefactorBadGene(chromosome.Container.ElementAt(i));
                            j = -1;
                        }
                    }
                }
            }
        }  
        private static bool AlgorithmOfCheckIntersection(Gene A, Gene B)
        {
            double radiusLenght=Math.Sqrt(
                ((A.OX - B.OX)*(A.OX - B.OX))+
                ((A.OY-B.OY)*(A.OY - B.OY))
                );
            /*
             * Данное условие провярет на:
             * -Пересечение двух окружностей
             * -Размещение окружностей относительно границ плоскости
             * -Размещение одной окружности внутри другой окружности
             */
            if (
                (Convert.ToInt32(radiusLenght) > A.Radius + B.Radius) &&
                !(Convert.ToInt32(radiusLenght) < A.Radius - B.Radius) &&
                ((A.OX-A.Radius)>=0 && (A.OX+A.Radius<=SingleSpaceParams.getInstance().Width)) &&
                ((A.OY-A.Radius)>=0 && (A.OY+A.Radius<=SingleSpaceParams.getInstance().Height))
               )
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
