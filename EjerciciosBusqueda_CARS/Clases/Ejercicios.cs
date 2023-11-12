using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjerciciosBusqueda_CARS.Clases
{
    internal class Ejercicios
    {
        //-------------------------------------Ejercicio Lineal1

        public void BusquedaLineal1()
        {
            int[] arreglo = { 1, 3, 5, 6, 8, };
            Console.WriteLine("Ingrese el numero a buscar del 1 al 10");
            int numero = Convert.ToInt32(Console.ReadLine());
            bool centinela = false;
            for (int i = 0; i < arreglo.Length; i++)
            {
                if (arreglo[i] == numero)
                {
                    centinela = true;
                    Console.WriteLine("El numero " + numero + " se encuentra en la posicion " + i);
                }
            }
            if (centinela == false)
            {
                Console.WriteLine("EL numero no existe");
            }
        }
        //-------------------------------------Ejercicio Lineal2

        public void BusquedaLineal2()
        {
            string[] arreglo = { "rojo", "azul", "verde", "rosa" };
            Console.WriteLine("Ingrese un color");
            string color = Console.ReadLine();
            bool centinela = false;
            for (int i = 0; i < arreglo.Length; i++)
            {
                if (arreglo[i] == color)
                {
                    centinela = true;
                    Console.WriteLine("El color " + color + " se encuentra en la posicion " + i);
                }
            }
            if (centinela == false)
            {
                Console.WriteLine("EL color no existe");
            }
        }
        //-------------------------------------Ejercicio Lineal3

        public void BusquedaLineal3()
        {
            int[] arreglo = { 1, 3, 5, 6, 8, };

            for (int i = 0; i < arreglo.Length; i++)
            {
                if (arreglo[i] % 2 == 0)
                {
                    Console.WriteLine("El numero par  se encuentra en la posicion " + i);
                }
            }

        }

        //-------------------------------------Ejercicio Binario1
        public void BusquedaBinaria1()
        {
            int[] arreglo = { 1, 3, 5, 6, 8, };
            Console.WriteLine("Ingrese el numero a buscar del 1 al 10");
            int numero = Convert.ToInt32(Console.ReadLine());
            bool centinela = false;
            int media = 0;
            int inicio = 0;
            int final = 4;
            while (inicio <= final && centinela == false)
            {
                media = (inicio + final) / 2;
                if (arreglo[media] == numero)
                {
                    centinela = true;
                    Console.WriteLine($"El elemento {numero} se encuentra en la posicion {media} ");
                }
                if (arreglo[media] > numero)
                    final = media - 1;
                else
                    inicio = media + 1;
            }
            if (centinela == false)
            {
                Console.WriteLine($"El elemento {numero} no existe ");
            }

        }

        //-------------------------------------Ejercicio Binario2

        public void BusquedaBinaria2()
        {
            string[] arreglo = { "a", "b", "c", "d", "e" };
            Console.WriteLine("Ingrese el caracter a buscar");
            string palabra = Console.ReadLine();
            bool centinela = false;
            int media = 0;
            int inicio = 0;
            int final = arreglo.Length;
            while (inicio <= final && centinela == false)
            {
                media = (inicio + final) / 2;
                if (string.Compare(palabra, arreglo[media]) == 0)
                {
                    centinela = true;
                    Console.WriteLine($"El elemento {palabra} se encuentra en la posicion {media} ");
                }
                if (string.Compare(palabra, arreglo[media]) < 0)
                    final = media - 1;
                else
                    inicio = media + 1;
            }
            if (centinela == false)
            {
                Console.WriteLine($"El elemento {palabra} no existe ");
            }

        }
        //-------------------------------------Ejercicio Binario3

        public void BusquedaBinaria3()
        {
            int[] arreglo = { 1, 3, 5, 7, 8, };

            bool centinela = false;
            int media = 0;
            int inicio = 0;
            int final = 4;
            while (inicio <= final && centinela == false)
            {
                media = inicio + (final - inicio) / 2;
                if (arreglo[media] % 2 == 0)
                {
                    centinela = true;
                    Console.WriteLine($"El elemento {arreglo[media]} se encuentra en la posicion {media}  y es par");

                    if (media == 0 || arreglo[media - 1] % 2 != 0)
                    {
                    }
                    else
                    {
                        final = media - 1;
                    }
                }
                else { inicio = media + 1; }

            }
            if (centinela == false)
            {
                Console.WriteLine($"El elemento Par no existe ");
            }

        }
    }
}
