namespace FiboWithArray
{
    internal class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i < 20; i++)
            {
                Console.WriteLine($"{i}\t{Fibo(i),10}");
            }
        }

        public static int Fibo(int n)
        {

            if (n <= 1)
            {
                return n;
            }

            int[] arr = new int[n + 1];
            arr[0] = 0;
            arr[1] = 1;

            for (int i = 2; i <= n; i++)
            {
                arr[i] = arr[i - 1] + arr[i - 2];
            }

            return arr[n];
        }
    }
}
