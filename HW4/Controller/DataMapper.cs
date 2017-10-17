using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW4.Controller
{
    /// <summary>
    /// A layer of Mappers that moves data between objects and a database
    /// while keeping them independent of each other and the mapper itself.
    /// </summary>
    class DataMapper
    {
        //Manage database conections


        //Get term methods

        public int GetDocumentCount(String term)
        {
            return 1;
        }

        public int GetTermDocFreq(String term)
        {
            return 1;
        }

        public int[] GetPostingTable(String term)
        {
            int[] prueba = { 1, 2 };
            return prueba;
        }

        public void InsertToDocs(String[] docString)
        {

        }
        public void InsertToPosting()
        {

        }
    }
}
