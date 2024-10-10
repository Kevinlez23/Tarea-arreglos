using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventario
{


    internal class Articulos
    {

        public static int[] id = new int[2]; //codigo del articulo
        public static string[] nombre = new string[2]; //nombre del articulo
        public static int[] Precio = new int[2]; // precio del articulo
        public static int[] cantidad = new int[2]; // cantidad disponible
        public static string[] bodega = new string[2]; // bodega donde se almacena

        //metodo para inicializar arreglos
        public static void inicializarArreglos() 
        {

            for (int i = 0; i < id.Length; i++) 
            {
                id[i] = 0;
                nombre[i] = "";
                Precio[i] = 0;
                cantidad[i] = 0;
                bodega[i] = "";
            
            
            }
            Console.WriteLine("Los arreglos han sido inicializados");
            Console.Clear();


        }




        //metodo para ingresar productos
        public static void ingresarProductos()
        {
            int indice = 0;
            while (indice < id.Length)
            {
                Console.WriteLine("Digite un codigo: ");
                id[indice] = int.Parse(Console.ReadLine());
                Console.WriteLine("Digite un articulo: ");
                nombre[indice] = Console.ReadLine();
                Console.WriteLine("Digite el precio: ");
                Precio[indice] = int.Parse(Console.ReadLine());
                Console.WriteLine("Digite la cantidad de productos: ");
                cantidad[indice] = int.Parse(Console.ReadLine());
                Console.WriteLine("Digite donde se almacena: ");
                bodega[indice] = Console.ReadLine();
                indice++;
                Console.Clear();

            }
            Console.WriteLine("Los articulos han sido ingresados");
        }


            //metodo para modificar productos
        public static void modificarProductos() 
        {
            Console.Clear();
            Console.WriteLine("digite el codigo del articulo que desea modificar: ");
            int nuevocodigo = int.Parse(Console.ReadLine());

            for (int i = 0; i < id.Length; i++)
            {
                if (nuevocodigo == id[i]) 
                {
                    Console.WriteLine($"Codigo: {id[i]} Nombre: {nombre[i]}");
                    Console.WriteLine($"precio: {Precio[i]} cantidad: {cantidad[i]}");
                    Console.WriteLine($"producto almacenado en: {bodega[i]} ");
                    Console.WriteLine($"**************************************");
                    Console.WriteLine("Digite un nuevo nombre: ");
                    nombre[i] = Console.ReadLine();
                    Console.WriteLine("Digite un nuevo precio: ");
                    Precio[i] = int.Parse(Console.ReadLine());
                    Console.WriteLine("Digite la nueva cantidad de productos: ");
                    cantidad[i] = int.Parse(Console.ReadLine());
                    Console.WriteLine("Digite una nueva bodega: ");
                    bodega[i] = Console.ReadLine();
                    break;
                }


                
            }
            
        }


        //metodo para consultar productos
        public static void consultarProductos()
        {
            Console.Clear();
            Console.WriteLine("*** REPORTE DE ARTICULOS ***");
            for (int i = 0; i < id.Length; i++)   
            {
                Console.WriteLine($"Codigo: {id[i]} Nombre: {nombre[i]}");
                Console.WriteLine($"precio: {Precio[i]} cantidad: {cantidad[i]}");
                Console.WriteLine($"producto almacenado en: {bodega[i]} ");
                Console.WriteLine($"**************************************");

            }
            Console.WriteLine("*** FIN DEL REPORTE ***");

        }


        //metodo para excluir productos
        public static void excluirProductos() 
        {
            Console.Clear();
            Console.WriteLine("digite el codigo del articulo que desea eliminar: ");
            int nuevocodigo = int.Parse(Console.ReadLine());

            for (int i = 0; i < id.Length; i++)
            {
                if (nuevocodigo == id[i])
                {
                    Console.WriteLine($"Codigo: {id[i]} Nombre: {nombre[i]}");
                    Console.WriteLine("Articulo eliminado");
                    nombre[i] = "";
                    id[i] = 0;
                    Precio[i] = 0;
                    cantidad[i] = 0;
                    bodega[i] = "";
                    break;
                }
            }

        }


    }
}
