namespace DictionaryCreator
{
    partial class AddEntryForm
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
            this.questionTextbox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.answerTextbox = new System.Windows.Forms.TextBox();
            this.addButton = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.categoriesTextbox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.noteTextbox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Question:";
            // 
            // questionTextbox
            // 
            this.questionTextbox.Location = new System.Drawing.Point(13, 30);
            this.questionTextbox.Name = "questionTextbox";
            this.questionTextbox.Size = new System.Drawing.Size(293, 20);
            this.questionTextbox.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Answer:";
            // 
            // answerTextbox
            // 
            this.answerTextbox.Location = new System.Drawing.Point(13, 73);
            this.answerTextbox.Multiline = true;
            this.answerTextbox.Name = "answerTextbox";
            this.answerTextbox.Size = new System.Drawing.Size(293, 20);
            this.answerTextbox.TabIndex = 3;
            this.answerTextbox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.submittableKeyDown);
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(206, 199);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(100, 23);
            this.addButton.TabIndex = 8;
            this.addButton.Text = "Add";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 105);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Categories:";
            // 
            // categoriesTextbox
            // 
            this.categoriesTextbox.Location = new System.Drawing.Point(13, 122);
            this.categoriesTextbox.Name = "categoriesTextbox";
            this.categoriesTextbox.Size = new System.Drawing.Size(293, 20);
            this.categoriesTextbox.TabIndex = 5;
            this.categoriesTextbox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.submittableKeyDown);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 157);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(33, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Note:";
            // 
            // noteTextbox
            // 
            this.noteTextbox.Location = new System.Drawing.Point(13, 173);
            this.noteTextbox.Name = "noteTextbox";
            this.noteTextbox.Size = new System.Drawing.Size(293, 20);
            this.noteTextbox.TabIndex = 7;
            this.noteTextbox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.submittableKeyDown);
            // 
            // AddEntryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(318, 234);
            this.Controls.Add(this.noteTextbox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.categoriesTextbox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.answerTextbox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.questionTextbox);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AddEntryForm";
            this.Text = "8";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox questionTextbox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox answerTextbox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox categoriesTextbox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox noteTextbox;
        private System.Windows.Forms.Button addButton;
    }
}