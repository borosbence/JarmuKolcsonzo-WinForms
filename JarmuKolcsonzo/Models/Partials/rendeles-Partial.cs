using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JarmuKolcsonzo.Models
{
    public partial class rendeles
    {
        public rendeles(int ugyfelId, int jarmuId, DateTime datum, int napok, decimal ar)
        {
            ugyfel_id = ugyfelId;
            jarmu_id = jarmuId;
            this.datum = datum.Date;
            napok_szama = napok;
            this.ar = ar;
        }
        public rendeles()
        {

        }
    }
}
