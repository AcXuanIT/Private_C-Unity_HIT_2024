using System;

namespace Cau1
{
    internal class Program
    {

        static double phanA()
        {
            double t = 2.125; // thoi gian
            double A = 9; // bien do
            double w = 5 * Math.PI;
            double x0 =A * Math.Cos(Math.PI / 2);
            double T = (2 * Math.PI) / w;

            double s = (int)(4 * t / T) * A;
            double s1 = A * Math.Cos(5 * Math.PI * 0.025 );

            return s + (9 - s1);
        }
        static double phanB(double a, double b, double t)
        {
            double x0 = a * Math.Cos(Math.PI / 2);
            double T = 2 / b;
            double dt = (int)(4 * t / T);
  
            double d = dt * a;
            double x01 = 0;
            if(dt*T/4 != t)
            {
                x01 = a * Math.Cos(b * Math.PI * t + Math.PI / 2);
                double o = b * Math.PI * (t - dt * T/4) ;

                if((o > 0 && o < Math.PI / 2) || (o > Math.PI && o < 3 * Math.PI / 2))
                    d = d + (a + x01);
                else
                    d = d + x01;
            }

            return d;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Quang duong vat di duoc la :" + phanA());
            double a = 9;
            double b = 2;
            double t = 2;
            Console.WriteLine("Quang duong vat A di duoc sau t la : " + phanB(9,5,2.125));
        }
    }
}
