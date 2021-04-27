
namespace projekt_2021_Olle
{
    partial class Login
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
            this.Txtbx_Username = new System.Windows.Forms.TextBox();
            this.Txtbx_Password = new System.Windows.Forms.TextBox();
            this.Btn_LogIn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Btn_SignIn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Txtbx_Username
            // 
            this.Txtbx_Username.Location = new System.Drawing.Point(171, 49);
            this.Txtbx_Username.Name = "Txtbx_Username";
            this.Txtbx_Username.Size = new System.Drawing.Size(138, 20);
            this.Txtbx_Username.TabIndex = 0;
            // 
            // Txtbx_Password
            // 
            this.Txtbx_Password.Location = new System.Drawing.Point(171, 87);
            this.Txtbx_Password.Name = "Txtbx_Password";
            this.Txtbx_Password.Size = new System.Drawing.Size(138, 20);
            this.Txtbx_Password.TabIndex = 1;
            // 
            // Btn_LogIn
            // 
            this.Btn_LogIn.Location = new System.Drawing.Point(245, 135);
            this.Btn_LogIn.Name = "Btn_LogIn";
            this.Btn_LogIn.Size = new System.Drawing.Size(64, 23);
            this.Btn_LogIn.TabIndex = 2;
            this.Btn_LogIn.Text = "Login";
            this.Btn_LogIn.UseVisualStyleBackColor = true;
            this.Btn_LogIn.Click += new System.EventHandler(this.Btn_LogIn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(102, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Username";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(102, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Password";
            // 
            // Btn_SignIn
            // 
            this.Btn_SignIn.Location = new System.Drawing.Point(171, 134);
            this.Btn_SignIn.Name = "Btn_SignIn";
            this.Btn_SignIn.Size = new System.Drawing.Size(57, 23);
            this.Btn_SignIn.TabIndex = 5;
            this.Btn_SignIn.Text = "Sign in";
            this.Btn_SignIn.UseVisualStyleBackColor = true;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(465, 232);
            this.Controls.Add(this.Btn_SignIn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Btn_LogIn);
            this.Controls.Add(this.Txtbx_Password);
            this.Controls.Add(this.Txtbx_Username);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "Login";
            this.Text = "Login";
            this.Load += new System.EventHandler(this.Login_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Txtbx_Username;
        private System.Windows.Forms.TextBox Txtbx_Password;
        private System.Windows.Forms.Button Btn_LogIn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button Btn_SignIn;
    }
}