using FigureLibrary.Figures.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FigureLibrary.Figures.Classes
{
    internal class Triangle : IFigure
    {

        public double FirstSide { 
            get
            {
                return FirstSide;
            } set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("Сторона не может быть меньше нуля");
                }
                FirstSide = value;
            }
        }
        public double SecondSide { 
            get
            {
                return SecondSide;
            } set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("Сторона не может быть меньше нуля");
                }
                SecondSide = value;
            }
        }
        public double ThirdSide {
            get
            {
                return ThirdSide;
             }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("Сторона не может быть меньше нуля");
                }
                ThirdSide = value;
            }
        }
        public Triangle(double firstSide = 0 , double secondSide = 0 , double thirdSide = 0)
        {
            // Проверяем длины сторон на неотрицательность
            if (firstSide < 0 || secondSide < 0 || thirdSide < 0)
            {
                throw new ArgumentException("Одна из указаных длин треугольника меньше нуля");
            }
            // Проверяем треугольник на существование
            if (
                 firstSide + secondSide < thirdSide ||
                 firstSide + thirdSide < secondSide ||
                 secondSide + thirdSide < thirdSide
                )
            {
                throw new ArgumentException("Треугольника с данными сторонами не может быть");
            }
            this.FirstSide = firstSide;
            this.SecondSide = secondSide;
            this.ThirdSide = thirdSide;
        }
        /// <summary>
        /// Площадь треугольника
        /// </summary>
        public double Area  { 
            get {
                double semiPerimeter = (this.FirstSide + this.SecondSide + this.ThirdSide) / 2;
                return Math.Sqrt(semiPerimeter * (semiPerimeter - this.FirstSide) * (semiPerimeter - this.SecondSide) * (semiPerimeter - this.ThirdSide));
            } 
        }
        /// <summary>
        /// Признак того, что треугольник прямоугольный
        /// </summary>
        public bool IsRight { 
            get
            {
                // Если хоть одно условие выполняется, то треугольник прямоугольный
                return
                    Math.Pow(this.SecondSide, 2) == Math.Sqrt(Math.Pow(this.FirstSide, 2) + Math.Pow(this.ThirdSide, 2)) ||
                    Math.Pow(this.FirstSide, 2) == Math.Sqrt(Math.Pow(this.SecondSide, 2) + Math.Pow(this.ThirdSide, 2)) ||
                    Math.Pow(this.ThirdSide, 2) == Math.Sqrt(Math.Pow(this.SecondSide, 2) + Math.Pow(this.FirstSide, 2));
            } 
        }
    }
}
