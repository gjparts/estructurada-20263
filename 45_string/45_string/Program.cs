namespace _45_string
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Tipo de Dato String
             Es una coleccion de elementos de tipo char
            -> Su tamaño depende de cuantos caracteres tiene almacenados
            -> Cada caracter mide 1 byte en el alfabeto occidental (ASCII)
            -> En C# el tipo de dato String se basa en la clase Object
               la cual es la clase de la que heredan todos los objetos
               de dicho lenguaje por lo que no es necesario importar librerias
            -> String se traduce al español como Cadena de Texto
            -> en C# usted puede usar el termino String (con S mayuscula)
               o string (con s minuscula), ambos hacen referencia al mismo
               tipo de dato.
             */

            //declarar objetos String:
            String nombre = "Gerardo";
            string pais = "Honduras";
            //String es un ALIAS de string

            /*String es una clase auto-instanciable, o sea que
             no necesita de la palabra new para crear un nuevo objeto*/
            Random r = new Random(); //asi se instancia normalmente un objeto
            //en cambio el String no necesita de ese new
            string comida = "Baleada";
            string campus = "Cortes";
            //pero siempre existe la posibilidad de instanciar el string con new:
            string bebida = new string("Coca Cola");

            String fruta = "manzana", verdura = "Repollo";

            //recuerde siempre que hasta en los string si no le asigna
            //un valor a la variable no se puede leer:
            string mascota;
            //Console.WriteLine(mascota);

            //lo recomendado es asignarle un valor:
            mascota = "Firulais";
            Console.WriteLine(mascota);

            //tambien puede inicializar el string con una cadena en blanco:
            string color = "";
            Console.WriteLine(color);

            //Concatenar String
            string marca = "Toyota";
            string modelo = "Corolla";
            string carro = marca + " " + modelo;
            string vehiculo = "La marca es " + marca + " y el modelo es " + modelo;
            Console.WriteLine(carro);
            Console.WriteLine(vehiculo);

            //tambien puede usar el operador de interpolacion para concatenar
            string fabricante = "Honda";
            string elmodelo = "Civic";
            string transporte = $"{fabricante} {elmodelo}";
            string troca = $"la marca es {fabricante} y el modelo es {elmodelo}";
            Console.WriteLine(transporte);
            Console.WriteLine(troca);

            //ventaja de interpolar versus el tradicional:
            string algo = "AMD";
            string otro = "Radeon 1234";
            int anio = 2026;
            //usar signos de mas se va volviendo confuso con mas variables
            string str1 = algo + " " + otro + " " + anio;
            //interpolar lo hace mas sencillo:
            string str2 = $"{algo} {otro} {anio}";

            Console.WriteLine(str1);
            Console.WriteLine(str2);
        }
    }
}
