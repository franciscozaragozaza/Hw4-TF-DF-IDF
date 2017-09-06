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

        public String[,] SplitLISA()
        {
            // Declaración de variables:
            String indexSplitColection;
            //String indexSplitTitle;

            indexSplitColection = "********************************************\r\n";

            splittedCollection1 = collection.Split(new[] { indexSplitColection }, StringSplitOptions.None); //Separa la colección en un arreglo con n cantidad de documentos

            //Se crea un arreglo bidimensional del tamaño necesario.
            String[,] matrix = new String[splittedCollection1.Count(), 3];

            for (int i = 0; i < splittedCollection1.Count(); i++)
            {
                int aux;
                int aux2;
                int aux3;

                try
                {
                    if (splittedCollection1[i] != null)
                    {
                        matrix[i, 0] = splittedCollection1[i].Substring(0, splittedCollection1[0].IndexOf("\r\n")); //substring desde el inicio de la string hasta el primer salto de línea

                        aux = splittedCollection1[i].IndexOf("\r\n", splittedCollection1[i].IndexOf("\r\n\r\n") + 1); //int aux es el indice del último caracter del título
                        aux2 = splittedCollection1[i].IndexOf("\r\n") + 2; //int aux2 es el indice del primer caracter del título

                        matrix[i, 1] = splittedCollection1[i].Substring(aux2, aux - aux2 - 2); //matrix en la posición Título ([n,2]) es una subcadena desde la posición aux2 que mide aux - aux2 caracteres, al final le restamos 2 porque \r\n se toma como un sólo caracter y queremos eliminarlos.

                        aux3 = splittedCollection1[i].IndexOf("\r\n", aux + 1) + 2;

                        matrix[i, 2] = splittedCollection1[i].Substring(aux + 2, splittedCollection1[i].Length - (aux + 2)).Replace("\r\n", " ");
                    }
                }
                catch
                {

                }
                // Vamos a ocupar substring e index of para obtener el titulo, id y texto separados de splittedCollection1 :3 :*
            }
            return matrix;


        }

    }
}
