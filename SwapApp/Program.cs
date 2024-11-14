namespace SwapApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 10; 
            int b = 20;
            Swap(ref a, ref b);

            Console.WriteLine($"a: {a}, b: {b}");

            string s = null;
            ChangeStr(out s);
            Console.WriteLine(s);
        }

        //Does not work
        //public static void Swap(int a, int b)
        //{
        //    int tmp = a;
        //    a = b;
        //    b = tmp;
        //}

        public static void Swap(ref int a, ref int b)
        {
            int tmp = a;
            a = b;
            b = tmp;
        }

        //Does not work
        //public static void ChangeStr(String str)
        //{
        //    str = "AUEB";
        //}

        public static void ChangeStr(out String? str)
        {
            str = "AUEB";
        }
    }
}
