namespace FiboRecursive
{
    internal class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i < 20; i++)
            {
                Console.WriteLine($"{i}\t{Fibo(i)}");
            }
        }

        /// <summary>
        /// Calculates the nth Fibonacci number.
        /// </summary>
        /// <param name="n">The position in the Fibonacci sequence.</param>
        /// <returns>The nth Fibonacci number.</returns>
        public static int Fibo(int n)
        {
            if (n == 0)
            {
                return 0;
            }
            if (n == 1)
            {
                return 1;
            }

            return Fibo(n - 1) + Fibo(n - 2);
        }
    }
}
