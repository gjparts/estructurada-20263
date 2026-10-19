namespace _21_if_or
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Haga un programa que capture el mes y el año como numeros
            enteros. El programa va a imprimir cuantos dias tiene
            el mes/año digitados.
            -> Debera validar que el mes sea un numero entre 1 y 12
             */
            try
            {
                int m, a;
                Console.Write("Mes: ");
                m = int.Parse(Console.ReadLine());
                Console.Write("Año: ");
                a = int.Parse(Console.ReadLine());

                if( m >= 1 && m <= 12)
                {
                    //OR tambien le permite hacer listas de seleccion para casos comunes
                    if(m == 1 || m == 3 || m == 5 || m == 7 || m == 8 || m == 10 || m == 12) Console.WriteLine("31 dias");
                    if(m == 4 || m == 6 || m == 9 || m == 11) Console.WriteLine("30 dias");
                    if(m == 2)
                    {
                        //febrero ya es un caso singular
                        if(a%4 == 0)
                            Console.WriteLine("29 dias");
                        else
                            Console.WriteLine("28 dias");
                    }
                }
                else
                    Console.WriteLine("Mes debe ser un numero entre 1 y 12");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Solo se acepta numeros enteros");
            }
        }
    }
}
