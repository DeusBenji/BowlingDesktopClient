namespace BowlingDesktopClient.GuiLayer
{
    partial class BookingMenu
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.labelProcessBooking = new System.Windows.Forms.Label();
            this.textBoxFindBy = new System.Windows.Forms.TextBox();
            this.buttonFindAll = new System.Windows.Forms.Button();
            this.buttonFindCustomerByPhone = new System.Windows.Forms.Button();
            this.listBoxBookings = new System.Windows.Forms.ListBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.monthCalendar2 = new System.Windows.Forms.MonthCalendar();
            this.maskedTextBoxSetBookingDate = new System.Windows.Forms.MaskedTextBox();
            this.labelProcessCreateBooking = new System.Windows.Forms.Label();
            this.labelProcessSaved = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxHoursToPlay = new System.Windows.Forms.TextBox();
            this.textBoxPlayers = new System.Windows.Forms.TextBox();
            this.textBoxCustomerPhone = new System.Windows.Forms.TextBox();
            this.buttonCreateBooking = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.textBoxDeleteBooking = new System.Windows.Forms.TextBox();
            this.buttonDeleteBooking = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.labelProcessBooking);
            this.groupBox1.Controls.Add(this.textBoxFindBy);
            this.groupBox1.Controls.Add(this.buttonFindAll);
            this.groupBox1.Controls.Add(this.buttonFindCustomerByPhone);
            this.groupBox1.Controls.Add(this.listBoxBookings);
            this.groupBox1.Location = new System.Drawing.Point(14, 16);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Size = new System.Drawing.Size(1045, 568);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Find Bookinger";
            // 
            // labelProcessBooking
            // 
            this.labelProcessBooking.AutoSize = true;
            this.labelProcessBooking.Location = new System.Drawing.Point(7, 531);
            this.labelProcessBooking.Name = "labelProcessBooking";
            this.labelProcessBooking.Size = new System.Drawing.Size(93, 20);
            this.labelProcessBooking.TabIndex = 4;
            this.labelProcessBooking.Text = "Good or Not";
            // 
            // textBoxFindBy
            // 
            this.textBoxFindBy.Location = new System.Drawing.Point(7, 44);
            this.textBoxFindBy.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBoxFindBy.Name = "textBoxFindBy";
            this.textBoxFindBy.Size = new System.Drawing.Size(213, 27);
            this.textBoxFindBy.TabIndex = 3;
            // 
            // buttonFindAll
            // 
            this.buttonFindAll.Location = new System.Drawing.Point(320, 44);
            this.buttonFindAll.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonFindAll.Name = "buttonFindAll";
            this.buttonFindAll.Size = new System.Drawing.Size(158, 31);
            this.buttonFindAll.TabIndex = 2;
            this.buttonFindAll.Text = "Find alle";
            this.buttonFindAll.UseVisualStyleBackColor = true;
            // 
            // buttonFindCustomerByPhone
            // 
            this.buttonFindCustomerByPhone.Location = new System.Drawing.Point(227, 44);
            this.buttonFindCustomerByPhone.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonFindCustomerByPhone.Name = "buttonFindCustomerByPhone";
            this.buttonFindCustomerByPhone.Size = new System.Drawing.Size(86, 31);
            this.buttonFindCustomerByPhone.TabIndex = 1;
            this.buttonFindCustomerByPhone.Text = "Søg";
            this.buttonFindCustomerByPhone.UseVisualStyleBackColor = true;
            this.buttonFindCustomerByPhone.Click += new System.EventHandler(this.buttonFindCustomerByPhone_Click_1);
            // 
            // listBoxBookings
            // 
            this.listBoxBookings.FormattingEnabled = true;
            this.listBoxBookings.ItemHeight = 20;
            this.listBoxBookings.Location = new System.Drawing.Point(7, 129);
            this.listBoxBookings.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.listBoxBookings.Name = "listBoxBookings";
            this.listBoxBookings.Size = new System.Drawing.Size(998, 384);
            this.listBoxBookings.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.monthCalendar2);
            this.groupBox2.Controls.Add(this.maskedTextBoxSetBookingDate);
            this.groupBox2.Controls.Add(this.labelProcessCreateBooking);
            this.groupBox2.Controls.Add(this.labelProcessSaved);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.textBoxHoursToPlay);
            this.groupBox2.Controls.Add(this.textBoxPlayers);
            this.groupBox2.Controls.Add(this.textBoxCustomerPhone);
            this.groupBox2.Controls.Add(this.buttonCreateBooking);
            this.groupBox2.Location = new System.Drawing.Point(1142, 13);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox2.Size = new System.Drawing.Size(429, 407);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Opret Booking";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(207, 249);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(187, 20);
            this.label4.TabIndex = 13;
            this.label4.Text = "Indtast dag/måned/år - tid";
            // 
            // monthCalendar2
            // 
            this.monthCalendar2.Location = new System.Drawing.Point(207, 33);
            this.monthCalendar2.Name = "monthCalendar2";
            this.monthCalendar2.TabIndex = 12;
            // 
            // maskedTextBoxSetBookingDate
            // 
            this.maskedTextBoxSetBookingDate.Location = new System.Drawing.Point(234, 282);
            this.maskedTextBoxSetBookingDate.Mask = "00/00/0000 00:00";
            this.maskedTextBoxSetBookingDate.Name = "maskedTextBoxSetBookingDate";
            this.maskedTextBoxSetBookingDate.Size = new System.Drawing.Size(125, 27);
            this.maskedTextBoxSetBookingDate.TabIndex = 11;
            this.maskedTextBoxSetBookingDate.ValidatingType = typeof(System.DateTime);
            // 
            // labelProcessCreateBooking
            // 
            this.labelProcessCreateBooking.AutoSize = true;
            this.labelProcessCreateBooking.Location = new System.Drawing.Point(163, 370);
            this.labelProcessCreateBooking.Name = "labelProcessCreateBooking";
            this.labelProcessCreateBooking.Size = new System.Drawing.Size(93, 20);
            this.labelProcessCreateBooking.TabIndex = 8;
            this.labelProcessCreateBooking.Text = "Good or Not";
            // 
            // labelProcessSaved
            // 
            this.labelProcessSaved.AutoSize = true;
            this.labelProcessSaved.Location = new System.Drawing.Point(115, 405);
            this.labelProcessSaved.Name = "labelProcessSaved";
            this.labelProcessSaved.Size = new System.Drawing.Size(0, 20);
            this.labelProcessSaved.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(30, 189);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(123, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "Kundes Mobil Nr.";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(47, 134);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "Antal Spillere";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(47, 79);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "Spille Timer";
            // 
            // textBoxHoursToPlay
            // 
            this.textBoxHoursToPlay.Location = new System.Drawing.Point(30, 103);
            this.textBoxHoursToPlay.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBoxHoursToPlay.Name = "textBoxHoursToPlay";
            this.textBoxHoursToPlay.Size = new System.Drawing.Size(135, 27);
            this.textBoxHoursToPlay.TabIndex = 3;
            // 
            // textBoxPlayers
            // 
            this.textBoxPlayers.Location = new System.Drawing.Point(30, 158);
            this.textBoxPlayers.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBoxPlayers.Name = "textBoxPlayers";
            this.textBoxPlayers.Size = new System.Drawing.Size(135, 27);
            this.textBoxPlayers.TabIndex = 2;
            // 
            // textBoxCustomerPhone
            // 
            this.textBoxCustomerPhone.Location = new System.Drawing.Point(30, 213);
            this.textBoxCustomerPhone.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBoxCustomerPhone.Name = "textBoxCustomerPhone";
            this.textBoxCustomerPhone.Size = new System.Drawing.Size(135, 27);
            this.textBoxCustomerPhone.TabIndex = 1;
            // 
            // buttonCreateBooking
            // 
            this.buttonCreateBooking.Location = new System.Drawing.Point(141, 335);
            this.buttonCreateBooking.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonCreateBooking.Name = "buttonCreateBooking";
            this.buttonCreateBooking.Size = new System.Drawing.Size(136, 31);
            this.buttonCreateBooking.TabIndex = 0;
            this.buttonCreateBooking.Text = "Opret Booking";
            this.buttonCreateBooking.UseVisualStyleBackColor = true;
            this.buttonCreateBooking.Click += new System.EventHandler(this.buttonCreateBooking_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.textBoxDeleteBooking);
            this.groupBox3.Controls.Add(this.buttonDeleteBooking);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Location = new System.Drawing.Point(1142, 418);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(429, 208);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Slet Booking";
            // 
            // textBoxDeleteBooking
            // 
            this.textBoxDeleteBooking.Location = new System.Drawing.Point(145, 46);
            this.textBoxDeleteBooking.Name = "textBoxDeleteBooking";
            this.textBoxDeleteBooking.Size = new System.Drawing.Size(132, 27);
            this.textBoxDeleteBooking.TabIndex = 2;
            // 
            // buttonDeleteBooking
            // 
            this.buttonDeleteBooking.Location = new System.Drawing.Point(145, 79);
            this.buttonDeleteBooking.Name = "buttonDeleteBooking";
            this.buttonDeleteBooking.Size = new System.Drawing.Size(132, 27);
            this.buttonDeleteBooking.TabIndex = 1;
            this.buttonDeleteBooking.Text = "slet booking";
            this.buttonDeleteBooking.UseVisualStyleBackColor = true;
            this.buttonDeleteBooking.Click += new System.EventHandler(this.buttonDeleteBooking_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(145, 23);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(132, 20);
            this.label5.TabIndex = 0;
            this.label5.Text = "Indtast booking ID";
            // 
            // BookingMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1707, 726);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "BookingMenu";
            this.Text = "BookingMenu";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private GroupBox groupBox1;
        private TextBox textBoxFindBy;
        private Button buttonFindAll;
        private Button buttonFindCustomerByPhone;
        private ListBox listBoxBookings;
        private Label labelProcessBooking;
        private GroupBox groupBox2;
        private Button buttonCreateBooking;
        private TextBox textBoxHoursToPlay;
        private TextBox textBoxPlayers;
        private TextBox textBoxCustomerPhone;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label labelProcessSaved;
        private Label labelProcessCreateBooking;
        private MonthCalendar monthCalendar1;
        private DateTimePicker dateTimePicker1;
        private DateTimePicker bookingDay;
        private NumericUpDown numericUpDown1;
        private MaskedTextBox maskedTextBoxSetBookingDate;
        private MonthCalendar monthCalendar2;
        private Label label4;
        private GroupBox groupBox3;
        private Label label5;
        private Button buttonDeleteBooking;
        private TextBox textBoxDeleteBooking;
    }
}