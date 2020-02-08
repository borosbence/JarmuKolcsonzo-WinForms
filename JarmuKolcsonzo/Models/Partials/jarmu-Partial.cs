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
            int kategoriaId,
            string tipus,
            string modell,
            int ferohely,
            double fogyasztas,
            bool elerheto,
            bool szervizben,
            DateTime szervizDatum,
            DateTime muszakiDatum,
            DateTime beszerzesDatum)
        {
            this.rendszam = rendszam;
            this.kategoriaId = kategoriaId;
            this.tipus = tipus;
            this.modell = modell;
            this.ferohely = ferohely;
            this.fogyasztas = fogyasztas;
            this.elerheto = elerheto;
            this.szervizben = szervizben;
            this.szervizDatum = szervizDatum;
            this.muszakiDatum = muszakiDatum;
            this.beszerzesDatum = beszerzesDatum;
        }

        public jarmu()
        {

        }
    }
}
