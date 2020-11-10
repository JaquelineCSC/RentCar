namespace CarLand.Forms
{
    partial class DetalhesCarro
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DetalhesCarro));
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.marcaTxt = new MetroFramework.Controls.MetroTextBox();
            this.portaTxt = new MetroFramework.Controls.MetroTextBox();
            this.corTxt = new MetroFramework.Controls.MetroTextBox();
            this.anoTxt = new MetroFramework.Controls.MetroTextBox();
            this.modeloTxt = new MetroFramework.Controls.MetroTextBox();
            this.combustivelTxt = new MetroFramework.Controls.MetroTextBox();
            this.textLabel = new MetroFramework.Controls.MetroLabel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList1.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.InitialImage")));
            this.pictureBox1.Location = new System.Drawing.Point(573, 96);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(277, 186);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.WaitOnLoad = true;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel1.Location = new System.Drawing.Point(30, 96);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(59, 25);
            this.metroLabel1.TabIndex = 1;
            this.metroLabel1.Text = "Marca";
            this.metroLabel1.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel2.Location = new System.Drawing.Point(234, 193);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(52, 25);
            this.metroLabel2.TabIndex = 2;
            this.metroLabel2.Text = "Porta";
            this.metroLabel2.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel3.Location = new System.Drawing.Point(30, 193);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(39, 25);
            this.metroLabel3.TabIndex = 3;
            this.metroLabel3.Text = "Cor";
            this.metroLabel3.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel4.Location = new System.Drawing.Point(409, 96);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(43, 25);
            this.metroLabel4.TabIndex = 4;
            this.metroLabel4.Text = "Ano";
            this.metroLabel4.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel5.Location = new System.Drawing.Point(194, 96);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(70, 25);
            this.metroLabel5.TabIndex = 5;
            this.metroLabel5.Text = "Modelo";
            this.metroLabel5.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // marcaTxt
            // 
            // 
            // 
            // 
            this.marcaTxt.CustomButton.Image = null;
            this.marcaTxt.CustomButton.Location = new System.Drawing.Point(106, 1);
            this.marcaTxt.CustomButton.Name = "";
            this.marcaTxt.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.marcaTxt.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.marcaTxt.CustomButton.TabIndex = 1;
            this.marcaTxt.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.marcaTxt.CustomButton.UseSelectable = true;
            this.marcaTxt.CustomButton.Visible = false;
            this.marcaTxt.Enabled = false;
            this.marcaTxt.Lines = new string[0];
            this.marcaTxt.Location = new System.Drawing.Point(30, 134);
            this.marcaTxt.MaxLength = 32767;
            this.marcaTxt.Name = "marcaTxt";
            this.marcaTxt.PasswordChar = '\0';
            this.marcaTxt.ReadOnly = true;
            this.marcaTxt.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.marcaTxt.SelectedText = "";
            this.marcaTxt.SelectionLength = 0;
            this.marcaTxt.SelectionStart = 0;
            this.marcaTxt.ShortcutsEnabled = true;
            this.marcaTxt.Size = new System.Drawing.Size(128, 23);
            this.marcaTxt.Style = MetroFramework.MetroColorStyle.Orange;
            this.marcaTxt.TabIndex = 6;
            this.marcaTxt.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.marcaTxt.UseSelectable = true;
            this.marcaTxt.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.marcaTxt.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // portaTxt
            // 
            // 
            // 
            // 
            this.portaTxt.CustomButton.Image = null;
            this.portaTxt.CustomButton.Location = new System.Drawing.Point(109, 1);
            this.portaTxt.CustomButton.Name = "";
            this.portaTxt.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.portaTxt.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.portaTxt.CustomButton.TabIndex = 1;
            this.portaTxt.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.portaTxt.CustomButton.UseSelectable = true;
            this.portaTxt.CustomButton.Visible = false;
            this.portaTxt.Enabled = false;
            this.portaTxt.Lines = new string[0];
            this.portaTxt.Location = new System.Drawing.Point(234, 237);
            this.portaTxt.MaxLength = 32767;
            this.portaTxt.Name = "portaTxt";
            this.portaTxt.PasswordChar = '\0';
            this.portaTxt.ReadOnly = true;
            this.portaTxt.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.portaTxt.SelectedText = "";
            this.portaTxt.SelectionLength = 0;
            this.portaTxt.SelectionStart = 0;
            this.portaTxt.ShortcutsEnabled = true;
            this.portaTxt.Size = new System.Drawing.Size(131, 23);
            this.portaTxt.Style = MetroFramework.MetroColorStyle.Orange;
            this.portaTxt.TabIndex = 7;
            this.portaTxt.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.portaTxt.UseSelectable = true;
            this.portaTxt.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.portaTxt.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // corTxt
            // 
            // 
            // 
            // 
            this.corTxt.CustomButton.Image = null;
            this.corTxt.CustomButton.Location = new System.Drawing.Point(151, 1);
            this.corTxt.CustomButton.Name = "";
            this.corTxt.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.corTxt.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.corTxt.CustomButton.TabIndex = 1;
            this.corTxt.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.corTxt.CustomButton.UseSelectable = true;
            this.corTxt.CustomButton.Visible = false;
            this.corTxt.Enabled = false;
            this.corTxt.Lines = new string[0];
            this.corTxt.Location = new System.Drawing.Point(30, 237);
            this.corTxt.MaxLength = 32767;
            this.corTxt.Name = "corTxt";
            this.corTxt.PasswordChar = '\0';
            this.corTxt.ReadOnly = true;
            this.corTxt.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.corTxt.SelectedText = "";
            this.corTxt.SelectionLength = 0;
            this.corTxt.SelectionStart = 0;
            this.corTxt.ShortcutsEnabled = true;
            this.corTxt.Size = new System.Drawing.Size(173, 23);
            this.corTxt.Style = MetroFramework.MetroColorStyle.Orange;
            this.corTxt.TabIndex = 8;
            this.corTxt.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.corTxt.UseSelectable = true;
            this.corTxt.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.corTxt.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // anoTxt
            // 
            // 
            // 
            // 
            this.anoTxt.CustomButton.Image = null;
            this.anoTxt.CustomButton.Location = new System.Drawing.Point(104, 1);
            this.anoTxt.CustomButton.Name = "";
            this.anoTxt.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.anoTxt.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.anoTxt.CustomButton.TabIndex = 1;
            this.anoTxt.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.anoTxt.CustomButton.UseSelectable = true;
            this.anoTxt.CustomButton.Visible = false;
            this.anoTxt.Enabled = false;
            this.anoTxt.Lines = new string[0];
            this.anoTxt.Location = new System.Drawing.Point(409, 134);
            this.anoTxt.MaxLength = 32767;
            this.anoTxt.Name = "anoTxt";
            this.anoTxt.PasswordChar = '\0';
            this.anoTxt.ReadOnly = true;
            this.anoTxt.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.anoTxt.SelectedText = "";
            this.anoTxt.SelectionLength = 0;
            this.anoTxt.SelectionStart = 0;
            this.anoTxt.ShortcutsEnabled = true;
            this.anoTxt.Size = new System.Drawing.Size(126, 23);
            this.anoTxt.Style = MetroFramework.MetroColorStyle.Orange;
            this.anoTxt.TabIndex = 9;
            this.anoTxt.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.anoTxt.UseSelectable = true;
            this.anoTxt.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.anoTxt.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // modeloTxt
            // 
            // 
            // 
            // 
            this.modeloTxt.CustomButton.Image = null;
            this.modeloTxt.CustomButton.Location = new System.Drawing.Point(165, 1);
            this.modeloTxt.CustomButton.Name = "";
            this.modeloTxt.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.modeloTxt.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.modeloTxt.CustomButton.TabIndex = 1;
            this.modeloTxt.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.modeloTxt.CustomButton.UseSelectable = true;
            this.modeloTxt.CustomButton.Visible = false;
            this.modeloTxt.Enabled = false;
            this.modeloTxt.Lines = new string[0];
            this.modeloTxt.Location = new System.Drawing.Point(194, 134);
            this.modeloTxt.MaxLength = 32767;
            this.modeloTxt.Name = "modeloTxt";
            this.modeloTxt.PasswordChar = '\0';
            this.modeloTxt.ReadOnly = true;
            this.modeloTxt.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.modeloTxt.SelectedText = "";
            this.modeloTxt.SelectionLength = 0;
            this.modeloTxt.SelectionStart = 0;
            this.modeloTxt.ShortcutsEnabled = true;
            this.modeloTxt.Size = new System.Drawing.Size(187, 23);
            this.modeloTxt.Style = MetroFramework.MetroColorStyle.Orange;
            this.modeloTxt.TabIndex = 10;
            this.modeloTxt.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.modeloTxt.UseSelectable = true;
            this.modeloTxt.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.modeloTxt.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // combustivelTxt
            // 
            // 
            // 
            // 
            this.combustivelTxt.CustomButton.Image = null;
            this.combustivelTxt.CustomButton.Location = new System.Drawing.Point(120, 1);
            this.combustivelTxt.CustomButton.Name = "";
            this.combustivelTxt.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.combustivelTxt.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.combustivelTxt.CustomButton.TabIndex = 1;
            this.combustivelTxt.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.combustivelTxt.CustomButton.UseSelectable = true;
            this.combustivelTxt.CustomButton.Visible = false;
            this.combustivelTxt.Enabled = false;
            this.combustivelTxt.Lines = new string[0];
            this.combustivelTxt.Location = new System.Drawing.Point(393, 237);
            this.combustivelTxt.MaxLength = 32767;
            this.combustivelTxt.Name = "combustivelTxt";
            this.combustivelTxt.PasswordChar = '\0';
            this.combustivelTxt.ReadOnly = true;
            this.combustivelTxt.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.combustivelTxt.SelectedText = "";
            this.combustivelTxt.SelectionLength = 0;
            this.combustivelTxt.SelectionStart = 0;
            this.combustivelTxt.ShortcutsEnabled = true;
            this.combustivelTxt.Size = new System.Drawing.Size(142, 23);
            this.combustivelTxt.Style = MetroFramework.MetroColorStyle.Orange;
            this.combustivelTxt.TabIndex = 12;
            this.combustivelTxt.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.combustivelTxt.UseSelectable = true;
            this.combustivelTxt.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.combustivelTxt.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // textLabel
            // 
            this.textLabel.AutoSize = true;
            this.textLabel.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.textLabel.Location = new System.Drawing.Point(393, 193);
            this.textLabel.Name = "textLabel";
            this.textLabel.Size = new System.Drawing.Size(105, 25);
            this.textLabel.TabIndex = 11;
            this.textLabel.Text = "Combustível";
            this.textLabel.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // DetalhesCarro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(873, 341);
            this.Controls.Add(this.combustivelTxt);
            this.Controls.Add(this.textLabel);
            this.Controls.Add(this.modeloTxt);
            this.Controls.Add(this.anoTxt);
            this.Controls.Add(this.corTxt);
            this.Controls.Add(this.portaTxt);
            this.Controls.Add(this.marcaTxt);
            this.Controls.Add(this.metroLabel5);
            this.Controls.Add(this.metroLabel4);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.pictureBox1);
            this.MaximizeBox = false;
            this.Name = "DetalhesCarro";
            this.Resizable = false;
            this.Style = MetroFramework.MetroColorStyle.Orange;
            this.Text = "Detalhe";
            this.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.Load += new System.EventHandler(this.DetalhesCarro_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private MetroFramework.Controls.MetroTextBox marcaTxt;
        private MetroFramework.Controls.MetroTextBox portaTxt;
        private MetroFramework.Controls.MetroTextBox corTxt;
        private MetroFramework.Controls.MetroTextBox anoTxt;
        private MetroFramework.Controls.MetroTextBox modeloTxt;
        private MetroFramework.Controls.MetroTextBox combustivelTxt;
        private MetroFramework.Controls.MetroLabel textLabel;
    }
}