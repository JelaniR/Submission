using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace RectangleApplication
{
    class Shape
    {
        public double sideTriA = 7;
        public double sideTriB = 8;
        //public double sideTriC = 9;
        public double sideOct = 4;
        public double sideSq = 4;

       

        //public double TriS()
        //{
        //    return (GetABC() / 2);
        //}
        
       

      
       
    }
    class Rectangle
    {
        //Member variables
        public double length;
        public double width;

       public void AcceptDetails()
        {
            length = 4.5;
            width = 3.5;
        }

        public double GetArea()
        {
            return length * width;
        }

        public void Display ()
        {
            WriteLine("Length : {0}", length);
            WriteLine("Width : {0}", width);
            WriteLine("Area : {0}", GetArea());
            ReadKey();
        }
    }
    class Triangle : Shape
    {

        public double GetABC()
        {
            return (sideTriA * sideTriB) / 2;
        }
        //public double TriArea()
        //{
        //    return Math.Sqrt(GetABC() * ((sideTriA - GetABC()) * (sideTriB - GetABC()) * (sideTriC - GetABC())));

        //}

    }

    class Square : Shape
    {
          public double SquareArea()
        {
            return sideSq * 2;
        }

    }
    class Octogon : Shape
    {
        public double OctArea()
        {
            return (2 * (1 + Math.Sqrt(2)) * (sideOct *2 ));
        }

    }
    class ExecuteShape
    {
        static void Main(string[] args)
        {
            Square s = new Square();
           
            Triangle t = new Triangle();
           Octogon o = new Octogon();
           
            WriteLine("The Square Area: {0}", s.SquareArea());
            WriteLine("The Triangle Area: {0}", t.GetABC());
            WriteLine("The Octagon Area: {0}", o.OctArea());
            ReadKey();


        }
    }
}
