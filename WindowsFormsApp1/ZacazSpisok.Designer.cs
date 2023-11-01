namespace WindowsFormsApp1
{
    partial class ZacazSpisok
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
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this._база_данных_курсача_ауф_DataSet = new WindowsFormsApp1._база_данных_курсача_ауф_DataSet();
            this.zACAZBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.zACAZTableAdapter = new WindowsFormsApp1._база_данных_курсача_ауф_DataSetTableAdapters.ZACAZTableAdapter();
            this.nomerZakazaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kodKlientaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.seriaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kolDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sPriseDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.priseDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kodSotrudnikaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dostavkaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._база_данных_курсача_ауф_DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.zACAZBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nomerZakazaDataGridViewTextBoxColumn,
            this.kodKlientaDataGridViewTextBoxColumn,
            this.seriaDataGridViewTextBoxColumn,
            this.kolDataGridViewTextBoxColumn,
            this.sPriseDataGridViewTextBoxColumn,
            this.priseDataGridViewTextBoxColumn,
            this.kodSotrudnikaDataGridViewTextBoxColumn,
            this.dostavkaDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.zACAZBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(172, 37);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(576, 353);
            this.dataGridView1.TabIndex = 0;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.DarkGray;
            this.button2.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button2.Location = new System.Drawing.Point(16, 68);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(117, 67);
            this.button2.TabIndex = 69;
            this.button2.Text = "Изменить заказ";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.DarkGray;
            this.button1.DialogResult = System.Windows.Forms.DialogResult.No;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(16, 153);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(117, 67);
            this.button1.TabIndex = 68;
            this.button1.Text = "Удалить";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(151, 24);
            this.label1.TabIndex = 66;
            this.label1.Text = "Список заказов";
            // 
            // _база_данных_курсача_ауф_DataSet
            // 
            this._база_данных_курсача_ауф_DataSet.DataSetName = "_база_данных_курсача_ауф_DataSet";
            this._база_данных_курсача_ауф_DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // zACAZBindingSource
            // 
            this.zACAZBindingSource.DataMember = "ZACAZ";
            this.zACAZBindingSource.DataSource = this._база_данных_курсача_ауф_DataSet;
            // 
            // zACAZTableAdapter
            // 
            this.zACAZTableAdapter.ClearBeforeFill = true;
            // 
            // nomerZakazaDataGridViewTextBoxColumn
            // 
            this.nomerZakazaDataGridViewTextBoxColumn.DataPropertyName = "NomerZakaza";
            this.nomerZakazaDataGridViewTextBoxColumn.HeaderText = "NomerZakaza";
            this.nomerZakazaDataGridViewTextBoxColumn.Name = "nomerZakazaDataGridViewTextBoxColumn";
            // 
            // kodKlientaDataGridViewTextBoxColumn
            // 
            this.kodKlientaDataGridViewTextBoxColumn.DataPropertyName = "KodKlienta";
            this.kodKlientaDataGridViewTextBoxColumn.HeaderText = "KodKlienta";
            this.kodKlientaDataGridViewTextBoxColumn.Name = "kodKlientaDataGridViewTextBoxColumn";
            // 
            // seriaDataGridViewTextBoxColumn
            // 
            this.seriaDataGridViewTextBoxColumn.DataPropertyName = "Seria";
            this.seriaDataGridViewTextBoxColumn.HeaderText = "Seria";
            this.seriaDataGridViewTextBoxColumn.Name = "seriaDataGridViewTextBoxColumn";
            // 
            // kolDataGridViewTextBoxColumn
            // 
            this.kolDataGridViewTextBoxColumn.DataPropertyName = "Kol";
            this.kolDataGridViewTextBoxColumn.HeaderText = "Kol";
            this.kolDataGridViewTextBoxColumn.Name = "kolDataGridViewTextBoxColumn";
            // 
            // sPriseDataGridViewTextBoxColumn
            // 
            this.sPriseDataGridViewTextBoxColumn.DataPropertyName = "SPrise";
            this.sPriseDataGridViewTextBoxColumn.HeaderText = "SPrise";
            this.sPriseDataGridViewTextBoxColumn.Name = "sPriseDataGridViewTextBoxColumn";
            // 
            // priseDataGridViewTextBoxColumn
            // 
            this.priseDataGridViewTextBoxColumn.DataPropertyName = "Prise";
            this.priseDataGridViewTextBoxColumn.HeaderText = "Prise";
            this.priseDataGridViewTextBoxColumn.Name = "priseDataGridViewTextBoxColumn";
            // 
            // kodSotrudnikaDataGridViewTextBoxColumn
            // 
            this.kodSotrudnikaDataGridViewTextBoxColumn.DataPropertyName = "KodSotrudnika";
            this.kodSotrudnikaDataGridViewTextBoxColumn.HeaderText = "KodSotrudnika";
            this.kodSotrudnikaDataGridViewTextBoxColumn.Name = "kodSotrudnikaDataGridViewTextBoxColumn";
            // 
            // dostavkaDataGridViewTextBoxColumn
            // 
            this.dostavkaDataGridViewTextBoxColumn.DataPropertyName = "Dostavka";
            this.dostavkaDataGridViewTextBoxColumn.HeaderText = "Dostavka";
            this.dostavkaDataGridViewTextBoxColumn.Name = "dostavkaDataGridViewTextBoxColumn";
            // 
            // ZacazSpisok
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "ZacazSpisok";
            this.Text = "ZacazSpisok";
            this.Load += new System.EventHandler(this.ZacazSpisok_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._база_данных_курсача_ауф_DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.zACAZBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        public System.Windows.Forms.Label label1;
        private _база_данных_курсача_ауф_DataSet _база_данных_курсача_ауф_DataSet;
        private System.Windows.Forms.BindingSource zACAZBindingSource;
        private _база_данных_курсача_ауф_DataSetTableAdapters.ZACAZTableAdapter zACAZTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomerZakazaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kodKlientaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn seriaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kolDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sPriseDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn priseDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kodSotrudnikaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dostavkaDataGridViewTextBoxColumn;
    }
}