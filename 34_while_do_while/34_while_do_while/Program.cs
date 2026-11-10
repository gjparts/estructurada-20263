namespace _34_while_do_while
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Haga un programa que le pregunte al usuario N cantidad de numeros positivos.
            La lectura de numeros terminará cuando se digite un numero negativo.
            Una vez que termine de leer los numeros imprima la suma de todos los numeros
            positivos leidos.
            Resulevalo usando while ó do-while la que prefiera.*/

            //usando while
            Console.WriteLine("Usando while ---------------------------------");
            double numero = 0; //variable de control y tambien para leer
            double suma = 0; //variable acumulador

            while(numero>= 0)
            {
                try
                {
                    Console.Write("Digite un numero positivo: ");
                    numero = double.Parse(Console.ReadLine());

                    if(numero >= 0) suma += numero; //suma = suma + numero
                }
                catch (Exception)
                {
                    Console.WriteLine("Solo se permite numeros");
                }
            }
            Console.WriteLine($"Suma: {suma}");

            //usando do-while
            Console.WriteLine("Usando do-while ---------------------------------");
            float n = 87654; //variable de control
            float s = 0; //variable acumlador

            do
            {
                try
                {
                    Console.Write("Digite un numero positivo: ");
                    n = float.Parse(Console.ReadLine());

                    if(n >= 0) s += n;
                }
                catch (Exception)
                {
                    Console.WriteLine("Solo se acepta numeros.");
                }
            } while (n >= 0);
            Console.WriteLine($"Suma: {s}");
        }
    }
}
