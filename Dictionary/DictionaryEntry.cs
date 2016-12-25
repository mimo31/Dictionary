using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DictionaryBase
{
    public class DictionaryEntry
    {
        public string Question { get; set; }
        public string Answer { get; set; }
        public string[] Categories { get; set; } = null;
        public string Note { get; set; } = null;

        public DictionaryEntry(BinaryReader reader, uint version)
        {
            this.Question = reader.ReadString();
            this.Answer = reader.ReadString();
            switch (version)
            {
                case 1:
                    int numberOfCategories = reader.ReadInt32();
                    this.Categories = new string[numberOfCategories];
                    for (int i = 0; i < numberOfCategories; i++)
                    {
                        this.Categories[i] = reader.ReadString();
                    }
                    this.Note = reader.ReadString();
                    break;
            }
        }

        public DictionaryEntry(string question, string answer, string[] categories, string note)
        {
            this.Question = question;
            this.Answer = answer;
            this.Categories = categories;
            this.Note = note;
        }

        public void Write(BinaryWriter writer)
        {
            writer.Write(this.Question);
            writer.Write(this.Answer);
            writer.Write(this.Categories == null ? 0 : this.Categories.Length);
            if (this.Categories != null)
            {
                for (int i = 0; i < this.Categories.Length; i++)
                {
                    writer.Write(this.Categories[i]);
                }
            }
            writer.Write(this.Note == null ? "" : this.Note);
        }
    }
}
