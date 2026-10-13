namespace _16_if
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Capture el monto de una venta, luego se calculara un descuento
            de acuerdo a la tabla siguiente:
            Si la venta es mayor o igual a 2000 se da un 10% de descuento
            Si la venta es mayor o igual a 5000 se da un 20% de descuento
            Si la venta es mayor o igual a 10000 se da un 30% de descuento
            Si la venta es mayor o igual a 20000 se da un 50% de descuento
            Al finalizar imprima el valor del descuento y el total a pagar.*/

            //Forma 2: usando if sin else
            try
            {
                double venta, descuento = 0, pagar;
                Console.Write("Escriba el monto de lo vendido: ");
                venta = double.Parse(Console.ReadLine());

                //esta forma es mas facil de entender; pero menos eficiente para la CPU
                if (venta >= 2000)
                    descuento = venta * 0.10;

                if (venta >= 5000)
                    descuento = venta * 0.20;

                if (venta >= 10000)
                    descuento = venta * 0.30;

                if (venta >= 20000)
                    descuento = venta * 0.50;

                pagar = venta - descuento;
                Console.WriteLine($"Descuento: {descuento}");
                Console.WriteLine($"Descuento: {pagar}");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Solo se acepta numeros");
            }
        }
    }
}
