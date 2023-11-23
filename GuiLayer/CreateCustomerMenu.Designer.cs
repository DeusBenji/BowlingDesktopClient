namespace BowlingDesktopClient.GuiLayer
{
    partial class CreateCustomerMenu
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
            textBoxLastName = new TextBox();
            textBoxPhone = new TextBox();
            textBoxFirstName = new TextBox();
            textBoxEmail = new TextBox();
            label1 = new Label();
            label2 = new Label();
            Efternavn = new Label();
            label5 = new Label();
            groupBox1 = new GroupBox();
            label3 = new Label();
            buttonCreateCustomer = new Button();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // textBoxLastName
            // 
            textBoxLastName.Location = new Point(121, 121);
            textBoxLastName.Name = "textBoxLastName";
            textBoxLastName.Size = new Size(125, 27);
            textBoxLastName.TabIndex = 0;
            // 
            // textBoxPhone
            // 
            textBoxPhone.Location = new Point(121, 227);
            textBoxPhone.Name = "textBoxPhone";
            textBoxPhone.Size = new Size(125, 27);
            textBoxPhone.TabIndex = 1;
            // 
            // textBoxFirstName
            // 
            textBoxFirstName.Location = new Point(121, 68);
            textBoxFirstName.Name = "textBoxFirstName";
            textBoxFirstName.Size = new Size(125, 27);
            textBoxFirstName.TabIndex = 2;
            // 
            // textBoxEmail
            // 
            textBoxEmail.Location = new Point(121, 174);
            textBoxEmail.Name = "textBoxEmail";
            textBoxEmail.Size = new Size(125, 27);
            textBoxEmail.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(155, 45);
            label1.Name = "label1";
            label1.Size = new Size(61, 20);
            label1.TabIndex = 4;
            label1.Text = "Fornavn";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(155, 151);
            label2.Name = "label2";
            label2.Size = new Size(46, 20);
            label2.TabIndex = 5;
            label2.Text = "Email";
            // 
            // Efternavn
            // 
            Efternavn.AutoSize = true;
            Efternavn.Location = new Point(155, 98);
            Efternavn.Name = "Efternavn";
            Efternavn.Size = new Size(71, 20);
            Efternavn.TabIndex = 6;
            Efternavn.Text = "Efternavn";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(350, 25);
            label5.Name = "label5";
            label5.Size = new Size(0, 20);
            label5.TabIndex = 8;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(buttonCreateCustomer);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(textBoxFirstName);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(Efternavn);
            groupBox1.Controls.Add(textBoxLastName);
            groupBox1.Controls.Add(textBoxEmail);
            groupBox1.Controls.Add(textBoxPhone);
            groupBox1.Location = new Point(90, 48);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(383, 367);
            groupBox1.TabIndex = 9;
            groupBox1.TabStop = false;
            groupBox1.Text = "Opret Kunde";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(121, 204);
            label3.Name = "label3";
            label3.Size = new Size(118, 20);
            label3.TabIndex = 7;
            label3.Text = "  Mobil Nummer";
            // 
            // buttonCreateCustomer
            // 
            buttonCreateCustomer.Location = new Point(124, 260);
            buttonCreateCustomer.Name = "buttonCreateCustomer";
            buttonCreateCustomer.Size = new Size(122, 28);
            buttonCreateCustomer.TabIndex = 8;
            buttonCreateCustomer.Text = "Opret Kunde";
            buttonCreateCustomer.UseVisualStyleBackColor = true;
            buttonCreateCustomer.Click += buttonCreateCustomer_Click;
            // 
            // CreateCustomerMenu
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(577, 466);
            Controls.Add(groupBox1);
            Controls.Add(label5);
            Name = "CreateCustomerMenu";
            Text = "CreateCustomerMenu";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBoxLastName;
        private TextBox textBoxPhone;
        private TextBox textBoxFirstName;
        private TextBox textBoxEmail;
        private Label label1;
        private Label label2;
        private Label Efternavn;
        private Label label5;
        private GroupBox groupBox1;
        private Label label3;
        private Button buttonCreateCustomer;
    }
}