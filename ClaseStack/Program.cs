using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClaseStack
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack<int> pila = new Stack<int>();
            int respuesta;
            do
            {

                Console.Clear();
                Console.WriteLine("Ejemplo de pila");
                Console.WriteLine("1.- Insertar dato");
                Console.WriteLine("2.- Eliminar dato");
                Console.WriteLine("3.- Mostrar datos");
                Console.WriteLine("4.- Vaciar datos");
                int opcion = int.Parse(Console.ReadLine());
                switch (opcion)
                {
                    case 1:
                        Console.WriteLine("Ingrese dato");
                        pila.Push(int.Parse(Console.ReadLine()));
                        Console.WriteLine("Dato insertado con exito");
                        break;
                    case 2:
                        pila.Pop();
                        Console.WriteLine("Dato eliminado con exito");
                        break;
                    case 3:
                        foreach (var item in pila)
                        {
                            Console.WriteLine("Dato: " + item);
                        }
                        break;
                    case 4:
                        pila.Clear();
                        break;
                    default:
                        Console.WriteLine("No existe opcion");
                        break;
                }

                Console.WriteLine("¿Desea realizar otra opcion?");
                Console.WriteLine("SI= 1 ------- NO=2");
                respuesta = int.Parse(Console.ReadLine());
            } while (respuesta==1);
        }
    }
}
