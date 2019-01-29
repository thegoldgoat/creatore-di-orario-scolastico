namespace creatore_di_orario_scolastico
{
    partial class Form1
    {
        /// <summary>
        /// Variabile di progettazione necessaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Pulire le risorse in uso.
        /// </summary>
        /// <param name="disposing">ha valore true se le risorse gestite devono essere eliminate, false in caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Codice generato da Progettazione Windows Form

        /// <summary>
        /// Metodo necessario per il supporto della finestra di progettazione. Non modificare
        /// il contenuto del metodo con l'editor di codice.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.orariBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.orarioBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.orario = new creatore_di_orario_scolastico.Orario();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.idClaPkDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.classiBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.idMatPkDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomeDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.materieBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridView4 = new System.Windows.Forms.DataGridView();
            this.idDocPkDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomeDataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cognomeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idMatDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.docentiBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.idOrPkDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.oraDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.giornoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idClaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idDocDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.orariBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.orarioBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.orario)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.classiBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.materieBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.docentiBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idOrPkDataGridViewTextBoxColumn,
            this.oraDataGridViewTextBoxColumn,
            this.giornoDataGridViewTextBoxColumn,
            this.idClaDataGridViewTextBoxColumn,
            this.idDocDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.orariBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(543, 462);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // orariBindingSource
            // 
            this.orariBindingSource.DataMember = "Orari";
            this.orariBindingSource.DataSource = this.orarioBindingSource;
            // 
            // orarioBindingSource
            // 
            this.orarioBindingSource.DataSource = this.orario;
            this.orarioBindingSource.Position = 0;
            // 
            // orario
            // 
            this.orario.DataSetName = "Orario";
            this.orario.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dataGridView2
            // 
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idClaPkDataGridViewTextBoxColumn,
            this.nomeDataGridViewTextBoxColumn});
            this.dataGridView2.DataSource = this.classiBindingSource;
            this.dataGridView2.Location = new System.Drawing.Point(561, 12);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(472, 150);
            this.dataGridView2.TabIndex = 1;
            // 
            // idClaPkDataGridViewTextBoxColumn
            // 
            this.idClaPkDataGridViewTextBoxColumn.DataPropertyName = "idClaPk";
            this.idClaPkDataGridViewTextBoxColumn.HeaderText = "idClaPk";
            this.idClaPkDataGridViewTextBoxColumn.Name = "idClaPkDataGridViewTextBoxColumn";
            // 
            // nomeDataGridViewTextBoxColumn
            // 
            this.nomeDataGridViewTextBoxColumn.DataPropertyName = "Nome";
            this.nomeDataGridViewTextBoxColumn.HeaderText = "Nome";
            this.nomeDataGridViewTextBoxColumn.Name = "nomeDataGridViewTextBoxColumn";
            // 
            // classiBindingSource
            // 
            this.classiBindingSource.DataMember = "Classi";
            this.classiBindingSource.DataSource = this.orarioBindingSource;
            // 
            // dataGridView3
            // 
            this.dataGridView3.AutoGenerateColumns = false;
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idMatPkDataGridViewTextBoxColumn,
            this.nomeDataGridViewTextBoxColumn1});
            this.dataGridView3.DataSource = this.materieBindingSource;
            this.dataGridView3.Location = new System.Drawing.Point(561, 168);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.Size = new System.Drawing.Size(472, 150);
            this.dataGridView3.TabIndex = 2;
            // 
            // idMatPkDataGridViewTextBoxColumn
            // 
            this.idMatPkDataGridViewTextBoxColumn.DataPropertyName = "idMatPk";
            this.idMatPkDataGridViewTextBoxColumn.HeaderText = "idMatPk";
            this.idMatPkDataGridViewTextBoxColumn.Name = "idMatPkDataGridViewTextBoxColumn";
            // 
            // nomeDataGridViewTextBoxColumn1
            // 
            this.nomeDataGridViewTextBoxColumn1.DataPropertyName = "Nome";
            this.nomeDataGridViewTextBoxColumn1.HeaderText = "Nome";
            this.nomeDataGridViewTextBoxColumn1.Name = "nomeDataGridViewTextBoxColumn1";
            // 
            // materieBindingSource
            // 
            this.materieBindingSource.DataMember = "Materie";
            this.materieBindingSource.DataSource = this.orarioBindingSource;
            // 
            // dataGridView4
            // 
            this.dataGridView4.AutoGenerateColumns = false;
            this.dataGridView4.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView4.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDocPkDataGridViewTextBoxColumn,
            this.nomeDataGridViewTextBoxColumn2,
            this.cognomeDataGridViewTextBoxColumn,
            this.idMatDataGridViewTextBoxColumn});
            this.dataGridView4.DataSource = this.docentiBindingSource;
            this.dataGridView4.Location = new System.Drawing.Point(561, 324);
            this.dataGridView4.Name = "dataGridView4";
            this.dataGridView4.Size = new System.Drawing.Size(472, 150);
            this.dataGridView4.TabIndex = 3;
            // 
            // idDocPkDataGridViewTextBoxColumn
            // 
            this.idDocPkDataGridViewTextBoxColumn.DataPropertyName = "idDocPk";
            this.idDocPkDataGridViewTextBoxColumn.HeaderText = "idDocPk";
            this.idDocPkDataGridViewTextBoxColumn.Name = "idDocPkDataGridViewTextBoxColumn";
            // 
            // nomeDataGridViewTextBoxColumn2
            // 
            this.nomeDataGridViewTextBoxColumn2.DataPropertyName = "Nome";
            this.nomeDataGridViewTextBoxColumn2.HeaderText = "Nome";
            this.nomeDataGridViewTextBoxColumn2.Name = "nomeDataGridViewTextBoxColumn2";
            // 
            // cognomeDataGridViewTextBoxColumn
            // 
            this.cognomeDataGridViewTextBoxColumn.DataPropertyName = "Cognome";
            this.cognomeDataGridViewTextBoxColumn.HeaderText = "Cognome";
            this.cognomeDataGridViewTextBoxColumn.Name = "cognomeDataGridViewTextBoxColumn";
            // 
            // idMatDataGridViewTextBoxColumn
            // 
            this.idMatDataGridViewTextBoxColumn.DataPropertyName = "idMat";
            this.idMatDataGridViewTextBoxColumn.HeaderText = "idMat";
            this.idMatDataGridViewTextBoxColumn.Name = "idMatDataGridViewTextBoxColumn";
            // 
            // docentiBindingSource
            // 
            this.docentiBindingSource.DataMember = "Docenti";
            this.docentiBindingSource.DataSource = this.orarioBindingSource;
            // 
            // idOrPkDataGridViewTextBoxColumn
            // 
            this.idOrPkDataGridViewTextBoxColumn.DataPropertyName = "idOrPk";
            this.idOrPkDataGridViewTextBoxColumn.HeaderText = "idOrPk";
            this.idOrPkDataGridViewTextBoxColumn.Name = "idOrPkDataGridViewTextBoxColumn";
            // 
            // oraDataGridViewTextBoxColumn
            // 
            this.oraDataGridViewTextBoxColumn.DataPropertyName = "Ora";
            this.oraDataGridViewTextBoxColumn.HeaderText = "Ora";
            this.oraDataGridViewTextBoxColumn.Name = "oraDataGridViewTextBoxColumn";
            // 
            // giornoDataGridViewTextBoxColumn
            // 
            this.giornoDataGridViewTextBoxColumn.DataPropertyName = "Giorno";
            this.giornoDataGridViewTextBoxColumn.HeaderText = "Giorno";
            this.giornoDataGridViewTextBoxColumn.Name = "giornoDataGridViewTextBoxColumn";
            // 
            // idClaDataGridViewTextBoxColumn
            // 
            this.idClaDataGridViewTextBoxColumn.DataPropertyName = "idCla";
            this.idClaDataGridViewTextBoxColumn.HeaderText = "idCla";
            this.idClaDataGridViewTextBoxColumn.Name = "idClaDataGridViewTextBoxColumn";
            // 
            // idDocDataGridViewTextBoxColumn
            // 
            this.idDocDataGridViewTextBoxColumn.DataPropertyName = "idDoc";
            this.idDocDataGridViewTextBoxColumn.HeaderText = "idDoc";
            this.idDocDataGridViewTextBoxColumn.Name = "idDocDataGridViewTextBoxColumn";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1045, 530);
            this.Controls.Add(this.dataGridView4);
            this.Controls.Add(this.dataGridView3);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.orariBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.orarioBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.orario)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.classiBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.materieBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.docentiBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource orariBindingSource;
        private System.Windows.Forms.BindingSource orarioBindingSource;
        private Orario orario;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridViewTextBoxColumn idClaPkDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomeDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource classiBindingSource;
        private System.Windows.Forms.DataGridView dataGridView3;
        private System.Windows.Forms.DataGridViewTextBoxColumn idMatPkDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomeDataGridViewTextBoxColumn1;
        private System.Windows.Forms.BindingSource materieBindingSource;
        private System.Windows.Forms.DataGridView dataGridView4;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDocPkDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomeDataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn cognomeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idMatDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource docentiBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn idOrPkDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn oraDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn giornoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idClaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDocDataGridViewTextBoxColumn;
    }
}

