namespace TaskManagementApp
{
    partial class SignUpForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && components != null) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtFullName = new System.Windows.Forms.TextBox();
            this.btnRegister = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1 - Username
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(40, 30);
            this.label1.Text = "Username";
            // 
            // label2 - Password
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(40, 70);
            this.label2.Text = "Password";
            // 
            // label3 - Full Name
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(40, 110);
            this.label3.Text = "Full Name";
            // 
            // txtUsername
            // 
            this.txtUsername.Location = new System.Drawing.Point(140, 27);
            this.txtUsername.Size = new System.Drawing.Size(180, 20);
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(140, 67);
            this.txtPassword.Size = new System.Drawing.Size(180, 20);
            // 
            // txtFullName
            // 
            this.txtFullName.Location = new System.Drawing.Point(140, 107);
            this.txtFullName.Size = new System.Drawing.Size(180, 20);
            // 
            // btnRegister
            // 
            this.btnRegister.Location = new System.Drawing.Point(140, 150);
            this.btnRegister.Size = new System.Drawing.Size(100, 30);
            this.btnRegister.Text = "Register";
            this.btnRegister.UseVisualStyleBackColor = true;

            // 
            // SignUpForm
            // 
            this.ClientSize = new System.Drawing.Size(380, 210);
            this.Controls.Add(this.btnRegister);
            this.Controls.Add(this.txtFullName);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtUsername);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "SignUpForm";
            this.Text = "Sign Up";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.TextBox txtFullName;
        private System.Windows.Forms.Button btnRegister;
    }
}

