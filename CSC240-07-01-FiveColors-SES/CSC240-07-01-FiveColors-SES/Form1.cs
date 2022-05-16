namespace CSC240_07_01_FiveColors_SES
{
    public partial class MainForm : Form
    {
       
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (UxBlueRadioButton.Checked)
                this.BackColor = Color.Blue;
            else if (UxRedRadioButton.Checked)
                this.BackColor = Color.Red;
            else if (UxGreenRadioButton.Checked)
                this.BackColor = Color.Green;
            else if (UxPurpleRadioButton.Checked)
                this.BackColor = Color.Purple;
            else if (UxYellowRadioButton.Checked)
                this.BackColor = Color.Yellow;

        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
        }

        private void UxColorButton_Click(object sender, EventArgs e)
        {
            if (timer1.Enabled == false)
            {
                UxColorButton.Text = "Start";
                timer1.Start();
            }
            else
            {
                UxColorButton.Text = "Stop";
                timer1.Stop();

            }

        }
        public static class check
        {
            public static int R = 0;
            public static int B = 0;
            public static int G = 0;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Random color = new Random();
            check.R = color.Next(0, 256);
            check.G = color.Next(0, 256);
            check.B = color.Next(0, 256);
            this.BackColor = Color.FromArgb(check.R, check.G, check.B);
        }
    }
}
