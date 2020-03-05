using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JarmuKolcsonzo.ViewModels
{
    class rendelesVM
    {
        public int rendelesId { get; set; }
        public int ugyfelNev { get; set; }
        public int ugyfelTelefonszam { get; set; }
        public int ugyfelEmail { get; set; }
        public int ugyfelPont { get; set; }
        public int jarmuRendszam { get; set; }
        public int jarmuFerohely { get; set; }
        public DateTime rendelesDatum { get; set; }
    }
}
