using System;
using System.Collections.Generic;

namespace Test
{
    class Program
    {
        static void Main(string[] args)
        {
            //Creo tre corsi
            Corso analisi1 = new Corso("Analisi1", 170);
            Corso elettromagnetismo = new Corso("Elettromagnetismo", 12);
            Corso astronomia = new Corso("Astronomia", 10);

            //Creo il corso di laurea triennale in fisica
            //I nomi dei corsi sono univoci per ogni corso di laurea
            CorsoLaurea corsoLaurea = new CorsoLaurea(CorsoLaurea.NomeCorsoLaurea.Fisica, 3, analisi1, elettromagnetismo, astronomia);
            
            //Creo immatricolazione e studente
            Immatricolazione immatricolazione = new Immatricolazione(corsoLaurea);
            Studente mara = new Studente("Mara", "Barani", 1995, immatricolazione);

            //Creo esami relativi ai corsi sopra definiti
            Esame esameAnalisi1 = new Esame(analisi1);
            Esame esameElettromagnetismo = new Esame(elettromagnetismo);
            Esame esameAstronomia = new Esame(astronomia);

            //Prove per verificare il funzionamento
            //Mi iscrivo all'esame di analisi 1 e lo passo
            mara.RichiestaIscrizioneEsame(esameAnalisi1);
            mara.EsamePassato(esameAnalisi1);

            //Mi iscrivo all'esame di elettromagnetismo ma non lo passo
            mara.RichiestaIscrizioneEsame(esameElettromagnetismo);
            mara.EsamePassato(esameElettromagnetismo);

            //Mi isrivo all'esame di astronomia e lo passo, raggiungengo i crediti necessari per la laurea
            mara.RichiestaIscrizioneEsame(esameAstronomia);
            mara.EsamePassato(esameAstronomia);

            //Cerco di iscrivermi ad un altro esame anche se ho già raggiunto i crediti per la laurea
            mara.RichiestaIscrizioneEsame(esameElettromagnetismo);

        }
    }
}
