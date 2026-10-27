namespace _26_azar
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Generacion de numeros aleatorios o al azar en C#
            //instanciar un objeto de clase Random
            Random r = new Random();
            //Clase: Random
            //Objeto: r
            //No es lo mismo Objeto y Clase ya que un objeto
            //es una instancia de una clase.
            
            //generar un numero al azar entre 1 y 6
            int azar = r.Next(1,7);
            //Observe que en Next va como parametros el numero
            //mas pequeño esperado y el numero mas grandes esperado
            //pero se le suma 1 ya que Random en C# considera al
            //limite superior como excluyente o sea ignora el valor
            //digitado y llega hasta un numero antes del mismo.
            Console.WriteLine(azar);

            //genere un numero al azar entre 11 y 43
            azar = r.Next(11, 44);
            Console.WriteLine(azar);

            //genere un numero al azar entre -7 y -5
            azar = r.Next(-7, -4);
            Console.WriteLine(azar);

            /*Haga un programa que genere un numero al azar
             entre 4 y 9.
            El programa imprimira el nombre del mes correspondiente
            al numero generado.
            -> Resuelvalo sin utilizar if.*/
            azar = r.Next(4, 10);
            switch (azar)
            {
                case 4:
                    Console.WriteLine("Abril");
                    break;
                case 5:
                    Console.WriteLine("Mayo");
                    break;
                case 6:
                    Console.WriteLine("Junio");
                    break;
                case 7:
                    Console.WriteLine("Julio");
                    break;
                case 8:
                    Console.WriteLine("Agosto");
                    break;
                case 9:
                    Console.WriteLine("Septiembre");
                    break;
                default:
                    Console.WriteLine("Mes no aceptado");
                    break;
            }

            //Tambien es posible generar numeros al azar usando double o float
            //generar un numro al azar entre 1 y 10 usando double
            double aleatorio = r.NextDouble()*10;
            Console.WriteLine(aleatorio);

            //numero al azar con decimales entre 6 y 27
            aleatorio = r.NextDouble() * (27 - 6 + 1) + 6;
            Console.WriteLine(aleatorio);
            //en estos casos se coloca r.NextDouble() * (MAX - MIN + 1) + MIN

            //esto se debe a que NextDouble() devuelve un numero
            //decimal entre 0 y 1, como si fuese un porcentaje.
        }
    }
}
