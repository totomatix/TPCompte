using TPCompte;
Console.WriteLine("Compte 1 :");
Console.Write("Donnez le CIN : ");
string cin = Console.ReadLine();
Console.Write("Donnez le Nom : ");
string nom = Console.ReadLine();
Console.Write("Donnez le Prenom : ");
string prenom = Console.ReadLine();
Console.Write("Donnez le téléphone : ");
string tel = Console.ReadLine();

Client client1 = new Client(nom, prenom, cin, tel);

Compte compte1 = new Compte(client1);
Console.WriteLine("Détails du compte :");
Console.WriteLine(compte1);

Console.WriteLine("Donnez le montant à déposer : ");
decimal montant = decimal.Parse(Console.ReadLine());
compte1.Crediter(montant);
Console.WriteLine("Opération bien effectuée.");
Console.WriteLine(compte1);

Console.WriteLine("Donnez le montant à retirer : ");
montant = decimal.Parse(Console.ReadLine());
compte1.Debiter(montant);
Console.WriteLine("Opération bien effectuée.");
Console.WriteLine(compte1);


Console.WriteLine("Compte 2 :");
Console.Write("Donnez le CIN : ");
cin = Console.ReadLine();
Console.Write("Donnez le Nom : ");
nom = Console.ReadLine();
Console.Write("Donnez le Prenom : ");
prenom = Console.ReadLine();
Console.Write("Donnez le téléphone : ");
tel = Console.ReadLine();

Client client2 = new Client(nom, prenom, cin, tel);

Compte compte2 = new Compte(client2);
Console.WriteLine("Détails du compte :");
Console.WriteLine(compte2);

Console.WriteLine("Créditer le compte 2 à partir du compte 1.");
Console.Write("Donnez le montant à déposer :");
montant = decimal.Parse(Console.ReadLine());
compte2.Crediter(montant, compte1);
Console.WriteLine("Opération bien effectuée.");

Console.WriteLine("Débiter le compte 1 et créditer le compte 2.");
Console.Write("Donnez le montant à déposer :");
montant = decimal.Parse(Console.ReadLine());
compte1.Debiter(montant, compte2);
Console.WriteLine("Opération bien effectuée.");
Console.WriteLine(compte1);
Console.WriteLine(compte2);

Console.WriteLine($"Nombre de comptes crées : {Compte.NbComptes}");
