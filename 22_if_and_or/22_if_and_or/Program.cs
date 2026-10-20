namespace _22_if_and_or
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Capturar el monto de una venta y la edad del cliente,
             se dara un descuento del 10% para todas aquellas
             ventas hechas a personas con edades entre 21 y 28 ó
             entre 45 y 57.
            Imprima el monto del descuento y el valor a pagar.
            -> Debera usar operadores AND y OR*/
            try
            {
                int edad;
                double venta, descuento = 0, pagar;
                Console.Write("Que edad tiene el cliente?");
                edad = int.Parse(Console.ReadLine());
                Console.Write("Digite el monto de la venta: ");
                venta = double.Parse(Console.ReadLine());

                if (edad >= 21 && edad <= 28 || edad >= 45 && edad <= 57)
                    descuento = venta * 0.10;

                pagar = venta - descuento;
                Console.WriteLine($"Descuento: {descuento}");
                Console.WriteLine($"Valor a pagar: {pagar}");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Solo se acepta numeros");
            }
        }
    }
}
