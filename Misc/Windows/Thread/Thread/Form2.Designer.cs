namespace ThreadExample
{
    partial class Form2
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
            this.chkSelect = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.fFMWSWDataSet1 = new ThreadExample.FFMWSWDataSet1();
            this.mFHTSAFInfoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.mF_HTSAF_InfoTableAdapter = new ThreadExample.FFMWSWDataSet1TableAdapters.MF_HTSAF_InfoTableAdapter();
            this.hIGlobalIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hILoginDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hITypeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fFMWSWDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mFHTSAFInfoBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.chkSelect,
            this.hIGlobalIDDataGridViewTextBoxColumn,
            this.hILoginDataGridViewTextBoxColumn,
            this.hITypeDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.mFHTSAFInfoBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(57, 34);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(473, 153);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // chkSelect
            // 
            this.chkSelect.HeaderText = "";
            this.chkSelect.Name = "chkSelect";
            // 
            // fFMWSWDataSet1
            // 
            this.fFMWSWDataSet1.DataSetName = "FFMWSWDataSet1";
            this.fFMWSWDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // mFHTSAFInfoBindingSource
            // 
            this.mFHTSAFInfoBindingSource.DataMember = "MF_HTSAF_Info";
            this.mFHTSAFInfoBindingSource.DataSource = this.fFMWSWDataSet1;
            // 
            // mF_HTSAF_InfoTableAdapter
            // 
            this.mF_HTSAF_InfoTableAdapter.ClearBeforeFill = true;
            // 
            // hIGlobalIDDataGridViewTextBoxColumn
            // 
            this.hIGlobalIDDataGridViewTextBoxColumn.DataPropertyName = "HI_GlobalID";
            this.hIGlobalIDDataGridViewTextBoxColumn.HeaderText = "HI_GlobalID";
            this.hIGlobalIDDataGridViewTextBoxColumn.Name = "hIGlobalIDDataGridViewTextBoxColumn";
            // 
            // hILoginDataGridViewTextBoxColumn
            // 
            this.hILoginDataGridViewTextBoxColumn.DataPropertyName = "HI_Login";
            this.hILoginDataGridViewTextBoxColumn.HeaderText = "HI_Login";
            this.hILoginDataGridViewTextBoxColumn.Name = "hILoginDataGridViewTextBoxColumn";
            // 
            // hITypeDataGridViewTextBoxColumn
            // 
            this.hITypeDataGridViewTextBoxColumn.DataPropertyName = "HI_Type";
            this.hITypeDataGridViewTextBoxColumn.HeaderText = "HI_Type";
            this.hITypeDataGridViewTextBoxColumn.Name = "hITypeDataGridViewTextBoxColumn";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(554, 272);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fFMWSWDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mFHTSAFInfoBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewCheckBoxColumn chkSelect;
        private FFMWSWDataSet1 fFMWSWDataSet1;
        private System.Windows.Forms.BindingSource mFHTSAFInfoBindingSource;
        private ThreadExample.FFMWSWDataSet1TableAdapters.MF_HTSAF_InfoTableAdapter mF_HTSAF_InfoTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn hIGlobalIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn hILoginDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn hITypeDataGridViewTextBoxColumn;
    }
}