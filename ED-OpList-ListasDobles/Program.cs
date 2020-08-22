using System;

namespace ED_OpList_ListasDobles
{
    class Program
    {
        static void Main(string[] args)
        {
            ListasDoblementeLigadas lista = new ListasDoblementeLigadas();
            Console.WriteLine(lista.RecorrerLista());

            lista.AgregarNodo("Uno");
            lista.AgregarNodo("Dos");
            lista.AgregarNodo("Tres");

            Console.WriteLine(lista.RecorrerLista());

            lista.AgregarNodoInicio("Cero");
            Console.WriteLine(lista.RecorrerLista());

            Console.WriteLine("--------Buscando Dos--------");
            Nodo nodo = lista.Buscar("Dos");
            if (nodo == null)
            {
                Console.WriteLine("No se encontro");
            }
            else
            {
                Console.WriteLine($"Se encontro {nodo.Dato}");
            }


            Console.WriteLine("----- Buscando por indice -----");
            int Indice = 1;
            Nodo nodoIndice = lista.BuscarIndice(Indice);
            if (nodoIndice == null)
            {
                Console.WriteLine("No se encontró");
            }
            else
            {
                Console.WriteLine($"Se encontró {nodoIndice.Dato} en el indice {Indice}");
            }


            Console.WriteLine("----- Buscando nodo anterior -----");
            Nodo nodoAnterior = lista.BuscarAnterior("Dos");
            if (nodoAnterior == null)
            {
                Console.WriteLine("No se encontró");
            }
            else
            {
                Console.WriteLine($"Se encontró {nodoAnterior.Dato}");
            }

            Console.WriteLine("----- Buscando nodo Siguiente -----");
            Nodo nodoSiguiente = lista.BuscarSiguiente("Dos");
            if (nodoSiguiente == null)
            {
                Console.WriteLine("No se encontró");
            }
            else
            {
                Console.WriteLine($"Se encontró {nodoSiguiente.Dato}");
            }

            Console.WriteLine("----- Eliminando un nodo -----");
            lista.BorrarNodo("Dos");
            Console.WriteLine(lista.RecorrerLista());
        }
    }
}
