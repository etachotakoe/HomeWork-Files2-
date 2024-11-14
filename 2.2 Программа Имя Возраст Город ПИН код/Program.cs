using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Напишите программу, в которой принимаются данные пользователя в виде имени, города, возраста и PIN-кода. Далее сохраните все значение в соответствующей переменной, а затем распечатайте всю информацию в правильном формате.");
        Console.Write("\n Введите ваше имя: ");
        string name = Console.ReadLine();

        Console.Write("Введите ваш город: ");
        string city = Console.ReadLine();

        Console.Write("Введите ваш возраст: ");
        int age;
        while (true)
        {

            if (int.TryParse(Console.ReadLine(), out age))
            {
                if (age < 0)
                {
                    Console.WriteLine("Какова вероятность того, что ты мой внук? Или праправнук?? Или может прапрапра... ПУТЕШЕСТВЕННИК ВО ВРЕМЕНИ????!!! Отвечай по чесноку... у тебя есть шанс не злить меня. ");
                }
                else if (age < 10 && age > 0)
                {
                    Console.WriteLine("Кто дал мелкому этот компьютер? Врать что ли не учили при вводе возраста? В наше время было по другому... Давай еще одну попытку, кто еще научит, если не я ;)");
                }
                else if (age > 100)
                {
                    Console.WriteLine($"И давно тебе {age} лет? Пожалуйста, введите корректный возраст: ");
                }
                else
                {
                    break; // Корректный возраст, выходим из цикла
                }
            }
            else
            {
                Console.Write("Пожалуйста, введите корректный возраст: ");
            }
        }

        Console.Write("\n Введите ваш PIN-код: ");
        string pinCode = Console.ReadLine();

        Console.WriteLine("Ваша информация: ");
        Console.WriteLine($"Имя: {name}");
        Console.WriteLine($"Город: {city}");
        Console.WriteLine($"Возраст: {age}");
        Console.WriteLine($"PIN-код: {pinCode}");
    }

}
