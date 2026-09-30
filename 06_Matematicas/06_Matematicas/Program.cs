namespace _06_Matematicas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Funciones de matematicas en C#
            //Dentro del lenguaje existe una clase llamada Math, dentro
            //de ella encontrara varios metodos para facilitar ciertos calculos

            //Metodo Pow: eleva un numero base a un determinado exponente
            double n1 = 3;
            Console.WriteLine($"{n1} elevado al cuadrado es {Math.Pow(n1,2)}");
            Console.WriteLine($"{n1} elevado al cubo es {Math.Pow(n1, 3)}");

            //Pow en realidad devuelve un numero double, el cual Usted
            //puede guardar en una variable
            //por ejemplo: guardar en algo el valor de n1 elevado a la quinta potencia
            double algo = Math.Pow(n1, 5);
            Console.WriteLine($"{n1} elevado a la quinta potencia es {algo}");

            //Metodo Sqrt: devuelve la raiz cuadrada de un numero (Square root)
            double n2 = 81;
            Console.WriteLine($"La raiz cuadrada de {n2} es {Math.Sqrt(n2)}");

            //recuerde que al igual que con Pow, Sqrt se puede guardar en una variable
            double raiz = Math.Sqrt(n2);
            Console.WriteLine($"La raiz cuadrada de {n2} es {raiz}");

            //IMPORTANTE: Como hago para calcular raices de otro orden, por ejemplo
            //una raiz quinta?
            //Para ello utilicen Math.Pow, elevando el numero a fraccion, ejemplos:
            double n3 = 27;
            //Calcular la raiz cubica de n3:
            Console.WriteLine($"La raiz cubica de {n3} es {Math.Pow(n3,1.0/3.0)}");
            //se preguntaran porque colocamos 1.0/3.0 en lugar de 1/3
            //eso se debe a que 1/3 es tratado como division de numeros enteros, por lo
            //tanto 1/3 = 0 porque la division de enteros no considera decimales;
            //Mientras que 1.0/3.0 se trata como una division de numeros que
            //va a producir decimales, por lo tanto su resultado es 0.3333333333
            //Recuerde que en programacion no es lo mismo dividir puros enteros
            //que dividir numeros double o float.

            //La clase Math tambien les provee algunos valores constantes
            //populares como por ejemplo:
            Console.WriteLine($"El valor de pi es {Math.PI}");
            Console.WriteLine($"El valor de la constante de Euler es {Math.E}");

            //Calculo de logaritmos
            double n4 = 2;
            Console.WriteLine($"El logaritmo de {n4} es {Math.Log(n4)}");
            Console.WriteLine($"El logaritmo base 2 de {n4} es {Math.Log2(n4)}");
            Console.WriteLine($"El logaritmo base 10 de {n4} es {Math.Log10(n4)}");

            //siempre recuerden que tambien puede guadar los calculos en variable aparte
            double logaritmo = Math.Log(n4);
            Console.WriteLine($"El logaritmo de {n4} es {logaritmo}");

            //Metodo Round: redondea un numero a los decimales que Usted determine
            double a = 1.23, b = 4.5, c = 9.0000002, d = 5.0, e = 7.46581112;

            //Redondeo a entero (cero decimales)
            Console.WriteLine($"Round de {a} es {Math.Round(a)}");
            Console.WriteLine($"Round de {b} es {Math.Round(b)}");
            Console.WriteLine($"Round de {c} es {Math.Round(c)}");
            Console.WriteLine($"Round de {d} es {Math.Round(d)}");
            Console.WriteLine($"Round de {e} es {Math.Round(e)}");

            //Redondeo a dos decimales
            Console.WriteLine($"Round a dos decimales de {a} es {Math.Round(a,2)}");
            Console.WriteLine($"Round a dos decimales de {b} es {Math.Round(b,2)}");
            Console.WriteLine($"Round a dos decimales de {c} es {Math.Round(c,2)}");
            Console.WriteLine($"Round a dos decimales de {d} es {Math.Round(d,2)}");
            Console.WriteLine($"Round a dos decimales de {e} es {Math.Round(e,2)}");

            //Metodo Ceiling: devuelve el numero entero superior del valor
            //proporcionado siempre y cuando halla una parte decimal, no importa
            //que tan pequeña sea. (se le conoce como redondeo forzado)
            Console.WriteLine($"Ceiling de {a} es {Math.Ceiling(a)}");
            Console.WriteLine($"Ceiling de {b} es {Math.Ceiling(b)}");
            Console.WriteLine($"Ceiling de {c} es {Math.Ceiling(c)}");
            Console.WriteLine($"Ceiling de {d} es {Math.Ceiling(d)}");
            Console.WriteLine($"Ceiling de {e} es {Math.Ceiling(e)}");

            //Metodo Floor: devuelve la parte entera de cualquier numero, no redondea
            Console.WriteLine($"Floor de {a} es {Math.Floor(a)}");
            Console.WriteLine($"Floor de {b} es {Math.Floor(b)}");
            Console.WriteLine($"Floor de {c} es {Math.Floor(c)}");
            Console.WriteLine($"Floor de {d} es {Math.Floor(d)}");
            Console.WriteLine($"Floor de {e} es {Math.Floor(e)}");

            //Si Usted quiere obtener solo parte decimal de un numero, puede
            //aprovechar el uso de Floor:
            Console.WriteLine($"Parte decimal de {e} es {e-Math.Floor(e)}");

            //ejercicios planteados en la pizarra
            double x = 5, y = 4, z = 1;
            //el programa se puede resolver de varias formas
            //por ejemplo, resolverlo al momento de imprimir:
            Console.WriteLine($"Resultado: {Math.Sqrt(Math.Pow(x,3)/(y-z))}");
            //otro ejemplo, almacenar el resultado en una variable:
            double resultado = Math.Sqrt(Math.Pow(x, 3) / (y - z));
            Console.WriteLine($"Resultado {resultado}");
            //un ejemplo mas, hacerlo por partes
            double fraccion = Math.Pow(x, 3) / (y - z);
            double r = Math.Sqrt(fraccion);
            Console.WriteLine($"Resultado {r}");

            //que pasaria si dentro de la raiz cuadrada queda un
            //numero negativo
            x = 5;
            y = 3;
            z = 9;
            Console.WriteLine($"Resultado: {Math.Sqrt(Math.Pow(x,3)/(y-z))}");
            //lo anterior producira una raiz cuadrada para un valor
            //negativo mostrando el resultado NaN lo que significa:
            //Not a Numbrer (no es un numero)
            //indicando que el valor no esta dentro de los numeros reales
            //sino dentro de los imaginarios o complejos.

            //que pasaria si el denominador de la division es CERO?
            x = 5;
            y = 3;
            z = 3;
            Console.WriteLine($"Resultado: {Math.Sqrt(Math.Pow(x,3)/(y-z))}");
            //lo anterior da como resultado Infinito, todo numero
            //dividido entre cero tiende al infinito.
            //En algunas computadoras sale el simbolo infinito como
            //un numero OCHO 8
            //en otras computadoras sale el numero 8 pero recostado
            //hay casos donde sale la palabra Inf o Infinite.
            
        }
    }
}
