using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;




namespace ConsoleApp4
{


    public abstract class Shape{
        public double pi = Math.PI;

        public double  x {get;set;}
        public double y {set; get;} 
        public double z {set; get;}
        public double w  {set; get;}
        public  Shape():this(0,0,0,0)
        {}
        public Shape(double x,double y,double z, double w){
            this.x = x;
            this.y = y;
            this.z = z;
            this.w = w;
                
        }
        public abstract  double Area();
    }


    public class Circle:Shape{
        public Circle(double radius):base(radius,0,0,0){
            this.x = radius;
        }

        public override double Area() =>  2 * base.pi * Math.Pow(base.x, 2);

        public override string ToString() => $"Circle Area: {Area():F2} ";

    }


    public class Triangle:Shape{
        public Triangle(double bases,double height):base(bases,height,0,0){
            this.x=bases;
            this.y=height;
        }

        public override double Area() => 0.5 * base.x * base.y;

        public override string ToString() => $"Triangle Area: {Area():F2} ";
    }


    public class Square:Shape{
        public Square(double side):base(side,0,0,0){
            this.x = side;
        }

        public override double Area() =>  base.x * base.x;

        public override string ToString() => $"Square Area: {Area():F2} ";

    }






    // public class Shape:ShapeArea{

    //     private const double PI = Math.PI;
    //     private double radius;
    //     private double height;
    //     private double bases;
    //     private double a_base;
    //     private double b_base;

    //     private double GetRadius() { return radius; }
    //     private double GetHeight() { return height; }
    //     private double GetBases() { return bases; }
    //     private double GetA_base() { return a_base; }

    //      private double GetB_base() { return b_base; }
    //      public Shape(){}

    //         //
    //         // summary :
    //         //         Calculating the circle
    //         //       
    //     public Shape(double radius) => SetRadius(radius);
        
    //         //
    //         // Summary :
    //         //      calculating the 
    //     public Shape(double height, double bases) {
    //         // 
    //         // summary :
    //         //         Use this when you want to calculate the triangle
    //         // return  : 
    //         //
    //         SetHeight(height);
    //         SetBases(bases);
    //     }

    //     public Shape(double a_base, double b_base, double height, double bases) {
    //         /// When you want to calculate the trapezium
    //         SetA_base(a_base);
    //         SetB_base(b_base);
    //         SetHeight(height); 
    //         SetBases(bases);

    //     }


    //      private void SetRadius(double radius) { this.radius = radius;}
    //      private void SetHeight(double height) { this.height = height;}
    //      private void SetBases(double bases) { this.bases = bases;}
    //      private void SetA_base(double a_base) { this.a_base = a_base;}
    //      private void SetB_base(double b_base) { this.b_base = b_base;}

    //     public override double CircleArea(double radius)
    //     {
    //         return 2*PI * Math.Pow(radius,2);
    //     }

    //     public override double SquareArea(double side)
    //     {
    //         return Math.Pow(side,2);
    //     }

    //     public override double TriangleArea(double height, double bases)
    //     {
    //         return 0.5 * (height*bases);
    //     }

    //     public override double TrapeziodArea(double a_base, double b_base, double height)
    //     {
    //         return 0.5 *(a_base + b_base)*height;
    //     }

    //     public bool Result(int choice){
            
    //         switch (choice){
    //             case 1:
    //                 Console.WriteLine("Trapeziod Area : {0}",TrapeziodArea(GetA_base(), GetB_base(), GetHeight()));
    //                 return false;
    //             case 2:
    //                 Console.WriteLine("Square Area : {0}",SquareArea(GetRadius()));
    //                 return false;
    //             case 3:
    //                 Console.WriteLine("Triangle Area : {0}",TriangleArea(GetHeight(),GetBases()));
    //                 return false;
    //             case 4:
    //                 Console.WriteLine("Circle Area : {0}",CircleArea(GetRadius()));
    //                 return false;
    //             default:
    //                 System.Console.WriteLine("Invalid Choice");
    //                 return true;
    //         }
                
           
    //     }

    // }
    
}