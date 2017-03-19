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
        /*Проверка всех окружностей на занимаемую плоскость*/
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
        /*Проверка пересечений*/
        public static bool CheckIntersection(Chromosome chromosome, int val)
        {
            int length = chromosome.Container.Count;

            for (int i = 0; i < length; i++)
            {
                for (int j = 0; j < length; j++)
                {
                    if (j != i)
                    {
                        bool resultValue = AlgorithmOfCheckIntersection(
                            chromosome.Container.ElementAt(i),
                            chromosome.Container.ElementAt(j)
                            );

                        if (resultValue == true)
                        {
                            return true;
                        }
                    }
                }
            }
            return false;
        }
        /*Проверка пересечений*/
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
        /*Корректировка ширины плоскасти*/
        private static void AdjustmentOfAreA(Chromosome chromosome)
        {
            List<int> distanceToWeightBorder = new List<int>();

            foreach (Gene gene in chromosome.Container)
            {
                 distanceToWeightBorder.Add(chromosome.AreaWidth - (gene.OX + gene.Radius));
            }

            chromosome.AreaWidth-=distanceToWeightBorder.Min();
        }
        /*Оценка фитнесс-функции*/
        public static double EvaluationOfFitenssFunc(Chromosome chromosome)
        {
            AdjustmentOfAreA(chromosome);

            double sumOfGenesArea = 0;

            foreach (Gene gene in chromosome.Container)
            {
                sumOfGenesArea += Math.PI * (gene.Radius * gene.Radius);
            }

            return (sumOfGenesArea / (chromosome.AreaWidth * chromosome.AreaHeight));
        }
        /*Кодирование позиции размещения*/
        public static void GA_Encode(Chromosome chromosome)
        {
            foreach (Gene gene in chromosome.Container)
            {
                String binValue = Convert.ToString(gene.NumOfPosition, 2);
                while (binValue.Length != 4)
                {
                    binValue = "0" + binValue;
                }

                gene.EncodeValue = binValue;
            }
        }

        //Кроссинговер
        public static void CrossingOver(List<Chromosome> chromosomesContainer)
        {
            int sumChromosome = chromosomesContainer.Count;

            for (int i=0;i<sumChromosome; i = i + 2)
            {
                int dotOfCrossingOver = new Random().Next(0, chromosomesContainer.ElementAt(i).Container.Count);

                Chromosome chrA = chromosomesContainer.ElementAt(i);
                Chromosome chrB = chromosomesContainer.ElementAt(i + 1);

                Chromosome child_one = OperationCO(chrA, chrB, dotOfCrossingOver);
                Chromosome child_two = OperationCO(chrB, chrA, dotOfCrossingOver);

                chromosomesContainer.Add(child_one);
                chromosomesContainer.Add(child_two);
            }
        }

        private static Chromosome OperationCO(Chromosome chromA, Chromosome chromB, int dotOfCross)
        {
            Chromosome childChromosome = new Chromosome();

            for (int i = 0; i< chromA.Container.Count; i++)
            {
                if (i <= dotOfCross)
                {
                    childChromosome.Container.Add(
                        chromA.Container.ElementAt(i)
                        );
                }
                if (i > dotOfCross)
                {
                    childChromosome.Container.Add(
                        chromB.Container.ElementAt(i)
                        );
                }
            }

            return childChromosome;
        }
    }
}
