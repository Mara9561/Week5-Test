using System;
using System.Collections.Generic;
using System.Text;

namespace Test
{
    public class Immatricolazione
    {
        //Campi
        private int seedMatricola = 800000;

        //Proprietà
        public int Matricola { get; }
        public DateTime DataInizio { get; }
        public CorsoLaurea CorsoDiLaurea { get;}
        public bool FuoriCorso
        {
            get
            {
                bool fuoriCorso = false;
                if (DateTime.Now > DataInizio.AddYears(3))
                    fuoriCorso = true;
                return fuoriCorso;
            }
        }
                
        public int CFUAccumulati { get; set; }

        //Costruttore
        public Immatricolazione(CorsoLaurea corsoLaurea)
        {
            Matricola = seedMatricola;
            seedMatricola++;
            DataInizio = DateTime.Now;
            CorsoDiLaurea = corsoLaurea;
            CFUAccumulati = 0;
        }


    }
}
