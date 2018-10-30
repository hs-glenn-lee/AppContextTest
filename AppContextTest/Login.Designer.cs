namespace AppContextTest
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
            this.label1 = new System.Windows.Forms.Label();
            this.UserNameTextBox = new System.Windows.Forms.TextBox();
            this.LoginButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.StateLabel = new System.Windows.Forms.Label();
            this.AppAuthStateMessage = new System.Windows.Forms.Label();
            this.PasswordTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "사용자명";
            // 
            // UserNameTextBox
            // 
            this.UserNameTextBox.Location = new System.Drawing.Point(95, 42);
            this.UserNameTextBox.Name = "UserNameTextBox";
            this.UserNameTextBox.Size = new System.Drawing.Size(178, 25);
            this.UserNameTextBox.TabIndex = 1;
            // 
            // LoginButton
            // 
            this.LoginButton.Location = new System.Drawing.Point(114, 125);
            this.LoginButton.Name = "LoginButton";
            this.LoginButton.Size = new System.Drawing.Size(75, 23);
            this.LoginButton.TabIndex = 2;
            this.LoginButton.Text = "로그인";
            this.LoginButton.UseVisualStyleBackColor = true;
            this.LoginButton.Click += new System.EventHandler(this.LoginButton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "비밀번호";
            // 
            // StateLabel
            // 
            this.StateLabel.AutoSize = true;
            this.StateLabel.Location = new System.Drawing.Point(12, 208);
            this.StateLabel.Name = "StateLabel";
            this.StateLabel.Size = new System.Drawing.Size(87, 15);
            this.StateLabel.TabIndex = 4;
            this.StateLabel.Text = "로그인 상태";
            // 
            // AppAuthStateMessage
            // 
            this.AppAuthStateMessage.AutoSize = true;
            this.AppAuthStateMessage.Location = new System.Drawing.Point(121, 208);
            this.AppAuthStateMessage.Name = "AppAuthStateMessage";
            this.AppAuthStateMessage.Size = new System.Drawing.Size(152, 15);
            this.AppAuthStateMessage.TabIndex = 5;
            this.AppAuthStateMessage.Text = "로그인이 필요합니다.";
            // 
            // PasswordTextBox
            // 
            this.PasswordTextBox.Location = new System.Drawing.Point(95, 79);
            this.PasswordTextBox.Name = "PasswordTextBox";
            this.PasswordTextBox.Size = new System.Drawing.Size(178, 25);
            this.PasswordTextBox.TabIndex = 6;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(426, 396);
            this.Controls.Add(this.PasswordTextBox);
            this.Controls.Add(this.AppAuthStateMessage);
            this.Controls.Add(this.StateLabel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.LoginButton);
            this.Controls.Add(this.UserNameTextBox);
            this.Controls.Add(this.label1);
            this.Name = "Login";
            this.Text = "Login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox UserNameTextBox;
        private System.Windows.Forms.Button LoginButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label StateLabel;
        private System.Windows.Forms.Label AppAuthStateMessage;
        private System.Windows.Forms.TextBox PasswordTextBox;
    }
}