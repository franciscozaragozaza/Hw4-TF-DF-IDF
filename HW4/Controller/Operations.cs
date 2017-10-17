using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace HW4.Controller
{
    class Operations
    {
        public String[] OrderCollectionTerms(String[,] matrix)
        {
            /*
             * Tomar todos los elementos el la posición [i,3]
             * Meterlos todos a un array palabra por palabra
             * Todas las palabras a Mayus con oldArray.ToUpper()
             * De ese array eliminar duplicados con String[] newArray = oldArray.Distinct().ToArray();
             * Ordenar newArray con newArray.Sort(testArray, StringComparer.InvariantCulture);
             **/

            int wordCount;
            LinkedList<String> newLinkedList = new LinkedList<String>();
            string[] newMatrix;
            string[] noRepeatMatrix;
            string[] finalMatrix;

            wordCount = 0;

            //Eliminar todos los signos de puntuación: ".;-,
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                try
                {
                    matrix[i, 2] = matrix[i, 2].Replace(". ", " ");
                    matrix[i, 2] = matrix[i, 2].Replace(", ", " ");
                    matrix[i, 2] = matrix[i, 2].Replace(": ", " ");
                    matrix[i, 2] = matrix[i, 2].Replace("; ", " ");
                    matrix[i, 2] = matrix[i, 2].Replace("\" ", " ");
                    matrix[i, 2] = matrix[i, 2].Replace("(", string.Empty);
                    matrix[i, 2] = matrix[i, 2].Replace(")", string.Empty);
                    
                    newMatrix = matrix[i, 2].Split(new[] { " " }, StringSplitOptions.RemoveEmptyEntries);

                    for (int j = 0; j < newMatrix.Count(); j++)
                    {
                        newLinkedList.AddLast(newMatrix[j]);
                    }

                    wordCount = wordCount + newMatrix.Count();
                }
                catch { }
            }
            finalMatrix = newLinkedList.ToArray();
            noRepeatMatrix = newLinkedList.Distinct().ToArray();
            Array.Sort(noRepeatMatrix, StringComparer.InvariantCulture);

            return noRepeatMatrix;


        }

        public int Get_d(String[,] matrix)
        {
            int wordCount;
            LinkedList<String> newLinkedList = new LinkedList<String>();
            string[] newMatrix;
            string[] finalMatrix;

            wordCount = 0;

            //Eliminar todos los signos de puntuación: ".;-,
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                try
                {


                    matrix[i, 2] = matrix[i, 2].Replace(". ", " ");
                    matrix[i, 2] = matrix[i, 2].Replace(", ", " ");
                    matrix[i, 2] = matrix[i, 2].Replace(": ", " ");
                    matrix[i, 2] = matrix[i, 2].Replace("; ", " ");
                    matrix[i, 2] = matrix[i, 2].Replace("\" ", " ");
                    matrix[i, 2] = matrix[i, 2].Replace("(", string.Empty);
                    matrix[i, 2] = matrix[i, 2].Replace(")", string.Empty);

                    newMatrix = matrix[i, 2].Split(new[] { " " }, StringSplitOptions.RemoveEmptyEntries);

                    for (int j = 0; j < newMatrix.Count(); j++)
                    {
                        newLinkedList.AddLast(newMatrix[j]);
                    }

                    wordCount = wordCount + newMatrix.Count();
                }
                catch { }
            }
            finalMatrix = newLinkedList.ToArray();
            int d;
            d = finalMatrix.GroupBy(v => v).Max(group => group.Count());

            return d;
        }

        //Para desplegar el idf y df de todo
        public double[] calcularDf_iDF(String[,] matrix, String searchTerm)
        {
            double[] df_idf = { 0, 0 };
            int df = 0;
            double aux2, aux3;
            int aux1 = 0;
            String newMatrix;

            //Buscar el indice del documento FALTA AGREGAR EXCEPTION EN CASO DE QUE NO LO ENCUENTRE
            //Buscar el indice del termino:
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                try
                {


                    matrix[i, 2] = matrix[i, 2].Replace(". ", " ");
                    matrix[i, 2] = matrix[i, 2].Replace(", ", " ");
                    matrix[i, 2] = matrix[i, 2].Replace(": ", " ");
                    matrix[i, 2] = matrix[i, 2].Replace("; ", " ");
                    matrix[i, 2] = matrix[i, 2].Replace("\" ", " ");
                    matrix[i, 2] = matrix[i, 2].Replace("(", string.Empty);
                    matrix[i, 2] = matrix[i, 2].Replace(")", string.Empty);

                    newMatrix = matrix[i, 2];



                }
                catch { }
            }
            //CONTEO DE PALABRAS

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                if (matrix[i, 2].Contains(searchTerm))
                {
                    df++;

                }
                else
                {

                }
            }

            df_idf[0] = df;

            //Obtener IDF palabra más repetida
            aux2 = df_idf[0];
            if (aux2 == 0)
            {
                df_idf[1] = 0;
            }
            else
            {
                aux3 = matrix.GetLength(0) / aux2;
                df_idf[1] = Math.Log10(aux3);
            }

            return df_idf;
        }

        public String[,] queryIdf(String[,] matrix, String query)
        {
            String[,] arraySim = new String[matrix.GetLength(0), 2];
            String[] newMatrix;
            String[] querySplitted;
            double idf, simi = 0;
            query = query.Replace(". ", " ");
            query = query.Replace(", ", " ");
            query = query.Replace(": ", " ");
            query = query.Replace("; ", " ");
            query = query.Replace("\" ", " ");
            query = query.Replace("(", string.Empty);
            query = query.Replace(")", string.Empty);
            querySplitted = query.Split(new[] { " " }, StringSplitOptions.RemoveEmptyEntries);

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                simi = 0;
                matrix[i, 2] = matrix[i, 2].Replace(". ", " ");
                matrix[i, 2] = matrix[i, 2].Replace(", ", " ");
                matrix[i, 2] = matrix[i, 2].Replace(": ", " ");
                matrix[i, 2] = matrix[i, 2].Replace("; ", " ");
                matrix[i, 2] = matrix[i, 2].Replace("\" ", " ");
                matrix[i, 2] = matrix[i, 2].Replace("(", string.Empty);
                matrix[i, 2] = matrix[i, 2].Replace(")", string.Empty);
                newMatrix = matrix[i, 2].Split(new[] { " " }, StringSplitOptions.RemoveEmptyEntries);
                for (int j = 0; j < querySplitted.Length; j++)
                {
                    // getOccurrences()
                    if (getDF(querySplitted[j], matrix) == 0)
                    {
                        idf = 0;
                    }
                    else
                    {
                        idf = Math.Log10(matrix.GetLength(0) / getDF(querySplitted[j], matrix));
                    }

                    simi = simi + (getOcurrences(querySplitted[j], newMatrix) * idf);
                }
                arraySim[i, 0] = matrix[i, 0];
                arraySim[i, 1] = simi.ToString();
            }




            return arraySim;
        }

        private float getDF(String term, String[,] matrix)
        {
            String[] newMatrix;
            int aux = 0;
            int aux2 = 0;
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                aux = 0;
                matrix[i, 2] = matrix[i, 2].Replace(". ", " ");
                matrix[i, 2] = matrix[i, 2].Replace(", ", " ");
                matrix[i, 2] = matrix[i, 2].Replace(": ", " ");
                matrix[i, 2] = matrix[i, 2].Replace("; ", " ");
                matrix[i, 2] = matrix[i, 2].Replace("\" ", " ");
                matrix[i, 2] = matrix[i, 2].Replace("(", string.Empty);
                matrix[i, 2] = matrix[i, 2].Replace(")", string.Empty);
                newMatrix = matrix[i, 2].Split(new[] { " " }, StringSplitOptions.RemoveEmptyEntries);
                for (int j = 0; j < newMatrix.Length; j++)
                {
                    if (newMatrix[j].Equals(term))
                    {
                        aux++;
                    }
                }
                if (aux > 0)
                {
                    aux2++;
                }
            }
            return (float)aux2;


        }

        public double getWeights(string[] vocabulary, string inputText)
        {
            throw new NotImplementedException();
        }

        private float getOcurrences(String term, String[] documento)
        {
            int aux = 0;
            for (int i = 0; i < documento.Length; i++)
            {
                if (documento[i].Equals(term))
                {
                    aux++;
                }
            }
            return aux;
        }

        public double TermFrequency(String[,] matrix, String[] terms, String searchTerm, String searchDocument)
        {

            double[] df_idf = { 0, 0 };
            double tf = 0;
            int documentIndex;
            double aux1 = 0;
            documentIndex = 0;
            String[] arrayAux;

            //Buscar el indice del documento FALTA AGREGAR EXCEPTION EN CASO DE QUE NO LO ENCUENTRE
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                if (matrix[i, 1] == searchDocument)
                {
                    documentIndex = i;
                    break;
                }
            }

            //Buscar el indice del termino:

            //Quitar signos del texto
            matrix[documentIndex, 2] = matrix[documentIndex, 2].Replace(". ", " ");
            matrix[documentIndex, 2] = matrix[documentIndex, 2].Replace(", ", " ");
            matrix[documentIndex, 2] = matrix[documentIndex, 2].Replace(": ", " ");
            matrix[documentIndex, 2] = matrix[documentIndex, 2].Replace("; ", " ");
            matrix[documentIndex, 2] = matrix[documentIndex, 2].Replace("\" ", " ");
            matrix[documentIndex, 2] = matrix[documentIndex, 2].Replace("(", string.Empty);
            matrix[documentIndex, 2] = matrix[documentIndex, 2].Replace(")", string.Empty);

            //Calcular TF de un documento especifico

            arrayAux = matrix[documentIndex, 2].Split(new[] { " " }, StringSplitOptions.RemoveEmptyEntries);

            for (int i = 0; i < arrayAux.GetLength(0); i++)
            {
                if (arrayAux[i].Equals(searchTerm))
                {
                    tf++;
                }
            }
            aux1 = Convert.ToDouble(matrix.GetLength(0));
            return tf;
        }

        public double[] getTermFrequency(String text)
        {
            //Clase fantasma
            double[] arrayIdf = new double[1];
            return arrayIdf;
        }
    }
}