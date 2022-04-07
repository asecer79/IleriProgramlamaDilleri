using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week06
{
    public static class MyExtensions
    {
        public static int SessizSay(this string text)
        {
            int cnt = 0;

            foreach (var letter in text)
            {
                var res = letter.SessizMi();
                if (res)
                    cnt++;

            }

            return cnt;
        }

        public static bool SessizMi(this char letter)
        {
            return letter == 'A' ||
                   letter == 'a' ||
                   letter == 'O' ||
                   letter == 'o' ||
                   letter == 'U' ||
                   letter == 'u' ||
                   letter == 'E' ||
                   letter == 'e' ||
                   letter == 'I' ||
                   letter == 'ı' ||
                   letter == 'Ö' ||
                   letter == 'ö' ||
                   letter == 'Ü' ||
                   letter == 'ü' ||
                   letter == 'İ' ||
                   letter == 'i'
                ? false
                : true;
        }

        public static int ToInt32(this string number)
        {
            return Convert.ToInt32(number);
        }
        public static double ToDouble(this string number)
        {
            return Convert.ToDouble(number);
        }

        public static string ToString2(this Point2D point)
        {
            return $"({point.X}, {point.Y})";
        }

        public static double Distance(this Point2D point1, Point2D point2)
        {
            return Math.Sqrt(Math.Pow((point1.X - point2.X), 2) + Math.Pow((point1.Y - point2.Y), 2));
        }

        public static double Norm(this Point2D point1)
        {
            return Math.Sqrt(Math.Pow(point1.X, 2) + Math.Pow(point1.Y, 2));
        }

        public static Point2D Sum(this Point2D point1, Point2D point2)
        {
            return new Point2D()
            {
                X = point1.X + point2.X,
                Y = point1.Y + point2.Y,

            };
        }
    }
}
