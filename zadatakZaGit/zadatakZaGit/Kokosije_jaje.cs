using System;
using System.Collections.Generic;
using System.Text;

namespace zadatakZaGit
{
    class Kokosije_jaje
    {
        public static string poreklo = "kokosije";
        public bool organsko, razbijeno;

        public Kokosije_jaje(string p, bool o, bool r)
        {
            poreklo = p;
            organsko = o;
            razbijeno = r;
        }

        public void Ispis(string poreklo, bool organsko, bool razbijeno)
        {
            Console.WriteLine("Poreklo: {0} Razbijeno: {1} Organsko: {2}", poreklo, razbijeno, organsko);
        }
    }
}
