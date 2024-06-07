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
            Shape shape =  new Shape();
            
            Console.WriteLine("Please select a shape \n 1. Tripezium \n 2. Square \n 3. Triangle \n 4. Circle \n 5. Rectangle");
            int input = int.Parse(Console.ReadLine());
      
           

            do
            {
                switch (input)
                {
                    case 1:
                         Console.WriteLine("Please enter the tripezium A length value : ");
                         shape.SetA_base(double.Parse(Console.ReadLine()));
                         Console.WriteLine("Please enter the tripezium B length value : ");
                         shape.SetB_base(double.Parse(Console.ReadLine()));
                         Console.WriteLine("Please enter the tripezium breadth value  : ");
                         shape.SetBases(double.Parse(Console.ReadLine()));
                         Console.WriteLine("Please enter the tripezium height value   : ");
                         shape.SetHeight(double.Parse(Console.ReadLine()));

                        
                         
                         break;
                    case 2:
                         Console.WriteLine("Please enter the square side value : ");
                         shape.SetRadius(double.Parse(Console.ReadLine()));
                        break;
                         



                    default:
                    break;
                }



                // if (shape == 1)
                // {

                //     double a = 0, b = 0, h = 0;

                //     Console.WriteLine("Please enter the tripezium length value");
                //     a = double.Parse(Console.ReadLine());
                //     b = double.Parse(Console.ReadLine());
                //     Console.WriteLine("Please enter the tripezium height value");
                //     h = double.Parse(Console.ReadLine());

                //     Tripezium tripezium = new Tripezium();

                //     Console.WriteLine("The Area is: " + tripezium.getArea(a, b, h));
                //     break;
                // }

                // else if (shape == 2)
                // {
                //     Console.WriteLine("Please enter the square side value");
                //     double s = double.Parse(Console.ReadLine());

                //     Square square = new Square();

                //     Console.WriteLine("The Area is: " + square.getArea(s));
                //     break;
                // }

                // else if (shape == 3)
                // {
                //     Console.WriteLine("Please enter the triangle base value");
                //     double b = double.Parse(Console.ReadLine());
                //     Console.WriteLine("Please enter the triangle height value");
                //     double h = double.Parse(Console.ReadLine());

                //     Triangle triangle = new Triangle();

                //     Console.WriteLine("The Area is: " + triangle.getArea(b, h));
                //     break;
                // }

                // else if (shape == 4)
                // {
                //     Console.WriteLine("Please enter the circle radius value");
                //     double r = double.Parse(Console.ReadLine());
            
             

                //     Circle circle = new Circle();

                //     Console.WriteLine("The Area is: " + circle.getArea(r));
                //     break;
                // }

                // else if (shape == 5)
                // {
                //     Console.WriteLine("Please enter the rectangle length value");
                //     double l = double.Parse(Console.ReadLine());
                //     Console.WriteLine("Please enter the rectangle width value");
                //     double w = double.Parse(Console.ReadLine());



                //     Rectangle rectangle = new Rectangle();

                //     Console.WriteLine("The Area is: " + rectangle.getArea(l, w));
                //     break;
                // }

                // else 
                // {

                //     Console.WriteLine("Invalid selection \n Please select a correct shape: \n 1. Tripezium \n 2. Square \n 3. Triangle \n 4. Circle \n 5. Rectangle");
                //     shape = int.Parse(Console.ReadLine());
                //     looper = false;

                // }

            }while (looper);
        }
    
    }

}
