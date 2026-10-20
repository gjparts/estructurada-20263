namespace _23_if_not
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Operador Logico NOT
            Invierte el resultado de una expresion logica.
            NOT True =>     False
            NOT False =>    True
            En C++, C#, Java, Javascript, Dart el simbolo usado es !
            En Electronica es una compuerta logica que invierte un voltaje.
             */

            /*Para un juego acuatico se le pregunta la edad,
            NO SE ADMITE personas con edades entre 0 y 10
            SI SE ADMITE personas con edades fuera de ese rango*/
            try
            {
                int edad;
                Console.Write("Edad: ");
                edad = int.Parse(Console.ReadLine());

                //Sin usar NOT:
                if( edad >= 0 && edad <= 10 )
                    Console.WriteLine("No se admite");
                else
                    Console.WriteLine("Si se admite");

                //Usando NOT (le da vuelta al problema)
                if (!(edad >= 0 && edad <= 10))
                    Console.WriteLine("Si se admite");
                else
                    Console.WriteLine("No se admite");

            }
            catch (Exception ex)
            {
                Console.WriteLine("Edad debe ser un numero entero");
            }
        }
    }
}
