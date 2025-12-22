using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tyuiu.NikitinRYu.Sprint7.Task0.V8.Lib
{
    public class Trip_NRY
    {
        public int Id { get; set; }
        public int CarId { get; set; }                    // ID автомобиля
        public int DriverId { get; set; }                 // ID водителя
        public DateTime StartDate { get; set; }           // Дата выезда
        public DateTime EndDate { get; set; }             // Дата прибытия
        public string Destination { get; set; }           // Место назначения
        public int Distance { get; set; }                 // Расстояние (км)
        public double FuelUsed { get; set; }              // Расход горючего (л)
        public double CargoWeight { get; set; }           // Масса груза (кг)

        public int DurationDays => (EndDate - StartDate).Days;

        public override string ToString()
        {
            return $"{StartDate:dd.MM.yyyy} → {Destination}";
        }
    }
}
