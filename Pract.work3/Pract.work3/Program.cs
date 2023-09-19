using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Practice.work1
{
    class Program
    {
        static void Main()
        {
            var rand = new Random();

            //1 задача
            Console.WriteLine("1) Введите три числа");
            F1();

            //2 задача
            Console.WriteLine("2) Три числа по столбику");
            F2();

            //3 задача
            Console.WriteLine("3) Введите сантимеры");
            Console.WriteLine("В метрах - " + F3());

            //4 задача
            Console.WriteLine("3)");
            F4();

            //5 задача
            Console.WriteLine("4)");
            F5();

            //6 задача
            Console.WriteLine("6)");
            F6();

            //7 задача
            Console.WriteLine("7)");
            F7();

            //8 задача
            Console.WriteLine("8)");
            F8();

            //9 задача
            Console.WriteLine("9)");
            F9();

            //10 задача
            F10();



            //20 задача свап с помощью значении
            int a = 1;
            int b = 2;
            (a, b) = Swap20(a, b);
            Console.WriteLine("20) " + a + " " + b);


            //21 задача свап с помощью ссылок
            a = 1;
            b = 2;
            Swap21(ref a, ref b);
            Console.WriteLine("21) " + a + " " + b);

            //22 задача 
            Console.Write("22)\nВведите значение x: ");
            int x = int.Parse(Console.ReadLine());

            Console.Write("Введите значение y: ");
            int y = int.Parse(Console.ReadLine());

            double result = F22(x, y);

            Console.WriteLine("Результат: " + result);

            //23 задача
            Console.Write("23)\nВведите часы (0-23): ");
            int hours = int.Parse(Console.ReadLine());

            Console.Write("Введите минуты (0-59): ");
            int minutes = int.Parse(Console.ReadLine());

            Console.Write("Введите секунды (0-59): ");
            int seconds = int.Parse(Console.ReadLine());

            result = F23(hours, minutes, seconds);

            if (result != -1)
            {
                Console.WriteLine("Количество секунд с начала дня: " + result);
            }
            else
            {
                Console.WriteLine("Ошибка: некорректные данные.");
            }

            //24 задача
            Console.Write("24)\nВведите месяц (1-12): ");
            int month = int.Parse(Console.ReadLine());

            Console.Write("Введите день (1-31): ");
            int day = int.Parse(Console.ReadLine());

            result = F24(month, day);

            if (result != -1)
            {
                Console.WriteLine("Количество дней с начала года: " + result);
            }
            else
            {
                Console.WriteLine("Ошибка: некорректные данные.");
            }

            //25 задача
            Console.Write("25)\nВведите месяц (1-12): ");
            month = int.Parse(Console.ReadLine());

            Console.Write("Введите день (1-31): ");
            day = int.Parse(Console.ReadLine());

            result = F25(month, day);

            if (result != -1)
            {
                Console.WriteLine("Количество дней с начала года: " + result);
            }
            else
            {
                Console.WriteLine("Ошибка: некорректные данные.");
            }

            //26 задача
            Console.WriteLine("29) три аргумента - 5, (8,2), (7, 1, 10)");
            Console.WriteLine("Наименьшее число: " + F26()); // Используем значения по умолчанию
            Console.WriteLine("Наименьшее число: " + F26(5)); // Один аргумент
            Console.WriteLine("Наименьшее число: " + F26(8, 2)); // Два аргумента
            Console.WriteLine("Наименьшее число: " + F26(7, 1, 10));

            //27 задача
            a = rand.Next(1, 100);
            Console.WriteLine("27) Четное ли число " + a + " = " + Even27(a));

            //28 задача
            a = 30;
            b = 14;
            int c = 20;
            Console.WriteLine("28) Минимальное значение из " + a + b + c + " -> " + F28(a, b, c));

            //29 задача
            Console.WriteLine("29) ");
            F29();

            //30 задача
            Console.WriteLine("30) " + F30(10, 3));

            //31 задача
            Console.WriteLine("31) " + F31(10, 3));
        }
        static void F1()
        {
            int a, b, c = 0;
            a = Convert.ToInt32(Console.ReadLine());
            b = Convert.ToInt32(Console.ReadLine());
            c = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(a + " " + b + " " + c);
        }
        static void F2()
        {
            Console.WriteLine(5);
            Console.WriteLine(10);
            Console.WriteLine(21);
        }
        static int F3()
        {

            int sm = 0;
            sm = Convert.ToInt32(Console.ReadLine());
            return (sm / 100);
        }
        static void F4()
        {
            int days = 234;
            Console.WriteLine("В неделях " + days / 7);
        }
        static void F5()
        {
            bool flag = true;
            while (flag)
            {
                Console.Write("Введите число:");
                string a = Console.ReadLine();
                if (int.TryParse(a, out int number))
                {
                    if (number / 10 > 0 && number / 10 < 10)
                    {
                        flag = false;
                        Console.Write("Число десятков:" + number / 10);
                        Console.WriteLine();
                        Console.Write("Число единиц:" + number % 10);
                        Console.WriteLine();
                        Console.Write("Сумма цифр:" + ((number / 10) + (number % 10)));
                        Console.WriteLine();
                        Console.Write("Произведение цифр:" + ((number / 10) * (number % 10)));
                        Console.ReadLine();
                    }
                    else
                    {
                        Console.WriteLine("Введите двузначное число!");
                    }
                }
                else
                {
                    Console.WriteLine("Ошибка введите допустимый тип переменной! (int). Нажмите Enter");
                    Console.ReadLine();
                }
            }
        }
        static void F6()
        {
            bool a = true;
            bool b = false;
            bool c = false;
            bool d = a || b;
            bool e = a && b;
            bool f = b || c;
            Console.WriteLine(d + " " + e + " " + f);
        }
        static void F7()
        {
            int squareSide = 0;
            int radius = 0;
            Console.WriteLine("Please write squareSide:");
            squareSide = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please write radius:");
            radius = Convert.ToInt32(Console.ReadLine());
            double squareOfCircle = 3.14 * radius * radius;
            if (squareSide * squareSide > squareOfCircle)
            {
                Console.WriteLine("squareOfSquare biger than squareOfCircle");
            }
            else if (squareSide * squareSide < squareOfCircle)
            {
                Console.WriteLine("squareOfCircle biger than squareOfSquare");
            }
            else
            {
                Console.WriteLine("Equal");
            }
        }
        static void F8()
        {
            double massOfFirstObject = 0;
            double massOfSecondObject = 0;
            double volumeOfFirstObject = 0;
            double volumeOfSecondObject = 0;

            Console.WriteLine("Please write the value for all variable: ");
            massOfFirstObject = Convert.ToInt32(Console.ReadLine());
            massOfSecondObject = Convert.ToInt32(Console.ReadLine());
            volumeOfFirstObject = Convert.ToInt32(Console.ReadLine());
            volumeOfSecondObject = Convert.ToInt32(Console.ReadLine());

            double densityOfFirstObject = massOfFirstObject / volumeOfFirstObject;
            double densityOfSecondObject = massOfSecondObject / volumeOfSecondObject;

            if (densityOfSecondObject > densityOfFirstObject)
            {
                Console.WriteLine("densityOfSecondObject: " + densityOfSecondObject);
            }
            else if (densityOfSecondObject < densityOfFirstObject)
            {
                Console.WriteLine("densityOfFirstObject: " + densityOfFirstObject);
            }
            else
            {
                Console.WriteLine("Equals");
            }
        }
        static void F9()
        {
            Console.Write("Введите сопротивление для первого участка: ");
            double resistance1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите напряжение для первого участка: ");
            double voltage1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Введите сопротивление для второго участка: ");
            double resistance2 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите напряжение для второго участка: ");
            double voltage2 = Convert.ToDouble(Console.ReadLine());

            double current1 = voltage1 / resistance1;
            double current2 = voltage2 / resistance2;

            if (current1 < current2)
            {
                Console.WriteLine("Ток на участке 1 меньше: " + current1 + " Ампер");
                Console.ReadLine();
            }
            else if (current2 < current1)
            {
                Console.WriteLine("Ток на участке 2 меньше: " + current2 + " Ампер");
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("Токи на обоих участках равны: " + current1 + " Ампер");
                Console.ReadLine();
            }
        }
        static void F10()
        {
            Console.WriteLine("Выберите задание:");
            Console.WriteLine("a) Все целые числа от 20 до 35.");
            Console.WriteLine("b) Квадраты всех целых чисел от 10 до b (значение b вводится с клавиатуры; b > 10).");
            Console.WriteLine("c) Третьи степени всех целых чисел от a до 50 (значение a вводится с клавиатуры; a < 50).");
            Console.WriteLine("d) Все целые числа от a до b (значения a и b вводятся с клавиатуры; b > a).");

            char choice;

            while (!char.TryParse(Console.ReadLine(), out choice) || (choice != 'a' && choice != 'b' && choice != 'c' && choice != 'd'))
            {
                Console.WriteLine("Выбор задания некорректен. Попробуйте ещё раз:");
            }

            Console.WriteLine();

            switch (choice)
            {
                case 'a':
                    for (int i = 20; i <= 35; i++)
                    {
                        Console.WriteLine(i);
                    }
                    break;
                case 'b':
                    int b;
                    do
                    {
                        if (TryParseInt("Введите значение b (b > 10):", out b) && b > 10)
                        {
                            break;
                        }
                        Console.WriteLine("Значение b должно быть больше 10. Попробуйте ещё раз:");
                    } while (true);

                    for (int i = 10; i <= b; i++)
                    {
                        Console.WriteLine(i * i);
                    }
                    break;
                case 'c':
                    int a;
                    do
                    {
                        if (TryParseInt("Введите значение a (a < 50):", out a) && a < 50)
                        {
                            break;
                        }
                        Console.WriteLine("Значение a должно быть меньше 50. Попробуйте ещё раз:");
                    } while (true);

                    for (int i = a; i <= 50; i++)
                    {
                        Console.WriteLine(Math.Pow(i, 3));
                    }
                    break;
                case 'd':
                    int start, end;
                    do
                    {
                        if (TryParseInt("Введите значение a:", out start) &&
                            TryParseInt("Введите значение b:", out end) && end > start)
                        {
                            break;
                        }
                        Console.WriteLine("Значение b должно быть больше a. Попробуйте ещё раз:");
                    } while (true);

                    for (int i = start; i <= end; i++)
                    {
                        Console.WriteLine(i);
                    }
                    break;
            }
        }

        static bool TryParseInt(string message, out int result)
        {
            Console.Write(message + " ");
            return int.TryParse(Console.ReadLine(), out result);
        }
        static int printSum()
        {
            int i, j = 0;
            i = Convert.ToInt32(Console.ReadLine());
            j = Convert.ToInt32(Console.ReadLine());
            return i + j;
        }
        static void printName()
        {
            string name = "", surname = "";
            Console.WriteLine("What is your name?: ");
            name = Console.ReadLine();
            Console.WriteLine("What is your surname?: ");
            surname = Console.ReadLine();
            Console.WriteLine("Your name is " + name + ", Your surname is " + surname);
        }
        static (int, int) Swap20(int a, int b)
        {
            return (b, a);

        }
        static void Swap21(ref int a, ref int b)
        {
            (b, a) = (a, b);
        }
        static double F22(int x, int y)
        {
            if (x == 0 && y == 0)
            {
                return 0;
            }
            else if (y == 0)
            {
                return 12.0 / x;
            }
            else if (x == 0)
            {
                return 12.0 / y;
            }
            else
            {
                return 144.0 / (x * y);
            }
        }
        static int F23(int h, int m, int s)
        {
            if (h < 0 || h >= 24 || m < 0 || m >= 60 || s < 0 || s >= 60)
            {
                return -1;
            }

            int totalSeconds = h * 3600 + m * 60 + s;

            return totalSeconds;
        }
        static int F24(int m, int d)
        {
            if (m < 1 || m > 12 || d < 1 || d > 30)
            {
                return -1;
            }

            int totalDays = (m - 1) * 30 + d;

            return totalDays;
        }
        static int F25(int m, int d)
        {
            int[] daysInMonth = { 31, 30, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };

            if (m < 1 || m > 12 || d < 1 || d > daysInMonth[m - 1])
            {
                return -1;
            }

            int totalDays = 0;

            for (int i = 0; i < m - 1; i++)
            {
                totalDays += daysInMonth[i];
            }

            totalDays += d;

            return totalDays;
        }
        static int F26(int m1 = 999, int m2 = 999, int m3 = 999)
        {
            if (m1 < 1 || m1 > 999) m1 = 999;
            if (m2 < 1 || m2 > 999) m2 = 999;
            if (m3 < 1 || m3 > 999) m3 = 999;

            int minNumber = m1;

            if (m2 < minNumber)
            {
                minNumber = m2;
            }
            if (m3 < minNumber)
            {
                minNumber = m3;
            }

            return minNumber;
        }
        static bool Even27(int n)
        {
            return n % 2 == 0;
        }
        static int F28(int a, int b, int c)
        {

            if (a <= b && a <= c)
            {
                return a;
            }
            else if (b <= a && b <= c)
            {
                return b;
            }
            else
            {
                return c;
            }

        }
        static void F29()
        {
            Random rand = new Random();

            for (int i = 0; i < 10; i++)
            {
                int grade = rand.Next(2, 6);
                string message;

                switch (grade)
                {
                    case 2:
                        message = "Неуд";
                        break;
                    case 3:
                        message = "Удовл";
                        break;
                    case 4:
                        message = "Хорошо";
                        break;
                    case 5:
                        message = "Отлично";
                        break;
                    default:
                        message = "Недопустимая оценка";
                        break;
                }

                Console.WriteLine($"Оценка: {grade}, Результат: {message}");
            }
        }
        static int F30(int M, int N)
        {
            int sum = 0;

            // Проверяем, чтобы M было нечетным, иначе увеличиваем M на 1
            if (M % 2 == 0)
            {
                M++;
            }

            for (int i = M; i <= N; i += 2)
            {
                sum += i;
            }

            return sum;
        }
        static int F31(int N, int n)
        {

            int result = N;

            while (result % n != 0)
            {
                result++;
            }

            return result;
        }

    }

}