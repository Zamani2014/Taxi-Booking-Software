namespace TaxiServiceDempAppWithSQLServer
{
    partial class TripOrderForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.customerTblBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.taxiServicesDBDataSet = new TaxiServiceDempAppWithSQLServer.TaxiServicesDBDataSet();
            this.customerTblTableAdapter = new TaxiServiceDempAppWithSQLServer.TaxiServicesDBDataSetTableAdapters.CustomerTblTableAdapter();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.driverTblBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.driverTblTableAdapter = new TaxiServiceDempAppWithSQLServer.TaxiServicesDBDataSetTableAdapters.DriverTblTableAdapter();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.reservationPersonTblBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.reservationPersonTblTableAdapter = new TaxiServiceDempAppWithSQLServer.TaxiServicesDBDataSetTableAdapters.ReservationPersonTblTableAdapter();
            this.tripsTblBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tripsTblTableAdapter = new TaxiServiceDempAppWithSQLServer.TaxiServicesDBDataSetTableAdapters.TripsTblTableAdapter();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.customerTblBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.taxiServicesDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.driverTblBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.reservationPersonTblBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tripsTblBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "نام مسافر :";
            // 
            // comboBox1
            // 
            this.comboBox1.DataSource = this.customerTblBindingSource;
            this.comboBox1.DisplayMember = "LastName";
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(76, 6);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 1;
            this.comboBox1.ValueMember = "ID";
            // 
            // customerTblBindingSource
            // 
            this.customerTblBindingSource.DataMember = "CustomerTbl";
            this.customerTblBindingSource.DataSource = this.taxiServicesDBDataSet;
            // 
            // taxiServicesDBDataSet
            // 
            this.taxiServicesDBDataSet.DataSetName = "TaxiServicesDBDataSet";
            this.taxiServicesDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // customerTblTableAdapter
            // 
            this.customerTblTableAdapter.ClearBeforeFill = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(264, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "نام راننده :";
            // 
            // comboBox2
            // 
            this.comboBox2.DataSource = this.driverTblBindingSource;
            this.comboBox2.DisplayMember = "LastName";
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(326, 6);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(121, 21);
            this.comboBox2.TabIndex = 3;
            this.comboBox2.ValueMember = "ID";
            // 
            // driverTblBindingSource
            // 
            this.driverTblBindingSource.DataMember = "DriverTbl";
            this.driverTblBindingSource.DataSource = this.taxiServicesDBDataSet;
            // 
            // driverTblTableAdapter
            // 
            this.driverTblTableAdapter.ClearBeforeFill = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(520, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "نام رزرویشن :";
            // 
            // comboBox3
            // 
            this.comboBox3.DataSource = this.reservationPersonTblBindingSource;
            this.comboBox3.DisplayMember = "LastName";
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Location = new System.Drawing.Point(596, 6);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(121, 21);
            this.comboBox3.TabIndex = 5;
            this.comboBox3.ValueMember = "ID";
            // 
            // reservationPersonTblBindingSource
            // 
            this.reservationPersonTblBindingSource.DataMember = "ReservationPersonTbl";
            this.reservationPersonTblBindingSource.DataSource = this.taxiServicesDBDataSet;
            // 
            // reservationPersonTblTableAdapter
            // 
            this.reservationPersonTblTableAdapter.ClearBeforeFill = true;
            // 
            // tripsTblBindingSource
            // 
            this.tripsTblBindingSource.DataMember = "TripsTbl";
            this.tripsTblBindingSource.DataSource = this.taxiServicesDBDataSet;
            // 
            // tripsTblTableAdapter
            // 
            this.tripsTblTableAdapter.ClearBeforeFill = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 77);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(36, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "مبداء :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 137);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(37, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "مقصد :";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(76, 74);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(641, 20);
            this.textBox1.TabIndex = 8;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(76, 134);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(641, 20);
            this.textBox2.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 194);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(38, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "هزینه :";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(76, 191);
            this.textBox3.Name = "textBox3";
            this.textBox3.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.textBox3.Size = new System.Drawing.Size(137, 20);
            this.textBox3.TabIndex = 11;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(251, 194);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(55, 13);
            this.label7.TabIndex = 12;
            this.label7.Text = "توضیحات :";
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(312, 191);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(405, 96);
            this.richTextBox1.TabIndex = 13;
            this.richTextBox1.Text = "";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(642, 293);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 14;
            this.button1.Text = "ذخیره";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(561, 293);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 15;
            this.button2.Text = "انصراف";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // TripOrderForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(733, 326);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.comboBox3);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "TripOrderForm";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "فرم ثبت سفر";
            this.Load += new System.EventHandler(this.TripOrderForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.customerTblBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.taxiServicesDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.driverTblBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.reservationPersonTblBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tripsTblBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox1;
        private TaxiServicesDBDataSet taxiServicesDBDataSet;
        private System.Windows.Forms.BindingSource customerTblBindingSource;
        private TaxiServicesDBDataSetTableAdapters.CustomerTblTableAdapter customerTblTableAdapter;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.BindingSource driverTblBindingSource;
        private TaxiServicesDBDataSetTableAdapters.DriverTblTableAdapter driverTblTableAdapter;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.BindingSource reservationPersonTblBindingSource;
        private TaxiServicesDBDataSetTableAdapters.ReservationPersonTblTableAdapter reservationPersonTblTableAdapter;
        private System.Windows.Forms.BindingSource tripsTblBindingSource;
        private TaxiServicesDBDataSetTableAdapters.TripsTblTableAdapter tripsTblTableAdapter;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}