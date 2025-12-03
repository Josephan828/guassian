namespace MatrixInversion
{
    partial class SolverForm
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
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            panelTitle = new Panel();
            label1 = new Label();
            minimizeBtn = new FontAwesome.Sharp.IconButton();
            exitBtn = new FontAwesome.Sharp.IconButton();
            guna2BorderlessForm1 = new Guna.UI2.WinForms.Guna2BorderlessForm(components);
            guna2DragControl1 = new Guna.UI2.WinForms.Guna2DragControl(components);
            panelDesktop = new Panel();
            panel1 = new Panel();
            solveBtn = new Guna.UI2.WinForms.Guna2Button();
            matrixGrid = new DataGridView();
            panelTitle.SuspendLayout();
            panelDesktop.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)matrixGrid).BeginInit();
            SuspendLayout();
            // 
            // panelTitle
            // 
            panelTitle.BackColor = Color.FromArgb(128, 128, 255);
            panelTitle.Controls.Add(label1);
            panelTitle.Controls.Add(minimizeBtn);
            panelTitle.Controls.Add(exitBtn);
            panelTitle.Dock = DockStyle.Top;
            panelTitle.Location = new Point(0, 0);
            panelTitle.Name = "panelTitle";
            panelTitle.Size = new Size(762, 49);
            panelTitle.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            label1.ForeColor = Color.White;
            label1.Location = new Point(3, 9);
            label1.Name = "label1";
            label1.Size = new Size(188, 32);
            label1.TabIndex = 3;
            label1.Text = "Matrix Inverter";
            // 
            // minimizeBtn
            // 
            minimizeBtn.Dock = DockStyle.Right;
            minimizeBtn.FlatAppearance.BorderSize = 0;
            minimizeBtn.FlatStyle = FlatStyle.Flat;
            minimizeBtn.IconChar = FontAwesome.Sharp.IconChar.WindowMinimize;
            minimizeBtn.IconColor = Color.White;
            minimizeBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            minimizeBtn.IconSize = 30;
            minimizeBtn.Location = new Point(672, 0);
            minimizeBtn.Name = "minimizeBtn";
            minimizeBtn.Size = new Size(45, 49);
            minimizeBtn.TabIndex = 2;
            minimizeBtn.UseVisualStyleBackColor = true;
            // 
            // exitBtn
            // 
            exitBtn.Dock = DockStyle.Right;
            exitBtn.FlatAppearance.BorderSize = 0;
            exitBtn.FlatStyle = FlatStyle.Flat;
            exitBtn.IconChar = FontAwesome.Sharp.IconChar.Close;
            exitBtn.IconColor = Color.White;
            exitBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            exitBtn.IconSize = 30;
            exitBtn.Location = new Point(717, 0);
            exitBtn.Name = "exitBtn";
            exitBtn.Size = new Size(45, 49);
            exitBtn.TabIndex = 1;
            exitBtn.UseVisualStyleBackColor = true;
            // 
            // guna2BorderlessForm1
            // 
            guna2BorderlessForm1.AnimateWindow = true;
            guna2BorderlessForm1.AnimationType = Guna.UI2.WinForms.Guna2BorderlessForm.AnimateWindowType.AW_CENTER;
            guna2BorderlessForm1.BorderRadius = 15;
            guna2BorderlessForm1.ContainerControl = this;
            guna2BorderlessForm1.DockForm = false;
            guna2BorderlessForm1.DockIndicatorTransparencyValue = 0.6D;
            guna2BorderlessForm1.ResizeForm = false;
            guna2BorderlessForm1.ShadowColor = Color.Red;
            guna2BorderlessForm1.TransparentWhileDrag = true;
            // 
            // guna2DragControl1
            // 
            guna2DragControl1.DockIndicatorTransparencyValue = 0.6D;
            guna2DragControl1.TargetControl = panelTitle;
            guna2DragControl1.UseTransparentDrag = true;
            // 
            // panelDesktop
            // 
            panelDesktop.BackColor = Color.White;
            panelDesktop.Controls.Add(panel1);
            panelDesktop.Controls.Add(matrixGrid);
            panelDesktop.Dock = DockStyle.Fill;
            panelDesktop.Location = new Point(0, 49);
            panelDesktop.Name = "panelDesktop";
            panelDesktop.Size = new Size(762, 348);
            panelDesktop.TabIndex = 2;
            // 
            // panel1
            // 
            panel1.Controls.Add(solveBtn);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 234);
            panel1.Name = "panel1";
            panel1.Size = new Size(762, 114);
            panel1.TabIndex = 1;
            // 
            // solveBtn
            // 
            solveBtn.BorderRadius = 15;
            solveBtn.CustomizableEdges = customizableEdges1;
            solveBtn.DisabledState.BorderColor = Color.DarkGray;
            solveBtn.DisabledState.CustomBorderColor = Color.DarkGray;
            solveBtn.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            solveBtn.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            solveBtn.FillColor = Color.FromArgb(128, 128, 255);
            solveBtn.Font = new Font("Segoe UI", 14F);
            solveBtn.ForeColor = Color.White;
            solveBtn.Location = new Point(289, 35);
            solveBtn.Name = "solveBtn";
            solveBtn.ShadowDecoration.CustomizableEdges = customizableEdges2;
            solveBtn.Size = new Size(184, 45);
            solveBtn.TabIndex = 2;
            solveBtn.Text = "Solve";
            // 
            // matrixGrid
            // 
            matrixGrid.AllowUserToAddRows = false;
            matrixGrid.AllowUserToDeleteRows = false;
            matrixGrid.BackgroundColor = Color.White;
            matrixGrid.ColumnHeadersHeight = 5;
            matrixGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            matrixGrid.ColumnHeadersVisible = false;
            matrixGrid.Dock = DockStyle.Top;
            matrixGrid.EditMode = DataGridViewEditMode.EditOnEnter;
            matrixGrid.Location = new Point(0, 0);
            matrixGrid.Name = "matrixGrid";
            matrixGrid.RowHeadersVisible = false;
            matrixGrid.RowHeadersWidth = 51;
            matrixGrid.Size = new Size(762, 234);
            matrixGrid.TabIndex = 0;
            // 
            // SolverForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(762, 397);
            Controls.Add(panelDesktop);
            Controls.Add(panelTitle);
            FormBorderStyle = FormBorderStyle.None;
            Name = "SolverForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "SolverForm";
            panelTitle.ResumeLayout(false);
            panelTitle.PerformLayout();
            panelDesktop.ResumeLayout(false);
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)matrixGrid).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelTitle;
        private Label label1;
        private FontAwesome.Sharp.IconButton minimizeBtn;
        private FontAwesome.Sharp.IconButton exitBtn;
        private Guna.UI2.WinForms.Guna2BorderlessForm guna2BorderlessForm1;
        private Panel panelDesktop;
        private DataGridView matrixGrid;
        private Guna.UI2.WinForms.Guna2DragControl guna2DragControl1;
        private Panel panel1;
        private Guna.UI2.WinForms.Guna2Button solveBtn;
    }
}