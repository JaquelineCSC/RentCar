namespace CarLand.Forms
{
    partial class Completar_Cadastro
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
            this.dateValidateCNH = new MetroFramework.Controls.MetroDateTime();
            this.metroLabel9 = new MetroFramework.Controls.MetroLabel();
            this.iAgreeCheck = new MetroFramework.Controls.MetroCheckBox();
            this.dateOfBirth = new MetroFramework.Controls.MetroDateTime();
            this.genero = new MetroFramework.Controls.MetroComboBox();
            this.email = new MetroFramework.Controls.MetroTextBox();
            this.telefone = new MetroFramework.Controls.MetroTextBox();
            this.cnh = new MetroFramework.Controls.MetroTextBox();
            this.cpf = new MetroFramework.Controls.MetroTextBox();
            this.name = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel8 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel7 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel6 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.buttonSave = new MetroFramework.Controls.MetroButton();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel10 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel11 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel12 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel13 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel14 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel15 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel16 = new MetroFramework.Controls.MetroLabel();
            this.manager = new MetroFramework.Components.MetroStyleManager(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.manager)).BeginInit();
            this.SuspendLayout();
            // 
            // dateValidateCNH
            // 
            this.dateValidateCNH.Location = new System.Drawing.Point(264, 264);
            this.dateValidateCNH.MinimumSize = new System.Drawing.Size(0, 29);
            this.dateValidateCNH.Name = "dateValidateCNH";
            this.dateValidateCNH.Size = new System.Drawing.Size(223, 29);
            this.dateValidateCNH.Style = MetroFramework.MetroColorStyle.Orange;
            this.dateValidateCNH.TabIndex = 60;
            this.dateValidateCNH.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.dateValidateCNH.UseStyleColors = true;
            this.dateValidateCNH.ValueChanged += new System.EventHandler(this.verificarPreenchimento);
            // 
            // metroLabel9
            // 
            this.metroLabel9.AutoSize = true;
            this.metroLabel9.BackColor = System.Drawing.Color.Transparent;
            this.metroLabel9.Location = new System.Drawing.Point(264, 242);
            this.metroLabel9.Name = "metroLabel9";
            this.metroLabel9.Size = new System.Drawing.Size(143, 19);
            this.metroLabel9.TabIndex = 59;
            this.metroLabel9.Text = "Data de Validade CNH:";
            this.metroLabel9.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // iAgreeCheck
            // 
            this.iAgreeCheck.AutoSize = true;
            this.iAgreeCheck.Location = new System.Drawing.Point(68, 355);
            this.iAgreeCheck.Name = "iAgreeCheck";
            this.iAgreeCheck.Size = new System.Drawing.Size(394, 15);
            this.iAgreeCheck.Style = MetroFramework.MetroColorStyle.Orange;
            this.iAgreeCheck.TabIndex = 58;
            this.iAgreeCheck.Text = "Li, entendi e concordo com os Termos de Uso e Política de Privacidade";
            this.iAgreeCheck.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.iAgreeCheck.UseSelectable = true;
            this.iAgreeCheck.UseStyleColors = true;
            this.iAgreeCheck.Click += new System.EventHandler(this.verificarPreenchimento);
            // 
            // dateOfBirth
            // 
            this.dateOfBirth.Location = new System.Drawing.Point(554, 110);
            this.dateOfBirth.MinimumSize = new System.Drawing.Size(0, 29);
            this.dateOfBirth.Name = "dateOfBirth";
            this.dateOfBirth.Size = new System.Drawing.Size(223, 29);
            this.dateOfBirth.Style = MetroFramework.MetroColorStyle.Orange;
            this.dateOfBirth.TabIndex = 57;
            this.dateOfBirth.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.dateOfBirth.UseStyleColors = true;
            this.dateOfBirth.ValueChanged += new System.EventHandler(this.verificarPreenchimento);
            // 
            // genero
            // 
            this.genero.FormattingEnabled = true;
            this.genero.ItemHeight = 23;
            this.genero.Items.AddRange(new object[] {
            "Masculino",
            "Feminino",
            "Prefiro não mencionar"});
            this.genero.Location = new System.Drawing.Point(465, 187);
            this.genero.Name = "genero";
            this.genero.Size = new System.Drawing.Size(180, 29);
            this.genero.Style = MetroFramework.MetroColorStyle.Orange;
            this.genero.TabIndex = 56;
            this.genero.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.genero.UseSelectable = true;
            this.genero.UseStyleColors = true;
            this.genero.SelectedIndexChanged += new System.EventHandler(this.verificarPreenchimento);
            // 
            // email
            // 
            // 
            // 
            // 
            this.email.CustomButton.Image = null;
            this.email.CustomButton.Location = new System.Drawing.Point(195, 1);
            this.email.CustomButton.Name = "";
            this.email.CustomButton.Size = new System.Drawing.Size(27, 27);
            this.email.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.email.CustomButton.TabIndex = 1;
            this.email.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.email.CustomButton.UseSelectable = true;
            this.email.CustomButton.Visible = false;
            this.email.Lines = new string[0];
            this.email.Location = new System.Drawing.Point(311, 110);
            this.email.MaxLength = 32767;
            this.email.Multiline = true;
            this.email.Name = "email";
            this.email.PasswordChar = '\0';
            this.email.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.email.SelectedText = "";
            this.email.SelectionLength = 0;
            this.email.SelectionStart = 0;
            this.email.ShortcutsEnabled = true;
            this.email.Size = new System.Drawing.Size(223, 29);
            this.email.Style = MetroFramework.MetroColorStyle.Orange;
            this.email.TabIndex = 55;
            this.email.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.email.UseSelectable = true;
            this.email.UseStyleColors = true;
            this.email.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.email.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.email.TextChanged += new System.EventHandler(this.verificarPreenchimento);
            // 
            // telefone
            // 
            // 
            // 
            // 
            this.telefone.CustomButton.Image = null;
            this.telefone.CustomButton.Location = new System.Drawing.Point(123, 1);
            this.telefone.CustomButton.Name = "";
            this.telefone.CustomButton.Size = new System.Drawing.Size(27, 27);
            this.telefone.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.telefone.CustomButton.TabIndex = 1;
            this.telefone.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.telefone.CustomButton.UseSelectable = true;
            this.telefone.CustomButton.Visible = false;
            this.telefone.Lines = new string[0];
            this.telefone.Location = new System.Drawing.Point(279, 187);
            this.telefone.MaxLength = 32767;
            this.telefone.Multiline = true;
            this.telefone.Name = "telefone";
            this.telefone.PasswordChar = '\0';
            this.telefone.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.telefone.SelectedText = "";
            this.telefone.SelectionLength = 0;
            this.telefone.SelectionStart = 0;
            this.telefone.ShortcutsEnabled = true;
            this.telefone.Size = new System.Drawing.Size(151, 29);
            this.telefone.Style = MetroFramework.MetroColorStyle.Orange;
            this.telefone.TabIndex = 54;
            this.telefone.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.telefone.UseSelectable = true;
            this.telefone.UseStyleColors = true;
            this.telefone.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.telefone.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.telefone.TextChanged += new System.EventHandler(this.verificarPreenchimento);
            // 
            // cnh
            // 
            // 
            // 
            // 
            this.cnh.CustomButton.Image = null;
            this.cnh.CustomButton.Location = new System.Drawing.Point(127, 1);
            this.cnh.CustomButton.Name = "";
            this.cnh.CustomButton.Size = new System.Drawing.Size(27, 27);
            this.cnh.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.cnh.CustomButton.TabIndex = 1;
            this.cnh.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.cnh.CustomButton.UseSelectable = true;
            this.cnh.CustomButton.Visible = false;
            this.cnh.Lines = new string[0];
            this.cnh.Location = new System.Drawing.Point(68, 264);
            this.cnh.MaxLength = 32767;
            this.cnh.Multiline = true;
            this.cnh.Name = "cnh";
            this.cnh.PasswordChar = '\0';
            this.cnh.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.cnh.SelectedText = "";
            this.cnh.SelectionLength = 0;
            this.cnh.SelectionStart = 0;
            this.cnh.ShortcutsEnabled = true;
            this.cnh.Size = new System.Drawing.Size(155, 29);
            this.cnh.Style = MetroFramework.MetroColorStyle.Orange;
            this.cnh.TabIndex = 53;
            this.cnh.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.cnh.UseSelectable = true;
            this.cnh.UseStyleColors = true;
            this.cnh.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.cnh.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.cnh.TextChanged += new System.EventHandler(this.verificarPreenchimento);
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
            this.cpf.Location = new System.Drawing.Point(68, 187);
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
            this.cpf.Style = MetroFramework.MetroColorStyle.Orange;
            this.cpf.TabIndex = 52;
            this.cpf.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.cpf.UseSelectable = true;
            this.cpf.UseStyleColors = true;
            this.cpf.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.cpf.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.cpf.TextChanged += new System.EventHandler(this.verificarPreenchimento);
            // 
            // name
            // 
            // 
            // 
            // 
            this.name.CustomButton.Image = null;
            this.name.CustomButton.Location = new System.Drawing.Point(195, 1);
            this.name.CustomButton.Name = "";
            this.name.CustomButton.Size = new System.Drawing.Size(27, 27);
            this.name.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.name.CustomButton.TabIndex = 1;
            this.name.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.name.CustomButton.UseSelectable = true;
            this.name.CustomButton.Visible = false;
            this.name.Lines = new string[0];
            this.name.Location = new System.Drawing.Point(68, 110);
            this.name.MaxLength = 32767;
            this.name.Multiline = true;
            this.name.Name = "name";
            this.name.PasswordChar = '\0';
            this.name.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.name.SelectedText = "";
            this.name.SelectionLength = 0;
            this.name.SelectionStart = 0;
            this.name.ShortcutsEnabled = true;
            this.name.Size = new System.Drawing.Size(223, 29);
            this.name.Style = MetroFramework.MetroColorStyle.Orange;
            this.name.TabIndex = 51;
            this.name.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.name.UseSelectable = true;
            this.name.UseStyleColors = true;
            this.name.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.name.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.name.TextChanged += new System.EventHandler(this.verificarPreenchimento);
            // 
            // metroLabel8
            // 
            this.metroLabel8.AutoSize = true;
            this.metroLabel8.BackColor = System.Drawing.Color.Transparent;
            this.metroLabel8.Location = new System.Drawing.Point(465, 165);
            this.metroLabel8.Name = "metroLabel8";
            this.metroLabel8.Size = new System.Drawing.Size(55, 19);
            this.metroLabel8.TabIndex = 50;
            this.metroLabel8.Text = "Gênero:";
            this.metroLabel8.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // metroLabel7
            // 
            this.metroLabel7.AutoSize = true;
            this.metroLabel7.BackColor = System.Drawing.Color.Transparent;
            this.metroLabel7.Location = new System.Drawing.Point(311, 88);
            this.metroLabel7.Name = "metroLabel7";
            this.metroLabel7.Size = new System.Drawing.Size(50, 19);
            this.metroLabel7.TabIndex = 49;
            this.metroLabel7.Text = "E-mail:";
            this.metroLabel7.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // metroLabel6
            // 
            this.metroLabel6.AutoSize = true;
            this.metroLabel6.BackColor = System.Drawing.Color.Transparent;
            this.metroLabel6.Location = new System.Drawing.Point(279, 165);
            this.metroLabel6.Name = "metroLabel6";
            this.metroLabel6.Size = new System.Drawing.Size(60, 19);
            this.metroLabel6.TabIndex = 48;
            this.metroLabel6.Text = "Telefone:";
            this.metroLabel6.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.BackColor = System.Drawing.Color.Transparent;
            this.metroLabel5.Location = new System.Drawing.Point(554, 88);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(131, 19);
            this.metroLabel5.TabIndex = 47;
            this.metroLabel5.Text = "Data de Nascimento:";
            this.metroLabel5.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.BackColor = System.Drawing.Color.Transparent;
            this.metroLabel4.Location = new System.Drawing.Point(68, 242);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(40, 19);
            this.metroLabel4.TabIndex = 46;
            this.metroLabel4.Text = "CNH:";
            this.metroLabel4.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.BackColor = System.Drawing.Color.Transparent;
            this.metroLabel3.Location = new System.Drawing.Point(68, 165);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(36, 19);
            this.metroLabel3.TabIndex = 45;
            this.metroLabel3.Text = "CPF:";
            this.metroLabel3.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.BackColor = System.Drawing.Color.Transparent;
            this.metroLabel1.Location = new System.Drawing.Point(68, 88);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(49, 19);
            this.metroLabel1.TabIndex = 44;
            this.metroLabel1.Text = "Nome:";
            this.metroLabel1.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // buttonSave
            // 
            this.buttonSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.buttonSave.Location = new System.Drawing.Point(612, 325);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(105, 45);
            this.buttonSave.TabIndex = 61;
            this.buttonSave.Text = "Cadastrar";
            this.buttonSave.Theme = MetroFramework.MetroThemeStyle.Light;
            this.buttonSave.UseCustomBackColor = true;
            this.buttonSave.UseSelectable = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.metroLabel2.Location = new System.Drawing.Point(112, 88);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(15, 19);
            this.metroLabel2.TabIndex = 62;
            this.metroLabel2.Text = "*";
            this.metroLabel2.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroLabel2.UseCustomForeColor = true;
            // 
            // metroLabel10
            // 
            this.metroLabel10.AutoSize = true;
            this.metroLabel10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.metroLabel10.Location = new System.Drawing.Point(102, 242);
            this.metroLabel10.Name = "metroLabel10";
            this.metroLabel10.Size = new System.Drawing.Size(15, 19);
            this.metroLabel10.TabIndex = 63;
            this.metroLabel10.Text = "*";
            this.metroLabel10.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroLabel10.UseCustomForeColor = true;
            // 
            // metroLabel11
            // 
            this.metroLabel11.AutoSize = true;
            this.metroLabel11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.metroLabel11.Location = new System.Drawing.Point(102, 165);
            this.metroLabel11.Name = "metroLabel11";
            this.metroLabel11.Size = new System.Drawing.Size(15, 19);
            this.metroLabel11.TabIndex = 64;
            this.metroLabel11.Text = "*";
            this.metroLabel11.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroLabel11.UseCustomForeColor = true;
            // 
            // metroLabel12
            // 
            this.metroLabel12.AutoSize = true;
            this.metroLabel12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.metroLabel12.Location = new System.Drawing.Point(335, 165);
            this.metroLabel12.Name = "metroLabel12";
            this.metroLabel12.Size = new System.Drawing.Size(15, 19);
            this.metroLabel12.TabIndex = 65;
            this.metroLabel12.Text = "*";
            this.metroLabel12.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroLabel12.UseCustomForeColor = true;
            // 
            // metroLabel13
            // 
            this.metroLabel13.AutoSize = true;
            this.metroLabel13.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.metroLabel13.Location = new System.Drawing.Point(519, 165);
            this.metroLabel13.Name = "metroLabel13";
            this.metroLabel13.Size = new System.Drawing.Size(15, 19);
            this.metroLabel13.TabIndex = 66;
            this.metroLabel13.Text = "*";
            this.metroLabel13.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroLabel13.UseCustomForeColor = true;
            // 
            // metroLabel14
            // 
            this.metroLabel14.AutoSize = true;
            this.metroLabel14.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.metroLabel14.Location = new System.Drawing.Point(680, 88);
            this.metroLabel14.Name = "metroLabel14";
            this.metroLabel14.Size = new System.Drawing.Size(15, 19);
            this.metroLabel14.TabIndex = 67;
            this.metroLabel14.Text = "*";
            this.metroLabel14.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroLabel14.UseCustomForeColor = true;
            // 
            // metroLabel15
            // 
            this.metroLabel15.AutoSize = true;
            this.metroLabel15.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.metroLabel15.Location = new System.Drawing.Point(358, 88);
            this.metroLabel15.Name = "metroLabel15";
            this.metroLabel15.Size = new System.Drawing.Size(15, 19);
            this.metroLabel15.TabIndex = 68;
            this.metroLabel15.Text = "*";
            this.metroLabel15.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroLabel15.UseCustomForeColor = true;
            // 
            // metroLabel16
            // 
            this.metroLabel16.AutoSize = true;
            this.metroLabel16.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.metroLabel16.Location = new System.Drawing.Point(403, 242);
            this.metroLabel16.Name = "metroLabel16";
            this.metroLabel16.Size = new System.Drawing.Size(15, 19);
            this.metroLabel16.TabIndex = 69;
            this.metroLabel16.Text = "*";
            this.metroLabel16.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroLabel16.UseCustomForeColor = true;
            // 
            // manager
            // 
            this.manager.Owner = null;
            this.manager.Style = MetroFramework.MetroColorStyle.Orange;
            this.manager.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // Completar_Cadastro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.metroLabel16);
            this.Controls.Add(this.metroLabel15);
            this.Controls.Add(this.metroLabel14);
            this.Controls.Add(this.metroLabel13);
            this.Controls.Add(this.metroLabel12);
            this.Controls.Add(this.metroLabel11);
            this.Controls.Add(this.metroLabel10);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.dateValidateCNH);
            this.Controls.Add(this.metroLabel9);
            this.Controls.Add(this.iAgreeCheck);
            this.Controls.Add(this.dateOfBirth);
            this.Controls.Add(this.genero);
            this.Controls.Add(this.email);
            this.Controls.Add(this.telefone);
            this.Controls.Add(this.cnh);
            this.Controls.Add(this.cpf);
            this.Controls.Add(this.name);
            this.Controls.Add(this.metroLabel8);
            this.Controls.Add(this.metroLabel7);
            this.Controls.Add(this.metroLabel6);
            this.Controls.Add(this.metroLabel5);
            this.Controls.Add(this.metroLabel4);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.metroLabel1);
            this.Name = "Completar_Cadastro";
            this.Resizable = false;
            this.Style = MetroFramework.MetroColorStyle.Orange;
            this.Text = "Completar_Cadastro";
            this.Theme = MetroFramework.MetroThemeStyle.Dark;
            ((System.ComponentModel.ISupportInitialize)(this.manager)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroDateTime dateValidateCNH;
        private MetroFramework.Controls.MetroLabel metroLabel9;
        private MetroFramework.Controls.MetroCheckBox iAgreeCheck;
        private MetroFramework.Controls.MetroDateTime dateOfBirth;
        private MetroFramework.Controls.MetroComboBox genero;
        private MetroFramework.Controls.MetroTextBox email;
        private MetroFramework.Controls.MetroTextBox telefone;
        private MetroFramework.Controls.MetroTextBox cnh;
        private MetroFramework.Controls.MetroTextBox cpf;
        private MetroFramework.Controls.MetroTextBox name;
        private MetroFramework.Controls.MetroLabel metroLabel8;
        private MetroFramework.Controls.MetroLabel metroLabel7;
        private MetroFramework.Controls.MetroLabel metroLabel6;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroButton buttonSave;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel metroLabel10;
        private MetroFramework.Controls.MetroLabel metroLabel11;
        private MetroFramework.Controls.MetroLabel metroLabel12;
        private MetroFramework.Controls.MetroLabel metroLabel13;
        private MetroFramework.Controls.MetroLabel metroLabel14;
        private MetroFramework.Controls.MetroLabel metroLabel15;
        private MetroFramework.Controls.MetroLabel metroLabel16;
        private MetroFramework.Components.MetroStyleManager manager;
    }
}