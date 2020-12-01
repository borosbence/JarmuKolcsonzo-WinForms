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
            this.jarmu = new HashSet<jarmu>();
            this.megnevezes = nev;
            this.ferohely = ferohely;
        }
    }
}
