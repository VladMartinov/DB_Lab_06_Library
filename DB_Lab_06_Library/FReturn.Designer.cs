namespace DB_Lab_06_Library
{
    partial class FReturn
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
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.readersListBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.libraryDataSet = new DB_Lab_06_Library.libraryDataSet();
            this.eXEMPLARBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.readers_ListTableAdapter = new DB_Lab_06_Library.libraryDataSetTableAdapters.Readers_ListTableAdapter();
            this.eXEMPLARTableAdapter = new DB_Lab_06_Library.libraryDataSetTableAdapters.EXEMPLARTableAdapter();
            this.tableAdapterManager = new DB_Lab_06_Library.libraryDataSetTableAdapters.TableAdapterManager();
            this.bOOKSTableAdapter = new DB_Lab_06_Library.libraryDataSetTableAdapters.BOOKSTableAdapter();
            this.eXEMPLARDataGridView = new System.Windows.Forms.DataGridView();
            this.bOOKSBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.buttonCancel = new System.Windows.Forms.Button();
            this.buttonOK = new System.Windows.Forms.Button();
            this.DataGridViewCheckBoxColumn1 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.readersListBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.libraryDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eXEMPLARBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eXEMPLARDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bOOKSBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Читатель:";
            // 
            // comboBox1
            // 
            this.comboBox1.DataSource = this.readersListBindingSource;
            this.comboBox1.DisplayMember = "READER";
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(87, 24);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(421, 21);
            this.comboBox1.TabIndex = 1;
            this.comboBox1.ValueMember = "READER_ID";
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // readersListBindingSource
            // 
            this.readersListBindingSource.DataMember = "Readers_List";
            this.readersListBindingSource.DataSource = this.libraryDataSet;
            // 
            // libraryDataSet
            // 
            this.libraryDataSet.DataSetName = "libraryDataSet";
            this.libraryDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // eXEMPLARBindingSource
            // 
            this.eXEMPLARBindingSource.DataMember = "EXEMPLAR";
            this.eXEMPLARBindingSource.DataSource = this.libraryDataSet;
            // 
            // readers_ListTableAdapter
            // 
            this.readers_ListTableAdapter.ClearBeforeFill = true;
            // 
            // eXEMPLARTableAdapter
            // 
            this.eXEMPLARTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.BOOKSTableAdapter = this.bOOKSTableAdapter;
            this.tableAdapterManager.CATALOGTableAdapter = null;
            this.tableAdapterManager.EXEMPLARTableAdapter = this.eXEMPLARTableAdapter;
            this.tableAdapterManager.READERSTableAdapter = null;
            this.tableAdapterManager.RELATION_1TableAdapter = null;
            this.tableAdapterManager.UpdateOrder = DB_Lab_06_Library.libraryDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // bOOKSTableAdapter
            // 
            this.bOOKSTableAdapter.ClearBeforeFill = true;
            // 
            // eXEMPLARDataGridView
            // 
            this.eXEMPLARDataGridView.AllowUserToAddRows = false;
            this.eXEMPLARDataGridView.AllowUserToDeleteRows = false;
            this.eXEMPLARDataGridView.AutoGenerateColumns = false;
            this.eXEMPLARDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.eXEMPLARDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.DataGridViewCheckBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5});
            this.eXEMPLARDataGridView.DataSource = this.eXEMPLARBindingSource;
            this.eXEMPLARDataGridView.Location = new System.Drawing.Point(15, 63);
            this.eXEMPLARDataGridView.Name = "eXEMPLARDataGridView";
            this.eXEMPLARDataGridView.Size = new System.Drawing.Size(711, 334);
            this.eXEMPLARDataGridView.TabIndex = 2;
            // 
            // bOOKSBindingSource
            // 
            this.bOOKSBindingSource.DataMember = "BOOKS";
            this.bOOKSBindingSource.DataSource = this.libraryDataSet;
            // 
            // buttonCancel
            // 
            this.buttonCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonCancel.Location = new System.Drawing.Point(651, 403);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(75, 25);
            this.buttonCancel.TabIndex = 4;
            this.buttonCancel.Text = "Отмена";
            this.buttonCancel.UseVisualStyleBackColor = true;
            // 
            // buttonOK
            // 
            this.buttonOK.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.buttonOK.Location = new System.Drawing.Point(545, 403);
            this.buttonOK.Name = "buttonOK";
            this.buttonOK.Size = new System.Drawing.Size(75, 25);
            this.buttonOK.TabIndex = 3;
            this.buttonOK.Text = "ОК";
            this.buttonOK.UseVisualStyleBackColor = true;
            // 
            // DataGridViewCheckBoxColumn1
            // 
            this.DataGridViewCheckBoxColumn1.DataPropertyName = "EXIST";
            this.DataGridViewCheckBoxColumn1.HeaderText = "Возврат";
            this.DataGridViewCheckBoxColumn1.Name = "DataGridViewCheckBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "ISBN";
            this.dataGridViewTextBoxColumn2.DataSource = this.bOOKSBindingSource;
            this.dataGridViewTextBoxColumn2.DisplayMember = "TITLE";
            this.dataGridViewTextBoxColumn2.HeaderText = "Книга";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewTextBoxColumn2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.dataGridViewTextBoxColumn2.ValueMember = "ISBN";
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "ID_EXEMPLAR";
            this.dataGridViewTextBoxColumn1.HeaderText = "Экземпляр";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "DATA_IN";
            this.dataGridViewTextBoxColumn4.HeaderText = "Дата выдачи";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "DATA_OUT";
            this.dataGridViewTextBoxColumn5.HeaderText = "Дата возврата";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            // 
            // FReturn
            // 
            this.AcceptButton = this.buttonOK;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.buttonCancel;
            this.ClientSize = new System.Drawing.Size(738, 434);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonOK);
            this.Controls.Add(this.eXEMPLARDataGridView);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label1);
            this.Name = "FReturn";
            this.Text = "FReturn";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FReturn_FormClosing);
            this.Load += new System.EventHandler(this.FReturn_Load);
            this.Shown += new System.EventHandler(this.FReturn_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.readersListBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.libraryDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eXEMPLARBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eXEMPLARDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bOOKSBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox1;
        private libraryDataSet libraryDataSet;
        private System.Windows.Forms.BindingSource readersListBindingSource;
        private libraryDataSetTableAdapters.Readers_ListTableAdapter readers_ListTableAdapter;
        private System.Windows.Forms.BindingSource eXEMPLARBindingSource;
        private libraryDataSetTableAdapters.EXEMPLARTableAdapter eXEMPLARTableAdapter;
        private libraryDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView eXEMPLARDataGridView;
        private libraryDataSetTableAdapters.BOOKSTableAdapter bOOKSTableAdapter;
        private System.Windows.Forms.BindingSource bOOKSBindingSource;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Button buttonOK;
        private System.Windows.Forms.DataGridViewCheckBoxColumn DataGridViewCheckBoxColumn1;
        private System.Windows.Forms.DataGridViewComboBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
    }
}