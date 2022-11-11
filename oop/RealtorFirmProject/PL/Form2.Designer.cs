
namespace PL
{
    partial class Form2
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
            this.label1 = new System.Windows.Forms.Label();
            this.listView1 = new System.Windows.Forms.ListView();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.sortButton = new System.Windows.Forms.Button();
            this.preferenceButton = new System.Windows.Forms.Button();
            this.comboBoxSorting = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.DeleteButton = new System.Windows.Forms.Button();
            this.AddButton = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.numberTextBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.emailTextBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.bankAccountTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SurnameTextBox = new System.Windows.Forms.TextBox();
            this.NameTextBox = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.bedroomsFilter = new System.Windows.Forms.TextBox();
            this.cityFilter = new System.Windows.Forms.TextBox();
            this.districtFilter = new System.Windows.Forms.TextBox();
            this.priceFilter = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.propertyTypeFilter = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.saleComboBox = new System.Windows.Forms.ComboBox();
            this.findPropertyFromPreferences = new System.Windows.Forms.Button();
            this.showPreferencesButton = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(360, 117);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 0;
            // 
            // listView1
            // 
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(13, 33);
            this.listView1.Name = "listView1";
            this.listView1.ShowGroups = false;
            this.listView1.Size = new System.Drawing.Size(414, 537);
            this.listView1.TabIndex = 1;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.List;
            this.listView1.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(146, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Customers from the Database";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.sortButton);
            this.groupBox1.Controls.Add(this.comboBoxSorting);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.DeleteButton);
            this.groupBox1.Controls.Add(this.AddButton);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.numberTextBox);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.emailTextBox);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.bankAccountTextBox);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.SurnameTextBox);
            this.groupBox1.Controls.Add(this.NameTextBox);
            this.groupBox1.Location = new System.Drawing.Point(434, 33);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(354, 313);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Information";
            // 
            // sortButton
            // 
            this.sortButton.Location = new System.Drawing.Point(267, 272);
            this.sortButton.Name = "sortButton";
            this.sortButton.Size = new System.Drawing.Size(81, 23);
            this.sortButton.TabIndex = 17;
            this.sortButton.Text = "Sort";
            this.sortButton.UseVisualStyleBackColor = true;
            this.sortButton.Click += new System.EventHandler(this.sortButton_Click);
            // 
            // preferenceButton
            // 
            this.preferenceButton.Location = new System.Drawing.Point(240, 188);
            this.preferenceButton.Name = "preferenceButton";
            this.preferenceButton.Size = new System.Drawing.Size(107, 23);
            this.preferenceButton.TabIndex = 16;
            this.preferenceButton.Text = "Add preferences";
            this.preferenceButton.UseVisualStyleBackColor = true;
            this.preferenceButton.Click += new System.EventHandler(this.preferenceButton_Click);
            // 
            // comboBoxSorting
            // 
            this.comboBoxSorting.FormattingEnabled = true;
            this.comboBoxSorting.Items.AddRange(new object[] {
            "firstName",
            "lastName",
            "bankAccountNumber"});
            this.comboBoxSorting.Location = new System.Drawing.Point(67, 274);
            this.comboBoxSorting.Name = "comboBoxSorting";
            this.comboBoxSorting.Size = new System.Drawing.Size(193, 21);
            this.comboBoxSorting.TabIndex = 14;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(7, 277);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(40, 13);
            this.label8.TabIndex = 12;
            this.label8.Text = "Sort by";
            // 
            // DeleteButton
            // 
            this.DeleteButton.Location = new System.Drawing.Point(179, 216);
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.Size = new System.Drawing.Size(168, 23);
            this.DeleteButton.TabIndex = 11;
            this.DeleteButton.Text = "Delete customer";
            this.DeleteButton.UseVisualStyleBackColor = true;
            this.DeleteButton.Click += new System.EventHandler(this.DeleteButton_Click);
            // 
            // AddButton
            // 
            this.AddButton.Location = new System.Drawing.Point(6, 216);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(168, 23);
            this.AddButton.TabIndex = 10;
            this.AddButton.Text = "Add customer";
            this.AddButton.UseVisualStyleBackColor = true;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(7, 152);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(96, 13);
            this.label7.TabIndex = 9;
            this.label7.Text = "Telephone number";
            // 
            // numberTextBox
            // 
            this.numberTextBox.Location = new System.Drawing.Point(6, 168);
            this.numberTextBox.Name = "numberTextBox";
            this.numberTextBox.Size = new System.Drawing.Size(168, 20);
            this.numberTextBox.TabIndex = 8;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(176, 97);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(32, 13);
            this.label6.TabIndex = 7;
            this.label6.Text = "Email";
            // 
            // emailTextBox
            // 
            this.emailTextBox.Location = new System.Drawing.Point(180, 113);
            this.emailTextBox.Name = "emailTextBox";
            this.emailTextBox.Size = new System.Drawing.Size(168, 20);
            this.emailTextBox.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(7, 97);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(112, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Bank account number";
            // 
            // bankAccountTextBox
            // 
            this.bankAccountTextBox.Location = new System.Drawing.Point(6, 113);
            this.bankAccountTextBox.Name = "bankAccountTextBox";
            this.bankAccountTextBox.Size = new System.Drawing.Size(168, 20);
            this.bankAccountTextBox.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(177, 42);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Surname";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 42);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Name";
            // 
            // SurnameTextBox
            // 
            this.SurnameTextBox.Location = new System.Drawing.Point(179, 61);
            this.SurnameTextBox.Name = "SurnameTextBox";
            this.SurnameTextBox.Size = new System.Drawing.Size(169, 20);
            this.SurnameTextBox.TabIndex = 1;
            // 
            // NameTextBox
            // 
            this.NameTextBox.Location = new System.Drawing.Point(7, 61);
            this.NameTextBox.Name = "NameTextBox";
            this.NameTextBox.Size = new System.Drawing.Size(168, 20);
            this.NameTextBox.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.showPreferencesButton);
            this.groupBox2.Controls.Add(this.findPropertyFromPreferences);
            this.groupBox2.Controls.Add(this.saleComboBox);
            this.groupBox2.Controls.Add(this.label14);
            this.groupBox2.Controls.Add(this.label13);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.propertyTypeFilter);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.priceFilter);
            this.groupBox2.Controls.Add(this.districtFilter);
            this.groupBox2.Controls.Add(this.cityFilter);
            this.groupBox2.Controls.Add(this.bedroomsFilter);
            this.groupBox2.Controls.Add(this.preferenceButton);
            this.groupBox2.Location = new System.Drawing.Point(434, 353);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(354, 217);
            this.groupBox2.TabIndex = 19;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Customer preferences";
            // 
            // bedroomsFilter
            // 
            this.bedroomsFilter.Location = new System.Drawing.Point(180, 47);
            this.bedroomsFilter.Name = "bedroomsFilter";
            this.bedroomsFilter.Size = new System.Drawing.Size(168, 20);
            this.bedroomsFilter.TabIndex = 19;
            // 
            // cityFilter
            // 
            this.cityFilter.Location = new System.Drawing.Point(6, 94);
            this.cityFilter.Name = "cityFilter";
            this.cityFilter.Size = new System.Drawing.Size(168, 20);
            this.cityFilter.TabIndex = 20;
            // 
            // districtFilter
            // 
            this.districtFilter.Location = new System.Drawing.Point(179, 94);
            this.districtFilter.Name = "districtFilter";
            this.districtFilter.Size = new System.Drawing.Size(168, 20);
            this.districtFilter.TabIndex = 21;
            // 
            // priceFilter
            // 
            this.priceFilter.Location = new System.Drawing.Point(6, 141);
            this.priceFilter.Name = "priceFilter";
            this.priceFilter.Size = new System.Drawing.Size(168, 20);
            this.priceFilter.TabIndex = 22;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 31);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(69, 13);
            this.label9.TabIndex = 18;
            this.label9.Text = "Property type";
            // 
            // propertyTypeFilter
            // 
            this.propertyTypeFilter.FormattingEnabled = true;
            this.propertyTypeFilter.Items.AddRange(new object[] {
            "flat",
            "house"});
            this.propertyTypeFilter.Location = new System.Drawing.Point(6, 47);
            this.propertyTypeFilter.Name = "propertyTypeFilter";
            this.propertyTypeFilter.Size = new System.Drawing.Size(168, 21);
            this.propertyTypeFilter.TabIndex = 18;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(177, 31);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(107, 13);
            this.label10.TabIndex = 24;
            this.label10.Text = "Quantity of bedrooms";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(6, 78);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(24, 13);
            this.label11.TabIndex = 25;
            this.label11.Text = "City";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(177, 78);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(39, 13);
            this.label12.TabIndex = 26;
            this.label12.Text = "District";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(7, 125);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(34, 13);
            this.label13.TabIndex = 27;
            this.label13.Text = "Price ";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(177, 125);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(51, 13);
            this.label14.TabIndex = 28;
            this.label14.Text = "Sale/rent";
            // 
            // saleComboBox
            // 
            this.saleComboBox.FormattingEnabled = true;
            this.saleComboBox.Items.AddRange(new object[] {
            "sale",
            "rent"});
            this.saleComboBox.Location = new System.Drawing.Point(179, 141);
            this.saleComboBox.Name = "saleComboBox";
            this.saleComboBox.Size = new System.Drawing.Size(168, 21);
            this.saleComboBox.TabIndex = 29;
            // 
            // findPropertyFromPreferences
            // 
            this.findPropertyFromPreferences.Location = new System.Drawing.Point(6, 188);
            this.findPropertyFromPreferences.Name = "findPropertyFromPreferences";
            this.findPropertyFromPreferences.Size = new System.Drawing.Size(113, 23);
            this.findPropertyFromPreferences.TabIndex = 30;
            this.findPropertyFromPreferences.Text = "Find property";
            this.findPropertyFromPreferences.UseVisualStyleBackColor = true;
            this.findPropertyFromPreferences.Click += new System.EventHandler(this.findPropertyFromPreferences_Click);
            // 
            // showPreferencesButton
            // 
            this.showPreferencesButton.Location = new System.Drawing.Point(125, 188);
            this.showPreferencesButton.Name = "showPreferencesButton";
            this.showPreferencesButton.Size = new System.Drawing.Size(109, 23);
            this.showPreferencesButton.TabIndex = 31;
            this.showPreferencesButton.Text = "Show preferences";
            this.showPreferencesButton.UseVisualStyleBackColor = true;
            this.showPreferencesButton.Click += new System.EventHandler(this.showPreferencesButton_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 582);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.label1);
            this.Name = "Form2";
            this.Text = "Customer menu";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form2_FormClosed);
            this.Load += new System.EventHandler(this.Form2_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox SurnameTextBox;
        private System.Windows.Forms.TextBox NameTextBox;
        private System.Windows.Forms.TextBox bankAccountTextBox;
        private System.Windows.Forms.Button DeleteButton;
        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox numberTextBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox emailTextBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox comboBoxSorting;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button preferenceButton;
        private System.Windows.Forms.Button sortButton;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox priceFilter;
        private System.Windows.Forms.TextBox districtFilter;
        private System.Windows.Forms.TextBox cityFilter;
        private System.Windows.Forms.TextBox bedroomsFilter;
        private System.Windows.Forms.ComboBox propertyTypeFilter;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.ComboBox saleComboBox;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Button findPropertyFromPreferences;
        private System.Windows.Forms.Button showPreferencesButton;
    }
}