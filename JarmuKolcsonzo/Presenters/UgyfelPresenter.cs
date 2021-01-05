using JarmuKolcsonzo.Models;
using JarmuKolcsonzo.Properties;
using JarmuKolcsonzo.Repositories;
using JarmuKolcsonzo.ViewInterfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace JarmuKolcsonzo.Presenters
{
    public class UgyfelPresenter
    {
        private IUgyfelView view;
        public UgyfelPresenter(IUgyfelView param)
        {
            view = param;
        }

        public bool ValidateData()
        {
            var valid = true;
            view.errorVnev = null;
            view.errorKnev = null;
            view.errorVaros = null;
            view.errorCim = null;
            view.errorTelefon = null;
            view.errorEmail = null;
            
            if (string.IsNullOrEmpty(view.ugyfel.vezeteknev))
            {
                view.errorVnev = Resources.KotelezoMezo;
                valid = false;
            }
            if (string.IsNullOrEmpty(view.ugyfel.keresztnev))
            {
                view.errorKnev = Resources.KotelezoMezo;
                valid = false;
            }
            if (string.IsNullOrEmpty(view.ugyfel.varos))
            {
                view.errorVaros = Resources.KotelezoMezo;
                valid = false;
            }
            if (string.IsNullOrEmpty(view.ugyfel.cim))
            {
                view.errorCim = Resources.KotelezoMezo;
                valid = false;
            }
            if (string.IsNullOrEmpty(view.ugyfel.telefonszam))
            {
                view.errorTelefon = Resources.KotelezoMezo;
                valid = false;
            }
            if (string.IsNullOrEmpty(view.ugyfel.email))
            {
                view.errorEmail = Resources.KotelezoMezo;
                valid = false;
            }
            else
            {
                try
                {
                    new MailAddress(view.ugyfel.email);
                }
                catch
                {
                    valid = false;
                    view.errorEmail = Resources.NemEmail;
                }
            }

            return valid;
        }
    }
}
