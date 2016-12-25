using System;
using System.Collections.Generic;
using System.IO;

namespace DictionaryBase
{
    public class Dictionary
    {
        List<DictionaryEntry> Data;
        public string Name { get; set; } = "";
        public string Author { get; set; } = "";
        public string Identifier { get; set; } = "";
        public DateTime CreatedOn { get; set; }
        public bool DoCheck { get; set; } = true;

		// the version of the Dictionary structure of this Dictionary, 0 the lowest
        public uint Version { get; set; } = 0;

        public Dictionary()
        {
            this.Data = new List<DictionaryEntry>();
        }

        public void AddEntry(string question, string answer, string categories, string note)
        {
            string[] categoriesArray = categories.Split(';');
            for (int i = 0; i < categoriesArray.Length; i++)
            {
                categoriesArray[i] = categoriesArray[i].Trim();
            }
            this.Data.Add(new DictionaryEntry(question, answer, categoriesArray, note));
        }

        public void AddEntry(DictionaryEntry entry)
        {
            this.Data.Add(entry);
        }

        public DictionaryEntry GetEntry(int index)
        {
            return this.Data[index];
        }

        public int GetNumberOfEntries()
        {
            return this.Data.Count;
        }

        public Dictionary(string saveAddress)
        {
            BinaryReader reader = null;
            try
            {
                FileStream inputStream = new FileStream(saveAddress, FileMode.Open);
                reader = new BinaryReader(inputStream);
                byte firstByte = reader.ReadByte();
                if (firstByte == 255)
                {
                    int headerLength = reader.ReadInt32();
                    byte[] headerData = new byte[headerLength];
                    reader.Read(headerData, 0, headerLength);
                    this.LoadFromHeader(headerData);
                }
                else
                {
                    inputStream.Position--;
                }
                int dataLength = reader.ReadInt32();
                this.Data = new List<DictionaryEntry>(dataLength);
                for (int i = 0; i < dataLength; i++)
                {
                    this.Data.Add(new DictionaryEntry(reader, this.Version));
                }
            }
            catch (Exception e)
            {
                throw new IOException("Couldn't load the specified file.", e);
            }
            finally
            {
                if (reader != null)
                {
                    reader.Close();
                }
            }
        }

        public void Save(string saveAddress)
        {
            FileStream outputStream = new FileStream(saveAddress, FileMode.Create);
            BinaryWriter writer = new BinaryWriter(outputStream);
            writer.Write((byte)255);
            byte[] headerData = this.GetHeaderBytes();
            writer.Write(headerData.Length);
            writer.Write(headerData);
            writer.Write(this.Data.Count);
            for (int i = 0; i < this.Data.Count; i++)
            {
                this.Data[i].Write(writer);
            }
            writer.Close();
            outputStream.Close();
        }

        private void LoadFromHeader(byte[] data)
        {
            MemoryStream memoryStream = new MemoryStream(data);
            BinaryReader reader = new BinaryReader(memoryStream);
            this.SetAsUnixTime(0);
            Action[] loaders = new Action[] {
                () => this.Name = reader.ReadString(),
                () => this.Author = reader.ReadString(),
                () => this.Identifier = reader.ReadString(),
                () => this.SetAsUnixTime(reader.ReadInt32()),
                () => this.DoCheck = reader.ReadBoolean(),
                () => this.Version = reader.ReadUInt32(),
            };
            for (int i = 0; i < loaders.Length; i++)
            {
                if (memoryStream.Position == data.Length)
                {
                    break;
                }
                else
                {
                    loaders[i]();
                }
            }
        }

        private byte[] GetHeaderBytes()
        {
            MemoryStream memoryStream = new MemoryStream();
            BinaryWriter writer = new BinaryWriter(memoryStream);
            writer.Write(this.Name);
            writer.Write(this.Author);
            writer.Write(this.Identifier);
            writer.Write(this.GetAsUnixTime());
            writer.Write(this.DoCheck);
            writer.Write((uint)1);
            byte[] bytes = memoryStream.ToArray();
            writer.Close();
            writer.Dispose();
            memoryStream.Dispose();
            return bytes;
        }

        private void SetAsUnixTime(int seconds)
        {
            this.CreatedOn = new DateTime(1970, 1, 1, 0, 0, 0).ToLocalTime() + new TimeSpan(0, 0, seconds);
        }

        private int GetAsUnixTime()
        {
            return (int)(this.CreatedOn - new DateTime(1970, 1, 1, 0, 0, 0).ToLocalTime()).TotalSeconds;
        }

        public void SetEntry(int index, DictionaryEntry value)
        {
            this.Data[index] = value;
        }

        public void RemoveEntry(int index)
        {
            this.Data.RemoveAt(index);
        }

        public void SetCurrentTime()
        {
            this.CreatedOn = DateTime.Now;
        }
    }
}
