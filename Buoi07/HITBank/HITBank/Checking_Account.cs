using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HITBank
{
    internal class Checking_Account : AccBank
    {
        private Saving_Account tkLienKet = null;

        public Checking_Account(string soTK, int sodu) : base(soTK,sodu) { }
        public override void rutTien(int tienRut)
        {
            base.rutTien(tienRut);
            if(base.Sodu < tienRut)
            {
                tienRut = tienRut - base.Sodu;
                base.Sodu = 0;
                tkLienKet.rutTien(tienRut);
            }
        }
        public override string print()
        {
            return $"So TK: {base.TK} So Du: {base.Sodu}";
        }
    }
}
