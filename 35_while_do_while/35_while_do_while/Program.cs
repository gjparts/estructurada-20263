namespace _35_while_do_while
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Haga un programa que capture N cantidad de edades de personas.
            -> El programa termina cuando digiten una edad negativa
            -> Una vez que termina el programa debe imprimir un resumen
               de cuantas edades capturo por cada uno de los grupos
               siguientes:

               Menores de Edad	de 0 a menos de 18
               Mayores de Edad	de 18 a menos de 21
               Adultos		    de 21 hasta menos de 60
               Tercera Edad		de 60 en adelante*/
            
            int edad = 0; //variable de control y de lectura
            int menores = 0, mayores = 0, adultos = 0, tercera = 0; //acumuladores
            do
            {
                try
                {
                    Console.Write("Digite una edad: ");
                    edad = int.Parse(Console.ReadLine());
                    //clasificar la edad leida
                    if (edad >= 0 && edad < 18) menores++;
                    if (edad >= 18 && edad < 21) mayores++;
                    if (edad >= 21 && edad < 60) adultos++;
                    if (edad >= 60) tercera++;
                }
                catch (Exception)
                {
                    Console.WriteLine("Solo se permite numeros enteros");
                }
            } while (edad >= 0);
            //sumario
            Console.WriteLine($"Menores de edad: {menores}");
            Console.WriteLine($"Mayores de edad: {mayores}");
            Console.WriteLine($"Adultos: {adultos}");
            Console.WriteLine($"Tercera edad: {tercera}");
        }
    }
}
