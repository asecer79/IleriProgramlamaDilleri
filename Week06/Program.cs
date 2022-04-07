

using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;

namespace Week06
{

    class Program
    {

        static void Main(string[] args)
        {

            //var x = Console.ReadLine();

            //var y = Console.ReadLine();

            //int z =x.ToInt32() +  y.ToInt32();

            //string name = "Ahmetcan";

            //var res = name.SessizSay();

            Point2D pointA = new Point2D()
            {
                X = -1,
                Y = 2,
            };

            Point2D pointB = new Point2D()
            {
                X = 1,
                Y = 2,
            };

            //var result = (20 * pointA + pointB * 2 - pointB).ToString2();

            //Console.WriteLine(pointB*pointA);

            //Console.WriteLine(result);


            Point2D np = (Point2D)"2,9";

            string sn = pointB;

            Console.WriteLine(np.ToString2());




            //Console.WriteLine(pointB.Sum(pointA).Sum(pointB).Sum(pointA).Norm());



            //Console.WriteLine(pointB.ToString());
            //Console.WriteLine(pointB.ToString2());

            //var dist1 = pointA.Distance(pointB);
            //var dist2 = pointB.Distance(pointA);

            //Console.WriteLine(dist1 + " - " + dist2);

            //Console.WriteLine(pointB.Norm());


        }
    }
}

