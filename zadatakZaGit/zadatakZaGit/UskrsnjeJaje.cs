using System;
using System.Collections.Generic;
using System.Text;

namespace zadatakZaGit
{
    class UskrsnjeJaje : Kokosije_jaje
    {
        public string boja;
        public bool jednobojno, obojeno;

        public UskrsnjeJaje(string b, string p, bool or, bool r, bool j, bool ob) : base(p, or, r)
        {
            boja = b;
            poreklo = p;
            organsko = or;
            razbijeno = r;
            jednobojno = j;
            obojeno = ob;
        }
        
        public void Ispis(string poreklo, bool organsko, bool razbijeno, string boja, bool jednobojno)
        {
            base.Ispis(poreklo, organsko, razbijeno);
            Console.WriteLine("Obojeno: {0} Boja: {1} Jednobojno: {2}", obojeno, boja, jednobojno);
        }
    }

    
}
