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
            do
            {
                Console.Write("Podaj sciezke katalogu: ");
                string path = Console.ReadLine();
                System.IO.DirectoryInfo dir = new System.IO.DirectoryInfo(path);
                if (dir.Exists)
                {
                    Console.WriteLine(dir.FullName);
                    Console.WriteLine("sciezka istnieje \n");
                    System.IO.FileInfo[] file = dir.GetFiles();
                    int i = 1;
                    foreach (System.IO.FileInfo fil in file)
                    {
                        Console.WriteLine(i + " " + fil.FullName +"  " + fil.LastAccessTime);
                        i++;
                    }
                }
                else
                {
                    Console.WriteLine("sciezka nie istnieje");
                }


                Console.ReadLine();

            } while (1==1);      
        }
    }
}
