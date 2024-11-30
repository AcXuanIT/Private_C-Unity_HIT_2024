using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HITBank 
{
    internal class Saving_Account : AccBank
    {
        private double laiSuat;
        public Saving_Account(string soTK, int sodu, int laiSuat) : base(soTK,sodu)
        {
            this.laiSuat = laiSuat;
        }
        public override string print()
        {      
            return $"So TK: {base.TK} So Du: {base.Sodu} Lai Suat: {this.laiSuat}";
        }
    }
}
