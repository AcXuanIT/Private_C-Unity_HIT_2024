using System.Globalization;
using System.Runtime.CompilerServices;

namespace Cau3
{
    internal class Program
    {
        static Dictionary<string, Dictionary<string, int>> list = new Dictionary<string, Dictionary<string, int>>();

        static void ADD()
        {
            Console.WriteLine("Ten nhan vien ban hang : ");
            string name = Console.ReadLine();
            
            if (!list.ContainsKey(name))
                list[name] = new Dictionary<string, int>();

            Console.WriteLine("Nhap so san pham : ");
            int sl = int.Parse(Console.ReadLine());

            string nameSP = null;
            int soLuong = 0;
            while (sl > 0)
            {
                Console.WriteLine("Nhap ten san pham : ");
                nameSP = Console.ReadLine();
                Console.WriteLine("Nhap so luong san pham : ");
                soLuong = int.Parse(Console.ReadLine());

                if (!list[name].ContainsKey(nameSP))
                {
                    list[name].Add(nameSP, soLuong);
                }
                else
                {
                    list[name][nameSP] += soLuong;
                }
                sl--;
            }
        }

        static void ThemNV()
        {
            Console.WriteLine("Nhap so luong nhan vien muon them :");
            int sl = int.Parse(Console.ReadLine());

            while(sl > 0)
            {
                ADD();
                sl--;
            }
        }
        static void PRINT()
        {
            foreach (var key in list)
            {
                Console.WriteLine($"Ten NV: {key.Key} ");
                foreach (var sp in key.Value)
                    Console.WriteLine($"        Ten SP : {sp.Key}, So Luong : {sp.Value}");
            }
        }
        static void NVBanNhieuNhat()
        {
            string maxNV = null;
            int maxSL = 0;

            foreach (var nv in list)
            {
                int sum = 0;
                foreach(var sp in nv.Value)
                {
                    sum += sp.Value;
                }
                if(sum > maxSL)
                {
                    maxSL = sum;
                    maxNV = nv.Key;
                }
            }

            Console.WriteLine("Nhan vien ban nhieu hang nhat :" + maxNV);
        }

        static void SPBanChayNhat()
        {
            Dictionary<string, int> dsSP = new Dictionary<string, int>();

            foreach(var nv in list)
            {
                foreach(var sp in nv.Value)
                {
                    if (!dsSP.ContainsKey(sp.Key))
                    {
                        dsSP.Add(sp.Key, sp.Value);
                    }
                    else
                    {
                        dsSP[sp.Key] += sp.Value;
                    }
                }
            }
            
            string maxSP = null;
            int maxSL = 0;
            foreach(var sp in dsSP)
            {
                if (sp.Value > maxSL)
                    maxSP = sp.Key;
            }

            Console.WriteLine("San Pham ban chay nhat : " + maxSP);
            
        }
        static void Main(string[] args)
        {
            ThemNV();
            PRINT();

            NVBanNhieuNhat();
            SPBanChayNhat();
        }
    }
}
