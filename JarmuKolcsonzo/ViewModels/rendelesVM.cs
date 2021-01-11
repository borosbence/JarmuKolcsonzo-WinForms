using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JarmuKolcsonzo.ViewModels
{
    public class rendelesVM
    {
        public int rendelesId { get; set; }
        public DateTime rendelesDatum { get; set; }
        public int rendelesNapok { get; set; }
        public decimal rendelesAr { get; set; }
        public int ugyfelId { get; set; }
        public string ugyfelNev { get; set; }
        public decimal ugyfelPont { get; set; }
        public int jarmuId { get; set; }
        public string jarmuRendszam { get; set; }

        public rendelesVM(
            int rendelesId, DateTime rendelesDatum, 
            int rendelesNapok, decimal rendelesAr,
            int ugyfelId,
            string ugyfelNev, decimal ugyfelPont,
            int jarmuId, string jarmuRendszam)
        {
            this.rendelesId = rendelesId;
            this.rendelesDatum = rendelesDatum;
            this.rendelesNapok = rendelesNapok;
            this.rendelesAr = rendelesAr;
            
            this.ugyfelId = ugyfelId;
            this.ugyfelNev = ugyfelNev;
            this.ugyfelPont = ugyfelPont;

            this.jarmuId = jarmuId;
            this.jarmuRendszam = jarmuRendszam;
        }

        public DateTime HatarIdo => rendelesDatum.AddDays(rendelesNapok);
    }
}
