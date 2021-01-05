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
        string errorUgyfelNev { get; set; }
        string errorJarmuRendszam { get; set; }
    }
}
