namespace MyBrowser
{
    partial class Settings
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
            guna2BorderlessForm1 = new Guna.UI2.WinForms.Guna2BorderlessForm(components);
            guna2CheckBox1 = new Guna.UI2.WinForms.Guna2CheckBox();
            label1 = new Label();
            closeButton = new Guna.UI2.WinForms.Guna2ControlBox();
            SuspendLayout();
            // 
            // guna2BorderlessForm1
            // 
            guna2BorderlessForm1.ContainerControl = this;
            guna2BorderlessForm1.DockIndicatorTransparencyValue = 0.6D;
            guna2BorderlessForm1.TransparentWhileDrag = true;
            // 
            // guna2CheckBox1
            // 
            guna2CheckBox1.AutoSize = true;
            guna2CheckBox1.CheckedState.BorderColor = Color.FromArgb(94, 148, 255);
            guna2CheckBox1.CheckedState.BorderRadius = 0;
            guna2CheckBox1.CheckedState.BorderThickness = 0;
            guna2CheckBox1.CheckedState.FillColor = Color.FromArgb(94, 148, 255);
            guna2CheckBox1.Location = new Point(12, 82);
            guna2CheckBox1.Name = "guna2CheckBox1";
            guna2CheckBox1.Size = new Size(91, 19);
            guna2CheckBox1.TabIndex = 0;
            guna2CheckBox1.Text = "Gen Z Mode";
            guna2CheckBox1.UncheckedState.BorderColor = Color.FromArgb(125, 137, 149);
            guna2CheckBox1.UncheckedState.BorderRadius = 0;
            guna2CheckBox1.UncheckedState.BorderThickness = 0;
            guna2CheckBox1.UncheckedState.FillColor = Color.FromArgb(125, 137, 149);
            guna2CheckBox1.CheckedChanged += guna2CheckBox1_CheckedChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 13F);
            label1.Location = new Point(179, 9);
            label1.Name = "label1";
            label1.Size = new Size(76, 25);
            label1.TabIndex = 1;
            label1.Text = "Settings";
            // 
            // closeButton
            // 
            closeButton.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            closeButton.BorderRadius = 5;
            closeButton.BorderThickness = 1;
            closeButton.ControlBoxStyle = Guna.UI2.WinForms.Enums.ControlBoxStyle.Custom;
            closeButton.Cursor = Cursors.Hand;
            closeButton.CustomClick = true;
            closeButton.CustomizableEdges = customizableEdges1;
            closeButton.FillColor = Color.FromArgb(0, 0, 0, 0);
            closeButton.HoverState.BorderColor = Color.Red;
            closeButton.HoverState.IconColor = Color.Red;
            closeButton.IconColor = Color.Black;
            closeButton.Location = new Point(396, 9);
            closeButton.Name = "closeButton";
            closeButton.ShadowDecoration.CustomizableEdges = customizableEdges2;
            closeButton.Size = new Size(45, 29);
            closeButton.TabIndex = 12;
            closeButton.Click += closeButton_Click;
            // 
            // Settings
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(453, 468);
            Controls.Add(closeButton);
            Controls.Add(label1);
            Controls.Add(guna2CheckBox1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Settings";
            Text = "Settings";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Guna.UI2.WinForms.Guna2BorderlessForm guna2BorderlessForm1;
        private Label label1;
        private Guna.UI2.WinForms.Guna2CheckBox guna2CheckBox1;
        private Guna.UI2.WinForms.Guna2ControlBox closeButton;
    }
}