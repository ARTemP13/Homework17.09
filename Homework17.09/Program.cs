using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Упражнение 3.1. Тип данных ");
            Bank account = Bank.Actual;
            Console.WriteLine(account);
            Console.ReadKey();


            Console.WriteLine("Упражнение 3.2. Структура данных ");
            BankAcc Number = new BankAcc(); 
            Number.number = "4200567489";
            BankAcc Balance = new BankAcc();
            Balance.balance = 1024;
            BankAcc Type = new BankAcc();
            Type.type = "Save";
            Console.WriteLine($"Номер счета: {Number.number}");
            Console.WriteLine($"Баланс аккаунта: {Balance.balance}$");
            Console.WriteLine($"Тип аккаунта: {Type.type}");
            Console.ReadKey();


            Console.WriteLine("Упражнение 3.3. Работники и вузы ");
            Worker Name1 = new Worker();
            Name1.name = "Алексей";
            Worker Name2 = new Worker();
            Name2.name = "Илья";
            Worker Name3 = new Worker();
            Name3.name = "Евгений";
            Worker Univ1 = new Worker();
            Univ1.university = Univ.KAI;
            Worker Univ2 = new Worker();
            Univ2.university = Univ.KHTI;
            Worker Univ3 = new Worker();
            Univ3.university = Univ.KGU;
            Console.WriteLine($"1 работник: Имя: {Name1.name}, Университет: {Univ1.university}");
            Console.WriteLine($"2 работник: Имя: {Name2.name}, Университет: {Univ2.university}");
            Console.WriteLine($"3 работник: Имя: {Name3.name}, Университет: {Univ3.university}");
            Console.ReadKey();

        }
    }
    enum Bank
    {
        Actual,
        Save
    }
    struct BankAcc
    {
        public string number;
        public double balance;
        public string type;

        
    }
    enum Univ
    {
        KGU,
        KAI,
        KHTI
    }
    struct Worker
    {
        public string name;
        public Univ university;
    }



}