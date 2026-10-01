namespace _10_Captura
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                double x, y, z, w;
                Console.Write("x: ");
                x = double.Parse(Console.ReadLine());
                Console.Write("y: ");
                y = double.Parse(Console.ReadLine());
                Console.Write("z: ");
                z = double.Parse(Console.ReadLine());
                Console.Write("w: ");
                w = double.Parse(Console.ReadLine());

                //por partes
                double num = -x + 7 * y;
                double den = 4 * z + 5 * w;
                double raiz = Math.Pow(num, 1.0 / 7.0);
                double res = (raiz/den) - 3;
                Console.WriteLine($"Resultado: {res}");
            }
            catch(Exception ex)
            {
                Console.WriteLine("Solo se permite numeros");
            }
        }
    }
}
