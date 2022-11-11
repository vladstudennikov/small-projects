
namespace PL
{
    partial class Form1
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openCustomersMenuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openPropertyMenuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.customersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openCustomersMenuToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.findCustomerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.propertyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openPropertyMenuToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.deletePropertyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.customersToolStripMenuItem,
            this.propertyToolStripMenuItem,
            this.aboutToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openCustomersMenuToolStripMenuItem,
            this.openPropertyMenuToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // openCustomersMenuToolStripMenuItem
            // 
            this.openCustomersMenuToolStripMenuItem.Name = "openCustomersMenuToolStripMenuItem";
            this.openCustomersMenuToolStripMenuItem.Size = new System.Drawing.Size(195, 22);
            this.openCustomersMenuToolStripMenuItem.Text = "Open customers menu";
            this.openCustomersMenuToolStripMenuItem.Click += new System.EventHandler(this.openCustomersMenuToolStripMenuItem_Click);
            // 
            // openPropertyMenuToolStripMenuItem
            // 
            this.openPropertyMenuToolStripMenuItem.Name = "openPropertyMenuToolStripMenuItem";
            this.openPropertyMenuToolStripMenuItem.Size = new System.Drawing.Size(195, 22);
            this.openPropertyMenuToolStripMenuItem.Text = "Open property menu";
            this.openPropertyMenuToolStripMenuItem.Click += new System.EventHandler(this.openPropertyMenuToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(195, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // customersToolStripMenuItem
            // 
            this.customersToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openCustomersMenuToolStripMenuItem1,
            this.findCustomerToolStripMenuItem});
            this.customersToolStripMenuItem.Name = "customersToolStripMenuItem";
            this.customersToolStripMenuItem.Size = new System.Drawing.Size(76, 20);
            this.customersToolStripMenuItem.Text = "Customers";
            // 
            // openCustomersMenuToolStripMenuItem1
            // 
            this.openCustomersMenuToolStripMenuItem1.Name = "openCustomersMenuToolStripMenuItem1";
            this.openCustomersMenuToolStripMenuItem1.Size = new System.Drawing.Size(195, 22);
            this.openCustomersMenuToolStripMenuItem1.Text = "Open customers menu";
            this.openCustomersMenuToolStripMenuItem1.Click += new System.EventHandler(this.openCustomersMenuToolStripMenuItem1_Click);
            // 
            // findCustomerToolStripMenuItem
            // 
            this.findCustomerToolStripMenuItem.Name = "findCustomerToolStripMenuItem";
            this.findCustomerToolStripMenuItem.Size = new System.Drawing.Size(195, 22);
            this.findCustomerToolStripMenuItem.Text = "Find customer";
            this.findCustomerToolStripMenuItem.Click += new System.EventHandler(this.findCustomerToolStripMenuItem_Click);
            // 
            // propertyToolStripMenuItem
            // 
            this.propertyToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openPropertyMenuToolStripMenuItem1,
            this.deletePropertyToolStripMenuItem});
            this.propertyToolStripMenuItem.Name = "propertyToolStripMenuItem";
            this.propertyToolStripMenuItem.Size = new System.Drawing.Size(64, 20);
            this.propertyToolStripMenuItem.Text = "Property";
            // 
            // openPropertyMenuToolStripMenuItem1
            // 
            this.openPropertyMenuToolStripMenuItem1.Name = "openPropertyMenuToolStripMenuItem1";
            this.openPropertyMenuToolStripMenuItem1.Size = new System.Drawing.Size(185, 22);
            this.openPropertyMenuToolStripMenuItem1.Text = "Open property menu";
            this.openPropertyMenuToolStripMenuItem1.Click += new System.EventHandler(this.openPropertyMenuToolStripMenuItem1_Click);
            // 
            // deletePropertyToolStripMenuItem
            // 
            this.deletePropertyToolStripMenuItem.Name = "deletePropertyToolStripMenuItem";
            this.deletePropertyToolStripMenuItem.Size = new System.Drawing.Size(185, 22);
            this.deletePropertyToolStripMenuItem.Text = "Find property";
            this.deletePropertyToolStripMenuItem.Click += new System.EventHandler(this.deletePropertyToolStripMenuItem_Click);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            this.helpToolStripMenuItem.Click += new System.EventHandler(this.helpToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Main menu";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openCustomersMenuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openPropertyMenuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem customersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openCustomersMenuToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem findCustomerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem propertyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openPropertyMenuToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem deletePropertyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
    }
}

