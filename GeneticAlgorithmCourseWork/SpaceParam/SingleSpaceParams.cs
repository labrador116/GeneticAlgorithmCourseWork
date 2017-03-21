using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeneticAlgorithmCourseWork.SpaceParam
{
    class SingleSpaceParams
    {
        private static SingleSpaceParams instance;
        private int _width;
        private int _height;
        private double _criterionOfQuality;
        private int numOfPopulation;

        private SingleSpaceParams(int width, int height)
        {
            _width = width;
            _height = height;
        }

        public int Width { get => _width; set => _width = value; }
        public int Height { get => _height; set => _height = value; }
        public double CriterionOfQuality { get => _criterionOfQuality; set => _criterionOfQuality = value; }
        public int NumOfPopulation { get => numOfPopulation; set => numOfPopulation = value; }

        public static SingleSpaceParams getInstance()
        {
            if (instance == null)
            {
                throw new Exception("SingleSpaceParams isn't created");
            }
            return instance;
        }

        public static SingleSpaceParams getInstance(int width, int height)
        {
            if (instance == null)
            {
                instance = new SingleSpaceParams(width,height);
            }
            return instance;
        }
    }
}
