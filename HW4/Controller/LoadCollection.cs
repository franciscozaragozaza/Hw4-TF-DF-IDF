﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW4.Controller
{
    class LoadCollection
    {

        Form1 interfaz;
        SplitFile splitter;
        public LoadCollection()

       {
            interfaz = new Form1();

        }
        public void LoadFile(String path)
        {
            String error;

            //loads path
            try 
            {
                File.Exists(path);
                interfaz.messageBox_message(path);
                TextReader textReader = File.OpenText(path);
                string content = new StreamReader(path, Encoding.UTF8).ReadToEnd();
                
                splitter = new SplitFile(content);
                
                //DIFERENTES CASOS DE SPLIT

                splitter.SplitLISA();

            }
            catch(Exception ex)
            {
                error = ex.ToString();
                interfaz.messageBox_loaderAlert(error);
            }
        }
    }
}
