using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Home.work1.Home1
{
    class Program
    {
        static void Main()
        {
            printFIO();
        }

        static void printFIO()
        {
            string name, surname, lastname;

            bool count = true;

            while (count)
            {

                Console.Write("Введите имя: ");
                name = Console.ReadLine();

                Console.Write("Введите фамилию: ");
                surname = Console.ReadLine();

                Console.Write("Введите отчество: ");
                lastname = Console.ReadLine();

                if (string.IsNullOrWhiteSpace(name) ||
                    string.IsNullOrWhiteSpace(surname) ||
                    string.IsNullOrWhiteSpace(lastname) ||
                    int.TryParse(name, out _) ||
                    int.TryParse(surname, out _) ||
                    int.TryParse(lastname, out _))
                {
                    Console.WriteLine("Ошибка! Вы ввели значение " +
                        "отличающееся от String или значение равно null! " +
                        "Нажмите Enter и введите данные еще раз");
                    Console.ReadLine();
                }
                else
                {
                    count = false;
                    Console.WriteLine("Приветствую тебя - " + name + " " + surname + " " + lastname);
                    Console.ReadLine();
                }
            }
        }

        static void printSumOfNumbers()
        {
            bool count = true;

            while (count)
            {
                Console.Write("Введите первое число:");
                string? First = Console.ReadLine();

                Console.Write("Введите второе число:");
                string? Second = Console.ReadLine();

                Console.Write("Введите третье число:");
                string? Thirt = Console.ReadLine();

                if (double.TryParse(First, out double first) &&
                    double.TryParse(Second, out double second) &&
                    double.TryParse(Thirt, out double thirt))
                {
                    count = false;
                    double Sum = first + second + thirt;
                    Console.Write("Сумма чисел:" + Sum);
                    Console.ReadLine();
                }
                else
                {
                    Console.Write("Введите число (int or double)! Нажмите Enter, чтобы продолжить!");
                    Console.ReadLine();
                }
            }
        }
    }

}