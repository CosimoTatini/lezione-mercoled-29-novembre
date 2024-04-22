Console.WriteLine("Inserisci qui il tuo voto");
//Console.ReadLine(); 
int voto = 0;
string lettera= Console.ReadLine();
if (!int.TryParse(lettera, out voto))
{
    Console.WriteLine("Non inserire una lettera,inserisci un numero intero");
    return;
}

if (voto < 0) 
{
    Console.WriteLine(" Voto inserito non valido esci dal programma");
    return;
}
if (voto > 100)
{
    Console.WriteLine("Voto inserito non valido esci dal programma");
    return;
}

if (voto >= 90)
{
    Console.WriteLine("Eccellente");
}
else if (voto >= 70 && voto <= 89) // se voto compreso tra 70 e 89 
{
    Console.WriteLine("Buono");
}
else if (voto >= 50 && voto <= 69) // se voto compreso tra 50 e 69
{
    Console.WriteLine("Sufficiente");
}
else if (voto<50) // voto inferiore a 50 
{
    Console.WriteLine("Insufficiente");
}
