using System;


namespace UniversityEmployee
{

    enum University
    {
        KGU,
        KAI,
        KHTI
    }

    class rabotnik
    {
        public string Name { get; }
        public University University { get; }


        public rabotnik(string name, University university)
        {
            Name = name;
            University = university;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Домашнее задание 3.1 Создать перечислимый тип ВУЗ (КГУ, КАИ, КХТИ). Создать структуру работник с двумя полями: имя, ВУЗ. Заполнить структуру данными и распечатать.");
            rabotnik rab1 = new rabotnik("Мойша Абрамович", University.KGU);
            rabotnik rab2 = new rabotnik("Ганс Шнайдер", University.KAI);


            PrintRABInfo(rab1);
            PrintRABInfo(rab2);
        }


        static void PrintRABInfo(rabotnik rab)
        {
            Console.WriteLine("Работник:");
            Console.WriteLine($"Имя: {rab.Name}");
            Console.WriteLine($"ВУЗ: {rab.University}");

        }
    }
}