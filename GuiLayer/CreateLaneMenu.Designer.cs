namespace BowlingDesktopClient.GuiLayer
{
    partial class CreateLaneMenu
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
            labelLaneNumber = new Label();
            textBoxLaneNumber = new TextBox();
            buttonSaveLane = new Button();
            labelProcessText = new Label();
            SuspendLayout();
            // 
            // labelLaneNumber
            // 
            labelLaneNumber.AutoSize = true;
            labelLaneNumber.Location = new Point(120, 56);
            labelLaneNumber.Name = "labelLaneNumber";
            labelLaneNumber.Size = new Size(104, 20);
            labelLaneNumber.TabIndex = 0;
            labelLaneNumber.Text = "Bane Nummer";
            // 
            // textBoxLaneNumber
            // 
            textBoxLaneNumber.Location = new Point(108, 79);
            textBoxLaneNumber.Name = "textBoxLaneNumber";
            textBoxLaneNumber.Size = new Size(125, 27);
            textBoxLaneNumber.TabIndex = 1;
            // 
            // buttonSaveLane
            // 
            buttonSaveLane.Location = new Point(120, 112);
            buttonSaveLane.Name = "buttonSaveLane";
            buttonSaveLane.Size = new Size(94, 29);
            buttonSaveLane.TabIndex = 2;
            buttonSaveLane.Text = "Gem Bane";
            buttonSaveLane.UseVisualStyleBackColor = true;
            buttonSaveLane.Click += buttonSaveLane_Click;
            // 
            // labelProcessText
            // 
            labelProcessText.AutoSize = true;
            labelProcessText.Location = new Point(121, 156);
            labelProcessText.Name = "labelProcessText";
            labelProcessText.Size = new Size(93, 20);
            labelProcessText.TabIndex = 3;
            labelProcessText.Text = "Good or Not";
            // 
            // CreateLaneMenu
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(345, 292);
            Controls.Add(labelProcessText);
            Controls.Add(buttonSaveLane);
            Controls.Add(textBoxLaneNumber);
            Controls.Add(labelLaneNumber);
            Name = "CreateLaneMenu";
            Text = "CreateLaneMenu";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelLaneNumber;
        private TextBox textBoxLaneNumber;
        private Button buttonSaveLane;
        private Label labelProcessText;
    }
}