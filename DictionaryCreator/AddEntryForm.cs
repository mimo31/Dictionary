using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DictionaryCreator
{
    public partial class AddEntryForm : Form
    {
        public event EntryAddedEventHandler EntryAdded;

        public AddEntryForm()
        {
            InitializeComponent();
        }

        public void TryAdd()
        {
            if (this.questionTextbox.Text == "")
            {
                MessageBox.Show("You must enter the question!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else if (this.answerTextbox.Text == "")
            {
                MessageBox.Show("You must enter the answer!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            this.EntryAdded?.Invoke(this, new EntryAddedEventArgs(this.questionTextbox.Text, this.answerTextbox.Text, this.categoriesTextbox.Text, this.noteTextbox.Text));
            this.questionTextbox.Text = "";
            this.answerTextbox.Text = "";
            this.categoriesTextbox.Text = "";
            this.noteTextbox.Text = "";
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            this.TryAdd();
        }

        private void submittableKeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.TryAdd();
                this.questionTextbox.Focus();
                e.Handled = true;
				e.SuppressKeyPress = true;
            }
        }
    }

    public class EntryAddedEventArgs : EventArgs
    {
        public string Question { get; set; }
        public string Answer { get; set; }
        public string Categories { get; set; }
        public string Note { get; set; }

        public EntryAddedEventArgs(string question, string answer, string categories, string note) : base()
        {
            this.Question = question;
            this.Answer = answer;
            this.Categories = categories;
            this.Note = note;
        }
    }

    public delegate void EntryAddedEventHandler(object sender, EntryAddedEventArgs e);
}
