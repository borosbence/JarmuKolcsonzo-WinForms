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
        string errorVnev { get; set; }
        string errorKnev { get; set; }
        string errorVaros { get; set; }
        string errorIrszam { get; set; }
        string errorCim { get; set; }
        string errorTelefon{ get; set; }
        string errorEmail { get; set; }

    }
}
