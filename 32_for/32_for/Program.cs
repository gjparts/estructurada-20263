namespace _32_for
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Haga un programa que lea 10 numeros y al finalizar
            muestre el promedio de los 10 numeros leidos y va a mostrar cuál es el
            numero mayor y el numero menor de los 10 numeros leídos.
            El programa debe funcionar tambien con números negativos.
            -> Imprima el promedio a maximo cuatro decimales*/

            double numero; //variable temporal para leer
            double suma = 0; //variable acumulador
            double mayor = double.MinValue; //variable bandera (flag)
            double menor = double.MaxValue; //vairable bandera

            for(int i = 1; i <= 10; i++)
            {
                try
                {
                    Console.Write("Digite un numero: ");
                    numero = double.Parse(Console.ReadLine());

                    suma += numero; //sumar el numero leido al acumulador

                    if (numero > mayor) mayor = numero;
                    if (numero < menor) menor = numero;
                }
                catch (Exception)
                {
                    Console.WriteLine("Solo se acepta numeros");
                }
            }
            double promedio = suma / 10.0; //calculo del promedio
            Console.WriteLine($"El promedio es: { Math.Round(promedio,4) }");
            Console.WriteLine($"El mayor es: {mayor}");
            Console.WriteLine($"El menor es: {menor}");
        }
    }
}
