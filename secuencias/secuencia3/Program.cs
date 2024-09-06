namespace secuencia3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int counter = 0;
            do
            {
                Console.WriteLine($"¡Hola Mundo! El contador es {counter}");
                counter++;
            } while (counter < 10);
        }
    }
}
