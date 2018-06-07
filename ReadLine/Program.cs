using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReadLine
{
    class Program
    {
        static void Main(string[] args)
        {
            // User bescheid geben was zu tun ist
            Console.WriteLine("Geben sie etwas ein:");
            // mir reicht eine Zeile nicht aus
            //deswegen hier noch eine Zeile
            //Auf eine Benutzereingabe warten und iese dann
            //ausgeben
            Console.WriteLine(Console.ReadLine());

            //leere Zeile ausgeben
            Console.WriteLine();

            //Willkürliche zweite Eingabe
            Console.WriteLine("Gebn Sie die Schuhgröße ein");
            Console.WriteLine(Console.ReadLine());

            //mit Write können Sie alles in einer Zeile ausgeben
            Console.Write(" test");
            Console.Write(" gleiche Zeile");
            Console.WriteLine();
                
                
              
        }
    }
}
