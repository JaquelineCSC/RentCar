namespace CarLand.Forms.Car
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ListCar));
            this.metroGrid1 = new MetroFramework.Controls.MetroGrid();
            this.carBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.listCarRamiresBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.listCarRamires = new CarLand.Forms.DataSets.Ramires.ListCarRamires();
            this.carsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cars = new CarLand.Forms.DataSets.Paulo.Cars();
            this.metroLink1 = new MetroFramework.Controls.MetroLink();
            this.metroLink2 = new MetroFramework.Controls.MetroLink();
            this.metroLink3 = new MetroFramework.Controls.MetroLink();
            this.metroLink4 = new MetroFramework.Controls.MetroLink();
            this.metrotooltipo = new MetroFramework.Components.MetroToolTip();
            this.carsTableAdapter = new CarLand.Forms.DataSets.Paulo.CarsTableAdapters.CarsTableAdapter();
            this.carTableAdapter = new CarLand.Forms.DataSets.Ramires.ListCarRamiresTableAdapters.CarTableAdapter();
            this.listaCar = new CarLand.ListaCar();
            this.carsBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.carsTableAdapter1 = new CarLand.ListaCarTableAdapters.CarsTableAdapter();
            this.códigoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.corDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.placaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.modeloDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.combustivelDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.portasDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.marcaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.anoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.metroGrid1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.carBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.listCarRamiresBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.listCarRamires)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.carsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cars)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.listaCar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.carsBindingSource1)).BeginInit();
            this.SuspendLayout();
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
            this.códigoDataGridViewTextBoxColumn,
            this.corDataGridViewTextBoxColumn,
            this.placaDataGridViewTextBoxColumn,
            this.modeloDataGridViewTextBoxColumn,
            this.combustivelDataGridViewTextBoxColumn,
            this.portasDataGridViewTextBoxColumn,
            this.marcaDataGridViewTextBoxColumn,
            this.anoDataGridViewTextBoxColumn});
            this.metroGrid1.DataSource = this.carsBindingSource1;
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
            this.metroGrid1.Location = new System.Drawing.Point(39, 85);
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
            this.metroGrid1.Size = new System.Drawing.Size(841, 435);
            this.metroGrid1.Style = MetroFramework.MetroColorStyle.Orange;
            this.metroGrid1.TabIndex = 0;
            this.metroGrid1.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroGrid1.SelectionChanged += new System.EventHandler(this.metroGrid1_CellContentClick);
            // 
            // carBindingSource
            // 
            this.carBindingSource.DataMember = "Car";
            this.carBindingSource.DataSource = this.listCarRamiresBindingSource;
            // 
            // listCarRamiresBindingSource
            // 
            this.listCarRamiresBindingSource.DataSource = this.listCarRamires;
            this.listCarRamiresBindingSource.Position = 0;
            // 
            // listCarRamires
            // 
            this.listCarRamires.DataSetName = "ListCarRamires";
            this.listCarRamires.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // carsBindingSource
            // 
            this.carsBindingSource.DataMember = "Cars";
            this.carsBindingSource.DataSource = this.cars;
            // 
            // cars
            // 
            this.cars.DataSetName = "Cars";
            this.cars.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // metroLink1
            // 
            this.metroLink1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("metroLink1.BackgroundImage")));
            this.metroLink1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.metroLink1.Location = new System.Drawing.Point(737, 54);
            this.metroLink1.Name = "metroLink1";
            this.metroLink1.Size = new System.Drawing.Size(25, 25);
            this.metroLink1.TabIndex = 1;
            this.metrotooltipo.SetToolTip(this.metroLink1, "Adicionar");
            this.metroLink1.UseSelectable = true;
            this.metroLink1.Click += new System.EventHandler(this.metroLink1_Click);
            this.metroLink1.MouseHover += new System.EventHandler(this.toolTip);
            // 
            // metroLink2
            // 
            this.metroLink2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("metroLink2.BackgroundImage")));
            this.metroLink2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.metroLink2.Location = new System.Drawing.Point(810, 54);
            this.metroLink2.Name = "metroLink2";
            this.metroLink2.Size = new System.Drawing.Size(25, 25);
            this.metroLink2.TabIndex = 3;
            this.metrotooltipo.SetToolTip(this.metroLink2, "Deletar");
            this.metroLink2.UseSelectable = true;
            this.metroLink2.Click += new System.EventHandler(this.metroLink2_Click);
            this.metroLink2.MouseHover += new System.EventHandler(this.toolTip);
            // 
            // metroLink3
            // 
            this.metroLink3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("metroLink3.BackgroundImage")));
            this.metroLink3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.metroLink3.Location = new System.Drawing.Point(774, 54);
            this.metroLink3.Name = "metroLink3";
            this.metroLink3.Size = new System.Drawing.Size(25, 25);
            this.metroLink3.TabIndex = 2;
            this.metrotooltipo.SetToolTip(this.metroLink3, "Editar");
            this.metroLink3.UseSelectable = true;
            this.metroLink3.Click += new System.EventHandler(this.metroLink3_Click);
            this.metroLink3.MouseHover += new System.EventHandler(this.toolTip);
            // 
            // metroLink4
            // 
            this.metroLink4.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("metroLink4.BackgroundImage")));
            this.metroLink4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.metroLink4.Location = new System.Drawing.Point(841, 54);
            this.metroLink4.Name = "metroLink4";
            this.metroLink4.Size = new System.Drawing.Size(25, 25);
            this.metroLink4.TabIndex = 4;
            this.metrotooltipo.SetToolTip(this.metroLink4, "Recarregar Pagina");
            this.metroLink4.UseSelectable = true;
            this.metroLink4.Click += new System.EventHandler(this.metroLink4_Click);
            // 
            // metrotooltipo
            // 
            this.metrotooltipo.Style = MetroFramework.MetroColorStyle.Orange;
            this.metrotooltipo.StyleManager = null;
            this.metrotooltipo.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // carsTableAdapter
            // 
            this.carsTableAdapter.ClearBeforeFill = true;
            // 
            // carTableAdapter
            // 
            this.carTableAdapter.ClearBeforeFill = true;
            // 
            // listaCar
            // 
            this.listaCar.DataSetName = "ListaCar";
            this.listaCar.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // carsBindingSource1
            // 
            this.carsBindingSource1.DataMember = "Cars";
            this.carsBindingSource1.DataSource = this.listaCar;
            // 
            // carsTableAdapter1
            // 
            this.carsTableAdapter1.ClearBeforeFill = true;
            // 
            // códigoDataGridViewTextBoxColumn
            // 
            this.códigoDataGridViewTextBoxColumn.DataPropertyName = "Código";
            this.códigoDataGridViewTextBoxColumn.HeaderText = "Código";
            this.códigoDataGridViewTextBoxColumn.Name = "códigoDataGridViewTextBoxColumn";
            this.códigoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // corDataGridViewTextBoxColumn
            // 
            this.corDataGridViewTextBoxColumn.DataPropertyName = "Cor";
            this.corDataGridViewTextBoxColumn.HeaderText = "Cor";
            this.corDataGridViewTextBoxColumn.Name = "corDataGridViewTextBoxColumn";
            this.corDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // placaDataGridViewTextBoxColumn
            // 
            this.placaDataGridViewTextBoxColumn.DataPropertyName = "Placa";
            this.placaDataGridViewTextBoxColumn.HeaderText = "Placa";
            this.placaDataGridViewTextBoxColumn.Name = "placaDataGridViewTextBoxColumn";
            this.placaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // modeloDataGridViewTextBoxColumn
            // 
            this.modeloDataGridViewTextBoxColumn.DataPropertyName = "Modelo";
            this.modeloDataGridViewTextBoxColumn.HeaderText = "Modelo";
            this.modeloDataGridViewTextBoxColumn.Name = "modeloDataGridViewTextBoxColumn";
            this.modeloDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // combustivelDataGridViewTextBoxColumn
            // 
            this.combustivelDataGridViewTextBoxColumn.DataPropertyName = "Combustivel";
            this.combustivelDataGridViewTextBoxColumn.HeaderText = "Combustivel";
            this.combustivelDataGridViewTextBoxColumn.Name = "combustivelDataGridViewTextBoxColumn";
            this.combustivelDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // portasDataGridViewTextBoxColumn
            // 
            this.portasDataGridViewTextBoxColumn.DataPropertyName = "Portas";
            this.portasDataGridViewTextBoxColumn.HeaderText = "Portas";
            this.portasDataGridViewTextBoxColumn.Name = "portasDataGridViewTextBoxColumn";
            this.portasDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // marcaDataGridViewTextBoxColumn
            // 
            this.marcaDataGridViewTextBoxColumn.DataPropertyName = "Marca";
            this.marcaDataGridViewTextBoxColumn.HeaderText = "Marca";
            this.marcaDataGridViewTextBoxColumn.Name = "marcaDataGridViewTextBoxColumn";
            this.marcaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // anoDataGridViewTextBoxColumn
            // 
            this.anoDataGridViewTextBoxColumn.DataPropertyName = "Ano";
            this.anoDataGridViewTextBoxColumn.HeaderText = "Ano";
            this.anoDataGridViewTextBoxColumn.Name = "anoDataGridViewTextBoxColumn";
            this.anoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // ListCar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackImage = ((System.Drawing.Image)(resources.GetObject("$this.BackImage")));
            this.BackImagePadding = new System.Windows.Forms.Padding(-19, 7, -1, -1);
            this.BackMaxSize = 240;
            this.ClientSize = new System.Drawing.Size(923, 543);
            this.Controls.Add(this.metroLink4);
            this.Controls.Add(this.metroLink3);
            this.Controls.Add(this.metroLink2);
            this.Controls.Add(this.metroLink1);
            this.Controls.Add(this.metroGrid1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ListCar";
            this.Resizable = false;
            this.Style = MetroFramework.MetroColorStyle.Orange;
            this.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.Load += new System.EventHandler(this.ListCar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.metroGrid1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.carBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.listCarRamiresBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.listCarRamires)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.carsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cars)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.listaCar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.carsBindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroGrid metroGrid1;
        private MetroFramework.Controls.MetroLink metroLink1;
        private MetroFramework.Controls.MetroLink metroLink2;
        private MetroFramework.Controls.MetroLink metroLink3;
        private MetroFramework.Components.MetroToolTip metrotooltipo;
        private MetroFramework.Controls.MetroLink metroLink4;
        private CarLand.Forms.DataSets.Paulo.Cars cars;
        private System.Windows.Forms.BindingSource carsBindingSource;
        private DataSets.Paulo.CarsTableAdapters.CarsTableAdapter carsTableAdapter;
        private System.Windows.Forms.BindingSource listCarRamiresBindingSource;
        private DataSets.Ramires.ListCarRamires listCarRamires;
        private System.Windows.Forms.BindingSource carBindingSource;
        private DataSets.Ramires.ListCarRamiresTableAdapters.CarTableAdapter carTableAdapter;
        private ListaCar listaCar;
        private System.Windows.Forms.BindingSource carsBindingSource1;
        private ListaCarTableAdapters.CarsTableAdapter carsTableAdapter1;
        private System.Windows.Forms.DataGridViewTextBoxColumn códigoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn corDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn placaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn modeloDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn combustivelDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn portasDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn marcaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn anoDataGridViewTextBoxColumn;
    }
}