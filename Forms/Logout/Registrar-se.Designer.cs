namespace CarLand.Forms
{
    partial class Registrar_se
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Registrar_se));
            this.mtxtSenhaClientes = new MetroFramework.Controls.MetroTextBox();
            this.mtxtUsuarioClientes = new MetroFramework.Controls.MetroTextBox();
            this.metroTextBox1 = new MetroFramework.Controls.MetroTextBox();
            this.metroLink1 = new MetroFramework.Controls.MetroLink();
            this.errors = new System.Windows.Forms.ErrorProvider(this.components);
            this.metroToolTip1 = new MetroFramework.Components.MetroToolTip();
            ((System.ComponentModel.ISupportInitialize)(this.errors)).BeginInit();
            this.SuspendLayout();
            // 
            // mtxtSenhaClientes
            // 
            this.mtxtSenhaClientes.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.mtxtSenhaClientes.CustomButton.Image = null;
            this.mtxtSenhaClientes.CustomButton.Location = new System.Drawing.Point(214, 2);
            this.mtxtSenhaClientes.CustomButton.Name = "";
            this.mtxtSenhaClientes.CustomButton.Size = new System.Drawing.Size(19, 19);
            this.mtxtSenhaClientes.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.mtxtSenhaClientes.CustomButton.TabIndex = 1;
            this.mtxtSenhaClientes.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.mtxtSenhaClientes.CustomButton.UseSelectable = true;
            this.mtxtSenhaClientes.CustomButton.Visible = false;
            this.mtxtSenhaClientes.DisplayIcon = true;
            this.mtxtSenhaClientes.Lines = new string[0];
            this.mtxtSenhaClientes.Location = new System.Drawing.Point(105, 168);
            this.mtxtSenhaClientes.MaxLength = 16;
            this.mtxtSenhaClientes.Name = "mtxtSenhaClientes";
            this.mtxtSenhaClientes.PasswordChar = '\0';
            this.mtxtSenhaClientes.PromptText = "Senha";
            this.mtxtSenhaClientes.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.mtxtSenhaClientes.SelectedText = "";
            this.mtxtSenhaClientes.SelectionLength = 0;
            this.mtxtSenhaClientes.SelectionStart = 0;
            this.mtxtSenhaClientes.ShortcutsEnabled = true;
            this.mtxtSenhaClientes.Size = new System.Drawing.Size(236, 24);
            this.mtxtSenhaClientes.Style = MetroFramework.MetroColorStyle.Orange;
            this.mtxtSenhaClientes.TabIndex = 45;
            this.mtxtSenhaClientes.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.mtxtSenhaClientes.UseSelectable = true;
            this.mtxtSenhaClientes.WaterMark = "Senha";
            this.mtxtSenhaClientes.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.mtxtSenhaClientes.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.mtxtSenhaClientes.TextChanged += new System.EventHandler(this.verficiarPreenchimento);
            // 
            // mtxtUsuarioClientes
            // 
            this.mtxtUsuarioClientes.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.mtxtUsuarioClientes.CustomButton.Image = null;
            this.mtxtUsuarioClientes.CustomButton.Location = new System.Drawing.Point(214, 2);
            this.mtxtUsuarioClientes.CustomButton.Name = "";
            this.mtxtUsuarioClientes.CustomButton.Size = new System.Drawing.Size(19, 19);
            this.mtxtUsuarioClientes.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.mtxtUsuarioClientes.CustomButton.TabIndex = 1;
            this.mtxtUsuarioClientes.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.mtxtUsuarioClientes.CustomButton.UseSelectable = true;
            this.mtxtUsuarioClientes.CustomButton.Visible = false;
            this.mtxtUsuarioClientes.DisplayIcon = true;
            this.mtxtUsuarioClientes.Lines = new string[0];
            this.mtxtUsuarioClientes.Location = new System.Drawing.Point(105, 115);
            this.mtxtUsuarioClientes.MaxLength = 20;
            this.mtxtUsuarioClientes.Name = "mtxtUsuarioClientes";
            this.mtxtUsuarioClientes.PasswordChar = '\0';
            this.mtxtUsuarioClientes.PromptText = "Usuário";
            this.mtxtUsuarioClientes.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.mtxtUsuarioClientes.SelectedText = "";
            this.mtxtUsuarioClientes.SelectionLength = 0;
            this.mtxtUsuarioClientes.SelectionStart = 0;
            this.mtxtUsuarioClientes.ShortcutsEnabled = true;
            this.mtxtUsuarioClientes.Size = new System.Drawing.Size(236, 24);
            this.mtxtUsuarioClientes.Style = MetroFramework.MetroColorStyle.Orange;
            this.mtxtUsuarioClientes.TabIndex = 34;
            this.mtxtUsuarioClientes.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.mtxtUsuarioClientes.UseSelectable = true;
            this.mtxtUsuarioClientes.WaterMark = "Usuário";
            this.mtxtUsuarioClientes.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.mtxtUsuarioClientes.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.mtxtUsuarioClientes.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.verficiarPreenchimento);
            this.mtxtUsuarioClientes.KeyUp += new System.Windows.Forms.KeyEventHandler(this.verficiarPreenchimento);
            // 
            // metroTextBox1
            // 
            this.metroTextBox1.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.metroTextBox1.CustomButton.Image = null;
            this.metroTextBox1.CustomButton.Location = new System.Drawing.Point(214, 2);
            this.metroTextBox1.CustomButton.Name = "";
            this.metroTextBox1.CustomButton.Size = new System.Drawing.Size(19, 19);
            this.metroTextBox1.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroTextBox1.CustomButton.TabIndex = 1;
            this.metroTextBox1.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroTextBox1.CustomButton.UseSelectable = true;
            this.metroTextBox1.CustomButton.Visible = false;
            this.metroTextBox1.DisplayIcon = true;
            this.metroTextBox1.Lines = new string[0];
            this.metroTextBox1.Location = new System.Drawing.Point(105, 228);
            this.metroTextBox1.MaxLength = 16;
            this.metroTextBox1.Name = "metroTextBox1";
            this.metroTextBox1.PasswordChar = '\0';
            this.metroTextBox1.PromptText = "Confirmar Senha";
            this.metroTextBox1.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.metroTextBox1.SelectedText = "";
            this.metroTextBox1.SelectionLength = 0;
            this.metroTextBox1.SelectionStart = 0;
            this.metroTextBox1.ShortcutsEnabled = true;
            this.metroTextBox1.Size = new System.Drawing.Size(236, 24);
            this.metroTextBox1.Style = MetroFramework.MetroColorStyle.Orange;
            this.metroTextBox1.TabIndex = 48;
            this.metroTextBox1.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroTextBox1.UseSelectable = true;
            this.metroTextBox1.WaterMark = "Confirmar Senha";
            this.metroTextBox1.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.metroTextBox1.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.metroTextBox1.TextChanged += new System.EventHandler(this.verficiarPreenchimento);
            // 
            // metroLink1
            // 
            this.metroLink1.Enabled = false;
            this.metroLink1.Image = ((System.Drawing.Image)(resources.GetObject("metroLink1.Image")));
            this.metroLink1.ImageSize = 45;
            this.metroLink1.Location = new System.Drawing.Point(379, 36);
            this.metroLink1.Name = "metroLink1";
            this.metroLink1.Size = new System.Drawing.Size(51, 47);
            this.metroLink1.Style = MetroFramework.MetroColorStyle.Orange;
            this.metroLink1.TabIndex = 49;
            this.metroLink1.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroLink1.UseSelectable = true;
            this.metroLink1.Click += new System.EventHandler(this.metroLink1_Click);
            this.metroLink1.MouseHover += new System.EventHandler(this.tooltipo);
            // 
            // errors
            // 
            this.errors.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.errors.ContainerControl = this;
            this.errors.Icon = ((System.Drawing.Icon)(resources.GetObject("errors.Icon")));
            // 
            // metroToolTip1
            // 
            this.metroToolTip1.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroToolTip1.StyleManager = null;
            this.metroToolTip1.Theme = MetroFramework.MetroThemeStyle.Light;
            // 
            // Registrar_se
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(453, 330);
            this.Controls.Add(this.metroLink1);
            this.Controls.Add(this.metroTextBox1);
            this.Controls.Add(this.mtxtSenhaClientes);
            this.Controls.Add(this.mtxtUsuarioClientes);
            this.Name = "Registrar_se";
            this.Resizable = false;
            this.Style = MetroFramework.MetroColorStyle.Orange;
            this.Text = "Registrar";
            this.Theme = MetroFramework.MetroThemeStyle.Dark;
            ((System.ComponentModel.ISupportInitialize)(this.errors)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private MetroFramework.Controls.MetroTextBox mtxtSenhaClientes;
        private MetroFramework.Controls.MetroTextBox mtxtUsuarioClientes;
        private MetroFramework.Controls.MetroTextBox metroTextBox1;
        private MetroFramework.Controls.MetroLink metroLink1;
        private System.Windows.Forms.ErrorProvider errors;
        private MetroFramework.Components.MetroToolTip metroToolTip1;
    }
}