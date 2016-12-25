using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DictionaryBase;

namespace DictionaryCreator
{
    public partial class Form1 : Form
    {
        Dictionary Dictionary = new Dictionary();
        AddEntryForm addEntryForm;
        string saveLocation;
        private bool saved = true;

        public Form1()
        {
            InitializeComponent();
        }

        private void UpdateFormTitle()
        {
            this.Text = "Dictionary Creator" + (this.Dictionary.Name != null ? (" - " + this.Dictionary.Name + " - " + saveLocation) : "") + (this.saved ? "" : " *");
        }

        private void addEntryButton_Click(object sender, EventArgs e)
        {
            if (this.addEntryForm == null)
            {
                this.addEntryForm = new AddEntryForm();
                this.addEntryForm.EntryAdded += this.AcceptEntry;
                this.addEntryForm.FormClosing += (lambdaSender, lambdaE) => this.addEntryForm = null;
                this.addEntryForm.Show(this);
            }
            else
            {
                this.addEntryForm.Focus();
            }
        }

        private void AcceptEntry(object sender, EntryAddedEventArgs e)
        {
            this.Dictionary.AddEntry(e.Question, e.Answer, e.Categories, e.Note);
            this.saved = false;
            this.UpdateFormTitle();
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            if (this.PrepareSave())
            {
                this.Save();
            }
        }

        private bool PrepareSave()
        {
            if (this.nameTextbox.Text.Equals(""))
            {
                if (this.Dictionary.Name == null)
                {
                    MessageBox.Show("You must specify the name of the Dictionary!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return false;
                }
            }
            else
            {
                this.Dictionary.Name = this.nameTextbox.Text;
            }
            if (this.authorTextbox.Text.Equals(""))
            {
                if (this.Dictionary.Author == null)
                {
                    MessageBox.Show("You must specify your name as the author of the Dictionary!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return false;
                }
            }
            else
            {
                this.Dictionary.Author = this.authorTextbox.Text;
            }
            if (this.identifierTextbox.Text.Equals(""))
            {
                if (this.Dictionary.Identifier == null)
                {
                    MessageBox.Show("You must specify the identifier of the Dictionary!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return false;
                }
            }
            else
            {
                this.Dictionary.Identifier = this.identifierTextbox.Text;
            }
            this.Dictionary.DoCheck = this.checkCheckbox.Checked;
            this.Dictionary.SetCurrentTime();
            this.UpdateMeta();
            return true;
        }

        private void Save()
        {
            if (this.saveLocation != null)
            {
                this.Dictionary.Save(saveLocation);
                this.saved = true;
                this.UpdateFormTitle();
            }
            else
            {
                this.SaveAs();
            }
        }

        private void SaveAs()
        {
            SaveFileDialog dialog = new SaveFileDialog();
            dialog.Title = "Save Dictionary";
            dialog.Filter = "Dictionary files|*.dic|All Files|*.*";
            dialog.FileName = "UnnamedDictionary.dic";
            dialog.DefaultExt = ".dic";
            dialog.AddExtension = true;
            dialog.ShowDialog();
            if (!dialog.FileName.Equals(""))
            {
                this.Dictionary.Save(dialog.FileName);
                this.saveLocation = dialog.FileName;
                this.saved = true;
                this.UpdateFormTitle();
            }
            dialog.Dispose();
        }

        private void TryLoad()
        {
            if (!this.ResolveUnsavedData())
            {
                return;
            }
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Multiselect = false;
            dialog.Title = "Load Dictionary";
            dialog.Filter = "Dictionary files|*.dic|All Files|*.*";
            dialog.DefaultExt = ".dic";
            dialog.ShowDialog();
            if (!dialog.FileName.Equals(""))
            {
                try
                {
                    this.Dictionary = new Dictionary(dialog.FileName);
                    this.UpdateMeta();
                    this.saveLocation = dialog.FileName;
                    this.saved = true;
                    this.UpdateFormTitle();
                }
                catch (Exception)
                {
                    MessageBox.Show("Failed to load this file as a dictionary.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            dialog.Dispose();
        }

        private void UpdateMeta()
        {
            this.currentDictionaryLabel.Text = "Current Dictionary: " + this.Dictionary.Name;
            this.nameTextbox.Text = this.Dictionary.Name;
            this.authorTextbox.Text = this.Dictionary.Author;
            this.identifierTextbox.Text = this.Dictionary.Identifier;
            this.checkCheckbox.Checked = this.Dictionary.DoCheck;
        }

        /// <returns>Returns whether the ongoing action should continue.</returns>
        private bool ResolveUnsavedData()
        {
            if (!this.saved)
            {
                DialogResult result = MessageBox.Show("You have some unsaved progress. Would you like to save it?", "Unsaved Progress", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Information);
                if (result == DialogResult.Yes)
                {
                    this.Save();
                }
                else if (result == DialogResult.Cancel)
                {
                    return false;
                }
            }
            return true;
        }

        private void loadButton_Click(object sender, EventArgs e)
        {
            this.TryLoad();
        }

        private void nameTextbox_TextChanged(object sender, EventArgs e)
        {
            this.saved = false;
            this.UpdateFormTitle();
        }

        private void authorTextbox_TextChanged(object sender, EventArgs e)
        {
            this.saved = false;
            this.UpdateFormTitle();
        }

        private void identifierTextbox_TextChanged(object sender, EventArgs e)
        {
            this.saved = false;
            this.UpdateFormTitle();
        }

        private void checkCheckbox_CheckedChanged(object sender, EventArgs e)
        {
            this.saved = false;
            this.UpdateFormTitle();
        }

        private void saveAsButton_Click(object sender, EventArgs e)
        {
            if (this.PrepareSave())
            {
                this.SaveAs();
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!this.ResolveUnsavedData())
            {
                e.Cancel = true;
            }
        }
    }
}
