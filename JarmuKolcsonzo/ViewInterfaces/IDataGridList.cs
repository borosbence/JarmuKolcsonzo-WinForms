using JarmuKolcsonzo.Views;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JarmuKolcsonzo.ViewInterfaces
{
    interface IDataGridList<G>
    {
        BindingList<G> bindingList { get; set; }
        int pageNumber { get; set; }
        int itemsPerPage { get; set; }
        string search { get; }
        string sortBy { get; set; }
        bool ascending { get; set; }
        int totalItems { set;}
    }
}
