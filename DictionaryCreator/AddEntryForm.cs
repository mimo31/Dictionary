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
            this.EntryAdded?.Invoke(this, new EntryAddedEventArgs(this.questionTextbox.Text, this.answerTextbox.Text));
            this.questionTextbox.Text = "";
            this.answerTextbox.Text = "";
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            this.TryAdd();
        }

        private void answerTextbox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.TryAdd();
            }
        }
    }

    public class EntryAddedEventArgs : EventArgs
    {
        public string Question { get; set; }
        public string Answer { get; set; }

        public EntryAddedEventArgs(string question, string answer) : base()
        {
            this.Question = question;
            this.Answer = answer;
        }
    }

    public delegate void EntryAddedEventHandler(object sender, EntryAddedEventArgs e);
}
