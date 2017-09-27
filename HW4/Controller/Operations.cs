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
            noRepeatMatrix = newLinkedList.Distinct().ToArray();
            Array.Sort(noRepeatMatrix, StringComparer.InvariantCulture);

            return noRepeatMatrix;


        }

        //Para desplegar el idf y df de todo


        public double[] calcularDf_iDF(String[,] matrix, String searchTerm)
        {
            double[] df_idf = { 0, 0 };
            int df = 0;
            int documentIndex;
            double aux1, aux2, aux3;
            documentIndex = 0;
            //Buscar el indice del documento FALTA AGREGAR EXCEPTION EN CASO DE QUE NO LO ENCUENTRE
         

            //Buscar el indice del termino:
            //termIndex = Array.IndexOf(terms, searchTerm);

            //Quitar signos del texto
            matrix[documentIndex, 2] = matrix[documentIndex, 2].Replace(". ", " ");
            matrix[documentIndex, 2] = matrix[documentIndex, 2].Replace(", ", " ");
            matrix[documentIndex, 2] = matrix[documentIndex, 2].Replace(": ", " ");
            matrix[documentIndex, 2] = matrix[documentIndex, 2].Replace("; ", " ");
            matrix[documentIndex, 2] = matrix[documentIndex, 2].Replace("\" ", " ");
            matrix[documentIndex, 2] = matrix[documentIndex, 2].Replace("(", string.Empty);
            matrix[documentIndex, 2] = matrix[documentIndex, 2].Replace(")", string.Empty);


            for (int i =0; i < 500; i++)
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

            //Obtener IDF
            aux1 = Convert.ToDouble(matrix.GetLength(0));
            aux2 = df_idf[0];
            if (aux1 == 0 || aux2 == 0)
            {
                df_idf[1] = 0;
            }
            else
            {
                aux3 = aux1 / aux2;
                df_idf[1] = Math.Log10(aux3);
            }

            return df_idf;
        }

        public double TermFrequency(String[,] matrix, String[] terms, String searchTerm, String searchDocument)
        {
            
            double[] df_idf = { 0, 0 };
            double tf = 0, df = 0, idf = 0;
            int documentIndex;
            double aux1, aux2, aux3;
            documentIndex = 0;
            //Buscar el indice del documento FALTA AGREGAR EXCEPTION EN CASO DE QUE NO LO ENCUENTRE
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                if (matrix[i, 1] == searchDocument)
                {
                    documentIndex = i;
                    break;
                }
                /*if (i == matrix.GetLength(1))
                {
                    documentIndex = -1;
                    break;
                }*/
            }

            //Buscar el indice del termino:
            //termIndex = Array.IndexOf(terms, searchTerm);

            //Quitar signos del texto
            matrix[documentIndex, 2] = matrix[documentIndex, 2].Replace(". ", " ");
            matrix[documentIndex, 2] = matrix[documentIndex, 2].Replace(", ", " ");
            matrix[documentIndex, 2] = matrix[documentIndex, 2].Replace(": ", " ");
            matrix[documentIndex, 2] = matrix[documentIndex, 2].Replace("; ", " ");
            matrix[documentIndex, 2] = matrix[documentIndex, 2].Replace("\" ", " ");
            matrix[documentIndex, 2] = matrix[documentIndex, 2].Replace("(", string.Empty);
            matrix[documentIndex, 2] = matrix[documentIndex, 2].Replace(")", string.Empty);

            //Calcular TF de un documento especifico
            Regex regex = new Regex(searchTerm);
            var results = regex.Matches(matrix[documentIndex, 2]);
            foreach (Match match in results)
            {
                if(match.Length == searchTerm.Length)
                {
                    tf = tf + 1;
                }
                
            }

            //Obtener IDF
            aux1 = Convert.ToDouble(matrix.GetLength(0));
           /* aux2 = termFrequency[0];
            if(aux1 == 0 || aux2 == 0)
            {
                termFrequency[1] = 0;
            }
            else
            {
                aux3 = aux1 / aux2;
                termFrequency[1] = Math.Log10(aux3);
            }           */ 
            

            return tf;
        }
    }
}
