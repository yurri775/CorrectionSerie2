
#region tests des classes:
using CorrectionSerie2;

internal class Program
{
    private static void Main(string[] args)
    {
        Emprunteur e1 = new Emprunteur { Nom = "Nom1", Prenom = "prenom1" };
        Emprunteur e2 = new Emprunteur { Nom = "Nom2", Prenom = "prenom2" };
        Emprunteur e3 = new Emprunteur { Nom = "Nom3", Prenom = "prenom3" };
        GestionEmprunteurs l1 = new GestionEmprunteurs();
        l1.AddEmprunteur(e1);
        l1.AddEmprunteur(e2);
        l1.AddEmprunteur(e3);
        Console.WriteLine(l1);


        Console.WriteLine("************************");
        Ouvrage ouvrage1 = new Ouvrage();
        Ouvrage ouvrage2 = new Ouvrage { Titre = "POO" };
        Ouvrage ouvrage3 = new Ouvrage("POO en c#", "2000/2/3", "aut0");
        Ouvrage ouvrage4 = new Ouvrage("POO en c++", "2000/2/20", "aut1", "aut2");
        Console.WriteLine(ouvrage1);
        Console.WriteLine(ouvrage2);
        Console.WriteLine(ouvrage3);
        Console.WriteLine(ouvrage4);


        Console.WriteLine("************************");
        GestionOuvrages l2 = new GestionOuvrages();

        l2.AddOuvrage(ouvrage1);
        l2.AddOuvrage(ouvrage2);
        l2.AddOuvrage(ouvrage3);
        l2.AddOuvrage(ouvrage4);
        Console.WriteLine(l2);


        GestionEmprunts gestEmp = new GestionEmprunts();
        while (true)
        {
            Console.WriteLine("entrer le code de l'emprunteur");
            int codeEmp = int.Parse(Console.ReadLine());
            Emprunteur e = l1.Search(codeEmp);
            Console.WriteLine("entrer le code de l'ouvrage");
            int codeOuv = int.Parse(Console.ReadLine());
            Ouvrage ouv = l2.Search(codeOuv);
            if (ouv != null && e != null)
            {
                Console.WriteLine("entrer la date de retour:");
                DateTime date = DateTime.Parse(Console.ReadLine());
                Emprunt emprunt = new Emprunt
                {
                    CodeEmprunteur = codeEmp,
                    CodeOuvrage = codeOuv,
                    DateEmprunt = DateTime.Now,
                    DateRetour = date
                };
                gestEmp.AddEmprunt(emprunt);
            }
            Console.WriteLine("encore un autre emprunt?o/n");
            string reponse = Console.ReadLine();
            if (reponse == "n")
                break;
        }
        Console.WriteLine("*******************************");
        Console.WriteLine("entrer le code de l'emprunteur");
        int code = int.Parse(Console.ReadLine());
        Console.WriteLine("liste des emprunts pour cet emprunteur:");
        List<Emprunt> list = gestEmp.SearchEmprunts(code);
        foreach (var emp in list)
            Console.WriteLine(emp);
    }
}