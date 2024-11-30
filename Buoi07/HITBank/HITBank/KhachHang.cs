using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HITBank
{
    internal class KhachHang
    {
        private string nameKH;
        private int soTKBank = 0;

        public KhachHang(string nameKH, int soTKBank, AccBank[] listBank)
        {
            this.nameKH = nameKH;
            this.soTKBank = soTKBank;
            this.listBank = listBank;
        }
        public string name
        {
            get
            {
                return this.nameKH;
            }
        }
        private AccBank[] listBank = new AccBank[4];
        public void AddBank(AccBank newBank)
        {
            if (this.soTKBank == 4)
                return;
            listBank[soTKBank] = newBank;
            soTKBank++;
        }

        public AccBank GetAccountBank(string soTK)
        {
            for(int i=0;i<this.soTKBank;i++)
                if (listBank[i].TK ==  soTK)
                    return listBank[i];
            return null;
        }

        public void PrintAllAccount()
        {
            int tongSoTien = 0;
            Console.WriteLine($"Ten TK: {this.nameKH}");
            Console.WriteLine("Thong tin tai khoan :");
            for (int i = 0; i < this.soTKBank; i++)
            {
                Console.WriteLine(listBank[i].print());
                tongSoTien += listBank[i].Sodu;
            }
            Console.WriteLine($"Tong so tien dang co: {tongSoTien}");
        }

    }
}
