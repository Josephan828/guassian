namespace MatrixInversion
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
            panelTitle = new Panel();
            label1 = new Label();
            minimizeBtn = new FontAwesome.Sharp.IconButton();
            exitBtn = new FontAwesome.Sharp.IconButton();
            matrixGrid = new DataGridView();
            guna2BorderlessForm1 = new Guna.UI2.WinForms.Guna2BorderlessForm(components);
            guna2DragControl1 = new Guna.UI2.WinForms.Guna2DragControl(components);
            panelTitle.SuspendLayout();
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
            panelTitle.Size = new Size(800, 49);
            panelTitle.TabIndex = 2;
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
            minimizeBtn.Location = new Point(710, 0);
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
            exitBtn.Location = new Point(755, 0);
            exitBtn.Name = "exitBtn";
            exitBtn.Size = new Size(45, 49);
            exitBtn.TabIndex = 1;
            exitBtn.UseVisualStyleBackColor = true;
            // 
            // matrixGrid
            // 
            matrixGrid.AllowUserToAddRows = false;
            matrixGrid.AllowUserToDeleteRows = false;
            matrixGrid.BackgroundColor = Color.White;
            matrixGrid.ColumnHeadersHeight = 29;
            matrixGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            matrixGrid.ColumnHeadersVisible = false;
            matrixGrid.Dock = DockStyle.Top;
            matrixGrid.Location = new Point(0, 49);
            matrixGrid.MultiSelect = false;
            matrixGrid.Name = "matrixGrid";
            matrixGrid.ReadOnly = true;
            matrixGrid.RowHeadersVisible = false;
            matrixGrid.RowHeadersWidth = 51;
            matrixGrid.Size = new Size(800, 234);
            matrixGrid.TabIndex = 3;
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
            // PreviewForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 283);
            Controls.Add(matrixGrid);
            Controls.Add(panelTitle);
            FormBorderStyle = FormBorderStyle.None;
            Name = "PreviewForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "PreviewForm";
            panelTitle.ResumeLayout(false);
            panelTitle.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)matrixGrid).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelTitle;
        private Label label1;
        private FontAwesome.Sharp.IconButton minimizeBtn;
        private FontAwesome.Sharp.IconButton exitBtn;
        private DataGridView matrixGrid;
        private Guna.UI2.WinForms.Guna2BorderlessForm guna2BorderlessForm1;
        private Guna.UI2.WinForms.Guna2DragControl guna2DragControl1;
    }
}