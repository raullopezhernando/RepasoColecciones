using System;
using System.Collections;

namespace RepasoColecciones
{
    class Program
    {
        static void Main(string[] args)
        {
            //// ArrayList

            //// Definicion de ArrayList
            //ArrayList Nombre = new ArrayList();

            //// Agregar informacion

            //ArrayList miArrayList = new ArrayList();

            //miArrayList.Add(5);
            //miArrayList.Add(10);

            //Console.WriteLine(miArrayList[1]);


            int indice = 0;
            int cantidad = 0;

            ArrayList datos = new ArrayList ();

            datos.Add(7);
            datos.Add(5);
            datos.Add(1);

            Console.WriteLine("Mostramos los valores iniciales del ArrayList : ");
             

            // Addicionamos elementos al ArrayList

            datos.Add(4);
            datos.Add(5);


            //Obtenemos el indice

            indice = datos.Add(10);

            Console.WriteLine("Despues de agregar mas elementos: ");
            Imprime(datos);
            Console.WriteLine("El ultimo elemento tiene el indice de {0} ", indice);
            Console.WriteLine("\n.............");


            // Imprimir un elemento en particular

            Console.WriteLine("El valor del indice 2 es  de {0} ", datos[2]);

            //Modificamos un dato

            datos[3] = 55;

            Console.WriteLine("Despues de modificar el dato : ");
            Imprime(datos);


            // Obtenemos la cantidad de datos

            cantidad = datos.Count;
            Console.WriteLine("La cantidad de elementos es  de {0} ", cantidad);
            Console.WriteLine("\n.............");

            // Insertamos un elemento en una posicion en particular

            datos.Insert(2, 88);
            Console.WriteLine("Despues de insertar el elemento:");
            Console.WriteLine("\n.............");

            // Elminando un elemento

            datos.RemoveAt(4);

            Console.WriteLine("Despues de eliminar el elemento ");
            Console.WriteLine("\n.............");

            // Encontramos el indice donde se encuentra el primer numero 5

            indice = datos.IndexOf(5);

            Console.WriteLine("El primer numero 5 se encuentra en el indice {0}", indice);
            Console.WriteLine("\n.............");


        }


        static void Imprime(ArrayList arreglo) 
        {

            foreach (int n in arreglo) 
            {
                Console.Write("{0} ",n);
            }

            Console.WriteLine("\n.............");

        }
    }
}
