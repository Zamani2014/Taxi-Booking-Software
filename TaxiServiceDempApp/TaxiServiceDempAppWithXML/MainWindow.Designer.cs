namespace TaxiServiceDempAppWithSQLServer
{
    partial class MainWindow
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.RegisterOrderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.searchToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.CustomersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.DriversToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.CarsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.TripsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ReservationPersonToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ExitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.RegisterOrderToolStripMenuItem,
            this.searchToolStripMenuItem,
            this.CustomersToolStripMenuItem,
            this.DriversToolStripMenuItem,
            this.CarsToolStripMenuItem,
            this.TripsToolStripMenuItem,
            this.ReservationPersonToolStripMenuItem,
            this.ExitToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(784, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // RegisterOrderToolStripMenuItem
            // 
            this.RegisterOrderToolStripMenuItem.Name = "RegisterOrderToolStripMenuItem";
            this.RegisterOrderToolStripMenuItem.Size = new System.Drawing.Size(62, 20);
            this.RegisterOrderToolStripMenuItem.Text = "ثبت سفر";
            this.RegisterOrderToolStripMenuItem.Click += new System.EventHandler(this.RegisterOrderToolStripMenuItem_Click);
            // 
            // searchToolStripMenuItem
            // 
            this.searchToolStripMenuItem.Name = "searchToolStripMenuItem";
            this.searchToolStripMenuItem.Size = new System.Drawing.Size(86, 20);
            this.searchToolStripMenuItem.Text = "جستجوی سفر";
            this.searchToolStripMenuItem.Click += new System.EventHandler(this.searchToolStripMenuItem_Click);
            // 
            // CustomersToolStripMenuItem
            // 
            this.CustomersToolStripMenuItem.Name = "CustomersToolStripMenuItem";
            this.CustomersToolStripMenuItem.Size = new System.Drawing.Size(113, 20);
            this.CustomersToolStripMenuItem.Text = "مسافران / مشتریان";
            this.CustomersToolStripMenuItem.Click += new System.EventHandler(this.CustomersToolStripMenuItem_Click);
            // 
            // DriversToolStripMenuItem
            // 
            this.DriversToolStripMenuItem.Name = "DriversToolStripMenuItem";
            this.DriversToolStripMenuItem.Size = new System.Drawing.Size(57, 20);
            this.DriversToolStripMenuItem.Text = "رانندگان";
            this.DriversToolStripMenuItem.Click += new System.EventHandler(this.DriversToolStripMenuItem_Click);
            // 
            // CarsToolStripMenuItem
            // 
            this.CarsToolStripMenuItem.Name = "CarsToolStripMenuItem";
            this.CarsToolStripMenuItem.Size = new System.Drawing.Size(69, 20);
            this.CarsToolStripMenuItem.Text = "اتومبیل ها";
            this.CarsToolStripMenuItem.Click += new System.EventHandler(this.CarsToolStripMenuItem_Click);
            // 
            // TripsToolStripMenuItem
            // 
            this.TripsToolStripMenuItem.Name = "TripsToolStripMenuItem";
            this.TripsToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.TripsToolStripMenuItem.Text = "سفرها";
            this.TripsToolStripMenuItem.Click += new System.EventHandler(this.TripsToolStripMenuItem_Click);
            // 
            // ReservationPersonToolStripMenuItem
            // 
            this.ReservationPersonToolStripMenuItem.Name = "ReservationPersonToolStripMenuItem";
            this.ReservationPersonToolStripMenuItem.Size = new System.Drawing.Size(74, 20);
            this.ReservationPersonToolStripMenuItem.Text = "رزرویشن ها";
            this.ReservationPersonToolStripMenuItem.Click += new System.EventHandler(this.ReservationPersonToolStripMenuItem_Click);
            // 
            // ExitToolStripMenuItem
            // 
            this.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem";
            this.ExitToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.ExitToolStripMenuItem.Text = "خروج";
            this.ExitToolStripMenuItem.Click += new System.EventHandler(this.ExitToolStripMenuItem_Click);
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainWindow";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.Text = "سامانه رزرو تاکسی سرویس / بانک اطلاعاتی فایل XML";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem RegisterOrderToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem CustomersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem DriversToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem CarsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem TripsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ReservationPersonToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ExitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem searchToolStripMenuItem;
    }
}

