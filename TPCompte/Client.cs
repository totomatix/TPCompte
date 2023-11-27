using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPCompte
{
    public class Client
    {
        private string _Nom;
        private string _Prenom;
        private string _CIN;
        private string _Tel;

        public Client(string nom, string prenom, string cIN, string tel)
        {
            Nom = nom;
            Prenom = prenom;
            CIN = cIN;
            Tel = tel;
        }

        public Client(string nom, string prenom, string cIN)
        {
            Nom = nom;
            Prenom = prenom;
            CIN = cIN;
        }

        public string Nom { get => _Nom; set => _Nom = value; }
        public string Prenom { get => _Prenom; set => _Prenom = value; }
        public string CIN { get => _CIN; set => _CIN = value; }
        public string Tel { get => _Tel; set => _Tel = value; }

        public void Afficher()
        {
            Console.WriteLine($"CIN : {CIN}");
            Console.WriteLine($"Nom : {Nom}");
            Console.WriteLine($"Prenom : {Prenom}");
            Console.WriteLine($"Tel : {Tel}");
        }

        public override string? ToString()
        {
            return $"CIN : {CIN}\n"
                + $"Nom : {Nom}\n"
                + $"Prenom : {Prenom}\n"
                + $"Tel : {Tel}\n";
        }
    }
}
