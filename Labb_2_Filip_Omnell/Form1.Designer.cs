namespace Labb_2_OOP
{
    partial class Form1
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
            this.NewPersonsGroupBox = new System.Windows.Forms.GroupBox();
            this.ExceptionLabel = new System.Windows.Forms.Label();
            this.AddButton = new System.Windows.Forms.Button();
            this.FemaleRadioButton = new System.Windows.Forms.RadioButton();
            this.MaleRadioButton = new System.Windows.Forms.RadioButton();
            this.LastNameLabel = new System.Windows.Forms.Label();
            this.FirstNameLabel = new System.Windows.Forms.Label();
            this.LastNameTextBox = new System.Windows.Forms.TextBox();
            this.FirstNameTextBox = new System.Windows.Forms.TextBox();
            this.PersonsGroupBox = new System.Windows.Forms.GroupBox();
            this.SortingByLabel = new System.Windows.Forms.Label();
            this.SortButton_2 = new System.Windows.Forms.Button();
            this.RemoveButton = new System.Windows.Forms.Button();
            this.MergeButton = new System.Windows.Forms.Button();
            this.SortButton = new System.Windows.Forms.Button();
            this.PersonsListBox = new System.Windows.Forms.ListBox();
            this.SearchGroupBox = new System.Windows.Forms.GroupBox();
            this.SearchTextBox = new System.Windows.Forms.TextBox();
            this.SearchLabel = new System.Windows.Forms.Label();
            this.NewPersonsGroupBox.SuspendLayout();
            this.PersonsGroupBox.SuspendLayout();
            this.SearchGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // NewPersonsGroupBox
            // 
            this.NewPersonsGroupBox.Controls.Add(this.ExceptionLabel);
            this.NewPersonsGroupBox.Controls.Add(this.AddButton);
            this.NewPersonsGroupBox.Controls.Add(this.FemaleRadioButton);
            this.NewPersonsGroupBox.Controls.Add(this.MaleRadioButton);
            this.NewPersonsGroupBox.Controls.Add(this.LastNameLabel);
            this.NewPersonsGroupBox.Controls.Add(this.FirstNameLabel);
            this.NewPersonsGroupBox.Controls.Add(this.LastNameTextBox);
            this.NewPersonsGroupBox.Controls.Add(this.FirstNameTextBox);
            this.NewPersonsGroupBox.Location = new System.Drawing.Point(12, 12);
            this.NewPersonsGroupBox.Name = "NewPersonsGroupBox";
            this.NewPersonsGroupBox.Size = new System.Drawing.Size(212, 139);
            this.NewPersonsGroupBox.TabIndex = 0;
            this.NewPersonsGroupBox.TabStop = false;
            this.NewPersonsGroupBox.Text = "New person";
            // 
            // ExceptionLabel
            // 
            this.ExceptionLabel.Cursor = System.Windows.Forms.Cursors.Default;
            this.ExceptionLabel.Location = new System.Drawing.Point(64, 102);
            this.ExceptionLabel.Name = "ExceptionLabel";
            this.ExceptionLabel.Size = new System.Drawing.Size(134, 31);
            this.ExceptionLabel.TabIndex = 7;
            this.ExceptionLabel.Text = "TextBoxes cannot be empty!";
            // 
            // AddButton
            // 
            this.AddButton.Location = new System.Drawing.Point(125, 76);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(75, 23);
            this.AddButton.TabIndex = 6;
            this.AddButton.Text = "Add";
            this.AddButton.UseVisualStyleBackColor = true;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // FemaleRadioButton
            // 
            this.FemaleRadioButton.AutoSize = true;
            this.FemaleRadioButton.Location = new System.Drawing.Point(7, 105);
            this.FemaleRadioButton.Name = "FemaleRadioButton";
            this.FemaleRadioButton.Size = new System.Drawing.Size(59, 17);
            this.FemaleRadioButton.TabIndex = 5;
            this.FemaleRadioButton.TabStop = true;
            this.FemaleRadioButton.Text = "Female";
            this.FemaleRadioButton.UseVisualStyleBackColor = true;
            // 
            // MaleRadioButton
            // 
            this.MaleRadioButton.AutoSize = true;
            this.MaleRadioButton.Location = new System.Drawing.Point(7, 82);
            this.MaleRadioButton.Name = "MaleRadioButton";
            this.MaleRadioButton.Size = new System.Drawing.Size(48, 17);
            this.MaleRadioButton.TabIndex = 4;
            this.MaleRadioButton.TabStop = true;
            this.MaleRadioButton.Text = "Male";
            this.MaleRadioButton.UseVisualStyleBackColor = true;
            // 
            // LastNameLabel
            // 
            this.LastNameLabel.AutoSize = true;
            this.LastNameLabel.Location = new System.Drawing.Point(129, 28);
            this.LastNameLabel.Name = "LastNameLabel";
            this.LastNameLabel.Size = new System.Drawing.Size(56, 13);
            this.LastNameLabel.TabIndex = 3;
            this.LastNameLabel.Text = "Last name";
            // 
            // FirstNameLabel
            // 
            this.FirstNameLabel.AutoSize = true;
            this.FirstNameLabel.Location = new System.Drawing.Point(23, 28);
            this.FirstNameLabel.Name = "FirstNameLabel";
            this.FirstNameLabel.Size = new System.Drawing.Size(55, 13);
            this.FirstNameLabel.TabIndex = 2;
            this.FirstNameLabel.Text = "First name";
            // 
            // LastNameTextBox
            // 
            this.LastNameTextBox.Location = new System.Drawing.Point(114, 45);
            this.LastNameTextBox.Name = "LastNameTextBox";
            this.LastNameTextBox.Size = new System.Drawing.Size(86, 20);
            this.LastNameTextBox.TabIndex = 1;
            // 
            // FirstNameTextBox
            // 
            this.FirstNameTextBox.Location = new System.Drawing.Point(6, 45);
            this.FirstNameTextBox.Name = "FirstNameTextBox";
            this.FirstNameTextBox.Size = new System.Drawing.Size(86, 20);
            this.FirstNameTextBox.TabIndex = 0;
            // 
            // PersonsGroupBox
            // 
            this.PersonsGroupBox.Controls.Add(this.SortingByLabel);
            this.PersonsGroupBox.Controls.Add(this.SortButton_2);
            this.PersonsGroupBox.Controls.Add(this.RemoveButton);
            this.PersonsGroupBox.Controls.Add(this.MergeButton);
            this.PersonsGroupBox.Controls.Add(this.SortButton);
            this.PersonsGroupBox.Controls.Add(this.PersonsListBox);
            this.PersonsGroupBox.Location = new System.Drawing.Point(12, 166);
            this.PersonsGroupBox.Name = "PersonsGroupBox";
            this.PersonsGroupBox.Size = new System.Drawing.Size(212, 239);
            this.PersonsGroupBox.TabIndex = 1;
            this.PersonsGroupBox.TabStop = false;
            this.PersonsGroupBox.Text = "Persons";
            // 
            // SortingByLabel
            // 
            this.SortingByLabel.AutoSize = true;
            this.SortingByLabel.Location = new System.Drawing.Point(101, 7);
            this.SortingByLabel.Name = "SortingByLabel";
            this.SortingByLabel.Size = new System.Drawing.Size(105, 13);
            this.SortingByLabel.TabIndex = 5;
            this.SortingByLabel.Text = "Sorting by: Firstname";
            // 
            // SortButton_2
            // 
            this.SortButton_2.Location = new System.Drawing.Point(7, 189);
            this.SortButton_2.Name = "SortButton_2";
            this.SortButton_2.Size = new System.Drawing.Size(60, 23);
            this.SortButton_2.TabIndex = 4;
            this.SortButton_2.Text = "Sort";
            this.SortButton_2.UseVisualStyleBackColor = true;
            this.SortButton_2.Click += new System.EventHandler(this.SortButton_2_Click);
            // 
            // RemoveButton
            // 
            this.RemoveButton.Location = new System.Drawing.Point(146, 189);
            this.RemoveButton.Name = "RemoveButton";
            this.RemoveButton.Size = new System.Drawing.Size(60, 23);
            this.RemoveButton.TabIndex = 3;
            this.RemoveButton.Text = "Remove";
            this.RemoveButton.UseVisualStyleBackColor = true;
            this.RemoveButton.Click += new System.EventHandler(this.RemoveButton_Click);
            // 
            // MergeButton
            // 
            this.MergeButton.Location = new System.Drawing.Point(72, 189);
            this.MergeButton.Name = "MergeButton";
            this.MergeButton.Size = new System.Drawing.Size(68, 23);
            this.MergeButton.TabIndex = 2;
            this.MergeButton.Text = "Merge";
            this.MergeButton.UseVisualStyleBackColor = true;
            this.MergeButton.Click += new System.EventHandler(this.MergeButton_Click);
            // 
            // SortButton
            // 
            this.SortButton.Location = new System.Drawing.Point(7, 189);
            this.SortButton.Name = "SortButton";
            this.SortButton.Size = new System.Drawing.Size(60, 23);
            this.SortButton.TabIndex = 1;
            this.SortButton.Text = "Sort";
            this.SortButton.UseVisualStyleBackColor = true;
            this.SortButton.Click += new System.EventHandler(this.SortButton_Click);
            // 
            // PersonsListBox
            // 
            this.PersonsListBox.FormattingEnabled = true;
            this.PersonsListBox.Location = new System.Drawing.Point(7, 23);
            this.PersonsListBox.Name = "PersonsListBox";
            this.PersonsListBox.Size = new System.Drawing.Size(199, 160);
            this.PersonsListBox.TabIndex = 0;
            // 
            // SearchGroupBox
            // 
            this.SearchGroupBox.Controls.Add(this.SearchTextBox);
            this.SearchGroupBox.Controls.Add(this.SearchLabel);
            this.SearchGroupBox.Location = new System.Drawing.Point(230, 12);
            this.SearchGroupBox.Name = "SearchGroupBox";
            this.SearchGroupBox.Size = new System.Drawing.Size(200, 100);
            this.SearchGroupBox.TabIndex = 2;
            this.SearchGroupBox.TabStop = false;
            this.SearchGroupBox.Text = "Search";
            // 
            // SearchTextBox
            // 
            this.SearchTextBox.Location = new System.Drawing.Point(9, 45);
            this.SearchTextBox.Name = "SearchTextBox";
            this.SearchTextBox.Size = new System.Drawing.Size(100, 20);
            this.SearchTextBox.TabIndex = 1;
            this.SearchTextBox.TextChanged += new System.EventHandler(this.SearchTextBox_TextChanged);
            // 
            // SearchLabel
            // 
            this.SearchLabel.AutoSize = true;
            this.SearchLabel.Location = new System.Drawing.Point(6, 28);
            this.SearchLabel.Name = "SearchLabel";
            this.SearchLabel.Size = new System.Drawing.Size(83, 13);
            this.SearchLabel.TabIndex = 0;
            this.SearchLabel.Text = "First or lastname";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(444, 450);
            this.Controls.Add(this.SearchGroupBox);
            this.Controls.Add(this.PersonsGroupBox);
            this.Controls.Add(this.NewPersonsGroupBox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.NewPersonsGroupBox.ResumeLayout(false);
            this.NewPersonsGroupBox.PerformLayout();
            this.PersonsGroupBox.ResumeLayout(false);
            this.PersonsGroupBox.PerformLayout();
            this.SearchGroupBox.ResumeLayout(false);
            this.SearchGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox NewPersonsGroupBox;
        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.RadioButton FemaleRadioButton;
        private System.Windows.Forms.RadioButton MaleRadioButton;
        private System.Windows.Forms.Label LastNameLabel;
        private System.Windows.Forms.Label FirstNameLabel;
        private System.Windows.Forms.TextBox LastNameTextBox;
        private System.Windows.Forms.TextBox FirstNameTextBox;
        private System.Windows.Forms.GroupBox PersonsGroupBox;
        private System.Windows.Forms.Button RemoveButton;
        private System.Windows.Forms.Button MergeButton;
        private System.Windows.Forms.Button SortButton;
        private System.Windows.Forms.ListBox PersonsListBox;
        private System.Windows.Forms.Button SortButton_2;
        private System.Windows.Forms.Label SortingByLabel;
        private System.Windows.Forms.Label ExceptionLabel;
        private System.Windows.Forms.GroupBox SearchGroupBox;
        private System.Windows.Forms.TextBox SearchTextBox;
        private System.Windows.Forms.Label SearchLabel;
    }
}

