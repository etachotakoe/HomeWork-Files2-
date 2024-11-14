using System;

namespace BankAcc
{
    enum AccountType //перечисляем виды банк счета
    {
        Current,      //текущий
        Savings       //сберегательный
    }

    struct BankAcc //структура счета
    {
        public string AccountNumber;
        public AccountType Type;
        public decimal Balance;

        public BankAcc(string accountNumber, AccountType type, decimal balance)
        {
            AccountNumber = accountNumber;
            Type = type;
            Balance = balance;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Упражнение 3.1 Создать перечислимый тип данных отображающий виды банковского счета (текущий и сберегательный). Создать переменную типа перечисления, присвоить ей значение и вывести это значение на печать.");
            Console.WriteLine("Упражнение 3.2 Создать структуру данных, которая хранит информацию о банковском счете - его номер, тип и баланс. Создать переменную такого типа, заполнить структуру значениями и напечатать результат.");


            AccountType myAccountType = AccountType.Current;
            Console.WriteLine("Тип счета: " + myAccountType);


            BankAcc myAccount = new BankAcc("8122012", AccountType.Savings, 228);


            Console.WriteLine("Информация о банковском счете:");
            Console.WriteLine("Номер счета: " + myAccount.AccountNumber);
            Console.WriteLine("Тип счета: " + myAccount.Type);
            Console.WriteLine("Баланс: " + myAccount.Balance);
        }
    }
}
