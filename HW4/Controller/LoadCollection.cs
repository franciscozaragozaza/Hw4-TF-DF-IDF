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
        public Double[] LoadFile(String path, String searchTerm, String searchDocument, Boolean all)
        {
            String error;
            String[,] matrix;
            Double[] matrixError = new Double[0];
            String[] terms;
            //loads path
            try
            {
               
                File.Exists(path);

                TextReader textReader = File.OpenText(path);

                string content = new StreamReader(path, Encoding.UTF8).ReadToEnd();

                splitter = new SplitFile(content);
                matrix = splitter.SplitLISA();
                
                terms = operation.OrderCollectionTerms(splitter.SplitLISA());

                if (all.Equals(false))
                {
                    return operation.TermFrequencyTable(matrix, terms, searchTerm, searchDocument);
                }

                else {
                    return operation.TermFrequencyAll(matrix, terms, searchTerm, searchDocument);
                }
                
            }
            catch (Exception ex)
            {
                error = ex.ToString();
                interfaz.messageBox_loaderAlert(error);
            }
            return matrixError;
        }

        public void ShowDocumentTitles(String path)
        {
            String error;
            String[,] matrix;
            //loads path
            try
            {

                File.Exists(path);

                interfaz.messageBox_message(path + "\nwas loaded.", -1);

                TextReader textReader = File.OpenText(path);

                string content = new StreamReader(path, Encoding.UTF8).ReadToEnd();

                splitter = new SplitFile(content);
                matrix = splitter.SplitLISA();

                interfaz.LoadDataTable(matrix); //Llena la tabla
            }
            catch (Exception ex)
            {
                error = ex.ToString();
                interfaz.messageBox_loaderAlert(error);
            }
        }
    }
}
