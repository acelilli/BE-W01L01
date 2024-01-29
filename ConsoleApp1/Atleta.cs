using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Atleta
    {
        private string _nome;
        public string Nome { get { return _nome; } set { _nome = value; } }
        public string _cognome;
        public string Cognome { get { return _cognome; } set { _cognome = value; } }
        private string _sport;
        public string Sport { get { return _sport; } set { _sport = value; } }
        private string _paese;
        public string Paese { get { return _paese; } set { _paese = value; } }

        public string numPartite(int PartiteVinte)
        {
            if (PartiteVinte > 10)
            {
                return " ed è un grande atleta";
            }
            else
            {
                return " ma può ancora migliorare";
            }
        }
    }
}
