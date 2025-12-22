namespace Tyuiu.NikitinRYu.Sprint7.Task0.V8
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            tabControlMain_NRY = new TabControl();
            tabPageCars_NRY = new TabPage();
            panelCarsControls_NRY = new Panel();
            labelCarsCount_NRY = new Label();
            buttonDeleteCar_NRY = new Button();
            buttonEditCar_NRY = new Button();
            buttonAddCar_NRY = new Button();
            dataGridViewCars_NRY = new DataGridView();
            tabPageDrivers_NRY = new TabPage();
            panelDriversControls_NRY = new Panel();
            labelDriversCount_NRY = new Label();
            buttonDeleteDriver_NRY = new Button();
            buttonEditDriver_NRY = new Button();
            buttonAddDriver_NRY = new Button();
            dataGridViewDrivers_NRY = new DataGridView();
            tabPageTrips_NRY = new TabPage();
            panelTripsControls_NRY = new Panel();
            labelTripsCount_NRY = new Label();
            buttonDeleteTrip_NRY = new Button();
            buttonEditTrip_NRY = new Button();
            buttonAddTrip_NRY = new Button();
            dataGridViewTrips_NRY = new DataGridView();
            tabPageSearch_NRY = new TabPage();
            labelSearchResults_NRY = new Label();
            dataGridViewSearchResults_NRY = new DataGridView();
            panelSearchControls_NRY = new Panel();
            buttonResetSearch_NRY = new Button();
            buttonSearch_NRY = new Button();
            comboBoxSearchField_NRY = new ComboBox();
            textBoxSearch_NRY = new TextBox();
            labelSearch_NRY = new Label();
            tabPageStats_NRY = new TabPage();
            panelChartControls_NRY = new Panel();
            buttonBuildChart_NRY = new Button();
            comboBoxChartSource_NRY = new ComboBox();
            labelSource_NRY = new Label();
            comboBoxChartType_NRY = new ComboBox();
            labelChartType_NRY = new Label();
            chartStats_NRY = new System.Windows.Forms.DataVisualization.Charting.Chart();
            panelStatsControls_NRY = new Panel();
            buttonExportStats_NRY = new Button();
            buttonRefreshStats_NRY = new Button();
            groupBoxTripStats_NRY = new GroupBox();
            textBoxTripStats_NRY = new TextBox();
            groupBoxDriverStats_NRY = new GroupBox();
            textBoxDriverStats_NRY = new TextBox();
            groupBoxCarStats_NRY = new GroupBox();
            textBoxCarStats_NRY = new TextBox();
            tabControlMain_NRY.SuspendLayout();
            tabPageCars_NRY.SuspendLayout();
            panelCarsControls_NRY.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewCars_NRY).BeginInit();
            tabPageDrivers_NRY.SuspendLayout();
            panelDriversControls_NRY.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewDrivers_NRY).BeginInit();
            tabPageTrips_NRY.SuspendLayout();
            panelTripsControls_NRY.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewTrips_NRY).BeginInit();
            tabPageSearch_NRY.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewSearchResults_NRY).BeginInit();
            panelSearchControls_NRY.SuspendLayout();
            tabPageStats_NRY.SuspendLayout();
            panelChartControls_NRY.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)chartStats_NRY).BeginInit();
            panelStatsControls_NRY.SuspendLayout();
            groupBoxTripStats_NRY.SuspendLayout();
            groupBoxDriverStats_NRY.SuspendLayout();
            groupBoxCarStats_NRY.SuspendLayout();
            SuspendLayout();
            // 
            // tabControlMain_NRY
            // 
            tabControlMain_NRY.Controls.Add(tabPageCars_NRY);
            tabControlMain_NRY.Controls.Add(tabPageDrivers_NRY);
            tabControlMain_NRY.Controls.Add(tabPageTrips_NRY);
            tabControlMain_NRY.Controls.Add(tabPageSearch_NRY);
            tabControlMain_NRY.Controls.Add(tabPageStats_NRY);
            tabControlMain_NRY.Dock = DockStyle.Fill;
            tabControlMain_NRY.Location = new Point(0, 0);
            tabControlMain_NRY.Margin = new Padding(3, 3, 3, 40);
            tabControlMain_NRY.Name = "tabControlMain_NRY";
            tabControlMain_NRY.SelectedIndex = 0;
            tabControlMain_NRY.Size = new Size(1184, 620);
            tabControlMain_NRY.TabIndex = 2;
            // 
            // tabPageCars_NRY
            // 
            tabPageCars_NRY.Controls.Add(panelCarsControls_NRY);
            tabPageCars_NRY.Controls.Add(dataGridViewCars_NRY);
            tabPageCars_NRY.Location = new Point(4, 24);
            tabPageCars_NRY.Name = "tabPageCars_NRY";
            tabPageCars_NRY.Padding = new Padding(3);
            tabPageCars_NRY.Size = new Size(1176, 592);
            tabPageCars_NRY.TabIndex = 0;
            tabPageCars_NRY.Text = "Автомобили";
            tabPageCars_NRY.UseVisualStyleBackColor = true;
            // 
            // panelCarsControls_NRY
            // 
            panelCarsControls_NRY.Controls.Add(labelCarsCount_NRY);
            panelCarsControls_NRY.Controls.Add(buttonDeleteCar_NRY);
            panelCarsControls_NRY.Controls.Add(buttonEditCar_NRY);
            panelCarsControls_NRY.Controls.Add(buttonAddCar_NRY);
            panelCarsControls_NRY.Dock = DockStyle.Bottom;
            panelCarsControls_NRY.Location = new Point(3, 549);
            panelCarsControls_NRY.Name = "panelCarsControls_NRY";
            panelCarsControls_NRY.Size = new Size(1170, 40);
            panelCarsControls_NRY.TabIndex = 2;
            // 
            // labelCarsCount_NRY
            // 
            labelCarsCount_NRY.Location = new Point(5, 3);
            labelCarsCount_NRY.Name = "labelCarsCount_NRY";
            labelCarsCount_NRY.Size = new Size(97, 34);
            labelCarsCount_NRY.TabIndex = 1;
            labelCarsCount_NRY.Text = "Автомобилей: 0";
            labelCarsCount_NRY.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // buttonDeleteCar_NRY
            // 
            buttonDeleteCar_NRY.Location = new Point(280, 3);
            buttonDeleteCar_NRY.Name = "buttonDeleteCar_NRY";
            buttonDeleteCar_NRY.Size = new Size(80, 34);
            buttonDeleteCar_NRY.TabIndex = 0;
            buttonDeleteCar_NRY.Text = "Удалить";
            buttonDeleteCar_NRY.UseVisualStyleBackColor = true;
            buttonDeleteCar_NRY.Click += buttonDeleteCar_NRY_Click;
            // 
            // buttonEditCar_NRY
            // 
            buttonEditCar_NRY.Location = new Point(194, 3);
            buttonEditCar_NRY.Name = "buttonEditCar_NRY";
            buttonEditCar_NRY.Size = new Size(80, 34);
            buttonEditCar_NRY.TabIndex = 0;
            buttonEditCar_NRY.Text = "Изменить";
            buttonEditCar_NRY.UseVisualStyleBackColor = true;
            buttonEditCar_NRY.Click += buttonEditCar_NRY_Click;
            // 
            // buttonAddCar_NRY
            // 
            buttonAddCar_NRY.Location = new Point(108, 3);
            buttonAddCar_NRY.Name = "buttonAddCar_NRY";
            buttonAddCar_NRY.Size = new Size(80, 34);
            buttonAddCar_NRY.TabIndex = 0;
            buttonAddCar_NRY.Text = "Добавить";
            buttonAddCar_NRY.UseVisualStyleBackColor = true;
            buttonAddCar_NRY.Click += buttonAddCar_NRY_Click;
            // 
            // dataGridViewCars_NRY
            // 
            dataGridViewCars_NRY.AllowUserToAddRows = false;
            dataGridViewCars_NRY.AllowUserToDeleteRows = false;
            dataGridViewCars_NRY.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCars_NRY.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCars_NRY.Dock = DockStyle.Fill;
            dataGridViewCars_NRY.Location = new Point(3, 3);
            dataGridViewCars_NRY.Name = "dataGridViewCars_NRY";
            dataGridViewCars_NRY.ReadOnly = true;
            dataGridViewCars_NRY.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewCars_NRY.Size = new Size(1170, 586);
            dataGridViewCars_NRY.TabIndex = 1;
            // 
            // tabPageDrivers_NRY
            // 
            tabPageDrivers_NRY.Controls.Add(panelDriversControls_NRY);
            tabPageDrivers_NRY.Controls.Add(dataGridViewDrivers_NRY);
            tabPageDrivers_NRY.Location = new Point(4, 24);
            tabPageDrivers_NRY.Name = "tabPageDrivers_NRY";
            tabPageDrivers_NRY.Padding = new Padding(3);
            tabPageDrivers_NRY.Size = new Size(1176, 592);
            tabPageDrivers_NRY.TabIndex = 1;
            tabPageDrivers_NRY.Text = "Водители";
            tabPageDrivers_NRY.UseVisualStyleBackColor = true;
            // 
            // panelDriversControls_NRY
            // 
            panelDriversControls_NRY.Controls.Add(labelDriversCount_NRY);
            panelDriversControls_NRY.Controls.Add(buttonDeleteDriver_NRY);
            panelDriversControls_NRY.Controls.Add(buttonEditDriver_NRY);
            panelDriversControls_NRY.Controls.Add(buttonAddDriver_NRY);
            panelDriversControls_NRY.Dock = DockStyle.Bottom;
            panelDriversControls_NRY.Location = new Point(3, 549);
            panelDriversControls_NRY.Name = "panelDriversControls_NRY";
            panelDriversControls_NRY.Size = new Size(1170, 40);
            panelDriversControls_NRY.TabIndex = 3;
            // 
            // labelDriversCount_NRY
            // 
            labelDriversCount_NRY.Location = new Point(5, 3);
            labelDriversCount_NRY.Name = "labelDriversCount_NRY";
            labelDriversCount_NRY.Size = new Size(97, 34);
            labelDriversCount_NRY.TabIndex = 4;
            labelDriversCount_NRY.Text = "Водителей: 0";
            labelDriversCount_NRY.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // buttonDeleteDriver_NRY
            // 
            buttonDeleteDriver_NRY.Location = new Point(280, 3);
            buttonDeleteDriver_NRY.Name = "buttonDeleteDriver_NRY";
            buttonDeleteDriver_NRY.Size = new Size(80, 34);
            buttonDeleteDriver_NRY.TabIndex = 1;
            buttonDeleteDriver_NRY.Text = "Удалить";
            buttonDeleteDriver_NRY.UseVisualStyleBackColor = true;
            buttonDeleteDriver_NRY.Click += buttonDeleteDriver_NRY_Click;
            // 
            // buttonEditDriver_NRY
            // 
            buttonEditDriver_NRY.Location = new Point(194, 3);
            buttonEditDriver_NRY.Name = "buttonEditDriver_NRY";
            buttonEditDriver_NRY.Size = new Size(80, 34);
            buttonEditDriver_NRY.TabIndex = 2;
            buttonEditDriver_NRY.Text = "Изменить";
            buttonEditDriver_NRY.UseVisualStyleBackColor = true;
            buttonEditDriver_NRY.Click += buttonEditDriver_NRY_Click;
            // 
            // buttonAddDriver_NRY
            // 
            buttonAddDriver_NRY.Location = new Point(108, 3);
            buttonAddDriver_NRY.Name = "buttonAddDriver_NRY";
            buttonAddDriver_NRY.Size = new Size(80, 34);
            buttonAddDriver_NRY.TabIndex = 3;
            buttonAddDriver_NRY.Text = "Добавить";
            buttonAddDriver_NRY.UseVisualStyleBackColor = true;
            buttonAddDriver_NRY.Click += buttonAddDriver_NRY_Click;
            // 
            // dataGridViewDrivers_NRY
            // 
            dataGridViewDrivers_NRY.AllowUserToAddRows = false;
            dataGridViewDrivers_NRY.AllowUserToDeleteRows = false;
            dataGridViewDrivers_NRY.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewDrivers_NRY.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewDrivers_NRY.Dock = DockStyle.Fill;
            dataGridViewDrivers_NRY.Location = new Point(3, 3);
            dataGridViewDrivers_NRY.Name = "dataGridViewDrivers_NRY";
            dataGridViewDrivers_NRY.ReadOnly = true;
            dataGridViewDrivers_NRY.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewDrivers_NRY.Size = new Size(1170, 586);
            dataGridViewDrivers_NRY.TabIndex = 2;
            // 
            // tabPageTrips_NRY
            // 
            tabPageTrips_NRY.Controls.Add(panelTripsControls_NRY);
            tabPageTrips_NRY.Controls.Add(dataGridViewTrips_NRY);
            tabPageTrips_NRY.Location = new Point(4, 24);
            tabPageTrips_NRY.Name = "tabPageTrips_NRY";
            tabPageTrips_NRY.Padding = new Padding(3);
            tabPageTrips_NRY.Size = new Size(1176, 592);
            tabPageTrips_NRY.TabIndex = 2;
            tabPageTrips_NRY.Text = "Маршрут";
            tabPageTrips_NRY.UseVisualStyleBackColor = true;
            // 
            // panelTripsControls_NRY
            // 
            panelTripsControls_NRY.Controls.Add(labelTripsCount_NRY);
            panelTripsControls_NRY.Controls.Add(buttonDeleteTrip_NRY);
            panelTripsControls_NRY.Controls.Add(buttonEditTrip_NRY);
            panelTripsControls_NRY.Controls.Add(buttonAddTrip_NRY);
            panelTripsControls_NRY.Dock = DockStyle.Bottom;
            panelTripsControls_NRY.Location = new Point(3, 549);
            panelTripsControls_NRY.Name = "panelTripsControls_NRY";
            panelTripsControls_NRY.Size = new Size(1170, 40);
            panelTripsControls_NRY.TabIndex = 4;
            // 
            // labelTripsCount_NRY
            // 
            labelTripsCount_NRY.Location = new Point(5, 3);
            labelTripsCount_NRY.Name = "labelTripsCount_NRY";
            labelTripsCount_NRY.Size = new Size(97, 34);
            labelTripsCount_NRY.TabIndex = 7;
            labelTripsCount_NRY.Text = "Рейсов: 0";
            labelTripsCount_NRY.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // buttonDeleteTrip_NRY
            // 
            buttonDeleteTrip_NRY.Location = new Point(280, 3);
            buttonDeleteTrip_NRY.Name = "buttonDeleteTrip_NRY";
            buttonDeleteTrip_NRY.Size = new Size(80, 34);
            buttonDeleteTrip_NRY.TabIndex = 4;
            buttonDeleteTrip_NRY.Text = "Удалить";
            buttonDeleteTrip_NRY.UseVisualStyleBackColor = true;
            buttonDeleteTrip_NRY.Click += buttonDeleteTrip_NRY_Click;
            // 
            // buttonEditTrip_NRY
            // 
            buttonEditTrip_NRY.Location = new Point(194, 3);
            buttonEditTrip_NRY.Name = "buttonEditTrip_NRY";
            buttonEditTrip_NRY.Size = new Size(80, 34);
            buttonEditTrip_NRY.TabIndex = 5;
            buttonEditTrip_NRY.Text = "Изменить";
            buttonEditTrip_NRY.UseVisualStyleBackColor = true;
            buttonEditTrip_NRY.Click += buttonEditTrip_NRY_Click;
            // 
            // buttonAddTrip_NRY
            // 
            buttonAddTrip_NRY.Location = new Point(108, 3);
            buttonAddTrip_NRY.Name = "buttonAddTrip_NRY";
            buttonAddTrip_NRY.Size = new Size(80, 34);
            buttonAddTrip_NRY.TabIndex = 6;
            buttonAddTrip_NRY.Text = "Добавить";
            buttonAddTrip_NRY.UseVisualStyleBackColor = true;
            buttonAddTrip_NRY.Click += buttonAddTrip_NRY_Click;
            // 
            // dataGridViewTrips_NRY
            // 
            dataGridViewTrips_NRY.AllowUserToAddRows = false;
            dataGridViewTrips_NRY.AllowUserToDeleteRows = false;
            dataGridViewTrips_NRY.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewTrips_NRY.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewTrips_NRY.Dock = DockStyle.Fill;
            dataGridViewTrips_NRY.Location = new Point(3, 3);
            dataGridViewTrips_NRY.Name = "dataGridViewTrips_NRY";
            dataGridViewTrips_NRY.ReadOnly = true;
            dataGridViewTrips_NRY.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewTrips_NRY.Size = new Size(1170, 586);
            dataGridViewTrips_NRY.TabIndex = 3;
            // 
            // tabPageSearch_NRY
            // 
            tabPageSearch_NRY.Controls.Add(labelSearchResults_NRY);
            tabPageSearch_NRY.Controls.Add(dataGridViewSearchResults_NRY);
            tabPageSearch_NRY.Controls.Add(panelSearchControls_NRY);
            tabPageSearch_NRY.Location = new Point(4, 24);
            tabPageSearch_NRY.Name = "tabPageSearch_NRY";
            tabPageSearch_NRY.Padding = new Padding(3);
            tabPageSearch_NRY.Size = new Size(1176, 592);
            tabPageSearch_NRY.TabIndex = 3;
            tabPageSearch_NRY.Text = "Поиск";
            tabPageSearch_NRY.UseVisualStyleBackColor = true;
            // 
            // labelSearchResults_NRY
            // 
            labelSearchResults_NRY.Dock = DockStyle.Bottom;
            labelSearchResults_NRY.Location = new Point(3, 550);
            labelSearchResults_NRY.Name = "labelSearchResults_NRY";
            labelSearchResults_NRY.Size = new Size(1170, 39);
            labelSearchResults_NRY.TabIndex = 2;
            // 
            // dataGridViewSearchResults_NRY
            // 
            dataGridViewSearchResults_NRY.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewSearchResults_NRY.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewSearchResults_NRY.Dock = DockStyle.Fill;
            dataGridViewSearchResults_NRY.Location = new Point(3, 51);
            dataGridViewSearchResults_NRY.Name = "dataGridViewSearchResults_NRY";
            dataGridViewSearchResults_NRY.Size = new Size(1170, 538);
            dataGridViewSearchResults_NRY.TabIndex = 1;
            // 
            // panelSearchControls_NRY
            // 
            panelSearchControls_NRY.Controls.Add(buttonResetSearch_NRY);
            panelSearchControls_NRY.Controls.Add(buttonSearch_NRY);
            panelSearchControls_NRY.Controls.Add(comboBoxSearchField_NRY);
            panelSearchControls_NRY.Controls.Add(textBoxSearch_NRY);
            panelSearchControls_NRY.Controls.Add(labelSearch_NRY);
            panelSearchControls_NRY.Dock = DockStyle.Top;
            panelSearchControls_NRY.Location = new Point(3, 3);
            panelSearchControls_NRY.Name = "panelSearchControls_NRY";
            panelSearchControls_NRY.Size = new Size(1170, 48);
            panelSearchControls_NRY.TabIndex = 0;
            // 
            // buttonResetSearch_NRY
            // 
            buttonResetSearch_NRY.Location = new Point(704, 10);
            buttonResetSearch_NRY.Name = "buttonResetSearch_NRY";
            buttonResetSearch_NRY.Size = new Size(75, 25);
            buttonResetSearch_NRY.TabIndex = 3;
            buttonResetSearch_NRY.Text = "Сброс";
            buttonResetSearch_NRY.UseVisualStyleBackColor = true;
            buttonResetSearch_NRY.Click += buttonResetSearch_NRY_Click;
            // 
            // buttonSearch_NRY
            // 
            buttonSearch_NRY.Location = new Point(624, 10);
            buttonSearch_NRY.Name = "buttonSearch_NRY";
            buttonSearch_NRY.Size = new Size(75, 25);
            buttonSearch_NRY.TabIndex = 3;
            buttonSearch_NRY.Text = "Найти";
            buttonSearch_NRY.UseVisualStyleBackColor = true;
            buttonSearch_NRY.Click += buttonSearch_NRY_Click;
            // 
            // comboBoxSearchField_NRY
            // 
            comboBoxSearchField_NRY.FormattingEnabled = true;
            comboBoxSearchField_NRY.Location = new Point(454, 12);
            comboBoxSearchField_NRY.Name = "comboBoxSearchField_NRY";
            comboBoxSearchField_NRY.Size = new Size(150, 23);
            comboBoxSearchField_NRY.TabIndex = 2;
            // 
            // textBoxSearch_NRY
            // 
            textBoxSearch_NRY.Location = new Point(184, 12);
            textBoxSearch_NRY.Name = "textBoxSearch_NRY";
            textBoxSearch_NRY.Size = new Size(250, 23);
            textBoxSearch_NRY.TabIndex = 1;
            textBoxSearch_NRY.KeyDown += textBoxSearch_NRY_KeyDown;
            // 
            // labelSearch_NRY
            // 
            labelSearch_NRY.AutoSize = true;
            labelSearch_NRY.Location = new Point(20, 15);
            labelSearch_NRY.Name = "labelSearch_NRY";
            labelSearch_NRY.Size = new Size(154, 15);
            labelSearch_NRY.TabIndex = 0;
            labelSearch_NRY.Text = "Введите пункт назначения:";
            // 
            // tabPageStats_NRY
            // 
            tabPageStats_NRY.Controls.Add(panelChartControls_NRY);
            tabPageStats_NRY.Controls.Add(chartStats_NRY);
            tabPageStats_NRY.Controls.Add(panelStatsControls_NRY);
            tabPageStats_NRY.Location = new Point(4, 24);
            tabPageStats_NRY.Name = "tabPageStats_NRY";
            tabPageStats_NRY.Padding = new Padding(3);
            tabPageStats_NRY.Size = new Size(1176, 592);
            tabPageStats_NRY.TabIndex = 4;
            tabPageStats_NRY.Text = "Статистика";
            tabPageStats_NRY.UseVisualStyleBackColor = true;
            // 
            // panelChartControls_NRY
            // 
            panelChartControls_NRY.Controls.Add(buttonBuildChart_NRY);
            panelChartControls_NRY.Controls.Add(comboBoxChartSource_NRY);
            panelChartControls_NRY.Controls.Add(labelSource_NRY);
            panelChartControls_NRY.Controls.Add(comboBoxChartType_NRY);
            panelChartControls_NRY.Controls.Add(labelChartType_NRY);
            panelChartControls_NRY.Dock = DockStyle.Bottom;
            panelChartControls_NRY.Location = new Point(303, 514);
            panelChartControls_NRY.Name = "panelChartControls_NRY";
            panelChartControls_NRY.Size = new Size(870, 75);
            panelChartControls_NRY.TabIndex = 2;
            // 
            // buttonBuildChart_NRY
            // 
            buttonBuildChart_NRY.Location = new Point(284, 8);
            buttonBuildChart_NRY.Name = "buttonBuildChart_NRY";
            buttonBuildChart_NRY.Size = new Size(75, 23);
            buttonBuildChart_NRY.TabIndex = 2;
            buttonBuildChart_NRY.Text = "Построить";
            buttonBuildChart_NRY.UseVisualStyleBackColor = true;
            buttonBuildChart_NRY.Click += buttonBuildChart_NRY_Click;
            // 
            // comboBoxChartSource_NRY
            // 
            comboBoxChartSource_NRY.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxChartSource_NRY.FormattingEnabled = true;
            comboBoxChartSource_NRY.Location = new Point(124, 36);
            comboBoxChartSource_NRY.Name = "comboBoxChartSource_NRY";
            comboBoxChartSource_NRY.Size = new Size(150, 23);
            comboBoxChartSource_NRY.TabIndex = 1;
            // 
            // labelSource_NRY
            // 
            labelSource_NRY.AutoSize = true;
            labelSource_NRY.Location = new Point(10, 38);
            labelSource_NRY.Name = "labelSource_NRY";
            labelSource_NRY.Size = new Size(108, 15);
            labelSource_NRY.TabIndex = 0;
            labelSource_NRY.Text = "Источник данных:";
            // 
            // comboBoxChartType_NRY
            // 
            comboBoxChartType_NRY.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxChartType_NRY.FormattingEnabled = true;
            comboBoxChartType_NRY.Location = new Point(124, 8);
            comboBoxChartType_NRY.Name = "comboBoxChartType_NRY";
            comboBoxChartType_NRY.Size = new Size(150, 23);
            comboBoxChartType_NRY.TabIndex = 1;
            // 
            // labelChartType_NRY
            // 
            labelChartType_NRY.AutoSize = true;
            labelChartType_NRY.Location = new Point(10, 10);
            labelChartType_NRY.Name = "labelChartType_NRY";
            labelChartType_NRY.Size = new Size(79, 15);
            labelChartType_NRY.TabIndex = 0;
            labelChartType_NRY.Text = "Тип графика:";
            // 
            // chartStats_NRY
            // 
            chartStats_NRY.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            chartArea1.Name = "ChartAreaMain";
            chartStats_NRY.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            chartStats_NRY.Legends.Add(legend1);
            chartStats_NRY.Location = new Point(309, 6);
            chartStats_NRY.Name = "chartStats_NRY";
            chartStats_NRY.Size = new Size(864, 502);
            chartStats_NRY.TabIndex = 1;
            chartStats_NRY.Text = "chart1";
            // 
            // panelStatsControls_NRY
            // 
            panelStatsControls_NRY.BorderStyle = BorderStyle.FixedSingle;
            panelStatsControls_NRY.Controls.Add(buttonExportStats_NRY);
            panelStatsControls_NRY.Controls.Add(buttonRefreshStats_NRY);
            panelStatsControls_NRY.Controls.Add(groupBoxTripStats_NRY);
            panelStatsControls_NRY.Controls.Add(groupBoxDriverStats_NRY);
            panelStatsControls_NRY.Controls.Add(groupBoxCarStats_NRY);
            panelStatsControls_NRY.Dock = DockStyle.Left;
            panelStatsControls_NRY.Location = new Point(3, 3);
            panelStatsControls_NRY.Name = "panelStatsControls_NRY";
            panelStatsControls_NRY.Size = new Size(300, 586);
            panelStatsControls_NRY.TabIndex = 0;
            // 
            // buttonExportStats_NRY
            // 
            buttonExportStats_NRY.Location = new Point(156, 470);
            buttonExportStats_NRY.Name = "buttonExportStats_NRY";
            buttonExportStats_NRY.Size = new Size(135, 30);
            buttonExportStats_NRY.TabIndex = 2;
            buttonExportStats_NRY.Text = "Экспорт";
            buttonExportStats_NRY.UseVisualStyleBackColor = true;
            buttonExportStats_NRY.Click += buttonExportStats_NRY_Click;
            // 
            // buttonRefreshStats_NRY
            // 
            buttonRefreshStats_NRY.Location = new Point(10, 470);
            buttonRefreshStats_NRY.Name = "buttonRefreshStats_NRY";
            buttonRefreshStats_NRY.Size = new Size(135, 30);
            buttonRefreshStats_NRY.TabIndex = 2;
            buttonRefreshStats_NRY.Text = "Обновить";
            buttonRefreshStats_NRY.UseVisualStyleBackColor = true;
            buttonRefreshStats_NRY.Click += buttonRefreshStats_NRY_Click;
            // 
            // groupBoxTripStats_NRY
            // 
            groupBoxTripStats_NRY.Controls.Add(textBoxTripStats_NRY);
            groupBoxTripStats_NRY.Location = new Point(10, 313);
            groupBoxTripStats_NRY.Name = "groupBoxTripStats_NRY";
            groupBoxTripStats_NRY.Size = new Size(280, 150);
            groupBoxTripStats_NRY.TabIndex = 0;
            groupBoxTripStats_NRY.TabStop = false;
            groupBoxTripStats_NRY.Text = "Статистика по рейсам";
            // 
            // textBoxTripStats_NRY
            // 
            textBoxTripStats_NRY.Location = new Point(6, 22);
            textBoxTripStats_NRY.Multiline = true;
            textBoxTripStats_NRY.Name = "textBoxTripStats_NRY";
            textBoxTripStats_NRY.ReadOnly = true;
            textBoxTripStats_NRY.ScrollBars = ScrollBars.Vertical;
            textBoxTripStats_NRY.Size = new Size(268, 122);
            textBoxTripStats_NRY.TabIndex = 1;
            // 
            // groupBoxDriverStats_NRY
            // 
            groupBoxDriverStats_NRY.Controls.Add(textBoxDriverStats_NRY);
            groupBoxDriverStats_NRY.Location = new Point(10, 157);
            groupBoxDriverStats_NRY.Name = "groupBoxDriverStats_NRY";
            groupBoxDriverStats_NRY.Size = new Size(280, 150);
            groupBoxDriverStats_NRY.TabIndex = 0;
            groupBoxDriverStats_NRY.TabStop = false;
            groupBoxDriverStats_NRY.Text = "Статистика по водителям";
            // 
            // textBoxDriverStats_NRY
            // 
            textBoxDriverStats_NRY.Location = new Point(6, 22);
            textBoxDriverStats_NRY.Multiline = true;
            textBoxDriverStats_NRY.Name = "textBoxDriverStats_NRY";
            textBoxDriverStats_NRY.ReadOnly = true;
            textBoxDriverStats_NRY.ScrollBars = ScrollBars.Vertical;
            textBoxDriverStats_NRY.Size = new Size(268, 122);
            textBoxDriverStats_NRY.TabIndex = 1;
            // 
            // groupBoxCarStats_NRY
            // 
            groupBoxCarStats_NRY.Controls.Add(textBoxCarStats_NRY);
            groupBoxCarStats_NRY.Location = new Point(10, 3);
            groupBoxCarStats_NRY.Name = "groupBoxCarStats_NRY";
            groupBoxCarStats_NRY.Size = new Size(280, 150);
            groupBoxCarStats_NRY.TabIndex = 0;
            groupBoxCarStats_NRY.TabStop = false;
            groupBoxCarStats_NRY.Text = "Статистика по автомобилям";
            // 
            // textBoxCarStats_NRY
            // 
            textBoxCarStats_NRY.Location = new Point(6, 22);
            textBoxCarStats_NRY.Multiline = true;
            textBoxCarStats_NRY.Name = "textBoxCarStats_NRY";
            textBoxCarStats_NRY.ReadOnly = true;
            textBoxCarStats_NRY.ScrollBars = ScrollBars.Vertical;
            textBoxCarStats_NRY.Size = new Size(268, 122);
            textBoxCarStats_NRY.TabIndex = 1;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1184, 620);
            Controls.Add(tabControlMain_NRY);
            MinimumSize = new Size(800, 600);
            Name = "MainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Автотранспортное предприятие - Никитин Р.Ю.";
            Load += MainForm_Load;
            tabControlMain_NRY.ResumeLayout(false);
            tabPageCars_NRY.ResumeLayout(false);
            panelCarsControls_NRY.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewCars_NRY).EndInit();
            tabPageDrivers_NRY.ResumeLayout(false);
            panelDriversControls_NRY.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewDrivers_NRY).EndInit();
            tabPageTrips_NRY.ResumeLayout(false);
            panelTripsControls_NRY.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewTrips_NRY).EndInit();
            tabPageSearch_NRY.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewSearchResults_NRY).EndInit();
            panelSearchControls_NRY.ResumeLayout(false);
            panelSearchControls_NRY.PerformLayout();
            tabPageStats_NRY.ResumeLayout(false);
            panelChartControls_NRY.ResumeLayout(false);
            panelChartControls_NRY.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)chartStats_NRY).EndInit();
            panelStatsControls_NRY.ResumeLayout(false);
            groupBoxTripStats_NRY.ResumeLayout(false);
            groupBoxTripStats_NRY.PerformLayout();
            groupBoxDriverStats_NRY.ResumeLayout(false);
            groupBoxDriverStats_NRY.PerformLayout();
            groupBoxCarStats_NRY.ResumeLayout(false);
            groupBoxCarStats_NRY.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private TabControl tabControlMain_NRY;
        private TabPage tabPageCars_NRY;
        private TabPage tabPageDrivers_NRY;
        private TabPage tabPageTrips_NRY;
        private TabPage tabPageSearch_NRY;
        private TabPage tabPageStats_NRY;
        private DataGridView dataGridViewCars_NRY;
        private DataGridView dataGridViewDrivers_NRY;
        private DataGridView dataGridViewTrips_NRY;
        private Panel panelCarsControls_NRY;
        private Button buttonDeleteCar_NRY;
        private Button buttonEditCar_NRY;
        private Button buttonAddCar_NRY;
        private Panel panelDriversControls_NRY;
        private Panel panelTripsControls_NRY;
        private Button buttonDeleteDriver_NRY;
        private Button buttonEditDriver_NRY;
        private Button buttonAddDriver_NRY;
        private Button buttonDeleteTrip_NRY;
        private Button buttonEditTrip_NRY;
        private Button buttonAddTrip_NRY;
        private Label labelCarsCount_NRY;
        private Label labelDriversCount_NRY;
        private Label labelTripsCount_NRY;
        private Panel panelSearchControls_NRY;
        private Button buttonResetSearch_NRY;
        private Button buttonSearch_NRY;
        private ComboBox comboBoxSearchField_NRY;
        private TextBox textBoxSearch_NRY;
        private Label labelSearch_NRY;
        private DataGridView dataGridViewSearchResults_NRY;
        private Label labelSearchResults_NRY;
        private Panel panelStatsControls_NRY;
        private TextBox textBoxCarStats_NRY;
        private GroupBox groupBoxCarStats_NRY;
        private Button buttonExportStats_NRY;
        private Button buttonRefreshStats_NRY;
        private TextBox textBoxTripStats_NRY;
        private GroupBox groupBoxTripStats_NRY;
        private TextBox textBoxDriverStats_NRY;
        private GroupBox groupBoxDriverStats_NRY;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartStats_NRY;
        private Panel panelChartControls_NRY;
        private Button buttonBuildChart_NRY;
        private ComboBox comboBoxChartType_NRY;
        private Label labelChartType_NRY;
        private ComboBox comboBoxChartSource_NRY;
        private Label labelSource_NRY;
    }
}
