namespace _11_if
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Estructura de seleccion if
            Permite condicionar el flujo del programa dependiendo de si se cumple
            o no se cumple una o varias condiciones.
            Existen casos en los que if se complementa con el bloque: else
            Ejemplos basicos:

            1) cuando solo necesita condicionar algo:
            if( condicion )
                instruccion a ejecutar si se cumple la condicion;

            2) cuando condiciona la ejecucion de algo; pero si no se cumple ejecuta otra cosa:
            if( condicion )
                instruccion a ejecutar si se cumple la condicion;
            else
                instruccion a ejecutar si NO se cumple la condicion;
             */
            try
            {
                int a, b;
                Console.Write("digite el valor de a:");
                a = int.Parse(Console.ReadLine());
                Console.Write("digite el valor de b:");
                b = int.Parse(Console.ReadLine());

                //caso 1: if sin else
                if( a > b )
                    Console.WriteLine("a es mayor que b");

                //caso 2: if utilizando else
                if (a == b)
                    Console.WriteLine("ambos son iguales");
                else
                    Console.WriteLine("los numeros son diferentes");

                /*Uso de llaves en estructura if:
                Se recomienda utilizar bloque de llaves siempre y cuando
                la estructura if condicion dos o mas instrucciones, ejemplos:
                 */
                int edad;
                Console.Write("Digite su edad: ");
                edad = int.Parse(Console.ReadLine());

                //cuando se condiciones mas de una instruccion; entonces es obligatorio el uso de llaves:
                if( edad >= 18 )
                {
                    Console.WriteLine("Usted es mayor de edad");
                    Console.WriteLine("Usted ya puede ir a la carcel si infringe la ley");
                    Console.WriteLine("Usted ya puede solicitar empleo formalmente");
                }
                else
                {
                    Console.WriteLine("Usted es menor de edad");
                    Console.WriteLine("Todo lo que haga es responsabilidad de sus padres");
                    Console.WriteLine("Usted deberia estar estudiando en la escuela");
                    Console.WriteLine("Ante la ley Usted no deberia estar en la planilla de la empresa");
                }

                if(edad >= 21)
                {
                    Console.WriteLine("Ya puede salir del pais sin permiso de sus padres");
                    Console.WriteLine("Ya puede solicitar la licencia de conducir equipo pesado");
                }

                if(edad >= 60)
                    Console.WriteLine("Ya tiene el descuento del 25%");

                //el uso de llaves cuando condiciona solo una instruccion es opcional
                //mi recomiendacion es no usar llaves si solo condiciona una instruccion
                if(edad >= 60)
                {
                    Console.WriteLine("Ya no hace fila en el banco");
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine("Solo se acepta numeros enteros");
            }
        }
    }
}
