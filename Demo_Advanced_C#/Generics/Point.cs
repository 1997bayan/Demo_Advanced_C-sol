using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_Advanced_C_.Generics
{
    internal class Point : IComparable<Point>
    {
    

        public int X { get; set; }
        public int Y { get; set; }

        public Point(int x, int y)
        {
            X = x;
            Y = y;
        }

        public override string ToString()
        {
            return $"{X} , {Y}";
        }

        public int CompareTo(Point? other)
        {
            //There are 3 cases for point:
            //1- Point
            //2- object from class inherit from point
            //3-Null
            if (other == null) return 1 ;
            if (X == other.X ) return Y.CompareTo(other.Y);
            else return X.CompareTo(other.X);
               
        }

        //public int CompareTo(object? obj)
        //{
        //    if (obj is Point passedPoint) 
        //    {
        //        if (this.X == passedPoint.X)
        //        { 
        //            return this.Y.CompareTo(passedPoint.Y);

        //        }

        //        else
        //        {
        //             return this.X.CompareTo(passedPoint.X);

        //        }
        //    }
        //    return 1;
        //}
    }
}
