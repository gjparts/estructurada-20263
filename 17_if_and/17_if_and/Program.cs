namespace _17_if_and
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Operador Logico AND
            Hace obligatorio el cumplimiento de una o varias
            condiciones.
            -> En C#, C++, JAVA, Javascript, Dart se representa
            como un doble ampesand &&
            
            Ejemplo:
            Haga un programa que le pregunta la edad de una persona,
            Tambien debera preguntar si trabaja o no.
            El programa va a imprimir un mensaje dependiendo de:
            1) Si es mayor de edad y trabaja: PRESTAMO APROBADO
            2) de lo contrario va a  imprimir: NO APLICA PARA PRESTAMO
            */
            try
            {
                int edad;
                char trabaja;
                Console.Write("Digite su edad: ");
                edad = int.Parse(Console.ReadLine());
                Console.Write("Usted trabaja? (Digite S para Si, N para No): ");
                trabaja = char.Parse(Console.ReadLine());

                if (edad >= 18 && trabaja == 'S')
                    Console.WriteLine("PRESTAMO APROBADO");
                else
                    Console.WriteLine("NO APLICA PARA PRESTAMO");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Datos proporcionados no son correctos.");
            }
        }
    }
}
