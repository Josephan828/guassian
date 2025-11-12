namespace LinearSystemSolver
{
    public partial class SplashForm : Form
    {
        public SplashForm()
        {
            InitializeComponent();

            progressTimer.Start();
        }

        private void progressTimer_Tick(object sender, EventArgs e)
        {
            if (++CircleProgressBar.Value < 100)
            {
                CircleProgressBar.Value++;
                return;
            }

            CircleProgressBar.Value = 100;
            progressTimer.Stop();

            var mainForm = new MainForm();
            this.Hide();
            mainForm.Show();
        }
    }
}
