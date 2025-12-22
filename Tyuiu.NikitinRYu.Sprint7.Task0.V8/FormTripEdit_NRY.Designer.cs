namespace Tyuiu.NikitinRYu.Sprint7.Task0.V8
{
    partial class FormTripEdit_NRY
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            dateTimePickerStartDate_NRY = new DateTimePicker();
            buttonCancel_NRY = new Button();
            buttonOK_NRY = new Button();
            numericUpDownFuelUsed_NRY = new NumericUpDown();
            numericUpDownDistance_NRY = new NumericUpDown();
            labelFuelUsed_NRY = new Label();
            labelDistance_NRY = new Label();
            textBoxDestination_NRY = new TextBox();
            labelStartDate_NRY = new Label();
            labelDestination_NRY = new Label();
            labelDriver_NRY = new Label();
            labelCar_NRY = new Label();
            comboBoxCar_NRY = new ComboBox();
            comboBoxDriver_NRY = new ComboBox();
            labelEndDate_NRY = new Label();
            dateTimePickerEndDate_NRY = new DateTimePicker();
            labelargoWeight_NRY = new Label();
            numericUpDownCargoWeight_NRY = new NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)numericUpDownFuelUsed_NRY).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownDistance_NRY).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownCargoWeight_NRY).BeginInit();
            SuspendLayout();
            // 
            // dateTimePickerStartDate_NRY
            // 
            dateTimePickerStartDate_NRY.Location = new Point(120, 77);
            dateTimePickerStartDate_NRY.Name = "dateTimePickerStartDate_NRY";
            dateTimePickerStartDate_NRY.Size = new Size(200, 23);
            dateTimePickerStartDate_NRY.TabIndex = 35;
            // 
            // buttonCancel_NRY
            // 
            buttonCancel_NRY.DialogResult = DialogResult.Cancel;
            buttonCancel_NRY.Location = new Point(168, 269);
            buttonCancel_NRY.Name = "buttonCancel_NRY";
            buttonCancel_NRY.Size = new Size(75, 30);
            buttonCancel_NRY.TabIndex = 33;
            buttonCancel_NRY.Text = "ОТМЕНА";
            buttonCancel_NRY.UseVisualStyleBackColor = true;
            buttonCancel_NRY.Click += buttonCancel_NRY_Click;
            // 
            // buttonOK_NRY
            // 
            buttonOK_NRY.DialogResult = DialogResult.OK;
            buttonOK_NRY.Location = new Point(88, 269);
            buttonOK_NRY.Name = "buttonOK_NRY";
            buttonOK_NRY.Size = new Size(75, 30);
            buttonOK_NRY.TabIndex = 34;
            buttonOK_NRY.Text = "ОК";
            buttonOK_NRY.UseVisualStyleBackColor = true;
            buttonOK_NRY.Click += buttonOK_NRY_Click;
            // 
            // numericUpDownFuelUsed_NRY
            // 
            numericUpDownFuelUsed_NRY.DecimalPlaces = 1;
            numericUpDownFuelUsed_NRY.Location = new Point(120, 197);
            numericUpDownFuelUsed_NRY.Maximum = new decimal(new int[] { 70, 0, 0, 0 });
            numericUpDownFuelUsed_NRY.Name = "numericUpDownFuelUsed_NRY";
            numericUpDownFuelUsed_NRY.Size = new Size(200, 23);
            numericUpDownFuelUsed_NRY.TabIndex = 31;
            numericUpDownFuelUsed_NRY.TextAlign = HorizontalAlignment.Center;
            numericUpDownFuelUsed_NRY.Value = new decimal(new int[] { 5, 0, 0, 0 });
            // 
            // numericUpDownDistance_NRY
            // 
            numericUpDownDistance_NRY.Location = new Point(120, 167);
            numericUpDownDistance_NRY.Maximum = new decimal(new int[] { 10000, 0, 0, 0 });
            numericUpDownDistance_NRY.Name = "numericUpDownDistance_NRY";
            numericUpDownDistance_NRY.Size = new Size(200, 23);
            numericUpDownDistance_NRY.TabIndex = 32;
            numericUpDownDistance_NRY.TextAlign = HorizontalAlignment.Center;
            numericUpDownDistance_NRY.Value = new decimal(new int[] { 10, 0, 0, 0 });
            // 
            // labelFuelUsed_NRY
            // 
            labelFuelUsed_NRY.AutoSize = true;
            labelFuelUsed_NRY.Location = new Point(12, 200);
            labelFuelUsed_NRY.Name = "labelFuelUsed_NRY";
            labelFuelUsed_NRY.Size = new Size(111, 15);
            labelFuelUsed_NRY.TabIndex = 22;
            labelFuelUsed_NRY.Text = "Расход топлива(л):";
            // 
            // labelDistance_NRY
            // 
            labelDistance_NRY.AutoSize = true;
            labelDistance_NRY.Location = new Point(12, 170);
            labelDistance_NRY.Name = "labelDistance_NRY";
            labelDistance_NRY.Size = new Size(99, 15);
            labelDistance_NRY.TabIndex = 23;
            labelDistance_NRY.Text = "Расстояние (км):";
            // 
            // textBoxDestination_NRY
            // 
            textBoxDestination_NRY.Location = new Point(120, 137);
            textBoxDestination_NRY.MaxLength = 100;
            textBoxDestination_NRY.Name = "textBoxDestination_NRY";
            textBoxDestination_NRY.Size = new Size(200, 23);
            textBoxDestination_NRY.TabIndex = 28;
            // 
            // labelStartDate_NRY
            // 
            labelStartDate_NRY.AutoSize = true;
            labelStartDate_NRY.Location = new Point(12, 80);
            labelStartDate_NRY.Name = "labelStartDate_NRY";
            labelStartDate_NRY.Size = new Size(77, 15);
            labelStartDate_NRY.TabIndex = 24;
            labelStartDate_NRY.Text = "Дата начала:";
            // 
            // labelDestination_NRY
            // 
            labelDestination_NRY.AutoSize = true;
            labelDestination_NRY.Location = new Point(12, 140);
            labelDestination_NRY.Name = "labelDestination_NRY";
            labelDestination_NRY.Size = new Size(110, 15);
            labelDestination_NRY.TabIndex = 25;
            labelDestination_NRY.Text = "Пункт назначения:";
            // 
            // labelDriver_NRY
            // 
            labelDriver_NRY.AutoSize = true;
            labelDriver_NRY.Location = new Point(12, 50);
            labelDriver_NRY.Name = "labelDriver_NRY";
            labelDriver_NRY.Size = new Size(61, 15);
            labelDriver_NRY.TabIndex = 26;
            labelDriver_NRY.Text = "Водитель:";
            // 
            // labelCar_NRY
            // 
            labelCar_NRY.AutoSize = true;
            labelCar_NRY.Location = new Point(12, 20);
            labelCar_NRY.Name = "labelCar_NRY";
            labelCar_NRY.Size = new Size(79, 15);
            labelCar_NRY.TabIndex = 27;
            labelCar_NRY.Text = "Автомобиль:";
            // 
            // comboBoxCar_NRY
            // 
            comboBoxCar_NRY.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxCar_NRY.FormattingEnabled = true;
            comboBoxCar_NRY.Location = new Point(120, 17);
            comboBoxCar_NRY.Name = "comboBoxCar_NRY";
            comboBoxCar_NRY.Size = new Size(202, 23);
            comboBoxCar_NRY.TabIndex = 36;
            // 
            // comboBoxDriver_NRY
            // 
            comboBoxDriver_NRY.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxDriver_NRY.FormattingEnabled = true;
            comboBoxDriver_NRY.Location = new Point(120, 47);
            comboBoxDriver_NRY.Name = "comboBoxDriver_NRY";
            comboBoxDriver_NRY.Size = new Size(202, 23);
            comboBoxDriver_NRY.TabIndex = 36;
            // 
            // labelEndDate_NRY
            // 
            labelEndDate_NRY.AutoSize = true;
            labelEndDate_NRY.Location = new Point(13, 110);
            labelEndDate_NRY.Name = "labelEndDate_NRY";
            labelEndDate_NRY.Size = new Size(98, 15);
            labelEndDate_NRY.TabIndex = 24;
            labelEndDate_NRY.Text = "Дата окончания:";
            // 
            // dateTimePickerEndDate_NRY
            // 
            dateTimePickerEndDate_NRY.Location = new Point(120, 107);
            dateTimePickerEndDate_NRY.Name = "dateTimePickerEndDate_NRY";
            dateTimePickerEndDate_NRY.Size = new Size(200, 23);
            dateTimePickerEndDate_NRY.TabIndex = 35;
            // 
            // labelargoWeight_NRY
            // 
            labelargoWeight_NRY.AutoSize = true;
            labelargoWeight_NRY.Location = new Point(12, 230);
            labelargoWeight_NRY.Name = "labelargoWeight_NRY";
            labelargoWeight_NRY.Size = new Size(99, 15);
            labelargoWeight_NRY.TabIndex = 22;
            labelargoWeight_NRY.Text = "Масса груза (кг):";
            // 
            // numericUpDownCargoWeight_NRY
            // 
            numericUpDownCargoWeight_NRY.DecimalPlaces = 1;
            numericUpDownCargoWeight_NRY.Location = new Point(120, 227);
            numericUpDownCargoWeight_NRY.Maximum = new decimal(new int[] { 10000, 0, 0, 0 });
            numericUpDownCargoWeight_NRY.Name = "numericUpDownCargoWeight_NRY";
            numericUpDownCargoWeight_NRY.Size = new Size(200, 23);
            numericUpDownCargoWeight_NRY.TabIndex = 31;
            numericUpDownCargoWeight_NRY.TextAlign = HorizontalAlignment.Center;
            numericUpDownCargoWeight_NRY.Value = new decimal(new int[] { 100, 0, 0, 0 });
            // 
            // FormTripEdit_NRY
            // 
            AcceptButton = buttonOK_NRY;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = buttonCancel_NRY;
            ClientSize = new Size(334, 311);
            Controls.Add(comboBoxDriver_NRY);
            Controls.Add(comboBoxCar_NRY);
            Controls.Add(dateTimePickerEndDate_NRY);
            Controls.Add(dateTimePickerStartDate_NRY);
            Controls.Add(buttonCancel_NRY);
            Controls.Add(buttonOK_NRY);
            Controls.Add(numericUpDownCargoWeight_NRY);
            Controls.Add(numericUpDownFuelUsed_NRY);
            Controls.Add(labelargoWeight_NRY);
            Controls.Add(numericUpDownDistance_NRY);
            Controls.Add(labelFuelUsed_NRY);
            Controls.Add(labelDistance_NRY);
            Controls.Add(labelEndDate_NRY);
            Controls.Add(textBoxDestination_NRY);
            Controls.Add(labelStartDate_NRY);
            Controls.Add(labelDestination_NRY);
            Controls.Add(labelDriver_NRY);
            Controls.Add(labelCar_NRY);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FormTripEdit_NRY";
            Text = "Карточка Маршрута";
            ((System.ComponentModel.ISupportInitialize)numericUpDownFuelUsed_NRY).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownDistance_NRY).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownCargoWeight_NRY).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DateTimePicker dateTimePickerStartDate_NRY;
        private Button buttonCancel_NRY;
        private Button buttonOK_NRY;
        private NumericUpDown numericUpDownFuelUsed_NRY;
        private NumericUpDown numericUpDownDistance_NRY;
        private Label labelFuelUsed_NRY;
        private Label labelDistance_NRY;
        private TextBox textBoxDestination_NRY;
        private Label labelStartDate_NRY;
        private Label labelDestination_NRY;
        private Label labelDriver_NRY;
        private Label labelCar_NRY;
        private ComboBox comboBoxCar_NRY;
        private ComboBox comboBoxDriver_NRY;
        private Label labelEndDate_NRY;
        private DateTimePicker dateTimePickerEndDate_NRY;
        private Label labelargoWeight_NRY;
        private NumericUpDown numericUpDownCargoWeight_NRY;
    }
}