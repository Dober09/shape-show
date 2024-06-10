using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// namespace ConsoleApp4
// {
//     public abstract class Area
//     {

//         public double getArea(int a)
//         {
//             return 0;
//         }

//     }

//     public class Tripezium: Area
//     {

//         public double getArea(double a, double b, double h)
//         {

//             return 0.5 * (a + b) * h;

//         }

//     }

//     public class Square : Area
//     {

//         public double getArea(double s)
//         {

//             return s*s;

//         }

//     }

//     public class Triangle : Area
//     {

//         public double getArea(double b, double h)
//         {

//             return 0.5 * b * h;

//         }

//     }

//     public class Circle : Area
//     {
//         double pi = Math.PI;
//         public double getArea(double r)
//         {

//             return pi * r*r;

//         }

//     }

//     public class Rectangle : Area
//     {
//         public double getArea(double l, double w)
//         {

//             return  l * w;

//         }

//     }

// }

namespace ConsoleApp4
{
    public abstract class ShapeArea{
        public abstract double CircleArea(double radius);
        public abstract double SquareArea(double side);
        public abstract double TriangleArea(double height, double bases);

        public abstract double TrapeziodArea(double a_base,double b_base, double height);

    }
    public class Shape:ShapeArea{

        private const double PI = Math.PI;
        private double radius;
        private double height;
        private double bases;
        private double a_base;
        private double b_base;

        private double GetRadius() { return radius; }
        private double GetHeight() { return height; }
        private double GetBases() { return bases; }
        private double GetA_base() { return a_base; }

         private double GetB_base() { return b_base; }


         public void SetRadius(double radius) { this.radius = radius;}
         public void SetHeight(double height) { this.height = height;}
         public void SetBases(double bases) { this.bases = bases;}
         public void SetA_base(double a_base) { this.a_base = a_base;}
         public void SetB_base(double b_base) { this.b_base = b_base;}

        public override double CircleArea(double radius)
        {
            return 2*PI * Math.Pow(radius,2);
        }

        public override double SquareArea(double side)
        {
            return Math.Pow(side,2);
        }

        public override double TriangleArea(double height, double bases)
        {
            return 0.5 * (height*bases);
        }

        public override double TrapeziodArea(double a_base, double b_base, double height)
        {
            return 0.5 *(a_base + b_base)*height;
        }

        public bool Result(int choice){
            
            switch (choice){
                case 1:
                    Console.WriteLine("Trapeziod Area : {0}",TrapeziodArea(GetA_base(), GetB_base(), GetHeight()));
                    return false;
                case 2:
                    Console.WriteLine("Square Area : {0}",SquareArea(GetRadius()));
                    return false;
                case 3:
                    Console.WriteLine("Triangle Area : {0}",TriangleArea(GetHeight(),GetBases()));
                    return false;
                case 4:
                    Console.WriteLine("Circle Area : {0}",CircleArea(GetRadius()));
                    return false;
                default:
                    System.Console.WriteLine("Invalid Choice");
                    return true;
            }
                
           
        }

    }
    
}