using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CorrectionSerie2
{
    internal class GestionOuvrages
    {
        List<Ouvrage> liste;

        public GestionOuvrages()
        {
            liste = new List<Ouvrage>();
        }
        public bool Exist(Ouvrage e)
        {
            if (e == null)
                return false;
            return liste.Contains(e);
        }
        public Ouvrage Search(int code)
        {
            foreach (Ouvrage item in liste)
            {
                
                if (item.Code == code)
                    return item;
            }
            return null;
        }
        public bool AddOuvrage(Ouvrage e)
        {
            if (!Exist(e))
            {
                liste.Add(e);
                return true;
            }
            return false;
        }
        public bool AddOuvrage(String titre, String anneeEdition, params string[] tab)
        {
            Ouvrage ouv = new Ouvrage(titre,anneeEdition,tab);
            return AddOuvrage(ouv);
        }
        public bool DelOuvrage(Ouvrage e)
        {
            return DelOuvrage(e.Code);
        }
        public bool DelOuvrage(int code)
        {
            Ouvrage e = Search(code);
            if (e == null)
                return false;
            liste.Remove(e);
            return true;
        }

        public bool ModifyOuvrage(Ouvrage ouv1, Ouvrage ouv2)
        {
            Ouvrage e = Search(ouv1.Code);
            if (e == null)
                return false;
            e = ouv2;
            return true;
        }

        public bool ModifyOuvrage(int code, String titre, string anneeEdition,params string[] tab)
        {
            Ouvrage e = Search(code);
            if (e == null)
                return false;
            e.Titre = titre;
            e.AnneeEdition =DateTime.Parse(anneeEdition);
            foreach (var item in tab)
            {
                e.AddAuteur(item);
            }
            
            return true;
        }
       
        public override string ToString()
        {
            String s = "";
            foreach (Ouvrage item in liste)
            {
                s += "\n" + item;
            }
            return s;
        }
        public int Count { get { return liste.Count; } }
    }
}
