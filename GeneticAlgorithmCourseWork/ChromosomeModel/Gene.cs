﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeneticAlgorithmCourseWork.ChromosomeModel
{
   public class Gene
    {
        int _radius;
        int _oX;
        int _oY;

        public Gene(int radius, int oX, int oY)
        {
            Radius = radius;
            OX = oX;
            this.OY = oY;
        }

        public Gene(int radius)
        {
            Radius = radius;
        }

        public int Radius { get => _radius; set => _radius = value; }
        public int OX { get => _oX; set => _oX = value; }
        public int OY { get => _oY; set => _oY = value; }
   
    }
}
