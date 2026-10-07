namespace IMAT_GitTest
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Divide(2,1));
        }
        static int Add(int a, int b)
        {
            return a + b;
        }

        static int Multiply(int x, int y)
        {
            return x*y;
        }

        static int Divide(int x, int y)
        {
            return x/y;
        }

    }
}