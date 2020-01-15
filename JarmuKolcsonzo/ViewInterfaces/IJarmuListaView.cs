using JarmuKolcsonzo.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JarmuKolcsonzo.ViewInterfaces
{
    interface IJarmuListaView : IDataGridList<jarmu>
    {
        BindingList<jarmukategoria> jarmukategoriaList { get; set; }
    }
}
