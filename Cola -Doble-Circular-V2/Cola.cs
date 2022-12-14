using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cola__Doble_Circular_V2
{
    class Cola
    {
        int TOP = 5;
        int CERO = 0;
        int final = -1, inicio = 4;
        int PI = 5, PF = -1;
        int[] dato { set; get; }
        public void Inicializar()
        {
            dato = new int[TOP];
        }
        //Encolar Inicio
        public void encolarInicio(int Num)
        {
            if (PI == 5 && PF == -1)
            {
                PF++;
                dato[PF] = Num;
                return;
            }
            if (PF + 1 == PI)
            {
                Console.WriteLine("La cola esta llena");
                Console.ReadKey();
                return;
            }
            if (PI == CERO)
            {
                PI = TOP;
                //Console.WriteLine("SIUUUUUUUUUUUu");
            }
            PI--;
            dato[PI] = Num;/*
            Console.WriteLine("PI: " + PI);
            Console.WriteLine("PF: " + PF);*/
            Console.ReadKey();
        }
        //Desencolar Inicio
        public void desencolarInicio()
        {
            if (PI == TOP)
            {
                PI = CERO;
            }
            if (PI == PF)
            {
                PI = 5;
                PF = -1;
                Console.WriteLine("Los indices han coincidido");
                Console.ReadKey();
                return;
            }
            //
            dato[PI] = CERO;
            PI++;/*
            Console.WriteLine("PI: " + PI);
            Console.WriteLine("PF: " + PF);*/
            Console.ReadKey();
        }
        //Encolar Final
        public void encolarFinal(int Num)
        {
            if (PF + 1 == PI)
            {
                Console.WriteLine("La cola esta llena");
                Console.ReadKey();
                return;
            }
            if (PF == inicio)
            {
                PF = final;
                //Console.WriteLine("SIUUUUUUUUUUUu");
            }
            //
            if (PI == PF)
            {
                PF++;
                dato[PF] = Num;
                return;
            }
            PF++;
            dato[PF] = Num;/*
            Console.WriteLine("PI: " + PI);
            Console.WriteLine("PF: " + PF);*/
            Console.ReadKey();
        }
        //Desencolar Final
        public void desencolarFinal()
        {
            if (PF == -1)
            {
                PF = inicio;
            }
            //
            if (PI == PF)
            {
                PI = 5;
                PF = -1;
                Console.WriteLine("Los indices han coincidido");
                Console.ReadKey();
                return;
            }/*
            Console.WriteLine("PI: " + PI);
            Console.WriteLine("PF: " + PF);*/
            PF--;
            Console.ReadKey();
        }
        //Mostrar
        public void mostrarDatos()
        {
            if (PF < PI)
            {
                for (int i = PI; i <= inicio; i++)
                {
                    Console.WriteLine("|" + dato[i] + "|");
                }
                for (int i = 0; i <= PF; i++)
                {
                    Console.WriteLine("|"+dato[i]+"|");
                }/*
                Console.WriteLine("PI: " + PI);
                Console.WriteLine("PF: " + PF);*/
                Console.ReadKey();
                return;
            }
            else if (PF >= PI)
            {
                for (int i = PI; i <= PF; i++)
                {
                    Console.WriteLine("|" + dato[i] + "|");
                }/*
                Console.WriteLine("PI: " + PI);
                Console.WriteLine("PF: " + PF);*/
                Console.ReadKey();
                return;
            }/*
            Console.WriteLine("PI: " + PI);
            Console.WriteLine("PF: " + PF);*/
            Console.ReadKey();
        }
    }
}
