namespace CarLand.Forms.Client
{
    partial class ListCar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ListCar));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.metroLink3 = new MetroFramework.Controls.MetroLink();
            this.metroGrid1 = new MetroFramework.Controls.MetroGrid();
            this.rentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.listRentRamires = new CarLand.Forms.DataSets.Ramires.ListRentRamires();
            this.rentViewBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.rentViewBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.rentView = new CarLand.Forms.DataSets.Paulo.RentView();
            this.rentViewTableAdapter = new CarLand.Forms.DataSets.Paulo.RentViewTableAdapters.RentViewTableAdapter();
            this.metroToolTip1 = new MetroFramework.Components.MetroToolTip();
            this.rentTableAdapter = new CarLand.Forms.DataSets.Ramires.ListRentRamiresTableAdapters.RentTableAdapter();
            this.listaRent = new CarLand.ListaRent();
            this.rentViewBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.rentViewTableAdapter1 = new CarLand.ListaRentTableAdapters.RentViewTableAdapter();
            this.idAluguelDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.marcaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.modeloDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.anoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.corDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.funcionarioDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clienteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataRetiradaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataDevoluçãoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.valorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.finalCartãoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.paymentTypeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.metroGrid1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rentBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.listRentRamires)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rentViewBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rentViewBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rentView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.listaRent)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rentViewBindingSource2)).BeginInit();
            this.SuspendLayout();
            // 
            // metroLink3
            // 
            this.metroLink3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("metroLink3.BackgroundImage")));
            this.metroLink3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.metroLink3.Location = new System.Drawing.Point(1113, 73);
            this.metroLink3.Name = "metroLink3";
            this.metroLink3.Size = new System.Drawing.Size(25, 25);
            this.metroLink3.TabIndex = 7;
            this.metroToolTip1.SetToolTip(this.metroLink3, "Ver Detalhes");
            this.metroLink3.UseSelectable = true;
            this.metroLink3.Click += new System.EventHandler(this.metroLink3_Click);
            // 
            // metroGrid1
            // 
            this.metroGrid1.AllowUserToAddRows = false;
            this.metroGrid1.AllowUserToDeleteRows = false;
            this.metroGrid1.AllowUserToResizeRows = false;
            this.metroGrid1.AutoGenerateColumns = false;
            this.metroGrid1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.metroGrid1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.metroGrid1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.metroGrid1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(119)))), ((int)(((byte)(53)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(133)))), ((int)(((byte)(72)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.metroGrid1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.metroGrid1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.metroGrid1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idAluguelDataGridViewTextBoxColumn,
            this.marcaDataGridViewTextBoxColumn,
            this.modeloDataGridViewTextBoxColumn,
            this.anoDataGridViewTextBoxColumn,
            this.corDataGridViewTextBoxColumn,
            this.funcionarioDataGridViewTextBoxColumn,
            this.clienteDataGridViewTextBoxColumn,
            this.dataRetiradaDataGridViewTextBoxColumn,
            this.dataDevoluçãoDataGridViewTextBoxColumn,
            this.valorDataGridViewTextBoxColumn,
            this.finalCartãoDataGridViewTextBoxColumn,
            this.paymentTypeDataGridViewTextBoxColumn});
            this.metroGrid1.DataSource = this.rentViewBindingSource2;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(133)))), ((int)(((byte)(72)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.metroGrid1.DefaultCellStyle = dataGridViewCellStyle2;
            this.metroGrid1.EnableHeadersVisualStyles = false;
            this.metroGrid1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.metroGrid1.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.metroGrid1.Location = new System.Drawing.Point(10, 104);
            this.metroGrid1.Name = "metroGrid1";
            this.metroGrid1.ReadOnly = true;
            this.metroGrid1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(119)))), ((int)(((byte)(53)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(133)))), ((int)(((byte)(72)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.metroGrid1.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.metroGrid1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.metroGrid1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.metroGrid1.Size = new System.Drawing.Size(1148, 451);
            this.metroGrid1.Style = MetroFramework.MetroColorStyle.Orange;
            this.metroGrid1.TabIndex = 8;
            this.metroGrid1.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroGrid1.SelectionChanged += new System.EventHandler(this.metroGrid1_SelectionChanged);
            // 
            // rentBindingSource
            // 
            this.rentBindingSource.DataMember = "Rent";
            this.rentBindingSource.DataSource = this.listRentRamires;
            // 
            // listRentRamires
            // 
            this.listRentRamires.DataSetName = "ListRentRamires";
            this.listRentRamires.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // rentViewBindingSource1
            // 
            this.rentViewBindingSource1.DataMember = "RentView";
            this.rentViewBindingSource1.DataSource = this.rentViewBindingSource;
            // 
            // rentViewBindingSource
            // 
            this.rentViewBindingSource.DataSource = this.rentView;
            this.rentViewBindingSource.Position = 0;
            // 
            // rentView
            // 
            this.rentView.DataSetName = "RentView";
            this.rentView.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // rentViewTableAdapter
            // 
            this.rentViewTableAdapter.ClearBeforeFill = true;
            // 
            // metroToolTip1
            // 
            this.metroToolTip1.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroToolTip1.StyleManager = null;
            this.metroToolTip1.Theme = MetroFramework.MetroThemeStyle.Light;
            // 
            // rentTableAdapter
            // 
            this.rentTableAdapter.ClearBeforeFill = true;
            // 
            // listaRent
            // 
            this.listaRent.DataSetName = "ListaRent";
            this.listaRent.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // rentViewBindingSource2
            // 
            this.rentViewBindingSource2.DataMember = "RentView";
            this.rentViewBindingSource2.DataSource = this.listaRent;
            // 
            // rentViewTableAdapter1
            // 
            this.rentViewTableAdapter1.ClearBeforeFill = true;
            // 
            // idAluguelDataGridViewTextBoxColumn
            // 
            this.idAluguelDataGridViewTextBoxColumn.DataPropertyName = "Id Aluguel";
            this.idAluguelDataGridViewTextBoxColumn.HeaderText = "Id Aluguel";
            this.idAluguelDataGridViewTextBoxColumn.Name = "idAluguelDataGridViewTextBoxColumn";
            this.idAluguelDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // marcaDataGridViewTextBoxColumn
            // 
            this.marcaDataGridViewTextBoxColumn.DataPropertyName = "Marca";
            this.marcaDataGridViewTextBoxColumn.HeaderText = "Marca";
            this.marcaDataGridViewTextBoxColumn.Name = "marcaDataGridViewTextBoxColumn";
            this.marcaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // modeloDataGridViewTextBoxColumn
            // 
            this.modeloDataGridViewTextBoxColumn.DataPropertyName = "Modelo";
            this.modeloDataGridViewTextBoxColumn.HeaderText = "Modelo";
            this.modeloDataGridViewTextBoxColumn.Name = "modeloDataGridViewTextBoxColumn";
            this.modeloDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // anoDataGridViewTextBoxColumn
            // 
            this.anoDataGridViewTextBoxColumn.DataPropertyName = "Ano";
            this.anoDataGridViewTextBoxColumn.HeaderText = "Ano";
            this.anoDataGridViewTextBoxColumn.Name = "anoDataGridViewTextBoxColumn";
            this.anoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // corDataGridViewTextBoxColumn
            // 
            this.corDataGridViewTextBoxColumn.DataPropertyName = "Cor";
            this.corDataGridViewTextBoxColumn.HeaderText = "Cor";
            this.corDataGridViewTextBoxColumn.Name = "corDataGridViewTextBoxColumn";
            this.corDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // funcionarioDataGridViewTextBoxColumn
            // 
            this.funcionarioDataGridViewTextBoxColumn.DataPropertyName = "Funcionario";
            this.funcionarioDataGridViewTextBoxColumn.HeaderText = "Funcionario";
            this.funcionarioDataGridViewTextBoxColumn.Name = "funcionarioDataGridViewTextBoxColumn";
            this.funcionarioDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // clienteDataGridViewTextBoxColumn
            // 
            this.clienteDataGridViewTextBoxColumn.DataPropertyName = "Cliente";
            this.clienteDataGridViewTextBoxColumn.HeaderText = "Cliente";
            this.clienteDataGridViewTextBoxColumn.Name = "clienteDataGridViewTextBoxColumn";
            this.clienteDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dataRetiradaDataGridViewTextBoxColumn
            // 
            this.dataRetiradaDataGridViewTextBoxColumn.DataPropertyName = "Data Retirada";
            this.dataRetiradaDataGridViewTextBoxColumn.HeaderText = "Data Retirada";
            this.dataRetiradaDataGridViewTextBoxColumn.Name = "dataRetiradaDataGridViewTextBoxColumn";
            this.dataRetiradaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dataDevoluçãoDataGridViewTextBoxColumn
            // 
            this.dataDevoluçãoDataGridViewTextBoxColumn.DataPropertyName = "Data Devolução";
            this.dataDevoluçãoDataGridViewTextBoxColumn.HeaderText = "Data Devolução";
            this.dataDevoluçãoDataGridViewTextBoxColumn.Name = "dataDevoluçãoDataGridViewTextBoxColumn";
            this.dataDevoluçãoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // valorDataGridViewTextBoxColumn
            // 
            this.valorDataGridViewTextBoxColumn.DataPropertyName = "Valor";
            this.valorDataGridViewTextBoxColumn.HeaderText = "Valor";
            this.valorDataGridViewTextBoxColumn.Name = "valorDataGridViewTextBoxColumn";
            this.valorDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // finalCartãoDataGridViewTextBoxColumn
            // 
            this.finalCartãoDataGridViewTextBoxColumn.DataPropertyName = "Final Cartão";
            this.finalCartãoDataGridViewTextBoxColumn.HeaderText = "Final Cartão";
            this.finalCartãoDataGridViewTextBoxColumn.Name = "finalCartãoDataGridViewTextBoxColumn";
            this.finalCartãoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // paymentTypeDataGridViewTextBoxColumn
            // 
            this.paymentTypeDataGridViewTextBoxColumn.DataPropertyName = "PaymentType";
            this.paymentTypeDataGridViewTextBoxColumn.HeaderText = "PaymentType";
            this.paymentTypeDataGridViewTextBoxColumn.Name = "paymentTypeDataGridViewTextBoxColumn";
            this.paymentTypeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // ListCar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackImage = ((System.Drawing.Image)(resources.GetObject("$this.BackImage")));
            this.BackImagePadding = new System.Windows.Forms.Padding(-19, 14, -1, -1);
            this.BackMaxSize = 270;
            this.ClientSize = new System.Drawing.Size(1181, 635);
            this.Controls.Add(this.metroGrid1);
            this.Controls.Add(this.metroLink3);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ListCar";
            this.Resizable = false;
            this.Style = MetroFramework.MetroColorStyle.Orange;
            this.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.Load += new System.EventHandler(this.AluguelCliente_Load);
            ((System.ComponentModel.ISupportInitialize)(this.metroGrid1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rentBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.listRentRamires)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rentViewBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rentViewBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rentView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.listaRent)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rentViewBindingSource2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private MetroFramework.Controls.MetroLink metroLink3;
        private MetroFramework.Controls.MetroGrid metroGrid1;
        private System.Windows.Forms.BindingSource rentViewBindingSource;
        private DataSets.Paulo.RentView rentView;
        private System.Windows.Forms.BindingSource rentViewBindingSource1;
        private DataSets.Paulo.RentViewTableAdapters.RentViewTableAdapter rentViewTableAdapter;
        private MetroFramework.Components.MetroToolTip metroToolTip1;
        private DataSets.Ramires.ListRentRamires listRentRamires;
        private System.Windows.Forms.BindingSource rentBindingSource;
        private DataSets.Ramires.ListRentRamiresTableAdapters.RentTableAdapter rentTableAdapter;
        private ListaRent listaRent;
        private System.Windows.Forms.BindingSource rentViewBindingSource2;
        private ListaRentTableAdapters.RentViewTableAdapter rentViewTableAdapter1;
        private System.Windows.Forms.DataGridViewTextBoxColumn idAluguelDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn marcaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn modeloDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn anoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn corDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn funcionarioDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn clienteDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataRetiradaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataDevoluçãoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn valorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn finalCartãoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn paymentTypeDataGridViewTextBoxColumn;
    }
}