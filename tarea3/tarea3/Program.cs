using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tarea3
{
    class Program
    {
        static void Main(string[] args)
        {
            Queue cola = new Queue();
            string frase = " ";
            while (frase != "")
            {
                Console.Write("Ingresa una frase (enter para finalizar):");
                frase = Console.ReadLine();
                if (frase != "")
                {
                    cola.Enqueue(frase);
                }
            }

            int cantidad = cola.Count;

            for (int i = 0; i < cantidad; i++)
            {
                Console.WriteLine(cola.Dequeue());
            }
            Console.ReadKey();
        }
    }
}
