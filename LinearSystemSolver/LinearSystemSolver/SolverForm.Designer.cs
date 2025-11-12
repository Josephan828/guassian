using System.Threading.Tasks;

namespace LinearSystemSolver
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
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges5 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges6 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SolverForm));
            guna2BorderlessForm1 = new Guna.UI2.WinForms.Guna2BorderlessForm(components);
            stepsBox = new TextBox();
            panelTitle = new Panel();
            label1 = new Label();
            minimizeBtn = new Button();
            exitBtn = new Button();
            splitter1 = new Splitter();
            panel = new Panel();
            panel2 = new Panel();
            label2 = new Label();
            fastMoodToggle = new Guna.UI2.WinForms.Guna2ToggleSwitch();
            clearBtn = new Guna.UI2.WinForms.Guna2Button();
            solveBtn = new Guna.UI2.WinForms.Guna2Button();
            dataGrid = new DataGridView();
            panelTitle.SuspendLayout();
            panel.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGrid).BeginInit();
            SuspendLayout();
            // 
            // guna2BorderlessForm1
            // 
            guna2BorderlessForm1.AnimateWindow = true;
            guna2BorderlessForm1.AnimationType = Guna.UI2.WinForms.Guna2BorderlessForm.AnimateWindowType.AW_CENTER;
            guna2BorderlessForm1.BorderRadius = 15;
            guna2BorderlessForm1.ContainerControl = this;
            guna2BorderlessForm1.DockIndicatorTransparencyValue = 0.6D;
            guna2BorderlessForm1.ResizeForm = false;
            guna2BorderlessForm1.TransparentWhileDrag = true;
            // 
            // stepsBox
            // 
            stepsBox.Dock = DockStyle.Right;
            stepsBox.Font = new Font("Segoe UI", 10F);
            stepsBox.Location = new Point(570, 41);
            stepsBox.Multiline = true;
            stepsBox.Name = "stepsBox";
            stepsBox.ReadOnly = true;
            stepsBox.ScrollBars = ScrollBars.Vertical;
            stepsBox.Size = new Size(213, 434);
            stepsBox.TabIndex = 2;
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
            panelTitle.Size = new Size(783, 41);
            panelTitle.TabIndex = 5;
            panelTitle.MouseDown += panelTitle_MouseDown;
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
            minimizeBtn.Location = new Point(703, 0);
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
            exitBtn.Location = new Point(743, 0);
            exitBtn.Margin = new Padding(5);
            exitBtn.Name = "exitBtn";
            exitBtn.Size = new Size(40, 41);
            exitBtn.TabIndex = 0;
            exitBtn.Text = "O";
            exitBtn.UseVisualStyleBackColor = true;
            // 
            // splitter1
            // 
            splitter1.Dock = DockStyle.Right;
            splitter1.Location = new Point(566, 41);
            splitter1.Name = "splitter1";
            splitter1.Size = new Size(4, 434);
            splitter1.TabIndex = 8;
            splitter1.TabStop = false;
            // 
            // panel
            // 
            panel.Controls.Add(panel2);
            panel.Controls.Add(dataGrid);
            panel.Dock = DockStyle.Fill;
            panel.Location = new Point(0, 41);
            panel.MinimumSize = new Size(410, 0);
            panel.Name = "panel";
            panel.Size = new Size(566, 434);
            panel.TabIndex = 9;
            // 
            // panel2
            // 
            panel2.Controls.Add(label2);
            panel2.Controls.Add(fastMoodToggle);
            panel2.Controls.Add(clearBtn);
            panel2.Controls.Add(solveBtn);
            panel2.Dock = DockStyle.Bottom;
            panel2.Location = new Point(0, 297);
            panel2.Margin = new Padding(3, 10, 3, 3);
            panel2.Name = "panel2";
            panel2.Size = new Size(566, 137);
            panel2.TabIndex = 9;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Bottom;
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10F);
            label2.Location = new Point(96, 19);
            label2.Name = "label2";
            label2.Size = new Size(89, 23);
            label2.TabIndex = 24;
            label2.Text = "Fast Mood";
            // 
            // fastMoodToggle
            // 
            fastMoodToggle.Anchor = AnchorStyles.Bottom;
            fastMoodToggle.Animated = true;
            fastMoodToggle.AutoRoundedCorners = true;
            fastMoodToggle.CheckedState.BorderColor = Color.FromArgb(94, 148, 255);
            fastMoodToggle.CheckedState.BorderRadius = 11;
            fastMoodToggle.CheckedState.FillColor = Color.FromArgb(128, 128, 255);
            fastMoodToggle.CheckedState.InnerBorderColor = Color.White;
            fastMoodToggle.CheckedState.InnerBorderRadius = 7;
            fastMoodToggle.CheckedState.InnerColor = Color.White;
            fastMoodToggle.CustomizableEdges = customizableEdges1;
            fastMoodToggle.Location = new Point(193, 19);
            fastMoodToggle.Name = "fastMoodToggle";
            fastMoodToggle.ShadowDecoration.BorderRadius = 10;
            fastMoodToggle.ShadowDecoration.CustomizableEdges = customizableEdges2;
            fastMoodToggle.Size = new Size(58, 25);
            fastMoodToggle.TabIndex = 23;
            fastMoodToggle.UncheckedState.BorderColor = Color.FromArgb(125, 137, 149);
            fastMoodToggle.UncheckedState.BorderRadius = 11;
            fastMoodToggle.UncheckedState.FillColor = Color.FromArgb(125, 137, 149);
            fastMoodToggle.UncheckedState.InnerBorderColor = Color.White;
            fastMoodToggle.UncheckedState.InnerBorderRadius = 7;
            fastMoodToggle.UncheckedState.InnerColor = Color.White;
            // 
            // clearBtn
            // 
            clearBtn.Anchor = AnchorStyles.Bottom;
            clearBtn.BorderRadius = 10;
            clearBtn.CustomizableEdges = customizableEdges3;
            clearBtn.DisabledState.BorderColor = Color.DarkGray;
            clearBtn.DisabledState.CustomBorderColor = Color.DarkGray;
            clearBtn.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            clearBtn.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            clearBtn.FillColor = Color.FromArgb(128, 128, 255);
            clearBtn.Font = new Font("Segoe UI", 18F);
            clearBtn.ForeColor = Color.White;
            clearBtn.Location = new Point(315, 57);
            clearBtn.Margin = new Padding(3, 10, 3, 3);
            clearBtn.Name = "clearBtn";
            clearBtn.ShadowDecoration.CustomizableEdges = customizableEdges4;
            clearBtn.Size = new Size(155, 56);
            clearBtn.TabIndex = 22;
            clearBtn.Text = "Clear";
            clearBtn.Click += clearBtn_Click;
            // 
            // solveBtn
            // 
            solveBtn.Anchor = AnchorStyles.Bottom;
            solveBtn.BorderRadius = 10;
            solveBtn.CustomizableEdges = customizableEdges5;
            solveBtn.DisabledState.BorderColor = Color.DarkGray;
            solveBtn.DisabledState.CustomBorderColor = Color.DarkGray;
            solveBtn.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            solveBtn.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            solveBtn.FillColor = Color.FromArgb(128, 128, 255);
            solveBtn.Font = new Font("Segoe UI", 18F);
            solveBtn.ForeColor = Color.White;
            solveBtn.Location = new Point(96, 57);
            solveBtn.Margin = new Padding(3, 10, 3, 3);
            solveBtn.Name = "solveBtn";
            solveBtn.ShadowDecoration.CustomizableEdges = customizableEdges6;
            solveBtn.Size = new Size(155, 56);
            solveBtn.TabIndex = 21;
            solveBtn.Text = "Solve";
            solveBtn.Click += solveBtn_Click;
            // 
            // dataGrid
            // 
            dataGrid.AllowUserToAddRows = false;
            dataGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGrid.BackgroundColor = Color.GhostWhite;
            dataGrid.BorderStyle = BorderStyle.None;
            dataGrid.ColumnHeadersHeight = 35;
            dataGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGrid.Dock = DockStyle.Top;
            dataGrid.EditMode = DataGridViewEditMode.EditOnEnter;
            dataGrid.Location = new Point(0, 0);
            dataGrid.MultiSelect = false;
            dataGrid.Name = "dataGrid";
            dataGrid.RowHeadersVisible = false;
            dataGrid.RowHeadersWidth = 51;
            dataGrid.SelectionMode = DataGridViewSelectionMode.CellSelect;
            dataGrid.Size = new Size(566, 291);
            dataGrid.TabIndex = 8;
            // 
            // SolverForm
            // 
            AutoScaleDimensions = new SizeF(18F, 45F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.GhostWhite;
            ClientSize = new Size(783, 475);
            Controls.Add(panel);
            Controls.Add(splitter1);
            Controls.Add(stepsBox);
            Controls.Add(panelTitle);
            Font = new Font("Segoe UI", 20F);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(7);
            MinimumSize = new Size(627, 0);
            Name = "SolverForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "SolverForm";
            TopMost = true;
            panelTitle.ResumeLayout(false);
            panel.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGrid).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Guna.UI2.WinForms.Guna2BorderlessForm guna2BorderlessForm1;
        private TextBox stepsBox;
        private Panel panelTitle;
        private Label label1;
        private Button minimizeBtn;
        private Button exitBtn;
        private Splitter splitter1;
        private Panel panel;
        private DataGridView dataGrid;
        private Panel panel2;
        private Label label2;
        private Guna.UI2.WinForms.Guna2ToggleSwitch fastMoodToggle;
        private Guna.UI2.WinForms.Guna2Button clearBtn;
        private Guna.UI2.WinForms.Guna2Button solveBtn;
    }
}