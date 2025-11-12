using System.Runtime.InteropServices;

namespace LinearSystemSolver
{
    public partial class SolverForm : Form
    {
        // Fields
        private const int WM_SYSCOMMAND = 0x0112;

        // WinAPI Definitions
        [DllImport("user32.dll", EntryPoint = "ReleaseCapture")]
        private static extern void ReleaseCapture();

        [DllImport("user32.dll", EntryPoint = "SendMessage")]
        private static extern void SendMessage(IntPtr hWnd, int Msg, IntPtr wParam, IntPtr lParam);

        public SolverForm(int vars, int eqs)
        {
            InitializeComponent();

            InitializeGrid(vars, eqs);
            this.Width = dataGrid.Width + stepsBox.Width + 20;
            this.Height = dataGrid.Height + 180;

            // short event handlers
            exitBtn.Click += (s, e) => this.Close();
            exitBtn.MouseEnter += (s, e) => exitBtn.BackColor = Color.Red;
            exitBtn.MouseLeave += (s, e) => exitBtn.BackColor = Color.FromArgb(128, 128, 255);

            minimizeBtn.Click += (s, e) => WindowState = FormWindowState.Minimized;
        }

        private void InitializeGrid(int vars, int eqs)
        {
            dataGrid.Font = new Font("Segoe UI", 11F);
            dataGrid.Size = new Size(vars * 80 + 60, eqs * 35 + 40);

            dataGrid.ColumnCount = vars + 1;
            for (int i = 0; i <= vars - 1; i++)
            {
                dataGrid.Columns[i].HeaderText = $"X{i + 1}";
                dataGrid.Columns[i].SortMode = DataGridViewColumnSortMode.NotSortable;
            }
            dataGrid.Columns[vars].HeaderText = $"C";
            dataGrid.Columns[vars].SortMode = DataGridViewColumnSortMode.NotSortable;

            dataGrid.RowCount = eqs;
        }

        private void panelTitle_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, WM_SYSCOMMAND, 0xf012, 0);
        }

        private async void solveBtn_Click(object sender, EventArgs e)
        {
            await SolveAsync();
        }

        private async Task SolveAsync()
        {
            var matrix = GetMatrix();

            if (matrix is not null)
            {
                matrix.OnStepCompleted += Matrix_OnStepCompleted;
                await matrix.SolveWithSteps(fastMoodToggle.Checked);
            }
        }

        private void Matrix_OnStepCompleted(string step)
        {
            stepsBox.AppendText(step);
        }

        private LinearMatrix GetMatrix()
        {
            int rows = dataGrid.Rows.Count;
            int cols = dataGrid.Columns.Count;

            double[,] matrix = new double[rows, cols];

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    object val = dataGrid[j, i].Value;

                    if (val != null && double.TryParse(val.ToString(), out double value))
                    {
                        matrix[i, j] = value;
                    }
                    else
                    {
                        MessageBox.Show($"Invalid data at cell [{i + 1} x {j + 1}]");
                        return null;
                    }
                }
            }

            return LinearMatrix.Create(matrix);
        }

        private void clearBtn_Click(object sender, EventArgs e)
        {
            stepsBox.Clear();
        }
    }
}