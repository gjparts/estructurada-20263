namespace _20_if_or
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Operador Logico OR
            Devuelve true cuando se cumple al menos una de las expresiones
            de comparacion.
            En C#, JAVA, C++, Javascript, Dart se representa con dos barras ||
            El caracter barra se puede obtener con ALT+124
            
            Ejemplo:
            Haga un programa que pregunte tres numeros enteros.
            Si el primer entero es igual a 5 Ó Si el segundo entero
            es menor a 9 Ó si el tercer entero es mayor a 7
            entonces muestre el mensaje: NUMEROS ACEPTADOS sino
            muestre el mensaje NUMERO NO PERMITIDOS.
             */
            try
            {
                int a, b, c;
                Console.Write("a: ");
                a = int.Parse(Console.ReadLine());
                Console.Write("b: ");
                b = int.Parse(Console.ReadLine());
                Console.Write("c: ");
                c = int.Parse(Console.ReadLine());

                if( a == 5 || b < 9 || c > 7 )
                    Console.WriteLine("NUMEROS ACEPTADOS");
                else
                    Console.WriteLine("NUMEROS NO PERMITIDOS");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Solo se acepta numeros enteros");
            }
        }
    }
}
