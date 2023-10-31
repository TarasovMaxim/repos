namespace ConsoleApp15
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Queue<string> patients = new Queue<string>();
            patients.Enqueue("Василий");
            patients.Enqueue("Антон");
            patients.Enqueue("Генадий");
            patients.Enqueue("Игнат");
            patients.Enqueue("Булат");
           // Console.WriteLine( "Сейчас на прием идет: "+patients.Dequeue());
            Console.WriteLine("Следующий на прием идет: " + patients.Peek());
            foreach (string i in patients) 
            {
                Console.WriteLine(i); 
            }
        }
    }
}