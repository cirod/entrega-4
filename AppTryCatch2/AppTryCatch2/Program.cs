using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppTryCatch2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Tablas de Multiplicar");
            for (int i=5;i<=50;i++)
            {
                 Console.WriteLine("Tabla del "+i+" :");

                for (int ii=0;ii<=10;ii++)
                {
                    try
                    {
                        Console.WriteLine(i + " x " + ii + " = " + i * ii);
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine("Errrorrrrrrr Noooooo que pasioooooo");
                    }
                    }
            }
            Console.ReadKey();
        }
    }
}
