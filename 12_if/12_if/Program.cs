namespace _12_if
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Haga un programa que capture el monto de una venta.
            Se dara un descuento del 10% si la venta es mayor
            de 10000 de lo contrario no se dara descuento.
            Al finalizar el programa debera imprimir el valor del descuento
            y el valor a pagar.*/

            //forma 1: resolverlo usando if con else
            float venta, descuento, pagar;

            Console.Write("Digite el monto de la venta: ");
            venta = float.Parse(Console.ReadLine());

            if (venta > 10000)
                descuento = venta * 0.10f;
            else
                descuento = 0;

            pagar = venta - descuento;
            Console.WriteLine($"Valor del descuento: {descuento}");
            Console.WriteLine($"Valor a pagar: {pagar}");
        }
    }
}
