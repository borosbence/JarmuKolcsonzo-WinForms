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
        public int ugyfelId { get; set; }
        public string ugyfelNev { get; set; }
        public string ugyfelTelefonszam { get; set; }
        public string ugyfelEmail { get; set; }
        public int ugyfelPont { get; set; }
        public int jarmuId { get; set; }
        public string jarmuRendszam { get; set; }
        public int? jarmuDij { get; set; }
        public DateTime rendelesDatum { get; set; }

        public rendelesVM(
            int id,
            int ugyfelId,
            string nev, string telefonszam,
            string email, int pont,
            int jarmuId,
            string rendszam, int? ferohely, 
            DateTime datum)
        {
            rendelesId = id;
            this.ugyfelId = ugyfelId;
            ugyfelNev = nev;
            ugyfelTelefonszam = telefonszam;
            ugyfelEmail = email;
            ugyfelPont = pont;
            this.jarmuId = jarmuId;
            jarmuRendszam = rendszam;
            jarmuDij = ferohely;
            rendelesDatum = datum;
        }

        public rendelesVM(string nev, string rendszam, DateTime datum)
        {
            ugyfelNev = nev;
            jarmuRendszam = rendszam;
            rendelesDatum = datum;
        }
    }
}
