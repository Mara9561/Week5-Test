using System;
using System.Collections.Generic;
using System.Text;

namespace Test
{
    public class Esame
    {
        //Proprietà
        public Corso EsameCorso { get; set; }
        public bool EsamePassato { get; set; }

        //Costruttore
        public Esame(Corso corso)
        {
            EsameCorso = corso;
            EsamePassato = false;
        }

    }
}
