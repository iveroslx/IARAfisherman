namespace IARAfisherman.View
{
    partial class MainView
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
            this.btn_insert = new System.Windows.Forms.Button();
            this.btnWIP = new System.Windows.Forms.Button();
            this.txtbxShipName = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.lbl_insguide = new System.Windows.Forms.Label();
            this.fmanDBDataSet1 = new IARAfisherman.FmanDBDataSet();
            this.dgvShip = new System.Windows.Forms.DataGridView();
            this.shipname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.expirydate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.santaMariaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mamaTiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.deebaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataTable1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.fmanDBDataSet1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dtpPermitEnds = new System.Windows.Forms.DateTimePicker();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            ((System.ComponentModel.ISupportInitialize)(this.fmanDBDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvShip)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTable1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fmanDBDataSet1BindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_insert
            // 
            this.btn_insert.Location = new System.Drawing.Point(12, 60);
            this.btn_insert.Name = "btn_insert";
            this.btn_insert.Size = new System.Drawing.Size(114, 26);
            this.btn_insert.TabIndex = 0;
            this.btn_insert.Text = "insert ship";
            this.btn_insert.UseVisualStyleBackColor = true;
            this.btn_insert.Click += new System.EventHandler(this.btn_insert_Click);
            // 
            // btnWIP
            // 
            this.btnWIP.Location = new System.Drawing.Point(266, 195);
            this.btnWIP.Name = "btnWIP";
            this.btnWIP.Size = new System.Drawing.Size(118, 63);
            this.btnWIP.TabIndex = 2;
            this.btnWIP.Text = "project work in progress";
            this.btnWIP.UseVisualStyleBackColor = true;
            // 
            // txtbxShipName
            // 
            this.txtbxShipName.Location = new System.Drawing.Point(12, 28);
            this.txtbxShipName.Multiline = true;
            this.txtbxShipName.Name = "txtbxShipName";
            this.txtbxShipName.Size = new System.Drawing.Size(114, 26);
            this.txtbxShipName.TabIndex = 3;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(301, 368);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(118, 20);
            this.textBox2.TabIndex = 4;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // lbl_insguide
            // 
            this.lbl_insguide.AutoSize = true;
            this.lbl_insguide.Location = new System.Drawing.Point(9, 9);
            this.lbl_insguide.Name = "lbl_insguide";
            this.lbl_insguide.Size = new System.Drawing.Size(193, 13);
            this.lbl_insguide.TabIndex = 5;
            this.lbl_insguide.Text = "Insert a ship name here and select date";
            this.lbl_insguide.Click += new System.EventHandler(this.label1_Click);
            // 
            // fmanDBDataSet1
            // 
            this.fmanDBDataSet1.DataSetName = "FmanDBDataSet";
            this.fmanDBDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dgvShip
            // 
            this.dgvShip.AutoGenerateColumns = false;
            this.dgvShip.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvShip.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.shipname,
            this.expirydate,
            this.santaMariaDataGridViewTextBoxColumn,
            this.mamaTiDataGridViewTextBoxColumn,
            this.deebaDataGridViewTextBoxColumn});
            this.dgvShip.DataSource = this.dataTable1BindingSource;
            this.dgvShip.Location = new System.Drawing.Point(338, 9);
            this.dgvShip.Name = "dgvShip";
            this.dgvShip.Size = new System.Drawing.Size(248, 110);
            this.dgvShip.TabIndex = 6;
            this.dgvShip.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvShip_CellContentClick);
            // 
            // shipname
            // 
            this.shipname.HeaderText = "ship name";
            this.shipname.Name = "shipname";
            this.shipname.Width = 105;
            // 
            // expirydate
            // 
            this.expirydate.HeaderText = "expiry date";
            this.expirydate.Name = "expirydate";
            // 
            // santaMariaDataGridViewTextBoxColumn
            // 
            this.santaMariaDataGridViewTextBoxColumn.DataPropertyName = "santa maria";
            this.santaMariaDataGridViewTextBoxColumn.HeaderText = "santa maria";
            this.santaMariaDataGridViewTextBoxColumn.Name = "santaMariaDataGridViewTextBoxColumn";
            // 
            // mamaTiDataGridViewTextBoxColumn
            // 
            this.mamaTiDataGridViewTextBoxColumn.DataPropertyName = "mama ti";
            this.mamaTiDataGridViewTextBoxColumn.HeaderText = "mama ti";
            this.mamaTiDataGridViewTextBoxColumn.Name = "mamaTiDataGridViewTextBoxColumn";
            // 
            // deebaDataGridViewTextBoxColumn
            // 
            this.deebaDataGridViewTextBoxColumn.DataPropertyName = "deeba";
            this.deebaDataGridViewTextBoxColumn.HeaderText = "deeba";
            this.deebaDataGridViewTextBoxColumn.Name = "deebaDataGridViewTextBoxColumn";
            // 
            // dataTable1BindingSource
            // 
            this.dataTable1BindingSource.DataMember = "DataTable1";
            this.dataTable1BindingSource.DataSource = this.fmanDBDataSet1BindingSource;
            // 
            // fmanDBDataSet1BindingSource
            // 
            this.fmanDBDataSet1BindingSource.DataSource = this.fmanDBDataSet1;
            this.fmanDBDataSet1BindingSource.Position = 0;
            // 
            // dtpPermitEnds
            // 
            this.dtpPermitEnds.Location = new System.Drawing.Point(132, 60);
            this.dtpPermitEnds.Name = "dtpPermitEnds";
            this.dtpPermitEnds.Size = new System.Drawing.Size(200, 20);
            this.dtpPermitEnds.TabIndex = 7;
            // 
            // MainView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dtpPermitEnds);
            this.Controls.Add(this.dgvShip);
            this.Controls.Add(this.lbl_insguide);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.txtbxShipName);
            this.Controls.Add(this.btnWIP);
            this.Controls.Add(this.btn_insert);
            this.Name = "MainView";
            this.Text = "Form";
            ((System.ComponentModel.ISupportInitialize)(this.fmanDBDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvShip)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTable1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fmanDBDataSet1BindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_insert;
        private System.Windows.Forms.Button btnWIP;
        private System.Windows.Forms.TextBox txtbxShipName;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label lbl_insguide;
        private FmanDBDataSet fmanDBDataSet1;
        private System.Windows.Forms.DataGridView dgvShip;
        private System.Windows.Forms.BindingSource dataTable1BindingSource;
        private System.Windows.Forms.BindingSource fmanDBDataSet1BindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn shipname;
        private System.Windows.Forms.DataGridViewTextBoxColumn expirydate;
        private System.Windows.Forms.DataGridViewTextBoxColumn santaMariaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mamaTiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn deebaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DateTimePicker dtpPermitEnds;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}