using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HITBank
{
    internal abstract class AccBank
    {
        private string soTK;
        private int sodu;
        public string TK
        {
            get
            {
                return this.soTK;
            }
            set
            {
                this.soTK = value;
            }
        }
        public int Sodu
        {
            get
            {
                return this.sodu;
            }
            set
            {
                this.sodu = value;
            }
        }
        public AccBank(string soTK, int sodu)
        {
            this.soTK = soTK;
            this.sodu = sodu;
        }
        public void guiTien(int tienGui)
        {
            this.sodu += tienGui;
        }

        public virtual void rutTien(int tienRut)
        {
            if(this.sodu >= tienRut ) 
                this.sodu -= tienRut;
        }

        public int checkSoDu()
        {
            return this.sodu;
        }

        public abstract string print();
    }
}
