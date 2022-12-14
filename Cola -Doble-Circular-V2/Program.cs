using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cola__Doble_Circular_V2
{
    class Program
    {
        static void Main(string[] args)
        {
            int Num;
            Cola Cola1 = new Cola();
            Cola1.Inicializar();
            int op;
            do
            {
                Console.WriteLine("-----Menu de opciones-----");
                Console.WriteLine("1)-Encolar Final");
                Console.WriteLine("2)-Encolar Inicio");
                Console.WriteLine("3)-Desencolar Final");
                Console.WriteLine("4)-Desencolar Inicio");
                Console.WriteLine("5)-Mostrar Cola");
                Console.WriteLine("6)-Creditos, SIU!");
                Console.WriteLine("0)-Salir");
                Console.WriteLine();
                Console.Write("Elige una opcion: ");
                op = Convert.ToInt16(Console.ReadLine());
                Console.WriteLine("----------------------------");
                switch (op)
                {
                    case 1:
                        Console.Write("Ingresa un numero: ");
                        Num = Convert.ToInt16(Console.ReadLine());
                        Cola1.encolarFinal(Num);
                        break;
                    case 2:
                        Console.Write("Ingresa un numero: ");
                        Num = Convert.ToInt16(Console.ReadLine());
                        Cola1.encolarInicio(Num);
                        break;
                    case 3:
                        Cola1.desencolarFinal();
                        break;
                    case 4:
                        Cola1.desencolarInicio();
                        break;
                    case 5:
                        Cola1.mostrarDatos();
                        break;
                    case 6:
                        Console.WriteLine("------Creditos-----");
                        Console.WriteLine("Cristian Sebastian Avitia");
                        Console.WriteLine("Abelardo Garcia Reyes");
                        Console.WriteLine("4-A");
                        Console.ReadKey();
                        break;
                    default:
                        Console.WriteLine("Opcion no valida!");
                        break;
                }
                Console.WriteLine();
                Console.Clear();
            } while (op != 0);
        }
    }
}
