using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JarmuKolcsonzo.Models
{
    public partial class jarmukategoria
    {
        public jarmukategoria(string nev)
        {
            this.jarmu = new HashSet<jarmu>();
            this.kategoriaNev = nev;
        }
    }
}
