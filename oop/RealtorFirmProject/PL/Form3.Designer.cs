
namespace PL
{
    partial class Form3
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
            this.listView1 = new System.Windows.Forms.ListView();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.deleteProperty = new System.Windows.Forms.Button();
            this.addProperty = new System.Windows.Forms.Button();
            this.saleComboBox = new System.Windows.Forms.ComboBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.propertyTypeFilter = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.priceFilter = new System.Windows.Forms.TextBox();
            this.districtFilter = new System.Windows.Forms.TextBox();
            this.cityFilter = new System.Windows.Forms.TextBox();
            this.bedroomsFilter = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.comboBoxSorting = new System.Windows.Forms.ComboBox();
            this.sortButton = new System.Windows.Forms.Button();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // listView1
            // 
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(12, 27);
            this.listView1.Name = "listView1";
            this.listView1.ShowGroups = false;
            this.listView1.Size = new System.Drawing.Size(414, 330);
            this.listView1.TabIndex = 5;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.List;
            this.listView1.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(136, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Property from the Database";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.sortButton);
            this.groupBox2.Controls.Add(this.comboBoxSorting);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.deleteProperty);
            this.groupBox2.Controls.Add(this.addProperty);
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
            this.groupBox2.Location = new System.Drawing.Point(434, 27);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(354, 330);
            this.groupBox2.TabIndex = 20;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Information";
            // 
            // deleteProperty
            // 
            this.deleteProperty.Location = new System.Drawing.Point(180, 188);
            this.deleteProperty.Name = "deleteProperty";
            this.deleteProperty.Size = new System.Drawing.Size(167, 23);
            this.deleteProperty.TabIndex = 31;
            this.deleteProperty.Text = "Delete property";
            this.deleteProperty.UseVisualStyleBackColor = true;
            this.deleteProperty.Click += new System.EventHandler(this.deleteProperty_Click);
            // 
            // addProperty
            // 
            this.addProperty.Location = new System.Drawing.Point(6, 188);
            this.addProperty.Name = "addProperty";
            this.addProperty.Size = new System.Drawing.Size(168, 23);
            this.addProperty.TabIndex = 30;
            this.addProperty.Text = "Add property";
            this.addProperty.UseVisualStyleBackColor = true;
            this.addProperty.Click += new System.EventHandler(this.addProperty_Click);
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
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(177, 125);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(51, 13);
            this.label14.TabIndex = 28;
            this.label14.Text = "Sale/rent";
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
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(177, 78);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(39, 13);
            this.label12.TabIndex = 26;
            this.label12.Text = "District";
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
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(177, 31);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(107, 13);
            this.label10.TabIndex = 24;
            this.label10.Text = "Quantity of bedrooms";
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
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 31);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(69, 13);
            this.label9.TabIndex = 18;
            this.label9.Text = "Property type";
            // 
            // priceFilter
            // 
            this.priceFilter.Location = new System.Drawing.Point(6, 141);
            this.priceFilter.Name = "priceFilter";
            this.priceFilter.Size = new System.Drawing.Size(168, 20);
            this.priceFilter.TabIndex = 22;
            // 
            // districtFilter
            // 
            this.districtFilter.Location = new System.Drawing.Point(179, 94);
            this.districtFilter.Name = "districtFilter";
            this.districtFilter.Size = new System.Drawing.Size(168, 20);
            this.districtFilter.TabIndex = 21;
            // 
            // cityFilter
            // 
            this.cityFilter.Location = new System.Drawing.Point(6, 94);
            this.cityFilter.Name = "cityFilter";
            this.cityFilter.Size = new System.Drawing.Size(168, 20);
            this.cityFilter.TabIndex = 20;
            // 
            // bedroomsFilter
            // 
            this.bedroomsFilter.Location = new System.Drawing.Point(180, 47);
            this.bedroomsFilter.Name = "bedroomsFilter";
            this.bedroomsFilter.Size = new System.Drawing.Size(168, 20);
            this.bedroomsFilter.TabIndex = 19;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(7, 244);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(40, 13);
            this.label8.TabIndex = 21;
            this.label8.Text = "Sort by";
            // 
            // comboBoxSorting
            // 
            this.comboBoxSorting.FormattingEnabled = true;
            this.comboBoxSorting.Items.AddRange(new object[] {
            "bedrooms",
            "price"});
            this.comboBoxSorting.Location = new System.Drawing.Point(68, 241);
            this.comboBoxSorting.Name = "comboBoxSorting";
            this.comboBoxSorting.Size = new System.Drawing.Size(193, 21);
            this.comboBoxSorting.TabIndex = 21;
            // 
            // sortButton
            // 
            this.sortButton.Location = new System.Drawing.Point(267, 239);
            this.sortButton.Name = "sortButton";
            this.sortButton.Size = new System.Drawing.Size(81, 23);
            this.sortButton.TabIndex = 32;
            this.sortButton.Text = "Sort";
            this.sortButton.UseVisualStyleBackColor = true;
            this.sortButton.Click += new System.EventHandler(this.sortButton_Click);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 370);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.listView1);
            this.Name = "Form3";
            this.Text = "Property menu";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form3_FormClosed);
            this.Load += new System.EventHandler(this.Form3_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button deleteProperty;
        private System.Windows.Forms.Button addProperty;
        private System.Windows.Forms.ComboBox saleComboBox;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox propertyTypeFilter;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox priceFilter;
        private System.Windows.Forms.TextBox districtFilter;
        private System.Windows.Forms.TextBox cityFilter;
        private System.Windows.Forms.TextBox bedroomsFilter;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox comboBoxSorting;
        private System.Windows.Forms.Button sortButton;
    }
}