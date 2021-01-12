using JarmuKolcsonzo.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JarmuKolcsonzo.ViewInterfaces
{
    public interface IUgyfelView
    {
        ugyfel ugyfel { get; set; }
        string errorVnev { set; }
        string errorKnev { set; }
        string errorVaros { set; }
        string errorCim { set; }
        string errorTelefon{ set; }
        string errorEmail { set; }
    }
}
