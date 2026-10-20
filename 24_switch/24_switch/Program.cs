namespace _24_switch
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Estructura de Seleccion switch
             -------------------------------
            Permite evaluar una variable y dependiendo de su valor
            se ejecutara alguno de los casos planteados.
            
             Ejemplo:
             Haga un programa que pregunte un numero entero del 1 al 4,
             el programa va aimprimir como se escribe dicho numero en Ingles.
             Si el numero digitado no estra dentro del rango entonces
             imprima: Numero desconocido.
             */
            try
            {
                int numero;
                Console.Write("Digite un numero entre 1 y 4: ");
                numero = int.Parse(Console.ReadLine());

            }
            catch (Exception ex )
            {
                Console.WriteLine("Solo se acepta numeros enteros.");
            }
        }
    }
}
