namespace secuencias
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 5;
            int b = 3;
            int c = 4;
            if ((a + b + c > 10) || (a == b))
            {
                Console.WriteLine("La respuesta es mayor que 10");
                Console.WriteLine("O el primer número es igual al segundo");
            }
            else
            {
                Console.WriteLine("La respuesta no es mayor que 10");
                Console.WriteLine("Y el primer número no es igual al segundo");
            }
        }
    }
}
