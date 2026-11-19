namespace _43_arreglos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Haga un programa que tenga un arreglo unidimensional de numeros
            enteros de 10 posiciones.
            Llene el arreglo con numeros al azar entre 7 y 21.

            Luego declare un segundo arreglo unidimensional de numeros
            enteros de 10 posiciones, el programa deberá copiar todos los
            numeros del primer arreglo hacia el segundo arreglo; pero elevados al cubo.

            Al finalizar imprima los valores del primer arreglo y del segundo
            arreglo de la siguiente manera:

            8	512
            10	1000
            9	729
            15	3375
            7	343
            9	729
            12	1728
            11	1331
            7	343
            19	6859*/

            //yo lo hice en varios for; pero Ustedes lo pueden hacer en un solo for
            int[] arreglo1 = new int[10];
            int[] arreglo2 = new int[10];
            Random r = new Random();
            //llenado del primer arreglo
            for(int i = 0; i < arreglo1.Length; i++)
            {
                arreglo1[i] = r.Next(7,22);
            }

            //copiar los valores del primer arreglo hacia el segundo pero al cubo
            for(int i = 0;i < arreglo1.Length; i++)
            {
                arreglo2[i] = arreglo1[i] * arreglo1[i] * arreglo1[i]; //puede multiplicarlo por si mismo
                //arreglo2[i] = (int)Math.Pow(arreglo1[i], 3); //puede usar conversion explicita
            }

            //imprimir
            for (int i = 0; i < arreglo1.Length; i++)
            {
                Console.WriteLine($"{arreglo1[i]}\t{arreglo2[i]}");
            }

            /*Existe otra forma de imprimir arreglos sin necesidad de utilizar for.
            por ejemplo si tiene prisa y solo quiere saber que hay dentro de un arreglo*/
            long[] arreglo777 = { 5, -10, 3000000, 1401198201055, 12345678, -231464};

            //C# dentro de la clase String cuenta con un metodo llamado Join con
            //el cual pueden convertir cualquier coleccion (arreglo, lista, etc.) a
            //un string el cual pueden imprimir, ejemplo:

            Console.WriteLine(String.Join("\n",arreglo777));
            Console.WriteLine(String.Join(", ", arreglo1));
            Console.WriteLine(String.Join(":::", arreglo2));
            //Join primero lleva el separador y luego la coleccion.
            //Join no nos da control sobre cada item
        }
    }
}
