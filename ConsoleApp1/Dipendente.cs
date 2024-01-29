using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Dipendente
    {
        private string _nome;
        public string Nome
        {
            get { return _nome; }
            set { _nome = value; }
        }
        private string _ruolo;
        public string Ruolo
        {
            get { return _ruolo; } set { _ruolo = value; }
        }
        private int _eta;
        public int Eta { 
        get { return _eta; } set { _eta = value; }
        }
    }
}
