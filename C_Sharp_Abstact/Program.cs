using C_Sharp_Abstact.Models;
using System;

namespace C_Sharp_Abstact
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int choice = GetMetodInt("Please make a choice \n" +
                "1. Square \n" +
                "2. Rectangular \n" +
                "0. Quit \n",-1,2);

            do
            {
                switch (choice)
                {
                    case 0:
                        {
                            Console.ReadKey();
                        }
                        break;

                    case 1:
                        {
                            Console.WriteLine("Write the number you want to calculate");
                            int side = int.Parse(Console.ReadLine());

                            Square square = new Square(side);
                            square.Side = side;
                            square.CalcArea();
                        }
                        break;
                    case 2:
                        {
                            Console.WriteLine("Write the width");
                            int width = int.Parse(Console.ReadLine());

                            Console.WriteLine("Write the length");
                            int length = int.Parse(Console.ReadLine());

                            Rectangular rectangular = new Rectangular(width, length);
                            rectangular.Width = width;
                            rectangular.Length = length;

                            rectangular.CalcArea();
                        }
                        break;

                    default:
                        break;
                }

            } while (choice<0 || choice>2);
           

        }
        static int GetMetodInt(string desc, int min, int max)
        {
            int input;
            do
            {
                Console.Write(desc);
                input = int.Parse(Console.ReadLine());

            } while (input<=min || input>max);
            return input;
        }
    }
}
