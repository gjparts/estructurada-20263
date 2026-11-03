namespace _30_for
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Haga un programa que lea 10 numeros, va a mostrar cual
             * de ellos es el mayor.
            -> El programa debe poder funcionar con numeros negativos y positivos.*/

            //Forma 1: utilizando una variable inicializada con un valor tan pequeño
            //que pueda ser superado por cualquier otro

            double numero; //variable temporal para leer numeros
            double mayor = double.MinValue;

            for(int i = 1; i <= 10; i++)
            {
                try
                {
                    Console.Write("Digite un numero: ");
                    numero = double.Parse(Console.ReadLine());

                    //si el numero leido es superior al numero mayor
                    //entonces el nuevo numero mayor es el numero leido
                    if(numero>mayor) mayor = numero;
                }
                catch (Exception)
                {
                    Console.WriteLine("Solo se permite numeros.");
                }
            }
            Console.WriteLine($"El numero mayor es: {mayor}");
        }
    }
}
