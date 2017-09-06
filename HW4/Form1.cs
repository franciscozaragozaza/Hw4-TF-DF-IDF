using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows;

namespace HW4
{
    public partial class Form1 : Form
    {
        Controller.LoadCollection loader;
        public Form1()
        {
            InitializeComponent();
        }

        private void openFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            loader = new Controller.LoadCollection();
            String path = "";

            try
            {
                OpenFileDialog file = new OpenFileDialog();
                if (file.ShowDialog() == DialogResult.OK)
                {
                    path = file.FileName;
                    loader.LoadFile(path);
                }



            }
            catch { }

        }

        /**
         * VENTANAS DE ALERTA
         * 
         */
        public void messageBox_loaderAlert(String errorMessage)
        {
            MessageBox.Show(errorMessage, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        public void messageBox_message(String text)
        {
            MessageBox.Show(text, "Alert", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }
    }
}
