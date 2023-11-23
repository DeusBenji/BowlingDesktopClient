namespace BowlingDesktopClient.GuiLayer
{
    partial class Main
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
            this.buttonBooking = new System.Windows.Forms.Button();
            this.buttonPrice = new System.Windows.Forms.Button();
            this.buttonLane = new System.Windows.Forms.Button();
            this.buttonCustomer = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonBooking
            // 
            this.buttonBooking.Location = new System.Drawing.Point(38, 48);
            this.buttonBooking.Name = "buttonBooking";
            this.buttonBooking.Size = new System.Drawing.Size(135, 23);
            this.buttonBooking.TabIndex = 0;
            this.buttonBooking.Text = "Booking";
            this.buttonBooking.UseVisualStyleBackColor = true;
            this.buttonBooking.Click += new System.EventHandler(this.buttonBooking_Click);
            // 
            // buttonPrice
            // 
            this.buttonPrice.Location = new System.Drawing.Point(38, 77);
            this.buttonPrice.Name = "buttonPrice";
            this.buttonPrice.Size = new System.Drawing.Size(135, 23);
            this.buttonPrice.TabIndex = 1;
            this.buttonPrice.Text = "Pris";
            this.buttonPrice.UseVisualStyleBackColor = true;
            this.buttonPrice.Click += new System.EventHandler(this.buttonPrice_Click);
            // 
            // buttonLane
            // 
            this.buttonLane.Location = new System.Drawing.Point(38, 106);
            this.buttonLane.Name = "buttonLane";
            this.buttonLane.Size = new System.Drawing.Size(135, 23);
            this.buttonLane.TabIndex = 2;
            this.buttonLane.Text = "Baner";
            this.buttonLane.UseVisualStyleBackColor = true;
            this.buttonLane.Click += new System.EventHandler(this.buttonLane_Click);
            // 
            // buttonCustomer
            // 
            this.buttonCustomer.Location = new System.Drawing.Point(38, 135);
            this.buttonCustomer.Name = "buttonCustomer";
            this.buttonCustomer.Size = new System.Drawing.Size(135, 23);
            this.buttonCustomer.TabIndex = 3;
            this.buttonCustomer.Text = "Kunder";
            this.buttonCustomer.UseVisualStyleBackColor = true;
            this.buttonCustomer.Click += new System.EventHandler(this.buttonCustomer_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonCustomer);
            this.Controls.Add(this.buttonLane);
            this.Controls.Add(this.buttonPrice);
            this.Controls.Add(this.buttonBooking);
            this.Name = "Main";
            this.Text = "Main";
            this.ResumeLayout(false);

        }

        #endregion

        private Button buttonBooking;
        private Button buttonPrice;
        private Button buttonLane;
        private Button buttonCustomer;
    }
}