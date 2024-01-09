
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CorrectionSerie2
{
    internal class Emprunt
    {
        int codeEmprunteur;
        int codeOuvrage;
        DateTime dateEmprunt;
        DateTime dateRetour;

        public Emprunt()
        {
            codeEmprunteur =codeOuvrage= 0;
            dateEmprunt = dateRetour = DateTime.Now;
        }
        public override string ToString()
        {
            return codeEmprunteur+" "+codeOuvrage+" "+
                dateEmprunt.ToShortDateString() + " "+dateRetour.ToShortDateString();
        }
        public int CodeEmprunteur { get => codeEmprunteur; set => codeEmprunteur = value; }
        public int CodeOuvrage { get => codeOuvrage; set => codeOuvrage = value; }
        public DateTime DateEmprunt { get => dateEmprunt; set => dateEmprunt = value; }
        public DateTime DateRetour { get => dateRetour; set => dateRetour = value; }

    }
}
