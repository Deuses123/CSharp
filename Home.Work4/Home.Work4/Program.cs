
namespace Home.Work4
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Train[] trains = new Train[5];

            // Заполняем массив объектами, используя различные конструкторы
            trains[0] = new Train("Train 1", 100, 50.0, true);
            trains[1] = new Train("Train 2", 150, 60.5, false);
            trains[2] = new Train("Train 3", 80, 45.3, true);
            trains[3] = new Train("Train 4", 120, 55.2, true);
            trains[4] = new Train(); // Используем конструктор по умолчанию для последнего элемента

            // Выводим информацию о поездах
            foreach (var train in trains)
            {
                Console.WriteLine(train);
            }
        }
    }



    public partial class Train
    {
        // Закрытые поля
        private string trainName;
        private int numberOfPassengers;
        private double length;
        private bool isRunning;
        private static int trainCount; // Статическое поле для подсчета общего количества поездов

        // Свойства для доступа к закрытым полям
        public string TrainName
        {
            get { return trainName; }
            set { trainName = value; }
        }

        public int NumberOfPassengers
        {
            get { return numberOfPassengers; }
            set { numberOfPassengers = value; }
        }

        public double Length
        {
            get { return length; }
            set { length = value; }
        }

        public bool IsRunning
        {
            get { return isRunning; }
            set { isRunning = value; }
        }

        // Статическое поле для общего количества поездов
        public static int TrainCount
        {
            get { return trainCount; }
        }

        // Конструктор по умолчанию
        public Train()
        {
            trainName = "Unknown";
            numberOfPassengers = 0;
            length = 0.0;
            isRunning = false;
            trainCount++;
        }

        // Перегруженный конструктор
        public Train(string name, int passengers, double trainLength, bool running)
        {
            trainName = name;
            numberOfPassengers = passengers;
            length = trainLength;
            isRunning = running;
            trainCount++;
        }

        // Статический конструктор
        static Train()
        {
            trainCount = 0;
        }

        // Метод для изменения числа пассажиров по ссылке
        public void ChangePassengerCount(ref int newPassengerCount)
        {
            numberOfPassengers = newPassengerCount;
        }

        // Дополнительный метод, объявленный в другом файле с использованием partial
        partial void AdditionalMethod();

        public override string ToString()
        {
            return $"Train Name: {trainName}, Passengers: {numberOfPassengers}, Length: {length} meters, Running: {isRunning}";
        }
    }



}