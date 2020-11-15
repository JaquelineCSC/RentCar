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
            this.nomeClienteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aniversárioDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telefoneDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.generoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cNHDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clientCNHBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.client = new CarLand.DataSets.Paulo.Client();
            this.metroTabPage2 = new MetroFramework.Controls.MetroTabPage();
            this.metroLinkVoltar = new MetroFramework.Controls.MetroLink();
            this.metroLinkSalvar = new MetroFramework.Controls.MetroLink();
            this.password = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel10 = new MetroFramework.Controls.MetroLabel();
            this.validateCNHdate = new MetroFramework.Controls.MetroDateTime();
            this.metroLabel9 = new MetroFramework.Controls.MetroLabel();
            this.dateofBirth = new MetroFramework.Controls.MetroDateTime();
            this.gener = new MetroFramework.Controls.MetroComboBox();
            this.email = new MetroFramework.Controls.MetroTextBox();
            this.phone = new MetroFramework.Controls.MetroTextBox();
            this.cnh = new MetroFramework.Controls.MetroTextBox();
            this.cpf = new MetroFramework.Controls.MetroTextBox();
            this.user = new MetroFramework.Controls.MetroTextBox();
            this.name = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel8 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel7 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel6 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.clientCNHTableAdapter = new CarLand.DataSets.Paulo.ClientTableAdapters.ClientCNHTableAdapter();
            this.metroToolTip1 = new MetroFramework.Components.MetroToolTip();
            this.rentLink = new MetroFramework.Controls.MetroLink();
            this.metroTabControl1.SuspendLayout();
            this.metroTabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.metroGrid1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientCNHBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.client)).BeginInit();
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
            this.metroTabControl1.Size = new System.Drawing.Size(874, 405);
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
            this.metroTabPage1.Size = new System.Drawing.Size(866, 363);
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
            this.nomeClienteDataGridViewTextBoxColumn,
            this.aniversárioDataGridViewTextBoxColumn,
            this.telefoneDataGridViewTextBoxColumn,
            this.emailDataGridViewTextBoxColumn,
            this.generoDataGridViewTextBoxColumn,
            this.cNHDataGridViewTextBoxColumn});
            this.metroGrid1.DataSource = this.clientCNHBindingSource;
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
            this.metroGrid1.Location = new System.Drawing.Point(-4, 19);
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
            this.metroGrid1.Size = new System.Drawing.Size(876, 339);
            this.metroGrid1.Style = MetroFramework.MetroColorStyle.Orange;
            this.metroGrid1.TabIndex = 2;
            this.metroGrid1.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroGrid1.SelectionChanged += new System.EventHandler(this.metroGrid1_CellContentClick);
            // 
            // nomeClienteDataGridViewTextBoxColumn
            // 
            this.nomeClienteDataGridViewTextBoxColumn.DataPropertyName = "Nome Cliente";
            this.nomeClienteDataGridViewTextBoxColumn.FillWeight = 200F;
            this.nomeClienteDataGridViewTextBoxColumn.HeaderText = "Nome Cliente";
            this.nomeClienteDataGridViewTextBoxColumn.Name = "nomeClienteDataGridViewTextBoxColumn";
            this.nomeClienteDataGridViewTextBoxColumn.ReadOnly = true;
            this.nomeClienteDataGridViewTextBoxColumn.Width = 200;
            // 
            // aniversárioDataGridViewTextBoxColumn
            // 
            this.aniversárioDataGridViewTextBoxColumn.DataPropertyName = "Aniversário";
            this.aniversárioDataGridViewTextBoxColumn.HeaderText = "Aniversário";
            this.aniversárioDataGridViewTextBoxColumn.Name = "aniversárioDataGridViewTextBoxColumn";
            this.aniversárioDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // telefoneDataGridViewTextBoxColumn
            // 
            this.telefoneDataGridViewTextBoxColumn.DataPropertyName = "Telefone";
            this.telefoneDataGridViewTextBoxColumn.HeaderText = "Telefone";
            this.telefoneDataGridViewTextBoxColumn.Name = "telefoneDataGridViewTextBoxColumn";
            this.telefoneDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // emailDataGridViewTextBoxColumn
            // 
            this.emailDataGridViewTextBoxColumn.DataPropertyName = "Email";
            this.emailDataGridViewTextBoxColumn.FillWeight = 200F;
            this.emailDataGridViewTextBoxColumn.HeaderText = "Email";
            this.emailDataGridViewTextBoxColumn.Name = "emailDataGridViewTextBoxColumn";
            this.emailDataGridViewTextBoxColumn.ReadOnly = true;
            this.emailDataGridViewTextBoxColumn.Width = 200;
            // 
            // generoDataGridViewTextBoxColumn
            // 
            this.generoDataGridViewTextBoxColumn.DataPropertyName = "Genero";
            this.generoDataGridViewTextBoxColumn.FillWeight = 120F;
            this.generoDataGridViewTextBoxColumn.HeaderText = "Genero";
            this.generoDataGridViewTextBoxColumn.Name = "generoDataGridViewTextBoxColumn";
            this.generoDataGridViewTextBoxColumn.ReadOnly = true;
            this.generoDataGridViewTextBoxColumn.Width = 120;
            // 
            // cNHDataGridViewTextBoxColumn
            // 
            this.cNHDataGridViewTextBoxColumn.DataPropertyName = "CNH";
            this.cNHDataGridViewTextBoxColumn.HeaderText = "CNH";
            this.cNHDataGridViewTextBoxColumn.Name = "cNHDataGridViewTextBoxColumn";
            this.cNHDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // clientCNHBindingSource
            // 
            this.clientCNHBindingSource.DataMember = "ClientCNH";
            this.clientCNHBindingSource.DataSource = this.client;
            // 
            // client
            // 
            this.client.DataSetName = "Client";
            this.client.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // metroTabPage2
            // 
            this.metroTabPage2.Controls.Add(this.metroLinkVoltar);
            this.metroTabPage2.Controls.Add(this.metroLinkSalvar);
            this.metroTabPage2.Controls.Add(this.password);
            this.metroTabPage2.Controls.Add(this.metroLabel10);
            this.metroTabPage2.Controls.Add(this.validateCNHdate);
            this.metroTabPage2.Controls.Add(this.metroLabel9);
            this.metroTabPage2.Controls.Add(this.dateofBirth);
            this.metroTabPage2.Controls.Add(this.gener);
            this.metroTabPage2.Controls.Add(this.email);
            this.metroTabPage2.Controls.Add(this.phone);
            this.metroTabPage2.Controls.Add(this.cnh);
            this.metroTabPage2.Controls.Add(this.cpf);
            this.metroTabPage2.Controls.Add(this.user);
            this.metroTabPage2.Controls.Add(this.name);
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
            this.metroTabPage2.Size = new System.Drawing.Size(866, 363);
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
            this.metroLinkVoltar.Location = new System.Drawing.Point(697, 309);
            this.metroLinkVoltar.Name = "metroLinkVoltar";
            this.metroLinkVoltar.Size = new System.Drawing.Size(46, 43);
            this.metroLinkVoltar.TabIndex = 24;
            this.metroLinkVoltar.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroToolTip1.SetToolTip(this.metroLinkVoltar, "Voltar");
            this.metroLinkVoltar.UseSelectable = true;
            this.metroLinkVoltar.Click += new System.EventHandler(this.metroLinkVoltar_Click);
            // 
            // metroLinkSalvar
            // 
            this.metroLinkSalvar.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.metroLinkSalvar.ForeColor = System.Drawing.Color.Black;
            this.metroLinkSalvar.Image = ((System.Drawing.Image)(resources.GetObject("metroLinkSalvar.Image")));
            this.metroLinkSalvar.ImageSize = 40;
            this.metroLinkSalvar.Location = new System.Drawing.Point(749, 309);
            this.metroLinkSalvar.Name = "metroLinkSalvar";
            this.metroLinkSalvar.Size = new System.Drawing.Size(50, 43);
            this.metroLinkSalvar.Style = MetroFramework.MetroColorStyle.Orange;
            this.metroLinkSalvar.TabIndex = 25;
            this.metroLinkSalvar.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroToolTip1.SetToolTip(this.metroLinkSalvar, "Salvar");
            this.metroLinkSalvar.UseSelectable = true;
            this.metroLinkSalvar.Click += new System.EventHandler(this.metroLinkSalvar_Click);
            // 
            // password
            // 
            // 
            // 
            // 
            this.password.CustomButton.Image = null;
            this.password.CustomButton.Location = new System.Drawing.Point(109, 1);
            this.password.CustomButton.Name = "";
            this.password.CustomButton.Size = new System.Drawing.Size(27, 27);
            this.password.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.password.CustomButton.TabIndex = 1;
            this.password.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.password.CustomButton.UseSelectable = true;
            this.password.CustomButton.Visible = false;
            this.password.Lines = new string[0];
            this.password.Location = new System.Drawing.Point(194, 133);
            this.password.MaxLength = 32767;
            this.password.Multiline = true;
            this.password.Name = "password";
            this.password.PasswordChar = '\0';
            this.password.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.password.SelectedText = "";
            this.password.SelectionLength = 0;
            this.password.SelectionStart = 0;
            this.password.ShortcutsEnabled = true;
            this.password.Size = new System.Drawing.Size(137, 29);
            this.password.TabIndex = 43;
            this.password.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.password.UseSelectable = true;
            this.password.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.password.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
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
            // validateCNHdate
            // 
            this.validateCNHdate.Location = new System.Drawing.Point(392, 209);
            this.validateCNHdate.MinimumSize = new System.Drawing.Size(4, 29);
            this.validateCNHdate.Name = "validateCNHdate";
            this.validateCNHdate.Size = new System.Drawing.Size(223, 29);
            this.validateCNHdate.TabIndex = 41;
            this.validateCNHdate.Theme = MetroFramework.MetroThemeStyle.Dark;
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
            // dateofBirth
            // 
            this.dateofBirth.Location = new System.Drawing.Point(503, 133);
            this.dateofBirth.MinimumSize = new System.Drawing.Size(4, 29);
            this.dateofBirth.Name = "dateofBirth";
            this.dateofBirth.Size = new System.Drawing.Size(223, 29);
            this.dateofBirth.TabIndex = 38;
            this.dateofBirth.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // gener
            // 
            this.gener.FormattingEnabled = true;
            this.gener.ItemHeight = 23;
            this.gener.Items.AddRange(new object[] {
            "Feminino",
            "Masculino",
            "Prefiro não mencionar"});
            this.gener.Location = new System.Drawing.Point(32, 209);
            this.gener.Name = "gener";
            this.gener.Size = new System.Drawing.Size(210, 29);
            this.gener.TabIndex = 37;
            this.gener.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.gener.UseSelectable = true;
            // 
            // email
            // 
            // 
            // 
            // 
            this.email.CustomButton.Image = null;
            this.email.CustomButton.Location = new System.Drawing.Point(174, 1);
            this.email.CustomButton.Name = "";
            this.email.CustomButton.Size = new System.Drawing.Size(27, 27);
            this.email.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.email.CustomButton.TabIndex = 1;
            this.email.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.email.CustomButton.UseSelectable = true;
            this.email.CustomButton.Visible = false;
            this.email.Lines = new string[0];
            this.email.Location = new System.Drawing.Point(337, 58);
            this.email.MaxLength = 32767;
            this.email.Multiline = true;
            this.email.Name = "email";
            this.email.PasswordChar = '\0';
            this.email.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.email.SelectedText = "";
            this.email.SelectionLength = 0;
            this.email.SelectionStart = 0;
            this.email.ShortcutsEnabled = true;
            this.email.Size = new System.Drawing.Size(202, 29);
            this.email.TabIndex = 36;
            this.email.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.email.UseSelectable = true;
            this.email.WaterMark = "exemplo@email.com";
            this.email.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.email.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // phone
            // 
            // 
            // 
            // 
            this.phone.CustomButton.Image = null;
            this.phone.CustomButton.Location = new System.Drawing.Point(89, 1);
            this.phone.CustomButton.Name = "";
            this.phone.CustomButton.Size = new System.Drawing.Size(27, 27);
            this.phone.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.phone.CustomButton.TabIndex = 1;
            this.phone.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.phone.CustomButton.UseSelectable = true;
            this.phone.CustomButton.Visible = false;
            this.phone.Lines = new string[0];
            this.phone.Location = new System.Drawing.Point(359, 133);
            this.phone.MaxLength = 32767;
            this.phone.Multiline = true;
            this.phone.Name = "phone";
            this.phone.PasswordChar = '\0';
            this.phone.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.phone.SelectedText = "";
            this.phone.SelectionLength = 0;
            this.phone.SelectionStart = 0;
            this.phone.ShortcutsEnabled = true;
            this.phone.Size = new System.Drawing.Size(117, 29);
            this.phone.TabIndex = 35;
            this.phone.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.phone.UseSelectable = true;
            this.phone.WaterMark = "(35) X XXXX-XXXX";
            this.phone.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.phone.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // cnh
            // 
            // 
            // 
            // 
            this.cnh.CustomButton.Image = null;
            this.cnh.CustomButton.Location = new System.Drawing.Point(72, 1);
            this.cnh.CustomButton.Name = "";
            this.cnh.CustomButton.Size = new System.Drawing.Size(27, 27);
            this.cnh.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.cnh.CustomButton.TabIndex = 1;
            this.cnh.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.cnh.CustomButton.UseSelectable = true;
            this.cnh.CustomButton.Visible = false;
            this.cnh.Lines = new string[0];
            this.cnh.Location = new System.Drawing.Point(261, 209);
            this.cnh.MaxLength = 32767;
            this.cnh.Multiline = true;
            this.cnh.Name = "cnh";
            this.cnh.PasswordChar = '\0';
            this.cnh.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.cnh.SelectedText = "";
            this.cnh.SelectionLength = 0;
            this.cnh.SelectionStart = 0;
            this.cnh.ShortcutsEnabled = true;
            this.cnh.Size = new System.Drawing.Size(100, 29);
            this.cnh.TabIndex = 34;
            this.cnh.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.cnh.UseSelectable = true;
            this.cnh.WaterMark = "XXXXXXXXXXX";
            this.cnh.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.cnh.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // cpf
            // 
            // 
            // 
            // 
            this.cpf.CustomButton.Image = null;
            this.cpf.CustomButton.Location = new System.Drawing.Point(141, 1);
            this.cpf.CustomButton.Name = "";
            this.cpf.CustomButton.Size = new System.Drawing.Size(27, 27);
            this.cpf.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.cpf.CustomButton.TabIndex = 1;
            this.cpf.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.cpf.CustomButton.UseSelectable = true;
            this.cpf.CustomButton.Visible = false;
            this.cpf.Lines = new string[0];
            this.cpf.Location = new System.Drawing.Point(556, 58);
            this.cpf.MaxLength = 32767;
            this.cpf.Multiline = true;
            this.cpf.Name = "cpf";
            this.cpf.PasswordChar = '\0';
            this.cpf.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.cpf.SelectedText = "";
            this.cpf.SelectionLength = 0;
            this.cpf.SelectionStart = 0;
            this.cpf.ShortcutsEnabled = true;
            this.cpf.Size = new System.Drawing.Size(169, 29);
            this.cpf.TabIndex = 33;
            this.cpf.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.cpf.UseSelectable = true;
            this.cpf.WaterMark = "XXX.XXX.XXX-XX";
            this.cpf.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.cpf.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // user
            // 
            // 
            // 
            // 
            this.user.CustomButton.Image = null;
            this.user.CustomButton.Location = new System.Drawing.Point(115, 1);
            this.user.CustomButton.Name = "";
            this.user.CustomButton.Size = new System.Drawing.Size(27, 27);
            this.user.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.user.CustomButton.TabIndex = 1;
            this.user.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.user.CustomButton.UseSelectable = true;
            this.user.CustomButton.Visible = false;
            this.user.Lines = new string[0];
            this.user.Location = new System.Drawing.Point(32, 133);
            this.user.MaxLength = 32767;
            this.user.Multiline = true;
            this.user.Name = "user";
            this.user.PasswordChar = '\0';
            this.user.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.user.SelectedText = "";
            this.user.SelectionLength = 0;
            this.user.SelectionStart = 0;
            this.user.ShortcutsEnabled = true;
            this.user.Size = new System.Drawing.Size(143, 29);
            this.user.TabIndex = 32;
            this.user.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.user.UseSelectable = true;
            this.user.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.user.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // name
            // 
            // 
            // 
            // 
            this.name.CustomButton.Image = null;
            this.name.CustomButton.Location = new System.Drawing.Point(258, 1);
            this.name.CustomButton.Name = "";
            this.name.CustomButton.Size = new System.Drawing.Size(27, 27);
            this.name.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.name.CustomButton.TabIndex = 1;
            this.name.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.name.CustomButton.UseSelectable = true;
            this.name.CustomButton.Visible = false;
            this.name.Lines = new string[0];
            this.name.Location = new System.Drawing.Point(31, 58);
            this.name.MaxLength = 32767;
            this.name.Multiline = true;
            this.name.Name = "name";
            this.name.PasswordChar = '\0';
            this.name.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.name.SelectedText = "";
            this.name.SelectionLength = 0;
            this.name.SelectionStart = 0;
            this.name.ShortcutsEnabled = true;
            this.name.Size = new System.Drawing.Size(286, 29);
            this.name.TabIndex = 31;
            this.name.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.name.UseSelectable = true;
            this.name.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.name.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
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
            // clientCNHTableAdapter
            // 
            this.clientCNHTableAdapter.ClearBeforeFill = true;
            // 
            // metroToolTip1
            // 
            this.metroToolTip1.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroToolTip1.StyleManager = null;
            this.metroToolTip1.Theme = MetroFramework.MetroThemeStyle.Light;
            // 
            // rentLink
            // 
            this.rentLink.Image = ((System.Drawing.Image)(resources.GetObject("rentLink.Image")));
            this.rentLink.ImageSize = 45;
            this.rentLink.Location = new System.Drawing.Point(812, 40);
            this.rentLink.Name = "rentLink";
            this.rentLink.Size = new System.Drawing.Size(55, 52);
            this.rentLink.TabIndex = 1;
            this.rentLink.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroToolTip1.SetToolTip(this.rentLink, "Abrir novo aluguel");
            this.rentLink.UseSelectable = true;
            this.rentLink.Click += new System.EventHandler(this.rentLink_Click);
            // 
            // Clientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackImage = ((System.Drawing.Image)(resources.GetObject("$this.BackImage")));
            this.BackImagePadding = new System.Windows.Forms.Padding(-19, 6, -1, -1);
            this.BackMaxSize = 210;
            this.ClientSize = new System.Drawing.Size(914, 485);
            this.Controls.Add(this.rentLink);
            this.Controls.Add(this.metroTabControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Clientes";
            this.Resizable = false;
            this.Style = MetroFramework.MetroColorStyle.Orange;
            this.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.Load += new System.EventHandler(this.Clientes_Load);
            this.metroTabControl1.ResumeLayout(false);
            this.metroTabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.metroGrid1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientCNHBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.client)).EndInit();
            this.metroTabPage2.ResumeLayout(false);
            this.metroTabPage2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroTabControl metroTabControl1;
        private MetroFramework.Controls.MetroTabPage metroTabPage1;
        private MetroFramework.Controls.MetroTabPage metroTabPage2;
        private MetroFramework.Controls.MetroTextBox password;
        private MetroFramework.Controls.MetroLabel metroLabel10;
        private MetroFramework.Controls.MetroDateTime validateCNHdate;
        private MetroFramework.Controls.MetroLabel metroLabel9;
        private MetroFramework.Controls.MetroDateTime dateofBirth;
        private MetroFramework.Controls.MetroComboBox gener;
        private MetroFramework.Controls.MetroTextBox email;
        private MetroFramework.Controls.MetroTextBox phone;
        private MetroFramework.Controls.MetroTextBox cnh;
        private MetroFramework.Controls.MetroTextBox cpf;
        private MetroFramework.Controls.MetroTextBox user;
        private MetroFramework.Controls.MetroTextBox name;
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
        private CarLand.DataSets.Paulo.Client client;
        private System.Windows.Forms.BindingSource clientCNHBindingSource;
        private CarLand.DataSets.Paulo.ClientTableAdapters.ClientCNHTableAdapter clientCNHTableAdapter;
        private MetroFramework.Components.MetroToolTip metroToolTip1;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomeClienteDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn aniversárioDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn telefoneDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn generoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cNHDataGridViewTextBoxColumn;
        private MetroFramework.Controls.MetroLink rentLink;
    }
}