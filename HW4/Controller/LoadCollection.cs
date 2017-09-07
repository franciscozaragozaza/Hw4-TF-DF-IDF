using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW4.Controller
{
    class LoadCollection
    {

        Form1 interfaz;
        SplitFile splitter;
        Operations operation;
        public LoadCollection()
        {
            interfaz = new Form1();
            operation = new Operations();

        }
        public void LoadFile(String path)
        {
            String error;
            String[,] matrix;
            String[] terms;
            String searchTerm;
            String searchDocument;
            //loads path
            try
            {
                searchDocument = "INDIAN LIBRARY SCIENCE LITERATURE.";
                searchTerm= "OF";
                File.Exists(path);

                interfaz.messageBox_message(path);

                TextReader textReader = File.OpenText(path);

                string content = new StreamReader(path, Encoding.UTF8).ReadToEnd();

                splitter = new SplitFile(content);
                matrix = splitter.SplitLISA();
                terms = operation.OrderCollectionTerms(splitter.SplitLISA());

                operation.TermFrequencyTable(matrix, terms, searchTerm, searchDocument);
            }
            catch (Exception ex)
            {
                error = ex.ToString();
                interfaz.messageBox_loaderAlert(error);
            }
        }
    }
}
