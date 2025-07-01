namespace TaskManagementApp
{
    partial class LoginForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonLI = new Guna.UI2.WinForms.Guna2Button();
            this.GunaLabelLoginForm = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.buttonSU = new Guna.UI2.WinForms.Guna2Button();
            this.textBoxUsername = new Guna.UI2.WinForms.Guna2TextBox();
            this.textBoxPassword = new Guna.UI2.WinForms.Guna2TextBox();
            this.exitLoginFormButton = new Guna.UI2.WinForms.Guna2ControlBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.label1.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label1.Location = new System.Drawing.Point(64, 171);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "Username";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.label2.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label2.Location = new System.Drawing.Point(67, 256);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 22);
            this.label2.TabIndex = 1;
            this.label2.Text = "Password";
            // 
            // buttonLI
            // 
            this.buttonLI.BorderRadius = 20;
            this.buttonLI.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.buttonLI.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.buttonLI.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.buttonLI.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.buttonLI.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.buttonLI.Font = new System.Drawing.Font("Segoe UI Semibold", 16F);
            this.buttonLI.ForeColor = System.Drawing.Color.White;
            this.buttonLI.HoverState.FillColor = System.Drawing.Color.Purple;
            this.buttonLI.Location = new System.Drawing.Point(68, 378);
            this.buttonLI.Name = "buttonLI";
            this.buttonLI.Size = new System.Drawing.Size(348, 45);
            this.buttonLI.TabIndex = 6;
            this.buttonLI.Text = "LOG IN";
            // 
            // GunaLabelLoginForm
            // 
            this.GunaLabelLoginForm.BackColor = System.Drawing.Color.Transparent;
            this.GunaLabelLoginForm.Font = new System.Drawing.Font("Segoe UI Semibold", 55F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GunaLabelLoginForm.ForeColor = System.Drawing.Color.Purple;
            this.GunaLabelLoginForm.Location = new System.Drawing.Point(71, 29);
            this.GunaLabelLoginForm.Name = "GunaLabelLoginForm";
            this.GunaLabelLoginForm.Size = new System.Drawing.Size(344, 100);
            this.GunaLabelLoginForm.TabIndex = 7;
            this.GunaLabelLoginForm.Text = "<b>To-Do List</b>";
            // 
            // buttonSU
            // 
            this.buttonSU.BorderRadius = 20;
            this.buttonSU.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.buttonSU.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.buttonSU.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.buttonSU.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.buttonSU.Font = new System.Drawing.Font("Segoe UI Semibold", 16F);
            this.buttonSU.ForeColor = System.Drawing.Color.White;
            this.buttonSU.Location = new System.Drawing.Point(68, 441);
            this.buttonSU.Name = "buttonSU";
            this.buttonSU.Size = new System.Drawing.Size(348, 45);
            this.buttonSU.TabIndex = 8;
            this.buttonSU.Text = "Sign Up";
            // 
            // textBoxUsername
            // 
            this.textBoxUsername.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textBoxUsername.DefaultText = "";
            this.textBoxUsername.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.textBoxUsername.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.textBoxUsername.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.textBoxUsername.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.textBoxUsername.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.textBoxUsername.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.textBoxUsername.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.textBoxUsername.Location = new System.Drawing.Point(68, 196);
            this.textBoxUsername.Name = "textBoxUsername";
            this.textBoxUsername.PlaceholderText = "";
            this.textBoxUsername.SelectedText = "";
            this.textBoxUsername.Size = new System.Drawing.Size(348, 36);
            this.textBoxUsername.TabIndex = 9;
            // 
            // textBoxPassword
            // 
            this.textBoxPassword.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textBoxPassword.DefaultText = "";
            this.textBoxPassword.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.textBoxPassword.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.textBoxPassword.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.textBoxPassword.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.textBoxPassword.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.textBoxPassword.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.textBoxPassword.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.textBoxPassword.Location = new System.Drawing.Point(68, 281);
            this.textBoxPassword.Name = "textBoxPassword";
            this.textBoxPassword.PlaceholderText = "";
            this.textBoxPassword.SelectedText = "";
            this.textBoxPassword.Size = new System.Drawing.Size(348, 36);
            this.textBoxPassword.TabIndex = 10;
            // 
            // exitLoginFormButton
            // 
            this.exitLoginFormButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.exitLoginFormButton.FillColor = System.Drawing.Color.Transparent;
            this.exitLoginFormButton.Font = new System.Drawing.Font("Segoe UI Semibold", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitLoginFormButton.IconColor = System.Drawing.Color.Red;
            this.exitLoginFormButton.Location = new System.Drawing.Point(425, 12);
            this.exitLoginFormButton.Name = "exitLoginFormButton";
            this.exitLoginFormButton.Size = new System.Drawing.Size(30, 30);
            this.exitLoginFormButton.TabIndex = 11;
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(467, 519);
            this.Controls.Add(this.exitLoginFormButton);
            this.Controls.Add(this.textBoxPassword);
            this.Controls.Add(this.textBoxUsername);
            this.Controls.Add(this.buttonSU);
            this.Controls.Add(this.GunaLabelLoginForm);
            this.Controls.Add(this.buttonLI);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "LoginForm";
            this.Text = "LoginForm";
            this.Load += new System.EventHandler(this.LoginForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2Button buttonLI;
        private Guna.UI2.WinForms.Guna2HtmlLabel GunaLabelLoginForm;
        private Guna.UI2.WinForms.Guna2Button buttonSU;
        private Guna.UI2.WinForms.Guna2TextBox textBoxUsername;
        private Guna.UI2.WinForms.Guna2TextBox textBoxPassword;
        private Guna.UI2.WinForms.Guna2ControlBox exitLoginFormButton;
    }
}