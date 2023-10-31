namespace ConsoleApp3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите свое имя:");
            string name;
            name= Console.ReadLine();
            int age;
            Console.WriteLine("Введите свой год рождения:");
            age = Convert.ToInt32(Console.ReadLine());
            age = (age - 2023) * -1;
            Console.WriteLine(name+ ", ты пидор "+age+"-летний");
        }
    }
}