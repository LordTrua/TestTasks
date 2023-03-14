using FigureLibrary.Figures.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FigureLibrary.Figures.Classes
{
    internal class Circle : IFigure
    {
        public Circle(double radius = 0)
        {
            this.Radius = radius;
        }
        public double Radius { 
            get {
                return Radius;
                    }
            set {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("Радиус не может быть меньше нуля");
                }
                Radius = value;
            }
        }
        public double Area { 
            get
            {
                if (
                    this.Radius < 0
                    )
                {
                    throw new ArgumentException("Радиус не может быть меньше нуля");
                }
                return Radius * Radius * Math.PI;
            } }
    }
}
