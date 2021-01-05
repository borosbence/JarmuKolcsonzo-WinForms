using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JarmuKolcsonzo.Models
{
    public partial class ugyfel
    {
        public ugyfel(
            string vnev,
            string knev,
            string varos,
            int irszam,
            string cim,
            string telefonszam,
            string email,
            int pont)
        {
            vezeteknev = vnev;
            keresztnev = knev;
            this.varos = varos;
            this.cim = cim;
            iranyitoszam = irszam;
            this.telefonszam = telefonszam;
            this.email = email;
            this.pont = pont;
            this.rendeles = new HashSet<rendeles>();
        }
    }
}
