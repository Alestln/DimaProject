namespace DimaProject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Однострочные комментарии

            /*
             * Многострочный комментарий
             */

            // Создание переменной
            // тип_данных имя_переменной = значение;

            // Создание переменной и ее инициализация
            // int number = 42;

            // Создание переменной без инициализации
            // int number;

            Console.Write("Enter your name: ");

            string name = Console.ReadLine();
            Console.WriteLine($"Your name is: {name}"); // Интерполяция строк

            Console.Write("Enter your age: ");
            int age = int.Parse(Console.ReadLine());
            Console.WriteLine("Your age is: " + age); // Конкатенация строк
        }
    }
}
