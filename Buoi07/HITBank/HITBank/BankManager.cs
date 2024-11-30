using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace HITBank
{
    internal class BankManager
    {
        private List<KhachHang> listHK = new List<KhachHang> ();

        public BankManager() { }
        public void fakeData()
        {
            AccBank[] listBank = new AccBank[4];
            listBank[0] = new Saving_Account("2005", 1000000, 5);
            listBank[1] = new Saving_Account("2004", 1500000, 10);
            listBank[2] = new Checking_Account("2003", 5000000);
            listHK.Add(new KhachHang("Nguyen Van A",3,listBank));

            AccBank[] listBank1 = new AccBank[4];
            listBank1[0] = new Saving_Account("1005", 100000, 7);
            listBank1[1] = new Saving_Account("1004", 3500000, 12);
            listBank1[2] = new Checking_Account("1003", 7000000);
            listHK.Add(new KhachHang("Nguyen Thi B", 3, listBank1));
        }
        public void PrintAllHK()
        {
            for (int i = 0; i < listHK.Count; i++)
            {
                listHK[i].PrintAllAccount();
            }
        }
        public void AddHK(KhachHang newHK)
        {
            listHK.Add (newHK);
        }
        public void DeleteHK(KhachHang newHK)
        {
            listHK.Remove (newHK);
        }
        public void timKiemHKByName(string nameTK)
        {
            for(int i=0;i<listHK.Count;i++)
            {
                if (listHK[i].name == nameTK)
                {
                    listHK[i].PrintAllAccount();
                    break;
                }
            }
        }
        public AccBank timKiemHKBySTK(string soTK)
        {
            for (int i = 0; i < listHK.Count; i++)
            {
                AccBank bank = listHK[i].GetAccountBank(soTK);
                if (bank != null)
                    return bank;
            }
            return null;
        }
        public void guiTien(string stk, int tienGui)
        {
            AccBank bank = timKiemHKBySTK(stk);
            bank.guiTien(tienGui);
        }
        public void rutTien(string stk, int tienRut)
        {
            AccBank bank = timKiemHKBySTK(stk);
            bank.rutTien(tienRut);
        }

    }
}
