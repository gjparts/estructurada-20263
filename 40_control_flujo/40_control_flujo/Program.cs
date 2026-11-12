namespace _40_control_flujo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Haga un programa que tenga una estructura while infinita, en cada
            iteracion va a generar un numero entero al azar entre 1 y 10, luego
            le va a preguntar al usuario que digite un numero entero.

            La idea es que el usuario adivine el numero al azar que se acaba
            de generar o sea un numero secreto.

            Si el usuario adivina dicho numero; entonces se termina la estructura
            infinita y muestre un mensaje felicitando al usuario.
            -> resuelvalo utilizando break al menos una vez.*/

            Random r = new Random();
            int azar;
            int numero;

            while (true)
            {
                try
                {
                    azar = r.Next(1,11);
                    Console.Write("Adivine un numero entero entre 1 y 10: ");
                    numero = int.Parse(Console.ReadLine());

                    if (numero == azar)
                    {
                        Console.WriteLine("Felicidades ha adivinado");
                        break;
                    }
                }
                catch (Exception)
                {
                    Console.WriteLine("Solo se acepta numeros enteros.");
                }
            }
        }
    }
}
