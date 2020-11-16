namespace CarLand.Forms.Client
{
    partial class NewCard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NewCard));
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.OwnerCard = new MetroFramework.Controls.MetroTextBox();
            this.CVC = new MetroFramework.Controls.MetroTextBox();
            this.numberCard = new MetroFramework.Controls.MetroTextBox();
            this.month = new MetroFramework.Controls.MetroComboBox();
            this.year = new MetroFramework.Controls.MetroComboBox();
            this.metroLabel6 = new MetroFramework.Controls.MetroLabel();
            this.CvcExplain = new MetroFramework.Controls.MetroPanel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.register = new MetroFramework.Controls.MetroButton();
            this.cancel = new MetroFramework.Controls.MetroButton();
            this.CvcExplain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(23, 152);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(0, 0);
            this.metroLabel3.TabIndex = 82;
            this.metroLabel3.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // OwnerCard
            // 
            // 
            // 
            // 
            this.OwnerCard.CustomButton.Image = null;
            this.OwnerCard.CustomButton.Location = new System.Drawing.Point(306, 1);
            this.OwnerCard.CustomButton.Name = "";
            this.OwnerCard.CustomButton.Size = new System.Drawing.Size(31, 31);
            this.OwnerCard.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.OwnerCard.CustomButton.TabIndex = 1;
            this.OwnerCard.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.OwnerCard.CustomButton.UseSelectable = true;
            this.OwnerCard.CustomButton.Visible = false;
            this.OwnerCard.DisplayIcon = true;
            this.OwnerCard.Icon = ((System.Drawing.Image)(resources.GetObject("OwnerCard.Icon")));
            this.OwnerCard.Lines = new string[0];
            this.OwnerCard.Location = new System.Drawing.Point(58, 86);
            this.OwnerCard.MaxLength = 32767;
            this.OwnerCard.Multiline = true;
            this.OwnerCard.Name = "OwnerCard";
            this.OwnerCard.PasswordChar = '\0';
            this.OwnerCard.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.OwnerCard.SelectedText = "";
            this.OwnerCard.SelectionLength = 0;
            this.OwnerCard.SelectionStart = 0;
            this.OwnerCard.ShortcutsEnabled = true;
            this.OwnerCard.Size = new System.Drawing.Size(338, 33);
            this.OwnerCard.Style = MetroFramework.MetroColorStyle.Orange;
            this.OwnerCard.TabIndex = 85;
            this.OwnerCard.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.OwnerCard.UseSelectable = true;
            this.OwnerCard.WaterMark = "Nome do Titular do Cartão";
            this.OwnerCard.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.OwnerCard.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // CVC
            // 
            // 
            // 
            // 
            this.CVC.CustomButton.BackColor = System.Drawing.Color.Transparent;
            this.CVC.CustomButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("resource.BackgroundImage")));
            this.CVC.CustomButton.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image")));
            this.CVC.CustomButton.Location = new System.Drawing.Point(65, 1);
            this.CVC.CustomButton.Name = "";
            this.CVC.CustomButton.Size = new System.Drawing.Size(31, 31);
            this.CVC.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.CVC.CustomButton.TabIndex = 1;
            this.CVC.CustomButton.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.CVC.CustomButton.UseSelectable = true;
            this.CVC.CustomButton.UseVisualStyleBackColor = false;
            this.CVC.IconRight = true;
            this.CVC.Lines = new string[0];
            this.CVC.Location = new System.Drawing.Point(299, 142);
            this.CVC.MaxLength = 32767;
            this.CVC.Multiline = true;
            this.CVC.Name = "CVC";
            this.CVC.PasswordChar = '\0';
            this.CVC.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.CVC.SelectedText = "";
            this.CVC.SelectionLength = 0;
            this.CVC.SelectionStart = 0;
            this.CVC.ShortcutsEnabled = true;
            this.CVC.ShowButton = true;
            this.CVC.Size = new System.Drawing.Size(97, 33);
            this.CVC.Style = MetroFramework.MetroColorStyle.Orange;
            this.CVC.TabIndex = 86;
            this.CVC.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.CVC.UseSelectable = true;
            this.CVC.WaterMark = "CVC";
            this.CVC.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.CVC.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.CVC.ButtonClick += new MetroFramework.Controls.MetroTextBox.ButClick(this.whatIsCVC);
            // 
            // numberCard
            // 
            // 
            // 
            // 
            this.numberCard.CustomButton.Image = null;
            this.numberCard.CustomButton.Location = new System.Drawing.Point(182, 1);
            this.numberCard.CustomButton.Name = "";
            this.numberCard.CustomButton.Size = new System.Drawing.Size(31, 31);
            this.numberCard.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.numberCard.CustomButton.TabIndex = 1;
            this.numberCard.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.numberCard.CustomButton.UseSelectable = true;
            this.numberCard.CustomButton.Visible = false;
            this.numberCard.DisplayIcon = true;
            this.numberCard.Icon = ((System.Drawing.Image)(resources.GetObject("numberCard.Icon")));
            this.numberCard.Lines = new string[0];
            this.numberCard.Location = new System.Drawing.Point(58, 142);
            this.numberCard.MaxLength = 32767;
            this.numberCard.Multiline = true;
            this.numberCard.Name = "numberCard";
            this.numberCard.PasswordChar = '\0';
            this.numberCard.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.numberCard.SelectedText = "";
            this.numberCard.SelectionLength = 0;
            this.numberCard.SelectionStart = 0;
            this.numberCard.ShortcutsEnabled = true;
            this.numberCard.Size = new System.Drawing.Size(214, 33);
            this.numberCard.Style = MetroFramework.MetroColorStyle.Orange;
            this.numberCard.TabIndex = 87;
            this.numberCard.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.numberCard.UseSelectable = true;
            this.numberCard.WaterMark = "Numero do Cartão";
            this.numberCard.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.numberCard.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // month
            // 
            this.month.DisplayMember = "Mes de Validade";
            this.month.FormattingEnabled = true;
            this.month.ItemHeight = 23;
            this.month.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12"});
            this.month.Location = new System.Drawing.Point(186, 207);
            this.month.Name = "month";
            this.month.Size = new System.Drawing.Size(97, 29);
            this.month.Style = MetroFramework.MetroColorStyle.Orange;
            this.month.TabIndex = 88;
            this.month.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.month.UseSelectable = true;
            // 
            // year
            // 
            this.year.FormattingEnabled = true;
            this.year.ItemHeight = 23;
            this.year.Items.AddRange(new object[] {
            "2020",
            "2021",
            "2022",
            "2023",
            "2024",
            "2025",
            "2026",
            "2027",
            "2028",
            "2029",
            "2030"});
            this.year.Location = new System.Drawing.Point(303, 207);
            this.year.Name = "year";
            this.year.Size = new System.Drawing.Size(93, 29);
            this.year.Style = MetroFramework.MetroColorStyle.Orange;
            this.year.TabIndex = 89;
            this.year.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.year.UseSelectable = true;
            // 
            // metroLabel6
            // 
            this.metroLabel6.AutoSize = true;
            this.metroLabel6.Dock = System.Windows.Forms.DockStyle.Top;
            this.metroLabel6.Location = new System.Drawing.Point(0, 0);
            this.metroLabel6.Name = "metroLabel6";
            this.metroLabel6.Size = new System.Drawing.Size(256, 38);
            this.metroLabel6.TabIndex = 90;
            this.metroLabel6.Text = "O número CVV é representado pelos três \r\núltimos dígitos no verso do seu cartão. " +
    "";
            this.metroLabel6.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroLabel6.WrapToLine = true;
            // 
            // CvcExplain
            // 
            this.CvcExplain.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.CvcExplain.Controls.Add(this.pictureBox1);
            this.CvcExplain.Controls.Add(this.metroLabel6);
            this.CvcExplain.HorizontalScrollbarBarColor = true;
            this.CvcExplain.HorizontalScrollbarHighlightOnWheel = false;
            this.CvcExplain.HorizontalScrollbarSize = 10;
            this.CvcExplain.Location = new System.Drawing.Point(435, 152);
            this.CvcExplain.Name = "CvcExplain";
            this.CvcExplain.Size = new System.Drawing.Size(307, 251);
            this.CvcExplain.TabIndex = 91;
            this.CvcExplain.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.CvcExplain.VerticalScrollbarBarColor = true;
            this.CvcExplain.VerticalScrollbarHighlightOnWheel = false;
            this.CvcExplain.VerticalScrollbarSize = 10;
            this.CvcExplain.Visible = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(0, 52);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(306, 198);
            this.pictureBox1.TabIndex = 91;
            this.pictureBox1.TabStop = false;
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel1.Location = new System.Drawing.Point(58, 211);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(118, 19);
            this.metroLabel1.TabIndex = 92;
            this.metroLabel1.Text = "Data de Expiração";
            this.metroLabel1.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // register
            // 
            this.register.BackColor = System.Drawing.Color.Green;
            this.register.Location = new System.Drawing.Point(263, 286);
            this.register.Name = "register";
            this.register.Size = new System.Drawing.Size(95, 47);
            this.register.TabIndex = 93;
            this.register.Text = "Cadastrar";
            this.register.UseCustomBackColor = true;
            this.register.UseSelectable = true;
            this.register.Click += new System.EventHandler(this.register_Click);
            // 
            // cancel
            // 
            this.cancel.BackColor = System.Drawing.Color.Red;
            this.cancel.Location = new System.Drawing.Point(112, 286);
            this.cancel.Name = "cancel";
            this.cancel.Size = new System.Drawing.Size(95, 47);
            this.cancel.Style = MetroFramework.MetroColorStyle.Red;
            this.cancel.TabIndex = 94;
            this.cancel.Text = "Cancelar";
            this.cancel.UseCustomBackColor = true;
            this.cancel.UseSelectable = true;
            this.cancel.Click += new System.EventHandler(this.cancel_Click);
            // 
            // NewCard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(467, 452);
            this.Controls.Add(this.cancel);
            this.Controls.Add(this.register);
            this.Controls.Add(this.CvcExplain);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.year);
            this.Controls.Add(this.month);
            this.Controls.Add(this.numberCard);
            this.Controls.Add(this.CVC);
            this.Controls.Add(this.OwnerCard);
            this.Controls.Add(this.metroLabel3);
            this.Name = "NewCard";
            this.Resizable = false;
            this.Style = MetroFramework.MetroColorStyle.Orange;
            this.Text = "Cadastrar Cartão";
            this.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.Load += new System.EventHandler(this.NewCard_Load);
            this.CvcExplain.ResumeLayout(false);
            this.CvcExplain.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroTextBox OwnerCard;
        private MetroFramework.Controls.MetroTextBox CVC;
        private MetroFramework.Controls.MetroTextBox numberCard;
        private MetroFramework.Controls.MetroComboBox month;
        private MetroFramework.Controls.MetroComboBox year;
        private MetroFramework.Controls.MetroLabel metroLabel6;
        private MetroFramework.Controls.MetroPanel CvcExplain;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private MetroFramework.Controls.MetroButton register;
        private MetroFramework.Controls.MetroButton cancel;
    }
}