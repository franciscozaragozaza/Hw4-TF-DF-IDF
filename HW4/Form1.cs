﻿using System;
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

        Controller.LoadCollection Loader;
        Controller.Wrapper Control;

        String path = "";
        public Form1()
        {
            InitializeComponent();
        }
        //Menú
        private void openFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Loader = new Controller.LoadCollection();
            try
            {
                OpenFileDialog file = new OpenFileDialog();
                if (file.ShowDialog() == DialogResult.OK)
                {
                    path = file.FileName;
                    Loader.ShowDocumentTitles(path);
                }



            }
            catch { }

        }

        //Botones
        private void button_CalculateDFandIDF_MouseClick(object sender, MouseEventArgs e)
        {
            String searchDocument;
            String searchTerm;
            double[] df_idf = new double[2];
            searchDocument = textBox_DocumentTitle.Text;
            searchTerm = textBox_Term.Text;
            df_idf=Loader.LoadFile(path, searchTerm, searchDocument);
            textBox_DocumentFrequency.Text = df_idf[0].ToString();
            textBox_InverseDF.Text = df_idf[1].ToString();

        }
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

        public void LoadDataTable(String[,] content)
        {
            DataTable table = new DataTable();
            table.Columns.Add("Document ID", typeof(String));
            table.Columns.Add("Document Title", typeof(String));
            /*for(int i =0; i< content.GetLength(0); i++)
            {
                table.Rows.Add(content[i, 0], content[i,1]);
            }*/
            table.Rows.Add("Uno", "DOS");
            dataGridView1.DataSource = table;
        }

        //Changes

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
