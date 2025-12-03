namespace MatrixInversion
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();

            exitBtn.MouseEnter += (s, e) => exitBtn.BackColor = Color.Red;
            exitBtn.MouseLeave += (s, e) => exitBtn.BackColor = Color.FromArgb(128, 128, 255);
            exitBtn.Click += (s, e) => Application.Exit();
            minimizeBtn.Click += (s, e) => WindowState = FormWindowState.Minimized;
        }

        private void dataBtn_Click(object sender, EventArgs e)
        {
            if (rowsValue.Value != colsValue.Value)
            {
                MessageBox.Show("Matrix must be square to compute its inverse.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            SolverForm form = new SolverForm((int)rowsValue.Value);
            form.Show();
        }

        
    }
}
