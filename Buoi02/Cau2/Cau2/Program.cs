using System;

namespace Cau2
{
    internal class Program
    {
        static double v0 = 20;
        static double g = 9.8;
        static double radian = 30 * Math.PI / 180;
        static void phanA()
        {
            double v0x = v0 * Math.Cos(radian);
            double v0y = v0 * Math.Sin(radian);

            Console.WriteLine("Thanh phan van toc theo phuong ngang: " + v0x);
            Console.WriteLine("Thanh phan van toc theo phuong doc: " + v0y);
        }
        static void phanB()
        {
            double v0y = v0 * Math.Sin(radian);
            double tmax = v0y / g;

            Console.WriteLine("Thoi gian len den diem cao nhat : " + tmax);
        }
        static void phanC()
        {
            double v0y = v0 * Math.Sin(radian);
            double tmax = v0y / g;
            double h = v0y * tmax - (g * tmax * tmax) / 2;

            Console.WriteLine("Chieu cao cuc dai : " + h);
        }
        static void phanD()
        {
            double v0x = v0 * Math.Cos(radian);
            double v0y = v0 * Math.Sin(radian);
            double ttol = 2 * (v0y / g);
            double R = v0x * ttol;

            Console.WriteLine("Quang duong ngang vat di duoc : " + R);
        }
        static void Main(string[] args)
        {
            phanA();
            phanB();
            phanC();
            phanD();
        }
    }
}
