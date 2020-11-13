namespace CarLand.Forms.Client
{
    partial class Profile
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Profile));
            this.dateValidateCNH = new MetroFramework.Controls.MetroDateTime();
            this.metroLabel9 = new MetroFramework.Controls.MetroLabel();
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
            this.metroLinkVoltar = new MetroFramework.Controls.MetroLink();
            this.metroLinkSalvar = new MetroFramework.Controls.MetroLink();
            this.SuspendLayout();
            // 
            // dateValidateCNH
            // 
            this.dateValidateCNH.Location = new System.Drawing.Point(245, 297);
            this.dateValidateCNH.MinimumSize = new System.Drawing.Size(0, 29);
            this.dateValidateCNH.Name = "dateValidateCNH";
            this.dateValidateCNH.Size = new System.Drawing.Size(223, 29);
            this.dateValidateCNH.Style = MetroFramework.MetroColorStyle.Orange;
            this.dateValidateCNH.TabIndex = 86;
            this.dateValidateCNH.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.dateValidateCNH.UseStyleColors = true;
            // 
            // metroLabel9
            // 
            this.metroLabel9.AutoSize = true;
            this.metroLabel9.BackColor = System.Drawing.Color.Transparent;
            this.metroLabel9.Location = new System.Drawing.Point(245, 275);
            this.metroLabel9.Name = "metroLabel9";
            this.metroLabel9.Size = new System.Drawing.Size(143, 19);
            this.metroLabel9.TabIndex = 85;
            this.metroLabel9.Text = "Data de Validade CNH:";
            this.metroLabel9.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // dateOfBirth
            // 
            this.dateOfBirth.Location = new System.Drawing.Point(535, 143);
            this.dateOfBirth.MinimumSize = new System.Drawing.Size(0, 29);
            this.dateOfBirth.Name = "dateOfBirth";
            this.dateOfBirth.Size = new System.Drawing.Size(223, 29);
            this.dateOfBirth.Style = MetroFramework.MetroColorStyle.Orange;
            this.dateOfBirth.TabIndex = 83;
            this.dateOfBirth.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.dateOfBirth.UseStyleColors = true;
            // 
            // genero
            // 
            this.genero.FormattingEnabled = true;
            this.genero.ItemHeight = 23;
            this.genero.Items.AddRange(new object[] {
            "Masculino",
            "Feminino",
            "Prefiro não mencionar"});
            this.genero.Location = new System.Drawing.Point(446, 220);
            this.genero.Name = "genero";
            this.genero.Size = new System.Drawing.Size(180, 29);
            this.genero.Style = MetroFramework.MetroColorStyle.Orange;
            this.genero.TabIndex = 82;
            this.genero.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.genero.UseSelectable = true;
            this.genero.UseStyleColors = true;
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
            this.email.Location = new System.Drawing.Point(292, 143);
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
            this.email.TabIndex = 81;
            this.email.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.email.UseSelectable = true;
            this.email.UseStyleColors = true;
            this.email.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.email.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
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
            this.telefone.Location = new System.Drawing.Point(260, 220);
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
            this.telefone.TabIndex = 80;
            this.telefone.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.telefone.UseSelectable = true;
            this.telefone.UseStyleColors = true;
            this.telefone.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.telefone.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
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
            this.cnh.Enabled = false;
            this.cnh.Lines = new string[0];
            this.cnh.Location = new System.Drawing.Point(49, 297);
            this.cnh.MaxLength = 32767;
            this.cnh.Multiline = true;
            this.cnh.Name = "cnh";
            this.cnh.PasswordChar = '\0';
            this.cnh.ReadOnly = true;
            this.cnh.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.cnh.SelectedText = "";
            this.cnh.SelectionLength = 0;
            this.cnh.SelectionStart = 0;
            this.cnh.ShortcutsEnabled = true;
            this.cnh.Size = new System.Drawing.Size(155, 29);
            this.cnh.Style = MetroFramework.MetroColorStyle.Orange;
            this.cnh.TabIndex = 79;
            this.cnh.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.cnh.UseSelectable = true;
            this.cnh.UseStyleColors = true;
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
            this.cpf.Enabled = false;
            this.cpf.Lines = new string[0];
            this.cpf.Location = new System.Drawing.Point(49, 220);
            this.cpf.MaxLength = 32767;
            this.cpf.Multiline = true;
            this.cpf.Name = "cpf";
            this.cpf.PasswordChar = '\0';
            this.cpf.ReadOnly = true;
            this.cpf.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.cpf.SelectedText = "";
            this.cpf.SelectionLength = 0;
            this.cpf.SelectionStart = 0;
            this.cpf.ShortcutsEnabled = true;
            this.cpf.Size = new System.Drawing.Size(169, 29);
            this.cpf.Style = MetroFramework.MetroColorStyle.Orange;
            this.cpf.TabIndex = 78;
            this.cpf.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.cpf.UseSelectable = true;
            this.cpf.UseStyleColors = true;
            this.cpf.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.cpf.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
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
            this.name.Location = new System.Drawing.Point(49, 143);
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
            this.name.TabIndex = 77;
            this.name.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.name.UseSelectable = true;
            this.name.UseStyleColors = true;
            this.name.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.name.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel8
            // 
            this.metroLabel8.AutoSize = true;
            this.metroLabel8.BackColor = System.Drawing.Color.Transparent;
            this.metroLabel8.Location = new System.Drawing.Point(446, 198);
            this.metroLabel8.Name = "metroLabel8";
            this.metroLabel8.Size = new System.Drawing.Size(55, 19);
            this.metroLabel8.TabIndex = 76;
            this.metroLabel8.Text = "Gênero:";
            this.metroLabel8.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // metroLabel7
            // 
            this.metroLabel7.AutoSize = true;
            this.metroLabel7.BackColor = System.Drawing.Color.Transparent;
            this.metroLabel7.Location = new System.Drawing.Point(292, 121);
            this.metroLabel7.Name = "metroLabel7";
            this.metroLabel7.Size = new System.Drawing.Size(50, 19);
            this.metroLabel7.TabIndex = 75;
            this.metroLabel7.Text = "E-mail:";
            this.metroLabel7.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // metroLabel6
            // 
            this.metroLabel6.AutoSize = true;
            this.metroLabel6.BackColor = System.Drawing.Color.Transparent;
            this.metroLabel6.Location = new System.Drawing.Point(260, 198);
            this.metroLabel6.Name = "metroLabel6";
            this.metroLabel6.Size = new System.Drawing.Size(60, 19);
            this.metroLabel6.TabIndex = 74;
            this.metroLabel6.Text = "Telefone:";
            this.metroLabel6.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.BackColor = System.Drawing.Color.Transparent;
            this.metroLabel5.Location = new System.Drawing.Point(535, 121);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(131, 19);
            this.metroLabel5.TabIndex = 73;
            this.metroLabel5.Text = "Data de Nascimento:";
            this.metroLabel5.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.BackColor = System.Drawing.Color.Transparent;
            this.metroLabel4.Location = new System.Drawing.Point(49, 275);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(40, 19);
            this.metroLabel4.TabIndex = 72;
            this.metroLabel4.Text = "CNH:";
            this.metroLabel4.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.BackColor = System.Drawing.Color.Transparent;
            this.metroLabel3.Location = new System.Drawing.Point(49, 198);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(36, 19);
            this.metroLabel3.TabIndex = 71;
            this.metroLabel3.Text = "CPF:";
            this.metroLabel3.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.BackColor = System.Drawing.Color.Transparent;
            this.metroLabel1.Location = new System.Drawing.Point(49, 121);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(49, 19);
            this.metroLabel1.TabIndex = 70;
            this.metroLabel1.Text = "Nome:";
            this.metroLabel1.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // metroLinkVoltar
            // 
            this.metroLinkVoltar.Image = ((System.Drawing.Image)(resources.GetObject("metroLinkVoltar.Image")));
            this.metroLinkVoltar.ImageSize = 39;
            this.metroLinkVoltar.Location = new System.Drawing.Point(659, 27);
            this.metroLinkVoltar.Name = "metroLinkVoltar";
            this.metroLinkVoltar.Size = new System.Drawing.Size(66, 57);
            this.metroLinkVoltar.TabIndex = 87;
            this.metroLinkVoltar.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroLinkVoltar.UseSelectable = true;
            // 
            // metroLinkSalvar
            // 
            this.metroLinkSalvar.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.metroLinkSalvar.ForeColor = System.Drawing.Color.Black;
            this.metroLinkSalvar.Image = ((System.Drawing.Image)(resources.GetObject("metroLinkSalvar.Image")));
            this.metroLinkSalvar.ImageSize = 32;
            this.metroLinkSalvar.Location = new System.Drawing.Point(718, 27);
            this.metroLinkSalvar.Name = "metroLinkSalvar";
            this.metroLinkSalvar.Size = new System.Drawing.Size(59, 57);
            this.metroLinkSalvar.Style = MetroFramework.MetroColorStyle.Orange;
            this.metroLinkSalvar.TabIndex = 88;
            this.metroLinkSalvar.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroLinkSalvar.UseSelectable = true;
            // 
            // Profile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackImage = ((System.Drawing.Image)(resources.GetObject("$this.BackImage")));
            this.BackImagePadding = new System.Windows.Forms.Padding(-19, 11, -1, -1);
            this.BackMaxSize = 240;
            this.ClientSize = new System.Drawing.Size(800, 414);
            this.Controls.Add(this.metroLinkVoltar);
            this.Controls.Add(this.metroLinkSalvar);
            this.Controls.Add(this.dateValidateCNH);
            this.Controls.Add(this.metroLabel9);
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
            this.Name = "Profile";
            this.Resizable = false;
            this.Style = MetroFramework.MetroColorStyle.Orange;
            this.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.Load += new System.EventHandler(this.Profile_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MetroFramework.Controls.MetroDateTime dateValidateCNH;
        private MetroFramework.Controls.MetroLabel metroLabel9;
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
        private MetroFramework.Controls.MetroLink metroLinkVoltar;
        private MetroFramework.Controls.MetroLink metroLinkSalvar;
    }
}