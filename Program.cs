using System;

namespace GestionInventario
{
    class Program
    {
        static string[] codigos = new string[100];
        static string[] nombres = new string[100];
        static double[] precios = new double[100];
        static int[] stocks = new int[100];

        static int contador = 0;

        static void Main(string[] args)
        {
            int opcion = 0;

            do
            {
                Console.Clear();
                Console.WriteLine("--- MENU PRINCIPAL ---");
                Console.WriteLine("1. Registrar elemento");
                Console.WriteLine("2. Mostrar todos los elementos");
                Console.WriteLine("3. Buscar elemento por codigo");
                Console.WriteLine("4. Modificar los datos de un elemento");
                Console.WriteLine("5. Insertar un elemento en posicion especifica");
                Console.WriteLine("6. Eliminar un elemento");
                Console.WriteLine("7. Ordenar elementos usando el metodo burbuja");
                Console.WriteLine("8. Mostrar resumen del conjunto de datos");
                Console.WriteLine("9. Salir del sistema");
                Console.Write("Ingrese opcion: ");

                opcion = int.Parse(Console.ReadLine());

                switch (opcion)
                {
                    case 9:
                        Console.WriteLine("Saliendo del programa...");
                        break;
                    default:
                        if (opcion >= 1 && opcion <= 8)
                        {
                            Console.WriteLine("Proximamente... Presione Enter.");
                            Console.ReadLine();
                        }
                        break;
                }

            } while (opcion != 9);
        }
    }
}