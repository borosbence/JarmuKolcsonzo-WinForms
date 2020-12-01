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
    public class JarmuTipusPresenter
    {
        IJarmuTipusView view;
        JarmuTipusRepository repo = new JarmuTipusRepository();

        public JarmuTipusPresenter(IJarmuTipusView param)
        {
            view = param;
        }

        public void Save(jarmu_tipus tipus)
        {
            view.errorMessage = null;

            if (repo.Exists(tipus))
            {
                try
                {
                    repo.Update(tipus);
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
                    repo.Insert(tipus);
                }
                catch (Exception ex)
                {
                    view.errorMessage = ex.Message;
                }
            }
        }
    }
}
