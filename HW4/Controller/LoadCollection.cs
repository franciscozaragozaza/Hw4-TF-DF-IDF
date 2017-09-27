using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace HW4.Controller
{
    class LoadCollection
    {

        Form1 interfaz;
        SplitFile splitter;
        Operations operation;
        SqlConnection connection;
        public LoadCollection()
        {
            interfaz = new Form1();
            operation = new Operations();

        }
        public double LoadFile(String path, String searchTerm, String searchDocument, Boolean calcularDF_IDF)
        {
            String error;
            String[,] matrix;
            Double matrixError = 0;
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

                    return operation.TermFrequency(matrix, terms, searchTerm, searchDocument);
            }
            catch (Exception ex)
            {
                error = ex.ToString();
                interfaz.messageBox_loaderAlert(error);
            }

            return matrixError;
        }

        public Double [] calcularDf_IDF(String path, String searchTerm, String searchDocument, Boolean calcularDF_IDF)
        {
            String[,] matrix;
            String error;
          
            String[] terms;
            //loads path
            try
            {

                File.Exists(path);

                TextReader textReader = File.OpenText(path);
                //...
                string content = new StreamReader(path, Encoding.UTF8).ReadToEnd();

                splitter = new SplitFile(content);
                matrix = splitter.SplitLISA();

                terms = operation.OrderCollectionTerms(splitter.SplitLISA());
                //Añadir terminos a tabla TermIdf
                string connectionString; //debería ser variable de la clase.
                string query = "INSERT INTO TermIdf (Term, idf) VALUES (@Term, @Idf)";
                connectionString = ConfigurationManager.ConnectionStrings["HW4.Properties.Settings.DBConnectionString"].ConnectionString;

                using (connection = new SqlConnection(connectionString))
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    float idf = 0.5f;
                    connection.Open();
                    //llena la tabla TermIdf de Term.
                    for (int i = 0; i < terms.Length; i++)
                    {

                        if (terms[i] != null)
                        {
                            //idf = operation.calcularDf_iDF(matrix, terms[i]);
                            command.Parameters.Clear();
                            command.Parameters.AddWithValue("@Term", terms[i]);
                            command.Parameters.AddWithValue("@Idf", idf);
                            command.ExecuteNonQuery();
                        }
                    }
                }
                return operation.calcularDf_iDF(matrix, searchTerm);

            }
            catch (Exception ex)
            {
                error = ex.ToString();
                interfaz.messageBox_loaderAlert(error);
            }
            return (new Double[] {0});
        }

        public void ShowDocumentTitles(String path)
        {
            String error;
            String connectionString;
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
                //Llena la base de datos.
                connectionString = ConfigurationManager.ConnectionStrings["HW4.Properties.Settings.DBConnectionString"].ConnectionString;
                
                string query = "INSERT INTO Docs (Id, Title, Text) VALUES (@DocId, @Title, @Text)";
                connectionString = ConfigurationManager.ConnectionStrings["HW4.Properties.Settings.DBConnectionString"].ConnectionString;

                using (connection = new SqlConnection(connectionString))
                using (SqlCommand command = new SqlCommand (query, connection))
                {
                    connection.Open();
                    //llena la tabla Docs de DocID.
                    for (int i = 0; i <matrix.GetLength(0); i++)
                    {
                        if (matrix[i,0]!= null)
                        {
                            command.Parameters.Clear();
                            command.Parameters.AddWithValue("@DocId", matrix[i,0]);
                            command.Parameters.AddWithValue("@Title", matrix[i, 1]);
                            command.Parameters.AddWithValue("@Text", matrix[i, 2]);
                            command.ExecuteNonQuery();
                        }

                    }
                   
                }

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
