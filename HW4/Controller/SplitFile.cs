using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW4.Controller
{
    class SplitFile
    {
        String colection = "";
        String [] splittedCollection1;
        
        public SplitFile(String aColection)
        {
            this.colection = aColection;
        }

        public void SplitLISA()
        {
            String[] arregloAux = new String[splittedCollection1.Count()];
            splittedCollection1 = colection.Split(new[] { "********************************************" }, StringSplitOptions.None);

            for(int i = 0; i<splittedCollection1.Count(); i++)
            {
                // Vamos a ocupar substring e index of para obtener el titulo, id y texto separados de splittedCollection1 :3 :*

            }
            //Eliminar arreglos de memoria
        }

    }
}
