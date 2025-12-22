using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tyuiu.NikitinRYu.Sprint7.Task0.V8.Lib
{
    public class Car_NRY
    {
        public int Id { get; set; }
        public string LicensePlate { get; set; }          // Номерной знак
        public string Brand { get; set; }                 // Марка
        public string Condition { get; set; }             // Техническое состояние
        public string Location { get; set; }              // Местонахождение
        public int AvgSpeed { get; set; }                 // Средняя скорость (км/ч)
        public int LoadCapacity { get; set; }             // Грузоподъёмность (кг)
        public double FuelConsumption { get; set; }       // Расход топлива (л/100км)

        public override string ToString()
        {
            return $"{LicensePlate} - {Brand}";
        }
    }
}
