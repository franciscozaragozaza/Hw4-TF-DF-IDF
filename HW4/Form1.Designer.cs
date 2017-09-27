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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabPageDF_IDF = new System.Windows.Forms.TabPage();
            this.docsDataGridView = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.titleDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.textDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.docsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dBDataSet = new HW4.DBDataSet();
            this.label_Document = new System.Windows.Forms.Label();
            this.textBox_DocumentTitle = new System.Windows.Forms.TextBox();
            this.button_CalculateTf = new System.Windows.Forms.Button();
            this.button_CalculateDFandIDF = new System.Windows.Forms.Button();
            this.textBox_InverseDF = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox1_TermFrequency = new System.Windows.Forms.TextBox();
            this.textBox_DocumentFrequency = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox_Term = new System.Windows.Forms.TextBox();
            this.tabLogicalView = new System.Windows.Forms.TabPage();
            this.termFreDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.termFreBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.termIdfDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.termIdfBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.queryResDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.queryResBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.docsTableAdapter = new HW4.DBDataSetTableAdapters.DocsTableAdapter();
            this.tableAdapterManager = new HW4.DBDataSetTableAdapters.TableAdapterManager();
            this.queryResTableAdapter = new HW4.DBDataSetTableAdapters.QueryResTableAdapter();
            this.termIdfTableAdapter = new HW4.DBDataSetTableAdapters.TermIdfTableAdapter();
            this.termFreTableAdapter = new HW4.DBDataSetTableAdapters.TermFreTableAdapter();
            this.tabControl.SuspendLayout();
            this.tabPageDF_IDF.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.docsDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.docsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dBDataSet)).BeginInit();
            this.tabLogicalView.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.termFreDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.termFreBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.termIdfDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.termIdfBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.queryResDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.queryResBindingSource)).BeginInit();
            this.menuStrip1.SuspendLayout();
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
            this.tabPageDF_IDF.AutoScroll = true;
            this.tabPageDF_IDF.Controls.Add(this.docsDataGridView);
            this.tabPageDF_IDF.Controls.Add(this.label_Document);
            this.tabPageDF_IDF.Controls.Add(this.textBox_DocumentTitle);
            this.tabPageDF_IDF.Controls.Add(this.button_CalculateTf);
            this.tabPageDF_IDF.Controls.Add(this.button_CalculateDFandIDF);
            this.tabPageDF_IDF.Controls.Add(this.textBox_InverseDF);
            this.tabPageDF_IDF.Controls.Add(this.label3);
            this.tabPageDF_IDF.Controls.Add(this.textBox1_TermFrequency);
            this.tabPageDF_IDF.Controls.Add(this.textBox_DocumentFrequency);
            this.tabPageDF_IDF.Controls.Add(this.label2);
            this.tabPageDF_IDF.Controls.Add(this.label4);
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
            // docsDataGridView
            // 
            this.docsDataGridView.AutoGenerateColumns = false;
            this.docsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.docsDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.titleDataGridViewTextBoxColumn,
            this.textDataGridViewTextBoxColumn});
            this.docsDataGridView.DataSource = this.docsBindingSource;
            this.docsDataGridView.Location = new System.Drawing.Point(4, 246);
            this.docsDataGridView.Name = "docsDataGridView";
            this.docsDataGridView.Size = new System.Drawing.Size(749, 344);
            this.docsDataGridView.TabIndex = 38;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            // 
            // titleDataGridViewTextBoxColumn
            // 
            this.titleDataGridViewTextBoxColumn.DataPropertyName = "Title";
            this.titleDataGridViewTextBoxColumn.HeaderText = "Title";
            this.titleDataGridViewTextBoxColumn.Name = "titleDataGridViewTextBoxColumn";
            this.titleDataGridViewTextBoxColumn.Width = 200;
            // 
            // textDataGridViewTextBoxColumn
            // 
            this.textDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.textDataGridViewTextBoxColumn.DataPropertyName = "Text";
            this.textDataGridViewTextBoxColumn.HeaderText = "Content";
            this.textDataGridViewTextBoxColumn.Name = "textDataGridViewTextBoxColumn";
            // 
            // docsBindingSource
            // 
            this.docsBindingSource.DataMember = "Docs";
            this.docsBindingSource.DataSource = this.dBDataSet;
            // 
            // dBDataSet
            // 
            this.dBDataSet.DataSetName = "DBDataSet";
            this.dBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            this.textBox_DocumentTitle.TextChanged += new System.EventHandler(this.textBox_DocumentTitle_TextChanged);
            // 
            // button_CalculateTf
            // 
            this.button_CalculateTf.Enabled = false;
            this.button_CalculateTf.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.button_CalculateTf.Location = new System.Drawing.Point(3, 205);
            this.button_CalculateTf.Name = "button_CalculateTf";
            this.button_CalculateTf.Size = new System.Drawing.Size(273, 35);
            this.button_CalculateTf.TabIndex = 36;
            this.button_CalculateTf.Text = "Calculate TF";
            this.button_CalculateTf.UseVisualStyleBackColor = true;
            this.button_CalculateTf.Click += new System.EventHandler(this.button_CalculateTf_Click);
            this.button_CalculateTf.MouseClick += new System.Windows.Forms.MouseEventHandler(this.button_CalculateDFandIDF_MouseClick);
            // 
            // button_CalculateDFandIDF
            // 
            this.button_CalculateDFandIDF.Enabled = false;
            this.button_CalculateDFandIDF.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.button_CalculateDFandIDF.Location = new System.Drawing.Point(3, 164);
            this.button_CalculateDFandIDF.Name = "button_CalculateDFandIDF";
            this.button_CalculateDFandIDF.Size = new System.Drawing.Size(273, 35);
            this.button_CalculateDFandIDF.TabIndex = 36;
            this.button_CalculateDFandIDF.Text = "Calculate DF and IDF";
            this.button_CalculateDFandIDF.UseVisualStyleBackColor = true;
            this.button_CalculateDFandIDF.MouseClick += new System.Windows.Forms.MouseEventHandler(this.button_CalculateDFandIDF_MouseClick);
            // 
            // textBox_InverseDF
            // 
            this.textBox_InverseDF.Cursor = System.Windows.Forms.Cursors.Default;
            this.textBox_InverseDF.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.textBox_InverseDF.Location = new System.Drawing.Point(366, 116);
            this.textBox_InverseDF.Name = "textBox_InverseDF";
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
            // textBox1_TermFrequency
            // 
            this.textBox1_TermFrequency.Cursor = System.Windows.Forms.Cursors.Default;
            this.textBox1_TermFrequency.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.textBox1_TermFrequency.Location = new System.Drawing.Point(370, 196);
            this.textBox1_TermFrequency.Name = "textBox1_TermFrequency";
            this.textBox1_TermFrequency.Size = new System.Drawing.Size(384, 35);
            this.textBox1_TermFrequency.TabIndex = 29;
            this.textBox1_TermFrequency.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // textBox_DocumentFrequency
            // 
            this.textBox_DocumentFrequency.Cursor = System.Windows.Forms.Cursors.Default;
            this.textBox_DocumentFrequency.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.textBox_DocumentFrequency.Location = new System.Drawing.Point(366, 33);
            this.textBox_DocumentFrequency.Name = "textBox_DocumentFrequency";
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
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.label4.Location = new System.Drawing.Point(511, 164);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(238, 29);
            this.label4.TabIndex = 26;
            this.label4.Text = "TF(Term Frequency)";
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
            this.tabLogicalView.AutoScroll = true;
            this.tabLogicalView.Controls.Add(this.termFreDataGridView);
            this.tabLogicalView.Controls.Add(this.termIdfDataGridView);
            this.tabLogicalView.Controls.Add(this.button1);
            this.tabLogicalView.Controls.Add(this.textBox1);
            this.tabLogicalView.Controls.Add(this.queryResDataGridView);
            this.tabLogicalView.Location = new System.Drawing.Point(4, 22);
            this.tabLogicalView.Name = "tabLogicalView";
            this.tabLogicalView.Padding = new System.Windows.Forms.Padding(3);
            this.tabLogicalView.Size = new System.Drawing.Size(758, 598);
            this.tabLogicalView.TabIndex = 1;
            this.tabLogicalView.Text = "Logical views";
            this.tabLogicalView.UseVisualStyleBackColor = true;
            // 
            // termFreDataGridView
            // 
            this.termFreDataGridView.AutoGenerateColumns = false;
            this.termFreDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.termFreDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7});
            this.termFreDataGridView.DataSource = this.termFreBindingSource;
            this.termFreDataGridView.Location = new System.Drawing.Point(328, 350);
            this.termFreDataGridView.Name = "termFreDataGridView";
            this.termFreDataGridView.Size = new System.Drawing.Size(423, 222);
            this.termFreDataGridView.TabIndex = 39;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Term";
            this.dataGridViewTextBoxColumn5.HeaderText = "Term";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "DocId";
            this.dataGridViewTextBoxColumn6.HeaderText = "DocId";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "TermFrequency";
            this.dataGridViewTextBoxColumn7.HeaderText = "TermFrequency";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            // 
            // termFreBindingSource
            // 
            this.termFreBindingSource.DataMember = "TermFre";
            this.termFreBindingSource.DataSource = this.dBDataSet;
            // 
            // termIdfDataGridView
            // 
            this.termIdfDataGridView.AutoGenerateColumns = false;
            this.termIdfDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.termIdfDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4});
            this.termIdfDataGridView.DataSource = this.termIdfBindingSource;
            this.termIdfDataGridView.Location = new System.Drawing.Point(6, 350);
            this.termIdfDataGridView.Name = "termIdfDataGridView";
            this.termIdfDataGridView.Size = new System.Drawing.Size(316, 222);
            this.termIdfDataGridView.TabIndex = 39;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Term";
            this.dataGridViewTextBoxColumn3.HeaderText = "Term";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "idf";
            this.dataGridViewTextBoxColumn4.HeaderText = "idf";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // termIdfBindingSource
            // 
            this.termIdfBindingSource.DataMember = "TermIdf";
            this.termIdfBindingSource.DataSource = this.dBDataSet;
            // 
            // button1
            // 
            this.button1.Enabled = false;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.button1.Location = new System.Drawing.Point(478, 6);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(273, 35);
            this.button1.TabIndex = 39;
            this.button1.Text = "Search";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.textBox1.Location = new System.Drawing.Point(6, 6);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(466, 35);
            this.textBox1.TabIndex = 37;
            // 
            // queryResDataGridView
            // 
            this.queryResDataGridView.AutoGenerateColumns = false;
            this.queryResDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.queryResDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2});
            this.queryResDataGridView.DataSource = this.queryResBindingSource;
            this.queryResDataGridView.Location = new System.Drawing.Point(6, 47);
            this.queryResDataGridView.Name = "queryResDataGridView";
            this.queryResDataGridView.Size = new System.Drawing.Size(745, 297);
            this.queryResDataGridView.TabIndex = 0;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "DocId";
            this.dataGridViewTextBoxColumn1.HeaderText = "DocId";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Similarity";
            this.dataGridViewTextBoxColumn2.HeaderText = "Similarity";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // queryResBindingSource
            // 
            this.queryResBindingSource.DataMember = "QueryRes";
            this.queryResBindingSource.DataSource = this.dBDataSet;
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
            // docsTableAdapter
            // 
            this.docsTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.DocsTableAdapter = this.docsTableAdapter;
            this.tableAdapterManager.QueryResTableAdapter = null;
            this.tableAdapterManager.TermFreTableAdapter = null;
            this.tableAdapterManager.TermIdfTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = HW4.DBDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // queryResTableAdapter
            // 
            this.queryResTableAdapter.ClearBeforeFill = true;
            // 
            // termIdfTableAdapter
            // 
            this.termIdfTableAdapter.ClearBeforeFill = true;
            // 
            // termFreTableAdapter
            // 
            this.termFreTableAdapter.ClearBeforeFill = true;
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
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl.ResumeLayout(false);
            this.tabPageDF_IDF.ResumeLayout(false);
            this.tabPageDF_IDF.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.docsDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.docsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dBDataSet)).EndInit();
            this.tabLogicalView.ResumeLayout(false);
            this.tabLogicalView.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.termFreDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.termFreBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.termIdfDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.termIdfBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.queryResDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.queryResBindingSource)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
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
        private System.Windows.Forms.Button button_CalculateDFandIDF;
        private System.Windows.Forms.Label label_Document;
        private System.Windows.Forms.TextBox textBox_DocumentTitle;
        private System.Windows.Forms.TextBox textBox1_TermFrequency;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button_CalculateTf;
        private DBDataSet dBDataSet;
        private System.Windows.Forms.BindingSource docsBindingSource;
        private DBDataSetTableAdapters.DocsTableAdapter docsTableAdapter;
        private DBDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView docsDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn titleDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn textDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource queryResBindingSource;
        private DBDataSetTableAdapters.QueryResTableAdapter queryResTableAdapter;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.DataGridView queryResDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.BindingSource termIdfBindingSource;
        private DBDataSetTableAdapters.TermIdfTableAdapter termIdfTableAdapter;
        private System.Windows.Forms.DataGridView termIdfDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.BindingSource termFreBindingSource;
        private DBDataSetTableAdapters.TermFreTableAdapter termFreTableAdapter;
        private System.Windows.Forms.DataGridView termFreDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
    }
}

