using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Home.work3
{
    class Program
    {
        static void Main(string[] args)
        {
            Reverse();
            LowToUpAndReverse1();
            LowToUpAndReverse2();
            SumNumbersEndingWith3Or4();
            CountFirstLetter();
            LuckyNumber();

            Console.WriteLine("***Task GenerateRandomArray***");
            int[,] array = GenerateRandomArray(5, 5);
            PrintArray(array);

            int sum = SumBetweenMaxAndMin(array);

            if (sum != int.MinValue)
            {
                Console.WriteLine($"Сумма элементов между минимальным и максимальным элементами: {sum}");
            }
            else
            {
                Console.WriteLine("Не удалось найти минимальный и максимальный элементы в массиве.");
            }
            Console.ReadLine();

            Console.WriteLine("***Task RunProgram***");
            RunProgram();


            Console.WriteLine("***Task ContainsWordOne***");

            bool containsOne = ContainsWordOne();

            if (containsOne)
            {
                Console.WriteLine("Текст содержит слово 'one'.");
            }
            else
            {
                Console.WriteLine("Текст не содержит слово 'one'.");
            }

            Console.ReadLine();

            Console.WriteLine("***FindIndexOfMaxValue***");
            FindIndexOfMaxValue();

            Console.WriteLine("*** Удалить элемент из массива по индексу."

                    + "· Удаление элементов из массива по значению"

                    + "· Вставить элемент в массив по индекс * **");
            int[] numbers = { 1, 2, 3, 4, 5 };

            // Удаление элемента из массива по индексу
            int indexToRemove = 2; // Индекс элемента, который нужно удалить
            if (indexToRemove >= 0 && indexToRemove < numbers.Length)
            {
                RemoveElementAtIndex(ref numbers, indexToRemove);
            }

            // Удаление элементов из массива по значению
            int valueToRemove = 4; // Значение элемента, который нужно удалить
            numbers = RemoveElementsByValue(numbers, valueToRemove);

            // Вставка элемента в массив по индексу
            int valueToInsert = 10; // Значение для вставки
            int indexToInsert = 2; // Индекс, куда вставить элемент
            if (indexToInsert >= 0 && indexToInsert <= numbers.Length)
            {
                InsertElementAtIndex(ref numbers, indexToInsert, valueToInsert);
            }

            // Вывод массива после операций
            foreach (int number in numbers)
            {
                Console.WriteLine(number);
            }

            Console.ReadLine();


            Console.WriteLine("***ContainsNonAlphanumericCharacters***");
            Console.WriteLine("Введите текст:");
            string text = Console.ReadLine();

            bool containsNonAlphanumeric = ContainsNonAlphanumericCharacters(text);

            if (containsNonAlphanumeric)
            {
                Console.WriteLine("Текст содержит символы, отличающиеся от букв и цифр.");
            }
            else
            {
                Console.WriteLine("Текст не содержит символов, отличающихся от букв и цифр.");
            }

            Console.ReadLine();

            ////////////////
            Console.WriteLine("***CountLetterP***");
            Console.WriteLine("Введите строку:");
            string input = Console.ReadLine();

            int count = CountLetterP(input);

            Console.WriteLine($"Количество вхождений буквы 'P': {count}");
            Console.ReadLine();
        }

        /*Дано целое число N (> 0), найти число, полученное при прочтении числа N справа налево. 
         * Например, если было введено число 345, то программа должна вывести число 543.*/
        static void Reverse()
        {
            Console.WriteLine("Reverse");
            Console.Write("Введите число:");
            string N = Console.ReadLine();
            for (int i = N.Length - 1; i >= 0; i--)
            {
                Console.Write(N[i]);
            }
            Console.ReadLine();
        }



        /*Числовые значения символов нижнего регистра в коде ASCII отличаются от значений символов 
         * верхнего регистра на величину 32. 
         *Используя эту информацию, написать программу, 
         *которая считывает с клавиатуры и конвертирует все символы нижнего регистра в 
         *символы верхнего регистра и наоборот.*/
        static void LowToUpAndReverse1()
        {
            Console.WriteLine("LowToUpAndReverse1");
            string simbol = "";


            Console.WriteLine("Введите буквы для изменения регистра, (для остановки введите 0):");

            bool flag = true;
            int count = 0;

            while (flag)
            {
                simbol = Console.ReadLine();
                for (int i = 0; i < simbol.Length; i++)
                {
                    if ((int)' ' == (int)simbol[i])
                    {
                        Console.Write((char)(int)simbol[i]);
                    }
                    else if (((int)'A' <= (int)simbol[i] && (int)simbol[i] <= (int)'Z') ||
                        ((int)'А' <= (int)simbol[i] && (int)simbol[i] <= (int)'Я'))
                    {
                        Console.Write((char)((int)simbol[i] + 32));
                    }

                    else if (((int)'a' <= (int)simbol[i] && (int)simbol[i] <= (int)'z') ||
                        ((int)'а' <= (int)simbol[i] && (int)simbol[i] <= (int)'я'))
                    {
                        Console.Write((char)((int)simbol[i] - 32));
                    }
                    else if (simbol[i] == '0')
                    {
                        flag = false;
                    }
                }

            }

            Console.ReadLine();

        }

        /*Способ 2*/
        static void LowToUpAndReverse2()
        {
            Console.WriteLine("LowToUpAndReverse2");
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

        /*
         Задача, которая стоит 3 сникерса
         */
        static void SumNumbersEndingWith3Or4()
        {
            Console.WriteLine("SumNumbersEndingWith3Or4");
            string input = "123 456 789 324 1234    45 1004";

            string[] words = input.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            int sum = 0;

            foreach (string word in words)
            {
                if (word.EndsWith("3") || word.EndsWith("4"))
                {
                    if (int.TryParse(word, out int num))
                    {
                        sum += num;
                    }
                }
            }

            Console.WriteLine(input);
            Console.WriteLine("Сумма чисел, оканчивающихся на '3' или '4': " + sum);
            Console.ReadLine();

        }


        /*
         Нужно ввести текст и определить, 
         на какую букв начинается больше всего слов в тексте.
         */
        static void CountFirstLetter()
        {
            Console.WriteLine("CountFirstLetter");
            Console.WriteLine("Введите текст:");
            string text = Console.ReadLine();
            string[] words = text.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            int max = 0;
            int count;
            List<char> mostFrequentLetters = new List<char>();
            for (int i = 0; i < words.Length; i++)
            {
                char firstLetter = words[i][0];
                count = 1;
                for (int j = i + 1; j < words.Length; j++)
                {
                    if (words[j].StartsWith(firstLetter.ToString()))
                    {
                        count++;
                    }
                }
                if (count > max)
                {
                    max = count;
                    mostFrequentLetters.Clear(); // Очищаем предыдущие буквы
                    mostFrequentLetters.Add(firstLetter);
                }
                else if (count == max)
                {
                    mostFrequentLetters.Add(firstLetter);
                }

            }

            Console.WriteLine("Буквы, которые чаще всего встречаются в начале слов:");
            foreach (char letter in mostFrequentLetters)
            {
                Console.WriteLine(letter);
            }
            Console.ReadLine();
        }

        /*
         Ввести с клавиатуры номер трамвайного билета (6-значное число) 
        и проверить является ли данный билет счастливым (если на билете напечатано 
        шестизначное число, и сумма первых трёх цифр равна сумме последних трёх, 
        то этот билет считается счастливым).
         */
        static void LuckyNumber()
        {
            Console.WriteLine("***LuckyNumber***");
            Console.Write("Введите шестизначное число:");

            string numberOfTransport = Console.ReadLine();

            int lucky;
            if (!int.TryParse(numberOfTransport, out lucky) && numberOfTransport.Length != 6)
            {
                Console.WriteLine("Введите число и длина его должна быть равна 6!");
            }
            else
            {
                int sumOfLeftSide = 0;
                int sumOfRightSide = 0;

                for (int i = numberOfTransport.Length / 2 - 1; i >= 0; i--)
                {
                    sumOfLeftSide += int.Parse(numberOfTransport[i].ToString());
                }
                for (int i = numberOfTransport.Length - 1; i >= numberOfTransport.Length / 2; i--)
                {
                    sumOfRightSide += int.Parse(numberOfTransport[i].ToString());
                }

                if (sumOfRightSide == sumOfLeftSide)
                    Console.WriteLine("lucky");
                else
                    Console.WriteLine("unlucky");
            }
            Console.ReadLine();

        }

        /*
         Дан двумерный массив размерностью 5×5, заполненный случайными числами из диапазона от –100 до 100. 
        Определить сумму элементов массива, расположенных между минимальным и максимальным элементами
         */
        static int[,] GenerateRandomArray(int rows, int cols)
        {
            Random rnd = new Random();
            int[,] array = new int[rows, cols];

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    array[i, j] = rnd.Next(-100, 101);
                }
            }

            return array;
        }

        /*
         Метод относится к задаче GenerateRandomArray
         */
        static void PrintArray(int[,] array)
        {
            int rows = array.GetLength(0);
            int cols = array.GetLength(1);

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    Console.Write(array[i, j].ToString().PadLeft(5) + " ");
                }
                Console.WriteLine();
            }
        }
        /*
         Метод относится к задаче GenerateRandomArray
        */
        static int SumBetweenMaxAndMin(int[,] array)
        {
            int minValue = int.MaxValue;
            int maxValue = int.MinValue;
            int sum = 0;

            int rows = array.GetLength(0);
            int cols = array.GetLength(1);

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    int value;
                    if (int.TryParse(array[i, j].ToString(), out value))
                    {
                        if (value < minValue)
                            minValue = value;
                        if (value > maxValue)
                            maxValue = value;
                    }
                }
            }

            if (minValue == int.MaxValue || maxValue == int.MinValue)
            {
                return int.MinValue;
            }

            bool foundMin = false;
            bool foundMax = false;

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    int value;
                    if (int.TryParse(array[i, j].ToString(), out value))
                    {
                        if (value == minValue)
                            foundMin = true;

                        if (foundMin && !foundMax)
                            sum += value;

                        if (value == maxValue)
                            foundMax = true;
                    }
                }
            }

            return sum;
        }

        /*
         Составьте программу, которая в слове «класс» две одинаковые буквы заменяет цифрой «1»
         */
        static void RunProgram()
        {
            Console.WriteLine("Введите слово:");
            string word = Console.ReadLine();

            string modifiedWord = ReplaceDuplicateLettersWith1(word);

            Console.WriteLine("Измененное слово: " + modifiedWord);
        }

        /*
         Метод относится к RunProgram
         */
        static string ReplaceDuplicateLettersWith1(string input)
        {
            char[] charArray = input.ToCharArray();

            for (int i = 0; i < charArray.Length - 1; i++)
            {
                for (int j = i + 1; j < charArray.Length; j++)
                {
                    if (charArray[i] == charArray[j])
                    {
                        charArray[i] = '1';
                        charArray[j] = '1';
                    }
                }
            }

            return new string(charArray);
        }

        /*
         Дан текст. Определить, есть ли в тексте слово one.
         */
        static bool ContainsWordOne()
        {
            Console.WriteLine("Введите текст:");
            string text = Console.ReadLine();

            string[] words = text.Split(new[] { ' ', ',', '.', '!', '?' }, StringSplitOptions.RemoveEmptyEntries);

            foreach (string word in words)
            {
                if (string.Equals(word, "one", StringComparison.OrdinalIgnoreCase))
                {
                    return true;
                }
            }

            return false;
        }

        /*
         Найти индекс максимального значения в массиве (воспользоваться функцией)
         */
        static void FindIndexOfMaxValue()
        {
            int[] array = { 5, 4, 75, 45, 12, 65, 2, 4, 9 };
            if (array.Length == 0)
            {
                Console.WriteLine("Массив пустой.");
                return;
            }

            int maxValue = array[0];
            int maxIndex = 0;

            for (int i = 1; i < array.Length; i++)
            {
                if (array[i] > maxValue)
                {
                    maxValue = array[i];
                    maxIndex = i;
                }
            }

            Console.WriteLine($"Индекс максимального значения: {maxIndex}");
        }

        /*
         Удалить элемент из массива по индексу.

        · Удаление элементов из массива по значению

        · Вставить элемент в массив по индекс
         */
        static void RemoveElementAtIndex(ref int[] array, int index)
        {
            for (int i = index; i < array.Length - 1; i++)
            {
                array[i] = array[i + 1];
            }
            Array.Resize(ref array, array.Length - 1);
        }

        static int[] RemoveElementsByValue(int[] array, int value)
        {
            int[] result = Array.FindAll(array, x => x != value);
            return result;
        }

        static void InsertElementAtIndex(ref int[] array, int index, int value)
        {
            Array.Resize(ref array, array.Length + 1);
            for (int i = array.Length - 1; i > index; i--)
            {
                array[i] = array[i - 1];
            }
            array[index] = value;
        }

        /*
         Дан текст. Определить, содержит ли он символы, отличающиеся от букв и цифр.
         */
        static bool ContainsNonAlphanumericCharacters(string input)
        {
            foreach (char c in input)
            {
                if (!char.IsLetter(c) && !char.IsDigit(c))
                {
                    return true; // Если найден символ, отличающийся от букв и цифр
                }
            }

            return false; // Если таких символов не найдено
        }

        /*
         Дана строка, посчитать количество вхождений буквы P.
         */
        static int CountLetterP(string input)
        {
            int count = 0;

            foreach (char c in input)
            {
                if (char.ToUpper(c) == 'P') // Игнорируем регистр с помощью char.ToUpper
                {
                    count++;
                }
            }

            return count;
        }
    }
}