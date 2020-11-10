namespace CarLand.Forms
{
    partial class Esqueceu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Esqueceu));
            this.metroTextBox1 = new MetroFramework.Controls.MetroTextBox();
            this.metroButton1 = new MetroFramework.Controls.MetroButton();
            this._manager = new MetroFramework.Components.MetroStyleManager(this.components);
            this.error = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this._manager)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.error)).BeginInit();
            this.SuspendLayout();
            // 
            // metroTextBox1
            // 
            // 
            // 
            // 
            this.metroTextBox1.CustomButton.Image = null;
            this.metroTextBox1.CustomButton.Location = new System.Drawing.Point(198, 2);
            this.metroTextBox1.CustomButton.Name = "";
            this.metroTextBox1.CustomButton.Size = new System.Drawing.Size(29, 29);
            this.metroTextBox1.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroTextBox1.CustomButton.TabIndex = 1;
            this.metroTextBox1.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroTextBox1.CustomButton.UseSelectable = true;
            this.metroTextBox1.CustomButton.Visible = false;
            this.metroTextBox1.DisplayIcon = true;
            this.metroTextBox1.Icon = ((System.Drawing.Image)(resources.GetObject("metroTextBox1.Icon")));
            this.metroTextBox1.Lines = new string[0];
            this.metroTextBox1.Location = new System.Drawing.Point(120, 97);
            this.metroTextBox1.MaxLength = 32767;
            this.metroTextBox1.Multiline = true;
            this.metroTextBox1.Name = "metroTextBox1";
            this.metroTextBox1.PasswordChar = '\0';
            this.metroTextBox1.PromptText = "Usuário";
            this.metroTextBox1.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.metroTextBox1.SelectedText = "";
            this.metroTextBox1.SelectionLength = 0;
            this.metroTextBox1.SelectionStart = 0;
            this.metroTextBox1.ShortcutsEnabled = true;
            this.metroTextBox1.Size = new System.Drawing.Size(230, 34);
            this.metroTextBox1.Style = MetroFramework.MetroColorStyle.Orange;
            this.metroTextBox1.TabIndex = 1;
            this.metroTextBox1.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroTextBox1.UseSelectable = true;
            this.metroTextBox1.WaterMark = "Usuário";
            this.metroTextBox1.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.metroTextBox1.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroButton1
            // 
            this.metroButton1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.metroButton1.Location = new System.Drawing.Point(169, 169);
            this.metroButton1.Name = "metroButton1";
            this.metroButton1.Size = new System.Drawing.Size(133, 41);
            this.metroButton1.Style = MetroFramework.MetroColorStyle.Silver;
            this.metroButton1.TabIndex = 2;
            this.metroButton1.Text = "Recuperar Senha";
            this.metroButton1.UseCustomBackColor = true;
            this.metroButton1.UseSelectable = true;
            this.metroButton1.Click += new System.EventHandler(this.metroButton1_Click);
            // 
            // _manager
            // 
            this._manager.Owner = null;
            this._manager.Style = MetroFramework.MetroColorStyle.Orange;
            this._manager.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // error
            // 
            this.error.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.error.ContainerControl = this;
            this.error.Icon = ((System.Drawing.Icon)(resources.GetObject("error.Icon")));
            // 
            // Esqueceu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(494, 319);
            this.Controls.Add(this.metroButton1);
            this.Controls.Add(this.metroTextBox1);
            this.Name = "Esqueceu";
            this.Resizable = false;
            this.Style = MetroFramework.MetroColorStyle.Orange;
            this.Text = "Esqueci minha senha";
            this.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.Load += new System.EventHandler(this.Esqueceu_Load);
            ((System.ComponentModel.ISupportInitialize)(this._manager)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.error)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroTextBox metroTextBox1;
        private MetroFramework.Controls.MetroButton metroButton1;
        private MetroFramework.Components.MetroStyleManager _manager;
        private System.Windows.Forms.ErrorProvider error;
    }
}