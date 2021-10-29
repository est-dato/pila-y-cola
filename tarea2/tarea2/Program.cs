using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tarea2
{
    class Program
    {
        static void Main(string[] args)
        {
            Queue cola = new Queue();
            for (int i = 0; i < 6; i++)
            {
                Console.Write("Ingre un numero:");
                cola.Enqueue(Console.ReadLine());
            }

            for (int i = 0; i < 6; i++)
            {
                Console.WriteLine(cola.Dequeue());
            }
            Console.ReadKey();
        }
    }
}
