namespace AutoDatabase
{
	partial class MainForm
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
            this.components = new System.ComponentModel.Container();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.RegistrateClientTab = new System.Windows.Forms.TabPage();
            this.labelIeskotiKliento = new System.Windows.Forms.Label();
            this.textBoxSearchClient = new System.Windows.Forms.TextBox();
            this.labelKlientai = new System.Windows.Forms.Label();
            this.comboBoxClientType = new System.Windows.Forms.ComboBox();
            this.listBoxClients = new System.Windows.Forms.ListBox();
            this.buttonAddNewCar = new System.Windows.Forms.Button();
            this.textBox16 = new System.Windows.Forms.TextBox();
            this.textBox15 = new System.Windows.Forms.TextBox();
            this.textBox14 = new System.Windows.Forms.TextBox();
            this.textBox10 = new System.Windows.Forms.TextBox();
            this.textBox11 = new System.Windows.Forms.TextBox();
            this.textBox12 = new System.Windows.Forms.TextBox();
            this.textBox13 = new System.Windows.Forms.TextBox();
            this.textBoxCarYear = new System.Windows.Forms.TextBox();
            this.textBoxCarEngine = new System.Windows.Forms.TextBox();
            this.textBoxCarRun = new System.Windows.Forms.TextBox();
            this.textBoxCarModel = new System.Windows.Forms.TextBox();
            this.textBoxCarMake = new System.Windows.Forms.TextBox();
            this.textBoxCarPlate = new System.Windows.Forms.TextBox();
            this.textBoxCarVIN = new System.Windows.Forms.TextBox();
            this.textClient1 = new System.Windows.Forms.TextBox();
            this.textClient2 = new System.Windows.Forms.TextBox();
            this.textBoxClient1 = new System.Windows.Forms.TextBox();
            this.textBoxClient2 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.buttonRegisterClient = new System.Windows.Forms.Button();
            this.textBoxTelephone = new System.Windows.Forms.TextBox();
            this.textBoxAddress = new System.Windows.Forms.TextBox();
            this.JobsTab = new System.Windows.Forms.TabPage();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.listBoxJobEmployees = new System.Windows.Forms.ListBox();
            this.buttonAddEmployeeToJob = new System.Windows.Forms.Button();
            this.listBoxEmployees = new System.Windows.Forms.ListBox();
            this.buttonDeleteJob = new System.Windows.Forms.Button();
            this.buttonFinishJob = new System.Windows.Forms.Button();
            this.listBoxCarJobs = new System.Windows.Forms.ListBox();
            this.buttonAddJobToCar = new System.Windows.Forms.Button();
            this.listBoxServices = new System.Windows.Forms.ListBox();
            this.listBoxArrivedCars = new System.Windows.Forms.ListBox();
            this.dataControllerTab = new System.Windows.Forms.TabPage();
            this.buttonShowBusyness = new System.Windows.Forms.Button();
            this.buttonUpdateData = new System.Windows.Forms.Button();
            this.buttonAddNew = new System.Windows.Forms.Button();
            this.labelRodyti = new System.Windows.Forms.Label();
            this.labelIeskoti = new System.Windows.Forms.Label();
            this.listBoxDuomenys = new System.Windows.Forms.ListBox();
            this.textBoxSearch = new System.Windows.Forms.TextBox();
            this.comboBoxData = new System.Windows.Forms.ComboBox();
            this.SystemLogTab = new System.Windows.Forms.TabPage();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.tabGenerator = new System.Windows.Forms.TabPage();
            this.buttonGenerateOrder = new System.Windows.Forms.Button();
            this.buttonGenerateGuarantee = new System.Windows.Forms.Button();
            this.buttonGenerateBill = new System.Windows.Forms.Button();
            this.labelKlientaiGen = new System.Windows.Forms.Label();
            this.listBoxGeneratorClients = new System.Windows.Forms.ListBox();
            this.newsFeed = new System.Windows.Forms.TabPage();
            this.deleteDiscountButton = new System.Windows.Forms.Button();
            this.addDiscountButton = new System.Windows.Forms.Button();
            this.discountTextLabel = new System.Windows.Forms.Label();
            this.discountsListBox = new System.Windows.Forms.ListBox();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.tabControl.SuspendLayout();
            this.RegistrateClientTab.SuspendLayout();
            this.JobsTab.SuspendLayout();
            this.dataControllerTab.SuspendLayout();
            this.SystemLogTab.SuspendLayout();
            this.tabGenerator.SuspendLayout();
            this.newsFeed.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl
            // 
            this.tabControl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl.Controls.Add(this.RegistrateClientTab);
            this.tabControl.Controls.Add(this.JobsTab);
            this.tabControl.Controls.Add(this.dataControllerTab);
            this.tabControl.Controls.Add(this.SystemLogTab);
            this.tabControl.Controls.Add(this.tabGenerator);
            this.tabControl.Controls.Add(this.newsFeed);
            this.tabControl.Location = new System.Drawing.Point(-1, 1);
            this.tabControl.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(1031, 674);
            this.tabControl.TabIndex = 0;
            // 
            // RegistrateClientTab
            // 
            this.RegistrateClientTab.Controls.Add(this.labelIeskotiKliento);
            this.RegistrateClientTab.Controls.Add(this.textBoxSearchClient);
            this.RegistrateClientTab.Controls.Add(this.labelKlientai);
            this.RegistrateClientTab.Controls.Add(this.comboBoxClientType);
            this.RegistrateClientTab.Controls.Add(this.listBoxClients);
            this.RegistrateClientTab.Controls.Add(this.buttonAddNewCar);
            this.RegistrateClientTab.Controls.Add(this.textBox16);
            this.RegistrateClientTab.Controls.Add(this.textBox15);
            this.RegistrateClientTab.Controls.Add(this.textBox14);
            this.RegistrateClientTab.Controls.Add(this.textBox10);
            this.RegistrateClientTab.Controls.Add(this.textBox11);
            this.RegistrateClientTab.Controls.Add(this.textBox12);
            this.RegistrateClientTab.Controls.Add(this.textBox13);
            this.RegistrateClientTab.Controls.Add(this.textBoxCarYear);
            this.RegistrateClientTab.Controls.Add(this.textBoxCarEngine);
            this.RegistrateClientTab.Controls.Add(this.textBoxCarRun);
            this.RegistrateClientTab.Controls.Add(this.textBoxCarModel);
            this.RegistrateClientTab.Controls.Add(this.textBoxCarMake);
            this.RegistrateClientTab.Controls.Add(this.textBoxCarPlate);
            this.RegistrateClientTab.Controls.Add(this.textBoxCarVIN);
            this.RegistrateClientTab.Controls.Add(this.textClient1);
            this.RegistrateClientTab.Controls.Add(this.textClient2);
            this.RegistrateClientTab.Controls.Add(this.textBoxClient1);
            this.RegistrateClientTab.Controls.Add(this.textBoxClient2);
            this.RegistrateClientTab.Controls.Add(this.textBox2);
            this.RegistrateClientTab.Controls.Add(this.textBox1);
            this.RegistrateClientTab.Controls.Add(this.buttonRegisterClient);
            this.RegistrateClientTab.Controls.Add(this.textBoxTelephone);
            this.RegistrateClientTab.Controls.Add(this.textBoxAddress);
            this.RegistrateClientTab.Location = new System.Drawing.Point(4, 25);
            this.RegistrateClientTab.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.RegistrateClientTab.Name = "RegistrateClientTab";
            this.RegistrateClientTab.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.RegistrateClientTab.Size = new System.Drawing.Size(1023, 645);
            this.RegistrateClientTab.TabIndex = 0;
            this.RegistrateClientTab.Text = "Registruoti klientą";
            this.RegistrateClientTab.UseVisualStyleBackColor = true;
            // 
            // labelIeskotiKliento
            // 
            this.labelIeskotiKliento.AutoSize = true;
            this.labelIeskotiKliento.Location = new System.Drawing.Point(331, 564);
            this.labelIeskotiKliento.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelIeskotiKliento.Name = "labelIeskotiKliento";
            this.labelIeskotiKliento.Size = new System.Drawing.Size(52, 17);
            this.labelIeskotiKliento.TabIndex = 46;
            this.labelIeskotiKliento.Text = "Ieskoti:";
            // 
            // textBoxSearchClient
            // 
            this.textBoxSearchClient.Location = new System.Drawing.Point(393, 560);
            this.textBoxSearchClient.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBoxSearchClient.Name = "textBoxSearchClient";
            this.textBoxSearchClient.Size = new System.Drawing.Size(307, 22);
            this.textBoxSearchClient.TabIndex = 45;
            this.textBoxSearchClient.TextChanged += new System.EventHandler(this.textBoxSearchClient_TextChanged);
            // 
            // labelKlientai
            // 
            this.labelKlientai.AutoSize = true;
            this.labelKlientai.Location = new System.Drawing.Point(331, 272);
            this.labelKlientai.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelKlientai.Name = "labelKlientai";
            this.labelKlientai.Size = new System.Drawing.Size(58, 17);
            this.labelKlientai.TabIndex = 44;
            this.labelKlientai.Text = "Klientai:";
            // 
            // comboBoxClientType
            // 
            this.comboBoxClientType.FormattingEnabled = true;
            this.comboBoxClientType.Items.AddRange(new object[] {
            "Įmonė",
            "Fizinis asmuo"});
            this.comboBoxClientType.Location = new System.Drawing.Point(188, 32);
            this.comboBoxClientType.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.comboBoxClientType.Name = "comboBoxClientType";
            this.comboBoxClientType.Size = new System.Drawing.Size(160, 24);
            this.comboBoxClientType.TabIndex = 43;
            this.comboBoxClientType.TextChanged += new System.EventHandler(this.comboBoxClientType_TextChanged);
            // 
            // listBoxClients
            // 
            this.listBoxClients.DisplayMember = "\"Id\"";
            this.listBoxClients.FormattingEnabled = true;
            this.listBoxClients.ItemHeight = 16;
            this.listBoxClients.Location = new System.Drawing.Point(335, 292);
            this.listBoxClients.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.listBoxClients.Name = "listBoxClients";
            this.listBoxClients.Size = new System.Drawing.Size(365, 260);
            this.listBoxClients.TabIndex = 40;
            this.listBoxClients.ValueMember = "Id";
            // 
            // buttonAddNewCar
            // 
            this.buttonAddNewCar.Location = new System.Drawing.Point(708, 217);
            this.buttonAddNewCar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonAddNewCar.Name = "buttonAddNewCar";
            this.buttonAddNewCar.Size = new System.Drawing.Size(188, 47);
            this.buttonAddNewCar.TabIndex = 39;
            this.buttonAddNewCar.Text = "Prideti automobili";
            this.buttonAddNewCar.UseVisualStyleBackColor = true;
            this.buttonAddNewCar.Click += new System.EventHandler(this.buttonAddNewCar_Click_1);
            // 
            // textBox16
            // 
            this.textBox16.BackColor = System.Drawing.SystemColors.Window;
            this.textBox16.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox16.Location = new System.Drawing.Point(545, 188);
            this.textBox16.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBox16.Name = "textBox16";
            this.textBox16.ReadOnly = true;
            this.textBox16.Size = new System.Drawing.Size(89, 15);
            this.textBox16.TabIndex = 38;
            this.textBox16.Text = "Metai";
            // 
            // textBox15
            // 
            this.textBox15.BackColor = System.Drawing.SystemColors.Window;
            this.textBox15.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox15.Location = new System.Drawing.Point(545, 156);
            this.textBox15.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBox15.Name = "textBox15";
            this.textBox15.ReadOnly = true;
            this.textBox15.Size = new System.Drawing.Size(89, 15);
            this.textBox15.TabIndex = 37;
            this.textBox15.Text = "Variklis";
            // 
            // textBox14
            // 
            this.textBox14.BackColor = System.Drawing.SystemColors.Window;
            this.textBox14.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox14.Location = new System.Drawing.Point(545, 126);
            this.textBox14.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBox14.Name = "textBox14";
            this.textBox14.ReadOnly = true;
            this.textBox14.Size = new System.Drawing.Size(89, 15);
            this.textBox14.TabIndex = 36;
            this.textBox14.Text = "Rida";
            // 
            // textBox10
            // 
            this.textBox10.BackColor = System.Drawing.SystemColors.Window;
            this.textBox10.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox10.Location = new System.Drawing.Point(545, 14);
            this.textBox10.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBox10.Name = "textBox10";
            this.textBox10.ReadOnly = true;
            this.textBox10.Size = new System.Drawing.Size(89, 15);
            this.textBox10.TabIndex = 35;
            this.textBox10.Text = "VIN";
            // 
            // textBox11
            // 
            this.textBox11.BackColor = System.Drawing.SystemColors.Window;
            this.textBox11.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox11.Location = new System.Drawing.Point(545, 36);
            this.textBox11.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBox11.Name = "textBox11";
            this.textBox11.ReadOnly = true;
            this.textBox11.Size = new System.Drawing.Size(89, 15);
            this.textBox11.TabIndex = 34;
            this.textBox11.Text = "Valstybinis nr";
            // 
            // textBox12
            // 
            this.textBox12.BackColor = System.Drawing.SystemColors.Window;
            this.textBox12.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox12.Location = new System.Drawing.Point(545, 96);
            this.textBox12.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBox12.Name = "textBox12";
            this.textBox12.ReadOnly = true;
            this.textBox12.Size = new System.Drawing.Size(89, 15);
            this.textBox12.TabIndex = 33;
            this.textBox12.Text = "Modelis";
            // 
            // textBox13
            // 
            this.textBox13.BackColor = System.Drawing.SystemColors.Window;
            this.textBox13.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox13.Location = new System.Drawing.Point(545, 64);
            this.textBox13.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBox13.Name = "textBox13";
            this.textBox13.ReadOnly = true;
            this.textBox13.Size = new System.Drawing.Size(89, 15);
            this.textBox13.TabIndex = 32;
            this.textBox13.Text = "Marke";
            // 
            // textBoxCarYear
            // 
            this.textBoxCarYear.Location = new System.Drawing.Point(657, 185);
            this.textBoxCarYear.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBoxCarYear.MaxLength = 50;
            this.textBoxCarYear.Name = "textBoxCarYear";
            this.textBoxCarYear.Size = new System.Drawing.Size(279, 22);
            this.textBoxCarYear.TabIndex = 31;
            // 
            // textBoxCarEngine
            // 
            this.textBoxCarEngine.Location = new System.Drawing.Point(657, 153);
            this.textBoxCarEngine.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBoxCarEngine.MaxLength = 50;
            this.textBoxCarEngine.Name = "textBoxCarEngine";
            this.textBoxCarEngine.Size = new System.Drawing.Size(279, 22);
            this.textBoxCarEngine.TabIndex = 30;
            // 
            // textBoxCarRun
            // 
            this.textBoxCarRun.Location = new System.Drawing.Point(657, 121);
            this.textBoxCarRun.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBoxCarRun.MaxLength = 50;
            this.textBoxCarRun.Name = "textBoxCarRun";
            this.textBoxCarRun.Size = new System.Drawing.Size(279, 22);
            this.textBoxCarRun.TabIndex = 29;
            // 
            // textBoxCarModel
            // 
            this.textBoxCarModel.Location = new System.Drawing.Point(657, 92);
            this.textBoxCarModel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBoxCarModel.MaxLength = 50;
            this.textBoxCarModel.Name = "textBoxCarModel";
            this.textBoxCarModel.Size = new System.Drawing.Size(279, 22);
            this.textBoxCarModel.TabIndex = 28;
            // 
            // textBoxCarMake
            // 
            this.textBoxCarMake.Location = new System.Drawing.Point(657, 60);
            this.textBoxCarMake.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBoxCarMake.MaxLength = 50;
            this.textBoxCarMake.Name = "textBoxCarMake";
            this.textBoxCarMake.Size = new System.Drawing.Size(279, 22);
            this.textBoxCarMake.TabIndex = 27;
            // 
            // textBoxCarPlate
            // 
            this.textBoxCarPlate.Location = new System.Drawing.Point(657, 32);
            this.textBoxCarPlate.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBoxCarPlate.MaxLength = 50;
            this.textBoxCarPlate.Name = "textBoxCarPlate";
            this.textBoxCarPlate.Size = new System.Drawing.Size(279, 22);
            this.textBoxCarPlate.TabIndex = 26;
            // 
            // textBoxCarVIN
            // 
            this.textBoxCarVIN.Location = new System.Drawing.Point(657, 5);
            this.textBoxCarVIN.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBoxCarVIN.MaxLength = 50;
            this.textBoxCarVIN.Name = "textBoxCarVIN";
            this.textBoxCarVIN.Size = new System.Drawing.Size(279, 22);
            this.textBoxCarVIN.TabIndex = 25;
            // 
            // textClient1
            // 
            this.textClient1.BackColor = System.Drawing.SystemColors.Window;
            this.textClient1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textClient1.Location = new System.Drawing.Point(12, 69);
            this.textClient1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textClient1.Name = "textClient1";
            this.textClient1.ReadOnly = true;
            this.textClient1.Size = new System.Drawing.Size(101, 15);
            this.textClient1.TabIndex = 10;
            this.textClient1.Text = "Vardas";
            // 
            // textClient2
            // 
            this.textClient2.BackColor = System.Drawing.SystemColors.Window;
            this.textClient2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textClient2.Location = new System.Drawing.Point(12, 101);
            this.textClient2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textClient2.Name = "textClient2";
            this.textClient2.ReadOnly = true;
            this.textClient2.Size = new System.Drawing.Size(68, 15);
            this.textClient2.TabIndex = 9;
            this.textClient2.Text = "Pavarde";
            // 
            // textBoxClient1
            // 
            this.textBoxClient1.Location = new System.Drawing.Point(121, 65);
            this.textBoxClient1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBoxClient1.MaxLength = 50;
            this.textBoxClient1.Name = "textBoxClient1";
            this.textBoxClient1.Size = new System.Drawing.Size(297, 22);
            this.textBoxClient1.TabIndex = 8;
            this.textBoxClient1.Validated += new System.EventHandler(this.textBoxClient1_Validated);
            // 
            // textBoxClient2
            // 
            this.textBoxClient2.Location = new System.Drawing.Point(121, 97);
            this.textBoxClient2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBoxClient2.MaxLength = 50;
            this.textBoxClient2.Name = "textBoxClient2";
            this.textBoxClient2.Size = new System.Drawing.Size(297, 22);
            this.textBoxClient2.TabIndex = 7;
            this.textBoxClient2.Validated += new System.EventHandler(this.textBoxClient2_Validated);
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.SystemColors.Window;
            this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox2.Location = new System.Drawing.Point(12, 161);
            this.textBox2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(71, 15);
            this.textBox2.TabIndex = 6;
            this.textBox2.Text = "Telefonas";
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.Window;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Location = new System.Drawing.Point(12, 129);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(71, 15);
            this.textBox1.TabIndex = 5;
            this.textBox1.Text = "Adresas";
            // 
            // buttonRegisterClient
            // 
            this.buttonRegisterClient.Location = new System.Drawing.Point(185, 188);
            this.buttonRegisterClient.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonRegisterClient.Name = "buttonRegisterClient";
            this.buttonRegisterClient.Size = new System.Drawing.Size(164, 43);
            this.buttonRegisterClient.TabIndex = 2;
            this.buttonRegisterClient.Text = "Registruoti";
            this.buttonRegisterClient.UseVisualStyleBackColor = true;
            this.buttonRegisterClient.Click += new System.EventHandler(this.buttonRegisterClient_Click);
            // 
            // textBoxTelephone
            // 
            this.textBoxTelephone.Location = new System.Drawing.Point(121, 156);
            this.textBoxTelephone.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBoxTelephone.MaxLength = 30;
            this.textBoxTelephone.Name = "textBoxTelephone";
            this.textBoxTelephone.Size = new System.Drawing.Size(297, 22);
            this.textBoxTelephone.TabIndex = 1;
            this.textBoxTelephone.Validated += new System.EventHandler(this.textBoxTelephone_Validated);
            // 
            // textBoxAddress
            // 
            this.textBoxAddress.Location = new System.Drawing.Point(121, 126);
            this.textBoxAddress.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBoxAddress.MaxLength = 50;
            this.textBoxAddress.Name = "textBoxAddress";
            this.textBoxAddress.Size = new System.Drawing.Size(297, 22);
            this.textBoxAddress.TabIndex = 0;
            this.textBoxAddress.Validated += new System.EventHandler(this.textBoxAddress_Validated);
            // 
            // JobsTab
            // 
            this.JobsTab.Controls.Add(this.label5);
            this.JobsTab.Controls.Add(this.label4);
            this.JobsTab.Controls.Add(this.label3);
            this.JobsTab.Controls.Add(this.label2);
            this.JobsTab.Controls.Add(this.label1);
            this.JobsTab.Controls.Add(this.listBoxJobEmployees);
            this.JobsTab.Controls.Add(this.buttonAddEmployeeToJob);
            this.JobsTab.Controls.Add(this.listBoxEmployees);
            this.JobsTab.Controls.Add(this.buttonDeleteJob);
            this.JobsTab.Controls.Add(this.buttonFinishJob);
            this.JobsTab.Controls.Add(this.listBoxCarJobs);
            this.JobsTab.Controls.Add(this.buttonAddJobToCar);
            this.JobsTab.Controls.Add(this.listBoxServices);
            this.JobsTab.Controls.Add(this.listBoxArrivedCars);
            this.JobsTab.Location = new System.Drawing.Point(4, 25);
            this.JobsTab.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.JobsTab.Name = "JobsTab";
            this.JobsTab.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.JobsTab.Size = new System.Drawing.Size(1023, 645);
            this.JobsTab.TabIndex = 9;
            this.JobsTab.Text = "Darbai";
            this.JobsTab.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(413, 6);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(81, 17);
            this.label5.TabIndex = 15;
            this.label5.Text = "Darbuotojai";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(721, 320);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 17);
            this.label4.TabIndex = 14;
            this.label4.Text = "Paslaugos";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(375, 320);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(174, 17);
            this.label3.TabIndex = 13;
            this.label3.Text = "Darbuotojai priskirti darbui";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(113, 320);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(129, 17);
            this.label2.TabIndex = 12;
            this.label2.Text = "Darbai automobiliui";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(113, 6);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(133, 17);
            this.label1.TabIndex = 11;
            this.label1.Text = "Automobiliai servise";
            // 
            // listBoxJobEmployees
            // 
            this.listBoxJobEmployees.DisplayMember = "Id";
            this.listBoxJobEmployees.FormattingEnabled = true;
            this.listBoxJobEmployees.ItemHeight = 16;
            this.listBoxJobEmployees.Location = new System.Drawing.Point(331, 340);
            this.listBoxJobEmployees.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.listBoxJobEmployees.Name = "listBoxJobEmployees";
            this.listBoxJobEmployees.Size = new System.Drawing.Size(269, 244);
            this.listBoxJobEmployees.TabIndex = 10;
            this.listBoxJobEmployees.ValueMember = "Id";
            // 
            // buttonAddEmployeeToJob
            // 
            this.buttonAddEmployeeToJob.Location = new System.Drawing.Point(655, 26);
            this.buttonAddEmployeeToJob.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonAddEmployeeToJob.Name = "buttonAddEmployeeToJob";
            this.buttonAddEmployeeToJob.Size = new System.Drawing.Size(120, 49);
            this.buttonAddEmployeeToJob.TabIndex = 9;
            this.buttonAddEmployeeToJob.Text = "Prideti Darbuotoja";
            this.buttonAddEmployeeToJob.UseVisualStyleBackColor = true;
            this.buttonAddEmployeeToJob.Click += new System.EventHandler(this.buttonAddEmployeeToJob_Click);
            // 
            // listBoxEmployees
            // 
            this.listBoxEmployees.DisplayMember = "Id";
            this.listBoxEmployees.FormattingEnabled = true;
            this.listBoxEmployees.ItemHeight = 16;
            this.listBoxEmployees.Location = new System.Drawing.Point(327, 26);
            this.listBoxEmployees.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.listBoxEmployees.Name = "listBoxEmployees";
            this.listBoxEmployees.Size = new System.Drawing.Size(273, 276);
            this.listBoxEmployees.TabIndex = 8;
            this.listBoxEmployees.ValueMember = "Id";
            // 
            // buttonDeleteJob
            // 
            this.buttonDeleteJob.Location = new System.Drawing.Point(655, 191);
            this.buttonDeleteJob.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonDeleteJob.Name = "buttonDeleteJob";
            this.buttonDeleteJob.Size = new System.Drawing.Size(120, 41);
            this.buttonDeleteJob.TabIndex = 7;
            this.buttonDeleteJob.Text = "Istrinti darba";
            this.buttonDeleteJob.UseVisualStyleBackColor = true;
            this.buttonDeleteJob.Click += new System.EventHandler(this.buttonDeleteJob_Click);
            // 
            // buttonFinishJob
            // 
            this.buttonFinishJob.Location = new System.Drawing.Point(655, 139);
            this.buttonFinishJob.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonFinishJob.Name = "buttonFinishJob";
            this.buttonFinishJob.Size = new System.Drawing.Size(120, 44);
            this.buttonFinishJob.TabIndex = 6;
            this.buttonFinishJob.Text = "Baigti darba";
            this.buttonFinishJob.UseVisualStyleBackColor = true;
            this.buttonFinishJob.Click += new System.EventHandler(this.buttonFinishJob_Click);
            // 
            // listBoxCarJobs
            // 
            this.listBoxCarJobs.DisplayMember = "Id";
            this.listBoxCarJobs.FormattingEnabled = true;
            this.listBoxCarJobs.ItemHeight = 16;
            this.listBoxCarJobs.Location = new System.Drawing.Point(33, 340);
            this.listBoxCarJobs.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.listBoxCarJobs.Name = "listBoxCarJobs";
            this.listBoxCarJobs.Size = new System.Drawing.Size(273, 244);
            this.listBoxCarJobs.TabIndex = 5;
            this.listBoxCarJobs.ValueMember = "Id";
            this.listBoxCarJobs.SelectedIndexChanged += new System.EventHandler(this.listBoxCarJobs_SelectedIndexChanged);
            // 
            // buttonAddJobToCar
            // 
            this.buttonAddJobToCar.Location = new System.Drawing.Point(655, 82);
            this.buttonAddJobToCar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonAddJobToCar.Name = "buttonAddJobToCar";
            this.buttonAddJobToCar.Size = new System.Drawing.Size(120, 49);
            this.buttonAddJobToCar.TabIndex = 4;
            this.buttonAddJobToCar.Text = "Prideti darba";
            this.buttonAddJobToCar.UseVisualStyleBackColor = true;
            this.buttonAddJobToCar.Click += new System.EventHandler(this.buttonAddJobToCar_Click);
            // 
            // listBoxServices
            // 
            this.listBoxServices.DisplayMember = "Id";
            this.listBoxServices.FormattingEnabled = true;
            this.listBoxServices.ItemHeight = 16;
            this.listBoxServices.Location = new System.Drawing.Point(627, 340);
            this.listBoxServices.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.listBoxServices.Name = "listBoxServices";
            this.listBoxServices.Size = new System.Drawing.Size(273, 244);
            this.listBoxServices.TabIndex = 2;
            this.listBoxServices.ValueMember = "Id";
            // 
            // listBoxArrivedCars
            // 
            this.listBoxArrivedCars.DisplayMember = "\"Id\"";
            this.listBoxArrivedCars.FormattingEnabled = true;
            this.listBoxArrivedCars.ItemHeight = 16;
            this.listBoxArrivedCars.Location = new System.Drawing.Point(33, 26);
            this.listBoxArrivedCars.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.listBoxArrivedCars.Name = "listBoxArrivedCars";
            this.listBoxArrivedCars.Size = new System.Drawing.Size(273, 276);
            this.listBoxArrivedCars.TabIndex = 1;
            this.listBoxArrivedCars.ValueMember = "Id";
            this.listBoxArrivedCars.SelectedIndexChanged += new System.EventHandler(this.listBoxCars_SelectedIndexChanged);
            // 
            // dataControllerTab
            // 
            this.dataControllerTab.Controls.Add(this.buttonShowBusyness);
            this.dataControllerTab.Controls.Add(this.buttonUpdateData);
            this.dataControllerTab.Controls.Add(this.buttonAddNew);
            this.dataControllerTab.Controls.Add(this.labelRodyti);
            this.dataControllerTab.Controls.Add(this.labelIeskoti);
            this.dataControllerTab.Controls.Add(this.listBoxDuomenys);
            this.dataControllerTab.Controls.Add(this.textBoxSearch);
            this.dataControllerTab.Controls.Add(this.comboBoxData);
            this.dataControllerTab.Location = new System.Drawing.Point(4, 25);
            this.dataControllerTab.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dataControllerTab.Name = "dataControllerTab";
            this.dataControllerTab.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dataControllerTab.Size = new System.Drawing.Size(1023, 645);
            this.dataControllerTab.TabIndex = 7;
            this.dataControllerTab.Text = "Duomenų valdyklė";
            this.dataControllerTab.UseVisualStyleBackColor = true;
            // 
            // buttonShowBusyness
            // 
            this.buttonShowBusyness.Location = new System.Drawing.Point(892, 7);
            this.buttonShowBusyness.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonShowBusyness.Name = "buttonShowBusyness";
            this.buttonShowBusyness.Size = new System.Drawing.Size(167, 60);
            this.buttonShowBusyness.TabIndex = 7;
            this.buttonShowBusyness.Text = "Rodyti užimtumą";
            this.buttonShowBusyness.UseVisualStyleBackColor = true;
            this.buttonShowBusyness.Click += new System.EventHandler(this.buttonShowBusyness_Click);
            // 
            // buttonUpdateData
            // 
            this.buttonUpdateData.Location = new System.Drawing.Point(543, 154);
            this.buttonUpdateData.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonUpdateData.Name = "buttonUpdateData";
            this.buttonUpdateData.Size = new System.Drawing.Size(152, 36);
            this.buttonUpdateData.TabIndex = 6;
            this.buttonUpdateData.Text = "Atnaujinti duomenis";
            this.buttonUpdateData.UseVisualStyleBackColor = true;
            this.buttonUpdateData.Click += new System.EventHandler(this.buttonUpdateData_Click);
            // 
            // buttonAddNew
            // 
            this.buttonAddNew.Location = new System.Drawing.Point(543, 111);
            this.buttonAddNew.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonAddNew.Name = "buttonAddNew";
            this.buttonAddNew.Size = new System.Drawing.Size(152, 36);
            this.buttonAddNew.TabIndex = 5;
            this.buttonAddNew.Text = "Pridėti naują...";
            this.buttonAddNew.UseVisualStyleBackColor = true;
            this.buttonAddNew.Click += new System.EventHandler(this.buttonAddNew_Click);
            // 
            // labelRodyti
            // 
            this.labelRodyti.AutoSize = true;
            this.labelRodyti.Location = new System.Drawing.Point(137, 81);
            this.labelRodyti.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelRodyti.Name = "labelRodyti";
            this.labelRodyti.Size = new System.Drawing.Size(52, 17);
            this.labelRodyti.TabIndex = 4;
            this.labelRodyti.Text = "Rodyti:";
            // 
            // labelIeskoti
            // 
            this.labelIeskoti.AutoSize = true;
            this.labelIeskoti.Location = new System.Drawing.Point(137, 495);
            this.labelIeskoti.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelIeskoti.Name = "labelIeskoti";
            this.labelIeskoti.Size = new System.Drawing.Size(52, 17);
            this.labelIeskoti.TabIndex = 3;
            this.labelIeskoti.Text = "Ieškoti:";
            // 
            // listBoxDuomenys
            // 
            this.listBoxDuomenys.DisplayMember = "Id";
            this.listBoxDuomenys.FormattingEnabled = true;
            this.listBoxDuomenys.ItemHeight = 16;
            this.listBoxDuomenys.Location = new System.Drawing.Point(141, 111);
            this.listBoxDuomenys.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.listBoxDuomenys.Name = "listBoxDuomenys";
            this.listBoxDuomenys.Size = new System.Drawing.Size(392, 372);
            this.listBoxDuomenys.TabIndex = 2;
            this.listBoxDuomenys.ValueMember = "Id";
            // 
            // textBoxSearch
            // 
            this.textBoxSearch.Location = new System.Drawing.Point(200, 491);
            this.textBoxSearch.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBoxSearch.Name = "textBoxSearch";
            this.textBoxSearch.Size = new System.Drawing.Size(333, 22);
            this.textBoxSearch.TabIndex = 1;
            this.textBoxSearch.TextChanged += new System.EventHandler(this.textBoxSearch_TextChanged);
            // 
            // comboBoxData
            // 
            this.comboBoxData.FormattingEnabled = true;
            this.comboBoxData.Items.AddRange(new object[] {
            "Darbuotojai",
            "Klientai",
            "Automobiliai",
            "Paslaugos",
            "Taisymai",
            "Dokumentai",
            "Detalės"});
            this.comboBoxData.Location = new System.Drawing.Point(199, 78);
            this.comboBoxData.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.comboBoxData.Name = "comboBoxData";
            this.comboBoxData.Size = new System.Drawing.Size(335, 24);
            this.comboBoxData.TabIndex = 0;
            this.comboBoxData.SelectedIndexChanged += new System.EventHandler(this.comboBoxData_SelectedIndexChanged);
            // 
            // SystemLogTab
            // 
            this.SystemLogTab.Controls.Add(this.richTextBox1);
            this.SystemLogTab.Location = new System.Drawing.Point(4, 25);
            this.SystemLogTab.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.SystemLogTab.Name = "SystemLogTab";
            this.SystemLogTab.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.SystemLogTab.Size = new System.Drawing.Size(1023, 645);
            this.SystemLogTab.TabIndex = 10;
            this.SystemLogTab.Text = "Sistemos žurnalas";
            this.SystemLogTab.UseVisualStyleBackColor = true;
            // 
            // richTextBox1
            // 
            this.richTextBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBox1.Location = new System.Drawing.Point(8, 7);
            this.richTextBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(1089, 602);
            this.richTextBox1.TabIndex = 0;
            this.richTextBox1.Text = "2016-11-09  16:03 Vartotojas Darbuotojas1 prisijungė į sistemą\n2016-11-09  16:04 " +
    "Užregistruotas naujas klientas Vardenis Pavardenis, Valst. Nr. AAA000\n\n";
            // 
            // tabGenerator
            // 
            this.tabGenerator.Controls.Add(this.buttonGenerateOrder);
            this.tabGenerator.Controls.Add(this.buttonGenerateGuarantee);
            this.tabGenerator.Controls.Add(this.buttonGenerateBill);
            this.tabGenerator.Controls.Add(this.labelKlientaiGen);
            this.tabGenerator.Controls.Add(this.listBoxGeneratorClients);
            this.tabGenerator.Location = new System.Drawing.Point(4, 25);
            this.tabGenerator.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabGenerator.Name = "tabGenerator";
            this.tabGenerator.Size = new System.Drawing.Size(1023, 645);
            this.tabGenerator.TabIndex = 11;
            this.tabGenerator.Text = "Dokumentų generatorius";
            this.tabGenerator.UseVisualStyleBackColor = true;
            // 
            // buttonGenerateOrder
            // 
            this.buttonGenerateOrder.Location = new System.Drawing.Point(387, 160);
            this.buttonGenerateOrder.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonGenerateOrder.Name = "buttonGenerateOrder";
            this.buttonGenerateOrder.Size = new System.Drawing.Size(279, 48);
            this.buttonGenerateOrder.TabIndex = 4;
            this.buttonGenerateOrder.Text = "Generuoti užsakymo dokumentą";
            this.buttonGenerateOrder.UseVisualStyleBackColor = true;
            this.buttonGenerateOrder.Click += new System.EventHandler(this.buttonGenerateOrder_Click);
            // 
            // buttonGenerateGuarantee
            // 
            this.buttonGenerateGuarantee.Location = new System.Drawing.Point(387, 107);
            this.buttonGenerateGuarantee.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonGenerateGuarantee.Name = "buttonGenerateGuarantee";
            this.buttonGenerateGuarantee.Size = new System.Drawing.Size(279, 46);
            this.buttonGenerateGuarantee.TabIndex = 3;
            this.buttonGenerateGuarantee.Text = "Generuoti garantiją";
            this.buttonGenerateGuarantee.UseVisualStyleBackColor = true;
            this.buttonGenerateGuarantee.Click += new System.EventHandler(this.buttonGenerateGuarantee_Click);
            // 
            // buttonGenerateBill
            // 
            this.buttonGenerateBill.Location = new System.Drawing.Point(387, 50);
            this.buttonGenerateBill.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonGenerateBill.Name = "buttonGenerateBill";
            this.buttonGenerateBill.Size = new System.Drawing.Size(279, 49);
            this.buttonGenerateBill.TabIndex = 2;
            this.buttonGenerateBill.Text = "Generuoti sąskaitą faktūrą";
            this.buttonGenerateBill.UseVisualStyleBackColor = true;
            this.buttonGenerateBill.Click += new System.EventHandler(this.buttonGenerateBill_Click);
            // 
            // labelKlientaiGen
            // 
            this.labelKlientaiGen.AutoSize = true;
            this.labelKlientaiGen.Location = new System.Drawing.Point(179, 28);
            this.labelKlientaiGen.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelKlientaiGen.Name = "labelKlientaiGen";
            this.labelKlientaiGen.Size = new System.Drawing.Size(54, 17);
            this.labelKlientaiGen.TabIndex = 1;
            this.labelKlientaiGen.Text = "Klientai";
            // 
            // listBoxGeneratorClients
            // 
            this.listBoxGeneratorClients.DisplayMember = "Id";
            this.listBoxGeneratorClients.FormattingEnabled = true;
            this.listBoxGeneratorClients.ItemHeight = 16;
            this.listBoxGeneratorClients.Location = new System.Drawing.Point(44, 50);
            this.listBoxGeneratorClients.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.listBoxGeneratorClients.Name = "listBoxGeneratorClients";
            this.listBoxGeneratorClients.Size = new System.Drawing.Size(333, 356);
            this.listBoxGeneratorClients.TabIndex = 0;
            this.listBoxGeneratorClients.ValueMember = "Id";
            // 
            // newsFeed
            // 
            this.newsFeed.AccessibleName = "";
            this.newsFeed.Controls.Add(this.deleteDiscountButton);
            this.newsFeed.Controls.Add(this.addDiscountButton);
            this.newsFeed.Controls.Add(this.discountTextLabel);
            this.newsFeed.Controls.Add(this.discountsListBox);
            this.newsFeed.Location = new System.Drawing.Point(4, 25);
            this.newsFeed.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.newsFeed.Name = "newsFeed";
            this.newsFeed.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.newsFeed.Size = new System.Drawing.Size(1023, 645);
            this.newsFeed.TabIndex = 12;
            this.newsFeed.Text = "naujienos ir nuolaidos";
            this.newsFeed.UseVisualStyleBackColor = true;
            // 
            // deleteDiscountButton
            // 
            this.deleteDiscountButton.Location = new System.Drawing.Point(471, 154);
            this.deleteDiscountButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.deleteDiscountButton.Name = "deleteDiscountButton";
            this.deleteDiscountButton.Size = new System.Drawing.Size(236, 57);
            this.deleteDiscountButton.TabIndex = 3;
            this.deleteDiscountButton.Text = "ištrinti nuolaidą";
            this.deleteDiscountButton.UseVisualStyleBackColor = true;
            // 
            // addDiscountButton
            // 
            this.addDiscountButton.Location = new System.Drawing.Point(471, 60);
            this.addDiscountButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.addDiscountButton.Name = "addDiscountButton";
            this.addDiscountButton.Size = new System.Drawing.Size(236, 57);
            this.addDiscountButton.TabIndex = 2;
            this.addDiscountButton.Text = "Pridėti nuolaidą";
            this.addDiscountButton.UseVisualStyleBackColor = true;
            this.addDiscountButton.Click += new System.EventHandler(this.addDiscountButton_Click);
            // 
            // discountTextLabel
            // 
            this.discountTextLabel.AutoSize = true;
            this.discountTextLabel.Location = new System.Drawing.Point(208, 27);
            this.discountTextLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.discountTextLabel.Name = "discountTextLabel";
            this.discountTextLabel.Size = new System.Drawing.Size(71, 17);
            this.discountTextLabel.TabIndex = 1;
            this.discountTextLabel.Text = "Nuolaidos";
            // 
            // discountsListBox
            // 
            this.discountsListBox.FormattingEnabled = true;
            this.discountsListBox.ItemHeight = 16;
            this.discountsListBox.Location = new System.Drawing.Point(88, 60);
            this.discountsListBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.discountsListBox.Name = "discountsListBox";
            this.discountsListBox.Size = new System.Drawing.Size(303, 420);
            this.discountsListBox.TabIndex = 0;
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1045, 690);
            this.Controls.Add(this.tabControl);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Mechanikas";
            this.tabControl.ResumeLayout(false);
            this.RegistrateClientTab.ResumeLayout(false);
            this.RegistrateClientTab.PerformLayout();
            this.JobsTab.ResumeLayout(false);
            this.JobsTab.PerformLayout();
            this.dataControllerTab.ResumeLayout(false);
            this.dataControllerTab.PerformLayout();
            this.SystemLogTab.ResumeLayout(false);
            this.tabGenerator.ResumeLayout(false);
            this.tabGenerator.PerformLayout();
            this.newsFeed.ResumeLayout(false);
            this.newsFeed.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.TabControl tabControl;
		private System.Windows.Forms.TabPage RegistrateClientTab;
		private System.Windows.Forms.TabPage dataControllerTab;
		private System.Windows.Forms.TabPage JobsTab;
		private System.Windows.Forms.TabPage SystemLogTab;
		private System.Windows.Forms.RichTextBox richTextBox1;
		private System.Windows.Forms.TextBox textBoxTelephone;
		private System.Windows.Forms.TextBox textBoxAddress;
		private System.Windows.Forms.Button buttonRegisterClient;
		private System.Windows.Forms.TextBox textBox2;
		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.TextBox textClient1;
		private System.Windows.Forms.TextBox textClient2;
		private System.Windows.Forms.TextBox textBoxClient1;
		private System.Windows.Forms.TextBox textBoxClient2;
		private System.Windows.Forms.ListBox listBoxArrivedCars;
		private System.Windows.Forms.ListBox listBoxCarJobs;
		private System.Windows.Forms.Button buttonAddJobToCar;
		private System.Windows.Forms.ListBox listBoxServices;
		private System.Windows.Forms.Button buttonFinishJob;
		private System.Windows.Forms.ErrorProvider errorProvider;
		private System.Windows.Forms.Button buttonDeleteJob;
		private System.Windows.Forms.ListBox listBoxJobEmployees;
		private System.Windows.Forms.Button buttonAddEmployeeToJob;
		private System.Windows.Forms.ListBox listBoxEmployees;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.ListBox listBoxClients;
		private System.Windows.Forms.Button buttonAddNewCar;
		private System.Windows.Forms.TextBox textBox16;
		private System.Windows.Forms.TextBox textBox15;
		private System.Windows.Forms.TextBox textBox14;
		private System.Windows.Forms.TextBox textBox10;
		private System.Windows.Forms.TextBox textBox11;
		private System.Windows.Forms.TextBox textBox12;
		private System.Windows.Forms.TextBox textBox13;
		private System.Windows.Forms.TextBox textBoxCarYear;
		private System.Windows.Forms.TextBox textBoxCarEngine;
		private System.Windows.Forms.TextBox textBoxCarRun;
		private System.Windows.Forms.TextBox textBoxCarModel;
		private System.Windows.Forms.TextBox textBoxCarMake;
		private System.Windows.Forms.TextBox textBoxCarPlate;
		private System.Windows.Forms.TextBox textBoxCarVIN;
        private System.Windows.Forms.ComboBox comboBoxClientType;
        private System.Windows.Forms.ComboBox comboBoxData;
        private System.Windows.Forms.TextBox textBoxSearch;
        private System.Windows.Forms.ListBox listBoxDuomenys;
        private System.Windows.Forms.Label labelIeskoti;
        private System.Windows.Forms.Label labelRodyti;
        private System.Windows.Forms.Button buttonAddNew;
        private System.Windows.Forms.Button buttonUpdateData;
        private System.Windows.Forms.Button buttonShowBusyness;
        private System.Windows.Forms.Label labelKlientai;
        private System.Windows.Forms.Label labelIeskotiKliento;
        private System.Windows.Forms.TextBox textBoxSearchClient;
        private System.Windows.Forms.TabPage tabGenerator;
        private System.Windows.Forms.Button buttonGenerateOrder;
        private System.Windows.Forms.Button buttonGenerateGuarantee;
        private System.Windows.Forms.Button buttonGenerateBill;
        private System.Windows.Forms.Label labelKlientaiGen;
        private System.Windows.Forms.ListBox listBoxGeneratorClients;
        private System.Windows.Forms.TabPage newsFeed;
        private System.Windows.Forms.Button deleteDiscountButton;
        private System.Windows.Forms.Button addDiscountButton;
        private System.Windows.Forms.Label discountTextLabel;
        private System.Windows.Forms.ListBox discountsListBox;
    }
}

