namespace IOCL
{
    partial class Waveguide_Calibration
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Waveguide_Calibration));
            exit = new PictureBox();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            pictureBox4 = new PictureBox();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            trial_txt = new TextBox();
            button1 = new Button();
            button2 = new Button();
            listBox = new ListBox();
            ok = new Button();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)exit).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            SuspendLayout();
            // 
            // exit
            // 
            exit.Image = (Image)resources.GetObject("exit.Image");
            exit.Location = new Point(1496, 27);
            exit.Name = "exit";
            exit.Size = new Size(70, 60);
            exit.SizeMode = PictureBoxSizeMode.StretchImage;
            exit.TabIndex = 8;
            exit.TabStop = false;
            exit.Click += exit_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(-2, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(108, 75);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 9;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10.125F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.ControlLight;
            label1.Location = new Point(93, 36);
            label1.Name = "label1";
            label1.Size = new Size(141, 37);
            label1.TabIndex = 10;
            label1.Text = "Indian Oil";
            // 
            // pictureBox4
            // 
            pictureBox4.Image = (Image)resources.GetObject("pictureBox4.Image");
            pictureBox4.Location = new Point(43, 895);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(63, 61);
            pictureBox4.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox4.TabIndex = 12;
            pictureBox4.TabStop = false;
            pictureBox4.Click += pictureBox4_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 13.875F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = SystemColors.HighlightText;
            label3.Location = new Point(594, 132);
            label3.Name = "label3";
            label3.Size = new Size(420, 50);
            label3.TabIndex = 17;
            label3.Text = "Waveguide Calibration";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft YaHei UI", 13.875F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = SystemColors.ButtonFace;
            label4.Location = new Point(79, 244);
            label4.Name = "label4";
            label4.Size = new Size(246, 50);
            label4.TabIndex = 18;
            label4.Text = "Fluid Name:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Microsoft YaHei UI", 13.875F, FontStyle.Bold, GraphicsUnit.Point);
            label5.ForeColor = SystemColors.ButtonFace;
            label5.Location = new Point(45, 345);
            label5.Name = "label5";
            label5.Size = new Size(280, 50);
            label5.TabIndex = 19;
            label5.Text = "Trial Number:";
            // 
            // trial_txt
            // 
            trial_txt.Location = new Point(357, 356);
            trial_txt.Name = "trial_txt";
            trial_txt.Size = new Size(396, 39);
            trial_txt.TabIndex = 23;
            // 
            // button1
            // 
            button1.BackColor = Color.LightSeaGreen;
            button1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            button1.ForeColor = SystemColors.ControlLightLight;
            button1.Location = new Point(1266, 775);
            button1.Name = "button1";
            button1.Size = new Size(246, 60);
            button1.TabIndex = 26;
            button1.Text = "Form Calibration";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(0, 192, 0);
            button2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            button2.ForeColor = SystemColors.ControlLightLight;
            button2.Location = new Point(594, 461);
            button2.Name = "button2";
            button2.Size = new Size(150, 60);
            button2.TabIndex = 27;
            button2.Text = "Start";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // listBox
            // 
            listBox.FormattingEnabled = true;
            listBox.ItemHeight = 32;
            listBox.Location = new Point(814, 229);
            listBox.Name = "listBox";
            listBox.Size = new Size(698, 292);
            listBox.TabIndex = 30;
            listBox.SelectedIndexChanged += listBox_SelectedIndexChanged;
            // 
            // ok
            // 
            ok.Location = new Point(357, 251);
            ok.Name = "ok";
            ok.Size = new Size(396, 46);
            ok.TabIndex = 31;
            ok.Text = "Browse";
            ok.UseVisualStyleBackColor = true;
            ok.Click += ok_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10.125F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = SystemColors.HighlightText;
            label2.Location = new Point(318, 919);
            label2.Name = "label2";
            label2.Size = new Size(884, 37);
            label2.TabIndex = 32;
            label2.Text = "© 2023 XYMA Analytics Pvt Ltd,IIT Madras Research Park,Chennai,600113";
            // 
            // Waveguide_Calibration
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(7, 14, 42);
            ClientSize = new Size(1600, 1000);
            Controls.Add(label2);
            Controls.Add(ok);
            Controls.Add(listBox);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(trial_txt);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(pictureBox4);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Controls.Add(exit);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Waveguide_Calibration";
            Text = "Waveguide_Calibration";
            Load += Waveguide_Calibration_Load;
            ((System.ComponentModel.ISupportInitialize)exit).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox exit;
        private PictureBox pictureBox1;
        private Label label1;
        private PictureBox pictureBox4;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox trial_txt;
        private Button button1;
        private Button button2;
        private ListBox listBox;
        private Button ok;
        private Label label2;
    }
}