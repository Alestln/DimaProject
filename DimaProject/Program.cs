namespace DimaProject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите порядковый номер пальца руки: ");
            int number = Convert.ToInt32(Console.ReadLine());

            if (number == 1)
            {
                Console.WriteLine("Большой");
            }
            else if (number == 2)
            {
                Console.WriteLine("Указательный");
            }
            else if (number == 3)
            {
                Console.WriteLine("Средний");
            }
            else if (number == 4)
            {
                Console.WriteLine("Безымянный");
            }
            else if (number == 5)
            {
                Console.WriteLine("Мизинец");
            }
            else
            {
                Console.WriteLine("Неверный порядковый номер");
            }

            // Домашнее задание
            // Решить задание через логическое И и логическое ИЛИ, и решить это же задания не используя логические операторы и switch.
            /*
             * 1) Требуется определить, является ли введенный пользователем год високосным (напомним, что год является високосным, если его номер кратен 4, но не кратен 100, а также если он кратен 400).
             * 2) Даны три целых числа, которые пользователь вводит с клавиатуры. Найти количество положительных и количество отрицательных чисел в исходном наборе.
             */
        }
    }
}
