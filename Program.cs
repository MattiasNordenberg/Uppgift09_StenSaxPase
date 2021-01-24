using System;

namespace Uppgift09_StenSaxPase
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hej! Välkommen att spela sten-sax-påse mot datorn");

            int player1count = 0;
            int player2count = 0;
            string repeat = "mumbojumbo";


            while (repeat != "Nej" || repeat != "nej")
            {

                Console.WriteLine("");
                Console.WriteLine("Välj genom att skriva: Sten, Sax eller Påse");
                string player1 = Console.ReadLine();
                Random rnd = new Random();
                int player2 = rnd.Next(1, 4);

                if (player2 == 1)
                {
                    if (player1 == "Sten")
                    {
                        Console.WriteLine("Datorn valde sten");
                        Console.WriteLine("Lika");
                    }
                    else if (player1 == "Sax")
                    {
                        Console.WriteLine("Datorn valde sten");
                        Console.WriteLine("Tyvärr, du förlorade. Sten slår sax.");
                        player2count += 1;

                    }
                    else if (player1 == "Påse")
                    {
                        Console.WriteLine("Datorn valde sten");
                        Console.WriteLine("Du vann! Påse slår sten.");
                        player1count += 1;
                    }
                    else
                    {
                        Console.WriteLine("Du måste välja antingen sten, sax eller påse!");
                    }

                }

                else if (player2 == 2)
                {
                    if (player1 == "Sten")
                    {
                        Console.WriteLine("Datorn valde sax.");
                        Console.WriteLine("Du vann! Sten slår sax.");
                        player1count += 1;

                    }
                    else if (player1 == "Sax")
                    {
                        Console.WriteLine("Datorn valde sax.");
                        Console.WriteLine("Lika");

                    }
                    else if (player1 == "Påse")
                    {
                        Console.WriteLine("Datorn valde sax.");
                        Console.WriteLine("Tyvärr, du förlorade. Sax slår påse.");
                        player2count += 1;

                    }
                    else
                    {
                        Console.WriteLine("Du måste välja antingen sten, sax eller påse!");
                    }
                }
                else if (player2 == 3)
                {
                    if (player1 == "Sten")
                    {
                        Console.WriteLine("Datorn valde påse.");
                        Console.WriteLine("Tyvärr, du förlorade. Påse slår sten.");
                        player2count += 1;

                    }
                    else if (player1 == "Sax")
                    {
                        Console.WriteLine("Datorn valde påse.");
                        Console.WriteLine("Du vann! Sax slår påse.");
                        player1count += 1;

                    }
                    else if (player1 == "Påse")
                    {
                        Console.WriteLine("Datorn valde påse.");
                        Console.WriteLine("Lika");

                    }
                    else
                    {
                        Console.WriteLine("Du måste välja antingen sten, sax eller påse!");

                    }

                }

                Console.WriteLine("Du har vunnit: " + player1count + " gånger");
                Console.WriteLine("Datorn har vunnit: " + player2count + " gånger");
                Console.WriteLine("Vill du spela igen? Ja/Nej");
                repeat = Console.ReadLine();

                if (repeat == "Nej" || repeat == "nej")
                {
                    Console.WriteLine("Tryck på valfri tangent för att avsluta");
                    Console.ReadKey();
                    break;
                }
            }
        }
    }
}
