using System.Globalization;

namespace Tyuiu.NikitinRYu.Sprint7.Task0.V8.Lib
{
    public class DataService
    {
        private readonly string _dateFormat = "yyyy-MM-dd";

        // ===== ЗАГРУЗКА ДАННЫХ =====
        public List<Car_NRY> LoadCars(string path)
        {
            var cars = new List<Car_NRY>();
            if (!File.Exists(path)) return cars;

            var lines = File.ReadAllLines(path);
            for (int i = 1; i < lines.Length; i++)
            {
                var values = lines[i].Split(',');
                if (values.Length >= 8)
                {
                    var car = new Car_NRY
                    {
                        Id = int.Parse(values[0]),
                        LicensePlate = values[1],
                        Brand = values[2],
                        Condition = values[3],
                        Location = values[4],
                        AvgSpeed = int.Parse(values[5]),
                        LoadCapacity = int.Parse(values[6]),
                        FuelConsumption = double.Parse(values[7], CultureInfo.InvariantCulture)
                    };
                    cars.Add(car);
                }
            }
            return cars;
        }

        public List<Driver_NRY> LoadDrivers(string path)
        {
            var drivers = new List<Driver_NRY>();
            if (!File.Exists(path)) return drivers;

            var lines = File.ReadAllLines(path);
            for (int i = 1; i < lines.Length; i++)
            {
                var values = lines[i].Split(',');
                if (values.Length >= 7)
                {
                    var driver = new Driver_NRY
                    {
                        Id = int.Parse(values[0]),
                        LastName = values[1],
                        FirstName = values[2],
                        MiddleName = values[3],
                        BirthDate = DateTime.ParseExact(values[4], _dateFormat, CultureInfo.InvariantCulture),
                        Experience = int.Parse(values[5]),
                        Salary = decimal.Parse(values[6], CultureInfo.InvariantCulture)
                    };
                    drivers.Add(driver);
                }
            }
            return drivers;
        }

        public List<Trip_NRY> LoadTrips(string path)
        {
            var trips = new List<Trip_NRY>();
            if (!File.Exists(path)) return trips;

            var lines = File.ReadAllLines(path);
            for (int i = 1; i < lines.Length; i++)
            {
                var values = lines[i].Split(',');
                if (values.Length >= 9)
                {
                    var trip = new Trip_NRY
                    {
                        Id = int.Parse(values[0]),
                        CarId = int.Parse(values[1]),
                        DriverId = int.Parse(values[2]),
                        StartDate = DateTime.ParseExact(values[3], _dateFormat, CultureInfo.InvariantCulture),
                        EndDate = DateTime.ParseExact(values[4], _dateFormat, CultureInfo.InvariantCulture),
                        Destination = values[5],
                        Distance = int.Parse(values[6]),
                        FuelUsed = double.Parse(values[7], CultureInfo.InvariantCulture),
                        CargoWeight = double.Parse(values[8], CultureInfo.InvariantCulture)
                    };
                    trips.Add(trip);
                }
            }
            return trips;
        }

        // ===== СОХРАНЕНИЕ ДАННЫХ =====
        public void SaveCars(List<Car_NRY> cars, string path)
        {
            var lines = new List<string> { "Id,LicensePlate,Brand,Condition,Location,AvgSpeed,LoadCapacity,FuelConsumption" };
            foreach (var car in cars)
            {
                lines.Add($"{car.Id},{car.LicensePlate},{car.Brand},{car.Condition},{car.Location}," +
                         $"{car.AvgSpeed},{car.LoadCapacity},{car.FuelConsumption.ToString(CultureInfo.InvariantCulture)}");
            }
            File.WriteAllLines(path, lines);
        }

        public void SaveDrivers(List<Driver_NRY> drivers, string path)
        {
            var lines = new List<string> { "Id,LastName,FirstName,MiddleName,BirthDate,Experience,Salary" };
            foreach (var driver in drivers)
            {
                lines.Add($"{driver.Id},{driver.LastName},{driver.FirstName},{driver.MiddleName}," +
                         $"{driver.BirthDate.ToString(_dateFormat)},{driver.Experience},{driver.Salary.ToString(CultureInfo.InvariantCulture)}");
            }
            File.WriteAllLines(path, lines);
        }

        public void SaveTrips(List<Trip_NRY> trips, string path)
        {
            var lines = new List<string> { "Id,CarId,DriverId,StartDate,EndDate,Destination,Distance,FuelUsed,CargoWeight" };
            foreach (var trip in trips)
            {
                lines.Add($"{trip.Id},{trip.CarId},{trip.DriverId}," +
                         $"{trip.StartDate.ToString(_dateFormat)},{trip.EndDate.ToString(_dateFormat)}," +
                         $"{trip.Destination},{trip.Distance},{trip.FuelUsed.ToString(CultureInfo.InvariantCulture)}," +
                         $"{trip.CargoWeight.ToString(CultureInfo.InvariantCulture)}");
            }
            File.WriteAllLines(path, lines);
        }

        // ===== ПОИСК И ФИЛЬТРАЦИЯ =====
        public List<Car_NRY> SearchCars(List<Car_NRY> cars, string searchText)
        {
            if (string.IsNullOrWhiteSpace(searchText)) return cars;
            return cars.Where(c =>
                c.LicensePlate.Contains(searchText, StringComparison.OrdinalIgnoreCase) ||
                c.Brand.Contains(searchText, StringComparison.OrdinalIgnoreCase) ||
                c.Location.Contains(searchText, StringComparison.OrdinalIgnoreCase) ||
                c.Condition.Contains(searchText, StringComparison.OrdinalIgnoreCase)
            ).ToList();
        }

        public List<Driver_NRY> SearchDrivers(List<Driver_NRY> drivers, string searchText)
        {
            if (string.IsNullOrWhiteSpace(searchText)) return drivers;
            return drivers.Where(d =>
                d.LastName.Contains(searchText, StringComparison.OrdinalIgnoreCase) ||
                d.FirstName.Contains(searchText, StringComparison.OrdinalIgnoreCase) ||
                d.MiddleName.Contains(searchText, StringComparison.OrdinalIgnoreCase)
            ).ToList();
        }

        public List<Trip_NRY> SearchTrips(List<Trip_NRY> trips, string searchText)
        {
            if (string.IsNullOrWhiteSpace(searchText)) return trips;
            return trips.Where(t => t.Destination.Contains(searchText, StringComparison.OrdinalIgnoreCase)).ToList();
        }

        // ===== СТАТИСТИКА =====
        public Dictionary<string, object> GetCarStatistics(List<Car_NRY> cars)
        {
            if (cars == null || cars.Count == 0) return new Dictionary<string, object>();
            return new Dictionary<string, object>
            {
                ["Количество"] = cars.Count,
                ["Макс. скорость"] = cars.Max(c => c.AvgSpeed),
                ["Мин. скорость"] = cars.Min(c => c.AvgSpeed),
                ["Средняя скорость"] = cars.Average(c => c.AvgSpeed),
                ["Макс. грузоподъемность"] = cars.Max(c => c.LoadCapacity),
                ["Средний расход топлива"] = cars.Average(c => c.FuelConsumption)
            };
        }

        public Dictionary<string, object> GetDriverStatistics(List<Driver_NRY> drivers)
        {
            if (drivers == null || drivers.Count == 0) return new Dictionary<string, object>();
            var now = DateTime.Now;
            return new Dictionary<string, object>
            {
                ["Количество"] = drivers.Count,
                ["Средний стаж"] = drivers.Average(d => d.Experience),
                ["Макс. стаж"] = drivers.Max(d => d.Experience),
                ["Средний оклад"] = drivers.Average(d => d.Salary),
                ["Средний возраст"] = Math.Round(drivers.Average(d => (now - d.BirthDate).Days / 365.25), 1)
            };
        }

        public Dictionary<string, object> GetTripStatistics(List<Trip_NRY> trips)
        {
            if (trips == null || trips.Count == 0) return new Dictionary<string, object>();
            return new Dictionary<string, object>
            {
                ["Количество рейсов"] = trips.Count,
                ["Общее расстояние"] = trips.Sum(t => t.Distance),
                ["Среднее расстояние"] = trips.Average(t => t.Distance),
                ["Общий расход топлива"] = trips.Sum(t => t.FuelUsed),
                ["Общая масса грузов"] = trips.Sum(t => t.CargoWeight),
                ["Средняя длительность"] = trips.Average(t => t.DurationDays)
            };
        }
    }
}