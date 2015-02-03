using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DocumentGenerator
{
    abstract class DocBuilder
    {
        public abstract void BuildAddress();
        public abstract void BuildData();
        public abstract void BuildThema();
        public abstract void BuildNumber();
        public abstract void BuildAuthor();
        public abstract void BuildType();

        public abstract Document getDocument();

    }
}
