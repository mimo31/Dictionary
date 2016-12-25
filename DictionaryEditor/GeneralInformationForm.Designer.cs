namespace DictionaryEditor
{
    partial class GeneralInformationForm
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
            this.nameTextbox = new System.Windows.Forms.TextBox();
            this.authorLabel = new System.Windows.Forms.Label();
            this.dateLabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.identifierTextbox = new System.Windows.Forms.TextBox();
            this.returnButton = new System.Windows.Forms.Button();
            this.questionCountLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name:";
            // 
            // nameTextbox
            // 
            this.nameTextbox.Location = new System.Drawing.Point(13, 30);
            this.nameTextbox.Name = "nameTextbox";
            this.nameTextbox.Size = new System.Drawing.Size(223, 20);
            this.nameTextbox.TabIndex = 1;
            this.nameTextbox.TextChanged += new System.EventHandler(this.nameTextbox_TextChanged);
            // 
            // authorLabel
            // 
            this.authorLabel.AutoSize = true;
            this.authorLabel.Location = new System.Drawing.Point(10, 114);
            this.authorLabel.Name = "authorLabel";
            this.authorLabel.Size = new System.Drawing.Size(44, 13);
            this.authorLabel.TabIndex = 2;
            this.authorLabel.Text = "Author: ";
            // 
            // dateLabel
            // 
            this.dateLabel.AutoSize = true;
            this.dateLabel.Location = new System.Drawing.Point(10, 147);
            this.dateLabel.Name = "dateLabel";
            this.dateLabel.Size = new System.Drawing.Size(62, 13);
            this.dateLabel.TabIndex = 3;
            this.dateLabel.Text = "Created on:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Identifier:";
            // 
            // identifierTextbox
            // 
            this.identifierTextbox.Location = new System.Drawing.Point(13, 74);
            this.identifierTextbox.Name = "identifierTextbox";
            this.identifierTextbox.Size = new System.Drawing.Size(223, 20);
            this.identifierTextbox.TabIndex = 5;
            this.identifierTextbox.TextChanged += new System.EventHandler(this.identifierTextbox_TextChanged);
            // 
            // returnButton
            // 
            this.returnButton.Location = new System.Drawing.Point(354, 170);
            this.returnButton.Name = "returnButton";
            this.returnButton.Size = new System.Drawing.Size(75, 23);
            this.returnButton.TabIndex = 6;
            this.returnButton.Text = "OK";
            this.returnButton.UseVisualStyleBackColor = true;
            this.returnButton.Click += new System.EventHandler(this.returnButton_Click);
            // 
            // questionCountLabel
            // 
            this.questionCountLabel.AutoSize = true;
            this.questionCountLabel.Location = new System.Drawing.Point(10, 175);
            this.questionCountLabel.Name = "questionCountLabel";
            this.questionCountLabel.Size = new System.Drawing.Size(61, 13);
            this.questionCountLabel.TabIndex = 7;
            this.questionCountLabel.Text = "0 questions";
            // 
            // GeneralInformationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(441, 214);
            this.Controls.Add(this.questionCountLabel);
            this.Controls.Add(this.returnButton);
            this.Controls.Add(this.identifierTextbox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dateLabel);
            this.Controls.Add(this.authorLabel);
            this.Controls.Add(this.nameTextbox);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "GeneralInformationForm";
            this.Text = "General Information";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox nameTextbox;
        private System.Windows.Forms.Label authorLabel;
        private System.Windows.Forms.Label dateLabel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox identifierTextbox;
        private System.Windows.Forms.Button returnButton;
        private System.Windows.Forms.Label questionCountLabel;
    }
}