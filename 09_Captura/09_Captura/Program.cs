namespace _09_Captura
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                double a, b, c;
                Console.Write("a: ");
                a = double.Parse(Console.ReadLine());
                Console.Write("b: ");
                b = double.Parse(Console.ReadLine());
                Console.Write("c: ");
                c = double.Parse(Console.ReadLine());

                //forma 1: un solo calculo al imprimir
                Console.WriteLine($"Resultado: {Math.Pow(Math.Pow((a+3*b)/(c*c+8),1.0/3.0),1.0/5.0) }");

                //forma 2: por partes
                double numerador = a + 3 * b;
                double denominador = Math.Pow(c, 2) + 8;
                double raizCubica = Math.Pow(numerador / denominador, 1.0 / 3.0);
                double raizQuinta = Math.Pow(raizCubica, 1.0 / 5.0);
                Console.WriteLine($"Resultado: {raizQuinta}");
            }
            catch(Exception ex)
            {
                Console.WriteLine("Solo se acepta numeros");
            }
        }
    }
}
