namespace CarLand.Forms
{
    partial class Funcionarios
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Funcionarios));
            this.metroTabControl1 = new MetroFramework.Controls.MetroTabControl();
            this.metroTabPage1 = new MetroFramework.Controls.MetroTabPage();
            this.metroGrid1 = new MetroFramework.Controls.MetroGrid();
            this.idEmployeeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.employeeNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idUserDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.employeeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.listFuncionarios = new CarLand.ListFuncionarios();
            this.metroTabPage2 = new MetroFramework.Controls.MetroTabPage();
            this.mtxtSenha = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel13 = new MetroFramework.Controls.MetroLabel();
            this.mtxtUsuario = new MetroFramework.Controls.MetroTextBox();
            this.mtxtNome = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel11 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel12 = new MetroFramework.Controls.MetroLabel();
            this.metroLinkVoltar = new MetroFramework.Controls.MetroLink();
            this.metroLinkSalvar = new MetroFramework.Controls.MetroLink();
            this.employeeTableAdapter = new CarLand.ListFuncionariosTableAdapters.EmployeeTableAdapter();
            this.metroTabControl1.SuspendLayout();
            this.metroTabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.metroGrid1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.listFuncionarios)).BeginInit();
            this.metroTabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // metroTabControl1
            // 
            this.metroTabControl1.Controls.Add(this.metroTabPage1);
            this.metroTabControl1.Controls.Add(this.metroTabPage2);
            this.metroTabControl1.Location = new System.Drawing.Point(16, 78);
            this.metroTabControl1.Name = "metroTabControl1";
            this.metroTabControl1.SelectedIndex = 0;
            this.metroTabControl1.Size = new System.Drawing.Size(480, 291);
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
            this.metroTabPage1.Size = new System.Drawing.Size(472, 249);
            this.metroTabPage1.TabIndex = 0;
            this.metroTabPage1.Text = "Lista de Funcionários";
            this.metroTabPage1.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroTabPage1.VerticalScrollbarBarColor = true;
            this.metroTabPage1.VerticalScrollbarHighlightOnWheel = false;
            this.metroTabPage1.VerticalScrollbarSize = 10;
            this.metroTabPage1.Click += new System.EventHandler(this.metroTabPage1_Click);
            // 
            // metroGrid1
            // 
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
            this.idEmployeeDataGridViewTextBoxColumn,
            this.employeeNameDataGridViewTextBoxColumn,
            this.idUserDataGridViewTextBoxColumn});
            this.metroGrid1.DataSource = this.employeeBindingSource;
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
            this.metroGrid1.Location = new System.Drawing.Point(27, 20);
            this.metroGrid1.Name = "metroGrid1";
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
            this.metroGrid1.Size = new System.Drawing.Size(410, 257);
            this.metroGrid1.Style = MetroFramework.MetroColorStyle.Orange;
            this.metroGrid1.TabIndex = 2;
            this.metroGrid1.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // idEmployeeDataGridViewTextBoxColumn
            // 
            this.idEmployeeDataGridViewTextBoxColumn.DataPropertyName = "idEmployee";
            this.idEmployeeDataGridViewTextBoxColumn.HeaderText = "idEmployee";
            this.idEmployeeDataGridViewTextBoxColumn.Name = "idEmployeeDataGridViewTextBoxColumn";
            this.idEmployeeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // employeeNameDataGridViewTextBoxColumn
            // 
            this.employeeNameDataGridViewTextBoxColumn.DataPropertyName = "EmployeeName";
            this.employeeNameDataGridViewTextBoxColumn.HeaderText = "EmployeeName";
            this.employeeNameDataGridViewTextBoxColumn.Name = "employeeNameDataGridViewTextBoxColumn";
            // 
            // idUserDataGridViewTextBoxColumn
            // 
            this.idUserDataGridViewTextBoxColumn.DataPropertyName = "idUser";
            this.idUserDataGridViewTextBoxColumn.HeaderText = "idUser";
            this.idUserDataGridViewTextBoxColumn.Name = "idUserDataGridViewTextBoxColumn";
            // 
            // employeeBindingSource
            // 
            this.employeeBindingSource.DataMember = "Employee";
            this.employeeBindingSource.DataSource = this.listFuncionarios;
            // 
            // listFuncionarios
            // 
            this.listFuncionarios.DataSetName = "ListFuncionarios";
            this.listFuncionarios.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // metroTabPage2
            // 
            this.metroTabPage2.Controls.Add(this.mtxtSenha);
            this.metroTabPage2.Controls.Add(this.metroLabel13);
            this.metroTabPage2.Controls.Add(this.mtxtUsuario);
            this.metroTabPage2.Controls.Add(this.mtxtNome);
            this.metroTabPage2.Controls.Add(this.metroLabel11);
            this.metroTabPage2.Controls.Add(this.metroLabel12);
            this.metroTabPage2.HorizontalScrollbarBarColor = true;
            this.metroTabPage2.HorizontalScrollbarHighlightOnWheel = false;
            this.metroTabPage2.HorizontalScrollbarSize = 10;
            this.metroTabPage2.Location = new System.Drawing.Point(4, 38);
            this.metroTabPage2.Name = "metroTabPage2";
            this.metroTabPage2.Size = new System.Drawing.Size(472, 249);
            this.metroTabPage2.TabIndex = 1;
            this.metroTabPage2.Text = "Novo";
            this.metroTabPage2.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroTabPage2.VerticalScrollbarBarColor = true;
            this.metroTabPage2.VerticalScrollbarHighlightOnWheel = false;
            this.metroTabPage2.VerticalScrollbarSize = 10;
            // 
            // mtxtSenha
            // 
            // 
            // 
            // 
            this.mtxtSenha.CustomButton.Image = null;
            this.mtxtSenha.CustomButton.Location = new System.Drawing.Point(174, 2);
            this.mtxtSenha.CustomButton.Name = "";
            this.mtxtSenha.CustomButton.Size = new System.Drawing.Size(19, 19);
            this.mtxtSenha.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.mtxtSenha.CustomButton.TabIndex = 1;
            this.mtxtSenha.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.mtxtSenha.CustomButton.UseSelectable = true;
            this.mtxtSenha.CustomButton.Visible = false;
            this.mtxtSenha.Lines = new string[0];
            this.mtxtSenha.Location = new System.Drawing.Point(256, 131);
            this.mtxtSenha.MaxLength = 32767;
            this.mtxtSenha.Name = "mtxtSenha";
            this.mtxtSenha.PasswordChar = '\0';
            this.mtxtSenha.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.mtxtSenha.SelectedText = "";
            this.mtxtSenha.SelectionLength = 0;
            this.mtxtSenha.SelectionStart = 0;
            this.mtxtSenha.ShortcutsEnabled = true;
            this.mtxtSenha.Size = new System.Drawing.Size(196, 24);
            this.mtxtSenha.Style = MetroFramework.MetroColorStyle.Orange;
            this.mtxtSenha.TabIndex = 31;
            this.mtxtSenha.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.mtxtSenha.UseSelectable = true;
            this.mtxtSenha.UseStyleColors = true;
            this.mtxtSenha.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.mtxtSenha.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel13
            // 
            this.metroLabel13.AutoSize = true;
            this.metroLabel13.BackColor = System.Drawing.Color.Transparent;
            this.metroLabel13.Location = new System.Drawing.Point(256, 109);
            this.metroLabel13.Name = "metroLabel13";
            this.metroLabel13.Size = new System.Drawing.Size(47, 19);
            this.metroLabel13.TabIndex = 30;
            this.metroLabel13.Text = "Senha:";
            this.metroLabel13.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroLabel13.Click += new System.EventHandler(this.metroLabel13_Click);
            // 
            // mtxtUsuario
            // 
            // 
            // 
            // 
            this.mtxtUsuario.CustomButton.Image = null;
            this.mtxtUsuario.CustomButton.Location = new System.Drawing.Point(176, 2);
            this.mtxtUsuario.CustomButton.Name = "";
            this.mtxtUsuario.CustomButton.Size = new System.Drawing.Size(19, 19);
            this.mtxtUsuario.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.mtxtUsuario.CustomButton.TabIndex = 1;
            this.mtxtUsuario.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.mtxtUsuario.CustomButton.UseSelectable = true;
            this.mtxtUsuario.CustomButton.Visible = false;
            this.mtxtUsuario.Lines = new string[0];
            this.mtxtUsuario.Location = new System.Drawing.Point(24, 131);
            this.mtxtUsuario.MaxLength = 32767;
            this.mtxtUsuario.Name = "mtxtUsuario";
            this.mtxtUsuario.PasswordChar = '\0';
            this.mtxtUsuario.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.mtxtUsuario.SelectedText = "";
            this.mtxtUsuario.SelectionLength = 0;
            this.mtxtUsuario.SelectionStart = 0;
            this.mtxtUsuario.ShortcutsEnabled = true;
            this.mtxtUsuario.Size = new System.Drawing.Size(198, 24);
            this.mtxtUsuario.Style = MetroFramework.MetroColorStyle.Orange;
            this.mtxtUsuario.TabIndex = 29;
            this.mtxtUsuario.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.mtxtUsuario.UseSelectable = true;
            this.mtxtUsuario.UseStyleColors = true;
            this.mtxtUsuario.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.mtxtUsuario.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // mtxtNome
            // 
            // 
            // 
            // 
            this.mtxtNome.CustomButton.Image = null;
            this.mtxtNome.CustomButton.Location = new System.Drawing.Point(406, 2);
            this.mtxtNome.CustomButton.Name = "";
            this.mtxtNome.CustomButton.Size = new System.Drawing.Size(19, 19);
            this.mtxtNome.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.mtxtNome.CustomButton.TabIndex = 1;
            this.mtxtNome.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.mtxtNome.CustomButton.UseSelectable = true;
            this.mtxtNome.CustomButton.Visible = false;
            this.mtxtNome.Lines = new string[0];
            this.mtxtNome.Location = new System.Drawing.Point(24, 42);
            this.mtxtNome.MaxLength = 32767;
            this.mtxtNome.Name = "mtxtNome";
            this.mtxtNome.PasswordChar = '\0';
            this.mtxtNome.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.mtxtNome.SelectedText = "";
            this.mtxtNome.SelectionLength = 0;
            this.mtxtNome.SelectionStart = 0;
            this.mtxtNome.ShortcutsEnabled = true;
            this.mtxtNome.Size = new System.Drawing.Size(428, 24);
            this.mtxtNome.Style = MetroFramework.MetroColorStyle.Orange;
            this.mtxtNome.TabIndex = 28;
            this.mtxtNome.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.mtxtNome.UseSelectable = true;
            this.mtxtNome.UseStyleColors = true;
            this.mtxtNome.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.mtxtNome.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel11
            // 
            this.metroLabel11.AutoSize = true;
            this.metroLabel11.BackColor = System.Drawing.Color.Transparent;
            this.metroLabel11.Location = new System.Drawing.Point(24, 109);
            this.metroLabel11.Name = "metroLabel11";
            this.metroLabel11.Size = new System.Drawing.Size(56, 19);
            this.metroLabel11.TabIndex = 27;
            this.metroLabel11.Text = "Usuário:";
            this.metroLabel11.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // metroLabel12
            // 
            this.metroLabel12.AutoSize = true;
            this.metroLabel12.BackColor = System.Drawing.Color.Transparent;
            this.metroLabel12.Location = new System.Drawing.Point(24, 20);
            this.metroLabel12.Name = "metroLabel12";
            this.metroLabel12.Size = new System.Drawing.Size(49, 19);
            this.metroLabel12.TabIndex = 26;
            this.metroLabel12.Text = "Nome:";
            this.metroLabel12.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // metroLinkVoltar
            // 
            this.metroLinkVoltar.Image = ((System.Drawing.Image)(resources.GetObject("metroLinkVoltar.Image")));
            this.metroLinkVoltar.ImageSize = 39;
            this.metroLinkVoltar.Location = new System.Drawing.Point(430, 35);
            this.metroLinkVoltar.Name = "metroLinkVoltar";
            this.metroLinkVoltar.Size = new System.Drawing.Size(66, 57);
            this.metroLinkVoltar.TabIndex = 26;
            this.metroLinkVoltar.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroLinkVoltar.UseSelectable = true;
            // 
            // metroLinkSalvar
            // 
            this.metroLinkSalvar.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.metroLinkSalvar.ForeColor = System.Drawing.Color.Black;
            this.metroLinkSalvar.Image = ((System.Drawing.Image)(resources.GetObject("metroLinkSalvar.Image")));
            this.metroLinkSalvar.ImageSize = 35;
            this.metroLinkSalvar.Location = new System.Drawing.Point(379, 35);
            this.metroLinkSalvar.Name = "metroLinkSalvar";
            this.metroLinkSalvar.Size = new System.Drawing.Size(59, 57);
            this.metroLinkSalvar.Style = MetroFramework.MetroColorStyle.Orange;
            this.metroLinkSalvar.TabIndex = 27;
            this.metroLinkSalvar.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroLinkSalvar.UseSelectable = true;
            // 
            // employeeTableAdapter
            // 
            this.employeeTableAdapter.ClearBeforeFill = true;
            // 
            // Funcionarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackImage = ((System.Drawing.Image)(resources.GetObject("$this.BackImage")));
            this.BackImagePadding = new System.Windows.Forms.Padding(-22, 11, -1, -1);
            this.BackMaxSize = 210;
            this.ClientSize = new System.Drawing.Size(520, 416);
            this.Controls.Add(this.metroLinkVoltar);
            this.Controls.Add(this.metroLinkSalvar);
            this.Controls.Add(this.metroTabControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Funcionarios";
            this.Style = MetroFramework.MetroColorStyle.Orange;
            this.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.Load += new System.EventHandler(this.Funcionarios_Load);
            this.metroTabControl1.ResumeLayout(false);
            this.metroTabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.metroGrid1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.listFuncionarios)).EndInit();
            this.metroTabPage2.ResumeLayout(false);
            this.metroTabPage2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroTabControl metroTabControl1;
        private MetroFramework.Controls.MetroTabPage metroTabPage1;
        private MetroFramework.Controls.MetroTabPage metroTabPage2;
        private MetroFramework.Controls.MetroGrid metroGrid1;
        private MetroFramework.Controls.MetroTextBox mtxtSenha;
        private MetroFramework.Controls.MetroLabel metroLabel13;
        private MetroFramework.Controls.MetroTextBox mtxtUsuario;
        private MetroFramework.Controls.MetroTextBox mtxtNome;
        private MetroFramework.Controls.MetroLabel metroLabel11;
        private MetroFramework.Controls.MetroLabel metroLabel12;
        private MetroFramework.Controls.MetroLink metroLinkVoltar;
        private MetroFramework.Controls.MetroLink metroLinkSalvar;
        private ListFuncionarios listFuncionarios;
        private System.Windows.Forms.BindingSource employeeBindingSource;
        private ListFuncionariosTableAdapters.EmployeeTableAdapter employeeTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idEmployeeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn employeeNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idUserDataGridViewTextBoxColumn;
    }
}