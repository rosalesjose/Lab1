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
                double Area;
                Area = Width * Length;

                double Perimeter;
                Perimeter = (Width * 2) + (Length * 2);

                double Volume;
                Volume = Area * Height;


                //Output

                Console.WriteLine("Area: {0}", Area);

                Console.WriteLine("Permieter: {0}", Perimeter);

                Console.WriteLine("Height: {0}", Height);

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
    }
}
