using System;

namespace Oblig_1
    {
        class O1
        {
            static void Main(string[] args)
            {
                // Tester klassen Punkt2D:

                Punkt2D P1 = new Punkt2D(1, 4);
                Punkt2D P2 = new Punkt2D(3, 6);

                Console.WriteLine("Avstand mellom {0} og {1} er {2:f4}.",
                    P1.DataSomStreng(), P2.DataSomStreng(), P1.BeregnAvstandTil(P2));

                Punkt2D P3 = P1.FinnMellompunkt(P2);
                Console.WriteLine("Mellompunkt for {0} og {1} er {2}.",
                    P1.DataSomStreng(), P2.DataSomStreng(), P3.DataSomStreng());

                Punkt2D P4 = P2.FinnMellompunkt(P1);
                Console.WriteLine("Mellompunkt for {0} og {1} er {2}.",
                    P2.DataSomStreng(), P1.DataSomStreng(), P4.DataSomStreng());

                if (P3.LiggerPaaSammeLinjeSom(P1, P2)) // det bør P3 gjøre
                {
                    Console.WriteLine("Punkt {0}, {1} og {2} ligger på samme linje.",
                       P1.DataSomStreng(), P3.DataSomStreng(), P2.DataSomStreng());
                }

                if (P3.ErISammePosisjonSom(P4)) // disse bør være like
                {
                    Console.WriteLine("Punkt {0} og {1} er like.",
                        P3.DataSomStreng(), P4.DataSomStreng());
                }

                P4.X = 100; // flytter punkt P4
                if (!P3.ErISammePosisjonSom(P4)) // disse bør IKKE være like NÅ
                {
                    Console.WriteLine("Punkt {0} og {1} er ulike.",
                        P3.DataSomStreng(), P4.DataSomStreng());
                }

                Console.WriteLine("\n\n\n");

                // Tester strukturen Punkt2DS

                Punkt2DS S1 = new Punkt2DS(1, 4);
                Punkt2DS S2 = new Punkt2DS(3, 6);

                Console.WriteLine("Avstand mellom {0} og {1} er {2:f4}.",
                    S1.DataSomStreng(), S2.DataSomStreng(), S1.BeregnAvstandTil(S2));

                Punkt2DS S3 = S1.FinnMellompunkt(S2);
                Console.WriteLine("Mellompunkt for {0} og {1} er {2}.",
                    S1.DataSomStreng(), S2.DataSomStreng(), S3.DataSomStreng());

                Punkt2DS S4 = S2.FinnMellompunkt(S1);
                Console.WriteLine("Mellompunkt for {0} og {1} er {2}.",
                    S2.DataSomStreng(), S1.DataSomStreng(), S4.DataSomStreng());

                if (S3.LiggerPaaSammeLinjeSom(S1, S2)) // det bør S3 gjøre
                {
                    Console.WriteLine("Punkt {0}, {1} og {2} ligger på samme linje.",
                       S1.DataSomStreng(), S3.DataSomStreng(), S2.DataSomStreng());
                }

                if (S3.ErISammePosisjonSom(S4)) // disse bør være like
                {
                    Console.WriteLine("Punkt {0} og {1} er like.",
                        S3.DataSomStreng(), S4.DataSomStreng());
                }

                S4.X = 100; // flytter punkt S4
                if (!S3.ErISammePosisjonSom(S4)) // disse bør IKKE være like NÅ
                {
                    Console.WriteLine("Punkt {0} og {1} er ulike.",
                        S3.DataSomStreng(), S4.DataSomStreng());
                }
                
                Console.ReadKey(true);
            }
        }
    }
