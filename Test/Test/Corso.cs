using System;
using System.Collections.Generic;
using System.Text;

namespace Test
{
    public class Corso
    {
        //Proprietà
        public string NomeCorso { get; set; }
        public int CFUCorso { get; set; }

        //Costruttore
        public Corso(string nome, int crediti)
        {
            NomeCorso = nome;
            CFUCorso = crediti;
        }

    }
}
