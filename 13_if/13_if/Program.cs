namespace _13_if
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

            //forma 2: resolverlo usando if; pero sin else
            float venta, descuento = 0, pagar;

            Console.Write("Digite el monto de la venta: ");
            venta = float.Parse(Console.ReadLine());

            /*si la inicializacion de una variable esta condicionada
             entonces es obligatorio inicializarla en la declaracion de la variable,*/
            if (venta > 10000)
                descuento = venta * 0.10f;

            pagar = venta - descuento;

            Console.WriteLine($"Valor del descuento: {descuento}");
            Console.WriteLine($"Valor a pagar: {pagar}");
        }
    }
}
