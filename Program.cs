namespace Recursion
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Addition");

            Console.WriteLine("Enter number n:");
            int n = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Enter number m:");
            int m = Int32.Parse(Console.ReadLine());

            int result = RecursiveSum(n, m);

            // result of the addition
            Console.WriteLine(result);
            
            Console.WriteLine("Division");

            Console.WriteLine("Enter your number: ");
            int x = Int32.Parse(Console.ReadLine());

            result = RecursiveDivision(x);
            Console.WriteLine($"Total number of divisions : {result}");
        }

        // Recursive sum function
        public static int RecursiveSum(int n, int m)
        {
            if (n == m) return m;

            return n + m + RecursiveSum(n + 1, m - 1);
        }

        // get count of division by 2
        public static int RecursiveDivision(int x)
        {
            if(x == 0) return 0;

            if(x % 2 == 0) return 1 + RecursiveDivision(Math.Abs(x / 2));

            return 0;
        }
    }
}
