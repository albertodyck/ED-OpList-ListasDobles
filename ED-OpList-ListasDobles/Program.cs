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



        }
    }
}
