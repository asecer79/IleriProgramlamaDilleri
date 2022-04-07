using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week06
{
    public class Point2D
    {
        public double X { get; set; }
        public double Y { get; set; }


        public override string ToString()
        {
            return $"({this.X}, {this.Y})";
        }

        public static Point2D operator + (Point2D point1, Point2D point2)
        {
            return new Point2D()
            {
                X = point1.X + point2.X,
                Y = point1.Y + point2.Y,

            };
        }

        public static Point2D operator -(Point2D point1, Point2D point2)
        {
            return new Point2D()
            {
                X = point1.X - point2.X,
                Y = point1.Y - point2.Y,

            };
        }
        public static Point2D operator *(double number, Point2D point)
        {
            return new Point2D()
            {
                X = number*point.X,
                Y = number*point.Y,

            };
        }
        public static Point2D operator *(Point2D point, double number)
        {
            return new Point2D()
            {
                X = number * point.X,
                Y = number * point.Y,

            };
        }

        public static double operator *(Point2D point1, Point2D point2)
        {
            return point1.X * point2.X + point1.Y * point2.Y;
        }

        // r,r
        public static explicit operator Point2D(string point)
        {
            var xPart = point.Split(',')[0].ToDouble();
            var yPart = point.Split(',')[1].ToDouble();

            return new Point2D()
            {
                X=xPart,
                Y=yPart

            };

        }

        public static implicit operator string(Point2D point)
        {
            return $"{point.X},{point.Y}";

        }
    }
}
