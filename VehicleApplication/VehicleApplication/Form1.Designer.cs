namespace VehicleApplication
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel1 = new System.Windows.Forms.Panel();
            this.pctrBoxPanel = new System.Windows.Forms.PictureBox();
            this.lblBusOnline = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblReturnDateHour = new System.Windows.Forms.Label();
            this.lblGoingDateHour = new System.Windows.Forms.Label();
            this.mskdReturnHour = new System.Windows.Forms.MaskedTextBox();
            this.mskdReturnDate = new System.Windows.Forms.MaskedTextBox();
            this.lblReturnHour = new System.Windows.Forms.Label();
            this.lblReturnDate = new System.Windows.Forms.Label();
            this.chckRoundTrip = new System.Windows.Forms.CheckBox();
            this.lblChngCity = new System.Windows.Forms.Label();
            this.btnChange = new System.Windows.Forms.Button();
            this.mskdBoxHour = new System.Windows.Forms.MaskedTextBox();
            this.mskdBoxDate = new System.Windows.Forms.MaskedTextBox();
            this.cmbBoxToWhere = new System.Windows.Forms.ComboBox();
            this.cmbBoxFromW = new System.Windows.Forms.ComboBox();
            this.lblDeparture4 = new System.Windows.Forms.Label();
            this.lbldeparture3 = new System.Windows.Forms.Label();
            this.lbldeparture2 = new System.Windows.Forms.Label();
            this.lbldeparture1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtBoxNameSurn = new System.Windows.Forms.TextBox();
            this.mskdBoxPhone = new System.Windows.Forms.MaskedTextBox();
            this.mskdBoxTC = new System.Windows.Forms.MaskedTextBox();
            this.btnInsert = new System.Windows.Forms.Button();
            this.lblPass3 = new System.Windows.Forms.Label();
            this.lblPass2 = new System.Windows.Forms.Label();
            this.lblPassenger1 = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctrBoxPanel)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.pctrBoxPanel);
            this.panel1.Controls.Add(this.lblBusOnline);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(752, 100);
            this.panel1.TabIndex = 0;
            // 
            // pctrBoxPanel
            // 
            this.pctrBoxPanel.Image = ((System.Drawing.Image)(resources.GetObject("pctrBoxPanel.Image")));
            this.pctrBoxPanel.Location = new System.Drawing.Point(497, 3);
            this.pctrBoxPanel.Name = "pctrBoxPanel";
            this.pctrBoxPanel.Size = new System.Drawing.Size(172, 97);
            this.pctrBoxPanel.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pctrBoxPanel.TabIndex = 1;
            this.pctrBoxPanel.TabStop = false;
            // 
            // lblBusOnline
            // 
            this.lblBusOnline.AutoSize = true;
            this.lblBusOnline.BackColor = System.Drawing.Color.Gold;
            this.lblBusOnline.Font = new System.Drawing.Font("Chiller", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBusOnline.Location = new System.Drawing.Point(108, 33);
            this.lblBusOnline.Name = "lblBusOnline";
            this.lblBusOnline.Size = new System.Drawing.Size(362, 43);
            this.lblBusOnline.TabIndex = 0;
            this.lblBusOnline.Text = "Bus online ticket sales panel";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblReturnDateHour);
            this.groupBox1.Controls.Add(this.lblGoingDateHour);
            this.groupBox1.Controls.Add(this.mskdReturnHour);
            this.groupBox1.Controls.Add(this.mskdReturnDate);
            this.groupBox1.Controls.Add(this.lblReturnHour);
            this.groupBox1.Controls.Add(this.lblReturnDate);
            this.groupBox1.Controls.Add(this.chckRoundTrip);
            this.groupBox1.Controls.Add(this.lblChngCity);
            this.groupBox1.Controls.Add(this.btnChange);
            this.groupBox1.Controls.Add(this.mskdBoxHour);
            this.groupBox1.Controls.Add(this.mskdBoxDate);
            this.groupBox1.Controls.Add(this.cmbBoxToWhere);
            this.groupBox1.Controls.Add(this.cmbBoxFromW);
            this.groupBox1.Controls.Add(this.lblDeparture4);
            this.groupBox1.Controls.Add(this.lbldeparture3);
            this.groupBox1.Controls.Add(this.lbldeparture2);
            this.groupBox1.Controls.Add(this.lbldeparture1);
            this.groupBox1.Location = new System.Drawing.Point(12, 118);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(453, 235);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Trip Information";
            // 
            // lblReturnDateHour
            // 
            this.lblReturnDateHour.AutoSize = true;
            this.lblReturnDateHour.Location = new System.Drawing.Point(263, 130);
            this.lblReturnDateHour.Name = "lblReturnDateHour";
            this.lblReturnDateHour.Size = new System.Drawing.Size(133, 18);
            this.lblReturnDateHour.TabIndex = 16;
            this.lblReturnDateHour.Text = "Return Date-Hour";
            this.lblReturnDateHour.Visible = false;
            // 
            // lblGoingDateHour
            // 
            this.lblGoingDateHour.AutoSize = true;
            this.lblGoingDateHour.Location = new System.Drawing.Point(103, 130);
            this.lblGoingDateHour.Name = "lblGoingDateHour";
            this.lblGoingDateHour.Size = new System.Drawing.Size(125, 18);
            this.lblGoingDateHour.TabIndex = 15;
            this.lblGoingDateHour.Text = "Going Date-Hour";
            // 
            // mskdReturnHour
            // 
            this.mskdReturnHour.Location = new System.Drawing.Point(314, 198);
            this.mskdReturnHour.Mask = "00:00";
            this.mskdReturnHour.Name = "mskdReturnHour";
            this.mskdReturnHour.Size = new System.Drawing.Size(110, 25);
            this.mskdReturnHour.TabIndex = 14;
            this.mskdReturnHour.ValidatingType = typeof(System.DateTime);
            this.mskdReturnHour.Visible = false;
            // 
            // mskdReturnDate
            // 
            this.mskdReturnDate.Location = new System.Drawing.Point(314, 155);
            this.mskdReturnDate.Mask = "00/00/0000";
            this.mskdReturnDate.Name = "mskdReturnDate";
            this.mskdReturnDate.Size = new System.Drawing.Size(110, 25);
            this.mskdReturnDate.TabIndex = 13;
            this.mskdReturnDate.ValidatingType = typeof(System.DateTime);
            this.mskdReturnDate.Visible = false;
            // 
            // lblReturnHour
            // 
            this.lblReturnHour.AutoSize = true;
            this.lblReturnHour.Location = new System.Drawing.Point(258, 198);
            this.lblReturnHour.Name = "lblReturnHour";
            this.lblReturnHour.Size = new System.Drawing.Size(50, 18);
            this.lblReturnHour.TabIndex = 12;
            this.lblReturnHour.Text = "Hour:";
            this.lblReturnHour.Visible = false;
            // 
            // lblReturnDate
            // 
            this.lblReturnDate.AutoSize = true;
            this.lblReturnDate.Location = new System.Drawing.Point(263, 158);
            this.lblReturnDate.Name = "lblReturnDate";
            this.lblReturnDate.Size = new System.Drawing.Size(45, 18);
            this.lblReturnDate.TabIndex = 11;
            this.lblReturnDate.Text = "Date:";
            this.lblReturnDate.Visible = false;
            // 
            // chckRoundTrip
            // 
            this.chckRoundTrip.AutoSize = true;
            this.chckRoundTrip.Location = new System.Drawing.Point(121, 20);
            this.chckRoundTrip.Name = "chckRoundTrip";
            this.chckRoundTrip.Size = new System.Drawing.Size(98, 22);
            this.chckRoundTrip.TabIndex = 10;
            this.chckRoundTrip.Text = "round-trip";
            this.chckRoundTrip.UseVisualStyleBackColor = true;
            this.chckRoundTrip.CheckedChanged += new System.EventHandler(this.chckRoundTrip_CheckedChanged);
            // 
            // lblChngCity
            // 
            this.lblChngCity.AutoSize = true;
            this.lblChngCity.Location = new System.Drawing.Point(411, 21);
            this.lblChngCity.Name = "lblChngCity";
            this.lblChngCity.Size = new System.Drawing.Size(36, 18);
            this.lblChngCity.TabIndex = 9;
            this.lblChngCity.Text = "City";
            this.lblChngCity.Visible = false;
            // 
            // btnChange
            // 
            this.btnChange.Location = new System.Drawing.Point(245, 67);
            this.btnChange.Name = "btnChange";
            this.btnChange.Size = new System.Drawing.Size(63, 36);
            this.btnChange.TabIndex = 8;
            this.btnChange.Text = "<>";
            this.btnChange.UseVisualStyleBackColor = true;
            this.btnChange.Click += new System.EventHandler(this.btnChange_Click);
            // 
            // mskdBoxHour
            // 
            this.mskdBoxHour.Location = new System.Drawing.Point(106, 194);
            this.mskdBoxHour.Mask = "00:00";
            this.mskdBoxHour.Name = "mskdBoxHour";
            this.mskdBoxHour.Size = new System.Drawing.Size(122, 25);
            this.mskdBoxHour.TabIndex = 7;
            this.mskdBoxHour.ValidatingType = typeof(System.DateTime);
            this.mskdBoxHour.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.mskdBoxHour_MaskInputRejected);
            // 
            // mskdBoxDate
            // 
            this.mskdBoxDate.Location = new System.Drawing.Point(106, 151);
            this.mskdBoxDate.Mask = "00/00/0000";
            this.mskdBoxDate.Name = "mskdBoxDate";
            this.mskdBoxDate.Size = new System.Drawing.Size(122, 25);
            this.mskdBoxDate.TabIndex = 6;
            this.mskdBoxDate.ValidatingType = typeof(System.DateTime);
            // 
            // cmbBoxToWhere
            // 
            this.cmbBoxToWhere.FormattingEnabled = true;
            this.cmbBoxToWhere.Items.AddRange(new object[] {
            "Amsterdam",
            "New York",
            "Paris",
            "İzmir",
            "Ankara",
            "İstanbul"});
            this.cmbBoxToWhere.Location = new System.Drawing.Point(106, 94);
            this.cmbBoxToWhere.Name = "cmbBoxToWhere";
            this.cmbBoxToWhere.Size = new System.Drawing.Size(120, 26);
            this.cmbBoxToWhere.TabIndex = 5;
            // 
            // cmbBoxFromW
            // 
            this.cmbBoxFromW.FormattingEnabled = true;
            this.cmbBoxFromW.Items.AddRange(new object[] {
            "İstanbul",
            "Ankara",
            "İzmir",
            "Erzincan",
            "Adana",
            "Antalya",
            "Ordu",
            "Samsun",
            "Muğla"});
            this.cmbBoxFromW.Location = new System.Drawing.Point(106, 50);
            this.cmbBoxFromW.Name = "cmbBoxFromW";
            this.cmbBoxFromW.Size = new System.Drawing.Size(120, 26);
            this.cmbBoxFromW.TabIndex = 4;
            // 
            // lblDeparture4
            // 
            this.lblDeparture4.AutoSize = true;
            this.lblDeparture4.Location = new System.Drawing.Point(50, 194);
            this.lblDeparture4.Name = "lblDeparture4";
            this.lblDeparture4.Size = new System.Drawing.Size(50, 18);
            this.lblDeparture4.TabIndex = 3;
            this.lblDeparture4.Text = "Hour:";
            // 
            // lbldeparture3
            // 
            this.lbldeparture3.AutoSize = true;
            this.lbldeparture3.Location = new System.Drawing.Point(55, 154);
            this.lbldeparture3.Name = "lbldeparture3";
            this.lbldeparture3.Size = new System.Drawing.Size(45, 18);
            this.lbldeparture3.TabIndex = 2;
            this.lbldeparture3.Text = "Date:";
            // 
            // lbldeparture2
            // 
            this.lbldeparture2.AutoSize = true;
            this.lbldeparture2.Location = new System.Drawing.Point(24, 94);
            this.lbldeparture2.Name = "lbldeparture2";
            this.lbldeparture2.Size = new System.Drawing.Size(80, 18);
            this.lbldeparture2.TabIndex = 1;
            this.lbldeparture2.Text = "To Where:";
            // 
            // lbldeparture1
            // 
            this.lbldeparture1.AutoSize = true;
            this.lbldeparture1.Location = new System.Drawing.Point(3, 53);
            this.lbldeparture1.Name = "lbldeparture1";
            this.lbldeparture1.Size = new System.Drawing.Size(101, 18);
            this.lbldeparture1.TabIndex = 0;
            this.lbldeparture1.Text = "From Where:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtBoxNameSurn);
            this.groupBox2.Controls.Add(this.mskdBoxPhone);
            this.groupBox2.Controls.Add(this.mskdBoxTC);
            this.groupBox2.Controls.Add(this.btnInsert);
            this.groupBox2.Controls.Add(this.lblPass3);
            this.groupBox2.Controls.Add(this.lblPass2);
            this.groupBox2.Controls.Add(this.lblPassenger1);
            this.groupBox2.Location = new System.Drawing.Point(471, 118);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(293, 235);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Pessenger Information";
            // 
            // txtBoxNameSurn
            // 
            this.txtBoxNameSurn.Location = new System.Drawing.Point(138, 39);
            this.txtBoxNameSurn.Name = "txtBoxNameSurn";
            this.txtBoxNameSurn.Size = new System.Drawing.Size(136, 25);
            this.txtBoxNameSurn.TabIndex = 10;
            // 
            // mskdBoxPhone
            // 
            this.mskdBoxPhone.Location = new System.Drawing.Point(138, 123);
            this.mskdBoxPhone.Mask = "(999) 000-0000";
            this.mskdBoxPhone.Name = "mskdBoxPhone";
            this.mskdBoxPhone.Size = new System.Drawing.Size(134, 25);
            this.mskdBoxPhone.TabIndex = 9;
            // 
            // mskdBoxTC
            // 
            this.mskdBoxTC.Location = new System.Drawing.Point(138, 81);
            this.mskdBoxTC.Mask = "00000000000";
            this.mskdBoxTC.Name = "mskdBoxTC";
            this.mskdBoxTC.Size = new System.Drawing.Size(134, 25);
            this.mskdBoxTC.TabIndex = 8;
            // 
            // btnInsert
            // 
            this.btnInsert.Location = new System.Drawing.Point(138, 169);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Size = new System.Drawing.Size(134, 33);
            this.btnInsert.TabIndex = 7;
            this.btnInsert.Text = "Insert";
            this.btnInsert.UseVisualStyleBackColor = true;
            this.btnInsert.Click += new System.EventHandler(this.btnInsert_Click);
            // 
            // lblPass3
            // 
            this.lblPass3.AutoSize = true;
            this.lblPass3.Location = new System.Drawing.Point(73, 126);
            this.lblPass3.Name = "lblPass3";
            this.lblPass3.Size = new System.Drawing.Size(56, 18);
            this.lblPass3.TabIndex = 6;
            this.lblPass3.Text = "Phone:";
            // 
            // lblPass2
            // 
            this.lblPass2.AutoSize = true;
            this.lblPass2.Location = new System.Drawing.Point(74, 85);
            this.lblPass2.Name = "lblPass2";
            this.lblPass2.Size = new System.Drawing.Size(55, 18);
            this.lblPass2.TabIndex = 5;
            this.lblPass2.Text = "TC ID:";
            // 
            // lblPassenger1
            // 
            this.lblPassenger1.AutoSize = true;
            this.lblPassenger1.Location = new System.Drawing.Point(8, 44);
            this.lblPassenger1.Name = "lblPassenger1";
            this.lblPassenger1.Size = new System.Drawing.Size(121, 18);
            this.lblPassenger1.TabIndex = 4;
            this.lblPassenger1.Text = "Name Surname:";
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.HorizontalScrollbar = true;
            this.listBox1.ItemHeight = 18;
            this.listBox1.Location = new System.Drawing.Point(12, 359);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(752, 94);
            this.listBox1.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(786, 469);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Georgia", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctrBoxPanel)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pctrBoxPanel;
        private System.Windows.Forms.Label lblBusOnline;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.MaskedTextBox mskdBoxHour;
        private System.Windows.Forms.MaskedTextBox mskdBoxDate;
        private System.Windows.Forms.ComboBox cmbBoxToWhere;
        private System.Windows.Forms.ComboBox cmbBoxFromW;
        private System.Windows.Forms.Label lblDeparture4;
        private System.Windows.Forms.Label lbldeparture3;
        private System.Windows.Forms.Label lbldeparture2;
        private System.Windows.Forms.Label lbldeparture1;
        private System.Windows.Forms.MaskedTextBox mskdBoxTC;
        private System.Windows.Forms.Button btnInsert;
        private System.Windows.Forms.Label lblPass3;
        private System.Windows.Forms.Label lblPass2;
        private System.Windows.Forms.Label lblPassenger1;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.TextBox txtBoxNameSurn;
        private System.Windows.Forms.MaskedTextBox mskdBoxPhone;
        private System.Windows.Forms.Label lblChngCity;
        private System.Windows.Forms.Button btnChange;
        private System.Windows.Forms.CheckBox chckRoundTrip;
        private System.Windows.Forms.MaskedTextBox mskdReturnHour;
        private System.Windows.Forms.MaskedTextBox mskdReturnDate;
        private System.Windows.Forms.Label lblReturnHour;
        private System.Windows.Forms.Label lblReturnDate;
        private System.Windows.Forms.Label lblReturnDateHour;
        private System.Windows.Forms.Label lblGoingDateHour;
    }
}

