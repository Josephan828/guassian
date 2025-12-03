namespace MatrixInversion
{
    public partial class PreviewForm : Form
    {
        private int size;

        public PreviewForm(Matrix matrix)
        {
            InitializeComponent();

            size = matrix.Rows;

            InitializeGrid();
            this.Width = matrixGrid.Width;
            this.Height = matrixGrid.Height;


            FillData(matrix);

            exitBtn.MouseEnter += (s, e) => exitBtn.BackColor = Color.Red;
            exitBtn.MouseLeave += (s, e) => exitBtn.BackColor = Color.FromArgb(128, 128, 255);
            exitBtn.Click += (s, e) => this.Close();
            minimizeBtn.Click += (s, e) => WindowState = FormWindowState.Minimized;
        }

        private void FillData(Matrix matrix)
        {
            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    matrixGrid.Rows[i].Cells[j].Value = matrix[i, j];
                }
            }
        }

        private void InitializeGrid()
        {
            matrixGrid.Font = new Font("Segoe UI", 11F);

            matrixGrid.ColumnCount = matrixGrid.RowCount = size;
            for (int i = 0; i < size; i++)
            {
                matrixGrid.Columns[i].Width = 80;
                matrixGrid.Rows[i].Height = 35;
            }
        }
    }
}
