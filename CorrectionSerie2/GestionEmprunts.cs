using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CorrectionSerie2
{
    internal class GestionEmprunts
    {
        Dictionary<int,List<Emprunt>> tab;

        public GestionEmprunts()
        {
            tab = new Dictionary<int, List<Emprunt>>();
        }
        public bool AddEmprunt(Emprunt e)
        {
            List<Emprunt> liste;
            if (tab.Keys.Count == 0)
            {
                liste = new List<Emprunt>();
                liste.Add(e);
                tab.Add(e.CodeEmprunteur, liste);
                return true;
            }
            liste = tab[e.CodeEmprunteur];
            if (liste == null)
            {
                liste = new List<Emprunt>();
                liste.Add(e);
                tab.Add(e.CodeEmprunteur, liste);
                return true;
            }
            else
            {
                liste.Add(e);
                return true;
            }
            return false;
        }
        public bool DelEmprunt(int codeEmprunteur, int codeOuvrage)
        {
            List<Emprunt> liste = tab[codeEmprunteur];
            if (liste == null)
            {
                return false;
            }
            foreach (Emprunt e in liste)
            {
                if (e.CodeOuvrage == codeOuvrage)
                {
                    liste.Remove(e);
                    return true;
                }
            }
            return false;
        }
        public bool ModifyEmprunt(int codeEmprunteur, int codeOuvrage1, int codeOuvage2)
        {
            List<Emprunt> liste = tab[codeEmprunteur];
            if (liste == null)
            {
                return false;
            }
            foreach (Emprunt e in liste)
            {
                if (e.CodeOuvrage == codeOuvrage1)
                {
                    e.CodeOuvrage = codeOuvage2;
                    return true;
                }
            }
            return false;
        }
        public List<Emprunt> SearchEmprunts(int codeEmprunteur)
        {
            if (tab.Keys.Count == 0)
                return null;
           
            List<Emprunt> liste = tab[codeEmprunteur];
            return liste;

        }
        public bool ExistEmprunt(int codeEmprunteur, int codeOuvrage)
        {
            if (tab.Keys.Count == 0)
                return false;
            List<Emprunt> liste = tab[codeEmprunteur];
            foreach (Emprunt e in liste)
            {
                if (e.CodeOuvrage == codeOuvrage)
                    return true;
            }
            return false;
        }
        
    }
}
