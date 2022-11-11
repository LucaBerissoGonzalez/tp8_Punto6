using System;

namespace tp8_Punto6
{
    class Program
    {
        static void Main(string[] args)
        {
            int [] arregloNumeros = {4, 45, 67, 20, 98, 140, 41, 37, 76, 83};
            int valor;

            Console.WriteLine("Ingrese un valor: ");
            valor = Convert.ToInt32(Console.ReadLine());

            buscarArreglo(arregloNumeros, valor);

            Console.WriteLine("Presione una tecla para salir...");
            Console.ReadKey();

        }

        static void buscarArreglo(int [] numeros, int buscar){

            bool encontrado = false;

            for(int i = 0; i < numeros.Length; i++)
            {
                if  (numeros[i] == buscar){
                    encontrado = true;
                }
            }

            Console.WriteLine(encontrado == true ? "El valor SI Fue encontrado" : "El valor NO fue encontrado");
        }
    }
}
