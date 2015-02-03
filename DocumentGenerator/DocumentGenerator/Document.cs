using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DocumentGenerator
{
    class Document
    {
        private string _type;
        private string _data;
        private string _thema;
        private string _number;
        private string _author;
        private string _address;

        public string Type
        {
            get { return _type; }
            set { _type = value; }
        }

        public string Data
        {
            get { return _data; }
            set { _data = value; }
        }

        public string Thema
        {
            get { return _thema; }
            set { _thema = value; }
        }

        public string Number
        {
            get { return _number; }
            set { _number = value; }
        }

        public string Author
        {
            get { return _author; }
            set { _author = value; }
        }

        public string Address
        {
            get { return _address; }
            set { _address = value; }
        }

        public void Show()
        {
            Console.WriteLine("\n                 {0} ", _data);
            Console.WriteLine("\n             {0}     ", _address);
            Console.WriteLine("\n         {0} nr {1}  ", _type, _number);
            Console.WriteLine("\n{0}:                 ", _thema);
            Console.WriteLine("\n\n       Z poważaniem");
            Console.WriteLine("\n               {0}     ", _author);
        }
        
    }
}
