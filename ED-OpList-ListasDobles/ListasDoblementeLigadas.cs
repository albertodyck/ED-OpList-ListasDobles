using System;
using System.Collections.Generic;
using System.Text;

namespace ED_OpList_ListasDobles
{
    public class ListasDoblementeLigadas
    {
        private Nodo nodoInicial;//No se utilizara solo marca el inicio
        private Nodo nodoActual;

        public ListasDoblementeLigadas()
        {
            nodoInicial = new Nodo();
            //de momento nodo inicial no esta enlazado a nada
            nodoInicial.Anterior = null;
            nodoInicial.Siguiente = null;
        }

        public string RecorrerLista()
        {
            string datos = string.Empty;

            nodoActual = nodoInicial;
            //mientras sea diferente de nulo, nulo es llegar al final de la lista
            while (nodoActual.Siguiente != null)
            {
                nodoActual = nodoActual.Siguiente;
                datos += $"{nodoActual.Dato}\n";
            }
            return datos;
        }

        public void VaciarLista()
        {
            //Con eliminar el primer enlace que apunta al siguiente nodo es suficiente
            //garbage collector se lleva todo a la memoria
            nodoInicial.Siguiente = null;
        }

        public bool ValidaVacia()
        {
            //Si el enlace del primer elemento es nulo, no hay mas elementos
            return (nodoInicial.Siguiente==null);
        }

        public void AgregarNodo(string dato)
        {
            //nos colocamos al inicio
            nodoActual = nodoInicial;
            //recorremos hacia adelante a fin de encontrar donde colocar el dato
            while (nodoActual.Siguiente != null)
            {
                nodoActual = nodoActual.Siguiente;
            }
            //salimos cuando encontramos el ultimo nodo con propiedad nulo
            //creamos el nodo nuevo en esa posicion
            Nodo nodoNuevo = new Nodo();
            //grabamos dato en la propiedad del nodo nuevo
            nodoNuevo.Dato = dato;
            //establecemos su propiedad siguiente en nulo al ser el ultimo enlace
            nodoNuevo.Siguiente = null;
            //establecemos su propiedad anterior apuntando al inicio
            nodoNuevo.Anterior = nodoInicial;
            //en nodo actual cuya propiedad siguiente era nulo ahora apuntara al nuevo nodo
            nodoActual.Siguiente = nodoNuevo;
        }

        public void AgregarNodoInicio(string dato)
        {
            //nos colocamos al inicio
            nodoActual = nodoInicial;

            Nodo nodoNuevo = new Nodo();
            nodoNuevo.Dato = dato;
            nodoNuevo.Anterior = nodoInicial;
            nodoNuevo.Siguiente = nodoInicial.Siguiente;
            nodoInicial.Siguiente = nodoNuevo;
            nodoNuevo.Siguiente.Anterior = nodoNuevo;

        }

    }
}
