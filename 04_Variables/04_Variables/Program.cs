namespace _04_Variables
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Variable: es un espacio de almacenamiento temporal
             que esta dentro de la memoria principal (RAM) y se
            utiliza para almacenar valores, estos pueden cambiar
            durante la vida del programa.
            
            Toda variable idealmente debe tener una tipo de dato
            el cual dicta la naturaleza de la informacion almacenada
            en ella.
            Por ejemplo: numeros, texto, fechas, objetos, booleanos, etc.
            
            Los tipos de dato se agrupan en:
            1) Tipos de dato primitivos: son los que vienen definidos
               dentro del compilador/interprete del lenguaje de
               programacion.
               Ejemplo en C++ y C#: int, double, float, char, bool, long

            2) Tipos de dato compuestos: son colecciones de elementos
               que tienen tipos de dato primitivos.
               Ejemplo en C#: String, Array, List, Class, Enum

            Reglas para nombrar variables en C#, JAVA y C++:
            1) No utilice espacios en blanco
            2) No usar caracteres especiales (excepto guion bajo)
            3) Dos variables no pueden tener el mismo nombre en el mismo ambito
            4) No utilice numeros al inicio del nombre de la variable
            5) No use palabras reservadas del lenguaje, por ejemplo:
               for, if, while.

            Recomendaciones al nombrar variables:
            1) asegurense que el nombre de la variable tenga sentido o significado
            2) cuando le ponga nombre a las variables recuerde que las maysculas
               y minusculas que utilice deberá respetarlas cuando vuelva a 
               referirse a dicha variable.
            */
            //3) Si bien C# le permite declarar variables con nombres parecidos
            //   jugando con las mayusculas/minusculas, no se recomienda
            //   ser ambiguos en los nombres de ellas, como en el ejemplo siguiente:
            int Gato;
            int gato;
            int GATO;
            int GaTo;

            //ejemplo de variable usando guiones bajos:
            int edad_de_persona;

            /*Notaciones para nombrar variables
            son formas que se utilizan para recomendar el uso de mayusculas/minusculas
            a la hora de nombrar una variable. Ejemplos:
            1) Pascal Case: se nombra cada palabra de la variable iniciando en mayusc.
               ejemplos:
               Nombre
               Genero
               CiudadOrigen
               CuentaAhorro
               CarreraDelEstudiante

            2) Camel Case: se escribe cada variable iniciando en minuscula y luego
               al encontrar una nueva palabra se coloca mayuscula
               ejemplos:
               nombre
               genero
               ciudadOrigen
               cuentaAhorro
               carreraDelEstudiante
            
            3) Snake Case: se escribe todo en minusculas y cada palabra se separa
               con un guion bajo (es muy utilizada en Python)
               ejemplos:
               nombre
               genero
               ciudad_origen
               cuenta_ahorro
               carrera_del_estudiante
             */
            //ejemplos practicos:
            //Recueden que C# y C++ son muy similares
            //declarar una variable sin valor de inicio (sin inicializar)
            int cantidad;
            //la variable cantidad es de tipo int

            //si Usted no asigna un valor a una variable no es posible leerla
            //Console.WriteLine(cantidad);

            //para poder leer una variable hay que asignarle un valor:
            cantidad = 23;
            Console.WriteLine(cantidad);

            //declarar multiples variables del mismo tipo en una sola instruccion:
            //sin inicializar:
            int n1, n2, n3;
            //con valor de inicio:
            int c1 = 5, c2 = 777, c3 = 90;

            //n1, n2 y n3 no puede imprimirse porque no tienen valor asignado
            //en cambio c1, c2 y c3 si pueden imprimirse.
            Console.WriteLine(c1);
            Console.WriteLine(c2);
            Console.WriteLine(c3);

            //el tipo de dato int
            //este tipo de dato permite almacenar un numero entero de 4 bytes (32 bit)
            //con signo. O sea que soporta positivos y negativos hasta 2 elevado a la
            //31 potencia: 2,147,483,648

            /*Tipos de dato para almacenar decimales
            los mas populares son:
            1) float: guarda numeros con decimales de 4 bytes (32 bit) (baja precision)
            2) double: guarda numeros con decimales de 8 bytes (64 bit)(alta precisision)
            */
            float salario = 15235.26f;
            double peso = 192.5;
            //observe que al final salario va una letra f, este se usa
            //para indicar a C# que se le ha asignado un numero float a la variable.
            //la f tambien puede ser mayuscula: F

            double distancia = 401212321231213221.34423454456;
            //double llega a soportar numeros con signo y decimales hasta 2 elevado
            //a la 63 potencia: 9,223,372,036,854,775,808

            //Tipo de dato Long (entero largo o int64)
            //se utiliza para almacenar numeros enteros de alta precision, 8bytes (64bit)
            //sea positivo o negativo
            long n = 1401198201055L;
            //se recomienda colocarle una L mayuscula al final a los numeros Long

            //Tipo de dato char: almacena un caracter, mide 1 byte (8 bit)
            char cr1 = 'z';
            //se utiliza comilla simple. ALT+39

            //una variable char solo puede guardar un caracter
            char cr2 = 'q';
            char cr3 = ' '; //espacio en blanco
            char cr4 = '\\'; //slash inverso (aqui si se coloca dos caracteres)
            char cr5 = '"'; //comilla doble
            char cr6 = '\''; //comilla simple necesita slash
            Console.WriteLine(cr4);
            Console.WriteLine(cr5);
            Console.WriteLine(cr6);

            //no se permite char con caracter vacio (nulo)
            //char cr7 = '';

            //Tipo de dato Boolean (Booleano)
            //Almacenar un valor de 1 o 0, su tamaño es 1 bit
            //Sus equivalentes en logica booleana son 1 para True, 0 para False
            //Se llama asi en honor a George Boole
            bool respuesta = true;
            bool salir = false;

            //Impresion de variables y mensajes en C#
            //Forma 1: concatenar variables
            Console.WriteLine("El valor de salario es "+salario);
            Console.WriteLine("El valor de cr1 es "+cr1);
            Console.WriteLine("El valor de peso es "+peso);
            Console.WriteLine("El valor de respuesta es "+respuesta);
            Console.WriteLine("c1 vale "+c1+", c2 vale "+c2+", c3 vale "+c3);

            //Forma 2: usando Interpolacion de variables
            Console.WriteLine($"El valor de salario es {salario}");
            Console.WriteLine($"El valor de cr1 es {cr1}");
            Console.WriteLine($"El valor de peso es {peso}");
            Console.WriteLine($"El valor de respuesta es {respuesta}");
            Console.WriteLine($"c1 vale {c1}, c2 vale {c2}, c3 vale {c3}");
        }
    }
}
