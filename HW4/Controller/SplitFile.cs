using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW4.Controller
{
    class SplitFile
    {
        String collection = "";
        String[] splittedCollection1;

        public SplitFile(String aColection)
        {
            this.collection = aColection;
        }

        public void SplitLISA()
        {
            /**
             * array[]
             * arrayAux[]
             * Matrix [][]
             * 
             * split se hace con substring y con FindIndex
             * loop que corre la cantidad de splits que haya de acuerdo a la primera condición (será la cantidad de documentos en el texto)
             * 
             * 
             **/

            // Declaración de variables:
            String indexSplitColection;
            String indexSplitTitle;

            indexSplitColection = "********************************************\r\n";

            splittedCollection1 = collection.Split(new[] { indexSplitColection }, StringSplitOptions.None);

            String[] arregloAux = new String[3];
            //Se crea un arreglo bidimensional del tamaño necesario.
            String[,] matrix = new String[splittedCollection1.Count(), 3];

            for (int i = 0; i < splittedCollection1.Count(); i++)
            {
                //
                //splittedCollection1[i].Split(new[] { "\r\n" }, StringSplitOptions.None);
                try
                {
                    matrix[i, 0] = splittedCollection1[i].Substring(0, splittedCollection1[i].IndexOf("\r\n"));
                    matrix[i, 1] = matrix[i,0].Substring(matrix[i,0].Length-2 , matrix[i,0].Length);
                    matrix[i, 2] = "Texto";
                }
                catch
                {

                }
                // Vamos a ocupar substring e index of para obtener el titulo, id y texto separados de splittedCollection1 :3 :*
            }
            
            indexSplitTitle = "\r\n";

        }

    }
}
