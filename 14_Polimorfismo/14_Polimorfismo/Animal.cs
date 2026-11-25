using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14_Polimorfismo
{
    public class Animal
    {
        //Propiedades
        public string Nombre { get; set; }
        public string Especie { get; set; }
        public int Patas { get; set; }
        public bool TieneCola { get; set; }

        //Constructor
        public Animal(string nombre, string especie, int patas, bool tieneCola)
        {
            this.Nombre = nombre;
            this.Especie = especie;
            this.Patas = patas;
            this.TieneCola = tieneCola;
        }

        //Metodos
        /*Polimorfismo: es un pilar de la programacion orientada objetos en
        el cual un metodo responde de diferente manera en cada uno de los
        hijos de una clase heredada.
        En C# para poder indicar que un metodo soporta polimorfismo
        se le coloca la clausula: virtual.*/
        public virtual void Imprimir()
        {
            Console.WriteLine("--------- Animal ---------");
            Console.WriteLine($"Nombre: {this.Nombre}");
            Console.WriteLine($"Especie: {this.Especie}");
            Console.WriteLine($"Numero de Patas: {this.Patas}");
            Console.WriteLine($"Tiene Cola: {(this.TieneCola ? "Si" : "No")}");
        }
        public virtual void Hablar()
        {
            Console.WriteLine($"El animal {this.Nombre} se está comunicando.");
        }   
    }
}
