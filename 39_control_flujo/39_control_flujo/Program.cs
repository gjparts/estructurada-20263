namespace _39_control_flujo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Instruccion break: termina con la estructura de repeticion.
            Ejemplo: haga una estructura for que lea 10 numeros long positivos.
            -> si durante la digitacion se ingresa un numero negativo entonces
               termina la lectura de numeros.
            -> Al finalizar el programa muestre la suma de los numeros positivos leidos*/
            long numero; //variable temporal
            long suma = 0; //acumulador

            for(int i = 1; i <= 10; i++)
            {
                try
                {
                    Console.Write("Digite un numero entero: ");
                    numero = long.Parse(Console.ReadLine());
                    
                    if (numero < 0) break; //si digita un negativo, rompe la estruct. de repeticion
                    
                    suma += numero;
                }
                catch (Exception)
                {
                    Console.WriteLine("Solo se permite numeros enteros.");
                }
            }
            Console.WriteLine($"Suma de numeros positivos: {suma}");
        }
    }
}
