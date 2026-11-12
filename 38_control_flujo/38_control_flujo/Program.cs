namespace _38_control_flujo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Instrucciones de control de flujo
            Permiten alterar el flujo dentro de una estructura de repeticion, normalmente
            son dos:
            1) continue: termina con la iteracion actual y pasa a la siguiente
            2) break: termina con la estructura de repeticion completa
            
            Instruccion continue
            Ejemplo: haga un programa que recorra los numeros del 1 al 100.
            Debera imprimir cada numero recorrido excepto aquellos multiplos de 7.
            -> Resuelvalo utilizando al menos una vez la instruccion continue.
            */
            for(int i = 1; i <= 100; i++)
            {
                if (i % 7 == 0) continue; //si i es multiplo de 7 se salta la iteracion actual
                Console.WriteLine(i);
            }

            /*Otro ejemplo: haga un programa que lea N cantidad de numeros enteros, solo va
             a sumar aquellos numeros que sean positivos.
            -> Si digita un numero negativo deberá saltarse la iteracion.
            -> El programa termina cuando digite CERO.
            -> Al finalizar el programa muestre la suma de los numeros leidos
            -> Debe utilizar la instruccion continue al menos una vez*/
            int numero = 0; //variable de control
            int suma = 0; //acumulador
            do
            {
                try
                {
                    Console.Write("Digite un numero entero: ");
                    numero = int.Parse(Console.ReadLine());

                    if (numero < 0) continue; //si digita un negativo se salta la iteracion actual
                    suma += numero;
                }
                catch (Exception)
                {
                    Console.WriteLine("Solo se permite numeros enteros");
                }
            } while(numero != 0);
            Console.WriteLine($"Suma de numeros positivos: {suma}");
        }
    }
}
