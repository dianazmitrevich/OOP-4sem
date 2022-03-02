
namespace WindowsFormsApp1
{
    partial class Airport
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.PlaneIDTextBox = new System.Windows.Forms.TextBox();
            this.PlaneTypeComboBox = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.RadioButtonBoeingOption = new System.Windows.Forms.RadioButton();
            this.RadioButtonAirbusOption = new System.Windows.Forms.RadioButton();
            this.PlaneLoadCapacityCheckbox = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.PlaneYearMaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.PlaneDateService = new System.Windows.Forms.DateTimePicker();
            this.label8 = new System.Windows.Forms.Label();
            this.PlaneCapacityNumeric = new System.Windows.Forms.NumericUpDown();
            this.AddPlaneButton = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.CrewPlaneID = new System.Windows.Forms.TextBox();
            this.AddCrewMemberButton = new System.Windows.Forms.Button();
            this.CrewSurname = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.CrewAge = new System.Windows.Forms.NumericUpDown();
            this.label13 = new System.Windows.Forms.Label();
            this.CrewWorkExperience = new System.Windows.Forms.TextBox();
            this.CrewPosition = new System.Windows.Forms.ComboBox();
            this.label14 = new System.Windows.Forms.Label();
            this.ManufacturerPlaneID = new System.Windows.Forms.TextBox();
            this.AddManufacturerButton = new System.Windows.Forms.Button();
            this.label15 = new System.Windows.Forms.Label();
            this.ManufacturerName = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.ManufacturerCountry = new System.Windows.Forms.TextBox();
            this.MaunfacturerYear = new System.Windows.Forms.MaskedTextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.OutputBox = new System.Windows.Forms.TextBox();
            this.ResetBoxButton = new System.Windows.Forms.Button();
            this.ModelPanel = new System.Windows.Forms.Panel();
            this.LoadCapacityCkeckbox = new System.Windows.Forms.CheckedListBox();
            this.label4 = new System.Windows.Forms.Label();
            this.ShowTypeInfo = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.PlaneIDShowInfo = new System.Windows.Forms.TextBox();
            this.ShowInfoButton = new System.Windows.Forms.Button();
            this.SearchFormButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.PlaneCapacityNumeric)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CrewAge)).BeginInit();
            this.ModelPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Самолет, ID:";
            // 
            // PlaneIDTextBox
            // 
            this.PlaneIDTextBox.Location = new System.Drawing.Point(105, 8);
            this.PlaneIDTextBox.Name = "PlaneIDTextBox";
            this.PlaneIDTextBox.Size = new System.Drawing.Size(51, 20);
            this.PlaneIDTextBox.TabIndex = 1;
            this.PlaneIDTextBox.TextChanged += new System.EventHandler(this.PlaneIDTextBox_TextChanged);
            // 
            // PlaneTypeComboBox
            // 
            this.PlaneTypeComboBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.PlaneTypeComboBox.FormattingEnabled = true;
            this.PlaneTypeComboBox.Items.AddRange(new object[] {
            "Пассажирский",
            "Грузовой",
            "Военный"});
            this.PlaneTypeComboBox.Location = new System.Drawing.Point(15, 64);
            this.PlaneTypeComboBox.Name = "PlaneTypeComboBox";
            this.PlaneTypeComboBox.Size = new System.Drawing.Size(126, 21);
            this.PlaneTypeComboBox.TabIndex = 2;
            this.PlaneTypeComboBox.SelectedIndexChanged += new System.EventHandler(this.PlaneTypeComboBox_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(132, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Выберите тип самолета:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(167, 42);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Модель:";
            // 
            // RadioButtonBoeingOption
            // 
            this.RadioButtonBoeingOption.AutoSize = true;
            this.RadioButtonBoeingOption.Location = new System.Drawing.Point(73, 10);
            this.RadioButtonBoeingOption.Name = "RadioButtonBoeingOption";
            this.RadioButtonBoeingOption.Size = new System.Drawing.Size(58, 17);
            this.RadioButtonBoeingOption.TabIndex = 1;
            this.RadioButtonBoeingOption.TabStop = true;
            this.RadioButtonBoeingOption.Text = "Boeing";
            this.RadioButtonBoeingOption.UseVisualStyleBackColor = true;
            this.RadioButtonBoeingOption.CheckedChanged += new System.EventHandler(this.RadioButtonBoeingOption_CheckedChanged);
            // 
            // RadioButtonAirbusOption
            // 
            this.RadioButtonAirbusOption.AutoSize = true;
            this.RadioButtonAirbusOption.Location = new System.Drawing.Point(13, 10);
            this.RadioButtonAirbusOption.Name = "RadioButtonAirbusOption";
            this.RadioButtonAirbusOption.Size = new System.Drawing.Size(54, 17);
            this.RadioButtonAirbusOption.TabIndex = 0;
            this.RadioButtonAirbusOption.TabStop = true;
            this.RadioButtonAirbusOption.Text = "Airbus";
            this.RadioButtonAirbusOption.UseVisualStyleBackColor = true;
            this.RadioButtonAirbusOption.CheckedChanged += new System.EventHandler(this.RadioButtonAirbusOption_CheckedChanged);
            // 
            // PlaneLoadCapacityCheckbox
            // 
            this.PlaneLoadCapacityCheckbox.AutoSize = true;
            this.PlaneLoadCapacityCheckbox.Location = new System.Drawing.Point(15, 145);
            this.PlaneLoadCapacityCheckbox.Name = "PlaneLoadCapacityCheckbox";
            this.PlaneLoadCapacityCheckbox.Size = new System.Drawing.Size(107, 13);
            this.PlaneLoadCapacityCheckbox.TabIndex = 7;
            this.PlaneLoadCapacityCheckbox.Text = "Грузоподъемность:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(15, 217);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(74, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Год выпуска:";
            // 
            // PlaneYearMaskedTextBox
            // 
            this.PlaneYearMaskedTextBox.Location = new System.Drawing.Point(18, 233);
            this.PlaneYearMaskedTextBox.Mask = "0000";
            this.PlaneYearMaskedTextBox.Name = "PlaneYearMaskedTextBox";
            this.PlaneYearMaskedTextBox.Size = new System.Drawing.Size(104, 20);
            this.PlaneYearMaskedTextBox.TabIndex = 12;
            this.PlaneYearMaskedTextBox.ValidatingType = typeof(int);
            this.PlaneYearMaskedTextBox.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.PlaneYearMaskedTextBox_MaskInputRejected);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(126, 217);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(116, 13);
            this.label7.TabIndex = 13;
            this.label7.Text = "Дата последнего ТО:";
            // 
            // PlaneDateService
            // 
            this.PlaneDateService.Location = new System.Drawing.Point(129, 232);
            this.PlaneDateService.Name = "PlaneDateService";
            this.PlaneDateService.Size = new System.Drawing.Size(162, 20);
            this.PlaneDateService.TabIndex = 14;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(15, 108);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(135, 13);
            this.label8.TabIndex = 15;
            this.label8.Text = "Кол-во посадочных мест:";
            // 
            // PlaneCapacityNumeric
            // 
            this.PlaneCapacityNumeric.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.PlaneCapacityNumeric.Location = new System.Drawing.Point(157, 108);
            this.PlaneCapacityNumeric.Minimum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.PlaneCapacityNumeric.Name = "PlaneCapacityNumeric";
            this.PlaneCapacityNumeric.Size = new System.Drawing.Size(134, 20);
            this.PlaneCapacityNumeric.TabIndex = 16;
            this.PlaneCapacityNumeric.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.PlaneCapacityNumeric.ValueChanged += new System.EventHandler(this.PlaneCapacityNumeric_ValueChanged);
            // 
            // AddPlaneButton
            // 
            this.AddPlaneButton.Location = new System.Drawing.Point(167, 8);
            this.AddPlaneButton.Name = "AddPlaneButton";
            this.AddPlaneButton.Size = new System.Drawing.Size(124, 20);
            this.AddPlaneButton.TabIndex = 18;
            this.AddPlaneButton.Text = "Добавить";
            this.AddPlaneButton.UseVisualStyleBackColor = true;
            this.AddPlaneButton.Click += new System.EventHandler(this.AddPlaneButton_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label9.Location = new System.Drawing.Point(349, 8);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(167, 16);
            this.label9.TabIndex = 19;
            this.label9.Text = "Экипах, ID самолета —     ";
            // 
            // CrewPlaneID
            // 
            this.CrewPlaneID.Location = new System.Drawing.Point(504, 7);
            this.CrewPlaneID.Name = "CrewPlaneID";
            this.CrewPlaneID.Size = new System.Drawing.Size(51, 20);
            this.CrewPlaneID.TabIndex = 20;
            // 
            // AddCrewMemberButton
            // 
            this.AddCrewMemberButton.Location = new System.Drawing.Point(561, 7);
            this.AddCrewMemberButton.Name = "AddCrewMemberButton";
            this.AddCrewMemberButton.Size = new System.Drawing.Size(64, 20);
            this.AddCrewMemberButton.TabIndex = 21;
            this.AddCrewMemberButton.Text = "add";
            this.AddCrewMemberButton.UseVisualStyleBackColor = true;
            this.AddCrewMemberButton.Click += new System.EventHandler(this.AddCrewMemberButton_Click);
            // 
            // CrewSurname
            // 
            this.CrewSurname.Location = new System.Drawing.Point(420, 41);
            this.CrewSurname.Name = "CrewSurname";
            this.CrewSurname.Size = new System.Drawing.Size(205, 20);
            this.CrewSurname.TabIndex = 22;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(349, 44);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(56, 13);
            this.label10.TabIndex = 23;
            this.label10.Text = "Фамилия";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(349, 73);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(65, 13);
            this.label11.TabIndex = 24;
            this.label11.Text = "Должность";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(358, 103);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(49, 13);
            this.label12.TabIndex = 26;
            this.label12.Text = "Возраст";
            // 
            // CrewAge
            // 
            this.CrewAge.Location = new System.Drawing.Point(352, 119);
            this.CrewAge.Minimum = new decimal(new int[] {
            18,
            0,
            0,
            0});
            this.CrewAge.Name = "CrewAge";
            this.CrewAge.Size = new System.Drawing.Size(71, 20);
            this.CrewAge.TabIndex = 27;
            this.CrewAge.Value = new decimal(new int[] {
            18,
            0,
            0,
            0});
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(435, 103);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(33, 13);
            this.label13.TabIndex = 28;
            this.label13.Text = "Стаж";
            // 
            // CrewWorkExperience
            // 
            this.CrewWorkExperience.Location = new System.Drawing.Point(438, 119);
            this.CrewWorkExperience.Name = "CrewWorkExperience";
            this.CrewWorkExperience.Size = new System.Drawing.Size(187, 20);
            this.CrewWorkExperience.TabIndex = 29;
            // 
            // CrewPosition
            // 
            this.CrewPosition.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.CrewPosition.FormattingEnabled = true;
            this.CrewPosition.Items.AddRange(new object[] {
            "Пилот",
            "Стюард"});
            this.CrewPosition.Location = new System.Drawing.Point(420, 70);
            this.CrewPosition.Name = "CrewPosition";
            this.CrewPosition.Size = new System.Drawing.Size(205, 21);
            this.CrewPosition.TabIndex = 30;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label14.Location = new System.Drawing.Point(349, 185);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(115, 32);
            this.label14.TabIndex = 31;
            this.label14.Text = "Производитель,\r\nID самолета —     ";
            // 
            // ManufacturerPlaneID
            // 
            this.ManufacturerPlaneID.Location = new System.Drawing.Point(470, 185);
            this.ManufacturerPlaneID.Name = "ManufacturerPlaneID";
            this.ManufacturerPlaneID.Size = new System.Drawing.Size(51, 20);
            this.ManufacturerPlaneID.TabIndex = 32;
            // 
            // AddManufacturerButton
            // 
            this.AddManufacturerButton.Location = new System.Drawing.Point(527, 185);
            this.AddManufacturerButton.Name = "AddManufacturerButton";
            this.AddManufacturerButton.Size = new System.Drawing.Size(98, 20);
            this.AddManufacturerButton.TabIndex = 33;
            this.AddManufacturerButton.Text = "add";
            this.AddManufacturerButton.UseVisualStyleBackColor = true;
            this.AddManufacturerButton.Click += new System.EventHandler(this.AddManufacturerButton_Click);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(349, 235);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(57, 13);
            this.label15.TabIndex = 35;
            this.label15.Text = "Название";
            // 
            // ManufacturerName
            // 
            this.ManufacturerName.Location = new System.Drawing.Point(437, 232);
            this.ManufacturerName.Name = "ManufacturerName";
            this.ManufacturerName.Size = new System.Drawing.Size(188, 20);
            this.ManufacturerName.TabIndex = 34;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(350, 261);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(43, 13);
            this.label16.TabIndex = 37;
            this.label16.Text = "Страна";
            // 
            // ManufacturerCountry
            // 
            this.ManufacturerCountry.Location = new System.Drawing.Point(437, 258);
            this.ManufacturerCountry.Name = "ManufacturerCountry";
            this.ManufacturerCountry.Size = new System.Drawing.Size(189, 20);
            this.ManufacturerCountry.TabIndex = 36;
            // 
            // MaunfacturerYear
            // 
            this.MaunfacturerYear.Location = new System.Drawing.Point(437, 284);
            this.MaunfacturerYear.Mask = "0000";
            this.MaunfacturerYear.Name = "MaunfacturerYear";
            this.MaunfacturerYear.Size = new System.Drawing.Size(189, 20);
            this.MaunfacturerYear.TabIndex = 39;
            this.MaunfacturerYear.ValidatingType = typeof(int);
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(349, 287);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(82, 13);
            this.label17.TabIndex = 38;
            this.label17.Text = "Год основания";
            // 
            // OutputBox
            // 
            this.OutputBox.Location = new System.Drawing.Point(20, 407);
            this.OutputBox.Multiline = true;
            this.OutputBox.Name = "OutputBox";
            this.OutputBox.Size = new System.Drawing.Size(606, 257);
            this.OutputBox.TabIndex = 40;
            // 
            // ResetBoxButton
            // 
            this.ResetBoxButton.Location = new System.Drawing.Point(19, 371);
            this.ResetBoxButton.Name = "ResetBoxButton";
            this.ResetBoxButton.Size = new System.Drawing.Size(122, 24);
            this.ResetBoxButton.TabIndex = 43;
            this.ResetBoxButton.Text = "Очистить поле";
            this.ResetBoxButton.UseVisualStyleBackColor = true;
            this.ResetBoxButton.Click += new System.EventHandler(this.ResetBoxButton_Click);
            // 
            // ModelPanel
            // 
            this.ModelPanel.Controls.Add(this.RadioButtonAirbusOption);
            this.ModelPanel.Controls.Add(this.RadioButtonBoeingOption);
            this.ModelPanel.Location = new System.Drawing.Point(157, 54);
            this.ModelPanel.Name = "ModelPanel";
            this.ModelPanel.Size = new System.Drawing.Size(144, 37);
            this.ModelPanel.TabIndex = 44;
            // 
            // LoadCapacityCkeckbox
            // 
            this.LoadCapacityCkeckbox.FormattingEnabled = true;
            this.LoadCapacityCkeckbox.Items.AddRange(new object[] {
            "1т",
            "2т",
            "10т"});
            this.LoadCapacityCkeckbox.Location = new System.Drawing.Point(18, 161);
            this.LoadCapacityCkeckbox.Name = "LoadCapacityCkeckbox";
            this.LoadCapacityCkeckbox.Size = new System.Drawing.Size(273, 49);
            this.LoadCapacityCkeckbox.TabIndex = 45;
            this.LoadCapacityCkeckbox.SelectedIndexChanged += new System.EventHandler(this.LoadCapacityCkeckbox_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(227, 374);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(88, 13);
            this.label4.TabIndex = 46;
            this.label4.Text = "Вывести инфу о";
            // 
            // ShowTypeInfo
            // 
            this.ShowTypeInfo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ShowTypeInfo.AutoCompleteCustomSource.AddRange(new string[] {
            "самолете",
            "экипаже",
            "производителе"});
            this.ShowTypeInfo.FormattingEnabled = true;
            this.ShowTypeInfo.Items.AddRange(new object[] {
            "самолете",
            "экипаже",
            "производителе"});
            this.ShowTypeInfo.Location = new System.Drawing.Point(321, 371);
            this.ShowTypeInfo.Name = "ShowTypeInfo";
            this.ShowTypeInfo.Size = new System.Drawing.Size(126, 21);
            this.ShowTypeInfo.TabIndex = 47;
            this.ShowTypeInfo.SelectedIndexChanged += new System.EventHandler(this.ShowTypeInfo_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(453, 374);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(24, 13);
            this.label5.TabIndex = 48;
            this.label5.Text = "у/#";
            // 
            // PlaneIDShowInfo
            // 
            this.PlaneIDShowInfo.Location = new System.Drawing.Point(483, 372);
            this.PlaneIDShowInfo.Name = "PlaneIDShowInfo";
            this.PlaneIDShowInfo.Size = new System.Drawing.Size(51, 20);
            this.PlaneIDShowInfo.TabIndex = 49;
            // 
            // ShowInfoButton
            // 
            this.ShowInfoButton.Location = new System.Drawing.Point(540, 372);
            this.ShowInfoButton.Name = "ShowInfoButton";
            this.ShowInfoButton.Size = new System.Drawing.Size(86, 20);
            this.ShowInfoButton.TabIndex = 50;
            this.ShowInfoButton.Text = "ok";
            this.ShowInfoButton.UseVisualStyleBackColor = true;
            this.ShowInfoButton.Click += new System.EventHandler(this.ShowInfoButton_Click);
            // 
            // SearchFormButton
            // 
            this.SearchFormButton.Location = new System.Drawing.Point(20, 332);
            this.SearchFormButton.Name = "SearchFormButton";
            this.SearchFormButton.Size = new System.Drawing.Size(121, 33);
            this.SearchFormButton.TabIndex = 51;
            this.SearchFormButton.Text = "Форма для поиска";
            this.SearchFormButton.UseVisualStyleBackColor = true;
            // 
            // Airport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(636, 676);
            this.Controls.Add(this.SearchFormButton);
            this.Controls.Add(this.ShowInfoButton);
            this.Controls.Add(this.PlaneIDShowInfo);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.ShowTypeInfo);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.LoadCapacityCkeckbox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.ModelPanel);
            this.Controls.Add(this.PlaneLoadCapacityCheckbox);
            this.Controls.Add(this.ResetBoxButton);
            this.Controls.Add(this.OutputBox);
            this.Controls.Add(this.MaunfacturerYear);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.ManufacturerCountry);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.ManufacturerName);
            this.Controls.Add(this.AddManufacturerButton);
            this.Controls.Add(this.ManufacturerPlaneID);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.CrewPosition);
            this.Controls.Add(this.CrewWorkExperience);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.CrewAge);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.CrewSurname);
            this.Controls.Add(this.AddCrewMemberButton);
            this.Controls.Add(this.CrewPlaneID);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.AddPlaneButton);
            this.Controls.Add(this.PlaneCapacityNumeric);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.PlaneDateService);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.PlaneYearMaskedTextBox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.PlaneTypeComboBox);
            this.Controls.Add(this.PlaneIDTextBox);
            this.Controls.Add(this.label1);
            this.Name = "Airport";
            this.Text = "Аэропорт";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PlaneCapacityNumeric)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CrewAge)).EndInit();
            this.ModelPanel.ResumeLayout(false);
            this.ModelPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox PlaneIDTextBox;
        private System.Windows.Forms.ComboBox PlaneTypeComboBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RadioButton RadioButtonBoeingOption;
        private System.Windows.Forms.RadioButton RadioButtonAirbusOption;
        private System.Windows.Forms.Label PlaneLoadCapacityCheckbox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.MaskedTextBox PlaneYearMaskedTextBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker PlaneDateService;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.NumericUpDown PlaneCapacityNumeric;
        private System.Windows.Forms.Button AddPlaneButton;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox CrewPlaneID;
        private System.Windows.Forms.Button AddCrewMemberButton;
        private System.Windows.Forms.TextBox CrewSurname;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.NumericUpDown CrewAge;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox CrewWorkExperience;
        private System.Windows.Forms.ComboBox CrewPosition;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox ManufacturerPlaneID;
        private System.Windows.Forms.Button AddManufacturerButton;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox ManufacturerName;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox ManufacturerCountry;
        private System.Windows.Forms.MaskedTextBox MaunfacturerYear;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox OutputBox;
        private System.Windows.Forms.Button ResetBoxButton;
        private System.Windows.Forms.Panel ModelPanel;
        private System.Windows.Forms.CheckedListBox LoadCapacityCkeckbox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox ShowTypeInfo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox PlaneIDShowInfo;
        private System.Windows.Forms.Button ShowInfoButton;
        private System.Windows.Forms.Button SearchFormButton;
    }
}

