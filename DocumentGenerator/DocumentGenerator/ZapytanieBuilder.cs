using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DocumentGenerator
{
    class ZapytanieBuilder : DocBuilder
    {
        private Document document;
        public ZapytanieBuilder()
        {
            document = new Document();
        }

        public override void BuildAddress()
        {
            document.Address = "ul. Wybickiego 21";
        }

        public override void BuildData()
        {
            document.Data = "2014.10.11";
            
        }

        public override void BuildThema()
        {
            document.Thema = "Materialy elekryczne.";
        }

        public override void BuildNumber()
        {
            document.Number = "10/ITI/10/2014";
        }

        public override void BuildAuthor()
        {
            document.Author = "Janusz Tomaszewski";
        }

        public override Document getDocument()
        {
            return this.document;
        }

        public override void BuildType()
        {
            document.Type = "Zapytanie";
        }
    }
}
