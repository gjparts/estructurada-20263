namespace _25_switch
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Haga un programa que pregunte el mes y el año como numeros enteros.
            El programa va a imprimir cuantos dias tiene el mes digitado,
            si el mes digitado no esta entre 1 y 12 entonces imprima: Mes no valido.
            -> Resuelva el problema usando una estructura switch
            -> solo se le permite usar if para evaluar si    febrero tiene 28 o 29 dias.*/
            try
            {
                int a, m;
                Console.Write("Mes: ");
                m = int.Parse(Console.ReadLine());
                Console.Write("Año: ");
                a = int.Parse(Console.ReadLine());

                switch (m)
                {
                    case 1:
                    case 3:
                    case 5:
                    case 7:
                    case 8:
                    case 10:
                    case 12: Console.WriteLine("31 dias"); break; //casos en cascada
                    case 4: 
                    case 6: 
                    case 9: 
                    case 11: Console.WriteLine("30 dias"); break; //casos en cascada
                    case 2: //caso particular
                        if (a % 4 == 0)
                            Console.WriteLine("29 dias");
                        else
                            Console.WriteLine("28 dias");
                        break;
                    default: Console.WriteLine("Mes no valido"); break;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Solo se acepta numeros enteros");
            }
        }
    }
}
