using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JarmuKolcsonzo.Models
{
    public partial class rendeles
    {
        public rendeles(
            int ugyfelId,
            int jarmuId,
            DateTime datum)
        {
            this.ugyfel_id = ugyfelId;
            this.jarmu_id = jarmuId;
            this.datum = datum.Date;
        }

        public rendeles()
        {

        }
    }
}
