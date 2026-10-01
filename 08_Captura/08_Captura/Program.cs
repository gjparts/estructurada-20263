namespace _08_Captura
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Captura de valores usando la terminal de sistema
            //programa que lee dos numeros float y los suma

            //bloque de caceria de error (bloque de caza de errores)
            try
            {
                //Codigo que puede llegar a fallar
                float a, b;
                Console.Write("Digite un numero: ");
                a = float.Parse( Console.ReadLine() );
                Console.Write("Digite otro numero: ");
                b = float.Parse(Console.ReadLine());
                Console.WriteLine($"La suma de ambos numeros es {a+b}");
            }catch(Exception ex)
            {
                //Codigo a ejecutar en caso de falla
                //Se recomienda imprimir un mensaje amigable para informar
                Console.WriteLine("Solo se acepta numeros");
                //Si Usted quisiera imprimir el mensaje dado por el compilador:
                Console.WriteLine(ex.Message);
            }


            
        }
    }
}
