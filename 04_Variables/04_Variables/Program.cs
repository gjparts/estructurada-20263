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
        }
    }
}
