using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Task4
{
    [Serializable]
    public class DictionaryEntry
    {
        public string word;
        public string translation;
        public DictionaryEntry()
        {

        }
        public DictionaryEntry(string word, string translation)
        {
            this.word = word;
            this.translation = translation;
        }
    }
    public class Dictionary
    {
        string filename;
        public string FileName
        {
            set { filename = value; }
        }

        List<DictionaryEntry> list;
        public Dictionary(string filename)
        {
            this.filename = filename;
            list = new List<DictionaryEntry>();
        }
        
        public DictionaryEntry this[int index]
        {
            get { return list[index]; }
        }

        public void Add(string word, string translation)
        {
            list.Add(new DictionaryEntry(word, translation));
        }
        public void Delete(int index)
        {
            if (list != null && index < list.Count && index >= 0) list.RemoveAt(index);
        }
        public void Save()
        {
            XmlSerializer xmlFormat = new XmlSerializer(typeof(List<DictionaryEntry>));
            Stream fStream = new FileStream(filename, FileMode.Create, FileAccess.Write);
            xmlFormat.Serialize(fStream, list);
            fStream.Close();
        }
        public void Load()
        {
            XmlSerializer xmlFormat = new XmlSerializer(typeof(List<DictionaryEntry>));
            Stream fStream = new FileStream(filename, FileMode.Open, FileAccess.Read);
            list = (List<DictionaryEntry>)xmlFormat.Deserialize(fStream);
            fStream.Close();
        }
        public int Count
        {
            get { return list.Count; }
        }
    }
}
