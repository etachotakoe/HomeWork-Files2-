using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Написать программу, содержащую решение следующих задач:\r\n﻿﻿﻿Выведите на экран информацию о каждом типе данных в виде:\r\nТип данных - максимальное значение - минимальное значение.");
        Console.WriteLine("\n int - " + int.MaxValue + " - " + int.MinValue);
        Console.WriteLine("\n long - " + long.MaxValue + " - " + long.MinValue);
        Console.WriteLine("\n short - " + short.MaxValue + " - " + short.MinValue);
        Console.WriteLine("\n byte - " + byte.MaxValue + " - " + byte.MinValue);
        Console.WriteLine("\n sbyte - " + sbyte.MaxValue + " - " + sbyte.MinValue);
        Console.WriteLine("\n float - " + float.MaxValue + " - " + float.MinValue);
        Console.WriteLine("\n double - " + double.MaxValue + " - " + double.MinValue);
        Console.WriteLine("\n decimal - " + decimal.MaxValue + " - " + decimal.MinValue);
    }
}