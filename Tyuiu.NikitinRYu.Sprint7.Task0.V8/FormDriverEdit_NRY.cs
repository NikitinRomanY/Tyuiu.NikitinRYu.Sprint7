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
    public partial class FormDriverEdit_NRY : Form
    {
        public Driver_NRY Driver { get; private set; }

        public FormDriverEdit_NRY()
        {
            InitializeComponent();

            // Инициализация пустого объекта
            Driver = new Driver_NRY();
            // Подписка на кнопки
            buttonOK_NRY.Click += buttonOK_NRY_Click;
            buttonCancel_NRY.Click += buttonCancel_NRY_Click;
        }

        public FormDriverEdit_NRY(Driver_NRY driver) : this()
        {
            Driver = driver;

            // Заполнение элементов управления
            textBoxLastName_NRY.Text = driver.LastName;
            textBoxFirstName_NRY.Text = driver.FirstName;
            textBoxMiddleName_NRY.Text = driver.MiddleName;
            dateTimePickerBirthDate_NRY.Value = driver.BirthDate;
            numericUpDownExperience_NRY.Value = driver.Experience;
            numericUpDownSalary_NRY.Value = driver.Salary;
        }

        private void buttonOK_NRY_Click(object sender, EventArgs e)
        {
            // Проверка обязательных полей
            if (string.IsNullOrWhiteSpace(textBoxLastName_NRY.Text) ||
                string.IsNullOrWhiteSpace(textBoxFirstName_NRY.Text) ||
                string.IsNullOrWhiteSpace(textBoxMiddleName_NRY.Text))
            {
                MessageBox.Show("Заполните все поля!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Создание/обновление объекта
            if (Driver == null)
                Driver = new Driver_NRY();

            Driver.LastName = textBoxLastName_NRY.Text;
            Driver.FirstName = textBoxFirstName_NRY.Text;
            Driver.MiddleName = textBoxMiddleName_NRY.Text;
            Driver.BirthDate = dateTimePickerBirthDate_NRY.Value;
            Driver.Experience = (int)numericUpDownExperience_NRY.Value;
            Driver.Salary = numericUpDownSalary_NRY.Value;

            DialogResult = DialogResult.OK;
        }

        private void buttonCancel_NRY_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }
    }
}
