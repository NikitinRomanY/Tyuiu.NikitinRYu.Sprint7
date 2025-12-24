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

            Assert.AreEqual(20, cars.Count);
            Assert.AreEqual(15, drivers.Count);
            Assert.AreEqual(50, trips.Count);
        }
    }
}
