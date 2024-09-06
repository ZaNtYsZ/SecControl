namespace secuencia5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            for (int fila = 1; fila < 11; fila++)
            {
                Console.WriteLine($"La fila es {fila}");
            }

            Console.WriteLine("---------------------------------------------");

            for (char columna = 'a'; columna < 'k'; columna++)
            {
                Console.WriteLine($"La columna es {columna}");
            }

            Console.WriteLine("---------------------------------------------");

            for (int fila = 1; fila < 11; fila++)
            {
                for (char columna = 'a'; columna < 'k'; columna++)
                {
                    Console.WriteLine($"La celda es ({fila}, {columna})");
                }
            }

        }
    }
}
