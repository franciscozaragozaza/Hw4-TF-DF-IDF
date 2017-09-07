namespace HW4
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabPageDF_IDF = new System.Windows.Forms.TabPage();
            this.button_CalculateDFandIDF = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox_InverseDF = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox_DocumentFrequency = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox_Term = new System.Windows.Forms.TextBox();
            this.tabLogicalView = new System.Windows.Forms.TabPage();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label_Document = new System.Windows.Forms.Label();
            this.textBox_DocumentTitle = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.tabControl.SuspendLayout();
            this.tabPageDF_IDF.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl
            // 
            this.tabControl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl.Controls.Add(this.tabPageDF_IDF);
            this.tabControl.Controls.Add(this.tabLogicalView);
            this.tabControl.Location = new System.Drawing.Point(4, 25);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(766, 624);
            this.tabControl.TabIndex = 6;
            // 
            // tabPageDF_IDF
            // 
            this.tabPageDF_IDF.Controls.Add(this.dataGridView1);
            this.tabPageDF_IDF.Controls.Add(this.label_Document);
            this.tabPageDF_IDF.Controls.Add(this.textBox_DocumentTitle);
            this.tabPageDF_IDF.Controls.Add(this.button_CalculateDFandIDF);
            this.tabPageDF_IDF.Controls.Add(this.label5);
            this.tabPageDF_IDF.Controls.Add(this.textBox_InverseDF);
            this.tabPageDF_IDF.Controls.Add(this.label3);
            this.tabPageDF_IDF.Controls.Add(this.textBox_DocumentFrequency);
            this.tabPageDF_IDF.Controls.Add(this.label2);
            this.tabPageDF_IDF.Controls.Add(this.label1);
            this.tabPageDF_IDF.Controls.Add(this.textBox_Term);
            this.tabPageDF_IDF.Location = new System.Drawing.Point(4, 22);
            this.tabPageDF_IDF.Name = "tabPageDF_IDF";
            this.tabPageDF_IDF.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageDF_IDF.Size = new System.Drawing.Size(758, 598);
            this.tabPageDF_IDF.TabIndex = 0;
            this.tabPageDF_IDF.Text = "DF&IDF";
            this.tabPageDF_IDF.UseVisualStyleBackColor = true;
            // 
            // button_CalculateDFandIDF
            // 
            this.button_CalculateDFandIDF.Enabled = false;
            this.button_CalculateDFandIDF.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.button_CalculateDFandIDF.Location = new System.Drawing.Point(478, 157);
            this.button_CalculateDFandIDF.Name = "button_CalculateDFandIDF";
            this.button_CalculateDFandIDF.Size = new System.Drawing.Size(273, 35);
            this.button_CalculateDFandIDF.TabIndex = 36;
            this.button_CalculateDFandIDF.Text = "Calculate DF and IDF";
            this.button_CalculateDFandIDF.UseVisualStyleBackColor = true;
            this.button_CalculateDFandIDF.MouseClick += new System.Windows.Forms.MouseEventHandler(this.button_CalculateDFandIDF_MouseClick);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.label5.Location = new System.Drawing.Point(6, 224);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(158, 29);
            this.label5.TabIndex = 33;
            this.label5.Text = "Document list";
            // 
            // textBox_InverseDF
            // 
            this.textBox_InverseDF.Cursor = System.Windows.Forms.Cursors.Default;
            this.textBox_InverseDF.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.textBox_InverseDF.Location = new System.Drawing.Point(366, 116);
            this.textBox_InverseDF.Name = "textBox_InverseDF";
            this.textBox_InverseDF.ReadOnly = true;
            this.textBox_InverseDF.Size = new System.Drawing.Size(387, 35);
            this.textBox_InverseDF.TabIndex = 31;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.label3.Location = new System.Drawing.Point(6, 3);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 29);
            this.label3.TabIndex = 30;
            this.label3.Text = "Term";
            // 
            // textBox_DocumentFrequency
            // 
            this.textBox_DocumentFrequency.Cursor = System.Windows.Forms.Cursors.Default;
            this.textBox_DocumentFrequency.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.textBox_DocumentFrequency.Location = new System.Drawing.Point(366, 33);
            this.textBox_DocumentFrequency.Name = "textBox_DocumentFrequency";
            this.textBox_DocumentFrequency.ReadOnly = true;
            this.textBox_DocumentFrequency.Size = new System.Drawing.Size(384, 35);
            this.textBox_DocumentFrequency.TabIndex = 29;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.label2.Location = new System.Drawing.Point(361, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(392, 29);
            this.label2.TabIndex = 28;
            this.label2.Text = "IDF ( Inverse Document Frequency)";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.label1.Location = new System.Drawing.Point(453, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(296, 29);
            this.label1.TabIndex = 26;
            this.label1.Text = "DF (Document Frequency)";
            // 
            // textBox_Term
            // 
            this.textBox_Term.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.textBox_Term.Location = new System.Drawing.Point(4, 33);
            this.textBox_Term.Name = "textBox_Term";
            this.textBox_Term.Size = new System.Drawing.Size(272, 35);
            this.textBox_Term.TabIndex = 25;
            this.textBox_Term.TextChanged += new System.EventHandler(this.textBox_Term_TextChanged);
            // 
            // tabLogicalView
            // 
            this.tabLogicalView.Location = new System.Drawing.Point(4, 22);
            this.tabLogicalView.Name = "tabLogicalView";
            this.tabLogicalView.Padding = new System.Windows.Forms.Padding(3);
            this.tabLogicalView.Size = new System.Drawing.Size(758, 598);
            this.tabLogicalView.TabIndex = 1;
            this.tabLogicalView.Text = "Logical views";
            this.tabLogicalView.UseVisualStyleBackColor = true;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.editToolStripMenuItem,
            this.viewToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(771, 24);
            this.menuStrip1.TabIndex = 7;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openFileToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // openFileToolStripMenuItem
            // 
            this.openFileToolStripMenuItem.Name = "openFileToolStripMenuItem";
            this.openFileToolStripMenuItem.Size = new System.Drawing.Size(131, 22);
            this.openFileToolStripMenuItem.Text = "Open file...";
            this.openFileToolStripMenuItem.Click += new System.EventHandler(this.openFileToolStripMenuItem_Click);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(39, 20);
            this.editToolStripMenuItem.Text = "Edit";
            // 
            // viewToolStripMenuItem
            // 
            this.viewToolStripMenuItem.Name = "viewToolStripMenuItem";
            this.viewToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.viewToolStripMenuItem.Text = "View";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.aboutToolStripMenuItem.Text = "About";
            // 
            // label_Document
            // 
            this.label_Document.AutoSize = true;
            this.label_Document.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.label_Document.Location = new System.Drawing.Point(6, 84);
            this.label_Document.Name = "label_Document";
            this.label_Document.Size = new System.Drawing.Size(166, 29);
            this.label_Document.TabIndex = 38;
            this.label_Document.Text = "Document title";
            // 
            // textBox_DocumentTitle
            // 
            this.textBox_DocumentTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.textBox_DocumentTitle.Location = new System.Drawing.Point(4, 114);
            this.textBox_DocumentTitle.Name = "textBox_DocumentTitle";
            this.textBox_DocumentTitle.Size = new System.Drawing.Size(272, 35);
            this.textBox_DocumentTitle.TabIndex = 37;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(11, 256);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(240, 150);
            this.dataGridView1.TabIndex = 39;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(771, 649);
            this.Controls.Add(this.tabControl);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Hw4: TF, DF, IDF";
            this.tabControl.ResumeLayout(false);
            this.tabPageDF_IDF.ResumeLayout(false);
            this.tabPageDF_IDF.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabPageDF_IDF;
        private System.Windows.Forms.TabPage tabLogicalView;
        private System.Windows.Forms.TextBox textBox_InverseDF;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox_DocumentFrequency;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox_Term;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openFileToolStripMenuItem;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button_CalculateDFandIDF;
        private System.Windows.Forms.Label label_Document;
        private System.Windows.Forms.TextBox textBox_DocumentTitle;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}

