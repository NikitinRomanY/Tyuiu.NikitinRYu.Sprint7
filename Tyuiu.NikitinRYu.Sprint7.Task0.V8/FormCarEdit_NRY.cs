using Tyuiu.NikitinRYu.Sprint7.Task0.V8.Lib;

namespace Tyuiu.NikitinRYu.Sprint7.Task0.V8
{
    public partial class FormCarEdit_NRY : Form
    {
        public Car_NRY Car { get; private set; }
        public FormCarEdit_NRY()
        {
            InitializeComponent();
            comboBoxCondition_NRY.Items.AddRange(new string[] { "Отличное", "Хорошее", "Удовлетворительное", "Неисправен" });
            comboBoxCondition_NRY.SelectedIndex = 0; // по умолчанию
            Car = new Car_NRY();
            // Подписка на кнопки
            buttonOK_NRY.Click += buttonOK_NRY_Click;
            buttonCancel_NRY.Click += buttonCancel_NRY_Click;
        }

        public FormCarEdit_NRY(Car_NRY car) : this()
        {
            Car = car;
            textBoxLicensePlate_NRY.Text = car.LicensePlate;
            textBoxBrand_NRY.Text = car.Brand;
            comboBoxCondition_NRY.SelectedItem = car.Condition;
            textBoxLocation_NRY.Text = car.Location;
            numericUpDownSpeed_NRY.Value = car.AvgSpeed;
            numericUpDownCapacity_NRY.Value = car.LoadCapacity;
            numericUpDownFuel_NRY.Value = (decimal)car.FuelConsumption;
        }


        private void buttonOK_NRY_Click(object sender, EventArgs e)
        {
            // Проверка заполнения всех полей
            if (string.IsNullOrWhiteSpace(textBoxLicensePlate_NRY.Text) ||
                string.IsNullOrWhiteSpace(textBoxBrand_NRY.Text) ||
                string.IsNullOrWhiteSpace(textBoxLocation_NRY.Text) ||
                comboBoxCondition_NRY.SelectedItem == null)
            {
                MessageBox.Show("Заполните все поля!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Создаем или обновляем автомобиль
            if (Car == null)
                Car = new Car_NRY();

            Car.LicensePlate = textBoxLicensePlate_NRY.Text;
            Car.Brand = textBoxBrand_NRY.Text;
            Car.Condition = comboBoxCondition_NRY.SelectedItem.ToString();
            Car.Location = textBoxLocation_NRY.Text;
            Car.AvgSpeed = (int)numericUpDownSpeed_NRY.Value;
            Car.LoadCapacity = (int)numericUpDownCapacity_NRY.Value;
            Car.FuelConsumption = (double)numericUpDownFuel_NRY.Value;

            DialogResult = DialogResult.OK;
        }

        private void buttonCancel_NRY_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

    }
}
