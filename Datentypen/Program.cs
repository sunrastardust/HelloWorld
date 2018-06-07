using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datentypen
{
    class Program
    {
        // So global wie nötig so lokal wie möglich
        // Wir verwenden wenns geht immer lokale Variabeln
        // um Kollisionen mit anderen Variablen zu vermeiden
        static string test = "testing";

        static void Main(string[] args)
        {
            long Number = 10000000000000;

            // nicht möglich da int zu klein (zu kleiner Wertebereich):
            // int num = 100000000000000;

            //ebenfalls nicht möglich, da double Wert erwartet wird:
            //double wrongIn = "asdf";
            double rightIn = 1.47786;

            // bool auf true setzen
            bool bl = true;
            Console.WriteLine(bl);
            bl = false;
            Console.WriteLine(bl);

            char ch = 'c';
            // char erwartet ein Symbol keine Zahl!
            // char ch = 66;

            Console.WriteLine(ch);

            //Variablen initialisieren mit Hello und World
            string str = "Hello ";
            string str2 = "World";

            //Ausgeben der Variabeln
            Console.Write(str);
            Console.WriteLine(str2);

            //Überschreiben des 2. strings
            str2 = "Haris";

            //erneut ausgeben
            Console.Write(str);
            Console.WriteLine(str2);

            // str2 mit Beutzereingabe überschreiben
            Console.WriteLine("Gib einen neuen Namen ein:");
            str2 = Console.ReadLine();

            // erneut ausgeben
            Console.Write(str);
            Console.WriteLine(str2);

            //diese Zeile ist nicht ausführbar weil
            //hallo danach definiert wird
            //Console.WriteLine(hallo);

            //gobale Variabel testen
            Console.WriteLine(test);

            string hallo;
            //diese Zeile wird nie ausgeführt weil sie 
            //direkt danach überschrieben wird
            hallo = "smthNew";
            hallo = "something different ";
            Console.WriteLine(hallo + Number + " " + rightIn + " test");

        }
        
    }
}
