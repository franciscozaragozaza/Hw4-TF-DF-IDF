﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW4.Controller
{
    class Operations
    {
        public void OrderCollectionTerms(String[,] matrix)
        {
            /*
             * Tomar todos los elementos el la posición [i,3]
             * Meterlos todos a un array palabra por palabra
             * Todas las palabras a Mayus con oldArray.ToUpper()
             * De ese array eliminar duplicados con String[] newArray = oldArray.Distinct().ToArray();
             * Ordenar newArray con newArray.Sort(testArray, StringComparer.InvariantCulture);
             **/

        }
        public int TermFrequency(String[,] matrix, string term = "", string document = "")
        {
            int TermCount = 0;
            /* 
             * Tomar todos los elementos el la posición [i,3]
             * Meterlos todos a un array palabra por palabra
             * De ese array eliminar duplicados con String[] newArray = oldArray.Distinct().ToArray();
             * Ordenar newArray con Array.Sort(testArray, StringComparer.InvariantCulture);
             * 
             **/
            return TermCount;
        }

        public void DocumentFrequency()
        {

        }
    }
}
