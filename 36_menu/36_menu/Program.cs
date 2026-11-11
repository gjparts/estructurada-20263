namespace _36_menu
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Haga un menú en consola/terminal, que muestre las opciones siguientes:
             
            -------- MENU --------
            1) Dame un saludo
            2) Dime la fecha y la hora
            3) Reproduce un sonido
            4) Sumadora
            5) Salir
            
            -> Programe cada una de las acciones para numero de opcion
            -> Cada vez que se elija una opcion, una vez terminada la ejecucion
               de la misma, programe una pausa, despues de la pausa se limpia
               la pantalla y se vuelve a mostrar el menú.
            -> Cuando digite la opcion para Salir muestre un mensaje de despedida
               y luego el programa va a terminar.*/

            int opcion = 0; //varible de control
            do {
                try
                {
                    Console.WriteLine("-------- MENU --------");
                    Console.WriteLine("1) Dame un saludo");
                    Console.WriteLine("2) Dime la fecha y la hora");
                    Console.WriteLine("3) Reproduce un sonido");
                    Console.WriteLine("4) Sumadora");
                    Console.WriteLine("5) Salir");
                    Console.Write("Ingrese la opcion deseada: ");
                    opcion = int.Parse(Console.ReadLine());

                    //acciones
                    double a, b; //cualquier variable que ocupe dentro de un switch
                                 //se recomienda declararlas antes.
                    switch (opcion)
                    {
                        case 1:
                            Console.WriteLine("Hola");
                            break;
                        case 2:
                            Console.WriteLine($"Hoy es: {DateTime.Now}");
                            break;
                        case 3:
                            Console.Beep(1000, 2000); //1000 Hertz durante 2 segundos
                            Console.Beep(3000, 500); //3000 Hertz durante medio segundo
                            break;
                        case 4:
                            Console.Write("Digite el primer numero: ");
                            a = double.Parse(Console.ReadLine());
                            Console.Write("Digite el segundo numero: ");
                            b = double.Parse(Console.ReadLine());
                            Console.WriteLine($"La suma de ambos numeros es {a+b}");
                            break;
                        case 5:
                            Console.WriteLine("Adios");
                            break;
                        default:
                            Console.WriteLine("Opcion no valida");
                            break;
                    }

                    //hacer una pausa:
                    Console.WriteLine("Presione cualquier tecla para continuar...");
                    Console.ReadKey(false);
                    Console.Clear(); //limpiar la pantalla
                }
                catch (Exception)
                {
                    Console.WriteLine("Solo se permite numeros enteros");
                }
            } while (opcion != 5);
            
        }
    }
}
