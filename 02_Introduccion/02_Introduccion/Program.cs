namespace _02_Introduccion
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Imprimir texto RAW (texto sin tratamiento)
            //el texto RAW ignora los caracteres de escape
            Console.WriteLine(@"\n\n\n\n\n\n\n");
            Console.WriteLine(@"Esto es un slash inverso: \");
            Console.WriteLine(@"Esto es una comilla doble: """);
            //el texto RAW permite hacer multilinea:
            Console.WriteLine(@"Esta es la linea 1
Esta es la Linea 2
Esta es la linea 3
Ultima linea");

            //otro ejemplo:
            Console.WriteLine(@" __         __
/  \.-""""""-./  \
\    -   -    /
 |   o   o   |
 \  .-'''-.  /
  '-\__Y__/-'
     `---`");

            //Pausar la ejecucion del programa en la terminal
            Console.WriteLine("Presione cualquier tecla para continuar...");
            Console.ReadKey(true); //true impide que se imprima la tecla presionada

            //Limpiar la pantalla de la terminal
            Console.Clear();

            //Cambiar la posicion del cursor de impresion en la terminal
            //colocar el cursor en la columna 11, renglon 7
            Console.SetCursorPosition(11, 7);
            Console.Write("UNAH");

            //ahora pasar a la col 5, renglon 2
            Console.SetCursorPosition(5, 2);
            Console.Write("Sistemas");

            //mas ejemplos:
            Console.SetCursorPosition(20, 14);
            Console.Write("Gerardo");
            Console.SetCursorPosition(0, 16);
            Console.Write(@"[bug]     /""*._         _
      .-*'`    `*-.._.-'/
    < * ))     ,       (
      `*-._`._(__.--*""`.\");

            //Cuando halla termina de posicionar el cursor en diferentes partes
            //y vaya a hacer la pausa se recomienda posicionar el cursor en un renglon
            //que este hasta abajo de todo lo impreso.
            Console.SetCursorPosition(0, 20);

            //Pausar la ejecucion del programa en la terminal
            Console.WriteLine("Presione cualquier tecla para continuar...");
            Console.ReadKey(true); //true impide que se imprima la tecla presionada
            Console.Clear(); //limpiar la terminal

            //Cambiar el color del texto
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Texto amarillo");
            Console.WriteLine("Mas texto por aqui");

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Texto en color verde");
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("Texto celeste");

            //para regresar la terminal al color de fabrica:
            Console.ResetColor();

            //cambiar el color de fondo
            Console.BackgroundColor = ConsoleColor.DarkMagenta;
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Fondo violeta texto amarillo");

            Console.BackgroundColor = ConsoleColor.DarkGreen;
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Fondo verde, texto rojo");

            Console.ResetColor();

            //si desea usar diferentes colores en la misma linea
            //entonces use Write en lugar de WriteLine
            Console.ForegroundColor= ConsoleColor.Red;
            Console.Write("Rojo");
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.Write("Azul claro");
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.Write("Magenta");
            Console.BackgroundColor = ConsoleColor.DarkBlue;
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.Write("Hielo");
            Console.ResetColor();
            Console.WriteLine();

            //Hacer una pausa con tiempo
            Console.WriteLine("Pausa por tres segundos...");
            Thread.Sleep(3000); //tiempo es el milisegundos
            Console.WriteLine("La pausa termino, Adios.");
        }
    }
}
