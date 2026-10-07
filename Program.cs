namespace IMAT_GitTest
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Subtract(2,5));
        }
        static int Add(int a, int b)
        {
            return a + b;
        }

        static int Multiply(int x, int y)
        {
            return x*y;
        }
        static int Subtract(int x, int y)
        {
            return x-y;
        }
    }
}