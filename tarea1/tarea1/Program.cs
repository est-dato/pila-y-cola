using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tarea1
{
    class Program
    {
        static void Main(string[] args)
        {
            
                Stack pila = new Stack();
                for (int i = 0; i < 6; i++)
                {
                    Console.Write("Ingrese un numero:");
                    pila.Push(Console.ReadLine());
                }

                for (int i = 0; i < 6; i++)
                {
                    Console.WriteLine(pila.Pop());
                }
            Console.ReadKey();
            
        }
    }
}
