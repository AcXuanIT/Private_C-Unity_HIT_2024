using System.Collections.Generic;

namespace HITBank
{
    internal class Program
    {
        static void Main(string[] args)
        {
            BankManager bankManager = new BankManager();
            bankManager.fakeData();
            while (true)
            {
                Console.Clear();
                bankManager.PrintAllHK();
                Console.WriteLine("1.Gui Tien");
                Console.WriteLine("2.Rut Tien");
                Console.WriteLine("3.Them Khach Hang");
                Console.WriteLine("4.Xoa Khach Hang");
                Console.WriteLine("0.Thoat");
                int luuChon = int.Parse(Console.ReadLine());
                if(luuChon == 0)
                {
                    break;
                }
                if(luuChon == 1)
                {
                    Console.WriteLine("Nhap stk gui tien : ");
                    string stk = Console.ReadLine();
                    Console.WriteLine("Nhap so tien can gui :");
                    int tienRut = int.Parse(Console.ReadLine());
                    bankManager.guiTien(stk, tienRut);
                }
                if(luuChon == 2)
                {
                    Console.WriteLine("Nhap stk rut tien : ");
                    string stk = Console.ReadLine();
                    Console.WriteLine("Nhap so tien can rut :");
                    int tienRut = int.Parse(Console.ReadLine());
                    bankManager.rutTien(stk,tienRut);
                }
            }
        }
    }
}
