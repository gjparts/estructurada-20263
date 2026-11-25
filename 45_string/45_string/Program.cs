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

            //Saber la longitud de un String
            string persona = "Gerardo";
            Console.WriteLine(persona);
            Console.WriteLine($"La longitud de persona es: {persona.Length}");

            //la propiedad Length devuelve un numero entero con la cantidad
            //de caracteres que tiene un String, por lo tanto tambien lo puede
            //almacenar en una variable:
            int longitud = persona.Length;
            Console.WriteLine($"La longitud de persona es: {longitud}");

            /*Tener acceso a los char que hay dentro de un String:
            en C# los String son una coleccion de elementos char los cuales
            puede ser obtenidos a traves del uso de brackets []
            -> Importante: un String no es un arreglo!
            -> El lenguaje C# nos da la facilidad de obtener char por medio de brackets
               para facilitarnos su uso; pero eso no quiere decir que son arreglos.
            -> Los elementos char dentro de un String se numeran de 0 hasta Length-1
            */
            string carrera = "Ingenieria en Sistemas";
            Console.WriteLine($"carrera: {carrera}");
            Console.WriteLine($"El caracter numero 4 de carrera es: {carrera[4]}");
            Console.WriteLine($"El caracter numero 0 de carrera es: {carrera[0]}");
            Console.WriteLine($"El primer caracter de carrera es: {carrera[0]}");
            Console.WriteLine($"El segundo caracter de carrera es: {carrera[1]}");
            Console.WriteLine($"El ultimo caracter de carrera es: {carrera[carrera.Length-1]}");

            //tambien es posible depositar un caracter extraido de un String dentro
            //de una variable:
            char c1 = carrera[7];
            Console.WriteLine($"El caracter numero 7 de carrera es {c1}");

            string refresco = "Te Liptop Mediano";
            //Ejercicio: haga un programa que imprima cada uno de los caracteres
            //de refresco; pero colocando cada uno en un nuevo renglon.
            for(int i = 0;  i < refresco.Length; i++)
            {
                Console.WriteLine(refresco[i]);
            }

            //Transformaciones de String
            /*Metodo ToUpper()
            Devuelve una version del String; pero en mayusculas.
            Metodo ToLower()
            Devuelve una version del String; pero en minusculas.*/
            string ciudad = "San Pedro Sula";
            Console.WriteLine($"ciudad: {ciudad}");
            Console.WriteLine($"ciudad en mayusculas: {ciudad.ToUpper()}");
            Console.WriteLine($"ciudad en minusculas: {ciudad.ToLower()}");
            Console.WriteLine($"ciudad (variable original): {ciudad}");

            /*Observe que cuando utilizamos ToUpper() y ToLower() la variable ciudad
            no fue afectada, lo que nos devuelven estos metodos es una copia en mayusculas
            y en minusculas de la variable ciudad.*/

            //Pero; y si en realidad Usted quiere AFECTAR a la variable original?
            ciudad = ciudad.ToUpper();
            //lo anterior sobreescribe la variable original con su copia en mayusculas
            Console.WriteLine($"ciudad (variable original): {ciudad}");

            /*Metodo Trim()
            Devuelve una copia del String a la cual se le ha eliminado los espacios en
            blanco que estan al inicio y al final (conocidos como espacios de relleno)
            -> Este metodo no elimina los espacios que hay en medio del String.*/
            string estudiante = "              Gerardo Josue Portillo            ";
            Console.WriteLine($"estudiante: *{estudiante}*");
            Console.WriteLine($"Longitud de estudiante: {estudiante.Length}");
            Console.WriteLine($"estudiante (Trim): *{estudiante.Trim()}*");
            Console.WriteLine($"Longitud de estudiante (Trim): *{estudiante.Trim().Length}*");
            //Trim afectaria a la variable original?
            Console.WriteLine($"estudiante (variable original): *{estudiante}*");
            //Observe que No afecto a estudiante, solo devolvio copias

            //Si Usted quiere afectar a la variable original eliminadole los espacios
            //de relleno, que va escribir?
            estudiante = estudiante.Trim();
            //en este caso si quedaria afectada la variable original:
            Console.WriteLine($"estudiante (variable original): *{estudiante}*");

            string alimento = "      Baleada con Todo                      ";
            //Ejercicio: haga un programa que imprima la variable alimento; pero sin relleno
            //de espacios y todo en mayusculas, sin alterar a la variable original.
            Console.WriteLine(alimento.Trim().ToUpper()); //forma 1
            Console.WriteLine(alimento.ToUpper().Trim()); //forma 2
            //cuando ejecuta un metodo despues de otro se le conoce como ejecucion en cascada
            Console.WriteLine(alimento); //variable original
        }
    }
}
