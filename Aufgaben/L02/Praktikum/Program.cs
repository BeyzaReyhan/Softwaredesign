using System;

namespace Praktikum
{
    class Program
    {
        static void Main(string[] args)
        {
            //int i = 42;
            //double pi = 3.1415;
            //string salute = "Hello, World";
            var test = 3D;
            Console.WriteLine(test);
            verzweigungen();
            //cases();
            ifelse();
            whilecondition();
            forwhile();

            //int[] ia = new int[10];             //Die Variable heißt ia     Der Grundtyp ist Integer    //10
            //char[] ca = new char[30];           //Die Variable heißt ca     Der Grundtyp ist char       //30
            //double[] da = new double[12];       // Die Variable heißt da    Der Gruntyp ist double      //12

            int[] ia = { 1, 0, 2, 9, 3, 8, 4, 7, 5, 6, 9, 10, 563, 19 };
            int ergebnis = ia[2] * ia[8] + ia[4];
            Console.WriteLine("Das Ergebnis ist " + ergebnis);

            double e = Math.Exp(1);
            double t = 2;
            double z = 4;
            double k = Math.Pow(t, 2) / Math.Pow(z, 3);
            double[] d = { 3.1415, e, k };
            Console.WriteLine("Die Länge des Arrays beträgt " + ia.Length);

            string meinString = "Dies ist ein String";
            string a = "Dies ist ";
            string b = "ein String";
            string c = a + b;
            string aa = "eins";
            string bb = "zwei";
            string cc = "eins";
            bool aa_eq_b = (aa == bb);
            bool aa_eq_c = (aa == cc);
            //string meinString2 = "Dies ist ein String";
            char zeichen = meinString[5];
            Console.WriteLine(meinString);
            Console.WriteLine(cc);
            Console.WriteLine(aa_eq_b);
            Console.WriteLine(aa_eq_c);
            Console.WriteLine(zeichen);
        }
        static void verzweigungen()
        {
            Console.WriteLine("Bitte eine eingabe machen");
            int d = int.Parse(Console.ReadLine());
            int e = int.Parse(Console.ReadLine());

            if (d >= 3 && e == 6)
            {
                Console.WriteLine("Du hast gewonnen!");
            }
            else
            {
                Console.WriteLine("Leider verloren");
            }
        }
        static void cases()
        {
            Console.WriteLine("Du bist jetzt hier, gib etwas ein");
            int i = int.Parse(Console.ReadLine());
            String j = i.ToString();
            switch (j)
            {
                case "1":
                    Console.WriteLine("Du hast EINS eingegeben");
                    break;
                case "2":
                    Console.WriteLine("ZWEI war Deine Wahl");
                    break;
                case "3":
                    Console.WriteLine("Du tipptest eine DREI");
                    break;
                case "4":
                    Console.WriteLine("Zahl meiner Wahl");
                    break;
                default:
                    Console.WriteLine("Die Zahl " + j + " kenne ich nicht");
                    break;
                    // Compilerfehler, da von einem case nicht mehr ins andere gesprungen werden darf.
            }
        }
        static void ifelse()
        {
            Console.WriteLine("Du bist jetzt in einer if/elsec");
            int i = int.Parse(Console.ReadLine());
            String j = i.ToString();
            if (j == "1")
            {
                Console.WriteLine("Du hast EINS eingegeben");
            }
            else if (j == "2")
            {
                Console.WriteLine("ZWEI war Deine Wahl");
            }
            else if (j == "3")
            {
                Console.WriteLine("Du tipptest eine DREI");
            }
            else if (j == "4")
            {
                Console.WriteLine("Zahl meiner Wahl");
            }
            else 
            {
                Console.WriteLine("Die Zahl " + j + "kenne ich nicht");
            }
        } 

        static void whilecondition()
        {
            Console.WriteLine("Du bist jetzt in der while-schleife");
            int k = 0;
            while(k<10)
            {
                k++;
                Console.WriteLine(k);
            }
        }

        static void forwhile()
        {
            Console.WriteLine("Hier soll eine for-Schleife in eine while-schleife umgewandelt werden.");
            string[] someStrings = 
                {
                    "Hier",
                    "sehen",
                    "wir",
                    "einen",
                    "Array",
                    "von",
                    "Strings"
                };
  
                /*for (int i = 0; i < 5; i++)
                {
                    Console.WriteLine(someStrings[i]); //Es wird nur "Hier sehen wir einen Array" ausgegeben
                }
                */
                int k = 0;
                while (k<someStrings.Length)
                {
                Console.WriteLine(someStrings[k]);
                k++;
                }
        

                Console.WriteLine("Hier ist die do-while");
                int l = 0;
                do
                {
                Console.WriteLine(someStrings[l]);
                l++;
                }
                while (l < someStrings.Length);

                int m = 0;
                while(true)
                {
                Console.WriteLine(someStrings[m]);
                if(m > someStrings.Length)
                break;
                m++;
                }
        
        }
    }
}

