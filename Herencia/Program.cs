using Herencia;

// Instancia de objeto
//Animal animal = new Animal();
Vertebrado vertebrado = new Vertebrado();
vertebrado.nombre = "Perro";
vertebrado.color = "Blanco";
vertebrado.tamano = "Mediano";
vertebrado.familia = "Husky";
vertebrado.tipo = "Mamífero";
vertebrado.tienePatas = true;
vertebrado.esDomestico = true;
vertebrado.esHerviboro = false;
vertebrado.esCarnivoro = true;

if (vertebrado.validar())
{
    vertebrado.imprimir();
    vertebrado.imprimirVertebrado();
} else
{
    Console.WriteLine("Ingrese todos los datos");
}

