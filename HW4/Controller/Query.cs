using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW4.Controller
{
    /// <summary>
    /// Represents a query that retrieves information from the collection. 
    /// </summary>
    class Query
    {
        /// <summary>
        /// Represents a String with the query to be performed.
        /// </summary>
        public String queryValue;

        public double queryRes;

        private bool linguisticModules;

        /// <summary>
        /// Performs a query and returns an array with results using the boolean search model.
        /// </summary>
        /// <param name="showNresults">
        /// Number of resutls that will be saved to the database table QueryRes. Default value is 5</param>
        public void Boolean(int showNresults = 10)
        {
            queryValue.stripPunctuations(); //Strips punctuation from query string.
            // Modelo booleano

            // Termina lógica del modelo booleano
            
        }//ends method Boolean

        /// <summary>
        /// Performs a query and returns an array with results sorted by similarity using the vector space model.
        /// </summary>
        /// <param name="showNresults">
        /// Number of resutls that will be saved to the database table QueryRes. Default value is 5</param>
        public void VectorSpace(int showNresults = 10)
        {
            queryValue.stripPunctuations(); //Strips punctuation from string.
            //Inicia procesamiento del modelo espacio vector
            
            //Termina procesamiento del modelo espacio vector

            //Writes the first n results into the database.

        }//ends method VectorSpace

    }//ends class Query
}