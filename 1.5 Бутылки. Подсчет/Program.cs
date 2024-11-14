﻿using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Цель этой задачи - определить, сколько бутылок виски беспошлинной торговли вам нужно будет купить, чтобы экономия по сравнению с обычной средней ценой фактически покрыла расходы на ваш отпуск. Вам будет предоставлена стандартная цена (normPrice), скидка в Duty Free (salePrice) и стоимость отпуска (holidayPrice). Например, если бутылка обычно стоит 10 фунтов стерлингов, а скидка в дьюти фри составляет 10%, вы сэкономите 1 фунт стерлингов на каждой бутылке. Если ваш отпуск стоит 500 фунтов стерлингов, ответ, который вы должны вернуть, будет 500. Все входные данные будут целыми числами. Пожалуйста, верните целое число. Округлить в меньшую сторону.");
        int price1 = 10;
        int dfprice = 9;
        int holiday = 500;
        double num; // переменная для количества бутылок

        while (true) // бесконечный цикл, который будет прерываться при выполнении условий
        {
            Console.Write("\n \n Введите количество бутылок, которое собираетесь брать в Дьюти Фри: ");


            if (double.TryParse(Console.ReadLine(), out num))
            {

                if (num < 500)
                {
                    Console.WriteLine("Сэкономленные деньги не покрывают расходы на отпуск. Попробуйте ввести количество еще раз.");
                }
                else
                {
                    int savings = (price1 - dfprice) * (int)num;

                    if (savings >= holiday)
                    {
                        Console.WriteLine($"Сэкономленные с покупки {num} бутылок виски деньги покрывают расходы на отпуск.");
                    }
                    else
                    {
                        Console.WriteLine("Сэкономленные деньги не покрывают расходы на отпуск.");
                    }
                    break;
                }
            }
            else
            {
                Console.WriteLine("Ошибка ввода. Пожалуйста, введите числовое значение.");
            }
        }
    }
}