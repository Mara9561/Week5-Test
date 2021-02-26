using System;
using System.Collections.Generic;
using System.Text;

namespace Test
{
    public class CorsoLaurea
    {
        //Campi
        public enum NomeCorsoLaurea
        {
            Matematica,
            Fisica,
            Informatica,
            Ingegneria,
            Lettere
        }

        //Proprietà
        public NomeCorsoLaurea Nome { get; set; }
        public int AnniDiCorso { get; set; }
        public int CFULaurea { get; set; }
        public List<Corso> ListaCorsi { get; set; }

        //Costruttore
        public CorsoLaurea(NomeCorsoLaurea nome, int anni, params Corso[] corsi)
        {
            Nome = nome;
            AnniDiCorso = anni;
            CFULaurea = 60 * AnniDiCorso;
            ListaCorsi = new List<Corso>(corsi);
        }


    }
}
