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
        jarmu jarmu { get; }
        BindingList<jarmukategoria> jarmukategoriaList { get; set; }
    }
}
