using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyuiu.NikitinRYu.Sprint7.Task0.V8.Lib;
using System.IO;

namespace Tyuiu.NikitinRYu.Sprint7.Task0.V8.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidLoadFromRealFiles_NRY()
        {
            // Тест загрузки реальных файлов
            var service = new DataService();
            string basePath = @"C:\DataSprint7\";

            var cars = service.LoadCars(Path.Combine(basePath, "cars.csv"));
            var drivers = service.LoadDrivers(Path.Combine(basePath, "drivers.csv"));
            var trips = service.LoadTrips(Path.Combine(basePath, "trips.csv"));

            Assert.IsNotNull(cars);
            Assert.IsNotNull(drivers);
            Assert.IsNotNull(trips);

            Assert.AreEqual(4, cars.Count);
            Assert.AreEqual(4, drivers.Count);
            Assert.AreEqual(4, trips.Count);
        }

        [TestMethod]
        public void ValidSearchCars_NRY()
        {
            // Тест поиска
            var service = new DataService();
            string basePath = @"C:\DataSprint7\";
            var cars = service.LoadCars(Path.Combine(basePath, "cars.csv"));

            var foundCars = service.SearchCars(cars, "Volvo");

            Assert.AreEqual(1, foundCars.Count);
            Assert.AreEqual("В456ОР98", foundCars[0].LicensePlate);
        }

        [TestMethod]
        public void ValidCarStatistics_NRY()
        {
            // Тест статистики
            var service = new DataService();
            string basePath = @"C:\DataSprint7\";
            var cars = service.LoadCars(Path.Combine(basePath, "cars.csv"));

            var stats = service.GetCarStatistics(cars);

            Assert.AreEqual(4, stats["Количество"]);
            Assert.AreEqual(90, stats["Макс. скорость"]);
            Assert.AreEqual(75, stats["Мин. скорость"]);
            Assert.AreEqual(82.5, stats["Средняя скорость"]);
        }
    }
}
