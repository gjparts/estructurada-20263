namespace _19_if_and
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
            Al finalizar imprima el valor del descuento y el total a pagar.
            -> Resuelvalo utilizando operadores logicos en todas las condiciones*/
            try
            {
                float venta, descuento = 0, pagar;
                Console.Write("Digite el valor de la venta: ");
                venta = float.Parse(Console.ReadLine());

                //El usar if sin else llega a ser ineficiente porque
                //ejecuta mas de una vez los calculos; pero si le coloca
                //operador logicos como AND puede evitar que eso suceda
                //y hacer mas eficiente su algoritmo
                //cuando evalua rangos numericos se recomienda usar operador AND
                if (venta >= 2000 && venta < 5000) descuento = venta * 0.10f;
                if (venta >= 5000 && venta < 10000) descuento = venta * 0.20f;
                if (venta >= 10000 && venta < 20000) descuento = venta * 0.30f;
                if (venta >= 20000) descuento = venta * 0.50f;

                pagar = venta - descuento;
                Console.WriteLine($"Descuento: {descuento}");
                Console.WriteLine($"Monto a Pagar: {pagar}");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Solo se admite numeros.");
            }
        }
    }
}
