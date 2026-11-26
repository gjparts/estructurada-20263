namespace _14_Polimorfismo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Gato gato1 = new Gato(4, true, "Mandarino", true);
            gato1.Imprimir();
            gato1.Hablar();
            gato1.Ronronear();

            Animal hipo1 = new Animal("Hipopotamo", "Paquidemo", 4, true);
            hipo1.Imprimir();
            hipo1.Hablar();

            Perro p1 = new Perro(4, false, "Killer", "Doberman");
            p1.Imprimir();
            p1.Hablar();
            p1.Jugar();

            //han notado que todos los objetos en C# tienen el metodo ToString()
            Console.WriteLine(gato1.ToString());
            Console.WriteLine(hipo1.ToString());
            Console.WriteLine(p1.ToString());
            int x = 90;
            Console.WriteLine(x.ToString());
        }
    }
}
