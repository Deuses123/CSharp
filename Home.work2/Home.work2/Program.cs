using System;

class Program
{
    static void Main(string[] args)
    {
        //1
        Console.WriteLine("1 задача");
        F1();
        //2
        Console.WriteLine("2 задача");
        F2();
        //3
        Console.WriteLine("3 задача");
        F3();
        //4
        Console.WriteLine("4 задача");
        F4();
        //6
        Console.WriteLine("6 задача");
        F6();
        //7
        Console.WriteLine("7 задача");
        F7();
        //8
        Console.WriteLine("8 задача");
        F8();
        //9
        Console.WriteLine("9 задача");
        F9();
        //10
        Console.WriteLine("10 задача");
        F10();
        //11
        Console.WriteLine("11 задача");
        F11();
        //12
        Console.WriteLine("12 задача");
        F12();
        //13
        Console.WriteLine("13 задача");
        F13();
        //14
        Console.WriteLine("14 задача");
        F14();
        //15
        Console.WriteLine("15 задача");
        F15();
        
        //30
        Console.WriteLine("30) Задача");
        F30();
        //31
        Console.WriteLine("31) Задача");
        F31();
        //32
        Console.WriteLine("32) Задача");
        F32();
        //33
        Console.WriteLine("33) Задача");
        F33();
        //34
        Console.WriteLine("34) Задача");
        F34();
        //35
        Console.WriteLine("35) Задача");
        F35();

    }

    static bool TryParseInt(string message, out int result)
    {
        Console.Write(message + " ");
        return int.TryParse(Console.ReadLine(), out result);
    }
    static void F1()
    {
        Console.Write("Введите размер массива:");
        int size = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Введите символы (для того, чтобы остановить программу введите '.'):");
        char[] str = new char[size];
        bool flag = true;
        int i = 0;
        int count = 0;
        while (i < size && flag)
        {
            str[i] = Convert.ToChar(Console.ReadLine());

            if (str[i] == ' ')
            {
                count++;
            }
            if (str[i] == '.')
            {
                flag = false;
            }
            i++;
        }

        Console.WriteLine("Количество пробелов:" + count);
        Console.ReadLine();
    }
    static void F2()
    {
        Console.Write("Введите шестизначное число:");
        int lucky = Convert.ToInt32(Console.ReadLine());
        //123321
        if (lucky / 1000 % 10 + lucky / 10000 % 10 + lucky / 100000 % 10 == lucky % 10 + lucky % 100 / 10 + lucky % 1000 / 100)
        {
            Console.WriteLine("Счастливое число!");
        }
        else
        {
            Console.WriteLine("Несчастливое число!");
        }

        Console.ReadLine();
    }
    static void F3()
    {

        char simbol = ' ';

        Console.WriteLine("Введите буквы для изменения регистра, (для остановки введите 0):");
        int i = 0;

        bool flag = true;

        while (flag)
        {
            simbol = Convert.ToChar(Console.ReadLine());
            if (((int)'A' <= (int)simbol && (int)simbol <= (int)'Z') ||
                ((int)'А' <= (int)simbol && (int)simbol <= (int)'Я'))
            {
                Console.WriteLine(simbol + "->" + (char)((int)simbol + 32));
            }
            else if (((int)'a' <= (int)simbol && (int)simbol <= (int)'z') ||
                ((int)'а' <= (int)simbol && (int)simbol <= (int)'я'))
            {
                Console.WriteLine(simbol + "->" + (char)((int)simbol - 32));
            }
            else if (simbol == '0')
            {
                flag = false;
            }
            else
            {
                Console.WriteLine("Введите букву!");
            }
            i++;
        }

        Console.ReadLine();

    }
    static void F4()
    {
        Console.WriteLine("Введите числа А и В:");

        int A, B;
        if (!int.TryParse(Console.ReadLine(), out A) || !int.TryParse(Console.ReadLine(), out B))
        {
            Console.WriteLine("Некорректный ввод. Введите целые числа.");
            Console.ReadLine();
            return;
        }

        if (Math.Abs(A) >= Math.Abs(B))
        {
            for (int i = 1; i <= A; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    if (i >= B)
                        Console.Write(i);
                }
                if (i >= B)
                    Console.WriteLine();
            }
        }
        else if (Math.Abs(B) >= Math.Abs(A))
        {
            for (int i = 1; i <= B; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    if (i >= A)
                        Console.Write(i);
                }
                if (i >= A)
                    Console.WriteLine();
            }
        }
        else
        {
            Console.WriteLine("Введите число удовлетворяющее условию!");
        }

        Console.ReadLine();
    }
    static void F6()
    {
        Console.WriteLine("Введите 3 числа:");
        int a, b, c = 0;
        a = Convert.ToInt32(Console.ReadLine());
        b = Convert.ToInt32(Console.ReadLine());
        c = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine(a + "  " + b + "  " + c);

        Console.ReadLine();
    }
    static void F7()
    {
        Console.WriteLine(5);
        Console.WriteLine(10);
        Console.WriteLine(21);

        Console.ReadLine();
    }
    static void F8()
    {
        int santimetr = 0;
        Console.WriteLine("Введите сантиметры:");
        santimetr = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Metrs:" + santimetr / 100);
    }
    static void F9()
    {
        int days = 234;
        Console.WriteLine(days / 7);
    }
    static void F10()
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
            }
            Console.ReadLine();
        }
    }
    static void F11()
    {
        bool a = true;
        bool b = false;
        bool c = false;
        bool d = a || b;
        bool e = a && b;
        bool f = b || c;
        Console.WriteLine("Result:" + d + " " + e + " " + f);
    }
    static void F12()
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
    static void F13()
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
    static void F14()
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
    static void F15()
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
        Console.ReadLine();
    }
   

    //Даны два различных вещественных числа. Определить: a.какое из них больше; b.какое из них меньше
    static void F30()
    {
        Console.WriteLine("Введите первое вещественное число:");
        double number1 = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Введите второе вещественное число:");
        double number2 = Convert.ToDouble(Console.ReadLine());

        if (number1 > number2)
        {
            Console.WriteLine($"Число {number1} больше числа {number2}");
        }
        else if (number1 < number2)
        {
            Console.WriteLine($"Число {number1} меньше числа {number2}");
        }
        else
        {
            Console.WriteLine($"Числа {number1} и {number2} равны");
        }
    }

    //Известны два расстояния: одно в километрах, другое — в футах ( 1 фут 0,305 м ). Какое из расстояний меньше?
    static void F31()
    {
        Console.WriteLine("Введите расстояние в километрах:");
        double distanceInKilometers = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Введите расстояние в футах:");
        double distanceInFeet = Convert.ToDouble(Console.ReadLine());

        // Преобразуем расстояние в футах в километры
        double distanceInMeters = distanceInFeet * 0.305;
        double distanceInKilometersFromFeet = distanceInMeters / 1000;

        if (distanceInKilometers < distanceInKilometersFromFeet)
        {
            Console.WriteLine($"Расстояние в километрах ({distanceInKilometers}) меньше расстояния в футах ({distanceInFeet})");
        }
        else if (distanceInKilometers > distanceInKilometersFromFeet)
        {
            Console.WriteLine($"Расстояние в футах ({distanceInFeet}) меньше расстояния в километрах ({distanceInKilometers})");
        }
        else
        {
            Console.WriteLine("Расстояния равны.");
        }
    }

    //Дано натуральное число. Определить: a.является ли оно четным; b.оканчивается ли оно цифрой 7
    static void F32()
    {
        Console.WriteLine("Введите натуральное число:");
        int number = Convert.ToInt32(Console.ReadLine());

        // Проверка на четность
        if (number % 2 == 0)
        {
            Console.WriteLine("Число является четным.");
        }
        else
        {
            Console.WriteLine("Число не является четным.");
        }

        // Проверка на окончание цифрой 7
        if (number % 10 == 7)
        {
            Console.WriteLine("Число оканчивается цифрой 7.");
        }
        else
        {
            Console.WriteLine("Число не оканчивается цифрой 7.");
        }
    }

    //Дано двузначное число. Определить: a.какая из его цифр больше: первая или вторая; b.одинаковы ли его цифры.
    static void F33()
    {
        Console.WriteLine("Введите двузначное число:");
        int number = Convert.ToInt32(Console.ReadLine());

        if (number >= 10 && number <= 99)
        {
            int tensDigit = number / 10;  // Получаем десятки
            int onesDigit = number % 10; // Получаем единицы

            if (tensDigit > onesDigit)
            {
                Console.WriteLine("Первая цифра больше второй.");
            }
            else if (tensDigit < onesDigit)
            {
                Console.WriteLine("Вторая цифра больше первой.");
            }
            else
            {
                Console.WriteLine("Цифры равны.");
            }
        }
        else
        {
            Console.WriteLine("Это не двузначное число.");
        }
    }

    //Составить программу, которая в зависимости от порядкового номера дня недели(1, 2, ..., 7) выводит на экран его название(понедельник, вторник, ..., воскресенье).
    static void F34()
    {
        Console.WriteLine("Введите порядковый номер дня недели (1-7):");
        int dayNumber = Convert.ToInt32(Console.ReadLine());

        string dayName;

        switch (dayNumber)
        {
            case 1:
                dayName = "понедельник";
                break;
            case 2:
                dayName = "вторник";
                break;
            case 3:
                dayName = "среда";
                break;
            case 4:
                dayName = "четверг";
                break;
            case 5:
                dayName = "пятница";
                break;
            case 6:
                dayName = "суббота";
                break;
            case 7:
                dayName = "воскресенье";
                break;
            default:
                dayName = "недействительный номер";
                break;
        }

        Console.WriteLine($"День недели под номером {dayNumber} - это {dayName}");
    }

    //Составить программу, которая в зависимости от порядкового номера дня месяца (1, 2, ..., 12) выводит на экран его название (январь, февраль, ..., декабрь).
    static void F35()
    {
        Console.WriteLine("Введите порядковый номер месяца (1-12):");
        int monthNumber = Convert.ToInt32(Console.ReadLine());

        string monthName;

        switch (monthNumber)
        {
            case 1:
                monthName = "январь";
                break;
            case 2:
                monthName = "февраль";
                break;
            case 3:
                monthName = "март";
                break;
            case 4:
                monthName = "апрель";
                break;
            case 5:
                monthName = "май";
                break;
            case 6:
                monthName = "июнь";
                break;
            case 7:
                monthName = "июль";
                break;
            case 8:
                monthName = "август";
                break;
            case 9:
                monthName = "сентябрь";
                break;
            case 10:
                monthName = "октябрь";
                break;
            case 11:
                monthName = "ноябрь";
                break;
            case 12:
                monthName = "декабрь";
                break;
            default:
                monthName = "недействительный номер";
                break;
        }

        Console.WriteLine($"Месяц под номером {monthNumber} - это {monthName}");
    }
}
