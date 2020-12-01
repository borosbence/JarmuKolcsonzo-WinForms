using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JarmuKolcsonzo.Models
{
    public partial class jarmu
    {
        public jarmu(
            string rendszam,
            int tipusId,
            int dij,
            bool elerheto,
            DateTime szervizDatum)
        {
            this.rendszam = rendszam;
            this.tipus_id = tipusId;
            this.dij = dij;
            this.elerheto = elerheto;
            this.szerviz_datum = szervizDatum;
        }
    }
}
