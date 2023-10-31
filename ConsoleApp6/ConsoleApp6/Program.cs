

namespace ConsoleApp6
{
     class Program
    {
        static void Main(string[] args)
        {
            bool isOpen = true;
            string[,]books={{ "Пушкин","Лермонтов","Глуховский"},{"Стивен Кинг","Говард Лавкрафт","Брэм Стокер"},{ "Донцова","Ален Карр","Игорь Прокопенко" }};
            while (isOpen)
            {
                Console.WriteLine("Библиотека\n\n1-узнать, что за книга, зная ее индекс.\n\n2-найти книгу по автору \n\n3-Вывести спиок книг\n\n4-выход\n\nВведите пункт меню:");
                switch(Convert.ToInt32(Console.ReadLine()))
                {
                    
                    case 1:
                        Console.WriteLine("Введите номер стелажа:");
                        int rows=Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Введите номер полки:");
                        int cols=Convert.ToInt32(Console.ReadLine());
                        if ((books.GetLength(0) < rows)|(books.GetLength(1) < cols))
                        {
                            Console.WriteLine("Введите корректные данные");
                        }
                        else
                        {
                            Console.WriteLine(books[rows-1, cols-1]);
                            
                        }
                        break;
                    case 2:
                        Console.WriteLine("Введите имя автора:");
                        string author = Console.ReadLine();
                        bool isOpen2 = true;
                        for (int i = 0; i< books.GetLength(0);i++) 
                        {
                            for (int j = 0; j< books.GetLength(1);j++)
                            {
                                if (author == books[i, j])
                                { Console.WriteLine((i + 1) + " номер стелажа " + (j + 1) + " номер полки"); }
                                else
                                {isOpen2 = false; }

                            }
                        }
                        if (isOpen2 == false) { Console.WriteLine("Такого автора нет в библиотеке"); }
                        break;
                    case 3:
                        for (int i = 0; i < books.GetLength(0); i++)
                        {
                            for (int j = 0; j < books.GetLength(1); j++)
                            {
                                Console.WriteLine(books[i, j]);

                            }
                         
                            
                        }
                        Console.WriteLine();    
                        break;
                    case 4:
                        isOpen = false;
                        break;
                      
                }
                Console.WriteLine("Нажмите любую клавишу для продолжения... ");
                Console.ReadKey();
                Console.Clear();
            }
            
            
            
            
        }
    }
}