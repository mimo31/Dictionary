namespace DictionaryEditor
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
            this.wordListBox = new System.Windows.Forms.ListBox();
            this.loadButton = new System.Windows.Forms.Button();
            this.questionEditTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.answerEditTextBox = new System.Windows.Forms.TextBox();
            this.editButton = new System.Windows.Forms.Button();
            this.deleteButton = new System.Windows.Forms.Button();
            this.informationButton = new System.Windows.Forms.Button();
            this.saveButton = new System.Windows.Forms.Button();
            this.saveAsButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.categoriesEditTextbox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.noteEditTextbox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // wordListBox
            // 
            this.wordListBox.FormattingEnabled = true;
            this.wordListBox.Location = new System.Drawing.Point(12, 41);
            this.wordListBox.Name = "wordListBox";
            this.wordListBox.Size = new System.Drawing.Size(476, 394);
            this.wordListBox.TabIndex = 0;
            this.wordListBox.SelectedIndexChanged += new System.EventHandler(this.wordListBox_SelectedIndexChanged);
            // 
            // loadButton
            // 
            this.loadButton.Location = new System.Drawing.Point(12, 12);
            this.loadButton.Name = "loadButton";
            this.loadButton.Size = new System.Drawing.Size(75, 23);
            this.loadButton.TabIndex = 3;
            this.loadButton.Text = "Load dictionary";
            this.loadButton.UseVisualStyleBackColor = true;
            this.loadButton.Click += new System.EventHandler(this.loadButton_Click);
            // 
            // questionEditTextBox
            // 
            this.questionEditTextBox.Location = new System.Drawing.Point(12, 454);
            this.questionEditTextBox.Name = "questionEditTextBox";
            this.questionEditTextBox.Size = new System.Drawing.Size(476, 20);
            this.questionEditTextBox.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 438);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Question:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 477);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Answer:";
            // 
            // answerEditTextBox
            // 
            this.answerEditTextBox.Location = new System.Drawing.Point(12, 493);
            this.answerEditTextBox.Name = "answerEditTextBox";
            this.answerEditTextBox.Size = new System.Drawing.Size(476, 20);
            this.answerEditTextBox.TabIndex = 7;
            // 
            // editButton
            // 
            this.editButton.Enabled = false;
            this.editButton.Location = new System.Drawing.Point(413, 598);
            this.editButton.Name = "editButton";
            this.editButton.Size = new System.Drawing.Size(75, 23);
            this.editButton.TabIndex = 8;
            this.editButton.Text = "Edit";
            this.editButton.UseVisualStyleBackColor = true;
            this.editButton.Click += new System.EventHandler(this.editButton_Click);
            // 
            // deleteButton
            // 
            this.deleteButton.Enabled = false;
            this.deleteButton.Location = new System.Drawing.Point(12, 598);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(75, 23);
            this.deleteButton.TabIndex = 10;
            this.deleteButton.Text = "Delete";
            this.deleteButton.UseVisualStyleBackColor = true;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // informationButton
            // 
            this.informationButton.Enabled = false;
            this.informationButton.Location = new System.Drawing.Point(93, 12);
            this.informationButton.Name = "informationButton";
            this.informationButton.Size = new System.Drawing.Size(233, 23);
            this.informationButton.TabIndex = 11;
            this.informationButton.Text = "General Information";
            this.informationButton.UseVisualStyleBackColor = true;
            this.informationButton.Click += new System.EventHandler(this.informationButton_Click);
            // 
            // saveButton
            // 
            this.saveButton.Enabled = false;
            this.saveButton.Location = new System.Drawing.Point(413, 12);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(75, 23);
            this.saveButton.TabIndex = 12;
            this.saveButton.Text = "Save";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // saveAsButton
            // 
            this.saveAsButton.Enabled = false;
            this.saveAsButton.Location = new System.Drawing.Point(332, 12);
            this.saveAsButton.Name = "saveAsButton";
            this.saveAsButton.Size = new System.Drawing.Size(75, 23);
            this.saveAsButton.TabIndex = 13;
            this.saveAsButton.Text = "Save As...";
            this.saveAsButton.UseVisualStyleBackColor = true;
            this.saveAsButton.Click += new System.EventHandler(this.saveAsButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 516);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 13);
            this.label1.TabIndex = 14;
            this.label1.Text = "Categories:";
            // 
            // categoriesEditTextbox
            // 
            this.categoriesEditTextbox.Location = new System.Drawing.Point(12, 533);
            this.categoriesEditTextbox.Name = "categoriesEditTextbox";
            this.categoriesEditTextbox.Size = new System.Drawing.Size(476, 20);
            this.categoriesEditTextbox.TabIndex = 15;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 556);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(33, 13);
            this.label4.TabIndex = 16;
            this.label4.Text = "Note:";
            // 
            // noteEditTextbox
            // 
            this.noteEditTextbox.Location = new System.Drawing.Point(12, 572);
            this.noteEditTextbox.Name = "noteEditTextbox";
            this.noteEditTextbox.Size = new System.Drawing.Size(476, 20);
            this.noteEditTextbox.TabIndex = 17;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(500, 630);
            this.Controls.Add(this.noteEditTextbox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.categoriesEditTextbox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.saveAsButton);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.informationButton);
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.editButton);
            this.Controls.Add(this.answerEditTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.questionEditTextBox);
            this.Controls.Add(this.loadButton);
            this.Controls.Add(this.wordListBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "Dictionary Editor";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox wordListBox;
        private System.Windows.Forms.Button loadButton;
        private System.Windows.Forms.TextBox questionEditTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox answerEditTextBox;
        private System.Windows.Forms.Button editButton;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.Button informationButton;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Button saveAsButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox categoriesEditTextbox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox noteEditTextbox;
    }
}

