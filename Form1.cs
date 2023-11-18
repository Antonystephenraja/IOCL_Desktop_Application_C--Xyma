namespace IOCL
{
    public partial class Form1 : Form
    {
        private bool isTimerActive = false;
        public Form1()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            panel2.Visible = false;

            /*int screenWidth = Screen.PrimaryScreen.Bounds.Width;
            int screenHeight = Screen.PrimaryScreen.Bounds.Height;
            //MessageBox.Show("Screen Width: " + screenWidth + "\nScreen Height: " + screenHeight);
            this.Width = screenWidth;
            this.Height = screenHeight;
            int exit_icon = screenWidth - (screenWidth - 100);
            int exit_icon_height = screenWidth - (screenWidth - 100);
            int xyma_img = screenWidth / 5;
            int xyma_img_height = screenHeight / 6;
            panel1.Width = screenWidth;
            panel2.Width = screenWidth;
            // Set the size and position of pictureBox1
            pictureBox1.Width = xyma_img;
            pictureBox1.Height = xyma_img_height;
            exit.Width = exit_icon;
            exit.Height = exit_icon_height;
            pictureBox1.Location = new Point((screenWidth - pictureBox1.Width) / 2, (screenHeight - pictureBox1.Height) / 2);
            pictureBox2.Location = new Point((screenWidth - pictureBox2.Width) / 2, (screenHeight - pictureBox2.Height) - 450);
            panel1.Location = new Point(0, screenHeight - 20);
            label5.Location = new Point((screenWidth - label5.Width) / 2, (screenHeight - 150));
            exit.Location = new Point(screenWidth - 100, screenHeight - (screenHeight - 10));*/
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Close();
            Application.Exit();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (isTimerActive)
            {
                panel2.Width += 10;
                if (panel2.Width >= 1600)
                {
                    timer1.Stop();
                    Dashboard fm = new Dashboard();
                    fm.Show(this);
                    this.Hide();
                }
            }
        }

        private void pictureBox2_Click_1(object sender, EventArgs e)
        {
            isTimerActive = true;
            timer1.Start();
            panel2.Visible = true;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}