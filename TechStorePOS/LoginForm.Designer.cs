namespace TechStorePOS
{
    partial class LoginForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblUsername = new System.Windows.Forms.Label();
            this.lblPassword = new System.Windows.Forms.Label();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.btnLogin = new System.Windows.Forms.Button();
            this.lblMessage = new System.Windows.Forms.Label();
            this.logoBox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.logoBox)).BeginInit();
            this.SuspendLayout();

            // LoginForm Styling
            this.BackColor = System.Drawing.Color.FromArgb(18, 21, 39);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;

            System.Drawing.Font fontLabel = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular);
            System.Drawing.Font fontTitle = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold);
            System.Drawing.Color foreColor = System.Drawing.Color.White;

            // logoBox
            this.logoBox.Location = new System.Drawing.Point(860, 100);
            this.logoBox.Size = new System.Drawing.Size(200, 200);
            this.logoBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.logoBox.BackColor = System.Drawing.Color.Transparent;

            // lblTitle
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = fontTitle;
            this.lblTitle.ForeColor = foreColor;
            this.lblTitle.Location = new System.Drawing.Point(780, 330);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(360, 46);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Login to TechStorePOS";

            // lblUsername
            this.lblUsername.AutoSize = true;
            this.lblUsername.Font = fontLabel;
            this.lblUsername.ForeColor = foreColor;
            this.lblUsername.Location = new System.Drawing.Point(720, 400);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(87, 21);
            this.lblUsername.TabIndex = 1;
            this.lblUsername.Text = "Username:";

            // txtUsername
            this.txtUsername.Font = fontLabel;
            this.txtUsername.Location = new System.Drawing.Point(840, 395);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(240, 29);
            this.txtUsername.TabIndex = 2;
            this.txtUsername.BackColor = System.Drawing.Color.FromArgb(29, 33, 53);
            this.txtUsername.ForeColor = foreColor;
            this.txtUsername.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;

            // lblPassword
            this.lblPassword.AutoSize = true;
            this.lblPassword.Font = fontLabel;
            this.lblPassword.ForeColor = foreColor;
            this.lblPassword.Location = new System.Drawing.Point(720, 450);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(80, 21);
            this.lblPassword.TabIndex = 3;
            this.lblPassword.Text = "Password:";

            // txtPassword
            this.txtPassword.Font = fontLabel;
            this.txtPassword.Location = new System.Drawing.Point(840, 445);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(240, 29);
            this.txtPassword.TabIndex = 4;
            this.txtPassword.UseSystemPasswordChar = true;
            this.txtPassword.BackColor = System.Drawing.Color.FromArgb(29, 33, 53);
            this.txtPassword.ForeColor = foreColor;
            this.txtPassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;

            // btnLogin
            this.btnLogin.Font = fontLabel;
            this.btnLogin.Location = new System.Drawing.Point(840, 500);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(240, 40);
            this.btnLogin.TabIndex = 5;
            this.btnLogin.Text = "Login";
            this.btnLogin.BackColor = System.Drawing.Color.FromArgb(255, 66, 77);
            this.btnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogin.FlatAppearance.BorderSize = 0;
            this.btnLogin.ForeColor = System.Drawing.Color.White;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);

            // lblMessage
            this.lblMessage.AutoSize = true;
            this.lblMessage.ForeColor = System.Drawing.Color.Red;
            this.lblMessage.Font = fontLabel;
            this.lblMessage.Location = new System.Drawing.Point(840, 560);
            this.lblMessage.Name = "lblMessage";
            this.lblMessage.Size = new System.Drawing.Size(0, 21);
            this.lblMessage.TabIndex = 6;

            // LoginForm
            this.Controls.Add(this.logoBox);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.lblUsername);
            this.Controls.Add(this.txtUsername);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.lblMessage);
            this.Name = "LoginForm";
            this.Text = "Login - TechStorePOS";
            this.AcceptButton = this.btnLogin;
            ((System.ComponentModel.ISupportInitialize)(this.logoBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Label lblMessage;
        private System.Windows.Forms.PictureBox logoBox;
    }
}
