//prodotto è caratterizzato da:
//-codice(numero intero)
//- nome
//- descrizione
//- prezzo
//- iva
//Usate opportunamente i livelli di accesso (public, private), i costruttori, i metodi getter e setter ed eventuali altri metodi di “utilità” per fare in modo che:
//alla creazione di un nuovo prodotto il codice sia valorizzato con un numero random
//Il codice prodotto sia accessibile solo in lettura
//Gli altri attributi siano accessibili sia in lettura che in scrittura
//Il prodotto esponga sia un metodo per avere il prezzo base che uno per avere il prezzo comprensivo di iva
//Il prodotto esponga un metodo per avere il nome esteso, ottenuto concatenando codice + nome
//Testate poi i vostri oggetti Prodotto, istanziandoli e provando ad interargirci per testare tutti i metodi che avete previsto.


Console.Write("Inserisci nome: ");
string name =Console.ReadLine() ?? "";

Console.Write("Inserisci descrizione: ");
string description = Console.ReadLine() ?? "";

Console.Write("Inserisci prezzo: ");
double price = Convert.ToDouble(Console.ReadLine());

Console.Write("Inserisci iva: ");
double iva = Convert.ToDouble(Console.ReadLine());

Product pasta = new Product(name, description, price, iva);


Console.WriteLine(pasta.ToString());

Console.WriteLine($"Prezzo iva compreso: {pasta.GetFullprice()}");