using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CorrectionSerie2
{
    internal class Emprunteur
    {
        static int lastCode = 0;
        int code;
        string nom;
        string prenom;

        public Emprunteur()
        {
            lastCode++;
            code = lastCode;
            nom = prenom = "???????";
        }

        public override string ToString()
        {
            return Code+" "+Nom+" "+Prenom;
        }
        public int Code { get => code; set => code = value; }
        public string Nom { get => nom; set => nom = value; }
        public string Prenom { get => prenom; set => prenom = value; }
    }
}
