using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DictionaryEditor
{
    public partial class GeneralInformationForm : Form
    {
        Form1 parentForm;
        bool loaded = false;

        public GeneralInformationForm(Form1 parentForm)
        {
            InitializeComponent();
            this.parentForm = parentForm;
            this.nameTextbox.Text = this.parentForm.DictionaryName;
            this.identifierTextbox.Text = this.parentForm.DictionaryIdentifier;
            this.authorLabel.Text = "Author: " + this.parentForm.DictionaryAuthor;
            this.dateLabel.Text = "Created on " + this.parentForm.DictionaryCreationTime;
            this.questionCountLabel.Text = this.parentForm.QuestionCount + " question" + (this.parentForm.QuestionCount == 1 ? "" : "s");
            this.loaded = true;
        }

        private void returnButton_Click(object sender, EventArgs e)
        {
            if (this.nameTextbox.Text.Equals(""))
            {
                MessageBox.Show("The name field can't be empty.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            if (this.identifierTextbox.Text.Equals(""))
            {
                MessageBox.Show("The identifier field can't be empty.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            this.Close();
        }

        private void nameTextbox_TextChanged(object sender, EventArgs e)
        {
            if (!this.nameTextbox.Text.Equals("") && this.loaded)
            {
                this.parentForm.DictionaryName = this.nameTextbox.Text;
            }
        }

        private void identifierTextbox_TextChanged(object sender, EventArgs e)
        {
            if (!this.identifierTextbox.Text.Equals("") && this.loaded)
            {
                this.parentForm.DictionaryIdentifier = this.identifierTextbox.Text;
            }
        }
    }
}
