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

        public void Fill_TermIdf(String[,] matrix, String[] terms)
        {
            string connectionString;
            string query = "INSERT INTO TermIdf (Term, idf) VALUES (@Term, @Idf)";
            connectionString = ConfigurationManager.ConnectionStrings["HW4.Properties.Settings.DBConnectionString"].ConnectionString;

            using (connection = new SqlConnection(connectionString))
                try
                {
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        float idf = 0.5f;
                        connection.Open();
                        //llena la tabla TermIdf de Term.
                        for (int i = 0; i < terms.Length; i++)
                        {
                            idf = (float)operation.calcularDf_iDF(matrix, terms[i])[1];
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
                }
                catch { }

            query = "INSERT INTO TermFre (Term, DocId, TermFrequency) VALUES (@Term, @DocId, @TermFreq)";
            connectionString = ConfigurationManager.ConnectionStrings["HW4.Properties.Settings.DBConnectionString"].ConnectionString;

            using (connection = new SqlConnection(connectionString))
                try
                {
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        float tf = 0;
                        connection.Open();
                        //llena la tabla de Term.
                        for (int j = 0; j < matrix.GetLength(0); j++)
                        {
                            for (int i = 0; i < terms.Length; i++)
                            {
                                tf = (float)operation.TermFrequency(matrix, terms, terms[i], matrix[j, 1]);
                                if (terms[i] != null || matrix[j, 1] != null)
                                {
                                    command.Parameters.Clear();
                                    command.Parameters.AddWithValue("@Term", terms[i]);
                                    command.Parameters.AddWithValue("@DocId", matrix[j, 0]);
                                    command.Parameters.AddWithValue("@TermFreq", tf);
                                    command.ExecuteNonQuery();
                                }
                            }
                        }
                    }
                }
                catch { }
        }

        public Double [] CalcularDf_IDF(String path, String searchTerm, String searchDocument, Boolean calcularDF_IDF)
        {
            String[,] matrix;
            String error;
            int d;
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
                d = operation.Get_d(splitter.SplitLISA());

                //Fill_TermIdf(matrix, terms);
                //Añadir terminos a tabla TermIdf

                /////////////////////////////////////////////////////////////////////////////////
                /*
                string connectionString;
                string query = "INSERT INTO TermIdf (Term, idf) VALUES (@Term, @Idf)";
                connectionString = ConfigurationManager.ConnectionStrings["HW4.Properties.Settings.DBConnectionString"].ConnectionString;

                using (connection = new SqlConnection(connectionString))
                    try
                    {
                        using (SqlCommand command = new SqlCommand(query, connection))
                        {
                            float idf = 0.5f;
                            connection.Open();
                            //llena la tabla TermIdf de Term.
                            for (int i = 0; i < terms.Length; i++)
                            {
                                idf = (float)operation.calcularDf_iDF(matrix, terms[i])[1];
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
                    }
                    catch { }
                */
                /////////////////////////////////////////////////////////////////////////////////

                return operation.calcularDf_iDF(matrix, searchTerm);

            }
            catch (Exception ex)
            {
                error = ex.ToString();
                interfaz.messageBox_loaderAlert(error);
            }
            return (new Double[] {0});
        }

        public void search(string query, string path)
        {
            String[,] matrix;
            String[,] simi;
            try
            {

                File.Exists(path);
                TextReader textReader = File.OpenText(path);
                //...
                string content = new StreamReader(path, Encoding.UTF8).ReadToEnd();
                splitter = new SplitFile(content);
                matrix = splitter.SplitLISA();
                simi = operation.queryIdf(matrix, query);

                TruncateQueryTable();
                string connectionString;
                string sqlQuery = "INSERT INTO QueryRes (DocId, Similarity) VALUES (@Id, @Sim)";
                connectionString = ConfigurationManager.ConnectionStrings["HW4.Properties.Settings.DBConnectionString"].ConnectionString;

                using (connection = new SqlConnection(connectionString))
                        using (SqlCommand command = new SqlCommand(sqlQuery, connection))
                        {
                            connection.Open();
                            //llena la tabla TermIdf de Term.
                            for (int i = 0; i < simi.GetLength(0); i++)
                            {
                                if (simi[i,0] != null)
                                {
                                    command.Parameters.Clear();
                                    command.Parameters.AddWithValue("@Id", simi[i,0]);
                                    command.Parameters.AddWithValue("@Sim", simi[i,1]);
                                    command.ExecuteNonQuery();
                                }
                            }
                        }
                
                    
            }
            catch { }


        }

        public void TruncateQueryTable()
        {
            string connectionString;
            string sqlQuery = "TRUNCATE TABLE QueryRes";
            connectionString = ConfigurationManager.ConnectionStrings["HW4.Properties.Settings.DBConnectionString"].ConnectionString;

            using (connection = new SqlConnection(connectionString))
            using (SqlCommand command = new SqlCommand(sqlQuery, connection))
            {
                connection.Open();
                command.ExecuteNonQuery();
            }
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
