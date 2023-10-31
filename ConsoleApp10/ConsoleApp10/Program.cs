

namespace ConsoleApp10
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int j = 3000, z = 5, q = 100000, sum=5555;
            sum +=Sum(j, z ,q);


            Console.WriteLine(Sum(j,j,j));

        }
        static int Sum (int x, int y,int z)
        {
            int sum =( x + y);
           return sum;
        }
    }
}