using System.Runtime.InteropServices;

namespace LinearSystemSolver
{
    public partial class PreviewForm : Form
    {
        // Fields
        private const int WM_SYSCOMMAND = 0x0112;

        // WinAPI Definitions
        [DllImport("user32.dll", EntryPoint = "ReleaseCapture")]
        private static extern void ReleaseCapture();

        [DllImport("user32.dll", EntryPoint = "SendMessage")]
        private static extern void SendMessage(IntPtr hWnd, int Msg, IntPtr wParam, IntPtr lParam);

        public PreviewForm(double[,] matrix)
        {
            InitializeComponent();
            InitializeGrid(matrix.GetLength(0), matrix.GetLength(1));
            this.Width = dataGrid.Width;
            this.Height = dataGrid.Height;


            // short event handlers
            panelTitle.MouseDown += panelTitle_MouseDown;
            exitBtn.Click += (s, e) => this.Close();
            exitBtn.MouseEnter += (s, e) => exitBtn.BackColor = Color.Red;
            exitBtn.MouseLeave += (s, e) => exitBtn.BackColor = Color.FromArgb(128, 128, 255);
            minimizeBtn.Click += (s, e) => WindowState = FormWindowState.Minimized;

            InsertMatrixIntoDataGrid(matrix);
        }

        private void panelTitle_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, WM_SYSCOMMAND, 0xf012, 0);
        }

        private void InitializeGrid(int eqs, int vars)
        {
            dataGrid.Font = new Font("Segoe UI", 11F);
            dataGrid.Size = new Size(vars * 80 + 60, eqs * 35 + 40);

            dataGrid.ColumnCount = vars;
            for (int i = 0; i <= vars - 1; i++)
            {
                dataGrid.Columns[i].HeaderText = $"X{i + 1}";
                dataGrid.Columns[i].SortMode = DataGridViewColumnSortMode.NotSortable;
            }
            dataGrid.Columns[vars - 1].HeaderText = $"C";
            dataGrid.Columns[vars - 1].SortMode = DataGridViewColumnSortMode.NotSortable;

            dataGrid.RowCount = eqs;
        }

        private void InsertMatrixIntoDataGrid(double[,] matrix)
        {
            for (int r = 0; r < dataGrid.RowCount; r++)
            {
                for (int c = 0; c < dataGrid.ColumnCount; c++)
                {
                    dataGrid[c, r].Value = matrix[r, c].ToString("0.##");
                }
            }
        }
    }
}
