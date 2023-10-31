using System;
using System.ComponentModel.Design;

namespace _22
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool iSOpen = true;
            int[] tables = { 44, 2, 31, 4, 8, 9 };
            
            while (iSOpen == true)
            {
                Console.SetCursorPosition(0, 17);
                for (int i = 0; i < tables.Length; i++)

                { 
                 Console.WriteLine("за столом  -  " + (i + 1) + " свободно " + tables[i] + " мест.");
                }


                Console.SetCursorPosition(45, 2);
                Console.WriteLine("Администрирование кафе");
                Console.WriteLine("1- Забронировать место \n\n2-выход из программы");
                Console.WriteLine("\n\nВведите номер команды");
                        switch (Convert.ToInt32(Console.ReadLine()))
                        {

                            case 1:
                                Console.WriteLine("За каким столиком Вы бронируете место? ");
                                int userTable, userPlace;
                                userTable = Convert.ToInt32(Console.ReadLine());
                        if ((tables.Length <= (userTable-1 ))|(userTable<=0))
                        { Console.WriteLine("выберете с первого по " + tables.Length + "ой столик"); break; }
                        else { Console.WriteLine("Сколько мест Вы бронируете за столиком? "); }
                     
                                userPlace = Convert.ToInt32(Console.ReadLine());
                        if (tables[userTable-1] < userPlace)
                        {
                            Console.WriteLine("За этим столик нет стольких мест");
                            break; }
                        if (userPlace<=0 ) { Console.WriteLine("Число мест должно быть больше нуля");break; }
                        tables[userTable - 1] -= userPlace;
                        
                        break;
                            case 2:
                                iSOpen = false;
                                break;
                        }
                        Console.ReadKey();
                        Console.Clear();
                    
                
            }
        }
    }

}
        










        







