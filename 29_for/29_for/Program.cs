namespace _29_for
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Haga un programa que capture 10 numeros enteros, al finalizar
             * el programa debera mostrar la suma de esos 10 numeros,
             * tambien debera mostrar cuantos de esos numeros son
             * pares y cuantos son impares.*/
            int numero; //variable temporal
            int suma = 0; //variable acumulador para ir sumando, inicia en cero
            int pares = 0, impares = 0; //variables acumulador para ir contando
            for(int i = 1; i <= 10; i++)
            {
                try
                {
                    Console.Write("Digite un numero entero: ");
                    numero = int.Parse(Console.ReadLine());
                    
                    suma += numero; //suma = suma + numero

                    //si el numero recien leido es par o impar acumularlo:
                    if (numero % 2 == 0)
                        pares++;    //pares = pares + 1
                    else
                        impares++; //impares = impares + 1
                }
                catch (Exception)
                {
                    Console.WriteLine("solo se acepta numeros enteros");
                }
            }
            Console.WriteLine($"Suma de los numeros {suma}");
            Console.WriteLine($"Cantidad de pares: {pares}");
            Console.WriteLine($"Cantidad de impares {impares}");
        }
    }
}
