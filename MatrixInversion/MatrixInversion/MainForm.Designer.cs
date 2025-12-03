namespace MatrixInversion
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            guna2BorderlessForm1 = new Guna.UI2.WinForms.Guna2BorderlessForm(components);
            panelTitle = new Panel();
            label1 = new Label();
            minimizeBtn = new FontAwesome.Sharp.IconButton();
            exitBtn = new FontAwesome.Sharp.IconButton();
            guna2DragControl1 = new Guna.UI2.WinForms.Guna2DragControl(components);
            label2 = new Label();
            label3 = new Label();
            rowsValue = new Guna.UI2.WinForms.Guna2NumericUpDown();
            colsValue = new Guna.UI2.WinForms.Guna2NumericUpDown();
            dataBtn = new FontAwesome.Sharp.IconButton();
            panelTitle.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)rowsValue).BeginInit();
            ((System.ComponentModel.ISupportInitialize)colsValue).BeginInit();
            SuspendLayout();
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
            // panelTitle
            // 
            panelTitle.BackColor = Color.FromArgb(128, 128, 255);
            panelTitle.Controls.Add(label1);
            panelTitle.Controls.Add(minimizeBtn);
            panelTitle.Controls.Add(exitBtn);
            panelTitle.Dock = DockStyle.Top;
            panelTitle.Location = new Point(0, 0);
            panelTitle.Name = "panelTitle";
            panelTitle.Size = new Size(633, 49);
            panelTitle.TabIndex = 0;
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
            minimizeBtn.Location = new Point(543, 0);
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
            exitBtn.Location = new Point(588, 0);
            exitBtn.Name = "exitBtn";
            exitBtn.Size = new Size(45, 49);
            exitBtn.TabIndex = 1;
            exitBtn.UseVisualStyleBackColor = true;
            // 
            // guna2DragControl1
            // 
            guna2DragControl1.DockIndicatorTransparencyValue = 0.6D;
            guna2DragControl1.TargetControl = panelTitle;
            guna2DragControl1.UseTransparentDrag = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(138, 91);
            label2.Name = "label2";
            label2.Size = new Size(178, 31);
            label2.TabIndex = 1;
            label2.Text = "Enter NO. Rows";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(138, 152);
            label3.Name = "label3";
            label3.Size = new Size(173, 31);
            label3.TabIndex = 2;
            label3.Text = "Enter NO.  Cols";
            // 
            // rowsValue
            // 
            rowsValue.BackColor = Color.Transparent;
            rowsValue.BorderRadius = 7;
            rowsValue.CustomizableEdges = customizableEdges3;
            rowsValue.Font = new Font("Segoe UI", 13.8F);
            rowsValue.Location = new Point(353, 81);
            rowsValue.Margin = new Padding(3, 4, 3, 4);
            rowsValue.Name = "rowsValue";
            rowsValue.ShadowDecoration.CustomizableEdges = customizableEdges4;
            rowsValue.Size = new Size(141, 41);
            rowsValue.TabIndex = 3;
            rowsValue.UpDownButtonFillColor = Color.FromArgb(128, 128, 255);
            rowsValue.UpDownButtonForeColor = Color.White;
            // 
            // colsValue
            // 
            colsValue.BackColor = Color.Transparent;
            colsValue.BorderRadius = 7;
            colsValue.CustomizableEdges = customizableEdges1;
            colsValue.Font = new Font("Segoe UI", 13.8F);
            colsValue.Location = new Point(353, 149);
            colsValue.Margin = new Padding(3, 4, 3, 4);
            colsValue.Name = "colsValue";
            colsValue.ShadowDecoration.CustomizableEdges = customizableEdges2;
            colsValue.Size = new Size(141, 41);
            colsValue.TabIndex = 3;
            colsValue.UpDownButtonFillColor = Color.FromArgb(128, 128, 255);
            colsValue.UpDownButtonForeColor = Color.White;
            // 
            // dataBtn
            // 
            dataBtn.Cursor = Cursors.Hand;
            dataBtn.FlatAppearance.BorderSize = 0;
            dataBtn.FlatAppearance.MouseDownBackColor = Color.Transparent;
            dataBtn.FlatAppearance.MouseOverBackColor = Color.Transparent;
            dataBtn.FlatStyle = FlatStyle.Flat;
            dataBtn.IconChar = FontAwesome.Sharp.IconChar.TableList;
            dataBtn.IconColor = Color.FromArgb(128, 128, 255);
            dataBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            dataBtn.IconSize = 75;
            dataBtn.Location = new Point(283, 209);
            dataBtn.Name = "dataBtn";
            dataBtn.Size = new Size(67, 62);
            dataBtn.TabIndex = 4;
            dataBtn.UseVisualStyleBackColor = true;
            dataBtn.Click += dataBtn_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(633, 298);
            Controls.Add(dataBtn);
            Controls.Add(colsValue);
            Controls.Add(rowsValue);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(panelTitle);
            FormBorderStyle = FormBorderStyle.None;
            Name = "MainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            panelTitle.ResumeLayout(false);
            panelTitle.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)rowsValue).EndInit();
            ((System.ComponentModel.ISupportInitialize)colsValue).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Guna.UI2.WinForms.Guna2BorderlessForm guna2BorderlessForm1;
        private Panel panelTitle;
        private FontAwesome.Sharp.IconButton minimizeBtn;
        private FontAwesome.Sharp.IconButton exitBtn;
        private Label label1;
        private Guna.UI2.WinForms.Guna2DragControl guna2DragControl1;
        private Guna.UI2.WinForms.Guna2NumericUpDown colsValue;
        private Guna.UI2.WinForms.Guna2NumericUpDown rowsValue;
        private Label label3;
        private Label label2;
        private FontAwesome.Sharp.IconButton dataBtn;
    }
}
