using System.ComponentModel;
using System.Text;
using System.Windows.Forms.DataVisualization.Charting;
using Tyuiu.NikitinRYu.Sprint7.Task0.V8.Lib;


namespace Tyuiu.NikitinRYu.Sprint7.Task0.V8
{
    public partial class MainForm : Form
    {
        private readonly DataService dataService = new DataService();

        private BindingList<Car_NRY> cars;
        private const string CarsPath = @"C:\DataSprint7\cars.csv";

        private BindingList<Driver_NRY> drivers;
        private const string DriversPath = @"C:\DataSprint7\drivers.csv";

        private BindingList<Trip_NRY> trips;
        private const string TripsPath = @"C:\DataSprint7\trips.csv";

        public MainForm()
        {
            InitializeComponent();
            this.Load += MainForm_Load;
        }

        private void buttonAddCar_NRY_Click(object sender, EventArgs e)
        {
            var form = new FormCarEdit_NRY();
            if (form.ShowDialog() == DialogResult.OK)
            {
                // Генерация нового ID
                int newId = cars.Count > 0 ? cars.Max(c => c.Id) + 1 : 1;
                form.Car.Id = newId;

                cars.Add(form.Car);
                dataService.SaveCars(cars.ToList(), CarsPath);
                UpdateCarsCount();
                dataGridViewCars_NRY.DataSource = null;
                dataGridViewCars_NRY.DataSource = cars;
            }
        }

        private void buttonEditCar_NRY_Click(object sender, EventArgs e)
        {
            if (dataGridViewCars_NRY.CurrentRow == null) return;

            var selectedCar = dataGridViewCars_NRY.CurrentRow.DataBoundItem as Car_NRY;
            var form = new FormCarEdit_NRY(selectedCar);
            if (form.ShowDialog() == DialogResult.OK)
            {
                // Обновление данных автоматически, т.к. BindingList
                dataService.SaveCars(cars.ToList(), CarsPath);
                dataGridViewCars_NRY.Refresh();
            }
        }

        private void buttonDeleteCar_NRY_Click(object sender, EventArgs e)
        {
            if (dataGridViewCars_NRY.CurrentRow == null)
                return;

            var selectedCar = dataGridViewCars_NRY.CurrentRow.DataBoundItem as Car_NRY;
            if (selectedCar == null)
                return;

            var confirm = MessageBox.Show($"Удалить автомобиль {selectedCar.LicensePlate}?",
                                          "Подтверждение",
                                          MessageBoxButtons.YesNo,
                                          MessageBoxIcon.Question);

            if (confirm == DialogResult.Yes)
            {
                cars.Remove(selectedCar);
                dataService.SaveCars(cars.ToList(), CarsPath);
                UpdateCarsCount();
            }
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            var list = dataService.LoadCars(CarsPath);
            cars = new BindingList<Car_NRY>(list);

            dataGridViewCars_NRY.AutoGenerateColumns = true;
            dataGridViewCars_NRY.DataSource = cars;
            dataGridViewCars_NRY.Columns["Id"].HeaderText = "ID";
            dataGridViewCars_NRY.Columns["LicensePlate"].HeaderText = "Гос. номер";
            dataGridViewCars_NRY.Columns["Brand"].HeaderText = "Марка";
            dataGridViewCars_NRY.Columns["Condition"].HeaderText = "Состояние";
            dataGridViewCars_NRY.Columns["Location"].HeaderText = "Местоположение";
            dataGridViewCars_NRY.Columns["AvgSpeed"].HeaderText = "Ср. скорость";
            dataGridViewCars_NRY.Columns["LoadCapacity"].HeaderText = "Грузоподъемность";
            dataGridViewCars_NRY.Columns["FuelConsumption"].HeaderText = "Расход топлива";

            dataGridViewCars_NRY.Columns["Id"].Visible = false; // ID скрываем

            UpdateCarsCount();

            // Загрузка водителей
            var driverList = dataService.LoadDrivers(DriversPath);
            drivers = new BindingList<Driver_NRY>(driverList);

            dataGridViewDrivers_NRY.AutoGenerateColumns = true;
            dataGridViewDrivers_NRY.DataSource = drivers;

            // Настройка заголовков столбцов
            dataGridViewDrivers_NRY.Columns["Id"].HeaderText = "ID";
            dataGridViewDrivers_NRY.Columns["LastName"].HeaderText = "Фамилия";
            dataGridViewDrivers_NRY.Columns["FirstName"].HeaderText = "Имя";
            dataGridViewDrivers_NRY.Columns["MiddleName"].HeaderText = "Отчество";
            dataGridViewDrivers_NRY.Columns["BirthDate"].HeaderText = "Дата рождения";
            dataGridViewDrivers_NRY.Columns["Experience"].HeaderText = "Стаж";
            dataGridViewDrivers_NRY.Columns["Salary"].HeaderText = "Оклад";

            dataGridViewDrivers_NRY.Columns["Id"].Visible = false; // ID скрываем

            UpdateDriversCount();

            var triplist = dataService.LoadTrips(TripsPath);
            trips = new BindingList<Trip_NRY>(triplist);

            dataGridViewTrips_NRY.AutoGenerateColumns = true;
            dataGridViewTrips_NRY.DataSource = trips;

            dataGridViewTrips_NRY.Columns["Id"].HeaderText = "ID";
            dataGridViewTrips_NRY.Columns["CarId"].HeaderText = "Автомобиль ID";
            dataGridViewTrips_NRY.Columns["DriverId"].HeaderText = "Водитель ID";
            dataGridViewTrips_NRY.Columns["StartDate"].HeaderText = "Дата начала";
            dataGridViewTrips_NRY.Columns["EndDate"].HeaderText = "Дата окончания";
            dataGridViewTrips_NRY.Columns["Destination"].HeaderText = "Пункт назначения";
            dataGridViewTrips_NRY.Columns["Distance"].HeaderText = "Расстояние";
            dataGridViewTrips_NRY.Columns["FuelUsed"].HeaderText = "Расход топлива";
            dataGridViewTrips_NRY.Columns["CargoWeight"].HeaderText = "Масса груза";

            dataGridViewTrips_NRY.Columns["Id"].Visible = false; // скрываем ID

            UpdateTripsCount();

            InitializeSortTab();
            LoadSortTab();

            // MainForm_Load
            textBoxSearch_NRY.KeyDown += textBoxSearch_NRY_KeyDown;

            comboBoxChartType_NRY.Items.Clear();
            comboBoxChartType_NRY.Items.AddRange(new string[] { "Гистограмма", "Круговая", "Линейная" });
            comboBoxChartType_NRY.SelectedIndex = 0; // По умолчанию

            comboBoxChartSource_NRY.Items.Clear();
            comboBoxChartSource_NRY.Items.AddRange(new string[] { "Автомобили", "Водители", "Маршруты" });
            comboBoxChartSource_NRY.SelectedIndex = 0; // Автомобили по умолчанию
        }

        private void UpdateCarsCount()
        {
            labelCarsCount_NRY.Text = $"Количество: {cars.Count}";
        }

        private void UpdateDriversCount()
        {
            labelDriversCount_NRY.Text = $"Количество: {drivers.Count}";
        }

        private void UpdateTripsCount()
        {
            labelTripsCount_NRY.Text = $"Количество: {trips.Count}";
        }

        private void InitializeSortTab()
        {
            comboBoxSearchField_NRY.Items.Clear();
            comboBoxSearchField_NRY.Items.AddRange(new string[]
            {
                "По расстоянию (убыв.)",
                "По расстоянию (возр.)",
                "По расходу топлива (убыв.)",
                "По расходу топлива (возр.)",
                "По массе груза (убыв.)",
                "По массе груза (возр.)",
                "По длительности маршрута (дней) (убыв.)",
                "По длительности маршрута (дней) (возр.)"
            });
            comboBoxSearchField_NRY.SelectedIndex = 0; // По умолчанию
        }

        private void LoadSortTab()
        {
            var tripList = dataService.LoadTrips(TripsPath);
            trips = new BindingList<Trip_NRY>(tripList);

            dataGridViewSearchResults_NRY.AutoGenerateColumns = true;
            dataGridViewSearchResults_NRY.DataSource = trips;

            // Настройка отображения (ID скрываем, авто и водителя выводим красиво)
            dataGridViewSearchResults_NRY.Columns["Id"].Visible = false;
            dataGridViewSearchResults_NRY.Columns["CarId"].Visible = false;
            dataGridViewSearchResults_NRY.Columns["DriverId"].Visible = false;

            dataGridViewSearchResults_NRY.Columns["StartDate"].HeaderText = "Дата начала";
            dataGridViewSearchResults_NRY.Columns["EndDate"].HeaderText = "Дата окончания";
            dataGridViewSearchResults_NRY.Columns["Destination"].HeaderText = "Пункт назначения";
            dataGridViewSearchResults_NRY.Columns["Distance"].HeaderText = "Расстояние (км)";
            dataGridViewSearchResults_NRY.Columns["FuelUsed"].HeaderText = "Расход топлива (л)";
            dataGridViewSearchResults_NRY.Columns["CargoWeight"].HeaderText = "Масса груза (кг)";
            dataGridViewSearchResults_NRY.Columns["DurationDays"].HeaderText = "Длительность (дн.)";
        }

        private void UpdateStats()
        {
            UpdateCarStats();
            UpdateDriverStats();
            UpdateTripStats();
        }

        private void UpdateCarStats()
        {
            if (cars == null || cars.Count == 0)
            {
                textBoxCarStats_NRY.Text = "Данные об автомобилях отсутствуют.";
                return;
            }

            int totalCars = cars.Count;
            int goodCars = cars.Count(c => !string.IsNullOrEmpty(c.Condition) &&
                                           (c.Condition.Trim() == "Отличное" ||
                                            c.Condition.Trim() == "Хорошее" ||
                                            c.Condition.Trim() == "Удовлетворительное"));
            int badCars = totalCars - goodCars;

            double avgLoadCapacity = cars.Average(c => c.LoadCapacity);
            double avgFuelConsumption = cars.Average(c => c.FuelConsumption);

            textBoxCarStats_NRY.Text = $"Всего автомобилей: {totalCars}{Environment.NewLine}" +
                                       $"Исправные: {goodCars}{Environment.NewLine}" +
                                       $"Неисправные: {badCars}{Environment.NewLine}" +
                                       $"Средняя грузоподъемность: {avgLoadCapacity:F2} кг{Environment.NewLine}" +
                                       $"Средний расход топлива: {avgFuelConsumption:F2} л/100 км";
        }

        private void UpdateDriverStats()
        {
            if (drivers == null || drivers.Count == 0)
            {
                textBoxDriverStats_NRY.Text = "Нет данных";
                return;
            }

            int total = drivers.Count;
            double avgExp = drivers.Average(d => d.Experience);
            double avgTrips = total > 0 ? trips.Count / (double)total : 0;

            textBoxDriverStats_NRY.Text =
                $"Общее количество водителей: {total}\r\n" +
                $"Средний стаж: {avgExp:F1} лет\r\n" +
                $"Среднее количество маршрутов на водителя: {avgTrips:F1}";
        }

        private void UpdateTripStats()
        {
            if (trips == null || trips.Count == 0)
            {
                textBoxTripStats_NRY.Text = "Нет данных";
                return;
            }

            int total = trips.Count;
            double sumDistance = trips.Sum(t => t.Distance);
            double sumCargo = trips.Sum(t => t.CargoWeight);
            double avgDuration = trips.Average(t => t.DurationDays);

            textBoxTripStats_NRY.Text =
                $"Общее количество маршрутов: {total}\r\n" +
                $"Суммарная дистанция: {sumDistance:F0} км\r\n" +
                $"Суммарная масса груза: {sumCargo:F0} кг\r\n" +
                $"Средняя длительность маршрута: {avgDuration:F1} дней";
        }

        private void buttonAddDriver_NRY_Click(object sender, EventArgs e)
        {
            var form = new FormDriverEdit_NRY();
            if (form.ShowDialog() == DialogResult.OK)
            {
                // Генерация нового ID
                int newId = drivers.Count > 0 ? drivers.Max(d => d.Id) + 1 : 1;
                form.Driver.Id = newId;

                drivers.Add(form.Driver);
                dataService.SaveDrivers(drivers.ToList(), DriversPath);
                UpdateDriversCount();
                dataGridViewDrivers_NRY.DataSource = null;
                dataGridViewDrivers_NRY.DataSource = drivers;
            }
        }

        private void buttonEditDriver_NRY_Click(object sender, EventArgs e)
        {
            if (dataGridViewDrivers_NRY.CurrentRow == null) return;

            var selectedDriver = dataGridViewDrivers_NRY.CurrentRow.DataBoundItem as Driver_NRY;
            var form = new FormDriverEdit_NRY(selectedDriver);
            if (form.ShowDialog() == DialogResult.OK)
            {
                // Обновление данных автоматически, т.к. BindingList
                dataService.SaveDrivers(drivers.ToList(), DriversPath);
                dataGridViewDrivers_NRY.Refresh();
            }
        }

        private void buttonDeleteDriver_NRY_Click(object sender, EventArgs e)
        {
            if (dataGridViewDrivers_NRY.CurrentRow == null) return;

            var selectedDriver = dataGridViewDrivers_NRY.CurrentRow.DataBoundItem as Driver_NRY;
            if (selectedDriver == null) return;

            var confirm = MessageBox.Show($"Удалить водителя {selectedDriver.LastName} {selectedDriver.FirstName}?",
                                          "Подтверждение",
                                          MessageBoxButtons.YesNo,
                                          MessageBoxIcon.Question);

            if (confirm == DialogResult.Yes)
            {
                drivers.Remove(selectedDriver);
                dataService.SaveDrivers(drivers.ToList(), DriversPath);
                UpdateDriversCount();
            }
        }

        private void buttonAddTrip_NRY_Click(object sender, EventArgs e)
        {
            var form = new FormTripEdit_NRY(cars.ToList(), drivers.ToList());
            if (form.ShowDialog() == DialogResult.OK)
            {
                int newId = trips.Count > 0 ? trips.Max(t => t.Id) + 1 : 1;
                form.Trip.Id = newId;

                trips.Add(form.Trip);
                dataService.SaveTrips(trips.ToList(), TripsPath);
                dataGridViewTrips_NRY.DataSource = null;
                dataGridViewTrips_NRY.DataSource = trips;
            }
        }

        private void buttonEditTrip_NRY_Click(object sender, EventArgs e)
        {
            if (dataGridViewTrips_NRY.CurrentRow == null) return;

            var selectedTrip = dataGridViewTrips_NRY.CurrentRow.DataBoundItem as Trip_NRY;
            if (selectedTrip == null) return;

            var form = new FormTripEdit_NRY(selectedTrip, cars.ToList(), drivers.ToList());
            if (form.ShowDialog() == DialogResult.OK)
            {
                dataService.SaveTrips(trips.ToList(), TripsPath);
                dataGridViewTrips_NRY.Refresh();
            }
        }

        private void buttonDeleteTrip_NRY_Click(object sender, EventArgs e)
        {
            if (dataGridViewTrips_NRY.CurrentRow == null) return;

            var selectedTrip = dataGridViewTrips_NRY.CurrentRow.DataBoundItem as Trip_NRY;
            if (selectedTrip == null) return;

            var confirm = MessageBox.Show($"Удалить маршрут в пункт {selectedTrip.Destination}?",
                                          "Подтверждение",
                                          MessageBoxButtons.YesNo,
                                          MessageBoxIcon.Question);

            if (confirm == DialogResult.Yes)
            {
                trips.Remove(selectedTrip);
                dataService.SaveTrips(trips.ToList(), TripsPath);
            }
        }

        private void buttonSearch_NRY_Click(object sender, EventArgs e)
        {
            string query = textBoxSearch_NRY.Text.Trim().ToLower();

            // Если текст пустой, берем весь список trips, иначе фильтруем
            var filtered = string.IsNullOrWhiteSpace(query)
                ? trips.ToList()
                : trips.Where(t => t.Destination.ToLower().Contains(query)).ToList();

            // Получаем выбранный критерий сортировки
            string sortField = comboBoxSearchField_NRY.SelectedItem?.ToString() ?? "";

            switch (sortField)
            {
                case "По расстоянию (убыв.)":
                    filtered = filtered.OrderByDescending(t => t.Distance).ToList();
                    break;
                case "По расстоянию (возр.)":
                    filtered = filtered.OrderBy(t => t.Distance).ToList();
                    break;
                case "По расходу топлива (убыв.)":
                    filtered = filtered.OrderByDescending(t => t.FuelUsed).ToList();
                    break;
                case "По расходу топлива (возр.)":
                    filtered = filtered.OrderBy(t => t.FuelUsed).ToList();
                    break;
                case "По массе груза (убыв.)":
                    filtered = filtered.OrderByDescending(t => t.CargoWeight).ToList();
                    break;
                case "По массе груза (возр.)":
                    filtered = filtered.OrderBy(t => t.CargoWeight).ToList();
                    break;
                case "По длительности маршрута (дней) (убыв.)":
                    filtered = filtered.OrderByDescending(t => t.DurationDays).ToList();
                    break;
                case "По длительности маршрута (дней) (возр.)":
                    filtered = filtered.OrderBy(t => t.DurationDays).ToList();
                    break;
            }

            dataGridViewSearchResults_NRY.DataSource = new BindingList<Trip_NRY>(filtered);

            // ===== Добавляем обновление labelSearchResults_NRY =====
            labelSearchResults_NRY.Text = $"Найдено маршрутов: {filtered.Count}";
        }

        private void buttonResetSearch_NRY_Click(object sender, EventArgs e)
        {
            textBoxSearch_NRY.Text = "";
            comboBoxSearchField_NRY.SelectedIndex = 0;
            dataGridViewSearchResults_NRY.DataSource = trips;
        }

        private void textBoxSearch_NRY_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.Handled = true; // предотвращаем "дзыньк" в TextBox
                e.SuppressKeyPress = true; // подавляем звуковой сигнал
                buttonSearch_NRY.PerformClick(); // вызываем клик кнопки поиска
            }
        }

        private void buttonRefreshStats_NRY_Click(object sender, EventArgs e)
        {
            UpdateStats();
        }

        private void buttonExportStats_NRY_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog sfd = new SaveFileDialog())
            {
                sfd.Filter = "Текстовый файл (*.txt)|*.txt";
                sfd.FileName = "Статистика.txt";
                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    var sb = new StringBuilder();
                    sb.AppendLine("=== Автомобили ===");
                    sb.AppendLine(textBoxCarStats_NRY.Text);
                    sb.AppendLine();
                    sb.AppendLine("=== Водители ===");
                    sb.AppendLine(textBoxDriverStats_NRY.Text);
                    sb.AppendLine();
                    sb.AppendLine("=== Маршруты ===");
                    sb.AppendLine(textBoxTripStats_NRY.Text);

                    File.WriteAllText(sfd.FileName, sb.ToString(), Encoding.UTF8);
                    MessageBox.Show("Статистика сохранена!", "Готово", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void buttonBuildChart_NRY_Click(object sender, EventArgs e)
        {
            chartStats_NRY.Series.Clear();
            chartStats_NRY.Titles.Clear();

            string chartTypeText = comboBoxChartType_NRY.SelectedItem?.ToString() ?? "Гистограмма";
            string source = comboBoxChartSource_NRY.SelectedItem?.ToString() ?? "Автомобили";

            var series = new System.Windows.Forms.DataVisualization.Charting.Series
            {
                ChartType = chartTypeText switch
                {
                    "Гистограмма" => System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Column,
                    "Круговая" => System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie,
                    "Линейная" => System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line,
                    _ => System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Column
                },
                IsValueShownAsLabel = true,
                IsXValueIndexed = true,
                XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.String
            };

            // ===== АВТОМОБИЛИ =====
            if (source == "Автомобили")
            {
                series.Name = "Состояние автомобилей";

                int goodCars = cars.Count(c =>
                    c.Condition == "Отличное" ||
                    c.Condition == "Хорошее" ||
                    c.Condition == "Удовлетворительное");

                int brokenCars = cars.Count(c => c.Condition == "Неисправен");

                series.Points.AddXY("Исправные", goodCars);
                series.Points.AddXY("Неисправные", brokenCars);

                chartStats_NRY.Titles.Add("Состояние автомобилей");
            }

            // ===== ВОДИТЕЛИ =====
            else if (source == "Водители")
            {
                series.Name = "Распределение по стажу";

                var groups = drivers.GroupBy(d =>
                {
                    if (d.Experience < 5) return "< 5 лет";
                    if (d.Experience <= 10) return "5–10 лет";
                    return "> 10 лет";
                });

                foreach (var g in groups)
                    series.Points.AddXY(g.Key, g.Count());

                chartStats_NRY.Titles.Add("Распределение водителей по стажу");
            }

            // ===== МАРШРУТЫ =====
            else if (source == "Маршруты")
            {
                series.Name = "Топ маршрутов по расстоянию";

                var topTrips = trips
                    .OrderByDescending(t => t.Distance)
                    .Take(5);

                foreach (var trip in topTrips)
                    series.Points.AddXY(trip.Destination, trip.Distance);

                chartStats_NRY.Titles.Add("Топ-5 маршрутов по расстоянию");
            }

            chartStats_NRY.Series.Add(series);
            chartStats_NRY.Invalidate();
        }
    }
}
