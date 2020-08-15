using System;
using System.Collections.Generic;
using System.Text;

namespace ED_OpList_ListasDobles
{
    public class Nodo
    {
        private Nodo anterior;
        private string dato;
        private Nodo siguiente;

        //ctrl + . despues de seleccionar para generar la propiedad
        public Nodo Anterior { get => anterior; set => anterior = value; }
        public string Dato { get => dato; set => dato = value; }
        public Nodo Siguiente { get => siguiente; set => siguiente = value; }

        //ctor para generar el constructor+tap tap
        public Nodo()
        {
            //estableceremos las propiedades anterior y siguiente como null
            anterior = null;
            siguiente = null;
        }

    }
}
