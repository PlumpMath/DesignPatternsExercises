using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DocumentGenerator
{
    class Program
    {
        static void Main(string[] args)
        {
            DocumentEngieener docEnginner = new DocumentEngieener();
            DocBuilder dBuilder = new ZapytanieBuilder();
            
            docEnginner.ConstructDocument(dBuilder);
            Document doc = dBuilder.getDocument();

            doc.Show();
            Console.ReadKey();

        }
    }
}
