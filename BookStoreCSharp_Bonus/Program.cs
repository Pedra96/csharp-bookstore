
string[] LibroArray = new string[] { "Titolo: ", "Autore: ", "ISBN: ", "Numero pagine: ", "Peso del libro: ", "Larghezza: ", "Altezza: ", "Profondità: ", "Valutazione media: ", "Numero di recensioni: ", "se ha il Kindle (y,n): ", "se ha la copertina flessibile (y,n): " };
Dictionary<int,string> Libro = new Dictionary<int,string>();

for(int i = 0; i < LibroArray.Length; i++)
{
    Console.WriteLine("inserisci " + LibroArray[i]);
    string InputUtente = Console.ReadLine();
    Libro.Add(i,InputUtente );
}

Console.WriteLine("-------------------------------------------------------");
for(int j=0; j < LibroArray.Length; j++)
{
    Console.WriteLine(LibroArray[j] + Libro[j]);
}


/*
 * public class Libro
{
    string Titolo = "Metro 2035";
    string Autore = "Dmitry Glukhovsky";
    string ISBN = "978-5-17-090538-6";
    float larghezza = 13.8f;
    float altezza = 20.1f;
    float profondità = 4.4f;
    int NumeroPagine = 560;
    float ValutazioneMedia = 4.5f;
    int NumeroDiRecensioni = 158;
    bool kindle = true;
    bool CopertinaFlessibile = true;
    float PesoLibro = 0.64f;
}

  Libro test1 = new Libro();
 * 
 * Console.WriteLine($"---------------IL LIBRO DI OGGI: {Titolo} di {Autore} ----------------");
Console.WriteLine("Informazioni generiche:");
Console.WriteLine("ISBN: " + ISBN);
Console.WriteLine("Numero di pagine: " + NumeroPagine);
Console.WriteLine("Peso del libro: " + PesoLibro + "kg");
Console.WriteLine(larghezza + "cm x " + altezza + "cm x " + profondità + "cm");
Console.WriteLine("\nInformazioni Amazon:");
Console.WriteLine("Numero di recensioni: " + NumeroDiRecensioni + " recensioni");
Console.WriteLine("Valutazione media: " + ValutazioneMedia + " stellina");
if (kindle)
{
    Console.WriteLine("Kindle disponibile: Si");
}
else
{
    Console.WriteLine("Kindle disponibile: No");
}
if (CopertinaFlessibile)
{
    Console.WriteLine("Copertina flessibile disponibile: Si");
}
else
{
    Console.WriteLine("Copertina flessibile disponibile: No");
}
*/
