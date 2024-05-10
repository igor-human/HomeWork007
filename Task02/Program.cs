
using Task02;

namespace task02
{
    class Program
    {
        static void Main()
        {
            const int trainCount = 5;
            Train[] trains = new Train[trainCount];

            // Введення даних
            for (int i = 0; i < trainCount; i++)
            {
                Console.WriteLine($"Введіть інформацію про поїзд {i + 1}:");
                Console.Write("Пункт призначення: ");
                string destination = Console.ReadLine();

                Console.Write("Номер поїзду: ");
                int trainNumber = int.Parse(Console.ReadLine());

                Console.Write("Час прибуття (гг:хх): ");
                TimeSpan departureTime = TimeSpan.Parse(Console.ReadLine());

                trains[i] = new Train(destination, trainNumber, departureTime);
            }

            // Сортування поїздів за номерами
            Array.Sort(trains, (t1, t2) => t1.TrainNumber.CompareTo(t2.TrainNumber));

            // Пошук поїзда за номером
            Console.Write("Введіть номер потягу для пошуку: ");
            int searchNumber = int.Parse(Console.ReadLine());

            var foundTrain = trains.FirstOrDefault(t => t.TrainNumber == searchNumber);

            if (foundTrain.TrainNumber != 0)
            {
                Console.WriteLine("Знайдений потяг: ");
                Console.WriteLine(foundTrain);
            }
            else
            {
                Console.WriteLine("Не знайдено потяг за введеним номером.");
            }

            Console.WriteLine("Натисніть ентер для знищення...");
            Console.ReadKey();
        }
    }
}


