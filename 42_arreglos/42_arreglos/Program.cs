namespace _42_arreglos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Haga un programa que pregunte al usuario 5 numeros double.
            Debera almacenar dichos numeros en un arreglo.
            Una vez finalizada la lectura de los 5 numeros deberá mostrar lo siguiente:
            -> Apliquele orden ascendente al arreglo
            -> Imprima el contenido del arreglo
            -> Imprima la suma de todos los numeros dentro del arreglo
            -> Imprima el promedio de todos los numeros dentro del arreglo
            -> Imprima el mayor y el menor de todos los numeros de dicho arreglo*/
            
            //declarar e inicializar el arreglo
            double[] arreglo = new double[5];

            //recorrer el arreglo e ir preguntando los valores
            for(int i = 0; i < arreglo.Length; i++)
            {
                //deposito el numero leido directamente en el arreglo en la i-esima posicion
                Console.Write("Digite un numero: ");
                arreglo[i] = double.Parse(Console.ReadLine());
            }

            //analizar la informacion
            Array.Sort(arreglo); //aplicar orden ascendente al arreglo
            double suma = 0; //acumulador
            //Imprimir el arreglo
            for(int i = 0; i < arreglo.Length; i++)
            {
                Console.WriteLine(arreglo[i]);
                suma += arreglo[i];
            }
            Console.WriteLine($"Suma de los numeros leidos: {suma}");
            Console.WriteLine($"Promedio de los numeros leidos: {suma/arreglo.Length}");
            Console.WriteLine($"Valor mayor: {arreglo.Max()}");
            Console.WriteLine($"Valor menor: {arreglo.Min()}");
        }
    }
}
