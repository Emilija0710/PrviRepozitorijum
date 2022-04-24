using System;
using System.Collections.Generic;

namespace zadatakZaGit
{
    class Program
    {
        static string poreklo = "kokosije";
        static void Main(string[] args)
        {
            List<UskrsnjeJaje> lista1 = new List<UskrsnjeJaje>();
            List<Kokosije_jaje> lista2 = new List<Kokosije_jaje>();

            int izbor = 1;
            while (izbor != 0)
            {
                Console.WriteLine("Program za vodjenje evidencije o jajima iz vaseg frizidera! ");
                Console.WriteLine("Za unos jajeta unesi 1,za ispis jaja 2, a za izlazak iz programa unesi 0: ");
                izbor = Convert.ToInt32(Console.ReadLine());
                if (izbor == 0) break;
                if (izbor == 2)
                {
                    evidencija(lista2, lista1);
                }
                else
                {
                    bool org = false; bool razb = false;
                    Console.WriteLine("Ako je jaje organsko unesi 'da', ako nije, unesi 'ne'");
                    if (Console.ReadLine().ToString() == "da") org = true;
                    Console.WriteLine("Ako je jaje razbijeno unesi 'da', ako nije, unesi 'ne'");
                    if (Console.ReadLine().ToString() == "da") razb = true;
                    Console.WriteLine("Ako je jaje obojeno unesi 'da', ako nije, unesi 'ne'");
                    if (Console.ReadLine().ToString() == "da")
                    {
                        bool ob = true;
                        bool jedn = false;
                        Console.WriteLine("Unesi naziv boje jajeta: ");
                        string boja = Console.ReadLine();
                        Console.WriteLine("Ako je jaje jednobojno unesi 'da', ako nije, unesi 'ne'");
                        if (Console.ReadLine().ToString() == "da") jedn = true;
                        lista1.Add(new UskrsnjeJaje(boja, poreklo, org, razb, jedn, ob));
                    }
                    else lista2.Add(new Kokosije_jaje(poreklo, org, razb));

                    Console.WriteLine("Jaje dodato u evidenciju!");
                    Console.WriteLine();
                }
            }
        }

        static void evidencija(List<Kokosije_jaje>lista2, List<UskrsnjeJaje>lista1)
        {
            Console.WriteLine("Lista jos neobojenih jaja: ");
            for (int i = 0; i < lista2.Count; i++)
            {
                lista2[i].Ispis(poreklo, lista2[i].organsko, lista2[i].razbijeno);
                Console.WriteLine();
            }

            Console.WriteLine("Lista obojenih jaja: ");
            for (int i = 0; i < lista1.Count; i++)
            {
                lista1[i].Ispis(poreklo, lista1[i].organsko, lista1[i].razbijeno, lista1[i].boja, lista1[i].jednobojno);
                Console.WriteLine();
            }

        }
    }
}
