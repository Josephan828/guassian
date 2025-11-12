namespace LinearSystemSolver
{
    partial class PreviewForm
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
            panel1 = new Panel();
            dataGrid = new DataGridView();
            panelTitle = new Panel();
            label1 = new Label();
            minimizeBtn = new Button();
            exitBtn = new Button();
            guna2BorderlessForm1 = new Guna.UI2.WinForms.Guna2BorderlessForm(components);
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGrid).BeginInit();
            panelTitle.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(dataGrid);
            panel1.Controls.Add(panelTitle);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(633, 325);
            panel1.TabIndex = 0;
            // 
            // dataGrid
            // 
            dataGrid.AllowUserToAddRows = false;
            dataGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGrid.BackgroundColor = Color.GhostWhite;
            dataGrid.BorderStyle = BorderStyle.None;
            dataGrid.ColumnHeadersHeight = 35;
            dataGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGrid.Dock = DockStyle.Fill;
            dataGrid.EditMode = DataGridViewEditMode.EditProgrammatically;
            dataGrid.Location = new Point(0, 41);
            dataGrid.MultiSelect = false;
            dataGrid.Name = "dataGrid";
            dataGrid.ReadOnly = true;
            dataGrid.RowHeadersVisible = false;
            dataGrid.RowHeadersWidth = 51;
            dataGrid.RowTemplate.ReadOnly = true;
            dataGrid.RowTemplate.Resizable = DataGridViewTriState.False;
            dataGrid.SelectionMode = DataGridViewSelectionMode.CellSelect;
            dataGrid.Size = new Size(633, 284);
            dataGrid.TabIndex = 9;
            // 
            // panelTitle
            // 
            panelTitle.BackColor = Color.FromArgb(128, 128, 255);
            panelTitle.Controls.Add(label1);
            panelTitle.Controls.Add(minimizeBtn);
            panelTitle.Controls.Add(exitBtn);
            panelTitle.Dock = DockStyle.Top;
            panelTitle.ForeColor = Color.White;
            panelTitle.Location = new Point(0, 0);
            panelTitle.Margin = new Padding(5);
            panelTitle.Name = "panelTitle";
            panelTitle.Size = new Size(633, 41);
            panelTitle.TabIndex = 6;
            // 
            // label1
            // 
            label1.Font = new Font("Segoe UI", 18F);
            label1.ForeColor = Color.White;
            label1.Location = new Point(0, 0);
            label1.Name = "label1";
            label1.Padding = new Padding(0, 0, 25, 0);
            label1.Size = new Size(323, 38);
            label1.TabIndex = 2;
            label1.Text = "Linear System Solver";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // minimizeBtn
            // 
            minimizeBtn.Dock = DockStyle.Right;
            minimizeBtn.FlatAppearance.BorderSize = 0;
            minimizeBtn.FlatStyle = FlatStyle.Flat;
            minimizeBtn.Font = new Font("Segoe UI", 15F);
            minimizeBtn.ForeColor = Color.White;
            minimizeBtn.Location = new Point(553, 0);
            minimizeBtn.Margin = new Padding(5);
            minimizeBtn.Name = "minimizeBtn";
            minimizeBtn.Size = new Size(40, 41);
            minimizeBtn.TabIndex = 1;
            minimizeBtn.Text = "O";
            minimizeBtn.UseVisualStyleBackColor = true;
            // 
            // exitBtn
            // 
            exitBtn.Dock = DockStyle.Right;
            exitBtn.FlatAppearance.BorderSize = 0;
            exitBtn.FlatStyle = FlatStyle.Flat;
            exitBtn.Font = new Font("Segoe UI", 15F);
            exitBtn.ForeColor = Color.White;
            exitBtn.Location = new Point(593, 0);
            exitBtn.Margin = new Padding(5);
            exitBtn.Name = "exitBtn";
            exitBtn.Size = new Size(40, 41);
            exitBtn.TabIndex = 0;
            exitBtn.Text = "O";
            exitBtn.UseVisualStyleBackColor = true;
            // 
            // guna2BorderlessForm1
            // 
            guna2BorderlessForm1.AnimateWindow = true;
            guna2BorderlessForm1.AnimationType = Guna.UI2.WinForms.Guna2BorderlessForm.AnimateWindowType.AW_CENTER;
            guna2BorderlessForm1.BorderRadius = 20;
            guna2BorderlessForm1.ContainerControl = this;
            guna2BorderlessForm1.DockIndicatorTransparencyValue = 0.6D;
            guna2BorderlessForm1.ResizeForm = false;
            guna2BorderlessForm1.ShadowColor = Color.Red;
            guna2BorderlessForm1.TransparentWhileDrag = true;
            // 
            // PreviewForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(633, 325);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "PreviewForm";
            ShowInTaskbar = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "PreviewForm";
            TopMost = true;
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGrid).EndInit();
            panelTitle.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panelTitle;
        private Label label1;
        private Button minimizeBtn;
        private Button exitBtn;
        private DataGridView dataGrid;
        private Guna.UI2.WinForms.Guna2BorderlessForm guna2BorderlessForm1;
    }
}