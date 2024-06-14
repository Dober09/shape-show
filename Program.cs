using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    internal class Program
    {



        public static void Main(string[] args)

        {

            bool looper = true;
           



            while (looper)
            {

                Console.WriteLine("Please select a shape \n1 .Square \n2. Triangle \n3. Circle ");
                int input = int.Parse(Console.ReadLine());


                switch (input)
                {
                   
                    case 1:
                        Console.WriteLine("Please enter the square side value : ");
                    
                        Square square = new (double.Parse(Console.ReadLine()));
                        Console.WriteLine(square.ToString());
                        looper = !looper;
                        break;
                    case 2:
                        Console.WriteLine("Please enter the triangle base value");
                        double bases=(double.Parse((Console.ReadLine())));
                        Console.WriteLine("Please enter the triangle height value");
                        double height_2 =(double.Parse(Console.ReadLine()));
                        
                        Triangle triangle = new (bases, height_2);
                        Console.WriteLine(triangle.ToString());
                        looper = !looper;
                        break;
                    case 3:
                        Console.WriteLine("Please enter the circle radius value");
                        Circle circle = new ((double.Parse(Console.ReadLine())));
                        Console.WriteLine(circle.ToString());
                        looper = !looper;
                        break;

                    default:
                        Console.WriteLine("Enter the correct choose.");
                        break;
                }

            
            }



        }


    }

}
