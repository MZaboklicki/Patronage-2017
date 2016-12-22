using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace core1
{
    public class Program
    {
        public static void Main(string[] args)
        {

            Console.Clear();
            string[] arg = Environment.GetCommandLineArgs();
            string path;
            try
            {
               path = arg[1];
            }
            catch
            {
                Console.WriteLine("Nie podano argumentu ");
                Console.ReadLine();
                return;
            }
           
                
                 Console.WriteLine("Podana sciezka: "+path);
                System.IO.DirectoryInfo dir = new System.IO.DirectoryInfo(path);
            if (dir.Exists)
            {
                Console.WriteLine("Katalog istnieje \n");
                Console.WriteLine("Sciezka do pliku \t \t \t data utworzenia \n");
                System.IO.FileInfo[] file = dir.GetFiles();
                int i = 1;
                if (file.Length == 0)
                {
                    Console.WriteLine("Brak plikow do wyswietlenia");
                }
                foreach (System.IO.FileInfo fil in file)
                {
                    string name = fil.FullName;
                    if (name.Length > 30)
                    {
                        name = "...";
                        for (int j = 20; j > 0; j--)
                        {
                            name = name + fil.FullName[(int)(fil.FullName.Length) - 1 - j];
                        }
                    }
                    Console.WriteLine(i + " " + " {0} \t \t {1} ", name, fil.LastAccessTime);
                    i++;
                }
                
            }
            else
            {
                Console.WriteLine("Katalog nie istnieje");
            }         
            
            Console.ReadLine();
        }
                
    }
}
