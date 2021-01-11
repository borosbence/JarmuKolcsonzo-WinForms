using JarmuKolcsonzo.Models;
using JarmuKolcsonzo.ViewModels;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JarmuKolcsonzo.ViewInterfaces
{
    public interface IRendelesView
    {
        rendelesVM rendelesVM { get; set; }
        string errorUgyfelNev { set; }
        string errorJarmuRendszam { set; }
        string ugyfelTelefonszam { set; }
        string ugyfelEmail { set; }
        string jarmuTipus { set; }
        int jarmuFerohely { set; }
        int jarmuDij { set; }
        string[] ugyfelList { set; }
        string[] jarmuList { set; }
    }
}
