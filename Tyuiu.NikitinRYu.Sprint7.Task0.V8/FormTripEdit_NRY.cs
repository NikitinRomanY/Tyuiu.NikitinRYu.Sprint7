using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tyuiu.NikitinRYu.Sprint7.Task0.V8.Lib;

namespace Tyuiu.NikitinRYu.Sprint7.Task0.V8
{
    public partial class FormTripEdit_NRY : Form
    {
        public Trip_NRY Trip { get; private set; }
        public FormTripEdit_NRY(List<Car_NRY> cars, List<Driver_NRY> drivers)
        {
            InitializeComponent();

            // Инициализация пустого объекта
            Trip = new Trip_NRY();

            // Заполнение комбобоксов
            comboBoxCar_NRY.DataSource = cars;
            comboBoxCar_NRY.DisplayMember = "LicensePlate"; // отображать гос. номер
            comboBoxCar_NRY.ValueMember = "Id";

            comboBoxDriver_NRY.DataSource = drivers;
            comboBoxDriver_NRY.DisplayMember = "LastName"; // отображать фамилию
            comboBoxDriver_NRY.ValueMember = "Id";

            // Подписка на кнопки
            buttonOK_NRY.Click += buttonOK_NRY_Click;
            buttonCancel_NRY.Click += buttonCancel_NRY_Click;
        }

        public FormTripEdit_NRY(Trip_NRY trip, List<Car_NRY> cars, List<Driver_NRY> drivers) : this(cars, drivers)
        {
            Trip = trip;

            // Заполнение полей
            comboBoxCar_NRY.SelectedItem = cars.FirstOrDefault(c => c.Id == trip.CarId);
            comboBoxDriver_NRY.SelectedItem = drivers.FirstOrDefault(d => d.Id == trip.DriverId);

            dateTimePickerStartDate_NRY.Value = trip.StartDate;
            dateTimePickerEndDate_NRY.Value = trip.EndDate;
            textBoxDestination_NRY.Text = trip.Destination;
            numericUpDownDistance_NRY.Value = trip.Distance;
            numericUpDownFuelUsed_NRY.Value = (decimal)trip.FuelUsed;
            numericUpDownCargoWeight_NRY.Value = (decimal)trip.CargoWeight;
        }

        private void buttonOK_NRY_Click(object sender, EventArgs e)
        {
            // Проверка заполнения всех полей
            if (comboBoxCar_NRY.SelectedItem == null ||
                comboBoxDriver_NRY.SelectedItem == null ||
                string.IsNullOrWhiteSpace(textBoxDestination_NRY.Text) ||
                dateTimePickerEndDate_NRY.Value < dateTimePickerStartDate_NRY.Value)
            {
                MessageBox.Show("Заполните все поля корректно!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (Trip == null)
                Trip = new Trip_NRY();

            Trip.CarId = ((Car_NRY)comboBoxCar_NRY.SelectedItem).Id;
            Trip.DriverId = ((Driver_NRY)comboBoxDriver_NRY.SelectedItem).Id;
            Trip.StartDate = dateTimePickerStartDate_NRY.Value;
            Trip.EndDate = dateTimePickerEndDate_NRY.Value;
            Trip.Destination = textBoxDestination_NRY.Text;
            Trip.Distance = (int)numericUpDownDistance_NRY.Value;
            Trip.FuelUsed = (double)numericUpDownFuelUsed_NRY.Value;
            Trip.CargoWeight = (double)numericUpDownCargoWeight_NRY.Value;

            DialogResult = DialogResult.OK;
        }

        private void buttonCancel_NRY_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }
    }
}
