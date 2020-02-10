using JarmuKolcsonzo.Models;
using JarmuKolcsonzo.Repositories;
using JarmuKolcsonzo.ViewInterfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JarmuKolcsonzo.Presenters
{
    public class JarmuKategoriaPresenter
    {
        IJarmuKategoriaView view;
        JarmuKategoriaRepository repo = new JarmuKategoriaRepository();

        public JarmuKategoriaPresenter(IJarmuKategoriaView param)
        {
            view = param;
        }

        public void Save(jarmukategoria jk)
        {
            view.errorMessage = null;

            if (repo.Exists(jk))
            {
                try
                {
                    repo.Update(jk);
                }
                catch (Exception ex)
                {
                    view.errorMessage = ex.Message;
                }
            }
            else
            {
                try
                {
                    repo.Insert(jk);
                }
                catch (Exception ex)
                {
                    view.errorMessage = ex.Message;
                }
            }
        }
    }
}
