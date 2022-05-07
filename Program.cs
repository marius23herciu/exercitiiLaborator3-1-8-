using System;

namespace exercitiiLaborator3_1_8_
{
    class Program
    {
        static void Main(string[] args)
        {
            //Ex1();
            //Ex2();
            //Ex3();
            //Ex4();
            //Ex5();
            //Ex6();
            Ex7();
            //Ex8();
        }
        static void Ex1()
        {
            //Ex1 Scrieti un program care sa calculeze maximul a trei numere citite de la
            //tastatura.Ex: se citeste 3,15,4 Vom afisa 15

            //varianta 1

            int[] numere = new int[3];
            Console.WriteLine("Introduceti 3 numere");
            for (int i = 0; i < numere.Length; i++)
            {
                numere[i] = int.Parse(Console.ReadLine());
            }

            int numarulMaxim = -1000;
            for (int i = 0; i < numere.Length; i++)
            {
                if (numere[i] > numarulMaxim)
                {
                    numarulMaxim = numere[i];
                }
            }

            Console.WriteLine("Cel mai mare numar introdus este " + numarulMaxim);

            //varianta 2

            //int[] numere = new int[3];
            //Console.WriteLine("Introduceti 3 numere");
            //for (int i = 0; i < numere.Length; i++)
            //{
            //    numere[i] = int.Parse(Console.ReadLine());
            //}

            //int numarulMaxim = Math.Max(numere[0], numere[1]);
            //numarulMaxim = Math.Max(numarulMaxim, numere[2]);
            //Console.WriteLine("Cel mai mare numar introdus este " + numarulMaxim);
        }
        static void Ex2()
        {
            //Ex2 Scrieti un program care va citi de la tastatura un numar intreg pozitiv
            //si va afisa valoarea acestuia in basa 2.Ex: se citeste 42, vom afisa 101010

            Console.WriteLine("Introduceti un numar:");
            int numar = int.Parse(Console.ReadLine());
            string nrInbaza2 = Convert.ToString(numar, 2);
            Console.WriteLine("Numarul introdus are urmatoarea valoare in baza 2: " + nrInbaza2);
        }
        static void Ex3()
        {
            //Ex3 Scrieti un program care determina daca un numar n citit de la tastatura
            //este un patrat perfect

            Console.WriteLine("Introduceti un numar:");
            int numar = int.Parse(Console.ReadLine());
            double radacinaPatrata = Math.Sqrt(numar);

            if (radacinaPatrata % 1 == 0)
            {
                Console.WriteLine("Numarul introdus este patrat perfect");
                return;
            }
            Console.WriteLine("Numarul introdus NU este patrat perfect");
        }
        static void Ex4()
        {
            //Ex4 Se citesc numere de la tastatură până la apariția lui zero. Să se
            //determine suma lor.

            Console.WriteLine("Introduceti numere diferite de 0. Introduceti 0 cand vreti sa va opriti. ");

            int suma;
            int numar = int.Parse(Console.ReadLine());
            suma = numar;

            while (numar != 0)
            {
                numar = int.Parse(Console.ReadLine());
                suma += numar;
            }

            Console.WriteLine("Suma numerelor introduse este " + suma);
        }

        static void Ex5()
        {
            //Ex5 Se citesc numere de la tastatură până când se introduc două numere
            //consecutive egale. Să se determine suma tuturor numerelor citite


            Console.WriteLine("Introduceti numere. Cand introduceti două numere consecutive egale, se va calcula suma.");

            int suma;
            int penultimulNumar;

            int numar = int.Parse(Console.ReadLine());
            suma = numar;
            penultimulNumar = numar;
            numar = int.Parse(Console.ReadLine());
            suma += numar;

            while (numar != penultimulNumar)
            {
                penultimulNumar = numar;
                numar = int.Parse(Console.ReadLine());
                suma += numar;
            }

            Console.WriteLine("Suma numerelor introduse este " + suma);
        }
        static void Ex6()
        {
            //Ex6 Scrieti un program care va determina daca un numar n este sau numar
            //prim, n fiind citit de la tastatura. Daca este numar prim, va afisa “prim”. In
            //caz contrar va afisa numarul cu care este divizibil

            Console.WriteLine("Introduceti un numar:");
            int numar = int.Parse(Console.ReadLine());
            var radacinaPatrata = (int)Math.Floor(Math.Sqrt(numar));

            if (numar <= 1)
            {
                Console.WriteLine("Introduceti numere mai mari decat 1.");
                return;
            }
            if (numar % 2 == 0)
            {
                Console.WriteLine(numar + " estedivizibil cu  " + radacinaPatrata);
                return;
            }

            for (int i = 3; i <= radacinaPatrata; i += 2)
            {
                if (numar % i == 0)
                {
                    Console.WriteLine(numar + " este divizibil cu  " + radacinaPatrata);
                    return;
                }
                else
                {
                    Console.WriteLine("prim");
                    return;
                }
            }
            Console.WriteLine("prim");
        }
        static void Ex7()
        {
            //Se citesc doua numere de la tastatura. Scrieti un program care va
            //calcula cel mai mare divizor comun al numerelor

            Console.WriteLine("Introduceti 2 numere:");
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int divizor;

            if (a == b)
            {
                divizor = a;
                Console.WriteLine("Cel mai mare divizor comun este " + divizor);
            }
            else if (a > b)
            {
                divizor = b;
                for (int i = 0; i < b; i++)
                {
                    if (a % divizor == 0 && b % divizor == 0)
                    {
                        Console.WriteLine("Cel mai mare divizor comun este " + divizor);
                        return;
                    }
                    divizor--;
                }
            }
            else
            {
                divizor = a;
                for (int i = 0; i < a; i++)
                {
                    if (a % divizor == 0 && b % divizor == 0)
                    {
                        Console.WriteLine("Cel mai mare divizor comun este " + divizor);
                        return;
                    }
                    divizor--;
                }
            }
        }
    }
}
