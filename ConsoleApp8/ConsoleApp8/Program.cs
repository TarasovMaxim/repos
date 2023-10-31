namespace ConsoleApp8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] bag = {45,44,4,8,68,8,8,6 };
            int[] tempBag= new int[bag.Length+1];
            for (int i = 0; bag.Length > i; i++)
            {
                tempBag[i] = bag[i];
               
            }
           
            for (int i = 0; tempBag.Length > i; i++) 
            {
                Console.WriteLine(tempBag[i]);
            }
                bag = tempBag;

        }
       
   
        
        
    }
}