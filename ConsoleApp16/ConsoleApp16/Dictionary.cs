
namespace Dictionary
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> bodyParts = new Dictionary<string, string>();
            bodyParts.Add("Нога", "нижний парный орган опоры и движения человека");
            bodyParts.Add("Рука", "верхняя конечность человека и некоторых других животных, орган опорно-двигательного аппарата");
            bodyParts.Add("Голова", "часть тела животного или человека, в которой находятся мозг, органы зрения, вкуса, обоняния, слуха и рот");
            bodyParts.Add("Ухо", "сложный орган животных и человека, предназначенный для восприятия звуковых колебаний");
            string inputTerm = Console.ReadLine();
            string defenition = ("В словаре нет таких терминов");

            foreach (var part in bodyParts)
            {
                if (part.Key == inputTerm)
                {
                    defenition = ($"{part.Key} -это {part.Value}");
                    break;
                }
            }
            Console.WriteLine(defenition);
        }
    }
}