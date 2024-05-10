using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task02
{
    public struct Train
    {
        public string Destination { get; set; }
        public int TrainNumber { get; set; }
        public TimeSpan DepartureTime { get; set; }

        public Train(string destination, int trainNumber, TimeSpan departureTime)
        {
            Destination = destination;
            TrainNumber = trainNumber;
            DepartureTime = departureTime;
        }

        public override string ToString()
        {
            return $"Поїзд №{TrainNumber} до {Destination} прибуває о {DepartureTime}";
        }
    }

}
