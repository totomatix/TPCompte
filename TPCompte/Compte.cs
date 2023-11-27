using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPCompte
{
    public class Compte
    {
        private decimal _Solde;
        private int _Code;
        private Client _Proprietaire;
        private static int _NbComptes;

        public decimal Solde { get => _Solde; private set => _Solde = value; }
        public int Code { get => _Code; private set => _Code = value; }
        public Client Proprietaire { get => _Proprietaire; private set => _Proprietaire = value; }
        public static int NbComptes { get => _NbComptes; private set => _NbComptes = value; }

        public Compte(Client proprietaire)
        {
            Proprietaire = proprietaire;
            Solde = 0;
            NbComptes++;
            Code = NbComptes;
        }

        public void Crediter(decimal somme)
        {
            Solde += somme;
            // mise en place d'un historique des transactions
        }

        public void Crediter(decimal somme, Compte compte)
        {
            Crediter(somme);
            compte.Debiter(somme);
        }

        public void Debiter(decimal somme)
        {
            Solde -= somme;
            // mise en place d'un historique des transactions
        }

        public void Debiter(decimal somme, Compte compte)
        {
            Debiter(somme);
            compte.Crediter(somme);
        }

        public override string? ToString()
        {
            return "*******************\n" +
                $"Numéro du compte : {Code}\n" +
                $"Solde du compte : {Solde}\n" +
                "Propritaire du compte :\n" +
                $"{Proprietaire}" +
                "*******************";
        }
    }
}
