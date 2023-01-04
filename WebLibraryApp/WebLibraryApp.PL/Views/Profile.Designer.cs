namespace WebLibraryApp.PL.Views
{
    partial class Profile
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
            this.LogOutButton = new System.Windows.Forms.Button();
            this.MainWindowButton = new System.Windows.Forms.Button();
            this.LabelFirstName = new System.Windows.Forms.Label();
            this.LabelSecondName = new System.Windows.Forms.Label();
            this.LabelLogin = new System.Windows.Forms.Label();
            this.LabelDate = new System.Windows.Forms.Label();
            this.DeleteUserButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LogOutButton
            // 
            this.LogOutButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(170)))), ((int)(((byte)(191)))));
            this.LogOutButton.FlatAppearance.BorderSize = 0;
            this.LogOutButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LogOutButton.Font = new System.Drawing.Font("Cascadia Code", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LogOutButton.ForeColor = System.Drawing.Color.White;
            this.LogOutButton.Location = new System.Drawing.Point(542, 12);
            this.LogOutButton.Name = "LogOutButton";
            this.LogOutButton.Size = new System.Drawing.Size(223, 65);
            this.LogOutButton.TabIndex = 16;
            this.LogOutButton.Text = "Log out";
            this.LogOutButton.UseVisualStyleBackColor = false;
            this.LogOutButton.Click += new System.EventHandler(this.LogOutButton_Click);
            // 
            // MainWindowButton
            // 
            this.MainWindowButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(170)))), ((int)(((byte)(191)))));
            this.MainWindowButton.FlatAppearance.BorderSize = 0;
            this.MainWindowButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MainWindowButton.Font = new System.Drawing.Font("Cascadia Code", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.MainWindowButton.ForeColor = System.Drawing.Color.White;
            this.MainWindowButton.Location = new System.Drawing.Point(12, 12);
            this.MainWindowButton.Name = "MainWindowButton";
            this.MainWindowButton.Size = new System.Drawing.Size(223, 65);
            this.MainWindowButton.TabIndex = 18;
            this.MainWindowButton.Text = "Main menu";
            this.MainWindowButton.UseVisualStyleBackColor = false;
            this.MainWindowButton.Click += new System.EventHandler(this.MainWindowButton_Click);
            // 
            // LabelFirstName
            // 
            this.LabelFirstName.AutoSize = true;
            this.LabelFirstName.Font = new System.Drawing.Font("Cascadia Code", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LabelFirstName.Location = new System.Drawing.Point(107, 162);
            this.LabelFirstName.Name = "LabelFirstName";
            this.LabelFirstName.Size = new System.Drawing.Size(193, 37);
            this.LabelFirstName.TabIndex = 19;
            this.LabelFirstName.Text = "First name:";
            // 
            // LabelSecondName
            // 
            this.LabelSecondName.AutoSize = true;
            this.LabelSecondName.Font = new System.Drawing.Font("Cascadia Code", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LabelSecondName.Location = new System.Drawing.Point(107, 273);
            this.LabelSecondName.Name = "LabelSecondName";
            this.LabelSecondName.Size = new System.Drawing.Size(209, 37);
            this.LabelSecondName.TabIndex = 20;
            this.LabelSecondName.Text = "Second name:";
            // 
            // LabelLogin
            // 
            this.LabelLogin.AutoSize = true;
            this.LabelLogin.Font = new System.Drawing.Font("Cascadia Code", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LabelLogin.Location = new System.Drawing.Point(107, 374);
            this.LabelLogin.Name = "LabelLogin";
            this.LabelLogin.Size = new System.Drawing.Size(113, 37);
            this.LabelLogin.TabIndex = 21;
            this.LabelLogin.Text = "Login:";
            // 
            // LabelDate
            // 
            this.LabelDate.AutoSize = true;
            this.LabelDate.Font = new System.Drawing.Font("Cascadia Code", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LabelDate.Location = new System.Drawing.Point(107, 478);
            this.LabelDate.Name = "LabelDate";
            this.LabelDate.Size = new System.Drawing.Size(465, 37);
            this.LabelDate.TabIndex = 22;
            this.LabelDate.Text = "Date of creating an account:";
            // 
            // DeleteUserButton
            // 
            this.DeleteUserButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(170)))), ((int)(((byte)(191)))));
            this.DeleteUserButton.FlatAppearance.BorderSize = 0;
            this.DeleteUserButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DeleteUserButton.Font = new System.Drawing.Font("Cascadia Code", 12.2F);
            this.DeleteUserButton.ForeColor = System.Drawing.Color.White;
            this.DeleteUserButton.Location = new System.Drawing.Point(771, 12);
            this.DeleteUserButton.Name = "DeleteUserButton";
            this.DeleteUserButton.Size = new System.Drawing.Size(223, 65);
            this.DeleteUserButton.TabIndex = 23;
            this.DeleteUserButton.Text = "Delete account";
            this.DeleteUserButton.UseVisualStyleBackColor = false;
            this.DeleteUserButton.Click += new System.EventHandler(this.DeleteUserButton_Click);
            // 
            // Profile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(134)))), ((int)(((byte)(240)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(1006, 721);
            this.Controls.Add(this.DeleteUserButton);
            this.Controls.Add(this.LabelDate);
            this.Controls.Add(this.LabelLogin);
            this.Controls.Add(this.LabelSecondName);
            this.Controls.Add(this.LabelFirstName);
            this.Controls.Add(this.MainWindowButton);
            this.Controls.Add(this.LogOutButton);
            this.MaximumSize = new System.Drawing.Size(1024, 768);
            this.MinimumSize = new System.Drawing.Size(1024, 768);
            this.Name = "Profile";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Profile";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button LogOutButton;
        private System.Windows.Forms.Button MainWindowButton;
        private System.Windows.Forms.Label LabelFirstName;
        private System.Windows.Forms.Label LabelSecondName;
        private System.Windows.Forms.Label LabelLogin;
        private System.Windows.Forms.Label LabelDate;
        private System.Windows.Forms.Button DeleteUserButton;
    }
}