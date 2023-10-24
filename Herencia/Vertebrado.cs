using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Herencia
{
    internal class Vertebrado : Animal
    {
        public string? tipo;
        public bool tienePatas;
        public bool esDomestico;
        public bool esHerviboro;
        public bool esCarnivoro;

        public void imprimirVertebrado()
        {
            Console.WriteLine("Tipo: " + tipo);
            Console.WriteLine("Tiene Patas: " + tienePatas);
            Console.WriteLine("Es doméstico: " + esDomestico);
            Console.WriteLine("Es hervíboro: " + esHerviboro);
            Console.WriteLine("Es carnívoro: " + esCarnivoro);
        }
    }
}
