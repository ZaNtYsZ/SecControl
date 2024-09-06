namespace secuencia6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int suma = 0; 
            // Recorer los números del 1 al 20
            for (int i = 1; i <= 20; i++)
            {
                // si el número es divisible entre 3
                if (i % 3 == 0)
                {
                    suma += i;  // Si es, lo suma a la variable "suma"
                }
            }

            Console.WriteLine($"La suma de todos los enteros de 1 a 20 que se pueden dividir entre 3 es: {suma}");

        }
    }
}
