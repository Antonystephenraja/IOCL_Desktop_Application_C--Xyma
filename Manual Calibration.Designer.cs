namespace IOCL
{
    partial class Manual_Calibration
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Manual_Calibration));
            pictureBox4 = new PictureBox();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            textBox2 = new TextBox();
            Fluid_textBox = new TextBox();
            tmpText = new TextBox();
            density_textbox = new TextBox();
            viscosity_textbox = new TextBox();
            add_btn = new Button();
            dataGridView1 = new DataGridView();
            Submit = new Button();
            label2 = new Label();
            exit = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)exit).BeginInit();
            SuspendLayout();
            // 
            // pictureBox4
            // 
            pictureBox4.Image = (Image)resources.GetObject("pictureBox4.Image");
            pictureBox4.Location = new Point(33, 901);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(63, 61);
            pictureBox4.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox4.TabIndex = 12;
            pictureBox4.TabStop = false;
            pictureBox4.Click += pictureBox4_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(-12, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(108, 75);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 15;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10.125F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.ControlLight;
            label1.Location = new Point(80, 36);
            label1.Name = "label1";
            label1.Size = new Size(141, 37);
            label1.TabIndex = 16;
            label1.Text = "Indian Oil";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 13.875F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = SystemColors.HighlightText;
            label3.Location = new Point(619, 97);
            label3.Name = "label3";
            label3.Size = new Size(355, 50);
            label3.TabIndex = 18;
            label3.Text = "Manual Calibration";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft YaHei UI", 13.875F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = SystemColors.ButtonFace;
            label4.Location = new Point(232, 180);
            label4.Name = "label4";
            label4.Size = new Size(115, 50);
            label4.TabIndex = 19;
            label4.Text = "Trial:";
            label4.Click += label4_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Microsoft YaHei UI", 13.875F, FontStyle.Bold, GraphicsUnit.Point);
            label5.ForeColor = SystemColors.ButtonFace;
            label5.Location = new Point(33, 478);
            label5.Name = "label5";
            label5.Size = new Size(291, 50);
            label5.TabIndex = 20;
            label5.Text = "Viscosity (cSt):";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Microsoft YaHei UI", 13.875F, FontStyle.Bold, GraphicsUnit.Point);
            label6.ForeColor = SystemColors.ButtonFace;
            label6.Location = new Point(19, 411);
            label6.Name = "label6";
            label6.Size = new Size(328, 50);
            label6.TabIndex = 21;
            label6.Text = "Density (kg/m³):";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Microsoft YaHei UI", 13.875F, FontStyle.Bold, GraphicsUnit.Point);
            label7.ForeColor = SystemColors.ButtonFace;
            label7.Location = new Point(-4, 328);
            label7.Name = "label7";
            label7.Size = new Size(351, 50);
            label7.TabIndex = 22;
            label7.Text = "Temperature (℃):";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Microsoft YaHei UI", 13.875F, FontStyle.Bold, GraphicsUnit.Point);
            label8.ForeColor = SystemColors.ButtonFace;
            label8.Location = new Point(101, 255);
            label8.Name = "label8";
            label8.Size = new Size(246, 50);
            label8.TabIndex = 23;
            label8.Text = "Fluid Name:";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(353, 191);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(309, 39);
            textBox2.TabIndex = 24;
            // 
            // Fluid_textBox
            // 
            Fluid_textBox.Location = new Point(353, 266);
            Fluid_textBox.Name = "Fluid_textBox";
            Fluid_textBox.Size = new Size(309, 39);
            Fluid_textBox.TabIndex = 25;
            Fluid_textBox.TextChanged += Fluid_textBox_TextChanged;
            // 
            // tmpText
            // 
            tmpText.Location = new Point(353, 339);
            tmpText.Name = "tmpText";
            tmpText.Size = new Size(309, 39);
            tmpText.TabIndex = 26;
            // 
            // density_textbox
            // 
            density_textbox.Location = new Point(353, 422);
            density_textbox.Name = "density_textbox";
            density_textbox.Size = new Size(309, 39);
            density_textbox.TabIndex = 27;
            // 
            // viscosity_textbox
            // 
            viscosity_textbox.Location = new Point(353, 489);
            viscosity_textbox.Name = "viscosity_textbox";
            viscosity_textbox.Size = new Size(309, 39);
            viscosity_textbox.TabIndex = 28;
            // 
            // add_btn
            // 
            add_btn.BackColor = Color.FromArgb(0, 192, 192);
            add_btn.Font = new Font("Segoe UI", 10.125F, FontStyle.Bold, GraphicsUnit.Point);
            add_btn.ForeColor = SystemColors.Desktop;
            add_btn.Location = new Point(398, 568);
            add_btn.Name = "add_btn";
            add_btn.Size = new Size(150, 85);
            add_btn.TabIndex = 29;
            add_btn.Text = "ADD";
            add_btn.UseVisualStyleBackColor = false;
            add_btn.Click += add_btn_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(689, 191);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 82;
            dataGridView1.RowTemplate.Height = 41;
            dataGridView1.Size = new Size(877, 337);
            dataGridView1.TabIndex = 30;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // Submit
            // 
            Submit.BackColor = Color.FromArgb(0, 192, 192);
            Submit.Font = new Font("Segoe UI", 10.125F, FontStyle.Bold, GraphicsUnit.Point);
            Submit.ForeColor = SystemColors.ActiveCaptionText;
            Submit.Location = new Point(1326, 659);
            Submit.Name = "Submit";
            Submit.Size = new Size(185, 85);
            Submit.TabIndex = 31;
            Submit.Text = "SUBMIT";
            Submit.UseVisualStyleBackColor = false;
            Submit.Click += Submit_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10.125F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = SystemColors.HighlightText;
            label2.Location = new Point(328, 925);
            label2.Name = "label2";
            label2.Size = new Size(884, 37);
            label2.TabIndex = 32;
            label2.Text = "© 2023 XYMA Analytics Pvt Ltd,IIT Madras Research Park,Chennai,600113";
            // 
            // exit
            // 
            exit.Image = (Image)resources.GetObject("exit.Image");
            exit.Location = new Point(1496, 27);
            exit.Name = "exit";
            exit.Size = new Size(70, 60);
            exit.SizeMode = PictureBoxSizeMode.StretchImage;
            exit.TabIndex = 14;
            exit.TabStop = false;
            exit.Click += exit_Click;
            // 
            // Manual_Calibration
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(7, 14, 42);
            ClientSize = new Size(1600, 1000);
            Controls.Add(label2);
            Controls.Add(Submit);
            Controls.Add(dataGridView1);
            Controls.Add(add_btn);
            Controls.Add(viscosity_textbox);
            Controls.Add(density_textbox);
            Controls.Add(tmpText);
            Controls.Add(Fluid_textBox);
            Controls.Add(textBox2);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Controls.Add(exit);
            Controls.Add(pictureBox4);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Manual_Calibration";
            Text = "Manual_Calibration";
            Load += Manual_Calibration_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)exit).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox4;
        private PictureBox pictureBox1;
        private Label label1;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private TextBox textBox2;
        private TextBox Fluid_textBox;
        private TextBox tmpText;
        private TextBox density_textbox;
        private TextBox viscosity_textbox;
        private Button add_btn;
        private DataGridView dataGridView1;
        private Button Submit;
        private Label label2;
        private PictureBox exit;
    }
}