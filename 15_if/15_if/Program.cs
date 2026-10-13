namespace _15_if
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

            //Forma 1: usando if-else anidado
            try
            {
                double venta, descuento, pagar;
                Console.Write("Escriba el monto de lo vendido: ");
                venta = double.Parse(Console.ReadLine());

                //si lo resuelve con if-else se ataca de forma descendente
                if (venta >= 20000)
                    descuento = venta * 0.50;
                else
                {
                    if (venta >= 10000)
                        descuento = venta * 0.30;
                    else
                    {
                        if (venta >= 5000)
                            descuento = venta * 0.20;
                        else
                        {
                            if (venta >= 2000)
                                descuento = venta * 0.10;
                            else
                                descuento = 0;
                        }
                    }
                }
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
