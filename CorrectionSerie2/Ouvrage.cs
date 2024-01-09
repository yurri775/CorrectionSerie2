using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CorrectionSerie2
{
    internal class Ouvrage
    {
        static int lastCode=0;
        int code;
        string titre;
        DateTime anneeEdition;
        List<string> auteurs;
        public Ouvrage()
        {
            lastCode++;
            code = lastCode;
            titre = "???????";
            anneeEdition = DateTime.Now;    
            auteurs=new List<string>();
        }
        public Ouvrage(string titre, string anneeEdition, 
            params string[] tab)
            :this() //appel au constructeur par défaut
        {
            this.titre = titre;
            this.anneeEdition =DateTime.Parse(anneeEdition);
            foreach (var item in tab)
            {
                auteurs.Add(item);
            }
        }
        public bool Exist(string aut)
        {
            return auteurs.Contains(aut);
        }
        public bool AddAuteur(string aut)
        {
            if (!Exist(aut))
            {
                auteurs.Add(aut);
                return true;
            }
            return false;
        }
        public bool DelAuteur(string aut)
        {
            if (Exist(aut))
            {
                auteurs.Remove(aut);
                return true;
            }
            return false;
        }
        public bool ModifiyAuteur(string aut1, string aut2)
        {
            if (Exist(aut1) && !Exist(aut2))
            {
                int pos=auteurs.IndexOf(aut1);
                auteurs[pos]=aut2;
                return true;
            }
            return false;
        }
        public override string ToString()
        {
            String s = Code + " " + titre + " " + 
                AnneeEdition.ToShortDateString() + " ";
            foreach (var item in auteurs)
            {
                s += ", " + item;
            }
            return s;
        }
        public int Code { get => code; set => code = value; }
        public string Titre { get => titre; set => titre = value; }
        public DateTime AnneeEdition { get => anneeEdition; set => anneeEdition = value; }
        public List<string> Auteurs { get => auteurs; set => auteurs = value; }
    }
}
