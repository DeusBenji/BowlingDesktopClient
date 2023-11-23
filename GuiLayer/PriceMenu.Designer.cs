namespace BowlingDesktopClient.GuiLayer
{
    partial class PriceMenu
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
            groupBox1 = new GroupBox();
            buttonCreatePriceMenu = new Button();
            labelProcessText = new Label();
            buttonFindAllPrices = new Button();
            button1 = new Button();
            textBoxFindBy = new TextBox();
            listBoxPrices = new ListBox();
            groupBox2 = new GroupBox();
            label3 = new Label();
            textBoxPriceId = new TextBox();
            textBoxWeekday = new TextBox();
            textBoxNormalPrice = new TextBox();
            labelWeekday = new Label();
            label1 = new Label();
            buttonSavePrice = new Button();
            groupBox3 = new GroupBox();
            buttonPriceToDelete = new Button();
            textBoxPriceToDelete = new TextBox();
            label4 = new Label();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(buttonCreatePriceMenu);
            groupBox1.Controls.Add(labelProcessText);
            groupBox1.Controls.Add(buttonFindAllPrices);
            groupBox1.Controls.Add(button1);
            groupBox1.Controls.Add(textBoxFindBy);
            groupBox1.Controls.Add(listBoxPrices);
            groupBox1.Location = new Point(17, 19);
            groupBox1.Margin = new Padding(3, 4, 3, 4);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(3, 4, 3, 4);
            groupBox1.Size = new Size(562, 565);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Find Priser";
            // 
            // buttonCreatePriceMenu
            // 
            buttonCreatePriceMenu.Location = new Point(427, 31);
            buttonCreatePriceMenu.Name = "buttonCreatePriceMenu";
            buttonCreatePriceMenu.Size = new Size(114, 29);
            buttonCreatePriceMenu.TabIndex = 5;
            buttonCreatePriceMenu.Text = "Opret Priser";
            buttonCreatePriceMenu.UseVisualStyleBackColor = true;
            buttonCreatePriceMenu.Click += buttonCreatePriceMenu_Click;
            // 
            // labelProcessText
            // 
            labelProcessText.AutoSize = true;
            labelProcessText.Location = new Point(7, 528);
            labelProcessText.Name = "labelProcessText";
            labelProcessText.Size = new Size(93, 20);
            labelProcessText.TabIndex = 4;
            labelProcessText.Text = "Good or Not";
            // 
            // buttonFindAllPrices
            // 
            buttonFindAllPrices.Location = new Point(299, 31);
            buttonFindAllPrices.Name = "buttonFindAllPrices";
            buttonFindAllPrices.Size = new Size(94, 29);
            buttonFindAllPrices.TabIndex = 3;
            buttonFindAllPrices.Text = "Find alle";
            buttonFindAllPrices.UseVisualStyleBackColor = true;
            buttonFindAllPrices.Click += buttonFindAllPrices_Click;
            // 
            // button1
            // 
            button1.Location = new Point(207, 29);
            button1.Margin = new Padding(3, 4, 3, 4);
            button1.Name = "button1";
            button1.Size = new Size(86, 31);
            button1.TabIndex = 2;
            button1.Text = "Søg";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // textBoxFindBy
            // 
            textBoxFindBy.Location = new Point(7, 29);
            textBoxFindBy.Margin = new Padding(3, 4, 3, 4);
            textBoxFindBy.Name = "textBoxFindBy";
            textBoxFindBy.Size = new Size(193, 27);
            textBoxFindBy.TabIndex = 1;
            // 
            // listBoxPrices
            // 
            listBoxPrices.FormattingEnabled = true;
            listBoxPrices.ItemHeight = 20;
            listBoxPrices.Location = new Point(10, 100);
            listBoxPrices.Margin = new Padding(3, 4, 3, 4);
            listBoxPrices.Name = "listBoxPrices";
            listBoxPrices.Size = new Size(546, 424);
            listBoxPrices.TabIndex = 0;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(label3);
            groupBox2.Controls.Add(textBoxPriceId);
            groupBox2.Controls.Add(textBoxWeekday);
            groupBox2.Controls.Add(textBoxNormalPrice);
            groupBox2.Controls.Add(labelWeekday);
            groupBox2.Controls.Add(label1);
            groupBox2.Controls.Add(buttonSavePrice);
            groupBox2.Location = new Point(611, 19);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(301, 330);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Opdater prissæt";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(6, 82);
            label3.Name = "label3";
            label3.Size = new Size(285, 20);
            label3.TabIndex = 8;
            label3.Text = "Skriv ID'et på den pris som skal opdateres";
            // 
            // textBoxPriceId
            // 
            textBoxPriceId.Location = new Point(84, 105);
            textBoxPriceId.Name = "textBoxPriceId";
            textBoxPriceId.Size = new Size(125, 27);
            textBoxPriceId.TabIndex = 7;
            // 
            // textBoxWeekday
            // 
            textBoxWeekday.Location = new Point(84, 211);
            textBoxWeekday.Name = "textBoxWeekday";
            textBoxWeekday.Size = new Size(125, 27);
            textBoxWeekday.TabIndex = 6;
            // 
            // textBoxNormalPrice
            // 
            textBoxNormalPrice.Location = new Point(84, 158);
            textBoxNormalPrice.Name = "textBoxNormalPrice";
            textBoxNormalPrice.Size = new Size(125, 27);
            textBoxNormalPrice.TabIndex = 4;
            // 
            // labelWeekday
            // 
            labelWeekday.AutoSize = true;
            labelWeekday.Location = new Point(96, 188);
            labelWeekday.Name = "labelWeekday";
            labelWeekday.Size = new Size(95, 20);
            labelWeekday.TabIndex = 3;
            labelWeekday.Text = "Dag på ugen";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(105, 135);
            label1.Name = "label1";
            label1.Size = new Size(86, 20);
            label1.TabIndex = 1;
            label1.Text = "Normal Pris";
            // 
            // buttonSavePrice
            // 
            buttonSavePrice.Location = new Point(97, 244);
            buttonSavePrice.Name = "buttonSavePrice";
            buttonSavePrice.Size = new Size(94, 29);
            buttonSavePrice.TabIndex = 0;
            buttonSavePrice.Text = "Gem Pris";
            buttonSavePrice.UseVisualStyleBackColor = true;
            buttonSavePrice.Click += buttonSavePrice_Click;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(buttonPriceToDelete);
            groupBox3.Controls.Add(textBoxPriceToDelete);
            groupBox3.Controls.Add(label4);
            groupBox3.Location = new Point(611, 355);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(301, 229);
            groupBox3.TabIndex = 2;
            groupBox3.TabStop = false;
            groupBox3.Text = "Slet Prissæt";
            // 
            // buttonPriceToDelete
            // 
            buttonPriceToDelete.Location = new Point(105, 109);
            buttonPriceToDelete.Name = "buttonPriceToDelete";
            buttonPriceToDelete.Size = new Size(94, 29);
            buttonPriceToDelete.TabIndex = 11;
            buttonPriceToDelete.Text = "Slet Prissæt";
            buttonPriceToDelete.UseVisualStyleBackColor = true;
            buttonPriceToDelete.Click += buttonPriceToDelete_Click;
            // 
            // textBoxPriceToDelete
            // 
            textBoxPriceToDelete.Location = new Point(84, 64);
            textBoxPriceToDelete.Name = "textBoxPriceToDelete";
            textBoxPriceToDelete.Size = new Size(125, 27);
            textBoxPriceToDelete.TabIndex = 10;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(21, 32);
            label4.Name = "label4";
            label4.Size = new Size(280, 20);
            label4.TabIndex = 9;
            label4.Text = "Skriv ID'et på det prissæt som skal slettes";
            // 
            // PriceMenu
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(924, 607);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "PriceMenu";
            Text = "PriceMenu";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Button button1;
        private TextBox textBoxFindBy;
        private ListBox listBoxPrices;
        private Button buttonFindAllPrices;
        private Label labelProcessText;
        private Button buttonCreatePriceMenu;
        private GroupBox groupBox2;
        private TextBox textBoxWeekday;
        private TextBox textBoxNormalPrice;
        private Label labelWeekday;
        private Label label1;
        private Button buttonSavePrice;
        private TextBox textBoxPriceId;
        private Label label3;
        private GroupBox groupBox3;
        private Label label4;
        private TextBox textBoxPriceToDelete;
        private Button buttonPriceToDelete;
    }
}