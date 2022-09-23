using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework17._09._22
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Задание 1");
            Student student1 = new Student();
            student1.name = "Никита";
            student1.surname = "Иванов";
            student1.id = 221;
            student1.birthday = "12.05.2004";
            student1.alco = "Категория алкоголизма: А";
            student1.Valco = 3;

            Student student2 = new Student();
            student2.name = "Алексей";
            student2.surname = "Овальный";
            student2.id = 222;
            student2.birthday = "24.08.2003";
            student2.alco = "Категория алкоголизма: Д";
            student2.Valco = 0;

            Student student3 = new Student();
            student3.name = "Владимир";
            student3.surname = "Пупкин";
            student3.id = 223;
            student3.birthday = "06.11.2002";
            student3.alco = "Категория алкоголизма: А";
            student3.Valco = 4;

            Student student4 = new Student();
            student4.name = "Валерий";
            student4.surname = "Смирнов";
            student4.id = 224;
            student4.birthday = "11.05.2004";
            student4.alco = "Категория алкоголизма: Б";
            student4.Valco = 1.5;

            Student student5 = new Student();
            student5.name = "Джон";
            student5.surname = "Петров";
            student5.id = 225;
            student5.birthday = "30.12.2000";
            student5.alco = "Категория алкоголизма: С";
            student5.Valco = 0.5;
            double sumalco = student5.Valco + student4.Valco + student3.Valco + student2.Valco + student1.Valco;
            double sumalco1 = Math.Round( student1.Valco / sumalco * 100);
            double sumalco2 = Math.Round(student2.Valco / sumalco * 100);
            double sumalco3 = Math.Round(student3.Valco / sumalco * 100);
            double sumalco4 = Math.Round(student4.Valco / sumalco * 100);
            double sumalco5 = Math.Round(student5.Valco / sumalco * 100);
            Console.WriteLine($"Студент 1.\nИмя: {student1.name}");
            Console.WriteLine($"Фамилия: {student1.surname}");
            Console.WriteLine($"Индификационный номер: {student1.id}");
            Console.WriteLine($"День рождения: {student1.birthday}");
            Console.WriteLine(student1.alco);
            Console.WriteLine($"Процент выпитого алкоголя: {sumalco1}%");

            Console.WriteLine($"Студент 2.\nИмя: {student2.name}");
            Console.WriteLine($"Фамилия: {student2.surname}");
            Console.WriteLine($"Индификационный номер: {student2.id}");
            Console.WriteLine($"День рождения: {student2.birthday}");
            Console.WriteLine(student2.alco);
            Console.WriteLine($"Процент выпитого алкоголя: {sumalco2}%");

            Console.WriteLine($"Студент 3.\nИмя: {student3.name}");
            Console.WriteLine($"Фамилия: {student3.surname}");
            Console.WriteLine($"Индификационный номер: {student3.id}");
            Console.WriteLine($"День рождения: {student3.birthday}");
            Console.WriteLine(student3.alco);
            Console.WriteLine($"Процент выпитого алкоголя: {sumalco3}%");

            Console.WriteLine($"Студент 4.\nИмя: {student4.name}");
            Console.WriteLine($"Фамилия: {student4.surname}");
            Console.WriteLine($"Индификационный номер: {student4.id}");
            Console.WriteLine($"День рождения: {student4.birthday}");
            Console.WriteLine(student4.alco);
            Console.WriteLine($"Процент выпитого алкоголя: {sumalco4}%");

            Console.WriteLine($"Студент 5.\nИмя: {student5.name}");
            Console.WriteLine($"Фамилия: {student5.surname}");
            Console.WriteLine($"Индификационный номер: {student5.id}");
            Console.WriteLine($"День рождения: {student5.birthday}");
            Console.WriteLine(student5.alco);
            Console.WriteLine($"Процент выпитого алкоголя: {sumalco5}%");
            Console.ReadKey();


            Console.WriteLine("Задание 2");
            Console.WriteLine($"Тип данных sbyte: {SByte.MaxValue} - {SByte.MinValue}");
            Console.WriteLine($"Тип данных byte: {Byte.MaxValue} - {Byte.MinValue}");
            Console.WriteLine($"Тип данных short: {short.MaxValue} - {short.MinValue}");
            Console.WriteLine($"Тип данных ushort:  {ushort.MaxValue} - {ushort.MinValue}");
            Console.WriteLine($"Тип данных int: {Int32.MaxValue} - {Int32.MinValue}");
            Console.WriteLine($"Тип данных uint: {UInt32.MaxValue} - {UInt32.MinValue}");
            Console.WriteLine($"Тип данных long: {long.MaxValue} - {long.MinValue}");
            Console.WriteLine($"Тип данных ulong: {ulong.MaxValue} - {ulong.MinValue}");
            Console.WriteLine($"Тип данных char: любой один знак");
            Console.WriteLine($"Тип данных float: {float.MaxValue} - {float.MinValue}");
            Console.WriteLine($"Тип данных double: {Double.MaxValue} - {Double.MinValue}");
            Console.WriteLine($"Тип данных decimal: {Decimal.MaxValue }- {Decimal.MinValue}");
            Console.WriteLine("Тип данных bool: TRUE/FALSE");
            Console.ReadKey();


            Console.WriteLine("Задание 3.");
            Console.Write("Введите свое имя: ");
            Data Name3 = new Data();
            Name3.name3 = Console.ReadLine();
            Console.Write("В каком городе вы живете: ");
            Data City = new Data();
            City.city = Console.ReadLine();
            Console.Write("Введите свой возраст: ");
            Data Age = new Data();
            Age.age = byte.Parse(Console.ReadLine());
            Console.Write("Введите пин-код: ");
            Data Pin = new Data();
            Pin.pin = int.Parse(Console.ReadLine());
            Console.WriteLine($"Вас зовут: { Name3.name3}, вы из г.{City.city}, вам {Age.age} лет. Ваш ПИН-КОД: {Pin.pin}");
            Console.ReadKey();


            Console.WriteLine("Задание 4.");
            Console.Write("Введите свое имя: ");
            string name4 = Console.ReadLine();
           
            Console.ReadKey();


            Console.WriteLine("Задание 5.");
            Console.Write("Введите стоимость одной бутылки виски: ");
            int bottle = int.Parse(Console.ReadLine());
            Console.Write("Введите скидку: ");
            int sale = int.Parse(Console.ReadLine());
            Console.Write("Введите сколько вы потратили в отпуске: ");
            int holiday = int.Parse(Console.ReadLine());
            double resualt = (double)holiday / (sale * 0.01 * bottle);
            double resualt5 = Math.Round(resualt);
            Console.WriteLine($"Вы должны купить {resualt5} бутылок виски");
            Console.ReadKey();


            Console.WriteLine("Задание 6.");
            Console.Write("Введите скорость таракана в км/ч: ");
            double speedkm = double.Parse(Console.ReadLine());
            double speedsm = speedkm * 1000 / 36;
            double speedsm2 = Math.Floor(speedsm);
            Console.WriteLine($"Скорость таракана: {speedsm2} см/c");
            Console.ReadKey();


            Console.WriteLine("Задание 7");
            Console.Write("Введите строку ");
            string String = Console.ReadLine();
            char[] Char = String.ToCharArray();
            for (int i = 0; i < Char.Length; i++)
            {
                if (char.IsLower(Char[i]))
                {
                    Char[i] = char.ToUpper(Char[i]);
                }
                else
                {
                    Char[i] = char.ToLower(Char[i]);
                }
            }
            for (int i = 0; i < Char.Length; i++)
            { Console.Write(Char[i]); }
            Console.ReadKey();


        }

        struct Student
        {
            public string name;
            public string surname;
            public int id;
            public string birthday;
            public string alco;
            public double Valco;
        }
        struct Data
        {
            public string name3;
            public string city;
            public byte age;
            public int pin;
        }


    }
}
