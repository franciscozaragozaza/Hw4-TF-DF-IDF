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
        Query Query;
        public LoadCollection()
        {
            interfaz = new Form1();
            operation = new Operations();
        }

        public Double LoadFile(String path, String searchTerm, String searchDocument, Boolean calcularDF_IDF)
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


                return operation.calcularDf_iDF(matrix, searchTerm);

            }
            catch (Exception ex)
            {
                error = ex.ToString();
                interfaz.messageBox_loaderAlert(error);
            }
            return (new Double[] {0});
        }

        /// <summary>
        /// Relevance Feedback returns a new Query using IDE DEC HI
        /// </summary>
        /// <param name="relevantIndexes"></param>
        /// <returns></returns>
        public string RelvanceFeedback(string[] relevantIndexes, string irrelevantDoc)
        {
            string[] relevantMatrix = new string[relevantIndexes.Count()];
            string newQuery;
            string[] irrelevantArray, oldQuery, vocabulary;
            string[,] splittedRelevantMatrix;

            string connectionString;
            string query = "SELECT Text FROM Docs WHERE Id == @docId";
            connectionString = ConfigurationManager.ConnectionStrings["HW4.Properties.Settings.DBConnectionString"].ConnectionString;
            double[] weigthTermMatrix = new double[relevantIndexes.Count()];
            for (int i = 0; i< relevantIndexes.Count(); i++){
                using (connection = new SqlConnection(connectionString))
                {
                    try
                    {
                        using (SqlCommand command = new SqlCommand(query, connection))
                        {
                            command.Parameters.AddWithValue("@docId", relevantIndexes[i]);
                            SqlDataReader reader = command.ExecuteReader();
                            if (reader.HasRows)
                            {
                                while (reader.Read())
                                {
                                    relevantMatrix[i] = reader.GetSqlValue(2).ToString();;
                                }
                            }
                        }
                    }
                    catch { }
                }
            }

            irrelevantArray = irrelevantDoc.stripPunctuations().splitToArray();
            oldQuery = interfaz.getQueryTextBox().stripPunctuations().splitToArray();

            vocabulary = getVocabulary(oldQuery, relevantMatrix, irrelevantArray);

            getLogicView(vocabulary, oldQuery);
            for (int i=0; i<relevantIndexes.Count();i++)
            {
                getrelevantMatrix[i];
            }
            getLogicView(vocabulary, irrelevantArray);
            
            newQuery = getQuery();
            return newQuery;
        }
        
        private double[] getLogicView(string[] vocabulary, string[] inputText)
        {
            double[] logicView = new double[vocabulary.Length];
            for (int i =0; i< vocabulary.Length; i++)
            {
                    logicView[i] = operation.getWeights(vocabulary, inputText[i]);
            }
            return logicView;
        }

        private string[] getVocabulary(string [] query, string[] relevant, string[] irrelevant)
        {
            string[] vocabulary;
            return vocabulary;
        }

        private double[] getQuery(double[] query, double[,] pesosDocRelevantes, double[] pesosDocIrrelevante)
        {
            /*Pesos de Rocchio*/
            double alfa = 1;
            double beta = 0.75;
            //Aquí se guarda el resultado
            double[] newQuery = new double[query.GetLength(0)];
            double[] sumaPesosDocRelevantes;

            //Hacemos la multiplicación de nuestra query "original" con alfa
            for (int i = 0; i < query.GetLength(0); i++)
            {
                query[i] = query[i] * alfa;
            }

            //Hacemos la multiplicación de la sumatoria de los pesos de los documentos relevantes por beta
            sumaPesosDocRelevantes = sumarVectores(pesosDocRelevantes);
            for (int i = 0; i < query.GetLength(0); i++)
            {
                sumaPesosDocRelevantes[i] = sumaPesosDocRelevantes[i] * beta;
            }

            /*Sumamos los pesos de la query y la sumatoria de los docs relevantes*/
            for (int i = 0; i < query.GetLength(0); i++)
            {
                newQuery[i] = query[i] + sumaPesosDocRelevantes[i];
            }

            /*Hacemos la resta de nuestro acumulado menos los pesos del doc irrelevante mas importante*/
            for (int i = 0; i < query.GetLength(0); i++)
            {
                newQuery[i] = newQuery[i] - pesosDocIrrelevante[i];
            }

            return newQuery;
        }

        private double[] sumarVectores(double[,] pesosDocRelevantes) //Realizamos la suma de los vectores que se encuentran en nuestra matriz
        {
            double[] resultado = new double[pesosDocRelevantes.GetLength(1)];
            int filas = pesosDocRelevantes.GetLength(0);
            int columnas = pesosDocRelevantes.GetLength(1);

            for (int i = 0; i < filas; i++)
            {
                for (int j = 0; j < columnas; j++)
                {
                    resultado[i] = resultado[i] + pesosDocRelevantes[j, i];
                }
            }

            return resultado;
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
            }
            catch (Exception ex)
            {
                error = ex.ToString();
                interfaz.messageBox_loaderAlert(error);
            }
        }
    }
}
