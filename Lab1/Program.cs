using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1
{
    class Program
    {
        static void Main(string[] args)
        {
            bool runprogram = true;
            while (runprogram)
            {
                //Input
                double Width, Length, Height;
                
                Console.WriteLine("Please enter the width");
                Width = double.Parse(Console.ReadLine());

                Console.WriteLine("Please enter the length");
                Length = double.Parse(Console.ReadLine());

                Console.WriteLine("Please enter the height");
                Height = double.Parse(Console.ReadLine());

                //Process
                double MyArea = GetArea(Width, Length);
                double MyPerimeter = GetPerimeter(Width,Length);
                double MyVolume = GetVolume(Width, Length, Height);

                //Output
                Console.WriteLine("Area: {0}", MyArea);

                Console.WriteLine("Permieter: {0}", MyPerimeter);

                Console.WriteLine("Volume: {0}", MyVolume);

                Console.WriteLine("Continue? (y/n)");

                //Repeat program        
                char DoAgain = char.Parse(Console.ReadLine());

                if (DoAgain == 'y' || DoAgain == 'Y')
                {
                    runprogram = true;
                    Console.Clear(); 
                }
                else
                {
                    runprogram = false;
                }
            }
        }
        //public static string ReadUserInput(string UserPrompt)
        //{

        //}

        public static double GetArea (double Width, double Length)
        {
            //double Area = Width* Length;           
            //return Area;
            return Length * Width;
        }
        
        public static double GetPerimeter (double Width, double Length)
        {
            double Perimeter = (Width * 2) + (Length * 2);
            return Perimeter;
        }

        public static double GetVolume (double Width, double Length, double Height)
        {
            double Volume = (Width * Length) * Height;
            return Volume;
        }
    }
}
