namespace MatrixInversion
{
    public partial class SolverForm : Form
    {
        private int size;

        public SolverForm(int n)
        {
            InitializeComponent();

            size = n;

            InitializeGrid();
            this.Width = matrixGrid.Width + 20;
            this.Height = matrixGrid.Height + 200;

            exitBtn.MouseEnter += (s, e) => exitBtn.BackColor = Color.Red;
            exitBtn.MouseLeave += (s, e) => exitBtn.BackColor = Color.FromArgb(128, 128, 255);
            exitBtn.Click += (s, e) => this.Close();
            minimizeBtn.Click += (s, e) => WindowState = FormWindowState.Minimized;

            solveBtn.Click += solveBtn_Click;
        }


        private void InitializeGrid()
        {
            matrixGrid.Font = new Font("Segoe UI", 11F);
            matrixGrid.Size = new Size(size * 80 + 60, size * 35 + 40);

            matrixGrid.ColumnCount = matrixGrid.RowCount = size;
            for (int i = 0; i < size; i++)
            {
                matrixGrid.Columns[i].Width = 80;
                matrixGrid.Rows[i].Height = 35;
            }
        }

        private void solveBtn_Click(object? sender, EventArgs e)
        {
            Matrix matrix = new Matrix(size, size);

            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    if (matrixGrid.Rows[i].Cells[j].Value == null ||
                        !double.TryParse(matrixGrid.Rows[i].Cells[j].Value.ToString(), out double value))
                    {
                        MessageBox.Show("Please ensure all matrix entries are valid numbers.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    matrix[i, j] = value;
                }
            }

            try
            {
                Matrix inverse = matrix.GetInverse();
                PreviewForm previewForm = new PreviewForm(inverse);
                previewForm.Show();
            }
            catch (InvalidOperationException ex)
            {
                MessageBox.Show(ex.Message, "Computation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
