namespace Practice.Work4
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Пример первой задачи");
            f1();
            Console.WriteLine("Пример второй задачи");
            f2();
            Console.WriteLine("Пример третьей задачи");
            f3();
            Console.WriteLine("Пример четвертой задачи");
            f4();
            Console.WriteLine("Пример пятой задачи");
            f5();
            Console.WriteLine("Пример шестой задачи");
            f6();
        }

        public static void f1()
        {
            Student[] students = new Student[10];
            students[0] = new Student("Иванов Иван Иванович", "Группа 101", new int[] { 5, 4, 5, 4, 5 });
            students[1] = new Student("Петров Петр Петрович", "Группа 101", new int[] { 4, 4, 3, 4, 5 });
            students[2] = new Student("Сидоров Сидор Сидорович", "Группа 102", new int[] { 5, 5, 5, 5, 5 });
            students[3] = new Student("Андреев Андрей Андреевич", "Группа 102", new int[] { 3, 4, 4, 3, 4 });
            students[4] = new Student("Николаев Николай Николаевич", "Группа 103", new int[] { 5, 4, 5, 4, 4 });
            students[5] = new Student("Егоров Егор Егорович", "Группа 103", new int[] { 4, 4, 5, 3, 4 });
            students[6] = new Student("Олегов Олег Олегович", "Группа 104", new int[] { 5, 5, 4, 4, 5 });
            students[7] = new Student("Дмитриев Дмитрий Дмитриевич", "Группа 104", new int[] { 3, 3, 4, 5, 3 });
            students[8] = new Student("Сергеев Сергей Сергеевич", "Группа 105", new int[] { 5, 5, 5, 5, 5 });
            students[9] = new Student("Алексеев Алексей Алексеевич", "Группа 105", new int[] { 4, 5, 4, 5, 4 });

            // Сортировка студентов по среднему баллу (по возрастанию)
            Array.Sort(students, (student1, student2) => student1.GetAverageGrade().CompareTo(student2.GetAverageGrade()));

            // Вывод фамилий и номеров групп студентов с оценками 4 или 5
            Console.WriteLine("Студенты с оценками 4 или 5:");
            foreach (var student in students)
            {
                if (student.HasOnlyGoodGrades())
                {
                    Console.WriteLine($"{student.FullName}, {student.GroupNumber}");
                }
            }

        }
        public static void f2()
        {
            List<Animal> animals = new List<Animal>
        {
            new Carnivore { ID = 1, Name = "Лев" },
            new Omnivore { ID = 2, Name = "Медведь" },
            new Herbivore { ID = 3, Name = "Зебра" },
            new Carnivore { ID = 4, Name = "Тигр" },
            new Omnivore { ID = 5, Name = "Человек" },
            new Herbivore { ID = 6, Name = "Кролик" }
        };

            // Упорядочиваем список по убыванию количества пищи и по имени
            var sortedAnimals = animals.OrderByDescending(animal => animal.CalculateFoodAmount())
                                       .ThenBy(animal => animal.Name)
                                       .ToList();

            // Выводим информацию о животных
            Console.WriteLine("Информация о животных:");
            foreach (var animal in sortedAnimals)
            {
                Console.WriteLine(animal);
            }

            // Выводим первые 5 имен животных
            Console.WriteLine("\nПервые 5 имен животных:");
            var firstFiveNames = sortedAnimals.Take(5).Select(animal => animal.Name);
            Console.WriteLine(string.Join(", ", firstFiveNames));

            // Выводим последние 3 идентификатора животных
            Console.WriteLine("\nПоследние 3 идентификатора животных:");
            var lastThreeIDs = sortedAnimals.Skip(sortedAnimals.Count - 3).Select(animal => animal.ID);
            Console.WriteLine(string.Join(", ", lastThreeIDs));

            // Сохраняем коллекцию животных в файл
            string filePath = "animals.txt";
            SaveAnimalsToFile(sortedAnimals, filePath);

            // Читаем коллекцию животных из файла и выводим ее
            Console.WriteLine("\nЧтение коллекции из файла:");
            var loadedAnimals = LoadAnimalsFromFile(filePath);
            foreach (var animal in loadedAnimals)
            {
                Console.WriteLine(animal);
            }

        }
        public static void f3()
        {
            Library library = new Library();

            // Добавляем книги в библиотеку
            library.AddBook(new Book { Title = "Book A", Author = "Author X", Year = 2000 });
            library.AddBook(new Book { Title = "Book B", Author = "Author Y", Year = 1995 });
            library.AddBook(new Book { Title = "Book C", Author = "Author Z", Year = 2021 });

            // Выводим список всех книг
            Console.WriteLine("All Books:");
            library.DisplayLibrary();

            // Ищем книги по автору и году
            Console.WriteLine("\nBooks by Author X:");
            var booksByAuthor = library.SearchByAuthor("Author X");
            foreach (var book in booksByAuthor)
            {
                Console.WriteLine(book);
            }

            Console.WriteLine("\nBooks from Year 2000:");
            var booksByYear = library.SearchByYear(2000);
            foreach (var book in booksByYear)
            {
                Console.WriteLine(book);
            }

            // Сортируем библиотеку по автору и выводим
            Console.WriteLine("\nLibrary Sorted by Author:");
            library.SortByAuthor();
            library.DisplayLibrary();
        }
        public static void f4()
        {
            Car car1 = new Car("Toyota Camry", "AB123CD");
            Car car2 = new Car("Honda Civic", "XY789ZW");

            Driver driver1 = new Driver("John");
            Driver driver2 = new Driver("Alice");

            Dispatcher dispatcher = new Dispatcher();

            dispatcher.AssignCarToDriver(driver1, car1);

            Trip trip1 = new Trip("Airport", DateTime.Now.AddHours(1));
            driver1.MakeTripRequest(trip1);

            dispatcher.AssignCarToDriver(driver2, car2);

            Trip trip2 = new Trip("Downtown", DateTime.Now.AddHours(2));
            driver2.MakeTripRequest(trip2);

            driver1.MarkTripAsCompleted(trip1);

            driver2.ReportCarMaintenanceIssue();

            dispatcher.SuspendDriver(driver2);
        }
        public static void f5()
        {
            BookingSystem bookingSystem = new BookingSystem();

            // Добавляем поезда в систему
            bookingSystem.AddTrain(new Train(101, "Station A", "Station B", DateTime.Now.AddHours(1), 50.0m));
            bookingSystem.AddTrain(new Train(102, "Station B", "Station C", DateTime.Now.AddHours(2), 60.0m));

            Passenger passenger = new Passenger("John");
            Ticket ticket = passenger.MakeReservation(bookingSystem, "Station A", "Station B", DateTime.Now.AddHours(1));

            if (ticket != null)
            {
                Cashier cashier = new Cashier();
                cashier.GenerateInvoice(ticket);
            }
        }
        public static void f6()
        {
            BankAccount account1 = new BankAccount("123456");
            BankAccount account2 = new BankAccount("789012");
            BankCard card1 = new BankCard("1111222233334444", DateTime.Now.AddYears(3));
            BankCard card2 = new BankCard("5555666677778888", DateTime.Now.AddYears(2));
            Client client1 = new Client("Alice", account1.AccountNumber, card1.CardNumber, card1.ExpiryDate);
            Client client2 = new Client("Bob", account2.AccountNumber, card2.CardNumber, card2.ExpiryDate);
            Administrator administrator = new Administrator();

            // Client 1 makes a payment
            Order order1 = new Order("Order001", 100.0m);
            client1.MakePayment(order1);

            // Client 2 makes a transfer
            client2.MakeTransfer(account1, 50.0m);

            // Administrator blocks a card
            administrator.BlockCard(card1);

            // Client 1 attempts to make a payment with the blocked card
            Order order2 = new Order("Order002", 75.0m);
            client1.MakePayment(order2);

            // Client 1 cancels the account
            account1.CancelAccount();
            client1.MakeTransfer(account2, 25.0m);
        }
        static void SaveAnimalsToFile(List<Animal> animals, string filePath)
        {
            using (StreamWriter writer = new StreamWriter(filePath))
            {
                foreach (var animal in animals)
                {
                    writer.WriteLine($"{animal.ID};{animal.Name};{animal.TypeOfFood}");
                }
            }
        }
        static List<Animal> LoadAnimalsFromFile(string filePath)
        {
            List<Animal> loadedAnimals = new List<Animal>();
            try
            {
                using (StreamReader reader = new StreamReader(filePath))
                {
                    string line;
                    while ((line = reader.ReadLine()) != null)
                    {
                        string[] parts = line.Split(';');
                        if (parts.Length == 3)
                        {
                            int id = int.Parse(parts[0]);
                            string name = parts[1];
                            string typeOfFood = parts[2];

                            Animal animal;
                            switch (typeOfFood)
                            {
                                case "Хищник":
                                    animal = new Carnivore { ID = id, Name = name };
                                    break;
                                case "Всеядное":
                                    animal = new Omnivore { ID = id, Name = name };
                                    break;
                                case "Травоядное":
                                    animal = new Herbivore { ID = id, Name = name };
                                    break;
                                default:
                                    continue; // Пропустить некорректные записи
                            }

                            loadedAnimals.Add(animal);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Ошибка при чтении файла: {ex.Message}");
            }
            return loadedAnimals;
        }
    }
}