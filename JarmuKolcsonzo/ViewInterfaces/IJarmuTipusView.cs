using JarmuKolcsonzo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JarmuKolcsonzo.ViewInterfaces
{
    public interface IJarmuTipusView
    {
        jarmu_tipus tipus { get; set; }
        string errorMessage { get; set; }
    }
}
