using System.Runtime.InteropServices;

namespace LinearSystemSolver
{
    public partial class MainForm : Form
    {
        // Fields
        private const int WM_SYSCOMMAND = 0x0112;

        // WinAPI Definitions
        [DllImport("user32.dll", EntryPoint = "ReleaseCapture")]
        private static extern void ReleaseCapture();

        [DllImport("user32.dll", EntryPoint = "SendMessage")]
        private static extern void SendMessage(IntPtr hWnd, int Msg, IntPtr wParam, IntPtr lParam);

        public MainForm()
        {
            InitializeComponent();

            // Form
            this.DoubleBuffered = true;

            // short event handlers
            exitBtn.Click += (s, e) => Application.Exit();
            exitBtn.MouseEnter += (s, e) => exitBtn.BackColor = Color.Red;
            exitBtn.MouseLeave += (s, e) => exitBtn.BackColor = Color.FromArgb(128, 128, 255);

            minimizeBtn.Click += (s, e) => WindowState = FormWindowState.Minimized;
        }

        private void panelTitle_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, WM_SYSCOMMAND, 0xf012, 0);
        }

        
        private void manimizeBtn_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void dataBtn_Click(object sender, EventArgs e)
        {
            var form = new SolverForm((int)varsValue.Value, (int)eqsValue.Value);
            form.Show();
        }
    }
}
