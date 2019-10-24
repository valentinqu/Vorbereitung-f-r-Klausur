using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vorbereitung_für_Klausur
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Auswahlmenü");
            Console.WriteLine("1: Summe der ganzen Zahlen von a bis b");
            Console.WriteLine("2: Verflixte 7");
            Console.WriteLine("3: °C in °F umrechnen");
            Console.WriteLine("5: Fakulität von x");
            int auswahl1 = Convert.ToInt32(Console.ReadLine());
            if (auswahl1 == 1)
            {

                int a, b, c;
                Console.WriteLine("Summe der ganzen zahlen von a bis b");
                Console.WriteLine("Zahl a eingeben");
                a = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Zahl b eingeben");
                b = Convert.ToInt32(Console.ReadLine());
                c = 0;
                for (int i = a; i <= b; i++)
                {
                    c += i;
                }
                Console.WriteLine(c + " ist Summe der Zahlen von " + a + " und " + b);
            }

            else if (auswahl1 == 2)
            {
                Console.WriteLine("eine ganze Zahl eingeben");
                int a = Convert.ToInt32(Console.ReadLine());
                int b = 1;
                while (b <= a)
                {
                    Console.WriteLine(b);
                    if (b % 7 == 0)
                    {
                        Console.WriteLine("----7----");
                    }


                    else
                    {
                        string d = Convert.ToString(b);
                        for (int c = 0; c < d.Length; c++)
                        {
                            if (d[c] == '7')
                            {
                                Console.WriteLine("----7----");
                            }

                        }
                    }

                    b = b + 1;
                }
            }














            else if (auswahl1 == 3)
            {
                Console.WriteLine("Möchten Sie 1. Grad Celsius oder 2. Grad Fahrenheit umrechnen");
                int auswahl2 = Convert.ToInt32(Console.ReadLine());
                if (auswahl2 == 1)
                {
                    Console.WriteLine("Grad Celsius eingeben:");
                    int C = int.Parse(Console.ReadLine());
                    Console.WriteLine("Grad Fahrenheit ist: " + (C * 1.8 + 32));
                }
                else if (auswahl2 == 2)
                {
                    Console.WriteLine("Grad Fahrenheit eingeben");
                    int F = int.Parse(Console.ReadLine());
                    Console.WriteLine("Grad Celsius ist : " + ((F - 32) / 1.8));
                }

            }
            else if(auswahl1 == 5)
            {
                ulong  a, i;
                ulong  sum = 1;
                Console.WriteLine("Zahl eingeben");
                a = Convert.ToUInt64(Console.ReadLine());
                for (i = a; i > 0; i--)
                {
                    sum = i * sum;
                }
                Console.WriteLine(a + "!=" + sum);


                    


            }
            }
        }
    }


