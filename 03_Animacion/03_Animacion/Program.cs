namespace _03_Animacion
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //imprimir elementos en pantalla e irlos moviendo
            for(int i = 1; i <= 100; i++)
            {
                Console.SetCursorPosition(i, 5);
                Console.Write("><>");
                Console.SetCursorPosition(i + 4, 10);
                Console.Write("><>");
                Console.SetCursorPosition(i + 8, 15);
                Console.Write("><>");

                Thread.Sleep(50); //pausa de 50ms
                Console.Clear(); //Limpiar la pantalla
            }
        }
    }
}
