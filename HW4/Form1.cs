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
        Controller.Wrapper Control;
        public Form1()
        {
            InitializeComponent();
        }
        //Menú
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

        //Botones

        /**
         * VENTANAS DE ALERTA
         * 
         */
        public void messageBox_loaderAlert(String errorMessage)
        {
            MessageBox.Show(errorMessage, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        public void messageBox_message(String text, int opt)
        {
            switch (opt)
            {
                case 0: //ALERT
                    MessageBox.Show(text, "Alert", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    break;
                case 1: //ERROR
                    MessageBox.Show(text, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    break;
                default: //INFO
                    MessageBox.Show(text, "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    break;
            }
            
        }

        private void button_CalculateDFandIDF_MouseClick(object sender, MouseEventArgs e)
        {
            
        }

        private void textBox_Term_TextChanged(object sender, EventArgs e)
        {
            if (textBox_Term.Text != String.Empty)
            {
                button_CalculateDFandIDF.Enabled = true;
            }
            else
            {
                button_CalculateDFandIDF.Enabled = false;
            }
        }
    }
}
