namespace LinearSystemSolver
{
    partial class SplashForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SplashForm));
            CircleProgressBar = new Guna.UI2.WinForms.Guna2CircleProgressBar();
            progressTimer = new System.Windows.Forms.Timer(components);
            label1 = new Label();
            guna2BorderlessForm1 = new Guna.UI2.WinForms.Guna2BorderlessForm(components);
            label2 = new Label();
            SuspendLayout();
            // 
            // CircleProgressBar
            // 
            CircleProgressBar.Animated = true;
            CircleProgressBar.FillColor = Color.White;
            CircleProgressBar.FillThickness = 12;
            CircleProgressBar.Font = new Font("Segoe UI", 12F);
            CircleProgressBar.ForeColor = Color.White;
            CircleProgressBar.Location = new Point(226, 111);
            CircleProgressBar.Minimum = 0;
            CircleProgressBar.Name = "CircleProgressBar";
            CircleProgressBar.ProgressColor = Color.MediumBlue;
            CircleProgressBar.ProgressColor2 = Color.MediumBlue;
            CircleProgressBar.ProgressEndCap = System.Drawing.Drawing2D.LineCap.Round;
            CircleProgressBar.ProgressStartCap = System.Drawing.Drawing2D.LineCap.Round;
            CircleProgressBar.ProgressThickness = 12;
            CircleProgressBar.ShadowDecoration.BorderRadius = 10;
            CircleProgressBar.ShadowDecoration.CustomizableEdges = customizableEdges1;
            CircleProgressBar.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            CircleProgressBar.ShowText = true;
            CircleProgressBar.Size = new Size(162, 162);
            CircleProgressBar.TabIndex = 0;
            CircleProgressBar.Text = "guna2CircleProgressBar1";
            // 
            // progressTimer
            // 
            progressTimer.Enabled = true;
            progressTimer.Interval = 120;
            progressTimer.Tick += progressTimer_Tick;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            label1.ForeColor = Color.GhostWhite;
            label1.Location = new Point(133, 24);
            label1.Name = "label1";
            label1.Size = new Size(349, 46);
            label1.TabIndex = 1;
            label1.Text = "Linear System Solver";
            // 
            // guna2BorderlessForm1
            // 
            guna2BorderlessForm1.AnimateWindow = true;
            guna2BorderlessForm1.AnimationType = Guna.UI2.WinForms.Guna2BorderlessForm.AnimateWindowType.AW_CENTER;
            guna2BorderlessForm1.BorderRadius = 20;
            guna2BorderlessForm1.ContainerControl = this;
            guna2BorderlessForm1.DockIndicatorTransparencyValue = 0.6D;
            guna2BorderlessForm1.DragForm = false;
            guna2BorderlessForm1.ResizeForm = false;
            guna2BorderlessForm1.ShadowColor = Color.Red;
            guna2BorderlessForm1.TransparentWhileDrag = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F);
            label2.Location = new Point(193, 316);
            label2.Name = "label2";
            label2.Size = new Size(232, 56);
            label2.TabIndex = 2;
            label2.Text = "© 2025 Eng. Yousef Yahia\r\nAll Rights Reserved\r\n";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // SplashForm
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(128, 128, 255);
            ClientSize = new Size(615, 396);
            ControlBox = false;
            Controls.Add(label2);
            Controls.Add(CircleProgressBar);
            Controls.Add(label1);
            Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "SplashForm";
            ShowInTaskbar = false;
            StartPosition = FormStartPosition.CenterScreen;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Guna.UI2.WinForms.Guna2CircleProgressBar CircleProgressBar;
        private System.Windows.Forms.Timer progressTimer;
        private Label label1;
        private Guna.UI2.WinForms.Guna2BorderlessForm guna2BorderlessForm1;
        private Label label2;
    }
}