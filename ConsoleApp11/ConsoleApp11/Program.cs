using System.Runtime.Serialization.Formatters;

namespace ConsoleApp11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int health = 10, maxHealth = 50;
            int mana = 7, maxMana = 50;
            while (true)
            {
                DrawBar(health, maxHealth, ConsoleColor.Green, 0, '|');
                DrawBar(mana, maxMana, ConsoleColor.Blue, 1);
                Console.SetCursorPosition(0, 5);
                health+=Convert.ToInt32(Console.ReadLine());
                mana+= Convert.ToInt32(Console.ReadLine());
                Console.ReadKey();
                Console.Clear();
            }
        }


        static  void DrawBar( int value, int maxValue, ConsoleColor color, int position, char symbol='_')
        {
            ConsoleColor defaultColor = Console.BackgroundColor;
            string bar = "";
            for( int i=0; i<value; i++ ) 
            {
                bar += symbol;
            }
         
            Console.SetCursorPosition( 0, position );
            Console.Write('[');
            Console.BackgroundColor = color;
            Console.Write(bar);
            Console.BackgroundColor = defaultColor;
            bar = "";

            for (int i = value; i < maxValue; i++)
            {
                bar += symbol;
                
            }
            Console.Write(bar + "]");
        }

    }
}