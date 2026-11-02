namespace _28_for
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Haga un programa que capture 10 numeros double y
             * al finalizar muestre la suma de esos 10 numeros.*/
            double numero; //variable temporal para leer numeros
            double suma = 0; //variable acumulador para ir sumando los numeros leidos
            //IMPORTANTE: toda variable acumulador debe tener un valor de inicio

            //10 lecturas de numeros
            for (int i = 1; i <= 10; i++)
            {
                try
                {
                    Console.Write("Digite un numero: ");
                    numero = double.Parse(Console.ReadLine());
                    //sumar al acumulador el valor recien leido
                    suma += numero;
                }
                catch (Exception)
                {
                    Console.WriteLine("Solo se acepta numeros");
                }
            }

            Console.WriteLine($"Suma de los numeros: {suma}");
        }
    }
}
