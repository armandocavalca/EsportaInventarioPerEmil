namespace EsportaInventarioPerEmil
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
            this.dgv1 = new System.Windows.Forms.DataGridView();
            this.Btn_export = new System.Windows.Forms.Button();
            this.btn_exit = new System.Windows.Forms.Button();
            this.mSARTIDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mSDSARDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mSLUNGDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mSLARGDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mSSPESDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mSUNMIDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mSNFOGDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mSMTCUDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mSVALMDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mSVALODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aRPOSIDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mAGINVPCBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet1 = new EsportaInventarioPerEmil.DataSet1();
            this.mAGINVPCTableAdapter = new EsportaInventarioPerEmil.DataSet1TableAdapters.MAGINVPCTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dgv1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mAGINVPCBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv1
            // 
            this.dgv1.AllowUserToAddRows = false;
            this.dgv1.AllowUserToDeleteRows = false;
            this.dgv1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv1.AutoGenerateColumns = false;
            this.dgv1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.mSARTIDataGridViewTextBoxColumn,
            this.mSDSARDataGridViewTextBoxColumn,
            this.mSLUNGDataGridViewTextBoxColumn,
            this.mSLARGDataGridViewTextBoxColumn,
            this.mSSPESDataGridViewTextBoxColumn,
            this.mSUNMIDataGridViewTextBoxColumn,
            this.mSNFOGDataGridViewTextBoxColumn,
            this.mSMTCUDataGridViewTextBoxColumn,
            this.mSVALMDataGridViewTextBoxColumn,
            this.mSVALODataGridViewTextBoxColumn,
            this.aRPOSIDataGridViewTextBoxColumn});
            this.dgv1.DataSource = this.mAGINVPCBindingSource;
            this.dgv1.Location = new System.Drawing.Point(12, 12);
            this.dgv1.Name = "dgv1";
            this.dgv1.ReadOnly = true;
            this.dgv1.RowHeadersWidth = 51;
            this.dgv1.RowTemplate.Height = 24;
            this.dgv1.Size = new System.Drawing.Size(992, 375);
            this.dgv1.TabIndex = 0;
            // 
            // Btn_export
            // 
            this.Btn_export.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.Btn_export.Location = new System.Drawing.Point(12, 393);
            this.Btn_export.Name = "Btn_export";
            this.Btn_export.Size = new System.Drawing.Size(268, 45);
            this.Btn_export.TabIndex = 1;
            this.Btn_export.Text = "Esporta in Excel";
            this.Btn_export.UseVisualStyleBackColor = true;
            this.Btn_export.Click += new System.EventHandler(this.Btn_export_Click);
            // 
            // btn_exit
            // 
            this.btn_exit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_exit.Location = new System.Drawing.Point(736, 393);
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.Size = new System.Drawing.Size(268, 45);
            this.btn_exit.TabIndex = 2;
            this.btn_exit.Text = "Uscita";
            this.btn_exit.UseVisualStyleBackColor = true;
            this.btn_exit.Click += new System.EventHandler(this.btn_exit_Click);
            // 
            // mSARTIDataGridViewTextBoxColumn
            // 
            this.mSARTIDataGridViewTextBoxColumn.DataPropertyName = "MSARTI";
            this.mSARTIDataGridViewTextBoxColumn.HeaderText = "MSARTI";
            this.mSARTIDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.mSARTIDataGridViewTextBoxColumn.Name = "mSARTIDataGridViewTextBoxColumn";
            this.mSARTIDataGridViewTextBoxColumn.ReadOnly = true;
            this.mSARTIDataGridViewTextBoxColumn.Width = 125;
            // 
            // mSDSARDataGridViewTextBoxColumn
            // 
            this.mSDSARDataGridViewTextBoxColumn.DataPropertyName = "MSDSAR";
            this.mSDSARDataGridViewTextBoxColumn.HeaderText = "MSDSAR";
            this.mSDSARDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.mSDSARDataGridViewTextBoxColumn.Name = "mSDSARDataGridViewTextBoxColumn";
            this.mSDSARDataGridViewTextBoxColumn.ReadOnly = true;
            this.mSDSARDataGridViewTextBoxColumn.Width = 125;
            // 
            // mSLUNGDataGridViewTextBoxColumn
            // 
            this.mSLUNGDataGridViewTextBoxColumn.DataPropertyName = "MSLUNG";
            this.mSLUNGDataGridViewTextBoxColumn.HeaderText = "MSLUNG";
            this.mSLUNGDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.mSLUNGDataGridViewTextBoxColumn.Name = "mSLUNGDataGridViewTextBoxColumn";
            this.mSLUNGDataGridViewTextBoxColumn.ReadOnly = true;
            this.mSLUNGDataGridViewTextBoxColumn.Width = 125;
            // 
            // mSLARGDataGridViewTextBoxColumn
            // 
            this.mSLARGDataGridViewTextBoxColumn.DataPropertyName = "MSLARG";
            this.mSLARGDataGridViewTextBoxColumn.HeaderText = "MSLARG";
            this.mSLARGDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.mSLARGDataGridViewTextBoxColumn.Name = "mSLARGDataGridViewTextBoxColumn";
            this.mSLARGDataGridViewTextBoxColumn.ReadOnly = true;
            this.mSLARGDataGridViewTextBoxColumn.Width = 125;
            // 
            // mSSPESDataGridViewTextBoxColumn
            // 
            this.mSSPESDataGridViewTextBoxColumn.DataPropertyName = "MSSPES";
            this.mSSPESDataGridViewTextBoxColumn.HeaderText = "MSSPES";
            this.mSSPESDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.mSSPESDataGridViewTextBoxColumn.Name = "mSSPESDataGridViewTextBoxColumn";
            this.mSSPESDataGridViewTextBoxColumn.ReadOnly = true;
            this.mSSPESDataGridViewTextBoxColumn.Width = 125;
            // 
            // mSUNMIDataGridViewTextBoxColumn
            // 
            this.mSUNMIDataGridViewTextBoxColumn.DataPropertyName = "MSUNMI";
            this.mSUNMIDataGridViewTextBoxColumn.HeaderText = "MSUNMI";
            this.mSUNMIDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.mSUNMIDataGridViewTextBoxColumn.Name = "mSUNMIDataGridViewTextBoxColumn";
            this.mSUNMIDataGridViewTextBoxColumn.ReadOnly = true;
            this.mSUNMIDataGridViewTextBoxColumn.Width = 125;
            // 
            // mSNFOGDataGridViewTextBoxColumn
            // 
            this.mSNFOGDataGridViewTextBoxColumn.DataPropertyName = "MSNFOG";
            this.mSNFOGDataGridViewTextBoxColumn.HeaderText = "MSNFOG";
            this.mSNFOGDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.mSNFOGDataGridViewTextBoxColumn.Name = "mSNFOGDataGridViewTextBoxColumn";
            this.mSNFOGDataGridViewTextBoxColumn.ReadOnly = true;
            this.mSNFOGDataGridViewTextBoxColumn.Width = 125;
            // 
            // mSMTCUDataGridViewTextBoxColumn
            // 
            this.mSMTCUDataGridViewTextBoxColumn.DataPropertyName = "MSMTCU";
            this.mSMTCUDataGridViewTextBoxColumn.HeaderText = "MSMTCU";
            this.mSMTCUDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.mSMTCUDataGridViewTextBoxColumn.Name = "mSMTCUDataGridViewTextBoxColumn";
            this.mSMTCUDataGridViewTextBoxColumn.ReadOnly = true;
            this.mSMTCUDataGridViewTextBoxColumn.Width = 125;
            // 
            // mSVALMDataGridViewTextBoxColumn
            // 
            this.mSVALMDataGridViewTextBoxColumn.DataPropertyName = "MSVALM";
            this.mSVALMDataGridViewTextBoxColumn.HeaderText = "MSVALM";
            this.mSVALMDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.mSVALMDataGridViewTextBoxColumn.Name = "mSVALMDataGridViewTextBoxColumn";
            this.mSVALMDataGridViewTextBoxColumn.ReadOnly = true;
            this.mSVALMDataGridViewTextBoxColumn.Width = 125;
            // 
            // mSVALODataGridViewTextBoxColumn
            // 
            this.mSVALODataGridViewTextBoxColumn.DataPropertyName = "MSVALO";
            this.mSVALODataGridViewTextBoxColumn.HeaderText = "MSVALO";
            this.mSVALODataGridViewTextBoxColumn.MinimumWidth = 6;
            this.mSVALODataGridViewTextBoxColumn.Name = "mSVALODataGridViewTextBoxColumn";
            this.mSVALODataGridViewTextBoxColumn.ReadOnly = true;
            this.mSVALODataGridViewTextBoxColumn.Width = 125;
            // 
            // aRPOSIDataGridViewTextBoxColumn
            // 
            this.aRPOSIDataGridViewTextBoxColumn.DataPropertyName = "ARPOSI";
            this.aRPOSIDataGridViewTextBoxColumn.HeaderText = "ARPOSI";
            this.aRPOSIDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.aRPOSIDataGridViewTextBoxColumn.Name = "aRPOSIDataGridViewTextBoxColumn";
            this.aRPOSIDataGridViewTextBoxColumn.ReadOnly = true;
            this.aRPOSIDataGridViewTextBoxColumn.Width = 125;
            // 
            // mAGINVPCBindingSource
            // 
            this.mAGINVPCBindingSource.DataMember = "MAGINVPC";
            this.mAGINVPCBindingSource.DataSource = this.dataSet1;
            // 
            // dataSet1
            // 
            this.dataSet1.DataSetName = "DataSet1";
            this.dataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // mAGINVPCTableAdapter
            // 
            this.mAGINVPCTableAdapter.ClearBeforeFill = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1016, 450);
            this.Controls.Add(this.btn_exit);
            this.Controls.Add(this.Btn_export);
            this.Controls.Add(this.dgv1);
            this.Name = "Form1";
            this.Text = "Esporta Inventario";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mAGINVPCBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv1;
        private System.Windows.Forms.Button Btn_export;
        private System.Windows.Forms.Button btn_exit;
        private DataSet1 dataSet1;
        private System.Windows.Forms.BindingSource mAGINVPCBindingSource;
        private DataSet1TableAdapters.MAGINVPCTableAdapter mAGINVPCTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn mSARTIDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mSDSARDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mSLUNGDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mSLARGDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mSSPESDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mSUNMIDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mSNFOGDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mSMTCUDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mSVALMDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mSVALODataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn aRPOSIDataGridViewTextBoxColumn;
    }
}

