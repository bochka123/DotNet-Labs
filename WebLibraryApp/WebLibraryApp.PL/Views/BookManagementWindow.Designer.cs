namespace WebLibraryApp.PL.Views
{
    partial class BookManagementWindow
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
            this.MainMenu = new System.Windows.Forms.Button();
            this.LabelBookAuthor = new System.Windows.Forms.Label();
            this.LabelBookName = new System.Windows.Forms.Label();
            this.LabelBookTopics = new System.Windows.Forms.Label();
            this.AuthorsField = new System.Windows.Forms.TextBox();
            this.BookNameField = new System.Windows.Forms.TextBox();
            this.BookTopicsField = new System.Windows.Forms.TextBox();
            this.AddBook = new System.Windows.Forms.Button();
            this.LabelNumberOfExampples = new System.Windows.Forms.Label();
            this.NumberOfExamplesField = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // MainMenu
            // 
            this.MainMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(170)))), ((int)(((byte)(191)))));
            this.MainMenu.FlatAppearance.BorderSize = 0;
            this.MainMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MainMenu.Font = new System.Drawing.Font("Cascadia Code", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.MainMenu.ForeColor = System.Drawing.Color.White;
            this.MainMenu.Location = new System.Drawing.Point(12, 12);
            this.MainMenu.Name = "MainMenu";
            this.MainMenu.Size = new System.Drawing.Size(223, 65);
            this.MainMenu.TabIndex = 31;
            this.MainMenu.Text = "Main menu";
            this.MainMenu.UseVisualStyleBackColor = false;
            this.MainMenu.Click += new System.EventHandler(this.MainMenu_Click);
            // 
            // LabelBookAuthor
            // 
            this.LabelBookAuthor.AutoSize = true;
            this.LabelBookAuthor.Font = new System.Drawing.Font("Cascadia Code", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LabelBookAuthor.Location = new System.Drawing.Point(181, 108);
            this.LabelBookAuthor.Name = "LabelBookAuthor";
            this.LabelBookAuthor.Size = new System.Drawing.Size(129, 37);
            this.LabelBookAuthor.TabIndex = 32;
            this.LabelBookAuthor.Text = "Authors";
            // 
            // LabelBookName
            // 
            this.LabelBookName.AutoSize = true;
            this.LabelBookName.Font = new System.Drawing.Font("Cascadia Code", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LabelBookName.Location = new System.Drawing.Point(181, 226);
            this.LabelBookName.Name = "LabelBookName";
            this.LabelBookName.Size = new System.Drawing.Size(161, 37);
            this.LabelBookName.TabIndex = 33;
            this.LabelBookName.Text = "Book name";
            // 
            // LabelBookTopics
            // 
            this.LabelBookTopics.AutoSize = true;
            this.LabelBookTopics.Font = new System.Drawing.Font("Cascadia Code", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LabelBookTopics.Location = new System.Drawing.Point(181, 355);
            this.LabelBookTopics.Name = "LabelBookTopics";
            this.LabelBookTopics.Size = new System.Drawing.Size(193, 37);
            this.LabelBookTopics.TabIndex = 34;
            this.LabelBookTopics.Text = "Book topics";
            // 
            // AuthorsField
            // 
            this.AuthorsField.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AuthorsField.Location = new System.Drawing.Point(181, 148);
            this.AuthorsField.MaxLength = 20;
            this.AuthorsField.Name = "AuthorsField";
            this.AuthorsField.Size = new System.Drawing.Size(619, 61);
            this.AuthorsField.TabIndex = 35;
            // 
            // BookNameField
            // 
            this.BookNameField.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BookNameField.Location = new System.Drawing.Point(181, 266);
            this.BookNameField.MaxLength = 20;
            this.BookNameField.Name = "BookNameField";
            this.BookNameField.Size = new System.Drawing.Size(619, 61);
            this.BookNameField.TabIndex = 36;
            // 
            // BookTopicsField
            // 
            this.BookTopicsField.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BookTopicsField.Location = new System.Drawing.Point(181, 395);
            this.BookTopicsField.MaxLength = 20;
            this.BookTopicsField.Name = "BookTopicsField";
            this.BookTopicsField.Size = new System.Drawing.Size(619, 61);
            this.BookTopicsField.TabIndex = 37;
            // 
            // AddBook
            // 
            this.AddBook.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(170)))), ((int)(((byte)(191)))));
            this.AddBook.FlatAppearance.BorderSize = 0;
            this.AddBook.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddBook.Font = new System.Drawing.Font("Cascadia Code", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AddBook.ForeColor = System.Drawing.Color.White;
            this.AddBook.Location = new System.Drawing.Point(375, 624);
            this.AddBook.Name = "AddBook";
            this.AddBook.Size = new System.Drawing.Size(223, 85);
            this.AddBook.TabIndex = 38;
            this.AddBook.Text = "Add book to library";
            this.AddBook.UseVisualStyleBackColor = false;
            this.AddBook.Click += new System.EventHandler(this.AddBook_Click);
            // 
            // LabelNumberOfExampples
            // 
            this.LabelNumberOfExampples.AutoSize = true;
            this.LabelNumberOfExampples.Font = new System.Drawing.Font("Cascadia Code", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LabelNumberOfExampples.Location = new System.Drawing.Point(181, 482);
            this.LabelNumberOfExampples.Name = "LabelNumberOfExampples";
            this.LabelNumberOfExampples.Size = new System.Drawing.Size(305, 37);
            this.LabelNumberOfExampples.TabIndex = 39;
            this.LabelNumberOfExampples.Text = "Number of examples";
            // 
            // NumberOfExamplesField
            // 
            this.NumberOfExamplesField.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.NumberOfExamplesField.Location = new System.Drawing.Point(181, 522);
            this.NumberOfExamplesField.MaxLength = 20;
            this.NumberOfExamplesField.Name = "NumberOfExamplesField";
            this.NumberOfExamplesField.Size = new System.Drawing.Size(619, 61);
            this.NumberOfExamplesField.TabIndex = 40;
            // 
            // BookManagementWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(134)))), ((int)(((byte)(240)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(1006, 721);
            this.Controls.Add(this.NumberOfExamplesField);
            this.Controls.Add(this.LabelNumberOfExampples);
            this.Controls.Add(this.AddBook);
            this.Controls.Add(this.BookTopicsField);
            this.Controls.Add(this.BookNameField);
            this.Controls.Add(this.AuthorsField);
            this.Controls.Add(this.LabelBookTopics);
            this.Controls.Add(this.LabelBookName);
            this.Controls.Add(this.LabelBookAuthor);
            this.Controls.Add(this.MainMenu);
            this.MaximumSize = new System.Drawing.Size(1024, 768);
            this.MinimumSize = new System.Drawing.Size(1024, 768);
            this.Name = "BookManagementWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BookManagementWindow";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button MainMenu;
        private System.Windows.Forms.Label LabelBookAuthor;
        private System.Windows.Forms.Label LabelBookName;
        private System.Windows.Forms.Label LabelBookTopics;
        private System.Windows.Forms.TextBox AuthorsField;
        private System.Windows.Forms.TextBox BookNameField;
        private System.Windows.Forms.TextBox BookTopicsField;
        private System.Windows.Forms.Button AddBook;
        private System.Windows.Forms.Label LabelNumberOfExampples;
        private System.Windows.Forms.TextBox NumberOfExamplesField;
    }
}