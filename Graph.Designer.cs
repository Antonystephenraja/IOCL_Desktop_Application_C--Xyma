namespace IOCL
{
    partial class Graph
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Graph));
            pictureBox4 = new PictureBox();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            exit = new PictureBox();
            cartesianChart1 = new LiveCharts.WinForms.CartesianChart();
            cartesianChart2 = new LiveCharts.WinForms.CartesianChart();
            label3 = new Label();
            label2 = new Label();
            timer1 = new System.Windows.Forms.Timer(components);
            button2 = new Button();
            button1 = new Button();
            timer2 = new System.Windows.Forms.Timer(components);
            PopupTimer_Tick = new System.Windows.Forms.Timer(components);
            label5 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)exit).BeginInit();
            SuspendLayout();
            // 
            // pictureBox4
            // 
            pictureBox4.Image = (Image)resources.GetObject("pictureBox4.Image");
            pictureBox4.Location = new Point(32, 904);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(63, 61);
            pictureBox4.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox4.TabIndex = 13;
            pictureBox4.TabStop = false;
            pictureBox4.Click += pictureBox4_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(1, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(108, 75);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 14;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10.125F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.ControlLight;
            label1.Location = new Point(92, 36);
            label1.Name = "label1";
            label1.Size = new Size(141, 37);
            label1.TabIndex = 15;
            label1.Text = "Indian Oil";
            // 
            // exit
            // 
            exit.Image = (Image)resources.GetObject("exit.Image");
            exit.Location = new Point(1496, 27);
            exit.Name = "exit";
            exit.Size = new Size(70, 60);
            exit.SizeMode = PictureBoxSizeMode.StretchImage;
            exit.TabIndex = 16;
            exit.TabStop = false;
            exit.Click += exit_Click;
            // 
            // cartesianChart1
            // 
            cartesianChart1.Location = new Point(147, 154);
            cartesianChart1.Name = "cartesianChart1";
            cartesianChart1.Size = new Size(1348, 278);
            cartesianChart1.TabIndex = 17;
            cartesianChart1.Text = "cartesianChart1";
            cartesianChart1.ChildChanged += cartesianChart1_ChildChanged;
            // 
            // cartesianChart2
            // 
            cartesianChart2.Location = new Point(147, 531);
            cartesianChart2.Name = "cartesianChart2";
            cartesianChart2.Size = new Size(1348, 271);
            cartesianChart2.TabIndex = 18;
            cartesianChart2.Text = "cartesianChart2";
            cartesianChart2.ChildChanged += cartesianChart2_ChildChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 13.875F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = SystemColors.HighlightText;
            label3.Location = new Point(760, 453);
            label3.Name = "label3";
            label3.Size = new Size(126, 50);
            label3.TabIndex = 19;
            label3.Text = "TOF-2";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 13.875F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = SystemColors.HighlightText;
            label2.Location = new Point(760, 75);
            label2.Name = "label2";
            label2.Size = new Size(126, 50);
            label2.TabIndex = 20;
            label2.Text = "TOF-1";
            // 
            // timer1
            // 
            timer1.Tick += timer1_Tick;
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(255, 128, 128);
            button2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            button2.ForeColor = SystemColors.ControlLightLight;
            button2.Location = new Point(1389, 905);
            button2.Name = "button2";
            button2.Size = new Size(150, 60);
            button2.TabIndex = 28;
            button2.Text = "Stop";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(0, 192, 192);
            button1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            button1.ForeColor = SystemColors.ControlLightLight;
            button1.Location = new Point(1126, 905);
            button1.Name = "button1";
            button1.Size = new Size(211, 60);
            button1.TabIndex = 29;
            button1.Text = "Temperature";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // timer2
            // 
            timer2.Tick += timer2_Tick;
            // 
            // PopupTimer_Tick
            // 
            PopupTimer_Tick.Interval = 10;
            PopupTimer_Tick.Tick += timer3_Tick;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.LawnGreen;
            label5.Font = new Font("Arial Rounded MT Bold", 10.875F, FontStyle.Regular, GraphicsUnit.Point);
            label5.ForeColor = SystemColors.ControlText;
            label5.Location = new Point(1215, 36);
            label5.Name = "label5";
            label5.Size = new Size(225, 33);
            label5.TabIndex = 30;
            label5.Text = "Data Stabilized";
            label5.Click += label5_Click;
            // 
            // Graph
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(7, 14, 42);
            BackgroundImageLayout = ImageLayout.Zoom;
            ClientSize = new Size(1600, 1000);
            Controls.Add(label5);
            Controls.Add(button1);
            Controls.Add(button2);
            Controls.Add(label2);
            Controls.Add(label3);
            Controls.Add(cartesianChart2);
            Controls.Add(cartesianChart1);
            Controls.Add(exit);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Controls.Add(pictureBox4);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Graph";
            Text = "Graph";
            Load += Graph_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)exit).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox4;
        private PictureBox pictureBox1;
        private Label label1;
        private PictureBox exit;
        private LiveCharts.WinForms.CartesianChart cartesianChart1;
        private LiveCharts.WinForms.CartesianChart cartesianChart2;
        private Label label3;
        private Label label2;
        private System.Windows.Forms.Timer timer1;
        private Button button2;
        private Button button1;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Timer PopupTimer_Tick;
        private Label label5;
    }
}