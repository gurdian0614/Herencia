using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Herencia
{
    internal class Animal
    {
        public string? nombre;
        public string? color;
        public string? tamano;
        public string? familia;

        /**
         * Metodo para imprimir datos 
         */
        public void imprimir()
        {
            Console.WriteLine("Nombre: " + nombre);
            Console.WriteLine("Color: " + color);
            Console.WriteLine("Tamaño: " + tamano);
            Console.WriteLine("Familia: " + familia);
        }

        /**
         * Metodo para validar datos 
         */
        public bool validar()
        {
            if (nombre != null && color != null && tamano != null && familia != null) {
                return true;
            } else
            {
                return false;
            }
        }
    }
}
