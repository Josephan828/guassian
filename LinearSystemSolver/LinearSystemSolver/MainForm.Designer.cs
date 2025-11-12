namespace LinearSystemSolver
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
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            panelTitle = new Panel();
            label1 = new Label();
            minimizeBtn = new Button();
            exitBtn = new Button();
            panelDesktop = new Panel();
            dataBtn = new FontAwesome.Sharp.IconButton();
            label3 = new Label();
            varsValue = new Guna.UI2.WinForms.Guna2NumericUpDown();
            label2 = new Label();
            eqsValue = new Guna.UI2.WinForms.Guna2NumericUpDown();
            guna2ShadowForm1 = new Guna.UI2.WinForms.Guna2ShadowForm(components);
            guna2BorderlessForm1 = new Guna.UI2.WinForms.Guna2BorderlessForm(components);
            panelTitle.SuspendLayout();
            panelDesktop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)varsValue).BeginInit();
            ((System.ComponentModel.ISupportInitialize)eqsValue).BeginInit();
            SuspendLayout();
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
            panelTitle.Size = new Size(536, 41);
            panelTitle.TabIndex = 0;
            panelTitle.MouseDown += panelTitle_MouseDown;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Dock = DockStyle.Left;
            label1.ForeColor = Color.White;
            label1.Location = new Point(0, 0);
            label1.Name = "label1";
            label1.Size = new Size(242, 35);
            label1.TabIndex = 2;
            label1.Text = "Linear System Solver";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // minimizeBtn
            // 
            minimizeBtn.Dock = DockStyle.Right;
            minimizeBtn.FlatAppearance.BorderSize = 0;
            minimizeBtn.FlatStyle = FlatStyle.Flat;
            minimizeBtn.ForeColor = Color.White;
            minimizeBtn.Location = new Point(456, 0);
            minimizeBtn.Margin = new Padding(5);
            minimizeBtn.Name = "minimizeBtn";
            minimizeBtn.Size = new Size(40, 41);
            minimizeBtn.TabIndex = 1;
            minimizeBtn.Text = "O";
            minimizeBtn.UseVisualStyleBackColor = true;
            minimizeBtn.Click += manimizeBtn_Click;
            // 
            // exitBtn
            // 
            exitBtn.Dock = DockStyle.Right;
            exitBtn.FlatAppearance.BorderSize = 0;
            exitBtn.FlatStyle = FlatStyle.Flat;
            exitBtn.ForeColor = Color.White;
            exitBtn.Location = new Point(496, 0);
            exitBtn.Margin = new Padding(5);
            exitBtn.Name = "exitBtn";
            exitBtn.Size = new Size(40, 41);
            exitBtn.TabIndex = 0;
            exitBtn.Text = "O";
            exitBtn.UseVisualStyleBackColor = true;
            // 
            // panelDesktop
            // 
            panelDesktop.Controls.Add(dataBtn);
            panelDesktop.Controls.Add(label3);
            panelDesktop.Controls.Add(varsValue);
            panelDesktop.Controls.Add(label2);
            panelDesktop.Controls.Add(eqsValue);
            panelDesktop.Dock = DockStyle.Fill;
            panelDesktop.Location = new Point(0, 41);
            panelDesktop.Name = "panelDesktop";
            panelDesktop.Size = new Size(536, 271);
            panelDesktop.TabIndex = 1;
            // 
            // dataBtn
            // 
            dataBtn.BackColor = Color.Transparent;
            dataBtn.Cursor = Cursors.Hand;
            dataBtn.FlatAppearance.BorderColor = Color.GhostWhite;
            dataBtn.FlatAppearance.BorderSize = 0;
            dataBtn.FlatAppearance.MouseDownBackColor = Color.Transparent;
            dataBtn.FlatAppearance.MouseOverBackColor = Color.Transparent;
            dataBtn.FlatStyle = FlatStyle.Flat;
            dataBtn.IconChar = FontAwesome.Sharp.IconChar.TableList;
            dataBtn.IconColor = Color.FromArgb(128, 128, 255);
            dataBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            dataBtn.IconSize = 96;
            dataBtn.Location = new Point(226, 166);
            dataBtn.Name = "dataBtn";
            dataBtn.Size = new Size(76, 87);
            dataBtn.TabIndex = 10;
            dataBtn.UseVisualStyleBackColor = false;
            dataBtn.Click += dataBtn_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            label3.Location = new Point(92, 107);
            label3.Name = "label3";
            label3.Size = new Size(173, 35);
            label3.TabIndex = 9;
            label3.Text = "NO. Variables";
            // 
            // varsValue
            // 
            varsValue.BackColor = Color.Transparent;
            varsValue.BorderRadius = 10;
            varsValue.CustomizableEdges = customizableEdges1;
            varsValue.DisabledState.BorderColor = Color.FromArgb(128, 128, 255);
            varsValue.FillColor = Color.GhostWhite;
            varsValue.FocusedState.BorderColor = Color.FromArgb(128, 128, 255);
            varsValue.Font = new Font("Segoe UI", 20F);
            varsValue.Location = new Point(302, 95);
            varsValue.Margin = new Padding(3, 4, 3, 4);
            varsValue.Maximum = new decimal(new int[] { 10, 0, 0, 0 });
            varsValue.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            varsValue.Name = "varsValue";
            varsValue.ShadowDecoration.CustomizableEdges = customizableEdges2;
            varsValue.Size = new Size(142, 47);
            varsValue.TabIndex = 8;
            varsValue.UpDownButtonFillColor = Color.FromArgb(128, 128, 255);
            varsValue.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            label2.Location = new Point(92, 41);
            label2.Name = "label2";
            label2.Size = new Size(181, 35);
            label2.TabIndex = 7;
            label2.Text = "NO. Equations";
            // 
            // eqsValue
            // 
            eqsValue.BackColor = Color.Transparent;
            eqsValue.BorderRadius = 10;
            eqsValue.CustomizableEdges = customizableEdges3;
            eqsValue.DisabledState.BorderColor = Color.FromArgb(128, 128, 255);
            eqsValue.FillColor = Color.GhostWhite;
            eqsValue.FocusedState.BorderColor = Color.FromArgb(128, 128, 255);
            eqsValue.Font = new Font("Segoe UI", 20F);
            eqsValue.Location = new Point(302, 29);
            eqsValue.Margin = new Padding(3, 4, 3, 4);
            eqsValue.Maximum = new decimal(new int[] { 10, 0, 0, 0 });
            eqsValue.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            eqsValue.Name = "eqsValue";
            eqsValue.ShadowDecoration.CustomizableEdges = customizableEdges4;
            eqsValue.Size = new Size(142, 47);
            eqsValue.TabIndex = 6;
            eqsValue.UpDownButtonFillColor = Color.FromArgb(128, 128, 255);
            eqsValue.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // guna2ShadowForm1
            // 
            guna2ShadowForm1.ShadowColor = Color.Red;
            guna2ShadowForm1.TargetForm = this;
            // 
            // guna2BorderlessForm1
            // 
            guna2BorderlessForm1.AnimateWindow = true;
            guna2BorderlessForm1.BorderRadius = 15;
            guna2BorderlessForm1.ContainerControl = this;
            guna2BorderlessForm1.DockIndicatorTransparencyValue = 0.6D;
            guna2BorderlessForm1.ResizeForm = false;
            guna2BorderlessForm1.TransparentWhileDrag = true;
            // 
            // MainForm
            // 
            AcceptButton = dataBtn;
            AutoScaleDimensions = new SizeF(14F, 35F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.GhostWhite;
            ClientSize = new Size(536, 312);
            ControlBox = false;
            Controls.Add(panelDesktop);
            Controls.Add(panelTitle);
            Font = new Font("Segoe UI", 15F);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(5);
            Name = "MainForm";
            StartPosition = FormStartPosition.CenterScreen;
            panelTitle.ResumeLayout(false);
            panelTitle.PerformLayout();
            panelDesktop.ResumeLayout(false);
            panelDesktop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)varsValue).EndInit();
            ((System.ComponentModel.ISupportInitialize)eqsValue).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelTitle;
        private Label label1;
        private Button minimizeBtn;
        private Button exitBtn;
        private Panel panelDesktop;
        private FontAwesome.Sharp.IconButton dataBtn;
        private Label label3;
        private Guna.UI2.WinForms.Guna2NumericUpDown varsValue;
        private Label label2;
        private Guna.UI2.WinForms.Guna2NumericUpDown eqsValue;
        private Guna.UI2.WinForms.Guna2ShadowForm guna2ShadowForm1;
        private Guna.UI2.WinForms.Guna2BorderlessForm guna2BorderlessForm1;
    }
}
