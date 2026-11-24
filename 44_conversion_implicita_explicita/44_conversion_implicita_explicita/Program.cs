namespace _44_conversion_implicita_explicita
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Difencia entre conversion implicita y explicita
             ------------------------------------------------
            Conversion Implicita: consiste en pasar de un tipo de dato
            mas pequeño hacia un tipo de dato mas grande.
            -> Este tipo de conversion es automatica por parte
               del compilador
            -> Este tipo de conversion es mas segura ya que se utiliza
               cuando Usted ya sabe que no hay riesgo de perder datos
            Ejemplos:*/
            int n = 26;
            double valor = n;
            //lo anterior ejemplifica como depositamos un valor cuyo tipo
            //de dato es de 4 bytes (32 bit) dentro de una variable
            //cuyo tipo de dato es de 8 bytes (64 bit)

            float abc = 6.78f;
            double xyz = abc;
            //no hay problema en esta asignacion porque float
            //es de menor precision que double.

            /*Conversion Explicita (Cast)
            Consiste en pasar un tipo de dato mas grande hacia uno
            mas pequeño.
            -> Esta es una conversion manual, el programador debe
               decirle al compilador que esta de acuerdo con la
               perdida de datos.
            -> Es menos segura porque al pasar de un tipo mas grande
               hacia uno pequeño provoca perdida de precision.
            Ejemplo:
             */
            double cifra = 424.5634533;
            int f = (int)cifra;

            Console.WriteLine(cifra);
            Console.WriteLine(f);
            //La conversion explicita no redondea, sino que
            //deshecha lo que no cabe (truncar)

            double algo = 7.8432894728974294729347298429842245443;
            float otro = (float)algo;
            Console.WriteLine(algo);
            Console.WriteLine(otro);

            int num = 3;
            int raiz = (int)Math.Sqrt(num);
            Console.WriteLine(num);
            Console.WriteLine(raiz);
            //Note como se pierde los decimales en la raiz
        }
    }
}
