namespace WebLibraryApp.PL.Views
{
    partial class MainWindow
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
            this.SearchField = new System.Windows.Forms.TextBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.S = new System.Windows.Forms.Button();
            this.ProfileButton = new System.Windows.Forms.Button();
            this.resultListBox = new System.Windows.Forms.ListBox();
            this.LabelBookName = new System.Windows.Forms.Label();
            this.LabelNumberOfAvailable = new System.Windows.Forms.Label();
            this.LabelBookAuthor = new System.Windows.Forms.Label();
            this.LabelBookTopics = new System.Windows.Forms.Label();
            this.ButtonTake = new System.Windows.Forms.Button();
            this.ButtonGive = new System.Windows.Forms.Button();
            this.LabelNumberOfTaken = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // SearchField
            // 
            this.SearchField.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SearchField.Location = new System.Drawing.Point(91, 154);
            this.SearchField.MaxLength = 20;
            this.SearchField.Name = "SearchField";
            this.SearchField.Size = new System.Drawing.Size(619, 61);
            this.SearchField.TabIndex = 18;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Items.AddRange(new object[] {
            "Name",
            "Author",
            "Book topic"});
            this.listBox1.Location = new System.Drawing.Point(874, 154);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(120, 52);
            this.listBox1.TabIndex = 19;
            // 
            // S
            // 
            this.S.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(170)))), ((int)(((byte)(191)))));
            this.S.FlatAppearance.BorderSize = 0;
            this.S.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.S.Font = new System.Drawing.Font("Cascadia Code", 14.2F);
            this.S.ForeColor = System.Drawing.Color.White;
            this.S.Location = new System.Drawing.Point(730, 154);
            this.S.Name = "S";
            this.S.Size = new System.Drawing.Size(123, 61);
            this.S.TabIndex = 21;
            this.S.Text = "Search";
            this.S.UseVisualStyleBackColor = false;
            this.S.Click += new System.EventHandler(this.S_Click);
            // 
            // ProfileButton
            // 
            this.ProfileButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(170)))), ((int)(((byte)(191)))));
            this.ProfileButton.FlatAppearance.BorderSize = 0;
            this.ProfileButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ProfileButton.Font = new System.Drawing.Font("Cascadia Code", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ProfileButton.ForeColor = System.Drawing.Color.White;
            this.ProfileButton.Location = new System.Drawing.Point(771, 12);
            this.ProfileButton.Name = "ProfileButton";
            this.ProfileButton.Size = new System.Drawing.Size(223, 65);
            this.ProfileButton.TabIndex = 22;
            this.ProfileButton.Text = "Profile";
            this.ProfileButton.UseVisualStyleBackColor = false;
            this.ProfileButton.Click += new System.EventHandler(this.ProfileButton_Click);
            // 
            // resultListBox
            // 
            this.resultListBox.FormattingEnabled = true;
            this.resultListBox.ItemHeight = 16;
            this.resultListBox.Location = new System.Drawing.Point(91, 262);
            this.resultListBox.Name = "resultListBox";
            this.resultListBox.Size = new System.Drawing.Size(272, 340);
            this.resultListBox.TabIndex = 23;
            this.resultListBox.SelectedIndexChanged += new System.EventHandler(this.resultListBox_SelectedIndexChanged);
            // 
            // LabelBookName
            // 
            this.LabelBookName.AutoSize = true;
            this.LabelBookName.Font = new System.Drawing.Font("Cascadia Code", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LabelBookName.Location = new System.Drawing.Point(414, 262);
            this.LabelBookName.Name = "LabelBookName";
            this.LabelBookName.Size = new System.Drawing.Size(177, 37);
            this.LabelBookName.TabIndex = 24;
            this.LabelBookName.Text = "Book name:";
            // 
            // LabelNumberOfAvailable
            // 
            this.LabelNumberOfAvailable.AutoSize = true;
            this.LabelNumberOfAvailable.Font = new System.Drawing.Font("Cascadia Code", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LabelNumberOfAvailable.Location = new System.Drawing.Point(414, 334);
            this.LabelNumberOfAvailable.Name = "LabelNumberOfAvailable";
            this.LabelNumberOfAvailable.Size = new System.Drawing.Size(337, 37);
            this.LabelNumberOfAvailable.TabIndex = 25;
            this.LabelNumberOfAvailable.Text = "Number of available:";
            // 
            // LabelBookAuthor
            // 
            this.LabelBookAuthor.AutoSize = true;
            this.LabelBookAuthor.Font = new System.Drawing.Font("Cascadia Code", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LabelBookAuthor.Location = new System.Drawing.Point(414, 405);
            this.LabelBookAuthor.Name = "LabelBookAuthor";
            this.LabelBookAuthor.Size = new System.Drawing.Size(145, 37);
            this.LabelBookAuthor.TabIndex = 26;
            this.LabelBookAuthor.Text = "Authors:";
            // 
            // LabelBookTopics
            // 
            this.LabelBookTopics.AutoSize = true;
            this.LabelBookTopics.Font = new System.Drawing.Font("Cascadia Code", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LabelBookTopics.Location = new System.Drawing.Point(414, 483);
            this.LabelBookTopics.Name = "LabelBookTopics";
            this.LabelBookTopics.Size = new System.Drawing.Size(209, 37);
            this.LabelBookTopics.TabIndex = 27;
            this.LabelBookTopics.Text = "Book topics:";
            // 
            // ButtonTake
            // 
            this.ButtonTake.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(170)))), ((int)(((byte)(191)))));
            this.ButtonTake.FlatAppearance.BorderSize = 0;
            this.ButtonTake.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonTake.Font = new System.Drawing.Font("Cascadia Code", 14.2F);
            this.ButtonTake.ForeColor = System.Drawing.Color.White;
            this.ButtonTake.Location = new System.Drawing.Point(436, 624);
            this.ButtonTake.Name = "ButtonTake";
            this.ButtonTake.Size = new System.Drawing.Size(123, 61);
            this.ButtonTake.TabIndex = 28;
            this.ButtonTake.Text = "Take";
            this.ButtonTake.UseVisualStyleBackColor = false;
            // 
            // ButtonGive
            // 
            this.ButtonGive.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(170)))), ((int)(((byte)(191)))));
            this.ButtonGive.FlatAppearance.BorderSize = 0;
            this.ButtonGive.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonGive.Font = new System.Drawing.Font("Cascadia Code", 14.2F);
            this.ButtonGive.ForeColor = System.Drawing.Color.White;
            this.ButtonGive.Location = new System.Drawing.Point(730, 624);
            this.ButtonGive.Name = "ButtonGive";
            this.ButtonGive.Size = new System.Drawing.Size(123, 61);
            this.ButtonGive.TabIndex = 29;
            this.ButtonGive.Text = "Give";
            this.ButtonGive.UseVisualStyleBackColor = false;
            // 
            // LabelNumberOfTaken
            // 
            this.LabelNumberOfTaken.AutoSize = true;
            this.LabelNumberOfTaken.Font = new System.Drawing.Font("Cascadia Code", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LabelNumberOfTaken.Location = new System.Drawing.Point(414, 555);
            this.LabelNumberOfTaken.Name = "LabelNumberOfTaken";
            this.LabelNumberOfTaken.Size = new System.Drawing.Size(273, 37);
            this.LabelNumberOfTaken.TabIndex = 30;
            this.LabelNumberOfTaken.Text = "Number of taken:";
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(134)))), ((int)(((byte)(240)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(1006, 721);
            this.Controls.Add(this.LabelNumberOfTaken);
            this.Controls.Add(this.ButtonGive);
            this.Controls.Add(this.ButtonTake);
            this.Controls.Add(this.LabelBookTopics);
            this.Controls.Add(this.LabelBookAuthor);
            this.Controls.Add(this.LabelNumberOfAvailable);
            this.Controls.Add(this.LabelBookName);
            this.Controls.Add(this.resultListBox);
            this.Controls.Add(this.ProfileButton);
            this.Controls.Add(this.S);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.SearchField);
            this.MaximumSize = new System.Drawing.Size(1024, 768);
            this.MinimumSize = new System.Drawing.Size(1024, 768);
            this.Name = "MainWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainWindow";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox SearchField;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button S;
        private System.Windows.Forms.Button ProfileButton;
        private System.Windows.Forms.ListBox resultListBox;
        private System.Windows.Forms.Label LabelBookName;
        private System.Windows.Forms.Label LabelNumberOfAvailable;
        private System.Windows.Forms.Label LabelBookAuthor;
        private System.Windows.Forms.Label LabelBookTopics;
        private System.Windows.Forms.Button ButtonTake;
        private System.Windows.Forms.Button ButtonGive;
        private System.Windows.Forms.Label LabelNumberOfTaken;
    }
}