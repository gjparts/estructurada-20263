using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14_Polimorfismo
{
    public class Gato : Animal
    {
        //Propiedades
        public string Apodo { get; set; }
        public bool TienePelaje { get; set; }

        //Constructor
        public Gato(int patas, bool tieneCola, string apodo, bool tienePelaje)
            :base("Gato","Felino",patas, tieneCola)
        {
            this.Apodo = apodo;
            this.TienePelaje = tienePelaje;
        }
        //Observe que el Nombre del animal y la Especie las enviamos con valores
        //constantes ya que un Gato siempre va a ser Felino y siempre va a ser Gato
        //Metodos
        public void Ronronear()
        {
            Console.WriteLine("Prrrrrrrrrrrrr");
        }
        /*Ahora toca aplicar polimorfismo a los metodos que hemos heredado.
        Existen dos tipos de polimorfismo:
        1) Polimorfismo total
        2) Polimorfismo parcial
        Para aplicar polimorfismo en la clase hija se usa la clausula: override*/
        public override void Hablar()
        {
            //Override Total o Completo: consiste en cambiar toda la respuesta del metodo heredado
            Console.WriteLine("Miau");
        }
        public override void Imprimir()
        {
            //Override Parcial: conservamos o reutilizamos el codigo del metodo heredado
            //o sea que mantenemos la funcionalidad original lo que nos permitirá
            //expandir las funciones del metodo a partir de la clase hija.
            base.Imprimir(); //mandar a llamar el metodo Heredado desde la clase padre
            //Agregar nuevas funcionalidades:
            Console.WriteLine($"Apodo: {this.Apodo}");
            Console.WriteLine($"Tiene pelaje: {(this.TienePelaje ? "Si" : "No")}");
        }
    }
}
