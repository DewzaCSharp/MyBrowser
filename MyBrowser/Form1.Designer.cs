namespace WinFormsApp2
{
    partial class Form1
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
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges9 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges10 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges11 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges12 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges7 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges8 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges5 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges6 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            guna2BorderlessForm1 = new Guna.UI2.WinForms.Guna2BorderlessForm(components);
            minimizeButton = new Guna.UI2.WinForms.Guna2ControlBox();
            closeButton = new Guna.UI2.WinForms.Guna2ControlBox();
            urlTextBox = new TextBox();
            GoButton = new Guna.UI2.WinForms.Guna2Button();
            ForewardButton = new Guna.UI2.WinForms.Guna2Button();
            BackButton = new Guna.UI2.WinForms.Guna2Button();
            notifyIcon1 = new NotifyIcon(components);
            MyBrowser = new Guna.UI2.WinForms.Guna2ContextMenuStrip();
            About = new ToolStripMenuItem();
            Minimize = new ToolStripMenuItem();
            Quit = new ToolStripMenuItem();
            pictureBox1 = new PictureBox();
            AddTabButton = new Guna.UI2.WinForms.Guna2Button();
            MyBrowser.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // guna2BorderlessForm1
            // 
            guna2BorderlessForm1.BorderRadius = 5;
            guna2BorderlessForm1.ContainerControl = this;
            guna2BorderlessForm1.DockIndicatorTransparencyValue = 0.6D;
            guna2BorderlessForm1.DragStartTransparencyValue = 1D;
            guna2BorderlessForm1.TransparentWhileDrag = true;
            // 
            // minimizeButton
            // 
            minimizeButton.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            minimizeButton.BorderRadius = 5;
            minimizeButton.BorderThickness = 1;
            minimizeButton.ControlBoxStyle = Guna.UI2.WinForms.Enums.ControlBoxStyle.Custom;
            minimizeButton.ControlBoxType = Guna.UI2.WinForms.Enums.ControlBoxType.MinimizeBox;
            minimizeButton.Cursor = Cursors.Hand;
            minimizeButton.CustomizableEdges = customizableEdges9;
            minimizeButton.FillColor = Color.FromArgb(0, 0, 0, 0);
            minimizeButton.HoverState.BorderColor = Color.Orange;
            minimizeButton.HoverState.IconColor = Color.Orange;
            minimizeButton.IconColor = Color.Black;
            minimizeButton.Location = new Point(894, 7);
            minimizeButton.Name = "minimizeButton";
            minimizeButton.ShadowDecoration.CustomizableEdges = customizableEdges10;
            minimizeButton.Size = new Size(45, 29);
            minimizeButton.TabIndex = 12;
            // 
            // closeButton
            // 
            closeButton.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            closeButton.BorderRadius = 5;
            closeButton.BorderThickness = 1;
            closeButton.ControlBoxStyle = Guna.UI2.WinForms.Enums.ControlBoxStyle.Custom;
            closeButton.Cursor = Cursors.Hand;
            closeButton.CustomClick = true;
            closeButton.CustomizableEdges = customizableEdges11;
            closeButton.FillColor = Color.FromArgb(0, 0, 0, 0);
            closeButton.HoverState.BorderColor = Color.Red;
            closeButton.HoverState.IconColor = Color.Red;
            closeButton.IconColor = Color.Black;
            closeButton.Location = new Point(945, 7);
            closeButton.Name = "closeButton";
            closeButton.ShadowDecoration.CustomizableEdges = customizableEdges12;
            closeButton.Size = new Size(45, 29);
            closeButton.TabIndex = 11;
            closeButton.Click += guna2ControlBox1_Click;
            // 
            // urlTextBox
            // 
            urlTextBox.AcceptsReturn = true;
            urlTextBox.Anchor = AnchorStyles.None;
            urlTextBox.Location = new Point(372, 12);
            urlTextBox.Name = "urlTextBox";
            urlTextBox.Size = new Size(259, 23);
            urlTextBox.TabIndex = 7;
            urlTextBox.KeyDown += searchTextBox_KeyDown;
            // 
            // GoButton
            // 
            GoButton.BackColor = Color.FromArgb(0, 0, 0, 0);
            GoButton.BorderRadius = 5;
            GoButton.BorderThickness = 1;
            GoButton.CustomizableEdges = customizableEdges7;
            GoButton.DisabledState.BorderColor = Color.DarkGray;
            GoButton.DisabledState.CustomBorderColor = Color.DarkGray;
            GoButton.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            GoButton.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            GoButton.FillColor = Color.FromArgb(0, 0, 0, 0);
            GoButton.Font = new Font("Segoe UI", 9F);
            GoButton.ForeColor = Color.Black;
            GoButton.Location = new Point(637, 12);
            GoButton.Name = "GoButton";
            GoButton.ShadowDecoration.CustomizableEdges = customizableEdges8;
            GoButton.Size = new Size(65, 23);
            GoButton.TabIndex = 13;
            GoButton.Text = "search";
            GoButton.Click += GoButton_Click;
            // 
            // ForewardButton
            // 
            ForewardButton.BackColor = Color.FromArgb(0, 0, 0, 0);
            ForewardButton.BorderRadius = 5;
            ForewardButton.BorderThickness = 1;
            ForewardButton.CustomizableEdges = customizableEdges5;
            ForewardButton.DisabledState.BorderColor = Color.DarkGray;
            ForewardButton.DisabledState.CustomBorderColor = Color.DarkGray;
            ForewardButton.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            ForewardButton.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            ForewardButton.FillColor = Color.FromArgb(0, 0, 0, 0);
            ForewardButton.Font = new Font("Segoe UI", 9F);
            ForewardButton.ForeColor = Color.Black;
            ForewardButton.Location = new Point(336, 12);
            ForewardButton.Name = "ForewardButton";
            ForewardButton.ShadowDecoration.CustomizableEdges = customizableEdges6;
            ForewardButton.Size = new Size(30, 23);
            ForewardButton.TabIndex = 14;
            ForewardButton.Text = "→";
            ForewardButton.Click += ForewardButton_Click;
            // 
            // BackButton
            // 
            BackButton.AccessibleDescription = "";
            BackButton.BackColor = Color.FromArgb(0, 0, 0, 0);
            BackButton.BorderRadius = 5;
            BackButton.BorderThickness = 1;
            BackButton.CustomizableEdges = customizableEdges3;
            BackButton.DisabledState.BorderColor = Color.DarkGray;
            BackButton.DisabledState.CustomBorderColor = Color.DarkGray;
            BackButton.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            BackButton.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            BackButton.FillColor = Color.FromArgb(0, 0, 0, 0);
            BackButton.Font = new Font("Segoe UI", 9F);
            BackButton.ForeColor = Color.Black;
            BackButton.Location = new Point(300, 12);
            BackButton.Name = "BackButton";
            BackButton.ShadowDecoration.CustomizableEdges = customizableEdges4;
            BackButton.Size = new Size(30, 23);
            BackButton.TabIndex = 15;
            BackButton.Text = "←";
            BackButton.Click += BackButton_Click;
            // 
            // notifyIcon1
            // 
            notifyIcon1.BalloonTipIcon = ToolTipIcon.Info;
            notifyIcon1.BalloonTipText = "MyBrowser is running";
            notifyIcon1.BalloonTipTitle = "MyBrowser";
            notifyIcon1.ContextMenuStrip = MyBrowser;
            notifyIcon1.Icon = (Icon)resources.GetObject("notifyIcon1.Icon");
            notifyIcon1.Text = "MyBrowser";
            notifyIcon1.Visible = true;
            // 
            // MyBrowser
            // 
            MyBrowser.Items.AddRange(new ToolStripItem[] { About, Minimize, Quit });
            MyBrowser.Name = "ContextMenuStrip1";
            MyBrowser.RenderStyle.ArrowColor = Color.FromArgb(151, 143, 255);
            MyBrowser.RenderStyle.BorderColor = Color.Gainsboro;
            MyBrowser.RenderStyle.ColorTable = null;
            MyBrowser.RenderStyle.RoundedEdges = true;
            MyBrowser.RenderStyle.SelectionArrowColor = Color.White;
            MyBrowser.RenderStyle.SelectionBackColor = Color.FromArgb(100, 88, 255);
            MyBrowser.RenderStyle.SelectionForeColor = Color.White;
            MyBrowser.RenderStyle.SeparatorColor = Color.Gainsboro;
            MyBrowser.RenderStyle.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
            MyBrowser.Size = new Size(124, 70);
            MyBrowser.Text = "MyBrowser";
            // 
            // About
            // 
            About.Name = "About";
            About.Size = new Size(123, 22);
            About.Text = "About";
            About.Click += About_Click;
            // 
            // Minimize
            // 
            Minimize.Name = "Minimize";
            Minimize.Size = new Size(123, 22);
            Minimize.Text = "Minimize";
            Minimize.Click += Minimize_Click;
            // 
            // Quit
            // 
            Quit.Name = "Quit";
            Quit.Size = new Size(123, 22);
            Quit.Text = "Quit";
            Quit.Click += Quit_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.FromArgb(0, 0, 0, 0);
            pictureBox1.Cursor = Cursors.Hand;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(142, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(37, 23);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 16;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // AddTabButton
            // 
            AddTabButton.BackColor = Color.FromArgb(0, 0, 0, 0);
            AddTabButton.BorderRadius = 5;
            AddTabButton.BorderThickness = 1;
            AddTabButton.CustomizableEdges = customizableEdges1;
            AddTabButton.DisabledState.BorderColor = Color.DarkGray;
            AddTabButton.DisabledState.CustomBorderColor = Color.DarkGray;
            AddTabButton.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            AddTabButton.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            AddTabButton.FillColor = Color.FromArgb(0, 0, 0, 0);
            AddTabButton.Font = new Font("Segoe UI", 9F);
            AddTabButton.ForeColor = Color.Black;
            AddTabButton.Location = new Point(185, 12);
            AddTabButton.Name = "AddTabButton";
            AddTabButton.ShadowDecoration.CustomizableEdges = customizableEdges2;
            AddTabButton.Size = new Size(30, 27);
            AddTabButton.TabIndex = 17;
            AddTabButton.Text = "+";
            AddTabButton.Click += AddTabButton_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1000, 600);
            Controls.Add(AddTabButton);
            Controls.Add(pictureBox1);
            Controls.Add(BackButton);
            Controls.Add(ForewardButton);
            Controls.Add(GoButton);
            Controls.Add(minimizeButton);
            Controls.Add(closeButton);
            Controls.Add(urlTextBox);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form1";
            Text = "<";
            MyBrowser.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Guna.UI2.WinForms.Guna2BorderlessForm guna2BorderlessForm1;
        private Guna.UI2.WinForms.Guna2ControlBox minimizeButton;
        private Guna.UI2.WinForms.Guna2ControlBox closeButton;
        private TextBox urlTextBox;
        private Guna.UI2.WinForms.Guna2Button GoButton;
        private Guna.UI2.WinForms.Guna2Button BackButton;
        private Guna.UI2.WinForms.Guna2Button ForewardButton;
        private NotifyIcon notifyIcon1;
        private Guna.UI2.WinForms.Guna2ContextMenuStrip MyBrowser;
        private ToolStripMenuItem Minimize;
        private ToolStripMenuItem Quit;
        private ToolStripMenuItem About;
        private PictureBox pictureBox1;
        private Guna.UI2.WinForms.Guna2Button AddTabButton;
    }
}
