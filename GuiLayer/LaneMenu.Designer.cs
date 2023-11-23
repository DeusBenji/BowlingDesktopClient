namespace BowlingDesktopClient.GuiLayer
{
    partial class LaneMenu
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
            this.buttonCreateLane = new System.Windows.Forms.Button();
            this.buttonGetAllLanes = new System.Windows.Forms.Button();
            this.buttonGetLane = new System.Windows.Forms.Button();
            this.textBoxFindBy = new System.Windows.Forms.TextBox();
            this.listBoxLanes = new System.Windows.Forms.ListBox();
            this.groupBoxUpdateLane = new System.Windows.Forms.GroupBox();
            this.buttonUpdateLane = new System.Windows.Forms.Button();
            this.textBoxNewLaneNumber = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxFindByID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.labelProcessText = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.buttonDeleteLane = new System.Windows.Forms.Button();
            this.textBoxLaneToDelete = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBoxUpdateLane.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.buttonCreateLane);
            this.groupBox1.Controls.Add(this.buttonGetAllLanes);
            this.groupBox1.Controls.Add(this.buttonGetLane);
            this.groupBox1.Controls.Add(this.textBoxFindBy);
            this.groupBox1.Controls.Add(this.listBoxLanes);
            this.groupBox1.Location = new System.Drawing.Point(14, 16);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Size = new System.Drawing.Size(550, 535);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Find Bane";
            // 
            // buttonCreateLane
            // 
            this.buttonCreateLane.Location = new System.Drawing.Point(450, 42);
            this.buttonCreateLane.Name = "buttonCreateLane";
            this.buttonCreateLane.Size = new System.Drawing.Size(94, 29);
            this.buttonCreateLane.TabIndex = 4;
            this.buttonCreateLane.Text = "Opret Bane";
            this.buttonCreateLane.UseVisualStyleBackColor = true;
            // 
            // buttonGetAllLanes
            // 
            this.buttonGetAllLanes.Location = new System.Drawing.Point(297, 41);
            this.buttonGetAllLanes.Name = "buttonGetAllLanes";
            this.buttonGetAllLanes.Size = new System.Drawing.Size(94, 29);
            this.buttonGetAllLanes.TabIndex = 3;
            this.buttonGetAllLanes.Text = "Find alle";
            this.buttonGetAllLanes.UseVisualStyleBackColor = true;
            // 
            // buttonGetLane
            // 
            this.buttonGetLane.Location = new System.Drawing.Point(187, 40);
            this.buttonGetLane.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonGetLane.Name = "buttonGetLane";
            this.buttonGetLane.Size = new System.Drawing.Size(104, 31);
            this.buttonGetLane.TabIndex = 2;
            this.buttonGetLane.Text = "Søg";
            this.buttonGetLane.UseVisualStyleBackColor = true;
            this.buttonGetLane.Click += new System.EventHandler(this.buttonGetLane_Click_1);
            // 
            // textBoxFindBy
            // 
            this.textBoxFindBy.Location = new System.Drawing.Point(7, 41);
            this.textBoxFindBy.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBoxFindBy.Name = "textBoxFindBy";
            this.textBoxFindBy.Size = new System.Drawing.Size(173, 27);
            this.textBoxFindBy.TabIndex = 1;
            // 
            // listBoxLanes
            // 
            this.listBoxLanes.FormattingEnabled = true;
            this.listBoxLanes.ItemHeight = 20;
            this.listBoxLanes.Location = new System.Drawing.Point(7, 197);
            this.listBoxLanes.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.listBoxLanes.Name = "listBoxLanes";
            this.listBoxLanes.Size = new System.Drawing.Size(442, 324);
            this.listBoxLanes.TabIndex = 0;
            // 
            // groupBoxUpdateLane
            // 
            this.groupBoxUpdateLane.Controls.Add(this.buttonUpdateLane);
            this.groupBoxUpdateLane.Controls.Add(this.textBoxNewLaneNumber);
            this.groupBoxUpdateLane.Controls.Add(this.label2);
            this.groupBoxUpdateLane.Controls.Add(this.textBoxFindByID);
            this.groupBoxUpdateLane.Controls.Add(this.label1);
            this.groupBoxUpdateLane.Location = new System.Drawing.Point(605, 16);
            this.groupBoxUpdateLane.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBoxUpdateLane.Name = "groupBoxUpdateLane";
            this.groupBoxUpdateLane.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBoxUpdateLane.Size = new System.Drawing.Size(295, 201);
            this.groupBoxUpdateLane.TabIndex = 1;
            this.groupBoxUpdateLane.TabStop = false;
            this.groupBoxUpdateLane.Text = "Opdater Bane";
            // 
            // buttonUpdateLane
            // 
            this.buttonUpdateLane.Location = new System.Drawing.Point(99, 133);
            this.buttonUpdateLane.Name = "buttonUpdateLane";
            this.buttonUpdateLane.Size = new System.Drawing.Size(94, 29);
            this.buttonUpdateLane.TabIndex = 4;
            this.buttonUpdateLane.Text = "Opdater Lane";
            this.buttonUpdateLane.UseVisualStyleBackColor = true;
            // 
            // textBoxNewLaneNumber
            // 
            this.textBoxNewLaneNumber.Location = new System.Drawing.Point(80, 100);
            this.textBoxNewLaneNumber.Name = "textBoxNewLaneNumber";
            this.textBoxNewLaneNumber.Size = new System.Drawing.Size(125, 27);
            this.textBoxNewLaneNumber.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(50, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(180, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Indtast nye Bane Nummer";
            // 
            // textBoxFindByID
            // 
            this.textBoxFindByID.Location = new System.Drawing.Point(80, 47);
            this.textBoxFindByID.Name = "textBoxFindByID";
            this.textBoxFindByID.Size = new System.Drawing.Size(125, 27);
            this.textBoxFindByID.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(91, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Skriv banes ID";
            // 
            // labelProcessText
            // 
            this.labelProcessText.AutoSize = true;
            this.labelProcessText.Location = new System.Drawing.Point(21, 555);
            this.labelProcessText.Name = "labelProcessText";
            this.labelProcessText.Size = new System.Drawing.Size(93, 20);
            this.labelProcessText.TabIndex = 2;
            this.labelProcessText.Text = "Good or Not";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.buttonDeleteLane);
            this.groupBox2.Controls.Add(this.textBoxLaneToDelete);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Location = new System.Drawing.Point(605, 276);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(283, 275);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Slet bane";
            // 
            // buttonDeleteLane
            // 
            this.buttonDeleteLane.Location = new System.Drawing.Point(99, 97);
            this.buttonDeleteLane.Name = "buttonDeleteLane";
            this.buttonDeleteLane.Size = new System.Drawing.Size(94, 29);
            this.buttonDeleteLane.TabIndex = 2;
            this.buttonDeleteLane.Text = "Slet bane";
            this.buttonDeleteLane.UseVisualStyleBackColor = true;
            // 
            // textBoxLaneToDelete
            // 
            this.textBoxLaneToDelete.Location = new System.Drawing.Point(80, 64);
            this.textBoxLaneToDelete.Name = "textBoxLaneToDelete";
            this.textBoxLaneToDelete.Size = new System.Drawing.Size(125, 27);
            this.textBoxLaneToDelete.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(91, 41);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(102, 20);
            this.label3.TabIndex = 0;
            this.label3.Text = "Skriv banes ID";
            // 
            // LaneMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(914, 600);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.labelProcessText);
            this.Controls.Add(this.groupBoxUpdateLane);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "LaneMenu";
            this.Text = "LaneMenu";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBoxUpdateLane.ResumeLayout(false);
            this.groupBoxUpdateLane.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private GroupBox groupBox1;
        private Button buttonGetLane;
        private TextBox textBoxFindBy;
        private ListBox listBoxLanes;
        private GroupBox groupBoxUpdateLane;
        private Label labelProcessText;
        private Button buttonGetAllLanes;
        private Button buttonCreateLane;
        private TextBox textBoxFindByID;
        private Label label1;
        private Label label2;
        private TextBox textBoxNewLaneNumber;
        private Button buttonUpdateLane;
        private GroupBox groupBox2;
        private Button buttonDeleteLane;
        private TextBox textBoxLaneToDelete;
        private Label label3;
    }
}