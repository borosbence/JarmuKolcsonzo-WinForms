using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JarmuKolcsonzo.Models
{
    public partial class jarmu_tipus
    {
        public jarmu_tipus(string nev, int ferohely)
        {
            jarmu = new HashSet<jarmu>();
            megnevezes = nev;
            this.ferohely = ferohely;
        }
    }
}
