using EjerciciosBusqueda_CARS.Clases;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjerciciosBusqueda_CARS
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Ejercicios ejercicios = new Ejercicios();
            //------------------------------------------Ejercicio1
            ejercicios.BusquedaLineal1();
            Console.ReadKey();
            //------------------------------------------Ejercicio2

            ejercicios.BusquedaLineal2();
            Console.ReadKey();
            //------------------------------------------Ejercicio3

            ejercicios.BusquedaLineal3();
            Console.ReadKey();
            //------------------------------------------Ejercicio4

            ejercicios.BusquedaBinaria1();
            Console.ReadKey();
            //------------------------------------------Ejercicio5

            ejercicios.BusquedaBinaria2();
            Console.ReadKey();
            //------------------------------------------Ejercicio6

            ejercicios.BusquedaBinaria3();
            Console.ReadKey();

        }
    }
}
