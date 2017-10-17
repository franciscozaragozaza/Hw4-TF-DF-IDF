using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW4.Controller
{
    /// <summary>
    /// Terms are the indexed units.
    /// </summary>
    class Term
    {
        private String termValue;

        public String TermValue
        {
            get
            {
                return termValue;
            }
            set
            {
                if (value != " ") //Checks the string is not an empty char.
                {
                    termValue = value;
                }
            }
        }

        DataMapper dataMapper = new DataMapper();

        /// <summary>
        /// Returns the inverse document frequency (IDF) of the term.
        /// </summary>
        public double getIDF()
        {
            double invDocFreq, docFreq, m;
            if (isNull())
            {
                return -1;
            }//end if
            else
            {
                m = dataMapper.GetDocumentCount(TermValue); //gets how many documents are in the collection.
                docFreq = getDF(); //gets document frequency of the term.
                invDocFreq = Math.Log10(docFreq / m);
                return invDocFreq;
            }//end else
        }

        /// <summary>
        /// Returns in how many collection documents the term appears.
        /// </summary>
        public int getDF()
        {
            int docFreq;
            if (isNull())
            {
                return -1;
            }//end if
            else
            {
                docFreq = dataMapper.GetTermDocFreq(TermValue); //Counts the number of entries for a term. 
                return docFreq;
            }//end else
        }

        /// <summary>
        /// Returns the Posting List for the term.
        /// </summary>
        public int[] getOccurrences()
        {
            int[] postingTable;
            if (isNull())
            {
                int[] fail = new int[] { -1, -1 };
                Console.WriteLine("Posting table is empty.");
                return fail;
            }//end if
            else
            {
                postingTable = dataMapper.GetPostingTable(TermValue); //Returns an array with the posting table.
                return postingTable;
            }//end else
        }

        /// <summary>
        /// Checks if termValue has been asigned a value.
        /// Returns a boolean.
        /// </summary>
        /// <returns>Returns true when is null and false when is not null</returns>
        private bool isNull()
        {
            if (termValue.Length < 1) //Checks if the number of characters in the term is less than 1
            {
                Console.Write("Error in class Term. String termValue is null or has not being asigned.");
                return true;
            }//ends if
            else
            {
                return false;
            }//ends if
        }
    }
}
