namespace Exportadados
{
    partial class Datatoexcel
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Export = new System.Windows.Forms.Button();
            this.rHDataSet = new Exportadados.RHDataSet();
            this.entrevistaDetalheBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.entrevistaDetalheTableAdapter = new Exportadados.RHDataSetTableAdapters.EntrevistaDetalheTableAdapter();
            this.nomeIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descrevaumpoucosobrevocêDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.digiteoqueseusexchefesdiriamsobrevocêDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.digiteoquevocêsabesobreanossaempresaenossaculturaorganizacionalDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.digiteoporquevocêdecidiusecandidataraestavagaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.digiteoqueseuscolegasdetrabalhodiriamsobrevocêDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.digitequaissãoosSeusPontosFortesefracosDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.digitesobresuaexperiênciacomoDevDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.digiteoporquevocêquersairousaiudaúltimaempresaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.candidatoDetalheBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.candidatoDetalheTableAdapter = new Exportadados.RHDataSetTableAdapters.CandidatoDetalheTableAdapter();
            this.candidatoIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.candidatoNomeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.candidatoIdadeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.candidatoEmailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.candidatoEnderecoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.candidatoTechIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vagaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.vagaTableAdapter = new Exportadados.RHDataSetTableAdapters.VagaTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rHDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.entrevistaDetalheBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.candidatoDetalheBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vagaBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nomeIDDataGridViewTextBoxColumn,
            this.descrevaumpoucosobrevocêDataGridViewTextBoxColumn,
            this.digiteoqueseusexchefesdiriamsobrevocêDataGridViewTextBoxColumn,
            this.digiteoquevocêsabesobreanossaempresaenossaculturaorganizacionalDataGridViewTextBoxColumn,
            this.digiteoporquevocêdecidiusecandidataraestavagaDataGridViewTextBoxColumn,
            this.digiteoqueseuscolegasdetrabalhodiriamsobrevocêDataGridViewTextBoxColumn,
            this.digitequaissãoosSeusPontosFortesefracosDataGridViewTextBoxColumn,
            this.digitesobresuaexperiênciacomoDevDataGridViewTextBoxColumn,
            this.digiteoporquevocêquersairousaiudaúltimaempresaDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.entrevistaDetalheBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(1, 1);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(949, 148);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // Export
            // 
            this.Export.Location = new System.Drawing.Point(863, 267);
            this.Export.Name = "Export";
            this.Export.Size = new System.Drawing.Size(87, 29);
            this.Export.TabIndex = 1;
            this.Export.Text = "&Export";
            this.Export.UseVisualStyleBackColor = true;
            this.Export.Click += new System.EventHandler(this.button1_Click);
            // 
            // rHDataSet
            // 
            this.rHDataSet.DataSetName = "RHDataSet";
            this.rHDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // entrevistaDetalheBindingSource
            // 
            this.entrevistaDetalheBindingSource.DataMember = "EntrevistaDetalhe";
            this.entrevistaDetalheBindingSource.DataSource = this.rHDataSet;
            // 
            // entrevistaDetalheTableAdapter
            // 
            this.entrevistaDetalheTableAdapter.ClearBeforeFill = true;
            // 
            // nomeIDDataGridViewTextBoxColumn
            // 
            this.nomeIDDataGridViewTextBoxColumn.DataPropertyName = "NomeID";
            this.nomeIDDataGridViewTextBoxColumn.HeaderText = "NomeID";
            this.nomeIDDataGridViewTextBoxColumn.Name = "nomeIDDataGridViewTextBoxColumn";
            this.nomeIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // descrevaumpoucosobrevocêDataGridViewTextBoxColumn
            // 
            this.descrevaumpoucosobrevocêDataGridViewTextBoxColumn.DataPropertyName = "Descrevaumpoucosobrevocê";
            this.descrevaumpoucosobrevocêDataGridViewTextBoxColumn.HeaderText = "Descrevaumpoucosobrevocê";
            this.descrevaumpoucosobrevocêDataGridViewTextBoxColumn.Name = "descrevaumpoucosobrevocêDataGridViewTextBoxColumn";
            // 
            // digiteoqueseusexchefesdiriamsobrevocêDataGridViewTextBoxColumn
            // 
            this.digiteoqueseusexchefesdiriamsobrevocêDataGridViewTextBoxColumn.DataPropertyName = "Digiteoqueseusexchefesdiriamsobrevocê";
            this.digiteoqueseusexchefesdiriamsobrevocêDataGridViewTextBoxColumn.HeaderText = "Digiteoqueseusexchefesdiriamsobrevocê";
            this.digiteoqueseusexchefesdiriamsobrevocêDataGridViewTextBoxColumn.Name = "digiteoqueseusexchefesdiriamsobrevocêDataGridViewTextBoxColumn";
            // 
            // digiteoquevocêsabesobreanossaempresaenossaculturaorganizacionalDataGridViewTextBoxColumn
            // 
            this.digiteoquevocêsabesobreanossaempresaenossaculturaorganizacionalDataGridViewTextBoxColumn.DataPropertyName = "Digiteoquevocêsabesobreanossaempresaenossaculturaorganizacional";
            this.digiteoquevocêsabesobreanossaempresaenossaculturaorganizacionalDataGridViewTextBoxColumn.HeaderText = "Digiteoquevocêsabesobreanossaempresaenossaculturaorganizacional";
            this.digiteoquevocêsabesobreanossaempresaenossaculturaorganizacionalDataGridViewTextBoxColumn.Name = "digiteoquevocêsabesobreanossaempresaenossaculturaorganizacionalDataGridViewTextBo" +
    "xColumn";
            // 
            // digiteoporquevocêdecidiusecandidataraestavagaDataGridViewTextBoxColumn
            // 
            this.digiteoporquevocêdecidiusecandidataraestavagaDataGridViewTextBoxColumn.DataPropertyName = "Digiteoporquevocêdecidiusecandidataraestavaga";
            this.digiteoporquevocêdecidiusecandidataraestavagaDataGridViewTextBoxColumn.HeaderText = "Digiteoporquevocêdecidiusecandidataraestavaga";
            this.digiteoporquevocêdecidiusecandidataraestavagaDataGridViewTextBoxColumn.Name = "digiteoporquevocêdecidiusecandidataraestavagaDataGridViewTextBoxColumn";
            // 
            // digiteoqueseuscolegasdetrabalhodiriamsobrevocêDataGridViewTextBoxColumn
            // 
            this.digiteoqueseuscolegasdetrabalhodiriamsobrevocêDataGridViewTextBoxColumn.DataPropertyName = "Digiteoqueseuscolegasdetrabalhodiriamsobrevocê";
            this.digiteoqueseuscolegasdetrabalhodiriamsobrevocêDataGridViewTextBoxColumn.HeaderText = "Digiteoqueseuscolegasdetrabalhodiriamsobrevocê";
            this.digiteoqueseuscolegasdetrabalhodiriamsobrevocêDataGridViewTextBoxColumn.Name = "digiteoqueseuscolegasdetrabalhodiriamsobrevocêDataGridViewTextBoxColumn";
            // 
            // digitequaissãoosSeusPontosFortesefracosDataGridViewTextBoxColumn
            // 
            this.digitequaissãoosSeusPontosFortesefracosDataGridViewTextBoxColumn.DataPropertyName = "Digitequaissãoos seus pontos fortesefracos";
            this.digitequaissãoosSeusPontosFortesefracosDataGridViewTextBoxColumn.HeaderText = "Digitequaissãoos seus pontos fortesefracos";
            this.digitequaissãoosSeusPontosFortesefracosDataGridViewTextBoxColumn.Name = "digitequaissãoosSeusPontosFortesefracosDataGridViewTextBoxColumn";
            // 
            // digitesobresuaexperiênciacomoDevDataGridViewTextBoxColumn
            // 
            this.digitesobresuaexperiênciacomoDevDataGridViewTextBoxColumn.DataPropertyName = "DigitesobresuaexperiênciacomoDev";
            this.digitesobresuaexperiênciacomoDevDataGridViewTextBoxColumn.HeaderText = "DigitesobresuaexperiênciacomoDev";
            this.digitesobresuaexperiênciacomoDevDataGridViewTextBoxColumn.Name = "digitesobresuaexperiênciacomoDevDataGridViewTextBoxColumn";
            // 
            // digiteoporquevocêquersairousaiudaúltimaempresaDataGridViewTextBoxColumn
            // 
            this.digiteoporquevocêquersairousaiudaúltimaempresaDataGridViewTextBoxColumn.DataPropertyName = "Digiteoporquevocêquersairousaiudaúltimaempresa";
            this.digiteoporquevocêquersairousaiudaúltimaempresaDataGridViewTextBoxColumn.HeaderText = "Digiteoporquevocêquersairousaiudaúltimaempresa";
            this.digiteoporquevocêquersairousaiudaúltimaempresaDataGridViewTextBoxColumn.Name = "digiteoporquevocêquersairousaiudaúltimaempresaDataGridViewTextBoxColumn";
            // 
            // dataGridView2
            // 
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.candidatoIDDataGridViewTextBoxColumn,
            this.candidatoNomeDataGridViewTextBoxColumn,
            this.candidatoIdadeDataGridViewTextBoxColumn,
            this.candidatoEmailDataGridViewTextBoxColumn,
            this.candidatoEnderecoDataGridViewTextBoxColumn,
            this.candidatoTechIDDataGridViewTextBoxColumn});
            this.dataGridView2.DataSource = this.candidatoDetalheBindingSource;
            this.dataGridView2.Location = new System.Drawing.Point(1, 185);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(646, 111);
            this.dataGridView2.TabIndex = 2;
            // 
            // candidatoDetalheBindingSource
            // 
            this.candidatoDetalheBindingSource.DataMember = "CandidatoDetalhe";
            this.candidatoDetalheBindingSource.DataSource = this.rHDataSet;
            // 
            // candidatoDetalheTableAdapter
            // 
            this.candidatoDetalheTableAdapter.ClearBeforeFill = true;
            // 
            // candidatoIDDataGridViewTextBoxColumn
            // 
            this.candidatoIDDataGridViewTextBoxColumn.DataPropertyName = "CandidatoID";
            this.candidatoIDDataGridViewTextBoxColumn.HeaderText = "CandidatoID";
            this.candidatoIDDataGridViewTextBoxColumn.Name = "candidatoIDDataGridViewTextBoxColumn";
            this.candidatoIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // candidatoNomeDataGridViewTextBoxColumn
            // 
            this.candidatoNomeDataGridViewTextBoxColumn.DataPropertyName = "CandidatoNome";
            this.candidatoNomeDataGridViewTextBoxColumn.HeaderText = "CandidatoNome";
            this.candidatoNomeDataGridViewTextBoxColumn.Name = "candidatoNomeDataGridViewTextBoxColumn";
            // 
            // candidatoIdadeDataGridViewTextBoxColumn
            // 
            this.candidatoIdadeDataGridViewTextBoxColumn.DataPropertyName = "CandidatoIdade";
            this.candidatoIdadeDataGridViewTextBoxColumn.HeaderText = "CandidatoIdade";
            this.candidatoIdadeDataGridViewTextBoxColumn.Name = "candidatoIdadeDataGridViewTextBoxColumn";
            // 
            // candidatoEmailDataGridViewTextBoxColumn
            // 
            this.candidatoEmailDataGridViewTextBoxColumn.DataPropertyName = "CandidatoEmail";
            this.candidatoEmailDataGridViewTextBoxColumn.HeaderText = "CandidatoEmail";
            this.candidatoEmailDataGridViewTextBoxColumn.Name = "candidatoEmailDataGridViewTextBoxColumn";
            // 
            // candidatoEnderecoDataGridViewTextBoxColumn
            // 
            this.candidatoEnderecoDataGridViewTextBoxColumn.DataPropertyName = "CandidatoEndereco";
            this.candidatoEnderecoDataGridViewTextBoxColumn.HeaderText = "CandidatoEndereco";
            this.candidatoEnderecoDataGridViewTextBoxColumn.Name = "candidatoEnderecoDataGridViewTextBoxColumn";
            // 
            // candidatoTechIDDataGridViewTextBoxColumn
            // 
            this.candidatoTechIDDataGridViewTextBoxColumn.DataPropertyName = "CandidatoTechID";
            this.candidatoTechIDDataGridViewTextBoxColumn.HeaderText = "CandidatoTechID";
            this.candidatoTechIDDataGridViewTextBoxColumn.Name = "candidatoTechIDDataGridViewTextBoxColumn";
            // 
            // vagaBindingSource
            // 
            this.vagaBindingSource.DataMember = "Vaga";
            this.vagaBindingSource.DataSource = this.rHDataSet;
            // 
            // vagaTableAdapter
            // 
            this.vagaTableAdapter.ClearBeforeFill = true;
            // 
            // Datatoexcel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(954, 301);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.Export);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Datatoexcel";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Datatoexcel_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rHDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.entrevistaDetalheBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.candidatoDetalheBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vagaBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button Export;
        private RHDataSet rHDataSet;
        private System.Windows.Forms.BindingSource entrevistaDetalheBindingSource;
        private RHDataSetTableAdapters.EntrevistaDetalheTableAdapter entrevistaDetalheTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomeIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descrevaumpoucosobrevocêDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn digiteoqueseusexchefesdiriamsobrevocêDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn digiteoquevocêsabesobreanossaempresaenossaculturaorganizacionalDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn digiteoporquevocêdecidiusecandidataraestavagaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn digiteoqueseuscolegasdetrabalhodiriamsobrevocêDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn digitequaissãoosSeusPontosFortesefracosDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn digitesobresuaexperiênciacomoDevDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn digiteoporquevocêquersairousaiudaúltimaempresaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.BindingSource candidatoDetalheBindingSource;
        private RHDataSetTableAdapters.CandidatoDetalheTableAdapter candidatoDetalheTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn candidatoIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn candidatoNomeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn candidatoIdadeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn candidatoEmailDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn candidatoEnderecoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn candidatoTechIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource vagaBindingSource;
        private RHDataSetTableAdapters.VagaTableAdapter vagaTableAdapter;
    }
}

