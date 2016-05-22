namespace DictionaryCreator
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
            this.addEntryButton = new System.Windows.Forms.Button();
            this.saveButton = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.nameTextbox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.authorTextbox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.identifierTextbox = new System.Windows.Forms.TextBox();
            this.checkCheckbox = new System.Windows.Forms.CheckBox();
            this.loadButton = new System.Windows.Forms.Button();
            this.currentDictionaryLabel = new System.Windows.Forms.Label();
            this.saveAsButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // addEntryButton
            // 
            this.addEntryButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addEntryButton.Location = new System.Drawing.Point(12, 12);
            this.addEntryButton.Name = "addEntryButton";
            this.addEntryButton.Size = new System.Drawing.Size(694, 39);
            this.addEntryButton.TabIndex = 0;
            this.addEntryButton.Text = "Add Entries";
            this.addEntryButton.UseVisualStyleBackColor = true;
            this.addEntryButton.Click += new System.EventHandler(this.addEntryButton_Click);
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(631, 353);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(75, 23);
            this.saveButton.TabIndex = 7;
            this.saveButton.Text = "Save";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 54);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Name:";
            // 
            // nameTextbox
            // 
            this.nameTextbox.Location = new System.Drawing.Point(12, 70);
            this.nameTextbox.Name = "nameTextbox";
            this.nameTextbox.Size = new System.Drawing.Size(161, 20);
            this.nameTextbox.TabIndex = 9;
            this.nameTextbox.TextChanged += new System.EventHandler(this.nameTextbox_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(9, 98);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Author:";
            // 
            // authorTextbox
            // 
            this.authorTextbox.Location = new System.Drawing.Point(12, 114);
            this.authorTextbox.Name = "authorTextbox";
            this.authorTextbox.Size = new System.Drawing.Size(161, 20);
            this.authorTextbox.TabIndex = 11;
            this.authorTextbox.TextChanged += new System.EventHandler(this.authorTextbox_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 141);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "Identifier:";
            // 
            // identifierTextbox
            // 
            this.identifierTextbox.Location = new System.Drawing.Point(12, 158);
            this.identifierTextbox.Name = "identifierTextbox";
            this.identifierTextbox.Size = new System.Drawing.Size(100, 20);
            this.identifierTextbox.TabIndex = 13;
            this.identifierTextbox.TextChanged += new System.EventHandler(this.identifierTextbox_TextChanged);
            // 
            // checkCheckbox
            // 
            this.checkCheckbox.AutoSize = true;
            this.checkCheckbox.Checked = true;
            this.checkCheckbox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkCheckbox.Location = new System.Drawing.Point(12, 185);
            this.checkCheckbox.Name = "checkCheckbox";
            this.checkCheckbox.Size = new System.Drawing.Size(99, 17);
            this.checkCheckbox.TabIndex = 14;
            this.checkCheckbox.Text = "Check answers";
            this.checkCheckbox.UseVisualStyleBackColor = true;
            this.checkCheckbox.CheckedChanged += new System.EventHandler(this.checkCheckbox_CheckedChanged);
            // 
            // loadButton
            // 
            this.loadButton.Location = new System.Drawing.Point(12, 352);
            this.loadButton.Name = "loadButton";
            this.loadButton.Size = new System.Drawing.Size(75, 23);
            this.loadButton.TabIndex = 15;
            this.loadButton.Text = "Load";
            this.loadButton.UseVisualStyleBackColor = true;
            this.loadButton.Click += new System.EventHandler(this.loadButton_Click);
            // 
            // currentDictionaryLabel
            // 
            this.currentDictionaryLabel.AutoSize = true;
            this.currentDictionaryLabel.Location = new System.Drawing.Point(381, 58);
            this.currentDictionaryLabel.Name = "currentDictionaryLabel";
            this.currentDictionaryLabel.Size = new System.Drawing.Size(0, 13);
            this.currentDictionaryLabel.TabIndex = 16;
            // 
            // saveAsButton
            // 
            this.saveAsButton.Location = new System.Drawing.Point(631, 324);
            this.saveAsButton.Name = "saveAsButton";
            this.saveAsButton.Size = new System.Drawing.Size(75, 23);
            this.saveAsButton.TabIndex = 17;
            this.saveAsButton.Text = "Save As...";
            this.saveAsButton.UseVisualStyleBackColor = true;
            this.saveAsButton.Click += new System.EventHandler(this.saveAsButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(718, 388);
            this.Controls.Add(this.saveAsButton);
            this.Controls.Add(this.currentDictionaryLabel);
            this.Controls.Add(this.loadButton);
            this.Controls.Add(this.checkCheckbox);
            this.Controls.Add(this.identifierTextbox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.authorTextbox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.nameTextbox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.addEntryButton);
            this.Name = "Form1";
            this.Text = "Dictionary Creator";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button addEntryButton;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox nameTextbox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox authorTextbox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox identifierTextbox;
        private System.Windows.Forms.CheckBox checkCheckbox;
        private System.Windows.Forms.Button loadButton;
        private System.Windows.Forms.Label currentDictionaryLabel;
        private System.Windows.Forms.Button saveAsButton;
    }
}

