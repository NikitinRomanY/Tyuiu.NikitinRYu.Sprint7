namespace Tyuiu.NikitinRYu.Sprint7.Task0.V8
{
    partial class FormDriverEdit_NRY
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
            buttonCancel_NRY = new Button();
            buttonOK_NRY = new Button();
            numericUpDownSalary_NRY = new NumericUpDown();
            numericUpDownExperience_NRY = new NumericUpDown();
            labelSalary_NRY = new Label();
            labelExperience_NRY = new Label();
            textBoxFirstName_NRY = new TextBox();
            labelFirstName_NRY = new Label();
            textBoxLastName_NRY = new TextBox();
            labelLastName_NRY = new Label();
            labelMiddleName_NRY = new Label();
            textBoxMiddleName_NRY = new TextBox();
            dateTimePickerBirthDate_NRY = new DateTimePicker();
            labelBirthDate_NRY = new Label();
            ((System.ComponentModel.ISupportInitialize)numericUpDownSalary_NRY).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownExperience_NRY).BeginInit();
            SuspendLayout();
            // 
            // buttonCancel_NRY
            // 
            buttonCancel_NRY.DialogResult = DialogResult.Cancel;
            buttonCancel_NRY.Location = new Point(168, 234);
            buttonCancel_NRY.Name = "buttonCancel_NRY";
            buttonCancel_NRY.Size = new Size(75, 30);
            buttonCancel_NRY.TabIndex = 19;
            buttonCancel_NRY.Text = "ОТМЕНА";
            buttonCancel_NRY.UseVisualStyleBackColor = true;
            buttonCancel_NRY.Click += buttonCancel_NRY_Click;
            // 
            // buttonOK_NRY
            // 
            buttonOK_NRY.DialogResult = DialogResult.OK;
            buttonOK_NRY.Location = new Point(88, 234);
            buttonOK_NRY.Name = "buttonOK_NRY";
            buttonOK_NRY.Size = new Size(75, 30);
            buttonOK_NRY.TabIndex = 20;
            buttonOK_NRY.Text = "ОК";
            buttonOK_NRY.UseVisualStyleBackColor = true;
            buttonOK_NRY.Click += buttonOK_NRY_Click;
            // 
            // numericUpDownSalary_NRY
            // 
            numericUpDownSalary_NRY.Location = new Point(120, 167);
            numericUpDownSalary_NRY.Maximum = new decimal(new int[] { 70, 0, 0, 0 });
            numericUpDownSalary_NRY.Name = "numericUpDownSalary_NRY";
            numericUpDownSalary_NRY.Size = new Size(200, 23);
            numericUpDownSalary_NRY.TabIndex = 17;
            numericUpDownSalary_NRY.TextAlign = HorizontalAlignment.Center;
            numericUpDownSalary_NRY.Value = new decimal(new int[] { 50, 0, 0, 0 });
            // 
            // numericUpDownExperience_NRY
            // 
            numericUpDownExperience_NRY.Location = new Point(120, 137);
            numericUpDownExperience_NRY.Maximum = new decimal(new int[] { 40, 0, 0, 0 });
            numericUpDownExperience_NRY.Name = "numericUpDownExperience_NRY";
            numericUpDownExperience_NRY.Size = new Size(200, 23);
            numericUpDownExperience_NRY.TabIndex = 18;
            numericUpDownExperience_NRY.TextAlign = HorizontalAlignment.Center;
            numericUpDownExperience_NRY.Value = new decimal(new int[] { 5, 0, 0, 0 });
            // 
            // labelSalary_NRY
            // 
            labelSalary_NRY.AutoSize = true;
            labelSalary_NRY.Location = new Point(15, 170);
            labelSalary_NRY.Name = "labelSalary_NRY";
            labelSalary_NRY.Size = new Size(70, 15);
            labelSalary_NRY.TabIndex = 6;
            labelSalary_NRY.Text = "Оклад (т.р):";
            // 
            // labelExperience_NRY
            // 
            labelExperience_NRY.AutoSize = true;
            labelExperience_NRY.Location = new Point(15, 140);
            labelExperience_NRY.Name = "labelExperience_NRY";
            labelExperience_NRY.Size = new Size(67, 15);
            labelExperience_NRY.TabIndex = 7;
            labelExperience_NRY.Text = "Стаж (лет):";
            // 
            // textBoxFirstName_NRY
            // 
            textBoxFirstName_NRY.Location = new Point(120, 47);
            textBoxFirstName_NRY.MaxLength = 50;
            textBoxFirstName_NRY.Name = "textBoxFirstName_NRY";
            textBoxFirstName_NRY.Size = new Size(200, 23);
            textBoxFirstName_NRY.TabIndex = 13;
            // 
            // labelFirstName_NRY
            // 
            labelFirstName_NRY.AutoSize = true;
            labelFirstName_NRY.Location = new Point(15, 50);
            labelFirstName_NRY.Name = "labelFirstName_NRY";
            labelFirstName_NRY.Size = new Size(34, 15);
            labelFirstName_NRY.TabIndex = 10;
            labelFirstName_NRY.Text = "Имя:";
            // 
            // textBoxLastName_NRY
            // 
            textBoxLastName_NRY.Location = new Point(120, 17);
            textBoxLastName_NRY.MaxLength = 50;
            textBoxLastName_NRY.Name = "textBoxLastName_NRY";
            textBoxLastName_NRY.Size = new Size(200, 23);
            textBoxLastName_NRY.TabIndex = 14;
            // 
            // labelLastName_NRY
            // 
            labelLastName_NRY.AutoSize = true;
            labelLastName_NRY.Location = new Point(12, 20);
            labelLastName_NRY.Name = "labelLastName_NRY";
            labelLastName_NRY.Size = new Size(61, 15);
            labelLastName_NRY.TabIndex = 11;
            labelLastName_NRY.Text = "Фамилия:";
            // 
            // labelMiddleName_NRY
            // 
            labelMiddleName_NRY.AutoSize = true;
            labelMiddleName_NRY.Location = new Point(15, 80);
            labelMiddleName_NRY.Name = "labelMiddleName_NRY";
            labelMiddleName_NRY.Size = new Size(61, 15);
            labelMiddleName_NRY.TabIndex = 10;
            labelMiddleName_NRY.Text = "Отчество:";
            // 
            // textBoxMiddleName_NRY
            // 
            textBoxMiddleName_NRY.Location = new Point(120, 77);
            textBoxMiddleName_NRY.MaxLength = 50;
            textBoxMiddleName_NRY.Name = "textBoxMiddleName_NRY";
            textBoxMiddleName_NRY.Size = new Size(200, 23);
            textBoxMiddleName_NRY.TabIndex = 13;
            // 
            // dateTimePickerBirthDate_NRY
            // 
            dateTimePickerBirthDate_NRY.Location = new Point(120, 107);
            dateTimePickerBirthDate_NRY.Name = "dateTimePickerBirthDate_NRY";
            dateTimePickerBirthDate_NRY.Size = new Size(200, 23);
            dateTimePickerBirthDate_NRY.TabIndex = 21;
            // 
            // labelBirthDate_NRY
            // 
            labelBirthDate_NRY.AutoSize = true;
            labelBirthDate_NRY.Location = new Point(15, 110);
            labelBirthDate_NRY.Name = "labelBirthDate_NRY";
            labelBirthDate_NRY.Size = new Size(93, 15);
            labelBirthDate_NRY.TabIndex = 10;
            labelBirthDate_NRY.Text = "Дата рождения:";
            // 
            // FormDriverEdit_NRY
            // 
            AcceptButton = buttonOK_NRY;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = buttonCancel_NRY;
            ClientSize = new Size(334, 281);
            Controls.Add(dateTimePickerBirthDate_NRY);
            Controls.Add(buttonCancel_NRY);
            Controls.Add(buttonOK_NRY);
            Controls.Add(numericUpDownSalary_NRY);
            Controls.Add(numericUpDownExperience_NRY);
            Controls.Add(labelSalary_NRY);
            Controls.Add(labelExperience_NRY);
            Controls.Add(textBoxMiddleName_NRY);
            Controls.Add(labelBirthDate_NRY);
            Controls.Add(labelMiddleName_NRY);
            Controls.Add(textBoxFirstName_NRY);
            Controls.Add(labelFirstName_NRY);
            Controls.Add(textBoxLastName_NRY);
            Controls.Add(labelLastName_NRY);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FormDriverEdit_NRY";
            Text = "Карточка Водителя";
            ((System.ComponentModel.ISupportInitialize)numericUpDownSalary_NRY).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownExperience_NRY).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonCancel_NRY;
        private Button buttonOK_NRY;
        private NumericUpDown numericUpDownFuel_NRY;
        private NumericUpDown numericUpDownSalary_NRY;
        private NumericUpDown numericUpDownExperience_NRY;
        private ComboBox comboBoxCondition_NRY;
        private Label labelFuel_NRY;
        private Label labelSalary_NRY;
        private Label labelExperience_NRY;
        private TextBox textBoxLocation_NRY;
        private Label labelLocation_NRY;
        private Label labelCondition_NRY;
        private TextBox textBoxFirstName_NRY;
        private Label labelFirstName_NRY;
        private TextBox textBoxLastName_NRY;
        private Label labelLastName_NRY;
        private Label labelMiddleName_NRY;
        private TextBox textBoxMiddleName_NRY;
        private DateTimePicker dateTimePickerBirthDate_NRY;
        private Label labelBirthDate_NRY;
    }
}