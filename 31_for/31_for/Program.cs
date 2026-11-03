namespace _31_for
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Haga un programa que lea 10 numeros, va a mostrar cual
             * de ellos es el mayor.
            -> El programa debe poder funcionar con numeros negativos y positivos.*/

            //Forma 2: mayor se inicializa en la primer captura
            double numero; //variable temporal para leer numeros
            double mayor = 7777; //este numero de aqui no importa en esta forma

            for (int i = 1; i <= 10; i++)
            {
                try
                {
                    Console.Write("Digite un numero: ");
                    numero = double.Parse(Console.ReadLine());

                    if (i == 1)
                        mayor = numero; //si es la primera iteracion ese sea el mayor
                    else
                    {
                        //si el numero leido es superior al numero mayor
                        //entonces el nuevo numero mayor es el numero leido
                        if (numero > mayor) mayor = numero;
                    }
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
