namespace CarLand.Forms
{
    partial class Clientes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Clientes));
            this.metroTabControl1 = new MetroFramework.Controls.MetroTabControl();
            this.metroTabPage1 = new MetroFramework.Controls.MetroTabPage();
            this.metroGrid1 = new MetroFramework.Controls.MetroGrid();
            this.idClientDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clientnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cPFDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.birthDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phoneDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.generDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clientBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.integradoraDataSet4 = new CarLand.DataSets.IntegradoraDataSet4();
            this.metroTabPage2 = new MetroFramework.Controls.MetroTabPage();
            this.metroLinkVoltar = new MetroFramework.Controls.MetroLink();
            this.metroLinkSalvar = new MetroFramework.Controls.MetroLink();
            this.mtxtSenhaClientes = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel10 = new MetroFramework.Controls.MetroLabel();
            this.mdtValidadeCNH = new MetroFramework.Controls.MetroDateTime();
            this.metroLabel9 = new MetroFramework.Controls.MetroLabel();
            this.mdtDataNascimento = new MetroFramework.Controls.MetroDateTime();
            this.mcmbGenero = new MetroFramework.Controls.MetroComboBox();
            this.mtxtEmail = new MetroFramework.Controls.MetroTextBox();
            this.mtxtTelefone = new MetroFramework.Controls.MetroTextBox();
            this.mtxtCNH = new MetroFramework.Controls.MetroTextBox();
            this.mtxtCPF = new MetroFramework.Controls.MetroTextBox();
            this.mtxtUsuarioClientes = new MetroFramework.Controls.MetroTextBox();
            this.mtxtNomeClientes = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel8 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel7 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel6 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.clientTableAdapter = new CarLand.DataSets.IntegradoraDataSet4TableAdapters.ClientTableAdapter();
            this.metroTabControl1.SuspendLayout();
            this.metroTabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.metroGrid1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.integradoraDataSet4)).BeginInit();
            this.metroTabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // metroTabControl1
            // 
            this.metroTabControl1.Controls.Add(this.metroTabPage1);
            this.metroTabControl1.Controls.Add(this.metroTabPage2);
            this.metroTabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.metroTabControl1.Location = new System.Drawing.Point(20, 60);
            this.metroTabControl1.Name = "metroTabControl1";
            this.metroTabControl1.SelectedIndex = 0;
            this.metroTabControl1.Size = new System.Drawing.Size(833, 424);
            this.metroTabControl1.Style = MetroFramework.MetroColorStyle.Orange;
            this.metroTabControl1.TabIndex = 0;
            this.metroTabControl1.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroTabControl1.UseSelectable = true;
            // 
            // metroTabPage1
            // 
            this.metroTabPage1.Controls.Add(this.metroGrid1);
            this.metroTabPage1.HorizontalScrollbarBarColor = true;
            this.metroTabPage1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroTabPage1.HorizontalScrollbarSize = 10;
            this.metroTabPage1.Location = new System.Drawing.Point(4, 38);
            this.metroTabPage1.Name = "metroTabPage1";
            this.metroTabPage1.Size = new System.Drawing.Size(825, 382);
            this.metroTabPage1.TabIndex = 0;
            this.metroTabPage1.Text = "Lista de Clientes";
            this.metroTabPage1.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroTabPage1.VerticalScrollbarBarColor = true;
            this.metroTabPage1.VerticalScrollbarHighlightOnWheel = false;
            this.metroTabPage1.VerticalScrollbarSize = 10;
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
            this.idClientDataGridViewTextBoxColumn,
            this.clientnameDataGridViewTextBoxColumn,
            this.cPFDataGridViewTextBoxColumn,
            this.birthDataGridViewTextBoxColumn,
            this.phoneDataGridViewTextBoxColumn,
            this.emailDataGridViewTextBoxColumn,
            this.generDataGridViewTextBoxColumn});
            this.metroGrid1.DataSource = this.clientBindingSource;
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
            this.metroGrid1.Location = new System.Drawing.Point(11, 23);
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
            this.metroGrid1.Size = new System.Drawing.Size(796, 339);
            this.metroGrid1.Style = MetroFramework.MetroColorStyle.Orange;
            this.metroGrid1.TabIndex = 2;
            this.metroGrid1.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // idClientDataGridViewTextBoxColumn
            // 
            this.idClientDataGridViewTextBoxColumn.DataPropertyName = "idClient";
            this.idClientDataGridViewTextBoxColumn.FillWeight = 30F;
            this.idClientDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idClientDataGridViewTextBoxColumn.Name = "idClientDataGridViewTextBoxColumn";
            this.idClientDataGridViewTextBoxColumn.ReadOnly = true;
            this.idClientDataGridViewTextBoxColumn.Width = 30;
            // 
            // clientnameDataGridViewTextBoxColumn
            // 
            this.clientnameDataGridViewTextBoxColumn.DataPropertyName = "Clientname";
            this.clientnameDataGridViewTextBoxColumn.FillWeight = 150F;
            this.clientnameDataGridViewTextBoxColumn.HeaderText = "Nome";
            this.clientnameDataGridViewTextBoxColumn.Name = "clientnameDataGridViewTextBoxColumn";
            this.clientnameDataGridViewTextBoxColumn.ReadOnly = true;
            this.clientnameDataGridViewTextBoxColumn.Width = 150;
            // 
            // cPFDataGridViewTextBoxColumn
            // 
            this.cPFDataGridViewTextBoxColumn.DataPropertyName = "CPF";
            this.cPFDataGridViewTextBoxColumn.HeaderText = "CPF";
            this.cPFDataGridViewTextBoxColumn.Name = "cPFDataGridViewTextBoxColumn";
            this.cPFDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // birthDataGridViewTextBoxColumn
            // 
            this.birthDataGridViewTextBoxColumn.DataPropertyName = "Birth";
            this.birthDataGridViewTextBoxColumn.FillWeight = 120F;
            this.birthDataGridViewTextBoxColumn.HeaderText = "Data Nascimento";
            this.birthDataGridViewTextBoxColumn.Name = "birthDataGridViewTextBoxColumn";
            this.birthDataGridViewTextBoxColumn.ReadOnly = true;
            this.birthDataGridViewTextBoxColumn.Width = 120;
            // 
            // phoneDataGridViewTextBoxColumn
            // 
            this.phoneDataGridViewTextBoxColumn.DataPropertyName = "Phone";
            this.phoneDataGridViewTextBoxColumn.HeaderText = "Telefone";
            this.phoneDataGridViewTextBoxColumn.Name = "phoneDataGridViewTextBoxColumn";
            this.phoneDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // emailDataGridViewTextBoxColumn
            // 
            this.emailDataGridViewTextBoxColumn.DataPropertyName = "Email";
            this.emailDataGridViewTextBoxColumn.FillWeight = 150F;
            this.emailDataGridViewTextBoxColumn.HeaderText = "Email";
            this.emailDataGridViewTextBoxColumn.Name = "emailDataGridViewTextBoxColumn";
            this.emailDataGridViewTextBoxColumn.ReadOnly = true;
            this.emailDataGridViewTextBoxColumn.Width = 150;
            // 
            // generDataGridViewTextBoxColumn
            // 
            this.generDataGridViewTextBoxColumn.DataPropertyName = "Gener";
            this.generDataGridViewTextBoxColumn.HeaderText = "Sexo";
            this.generDataGridViewTextBoxColumn.Name = "generDataGridViewTextBoxColumn";
            this.generDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // clientBindingSource
            // 
            this.clientBindingSource.DataMember = "Client";
            this.clientBindingSource.DataSource = this.integradoraDataSet4;
            // 
            // integradoraDataSet4
            // 
            this.integradoraDataSet4.DataSetName = "IntegradoraDataSet4";
            this.integradoraDataSet4.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // metroTabPage2
            // 
            this.metroTabPage2.Controls.Add(this.metroLinkVoltar);
            this.metroTabPage2.Controls.Add(this.metroLinkSalvar);
            this.metroTabPage2.Controls.Add(this.mtxtSenhaClientes);
            this.metroTabPage2.Controls.Add(this.metroLabel10);
            this.metroTabPage2.Controls.Add(this.mdtValidadeCNH);
            this.metroTabPage2.Controls.Add(this.metroLabel9);
            this.metroTabPage2.Controls.Add(this.mdtDataNascimento);
            this.metroTabPage2.Controls.Add(this.mcmbGenero);
            this.metroTabPage2.Controls.Add(this.mtxtEmail);
            this.metroTabPage2.Controls.Add(this.mtxtTelefone);
            this.metroTabPage2.Controls.Add(this.mtxtCNH);
            this.metroTabPage2.Controls.Add(this.mtxtCPF);
            this.metroTabPage2.Controls.Add(this.mtxtUsuarioClientes);
            this.metroTabPage2.Controls.Add(this.mtxtNomeClientes);
            this.metroTabPage2.Controls.Add(this.metroLabel8);
            this.metroTabPage2.Controls.Add(this.metroLabel7);
            this.metroTabPage2.Controls.Add(this.metroLabel6);
            this.metroTabPage2.Controls.Add(this.metroLabel5);
            this.metroTabPage2.Controls.Add(this.metroLabel4);
            this.metroTabPage2.Controls.Add(this.metroLabel3);
            this.metroTabPage2.Controls.Add(this.metroLabel2);
            this.metroTabPage2.Controls.Add(this.metroLabel1);
            this.metroTabPage2.HorizontalScrollbarBarColor = true;
            this.metroTabPage2.HorizontalScrollbarHighlightOnWheel = false;
            this.metroTabPage2.HorizontalScrollbarSize = 10;
            this.metroTabPage2.Location = new System.Drawing.Point(4, 38);
            this.metroTabPage2.Name = "metroTabPage2";
            this.metroTabPage2.Size = new System.Drawing.Size(825, 382);
            this.metroTabPage2.TabIndex = 1;
            this.metroTabPage2.Text = "Novo";
            this.metroTabPage2.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroTabPage2.VerticalScrollbarBarColor = true;
            this.metroTabPage2.VerticalScrollbarHighlightOnWheel = false;
            this.metroTabPage2.VerticalScrollbarSize = 10;
            // 
            // metroLinkVoltar
            // 
            this.metroLinkVoltar.Image = ((System.Drawing.Image)(resources.GetObject("metroLinkVoltar.Image")));
            this.metroLinkVoltar.ImageSize = 45;
            this.metroLinkVoltar.Location = new System.Drawing.Point(749, 309);
            this.metroLinkVoltar.Name = "metroLinkVoltar";
            this.metroLinkVoltar.Size = new System.Drawing.Size(46, 43);
            this.metroLinkVoltar.TabIndex = 24;
            this.metroLinkVoltar.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroLinkVoltar.UseSelectable = true;
            // 
            // metroLinkSalvar
            // 
            this.metroLinkSalvar.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.metroLinkSalvar.ForeColor = System.Drawing.Color.Black;
            this.metroLinkSalvar.Image = ((System.Drawing.Image)(resources.GetObject("metroLinkSalvar.Image")));
            this.metroLinkSalvar.ImageSize = 40;
            this.metroLinkSalvar.Location = new System.Drawing.Point(693, 309);
            this.metroLinkSalvar.Name = "metroLinkSalvar";
            this.metroLinkSalvar.Size = new System.Drawing.Size(50, 43);
            this.metroLinkSalvar.Style = MetroFramework.MetroColorStyle.Orange;
            this.metroLinkSalvar.TabIndex = 25;
            this.metroLinkSalvar.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroLinkSalvar.UseSelectable = true;
            // 
            // mtxtSenhaClientes
            // 
            // 
            // 
            // 
            this.mtxtSenhaClientes.CustomButton.Image = null;
            this.mtxtSenhaClientes.CustomButton.Location = new System.Drawing.Point(109, 1);
            this.mtxtSenhaClientes.CustomButton.Name = "";
            this.mtxtSenhaClientes.CustomButton.Size = new System.Drawing.Size(27, 27);
            this.mtxtSenhaClientes.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.mtxtSenhaClientes.CustomButton.TabIndex = 1;
            this.mtxtSenhaClientes.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.mtxtSenhaClientes.CustomButton.UseSelectable = true;
            this.mtxtSenhaClientes.CustomButton.Visible = false;
            this.mtxtSenhaClientes.Lines = new string[0];
            this.mtxtSenhaClientes.Location = new System.Drawing.Point(194, 133);
            this.mtxtSenhaClientes.MaxLength = 32767;
            this.mtxtSenhaClientes.Multiline = true;
            this.mtxtSenhaClientes.Name = "mtxtSenhaClientes";
            this.mtxtSenhaClientes.PasswordChar = '\0';
            this.mtxtSenhaClientes.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.mtxtSenhaClientes.SelectedText = "";
            this.mtxtSenhaClientes.SelectionLength = 0;
            this.mtxtSenhaClientes.SelectionStart = 0;
            this.mtxtSenhaClientes.ShortcutsEnabled = true;
            this.mtxtSenhaClientes.Size = new System.Drawing.Size(137, 29);
            this.mtxtSenhaClientes.TabIndex = 43;
            this.mtxtSenhaClientes.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.mtxtSenhaClientes.UseSelectable = true;
            this.mtxtSenhaClientes.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.mtxtSenhaClientes.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel10
            // 
            this.metroLabel10.AutoSize = true;
            this.metroLabel10.BackColor = System.Drawing.Color.Transparent;
            this.metroLabel10.Location = new System.Drawing.Point(194, 111);
            this.metroLabel10.Name = "metroLabel10";
            this.metroLabel10.Size = new System.Drawing.Size(47, 19);
            this.metroLabel10.TabIndex = 42;
            this.metroLabel10.Text = "Senha:";
            this.metroLabel10.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // mdtValidadeCNH
            // 
            this.mdtValidadeCNH.Location = new System.Drawing.Point(392, 209);
            this.mdtValidadeCNH.MinimumSize = new System.Drawing.Size(4, 29);
            this.mdtValidadeCNH.Name = "mdtValidadeCNH";
            this.mdtValidadeCNH.Size = new System.Drawing.Size(223, 29);
            this.mdtValidadeCNH.TabIndex = 41;
            this.mdtValidadeCNH.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // metroLabel9
            // 
            this.metroLabel9.AutoSize = true;
            this.metroLabel9.BackColor = System.Drawing.Color.Transparent;
            this.metroLabel9.Location = new System.Drawing.Point(392, 187);
            this.metroLabel9.Name = "metroLabel9";
            this.metroLabel9.Size = new System.Drawing.Size(143, 19);
            this.metroLabel9.TabIndex = 40;
            this.metroLabel9.Text = "Data de Validade CNH:";
            this.metroLabel9.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // mdtDataNascimento
            // 
            this.mdtDataNascimento.Location = new System.Drawing.Point(503, 133);
            this.mdtDataNascimento.MinimumSize = new System.Drawing.Size(4, 29);
            this.mdtDataNascimento.Name = "mdtDataNascimento";
            this.mdtDataNascimento.Size = new System.Drawing.Size(223, 29);
            this.mdtDataNascimento.TabIndex = 38;
            this.mdtDataNascimento.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // mcmbGenero
            // 
            this.mcmbGenero.FormattingEnabled = true;
            this.mcmbGenero.ItemHeight = 23;
            this.mcmbGenero.Items.AddRange(new object[] {
            "Feminino",
            "Masculino",
            "Prefiro não mencionar"});
            this.mcmbGenero.Location = new System.Drawing.Point(32, 209);
            this.mcmbGenero.Name = "mcmbGenero";
            this.mcmbGenero.Size = new System.Drawing.Size(210, 29);
            this.mcmbGenero.TabIndex = 37;
            this.mcmbGenero.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.mcmbGenero.UseSelectable = true;
            // 
            // mtxtEmail
            // 
            // 
            // 
            // 
            this.mtxtEmail.CustomButton.Image = null;
            this.mtxtEmail.CustomButton.Location = new System.Drawing.Point(174, 1);
            this.mtxtEmail.CustomButton.Name = "";
            this.mtxtEmail.CustomButton.Size = new System.Drawing.Size(27, 27);
            this.mtxtEmail.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.mtxtEmail.CustomButton.TabIndex = 1;
            this.mtxtEmail.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.mtxtEmail.CustomButton.UseSelectable = true;
            this.mtxtEmail.CustomButton.Visible = false;
            this.mtxtEmail.Lines = new string[0];
            this.mtxtEmail.Location = new System.Drawing.Point(337, 58);
            this.mtxtEmail.MaxLength = 32767;
            this.mtxtEmail.Multiline = true;
            this.mtxtEmail.Name = "mtxtEmail";
            this.mtxtEmail.PasswordChar = '\0';
            this.mtxtEmail.PromptText = "exemplo@email.com";
            this.mtxtEmail.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.mtxtEmail.SelectedText = "";
            this.mtxtEmail.SelectionLength = 0;
            this.mtxtEmail.SelectionStart = 0;
            this.mtxtEmail.ShortcutsEnabled = true;
            this.mtxtEmail.Size = new System.Drawing.Size(202, 29);
            this.mtxtEmail.TabIndex = 36;
            this.mtxtEmail.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.mtxtEmail.UseSelectable = true;
            this.mtxtEmail.WaterMark = "exemplo@email.com";
            this.mtxtEmail.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.mtxtEmail.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // mtxtTelefone
            // 
            // 
            // 
            // 
            this.mtxtTelefone.CustomButton.Image = null;
            this.mtxtTelefone.CustomButton.Location = new System.Drawing.Point(89, 1);
            this.mtxtTelefone.CustomButton.Name = "";
            this.mtxtTelefone.CustomButton.Size = new System.Drawing.Size(27, 27);
            this.mtxtTelefone.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.mtxtTelefone.CustomButton.TabIndex = 1;
            this.mtxtTelefone.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.mtxtTelefone.CustomButton.UseSelectable = true;
            this.mtxtTelefone.CustomButton.Visible = false;
            this.mtxtTelefone.Lines = new string[0];
            this.mtxtTelefone.Location = new System.Drawing.Point(359, 133);
            this.mtxtTelefone.MaxLength = 32767;
            this.mtxtTelefone.Multiline = true;
            this.mtxtTelefone.Name = "mtxtTelefone";
            this.mtxtTelefone.PasswordChar = '\0';
            this.mtxtTelefone.PromptText = "(35) X XXXX-XXXX";
            this.mtxtTelefone.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.mtxtTelefone.SelectedText = "";
            this.mtxtTelefone.SelectionLength = 0;
            this.mtxtTelefone.SelectionStart = 0;
            this.mtxtTelefone.ShortcutsEnabled = true;
            this.mtxtTelefone.Size = new System.Drawing.Size(117, 29);
            this.mtxtTelefone.TabIndex = 35;
            this.mtxtTelefone.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.mtxtTelefone.UseSelectable = true;
            this.mtxtTelefone.WaterMark = "(35) X XXXX-XXXX";
            this.mtxtTelefone.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.mtxtTelefone.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // mtxtCNH
            // 
            // 
            // 
            // 
            this.mtxtCNH.CustomButton.Image = null;
            this.mtxtCNH.CustomButton.Location = new System.Drawing.Point(72, 1);
            this.mtxtCNH.CustomButton.Name = "";
            this.mtxtCNH.CustomButton.Size = new System.Drawing.Size(27, 27);
            this.mtxtCNH.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.mtxtCNH.CustomButton.TabIndex = 1;
            this.mtxtCNH.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.mtxtCNH.CustomButton.UseSelectable = true;
            this.mtxtCNH.CustomButton.Visible = false;
            this.mtxtCNH.Lines = new string[0];
            this.mtxtCNH.Location = new System.Drawing.Point(261, 209);
            this.mtxtCNH.MaxLength = 32767;
            this.mtxtCNH.Multiline = true;
            this.mtxtCNH.Name = "mtxtCNH";
            this.mtxtCNH.PasswordChar = '\0';
            this.mtxtCNH.PromptText = "XXXXXXXXXXX";
            this.mtxtCNH.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.mtxtCNH.SelectedText = "";
            this.mtxtCNH.SelectionLength = 0;
            this.mtxtCNH.SelectionStart = 0;
            this.mtxtCNH.ShortcutsEnabled = true;
            this.mtxtCNH.Size = new System.Drawing.Size(100, 29);
            this.mtxtCNH.TabIndex = 34;
            this.mtxtCNH.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.mtxtCNH.UseSelectable = true;
            this.mtxtCNH.WaterMark = "XXXXXXXXXXX";
            this.mtxtCNH.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.mtxtCNH.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // mtxtCPF
            // 
            // 
            // 
            // 
            this.mtxtCPF.CustomButton.Image = null;
            this.mtxtCPF.CustomButton.Location = new System.Drawing.Point(141, 1);
            this.mtxtCPF.CustomButton.Name = "";
            this.mtxtCPF.CustomButton.Size = new System.Drawing.Size(27, 27);
            this.mtxtCPF.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.mtxtCPF.CustomButton.TabIndex = 1;
            this.mtxtCPF.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.mtxtCPF.CustomButton.UseSelectable = true;
            this.mtxtCPF.CustomButton.Visible = false;
            this.mtxtCPF.Lines = new string[0];
            this.mtxtCPF.Location = new System.Drawing.Point(556, 58);
            this.mtxtCPF.MaxLength = 32767;
            this.mtxtCPF.Multiline = true;
            this.mtxtCPF.Name = "mtxtCPF";
            this.mtxtCPF.PasswordChar = '\0';
            this.mtxtCPF.PromptText = "XXX.XXX.XXX-XX";
            this.mtxtCPF.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.mtxtCPF.SelectedText = "";
            this.mtxtCPF.SelectionLength = 0;
            this.mtxtCPF.SelectionStart = 0;
            this.mtxtCPF.ShortcutsEnabled = true;
            this.mtxtCPF.Size = new System.Drawing.Size(169, 29);
            this.mtxtCPF.TabIndex = 33;
            this.mtxtCPF.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.mtxtCPF.UseSelectable = true;
            this.mtxtCPF.WaterMark = "XXX.XXX.XXX-XX";
            this.mtxtCPF.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.mtxtCPF.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // mtxtUsuarioClientes
            // 
            // 
            // 
            // 
            this.mtxtUsuarioClientes.CustomButton.Image = null;
            this.mtxtUsuarioClientes.CustomButton.Location = new System.Drawing.Point(115, 1);
            this.mtxtUsuarioClientes.CustomButton.Name = "";
            this.mtxtUsuarioClientes.CustomButton.Size = new System.Drawing.Size(27, 27);
            this.mtxtUsuarioClientes.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.mtxtUsuarioClientes.CustomButton.TabIndex = 1;
            this.mtxtUsuarioClientes.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.mtxtUsuarioClientes.CustomButton.UseSelectable = true;
            this.mtxtUsuarioClientes.CustomButton.Visible = false;
            this.mtxtUsuarioClientes.Lines = new string[0];
            this.mtxtUsuarioClientes.Location = new System.Drawing.Point(32, 133);
            this.mtxtUsuarioClientes.MaxLength = 32767;
            this.mtxtUsuarioClientes.Multiline = true;
            this.mtxtUsuarioClientes.Name = "mtxtUsuarioClientes";
            this.mtxtUsuarioClientes.PasswordChar = '\0';
            this.mtxtUsuarioClientes.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.mtxtUsuarioClientes.SelectedText = "";
            this.mtxtUsuarioClientes.SelectionLength = 0;
            this.mtxtUsuarioClientes.SelectionStart = 0;
            this.mtxtUsuarioClientes.ShortcutsEnabled = true;
            this.mtxtUsuarioClientes.Size = new System.Drawing.Size(143, 29);
            this.mtxtUsuarioClientes.TabIndex = 32;
            this.mtxtUsuarioClientes.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.mtxtUsuarioClientes.UseSelectable = true;
            this.mtxtUsuarioClientes.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.mtxtUsuarioClientes.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // mtxtNomeClientes
            // 
            // 
            // 
            // 
            this.mtxtNomeClientes.CustomButton.Image = null;
            this.mtxtNomeClientes.CustomButton.Location = new System.Drawing.Point(258, 1);
            this.mtxtNomeClientes.CustomButton.Name = "";
            this.mtxtNomeClientes.CustomButton.Size = new System.Drawing.Size(27, 27);
            this.mtxtNomeClientes.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.mtxtNomeClientes.CustomButton.TabIndex = 1;
            this.mtxtNomeClientes.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.mtxtNomeClientes.CustomButton.UseSelectable = true;
            this.mtxtNomeClientes.CustomButton.Visible = false;
            this.mtxtNomeClientes.Lines = new string[0];
            this.mtxtNomeClientes.Location = new System.Drawing.Point(31, 58);
            this.mtxtNomeClientes.MaxLength = 32767;
            this.mtxtNomeClientes.Multiline = true;
            this.mtxtNomeClientes.Name = "mtxtNomeClientes";
            this.mtxtNomeClientes.PasswordChar = '\0';
            this.mtxtNomeClientes.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.mtxtNomeClientes.SelectedText = "";
            this.mtxtNomeClientes.SelectionLength = 0;
            this.mtxtNomeClientes.SelectionStart = 0;
            this.mtxtNomeClientes.ShortcutsEnabled = true;
            this.mtxtNomeClientes.Size = new System.Drawing.Size(286, 29);
            this.mtxtNomeClientes.TabIndex = 31;
            this.mtxtNomeClientes.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.mtxtNomeClientes.UseSelectable = true;
            this.mtxtNomeClientes.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.mtxtNomeClientes.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel8
            // 
            this.metroLabel8.AutoSize = true;
            this.metroLabel8.BackColor = System.Drawing.Color.Transparent;
            this.metroLabel8.Location = new System.Drawing.Point(32, 187);
            this.metroLabel8.Name = "metroLabel8";
            this.metroLabel8.Size = new System.Drawing.Size(55, 19);
            this.metroLabel8.TabIndex = 30;
            this.metroLabel8.Text = "Gênero:";
            this.metroLabel8.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // metroLabel7
            // 
            this.metroLabel7.AutoSize = true;
            this.metroLabel7.BackColor = System.Drawing.Color.Transparent;
            this.metroLabel7.Location = new System.Drawing.Point(337, 36);
            this.metroLabel7.Name = "metroLabel7";
            this.metroLabel7.Size = new System.Drawing.Size(50, 19);
            this.metroLabel7.TabIndex = 29;
            this.metroLabel7.Text = "E-mail:";
            this.metroLabel7.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // metroLabel6
            // 
            this.metroLabel6.AutoSize = true;
            this.metroLabel6.BackColor = System.Drawing.Color.Transparent;
            this.metroLabel6.Location = new System.Drawing.Point(359, 111);
            this.metroLabel6.Name = "metroLabel6";
            this.metroLabel6.Size = new System.Drawing.Size(60, 19);
            this.metroLabel6.TabIndex = 28;
            this.metroLabel6.Text = "Telefone:";
            this.metroLabel6.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.BackColor = System.Drawing.Color.Transparent;
            this.metroLabel5.Location = new System.Drawing.Point(503, 111);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(131, 19);
            this.metroLabel5.TabIndex = 27;
            this.metroLabel5.Text = "Data de Nascimento:";
            this.metroLabel5.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.BackColor = System.Drawing.Color.Transparent;
            this.metroLabel4.Location = new System.Drawing.Point(261, 187);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(40, 19);
            this.metroLabel4.TabIndex = 26;
            this.metroLabel4.Text = "CNH:";
            this.metroLabel4.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.BackColor = System.Drawing.Color.Transparent;
            this.metroLabel3.Location = new System.Drawing.Point(556, 36);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(36, 19);
            this.metroLabel3.TabIndex = 25;
            this.metroLabel3.Text = "CPF:";
            this.metroLabel3.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.BackColor = System.Drawing.Color.Transparent;
            this.metroLabel2.Location = new System.Drawing.Point(32, 111);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(56, 19);
            this.metroLabel2.TabIndex = 24;
            this.metroLabel2.Text = "Usuário:";
            this.metroLabel2.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.BackColor = System.Drawing.Color.Transparent;
            this.metroLabel1.Location = new System.Drawing.Point(31, 36);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(49, 19);
            this.metroLabel1.TabIndex = 23;
            this.metroLabel1.Text = "Nome:";
            this.metroLabel1.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // clientTableAdapter
            // 
            this.clientTableAdapter.ClearBeforeFill = true;
            // 
            // Clientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackImage = ((System.Drawing.Image)(resources.GetObject("$this.BackImage")));
            this.BackImagePadding = new System.Windows.Forms.Padding(-19, 6, -1, -1);
            this.BackMaxSize = 210;
            this.ClientSize = new System.Drawing.Size(873, 504);
            this.Controls.Add(this.metroTabControl1);
            this.Name = "Clientes";
            this.Resizable = false;
            this.Style = MetroFramework.MetroColorStyle.Orange;
            this.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.Load += new System.EventHandler(this.Clientes_Load);
            this.metroTabControl1.ResumeLayout(false);
            this.metroTabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.metroGrid1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.integradoraDataSet4)).EndInit();
            this.metroTabPage2.ResumeLayout(false);
            this.metroTabPage2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroTabControl metroTabControl1;
        private MetroFramework.Controls.MetroTabPage metroTabPage1;
        private MetroFramework.Controls.MetroTabPage metroTabPage2;
        private MetroFramework.Controls.MetroTextBox mtxtSenhaClientes;
        private MetroFramework.Controls.MetroLabel metroLabel10;
        private MetroFramework.Controls.MetroDateTime mdtValidadeCNH;
        private MetroFramework.Controls.MetroLabel metroLabel9;
        private MetroFramework.Controls.MetroDateTime mdtDataNascimento;
        private MetroFramework.Controls.MetroComboBox mcmbGenero;
        private MetroFramework.Controls.MetroTextBox mtxtEmail;
        private MetroFramework.Controls.MetroTextBox mtxtTelefone;
        private MetroFramework.Controls.MetroTextBox mtxtCNH;
        private MetroFramework.Controls.MetroTextBox mtxtCPF;
        private MetroFramework.Controls.MetroTextBox mtxtUsuarioClientes;
        private MetroFramework.Controls.MetroTextBox mtxtNomeClientes;
        private MetroFramework.Controls.MetroLabel metroLabel8;
        private MetroFramework.Controls.MetroLabel metroLabel7;
        private MetroFramework.Controls.MetroLabel metroLabel6;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroGrid metroGrid1;
        private MetroFramework.Controls.MetroLink metroLinkVoltar;
        private MetroFramework.Controls.MetroLink metroLinkSalvar;
        private DataSets.IntegradoraDataSet4 integradoraDataSet4;
        private System.Windows.Forms.BindingSource clientBindingSource;
        private DataSets.IntegradoraDataSet4TableAdapters.ClientTableAdapter clientTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idClientDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn clientnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cPFDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn birthDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn phoneDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn generDataGridViewTextBoxColumn;
    }
}