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
        IUgyfelView view;
        UgyfelRepository repo = new UgyfelRepository();

        public UgyfelPresenter(IUgyfelView param)
        {
            view = param;
        }

        public void Save(ugyfel uf)
        {
            view.errorVnev = null;
            view.errorKnev = null;
            view.errorVaros = null;
            view.errorIrszam = null;
            view.errorCim = null;
            view.errorTelefon = null;
            view.errorEmail = null;

            bool helyes = true;
            if (string.IsNullOrEmpty(uf.vezeteknev))
            {
                view.errorVnev = Resources.KotelezoMezo;
                helyes = false;
            }
            if (string.IsNullOrEmpty(uf.keresztnev))
            {
                view.errorKnev = Resources.KotelezoMezo;
                helyes = false;
            }
            if (string.IsNullOrEmpty(uf.varos))
            {
                view.errorVaros = Resources.KotelezoMezo;
                helyes = false;
            }
            if (uf.irszam < 1)
            {
                view.errorIrszam = Resources.KotelezoMezo;
                helyes = false;
            }
            if (string.IsNullOrEmpty(uf.cim))
            {
                view.errorCim = Resources.KotelezoMezo;
                helyes = false;
            }
            if (string.IsNullOrEmpty(uf.telefonszam))
            {
                view.errorTelefon = Resources.KotelezoMezo;
                helyes = false;
            }
            if (string.IsNullOrEmpty(uf.email))
            {
                view.errorEmail = Resources.KotelezoMezo;
                helyes = false;
            }
            else
            {
                try
                {
                    new MailAddress(uf.email);
                }
                catch (Exception)
                {
                    view.errorEmail = Resources.NemEmail;
                }
            }

            // Repo ellenőrzés
            if (helyes)
            {
                if (repo.Exists(uf))
                {
                    try
                    {
                        repo.Update(uf);
                    }
                    catch (Exception ex)
                    {
                        view.errorVnev = ex.Message;
                    }
                }
                else
                {
                    try
                    {
                        repo.Insert(uf);
                    }
                    catch (Exception ex)
                    {
                        view.errorVnev = ex.Message;
                    }
                }
            }
        }
    }
}
