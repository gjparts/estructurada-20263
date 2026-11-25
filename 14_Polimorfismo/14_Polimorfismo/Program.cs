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
        }
    }
}
