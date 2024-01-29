using System;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Righe veicolo
            Veicolo auto = new Veicolo();
            auto.Marca = "Kia";
            Veicolo moto = new Veicolo();
            moto.Marca = "Honda";
            Console.WriteLine("Auto è " + auto.Marca);
            Console.WriteLine("Moto è " + moto.Marca);
            Console.WriteLine("\n"); // riga vuota
            // Righe animale 
            Animale cane = new Animale();
            cane.Razza = "Yorkshire";
            cane.Nome = "Floki";
            Console.WriteLine("Ho uno " + cane.Razza + " che si chiama " + cane.Nome);
            Animale gatto = new Animale();
            gatto.Razza = "Norvegese";
            gatto.Nome = "King";
            Console.WriteLine("Il mio gatto è un " + gatto.Razza + " che si chiama " + gatto.Nome);
            Console.WriteLine("\n"); // riga vuota
            // Righe dipendente
            Dipendente dipendente1 = new Dipendente();
            dipendente1.Nome = "Tizio";
            dipendente1.Ruolo = "Full Stack Developer";
            dipendente1.Eta = 30;
            Console.WriteLine(dipendente1.Nome + " lavora come " + dipendente1.Ruolo + " e ha " + dipendente1.Eta + " anni.");
            Console.WriteLine("\n"); // riga vuota
            // Righe Atleta
            Atleta atleta1 = new Atleta();
            atleta1.Nome = "Jannik";
            atleta1.Cognome = "Sinner";
            atleta1.Sport = "Tennis";
            atleta1.Paese = "Italia";
            Console.WriteLine(atleta1.Nome + atleta1.Cognome + " ha rappresentato " + atleta1.Paese + " nel " + atleta1.Sport);
            string Messaggio = atleta1.numMatch(13);
            Console.WriteLine(Messaggio + "\n");
            Console.WriteLine("\n"); // riga vuota
            Console.ReadLine();
        }
    }
}
