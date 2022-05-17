
namespace it_cursov.Формы
{
    partial class Zakazs
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
            this.label9 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.Procs = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MatPlatas = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Corpus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GraphicsCards = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RAMs = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.storageDevices = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PowerSupplies = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numberZakazDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.priceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.zakazBindingSource3 = new System.Windows.Forms.BindingSource(this.components);
            this.zakazBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.zakazBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.zakazBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.zakazBindingSource3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.zakazBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.zakazBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.zakazBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.numberZakazDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.Procs,
            this.MatPlatas,
            this.Corpus,
            this.GraphicsCards,
            this.RAMs,
            this.storageDevices,
            this.PowerSupplies,
            this.Column1,
            this.priceDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.zakazBindingSource3;
            this.dataGridView1.Location = new System.Drawing.Point(12, 42);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(745, 368);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.SystemColors.MenuBar;
            this.label9.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(12, 9);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(141, 21);
            this.label9.TabIndex = 9;
            this.label9.Text = "Список заказов";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(781, 119);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(87, 32);
            this.button1.TabIndex = 10;
            this.button1.Text = "Удалить";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(793, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 20);
            this.label2.TabIndex = 13;
            this.label2.Text = "Поиск:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(763, 65);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(121, 20);
            this.textBox2.TabIndex = 12;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // Procs
            // 
            this.Procs.DataPropertyName = "Procs";
            this.Procs.HeaderText = "Процессор";
            this.Procs.Name = "Procs";
            this.Procs.Width = 88;
            // 
            // MatPlatas
            // 
            this.MatPlatas.DataPropertyName = "MatPlatas";
            this.MatPlatas.HeaderText = "Материнская плата";
            this.MatPlatas.Name = "MatPlatas";
            this.MatPlatas.Width = 121;
            // 
            // Corpus
            // 
            this.Corpus.DataPropertyName = "Corpus";
            this.Corpus.HeaderText = "Корпус";
            this.Corpus.Name = "Corpus";
            this.Corpus.Width = 68;
            // 
            // GraphicsCards
            // 
            this.GraphicsCards.DataPropertyName = "GraphicsCards";
            this.GraphicsCards.HeaderText = "Видеокарта";
            this.GraphicsCards.Name = "GraphicsCards";
            this.GraphicsCards.Width = 92;
            // 
            // RAMs
            // 
            this.RAMs.DataPropertyName = "RAMs";
            this.RAMs.HeaderText = "ОЗУ";
            this.RAMs.Name = "RAMs";
            this.RAMs.Width = 55;
            // 
            // storageDevices
            // 
            this.storageDevices.DataPropertyName = "storageDevices";
            this.storageDevices.HeaderText = "Накопитель";
            this.storageDevices.Name = "storageDevices";
            this.storageDevices.Width = 93;
            // 
            // PowerSupplies
            // 
            this.PowerSupplies.DataPropertyName = "PowerSupplies";
            this.PowerSupplies.HeaderText = "Блок питания";
            this.PowerSupplies.Name = "PowerSupplies";
            this.PowerSupplies.Width = 93;
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "IdStore";
            this.Column1.HeaderText = "Магазин";
            this.Column1.Name = "Column1";
            this.Column1.Width = 76;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.Width = 41;
            // 
            // numberZakazDataGridViewTextBoxColumn
            // 
            this.numberZakazDataGridViewTextBoxColumn.DataPropertyName = "Number_Zakaz";
            this.numberZakazDataGridViewTextBoxColumn.HeaderText = "Номер заказа";
            this.numberZakazDataGridViewTextBoxColumn.Name = "numberZakazDataGridViewTextBoxColumn";
            this.numberZakazDataGridViewTextBoxColumn.Width = 96;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Наименование";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.Width = 108;
            // 
            // priceDataGridViewTextBoxColumn
            // 
            this.priceDataGridViewTextBoxColumn.DataPropertyName = "Price";
            this.priceDataGridViewTextBoxColumn.HeaderText = "Цена";
            this.priceDataGridViewTextBoxColumn.Name = "priceDataGridViewTextBoxColumn";
            this.priceDataGridViewTextBoxColumn.Width = 58;
            // 
            // zakazBindingSource3
            // 
            this.zakazBindingSource3.DataSource = typeof(it_cursov.Context.Zakaz);
            // 
            // zakazBindingSource2
            // 
            this.zakazBindingSource2.DataSource = typeof(it_cursov.Context.Zakaz);
            // 
            // zakazBindingSource1
            // 
            this.zakazBindingSource1.DataSource = typeof(it_cursov.Context.Zakaz);
            // 
            // zakazBindingSource
            // 
            this.zakazBindingSource.DataSource = typeof(it_cursov.Context.Zakaz);
            // 
            // Zakazs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(886, 415);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Zakazs";
            this.Text = "Заказы";
            this.Load += new System.EventHandler(this.Zakazs_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.zakazBindingSource3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.zakazBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.zakazBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.zakazBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.BindingSource zakazBindingSource;
        private System.Windows.Forms.BindingSource zakazBindingSource1;
        private System.Windows.Forms.BindingSource zakazBindingSource2;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn numberZakazDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Procs;
        private System.Windows.Forms.DataGridViewTextBoxColumn MatPlatas;
        private System.Windows.Forms.DataGridViewTextBoxColumn Corpus;
        private System.Windows.Forms.DataGridViewTextBoxColumn GraphicsCards;
        private System.Windows.Forms.DataGridViewTextBoxColumn RAMs;
        private System.Windows.Forms.DataGridViewTextBoxColumn storageDevices;
        private System.Windows.Forms.DataGridViewTextBoxColumn PowerSupplies;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn priceDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource zakazBindingSource3;
    }
}