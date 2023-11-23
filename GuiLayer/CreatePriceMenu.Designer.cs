namespace BowlingDesktopClient.GuiLayer
{
    partial class CreatePriceMenu
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
            button1 = new Button();
            label1 = new Label();
            labelWeekday = new Label();
            textBoxNormalPrice = new TextBox();
            textBoxWeekday = new TextBox();
            labelProcessText = new Label();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(178, 180);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 0;
            button1.Text = "Gem Pris";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(186, 59);
            label1.Name = "label1";
            label1.Size = new Size(86, 20);
            label1.TabIndex = 1;
            label1.Text = "Normal Pris";
            // 
            // labelWeekday
            // 
            labelWeekday.AutoSize = true;
            labelWeekday.Location = new Point(180, 124);
            labelWeekday.Name = "labelWeekday";
            labelWeekday.Size = new Size(95, 20);
            labelWeekday.TabIndex = 3;
            labelWeekday.Text = "Dag på ugen";
            // 
            // textBoxNormalPrice
            // 
            textBoxNormalPrice.Location = new Point(164, 82);
            textBoxNormalPrice.Name = "textBoxNormalPrice";
            textBoxNormalPrice.Size = new Size(125, 27);
            textBoxNormalPrice.TabIndex = 4;
            // 
            // textBoxWeekday
            // 
            textBoxWeekday.Location = new Point(164, 147);
            textBoxWeekday.Name = "textBoxWeekday";
            textBoxWeekday.Size = new Size(125, 27);
            textBoxWeekday.TabIndex = 6;
            // 
            // labelProcessText
            // 
            labelProcessText.AutoSize = true;
            labelProcessText.Location = new Point(178, 233);
            labelProcessText.Name = "labelProcessText";
            labelProcessText.Size = new Size(93, 20);
            labelProcessText.TabIndex = 7;
            labelProcessText.Text = "Good or Not";
            // 
            // CreatePriceMenu
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(462, 399);
            Controls.Add(labelProcessText);
            Controls.Add(textBoxWeekday);
            Controls.Add(textBoxNormalPrice);
            Controls.Add(labelWeekday);
            Controls.Add(label1);
            Controls.Add(button1);
            Name = "CreatePriceMenu";
            Text = "CreatePriceMenu";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Label label1;
        private Label labelWeekday;
        private TextBox textBoxNormalPrice;
        private TextBox textBoxWeekday;
        private Label labelProcessText;
    }
}