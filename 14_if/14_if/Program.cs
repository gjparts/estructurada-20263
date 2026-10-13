namespace _14_if
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Estructura anidada (nested)
             Es una estructura que se encuentra dentro de otra estructura.
            
             Por ejemplo un if dentro de otro if se le conoce como if anidado.*/
            int edad;
            Console.Write("Digite su edad: ");
            edad = int.Parse(Console.ReadLine());

            if(edad >= 18)
            {
                Console.WriteLine("Usted es mayor de edad.");
                if(edad >= 21)
                    Console.WriteLine("Ya puede salir del pais sin permiso");
                else
                {
                    Console.WriteLine("Debe pedir permiso para casarse");
                    Console.WriteLine("Aun no puede tramitar licencia pesada");
                }
            }
            else
                Console.WriteLine("Usted es menor de edad");
        }
    }
}
