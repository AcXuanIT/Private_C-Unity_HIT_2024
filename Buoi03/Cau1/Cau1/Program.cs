namespace Cau1
{
    internal class Program
    {
        static void phanA1()
        {
            int a, b;
            Console.WriteLine("Nhap chieu rong : ");
            a = int.Parse(Console.ReadLine());
            Console.WriteLine("Nhap chieu dai : ");
            b = int.Parse(Console.ReadLine());

            for (int i = 1; i <= b; i++)
            {
                for (int j = 1; j <= a; j++)
                {
                    if (i == 1 || i == b)
                        Console.Write("*");
                    else
                        if (j == 1 || j == a)
                            Console.Write("*");
                        else 
                            Console.Write(" ");
                }
                Console.WriteLine();
            }
        }

        static void phanA2()
        {
            int c;
            Console.WriteLine("Nhap chieu dai canh tam giac : ");
            c = int.Parse(Console.ReadLine());

            for(int i = 0; i < c; i++)
            {
                if (i == c-1)
                    for (int j = 1; j <= c * 2 - 1; j++)
                        Console.Write("*");
                else
                    for (int j = 1; j <= c * 2 - 1; j++)
                        if (j == (c - i) || j == (c + i))
                            Console.Write("*");
                        else
                            Console.Write(" ");
                Console.WriteLine("");
            }
        }
        static void Main(string[] args)
        {
            phanA1();
            phanA2();
        }
    }
}
