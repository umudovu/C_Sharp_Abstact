using System;

namespace C_Sharp_Abstact.Models
{
    internal class Rectangular:Figure
    {
        private int _width;
        private int _length;

        public int Width
        {
            get
            {
                return _width;
            }
            set
            {
                if (value<0)
                {
                    Console.WriteLine("It cannot be negative");
                    return;
                }
                _width = value;
            }
        }

        public int Length
        {
            get
            {
                return _length;
            }
            set
            {
                if (value<0)
                {
                    Console.WriteLine("It cannot be negative");
                    return;
                }
                _length = value;
            }
        }
        public Rectangular(int width,int length)
        {
            width=Width;
            length=Length;
        }

        public override void CalcArea()
        {


            Console.WriteLine($"Area of a rectangle: {_width*_length}");

            Console.WriteLine("Rectangulars CalcArea method"); ;
        }
    }
}
