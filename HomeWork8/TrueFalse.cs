using System;
using System.Collections.Generic;
using System.IO;
using System.Xml.Serialization;

namespace HomeWork8
{
    [Serializable]
    public class Question
    {
        public string Text;

        public bool TrueFalse;

        private Question()
        {
        }

        public Question(string text, bool trueFalse)
        {
            Text = text;
            TrueFalse = trueFalse;
        }
    }

    class TrueFalse
    {
        readonly string _fileName;
        List<Question> _list;

        public TrueFalse(string fileName)
        {
            _fileName = fileName;
            _list = new List<Question>();
        }

        public void Add(string text, bool trueFalse)
        {
            _list.Add(new Question(text, trueFalse));
        }

        public void Remove(int index)
        {
            if (_list != null && index < _list.Count && index >= 0) _list.RemoveAt(index);
        }

        public Question this[int index]
        {
            get { return _list[index]; }
        }

        public void Save()
        {
            XmlSerializer xmlFormat = new XmlSerializer(typeof(List<Question>));
            Stream fStream = new FileStream(_fileName, FileMode.Create, FileAccess.Write);
            xmlFormat.Serialize(fStream, _list);
            fStream.Close();
        }

        public void SaveAs(string fileName)
        {
            XmlSerializer xmlFormat = new XmlSerializer(typeof(List<Question>));
            Stream fStream = new FileStream(fileName, FileMode.Create, FileAccess.Write);
            xmlFormat.Serialize(fStream, _list);
            fStream.Close();
        }

        public void Load()
        {
            XmlSerializer xmlFormat = new XmlSerializer(typeof(List<Question>));
            Stream fStream = new FileStream(_fileName, FileMode.Open, FileAccess.Read);
            _list = (List<Question>) xmlFormat.Deserialize(fStream);
            fStream.Close();
        }

        public int Count
        {
            get { return _list.Count; }
        }
    }
}