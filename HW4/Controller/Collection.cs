using System;
using System.IO;
using System.Data.SqlClient;
using System.Configuration;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW4.Controller
{
    
    class Collection
    {
        Form1 mainWindow;

        /// <summary>
        /// Adds a collection in a text file to the database.
        /// </summary>
        /// <param name="collectionName">Name of the collection to which the documents belong.</param>
        /// <param name="path">File path of the .txt file to retrieve the collection.</param>        
        public void AddCollectiontoDB(String collectionName, String path)
        {
            try
            {
                File.Exists(path);
                string[] splittedFile;
                splittedFile = SplitFile(path, collectionName);
                
                //Agregar a la BD
            }
            catch(Exception ex)
            {
                String error = ex.ToString();
                mainWindow.messageBox_loaderAlert(error); //creates a new messagebox alert with the error message.
            }
        }
        
        /// <summary>
        /// Updates the posting list and writes it to the data base. 
        /// It must be used every time the collection is updated.
        /// </summary>
        private void UpdatePostingList()
        {

        }

        /// <summary>
        /// Given the path of a txt file, returns a linked list
        /// whichs its nodes point to arrays with the structure
        /// [docId, docTitle, docText].
        /// </summary>
        /// <param name="path">Text file with the collection.</param>
        /// <param name="collectionName">Name of the collection</param>
        private String[] SplitFile(String path, String CollectionID = "LISA")
        {
            //Método óptimo para el procesamiento.

            TextReader text = File.OpenText(path); //Probs inútil
            String content = new StreamReader(path, Encoding.UTF8).ReadToEnd(), indexSplitColection;
            
            String[] collectionText;
            switch (CollectionID)
            {
                case "LISA":
                    indexSplitColection = "********************************************\n";
                    collectionText = content.Split(new[] { indexSplitColection }, StringSplitOptions.None); //Splits the collection in to a N size linked list
                    
                    Console.WriteLine("Adding text to lisa");
                    break;
                //case "CACM":
                //    indexSplitColection = "";
                //    Console.WriteLine("Case 2");
                //    break;
                //case "CISI":
                //    indexSplitColection = "";
                //    Console.WriteLine("Case 2");
                //    break;
                //case "CRAN":
                //    indexSplitColection = "";
                //    Console.WriteLine("Case 2");
                //    break;
                //case "MED":
                //    indexSplitColection = "";
                //    Console.WriteLine("Case 2");
                //    break;
                //case "NPL":
                //    indexSplitColection = "";
                //    Console.WriteLine("Case 2");
                //    break;
                //case "TIME":
                //    indexSplitColection = "";
                //    Console.WriteLine("Case 2");
                //    break;
                default:
                    Console.WriteLine("The ID of the collection could not be located.");
                    break;
            }
            collectionText = new String[1];
            return collectionText;
        }

        private void SplitDocuments()
        {

        }
    }
}