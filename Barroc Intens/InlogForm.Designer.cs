namespace Barroc_Intens
{
    partial class InlogForm
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
            this.txbUsername = new System.Windows.Forms.TextBox();
            this.lblUsername = new System.Windows.Forms.Label();
            this.txbPassword = new System.Windows.Forms.TextBox();
            this.lblPassword = new System.Windows.Forms.Label();
            this.lblInformation = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnLogin = new System.Windows.Forms.Button();
            this.lblError = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // txbUsername
            // 
            this.txbUsername.Location = new System.Drawing.Point(200, 216);
            this.txbUsername.Name = "txbUsername";
            this.txbUsername.Size = new System.Drawing.Size(189, 22);
            this.txbUsername.TabIndex = 0;
            this.txbUsername.TextChanged += new System.EventHandler(this.txbUsername_TextChanged);
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.Location = new System.Drawing.Point(106, 219);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(70, 16);
            this.lblUsername.TabIndex = 1;
            this.lblUsername.Text = "Username";
            // 
            // txbPassword
            // 
            this.txbPassword.Location = new System.Drawing.Point(200, 244);
            this.txbPassword.Name = "txbPassword";
            this.txbPassword.PasswordChar = 'ඞ';
            this.txbPassword.Size = new System.Drawing.Size(189, 22);
            this.txbPassword.TabIndex = 2;
            this.txbPassword.TextChanged += new System.EventHandler(this.txbPassword_TextChanged);
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Location = new System.Drawing.Point(106, 247);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(67, 16);
            this.lblPassword.TabIndex = 3;
            this.lblPassword.Text = "Password";
            // 
            // lblInformation
            // 
            this.lblInformation.AutoSize = true;
            this.lblInformation.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInformation.Location = new System.Drawing.Point(237, 92);
            this.lblInformation.Name = "lblInformation";
            this.lblInformation.Size = new System.Drawing.Size(110, 31);
            this.lblInformation.TabIndex = 4;
            this.lblInformation.Text = "Inloggen";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Barroc_Intens.Properties.Resources.Logo6_klein;
            this.pictureBox1.Location = new System.Drawing.Point(30, 23);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 100);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // btnLogin
            // 
            this.btnLogin.Location = new System.Drawing.Point(200, 335);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(189, 66);
            this.btnLogin.TabIndex = 6;
            this.btnLogin.Text = "Inloggen";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // lblError
            // 
            this.lblError.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lblError.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblError.ForeColor = System.Drawing.Color.Red;
            this.lblError.Location = new System.Drawing.Point(0, 422);
            this.lblError.Name = "lblError";
            this.lblError.Size = new System.Drawing.Size(542, 23);
            this.lblError.TabIndex = 7;
            this.lblError.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // InlogForm
            // 
            this.AcceptButton = this.btnLogin;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(542, 445);
            this.Controls.Add(this.lblError);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lblInformation);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.txbPassword);
            this.Controls.Add(this.lblUsername);
            this.Controls.Add(this.txbUsername);
            this.Name = "InlogForm";
            this.Text = "InlogForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.InlogForm_FormClosing);
            this.Load += new System.EventHandler(this.InlogForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txbUsername;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.TextBox txbPassword;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.Label lblInformation;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Label lblError;
    }
}