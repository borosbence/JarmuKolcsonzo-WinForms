using JarmuKolcsonzo.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JarmuKolcsonzo.ViewInterfaces
{
    public interface IJarmuView
    {
        jarmu jarmu { get; set; }
        BindingList<jarmukategoria> jarmukategoriaList { get; set; }
        string errorRendszam { get; set; }
        string errorFerohely { get; set; }

    }
}
