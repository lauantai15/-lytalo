using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TiedonTallennus
{
    class Program
    {
        static void Main(string[] args)
        {
            string tiedosto = @"C:\Temp\Lämpötila.txt";
            //luetaan tiedostosta aiemmin asetettu lämpötila
            if (File.Exists(tiedosto))
            {
                string aiempiAevo = File.ReadAllText(tiedosto);
                Console.WriteLine("Aiemmin asetettu lämpötila on " + aiempiAevo + " astetta.");
            }
            else
                {
                Console.WriteLine("Tervetuloa!");
            }

            int lämpötila = 0;
            Console.Write("Anna uusi lämpötila");
            string syöte = Console.ReadLine();
            lämpötila = int.Parse(syöte);
            //tiedoston tallentaminen

            
            File.WriteAllText(tiedosto, lämpötila.ToString());
            Console.WriteLine("Uusi lämpötila tallennettu.");
            Console.ReadLine();
        }
    }
}
