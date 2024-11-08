namespace PrimesApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            for (int i = 1; i < 20; i++)
            {
                Console.WriteLine($"{i} : is prime {IsPrime(i)}");
            }
        }

        public static bool IsPrime(int n)
        {
            bool flag = true;
            for (int i = 2; i <= (int) Math.Sqrt(n); i++)
            {
                if (n % i == 0)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
