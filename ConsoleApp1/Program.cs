using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Veicolo auto = new Veicolo();
            auto.Marca = "Kia";
            Veicolo moto = new Veicolo();
            moto.Marca = "Honda";
            Console.WriteLine("Auto è " + auto.Marca);
            Console.WriteLine("\n"); // riga vuota
            Console.WriteLine("Moto è " + moto.Marca);
            Console.WriteLine("\n"); // riga vuota
            // funzionante! 
            Console.ReadLine();
        }
    }
}
