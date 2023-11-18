namespace IOCL
{
    partial class testing
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(testing));
            label4 = new Label();
            comboBox1 = new ComboBox();
            panel1 = new Panel();
            label2 = new Label();
            temp_data = new Label();
            pictureBox1 = new PictureBox();
            panel2 = new Panel();
            density_data = new Label();
            label1 = new Label();
            pictureBox2 = new PictureBox();
            panel3 = new Panel();
            viscosity_data = new Label();
            label3 = new Label();
            pictureBox3 = new PictureBox();
            timer1 = new System.Windows.Forms.Timer(components);
            exit = new PictureBox();
            pictureBox4 = new PictureBox();
            button2 = new Button();
            timer2 = new System.Windows.Forms.Timer(components);
            button1 = new Button();
            label5 = new Label();
            pictureBox5 = new PictureBox();
            label6 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)exit).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            SuspendLayout();
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.FromArgb(7, 14, 42);
            label4.Font = new Font("Segoe UI Symbol", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = SystemColors.Control;
            label4.Location = new Point(354, 167);
            label4.Name = "label4";
            label4.Size = new Size(240, 45);
            label4.TabIndex = 6;
            label4.Text = "Select a Fluid :";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Oil" });
            comboBox1.Location = new Point(623, 167);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(376, 40);
            comboBox1.TabIndex = 7;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(209, 189, 212);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(temp_data);
            panel1.Controls.Add(pictureBox1);
            panel1.Location = new Point(39, 339);
            panel1.Name = "panel1";
            panel1.Size = new Size(453, 200);
            panel1.TabIndex = 8;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Variable Display", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(13, 148);
            label2.Name = "label2";
            label2.Size = new Size(240, 43);
            label2.TabIndex = 5;
            label2.Text = "TEMPERATURE";
            label2.Click += label2_Click;
            // 
            // temp_data
            // 
            temp_data.AutoSize = true;
            temp_data.Font = new Font("Segoe UI Black", 13.875F, FontStyle.Bold, GraphicsUnit.Point);
            temp_data.Location = new Point(23, 70);
            temp_data.Name = "temp_data";
            temp_data.Size = new Size(44, 50);
            temp_data.TabIndex = 5;
            temp_data.Text = "0";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(315, 29);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(97, 117);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(209, 189, 212);
            panel2.Controls.Add(density_data);
            panel2.Controls.Add(label1);
            panel2.Controls.Add(pictureBox2);
            panel2.Location = new Point(555, 339);
            panel2.Name = "panel2";
            panel2.Size = new Size(453, 200);
            panel2.TabIndex = 9;
            panel2.Paint += panel2_Paint;
            // 
            // density_data
            // 
            density_data.AutoSize = true;
            density_data.Font = new Font("Segoe UI Black", 13.875F, FontStyle.Bold, GraphicsUnit.Point);
            density_data.Location = new Point(9, 70);
            density_data.Name = "density_data";
            density_data.Size = new Size(44, 50);
            density_data.TabIndex = 6;
            density_data.Text = "0";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Variable Display", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(68, 148);
            label1.Name = "label1";
            label1.Size = new Size(152, 43);
            label1.TabIndex = 4;
            label1.Text = "DENSITY";
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(307, 35);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(102, 100);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 3;
            pictureBox2.TabStop = false;
            pictureBox2.Click += pictureBox2_Click;
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(209, 189, 212);
            panel3.Controls.Add(viscosity_data);
            panel3.Controls.Add(label3);
            panel3.Controls.Add(pictureBox3);
            panel3.Location = new Point(1082, 339);
            panel3.Name = "panel3";
            panel3.Size = new Size(453, 200);
            panel3.TabIndex = 10;
            // 
            // viscosity_data
            // 
            viscosity_data.AutoSize = true;
            viscosity_data.Font = new Font("Segoe UI Black", 13.875F, FontStyle.Bold, GraphicsUnit.Point);
            viscosity_data.Location = new Point(17, 70);
            viscosity_data.Name = "viscosity_data";
            viscosity_data.Size = new Size(54, 50);
            viscosity_data.TabIndex = 7;
            viscosity_data.Text = "0 ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Variable Display", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(94, 145);
            label3.Name = "label3";
            label3.Size = new Size(184, 43);
            label3.TabIndex = 6;
            label3.Text = "VISCOSITY";
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(302, 35);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(128, 111);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 3;
            pictureBox3.TabStop = false;
            // 
            // timer1
            // 
            timer1.Interval = 1000;
            timer1.Tick += timer1_Tick;
            // 
            // exit
            // 
            exit.Image = (Image)resources.GetObject("exit.Image");
            exit.Location = new Point(1496, 27);
            exit.Name = "exit";
            exit.Size = new Size(70, 60);
            exit.SizeMode = PictureBoxSizeMode.StretchImage;
            exit.TabIndex = 11;
            exit.TabStop = false;
            exit.Click += exit_Click;
            // 
            // pictureBox4
            // 
            pictureBox4.Image = (Image)resources.GetObject("pictureBox4.Image");
            pictureBox4.Location = new Point(24, 927);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(63, 61);
            pictureBox4.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox4.TabIndex = 13;
            pictureBox4.TabStop = false;
            pictureBox4.Click += pictureBox4_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(0, 192, 0);
            button2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            button2.ForeColor = SystemColors.ControlLightLight;
            button2.Location = new Point(1082, 131);
            button2.Name = "button2";
            button2.Size = new Size(150, 76);
            button2.TabIndex = 28;
            button2.Text = "Start";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // timer2
            // 
            timer2.Interval = 6000;
            timer2.Tick += timer2_Tick;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(255, 128, 128);
            button1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            button1.ForeColor = SystemColors.ControlLightLight;
            button1.Location = new Point(1400, 928);
            button1.Name = "button1";
            button1.Size = new Size(150, 45);
            button1.TabIndex = 29;
            button1.Text = "Stop";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 10.125F, FontStyle.Regular, GraphicsUnit.Point);
            label5.ForeColor = SystemColors.HighlightText;
            label5.Location = new Point(319, 936);
            label5.Name = "label5";
            label5.Size = new Size(884, 37);
            label5.TabIndex = 30;
            label5.Text = "© 2023 XYMA Analytics Pvt Ltd,IIT Madras Research Park,Chennai,600113";
            // 
            // pictureBox5
            // 
            pictureBox5.Image = (Image)resources.GetObject("pictureBox5.Image");
            pictureBox5.Location = new Point(-17, 12);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(108, 75);
            pictureBox5.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox5.TabIndex = 31;
            pictureBox5.TabStop = false;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 10.125F, FontStyle.Bold, GraphicsUnit.Point);
            label6.ForeColor = SystemColors.ControlLight;
            label6.Location = new Point(70, 36);
            label6.Name = "label6";
            label6.Size = new Size(141, 37);
            label6.TabIndex = 32;
            label6.Text = "Indian Oil";
            // 
            // testing
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(7, 14, 42);
            ClientSize = new Size(1600, 1000);
            Controls.Add(label6);
            Controls.Add(pictureBox5);
            Controls.Add(label5);
            Controls.Add(button1);
            Controls.Add(button2);
            Controls.Add(pictureBox4);
            Controls.Add(exit);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(comboBox1);
            Controls.Add(label4);
            FormBorderStyle = FormBorderStyle.None;
            Name = "testing";
            Text = "testing";
            Load += testing_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)exit).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label4;
        private ComboBox comboBox1;
        private Panel panel1;
        private Label label2;
        private Label temp_data;
        private PictureBox pictureBox1;
        private Panel panel2;
        private Label density_data;
        private Label label1;
        private PictureBox pictureBox2;
        private Panel panel3;
        private Label viscosity_data;
        private Label label3;
        private PictureBox pictureBox3;
        private System.Windows.Forms.Timer timer1;
        private PictureBox exit;
        private PictureBox pictureBox4;
        private Button button2;
        private System.Windows.Forms.Timer timer2;
        private Button button1;
        private Label label5;
        private PictureBox pictureBox5;
        private Label label6;
    }
}