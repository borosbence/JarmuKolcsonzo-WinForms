using JarmuKolcsonzo.Repositories;
using JarmuKolcsonzo.ViewInterfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JarmuKolcsonzo.Presenters
{
    public class JarmuPresenter
    {
        IJarmuView view;
        JarmuKategoriaRepository repo = new JarmuKategoriaRepository();

        public JarmuPresenter(IJarmuView param)
        {
            view = param;
        }

        public void LoadData()
        {
            view.jarmukategoriaList = repo.GetAllJarmuKategoria();
        }
    }
}
