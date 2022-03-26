using System;

namespace C_Sharp_Abstact.Models
{
    internal class Square:Figure
    {
        private int _side;

        public int Side
        {
            get
            {
                return _side;
            }
            set
            {
                if (value<0)
                {
                    Console.WriteLine("Side cannot be negative");
                    return;
                }
                _side = value;
            }
        }


        public Square(int side)
        {
            side = Side;
        }

        public override void CalcArea()
        {
            Console.WriteLine("Square CalcArea method"); 
        }
    }
}
