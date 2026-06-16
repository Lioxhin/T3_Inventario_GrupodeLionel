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
                    case 1:
                        RegistrarElemento();
                        break;
                    case 2:
                        MostrarElementos();
                        break;
                    case 3:
                        BuscarElemento();
                        break;
                    case 4:
                        ModificarElemento();
                        break;
                    case 9:
                        Console.WriteLine("Saliendo del programa...");
                        break;
                    default:
                        if (opcion >= 5 && opcion <= 8)
                        {
                            Console.WriteLine("Proximamente... Presione Enter.");
                            Console.ReadLine();
                        }
                        break;
                }

            } while (opcion != 9);
        }
        static void RegistrarElemento()
        {
            Console.Clear();
            Console.WriteLine("--- REGISTRAR NUEVO PRODUCTO ---");

            if (contador >= 100)
            {
                Console.WriteLine("Error: Inventario lleno (Maximo 100).");
                Console.ReadLine();
                return;
            }

            Console.Write("Ingrese codigo: ");
            string codigo = Console.ReadLine();
            while (codigo == "")
            {
                Console.WriteLine("El codigo no puede estar vacio.");
                Console.Write("Ingrese codigo nuevamente: ");
                codigo = Console.ReadLine();
            }

            Console.Write("Ingrese nombre/descripcion: ");
            string nombre = Console.ReadLine();
            while (nombre == "")
            {
                Console.WriteLine("El nombre no puede estar vacio.");
                Console.Write("Ingrese nombre nuevamente: ");
                nombre = Console.ReadLine();
            }

            Console.Write("Ingrese precio: ");
            double precio = double.Parse(Console.ReadLine());
            while (precio < 0)
            {
                Console.WriteLine("El precio no puede ser negativo.");
                Console.Write("Ingrese precio nuevamente: ");
                precio = double.Parse(Console.ReadLine());
            }

            Console.Write("Ingrese stock: ");
            int stock = int.Parse(Console.ReadLine());
            while (stock < 0)
            {
                Console.WriteLine("El stock no puede ser negativo.");
                Console.Write("Ingrese stock nuevamente: ");
                stock = int.Parse(Console.ReadLine());
            }

            codigos[contador] = codigo;
            nombres[contador] = nombre;
            precios[contador] = precio;
            stocks[contador] = stock;

            contador++;

            Console.WriteLine("\n¡Producto registrado con exito! Presione Enter.");
            Console.ReadLine();
        }

        static void MostrarElementos()
        {
            Console.Clear();
            Console.WriteLine("--- LISTA DE PRODUCTOS ---");

            if (contador == 0)
            {
                Console.WriteLine("No hay productos registrados en el sistema.");
                Console.ReadLine();
                return;
            }

            for (int i = 0; i < contador; i++)
            {
                Console.WriteLine("Posicion: " + i);
                Console.WriteLine("Codigo: " + codigos[i]);
                Console.WriteLine("Nombre: " + nombres[i]);
                Console.WriteLine("Precio: S/. " + precios[i]);
                Console.WriteLine("Stock: " + stocks[i] + " unidades");
                Console.WriteLine("--------------------------------");
            }

            Console.WriteLine("Fin de la lista. Presione Enter.");
            Console.ReadLine();
        }

        static void BuscarElemento()
        {
            Console.Clear();
            Console.WriteLine("--- BUSCAR PRODUCTO POR CODIGO ---");

            if (contador == 0)
            {
                Console.WriteLine("No hay productos registrados para buscar.");
                Console.ReadLine();
                return;
            }

            Console.Write("Ingrese el codigo del producto a buscar: ");
            string codigoBuscar = Console.ReadLine();

            bool encontrado = false;

            for (int i = 0; i < contador; i++)
            {
                if (codigos[i] == codigoBuscar)
                {
                    Console.WriteLine("\n¡Producto Encontrado!");
                    Console.WriteLine("Posicion: " + i);
                    Console.WriteLine("Codigo: " + codigos[i]);
                    Console.WriteLine("Nombre: " + nombres[i]);
                    Console.WriteLine("Precio: S/. " + precios[i]);
                    Console.WriteLine("Stock: " + stocks[i] + " unidades");
                    encontrado = true;
                    break;
                }
            }

            if (encontrado == false)
            {
                Console.WriteLine("\nEl codigo '" + codigoBuscar + "' no existe en el sistema.");
            }

            Console.WriteLine("\nPresione Enter para continuar.");
            Console.ReadLine();
        }

        static void ModificarElemento()
        {
            Console.Clear();
            Console.WriteLine("--- MODIFICAR PRODUCTO ---");

            if (contador == 0)
            {
                Console.WriteLine("No hay productos registrados para modificar.");
                Console.ReadLine();
                return;
            }

            Console.Write("Ingrese el codigo del producto a modificar: ");
            string codigoModificar = Console.ReadLine();

            int posicionEncontrada = -1;

            for (int i = 0; i < contador; i++)
            {
                if (codigos[i] == codigoModificar)
                {
                    posicionEncontrada = i;
                    break;
                }
            }

            if (posicionEncontrada == -1)
            {
                Console.WriteLine("\nEl codigo '" + codigoModificar + "' no fue encontrado.");
                Console.ReadLine();
                return;
            }

            Console.WriteLine("\nProducto encontrado: " + nombres[posicionEncontrada]);
            Console.WriteLine("Ingrese los nuevos datos del producto:");

            Console.Write("Nuevo nombre: ");
            string nuevoNombre = Console.ReadLine();
            while (nuevoNombre == "")
            {
                Console.WriteLine("El nombre no puede estar vacio.");
                Console.Write("Nuevo nombre nuevamente: ");
                nuevoNombre = Console.ReadLine();
            }

            Console.Write("Nuevo precio: ");
            double nuevoPrecio = double.Parse(Console.ReadLine());
            while (nuevoPrecio < 0)
            {
                Console.WriteLine("El precio no puede ser negativo.");
                Console.Write("Nuevo precio nuevamente: ");
                nuevoPrecio = double.Parse(Console.ReadLine());
            }

            Console.Write("Nuevo stock: ");
            int nuevoStock = int.Parse(Console.ReadLine());
            while (nuevoStock < 0)
            {
                Console.WriteLine("El stock no puede ser negativo.");
                Console.Write("Nuevo stock nuevamente: ");
                nuevoStock = int.Parse(Console.ReadLine());
            }

            nombres[posicionEncontrada] = nuevoNombre;
            precios[posicionEncontrada] = nuevoPrecio;
            stocks[posicionEncontrada] = nuevoStock;

            Console.WriteLine("\n¡Datos actualizados con éxito! Presione Enter.");
            Console.ReadLine();
        }
    }
}