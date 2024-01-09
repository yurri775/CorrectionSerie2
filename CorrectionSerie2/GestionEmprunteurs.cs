using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CorrectionSerie2
{
    internal class GestionEmprunteurs
    {
        List<Emprunteur> liste;

        public GestionEmprunteurs()
        {
            liste = new List<Emprunteur>();
        }
        public bool Exist(Emprunteur e)
        {
            if(e == null)
                return false;
            return liste.Contains(e);
        }
        public Emprunteur Search(int code)
        {
            foreach (Emprunteur item in liste)
            {
                if (item.Code == code)
                    return item;
            }
            return null;
        }
        public bool AddEmprunteur(Emprunteur e)
        {
            if (!Exist(e))
            {
                liste.Add(e);
                return true;
            }
            return false;
        }
        public bool AddEmprunteur(String nom, String prenom)
        {
            Emprunteur emprunteur = new Emprunteur { Nom = nom, Prenom = prenom };
            return AddEmprunteur(emprunteur);
        }
        public bool DelEmprunteur(Emprunteur e)
        {
            return DelEmprunteur(e.Code);
        }
        public bool DelEmprunteur(int code)
        {
           Emprunteur e=Search(code);
           if (e == null)
                return false;
           liste.Remove(e);
           return true;
        }
        public bool ModifyEmprunteur(int code, String nom, String prenom)
        {
            Emprunteur e=Search(code);
            if (e == null)
                return false;
            e.Nom = nom;
            e.Prenom = prenom;
            return true;
        }
        
        public override string ToString()
        {
            String s = "";
            foreach (Emprunteur item in liste)
            {
                s += "\n" + item;
            }
            return s;
        }
        public int Count { get { return liste.Count; } }
    }
}
