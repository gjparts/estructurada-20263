using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14_Polimorfismo
{
    public class Perro : Animal
    {
        //Propiedades
        public string Apodo { get; set; }
        public string Raza { get; set; }

        //Constructor
        public Perro(int patas, bool tieneCola, string apodo, string raza)
            : base("Perro","Canino", patas, tieneCola)
        {
            this.Apodo = apodo;
            this.Raza = raza;
        }

        //Metodos
        public void Jugar()
        {
            Console.WriteLine("Corre en circulos y ladra");
        }
        public override void Hablar()
        {
            //Override total
            Console.WriteLine("Guau Arf Woof Bark");
        }
        public override void Imprimir()
        {
            //Override parcial
            base.Imprimir();
            Console.WriteLine($"Apodo: {this.Apodo}");
            Console.WriteLine($"Raza: {this.Raza}");
        }
    }
}
