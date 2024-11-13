using ListaLigada.Logica;
using System.ComponentModel.Design;

internal class Program
{    
    private static void Main(string[] args)
    {
        Console.WriteLine("Lista ligada simple\n");
                
        var singleList = new SingleList<String>();

        int opcion = 0;

        do
        {
            opcion = Menu();
            switch (opcion)
            {
                case 1: AgregarElemento();   break;
                case 2: MostrarLista();  break;
                case 3: EliminarElemento();  break;

                case 0: Console.WriteLine("Presione una tecla para cerrar el programa"); ; break;
                    //default: Console.WriteLine("La opción no existe"); 
                    //    break;


            }


        } while (opcion!=0);


        void AgregarElemento()
        {
            Console.Write("** Agregar elementos a la lista **\n");
            Console.Write("Escriba el nombre del nodo:  ");

            var nombre = Console.ReadLine();
            singleList.Add(nombre);
        }

        void MostrarLista() {

            if (singleList.isEmpty)
            {
                Console.WriteLine("La lista está vacía");
                
            }
            else
            {
                Console.WriteLine(singleList);
            }

            
        }
        void EliminarElemento()
        {
            throw new NotImplementedException();
        }


        Console.ReadKey();
    }//Fin de main

   

    private static int Menu()
    {
        Console.WriteLine("Menú\n");
        Console.WriteLine("1. Agregar elemento");
        Console.WriteLine("2. Mostrar lista");
        Console.WriteLine("3. Eliminar elemento");

        Console.WriteLine("0. Salir");

        bool esValido = false;

        int opcion = 0;
        do
        {
            Console.Write("\nSeleccione una opción del menú:  \n");
            var opcionCapturada = Console.ReadLine();            

            if (!int.TryParse(opcionCapturada, out opcion) || opcion < 0 || opcion > 2)
            {
                Console.WriteLine("Ingrese una opción válida\n");
                esValido=false;
            }
            else
            {
                esValido = true;
            }
        } while(esValido==false);

        return opcion;       

    }
}