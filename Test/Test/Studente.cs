using System;
using System.Collections.Generic;
using System.Text;

namespace Test
{
    public class Studente
    {
        //Proprietà
        public string Nome { get; set; } //uno può cambiare nome e cognome all'anagrafe
        public string Cognome { get; set; }
        public int AnnoDiNascita { get;}
        public Immatricolazione Imm { get; }
        public List<Esame> Esami { get; set; }
        public bool RichiestaLaurea { get; set; }

        //Costruttore
        public Studente(string nome, string cognome, int anno, Immatricolazione imm)
        {
            Nome = nome;
            Cognome = cognome;
            AnnoDiNascita = anno;
            Imm = imm;
            Esami = new List<Esame>();
            RichiestaLaurea = false;
        }

        //Metodi
        public void RichiestaIscrizioneEsame(Esame esame)
        {
            if (Imm.CorsoDiLaurea.ListaCorsi.Contains(esame.EsameCorso) && (esame.EsameCorso.CFUCorso+Imm.CFUAccumulati) <= Imm.CorsoDiLaurea.CFULaurea && !RichiestaLaurea)
                Esami.Add(esame);
            else
            {
                if (!Imm.CorsoDiLaurea.ListaCorsi.Contains(esame.EsameCorso))
                    Console.WriteLine("L'esame di {0} non è disponibile per il tuo corso di laurea!", esame.EsameCorso.NomeCorso);
                else if (RichiestaLaurea)
                    Console.WriteLine("Hai già richiesto la laurea. Non puoi sostenere altri esami!");
                else
                    Console.WriteLine("L'esame di {0} supera i CFU massimi del corso di laurea!", esame.EsameCorso.NomeCorso);


            }
        }

        public void EsamePassato(Esame esame)
        {
            if (Esami.Contains(esame))
            {
                Imm.CFUAccumulati += esame.EsameCorso.CFUCorso;
                esame.EsamePassato = true;
                if (Imm.CFUAccumulati == Imm.CorsoDiLaurea.CFULaurea)
                    RichiestaLaurea = true;
            }
            else
                Console.WriteLine($"Non sei iscritto all'esame di {esame.EsameCorso.NomeCorso}");
        }


    }
}
