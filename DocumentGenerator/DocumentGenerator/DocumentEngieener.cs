using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DocumentGenerator
{
    class DocumentEngieener
    {
        public void ConstructDocument(DocBuilder docBuilder)
        {
            //docBuilder.BuildAddress();
            docBuilder.BuildAuthor();
            docBuilder.BuildData();
            //docBuilder.BuildNumber();
            docBuilder.BuildType();
        }
    }
}
