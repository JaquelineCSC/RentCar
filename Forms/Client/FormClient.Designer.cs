namespace CarLand
{
    partial class FormClient
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormClient));
            this.metroTabControl1 = new MetroFramework.Controls.MetroTabControl();
            this.metroTabPage1 = new MetroFramework.Controls.MetroTabPage();
            this.metroTile3 = new MetroFramework.Controls.MetroTile();
            this.settingsTile2 = new MetroFramework.Controls.MetroTile();
            this.metroTile5 = new MetroFramework.Controls.MetroTile();
            this.metroTile4 = new MetroFramework.Controls.MetroTile();
            this.metroTile2 = new MetroFramework.Controls.MetroTile();
            this.metroTile1 = new MetroFramework.Controls.MetroTile();
            this.metroLinkLogout = new MetroFramework.Controls.MetroLink();
            this.panelSettings2 = new MetroFramework.Controls.MetroPanel();
            this.metroPanel2 = new MetroFramework.Controls.MetroPanel();
            this.metroLabel6 = new MetroFramework.Controls.MetroLabel();
            this.metroTabPage3 = new MetroFramework.Controls.MetroTabPage();
            this.setDark2 = new MetroFramework.Controls.MetroButton();
            this.setLight2 = new MetroFramework.Controls.MetroButton();
            this.themes = new MetroFramework.Controls.MetroTabControl();
            this.mostrar2 = new System.Windows.Forms.Timer(this.components);
            this.esconder2 = new System.Windows.Forms.Timer(this.components);
            this.metroStyleManager2 = new MetroFramework.Components.MetroStyleManager(this.components);
            this.metroTabControl1.SuspendLayout();
            this.metroTabPage1.SuspendLayout();
            this.panelSettings2.SuspendLayout();
            this.metroPanel2.SuspendLayout();
            this.metroTabPage3.SuspendLayout();
            this.themes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.metroStyleManager2)).BeginInit();
            this.SuspendLayout();
            // 
            // metroTabControl1
            // 
            this.metroTabControl1.Controls.Add(this.metroTabPage1);
            this.metroTabControl1.Location = new System.Drawing.Point(20, 62);
            this.metroTabControl1.Name = "metroTabControl1";
            this.metroTabControl1.SelectedIndex = 0;
            this.metroTabControl1.Size = new System.Drawing.Size(1189, 703);
            this.metroTabControl1.Style = MetroFramework.MetroColorStyle.Orange;
            this.metroTabControl1.TabIndex = 0;
            this.metroTabControl1.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroTabControl1.UseSelectable = true;
            // 
            // metroTabPage1
            // 
            this.metroTabPage1.Controls.Add(this.panelSettings2);
            this.metroTabPage1.Controls.Add(this.metroTile3);
            this.metroTabPage1.Controls.Add(this.settingsTile2);
            this.metroTabPage1.Controls.Add(this.metroTile5);
            this.metroTabPage1.Controls.Add(this.metroTile4);
            this.metroTabPage1.Controls.Add(this.metroTile2);
            this.metroTabPage1.Controls.Add(this.metroTile1);
            this.metroTabPage1.HorizontalScrollbarBarColor = true;
            this.metroTabPage1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroTabPage1.HorizontalScrollbarSize = 10;
            this.metroTabPage1.Location = new System.Drawing.Point(4, 38);
            this.metroTabPage1.Name = "metroTabPage1";
            this.metroTabPage1.Size = new System.Drawing.Size(1181, 661);
            this.metroTabPage1.TabIndex = 0;
            this.metroTabPage1.Text = "Home";
            this.metroTabPage1.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroTabPage1.VerticalScrollbarBarColor = true;
            this.metroTabPage1.VerticalScrollbarHighlightOnWheel = false;
            this.metroTabPage1.VerticalScrollbarSize = 10;
            this.metroTabPage1.Click += new System.EventHandler(this.metroTabPage1_Click);
            // 
            // metroTile3
            // 
            this.metroTile3.ActiveControl = null;
            this.metroTile3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.metroTile3.Location = new System.Drawing.Point(296, 336);
            this.metroTile3.Name = "metroTile3";
            this.metroTile3.Size = new System.Drawing.Size(132, 126);
            this.metroTile3.Style = MetroFramework.MetroColorStyle.Orange;
            this.metroTile3.TabIndex = 7;
            this.metroTile3.Text = "Aluguel";
            this.metroTile3.TileImage = ((System.Drawing.Image)(resources.GetObject("metroTile3.TileImage")));
            this.metroTile3.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.metroTile3.UseSelectable = true;
            this.metroTile3.UseTileImage = true;
            this.metroTile3.Click += new System.EventHandler(this.metroTile3_Click);
            // 
            // settingsTile2
            // 
            this.settingsTile2.ActiveControl = null;
            this.settingsTile2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.settingsTile2.BackColor = System.Drawing.Color.Black;
            this.settingsTile2.ForeColor = System.Drawing.Color.Black;
            this.settingsTile2.Location = new System.Drawing.Point(571, 205);
            this.settingsTile2.Name = "settingsTile2";
            this.settingsTile2.Size = new System.Drawing.Size(132, 258);
            this.settingsTile2.Style = MetroFramework.MetroColorStyle.Orange;
            this.settingsTile2.TabIndex = 6;
            this.settingsTile2.Text = "Configurações";
            this.settingsTile2.TileImage = ((System.Drawing.Image)(resources.GetObject("settingsTile2.TileImage")));
            this.settingsTile2.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.settingsTile2.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Regular;
            this.settingsTile2.UseMnemonic = false;
            this.settingsTile2.UseSelectable = true;
            this.settingsTile2.UseTileImage = true;
            this.settingsTile2.Click += new System.EventHandler(this.settingsTile2_Click);
            // 
            // metroTile5
            // 
            this.metroTile5.ActiveControl = null;
            this.metroTile5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.metroTile5.Location = new System.Drawing.Point(708, 336);
            this.metroTile5.Name = "metroTile5";
            this.metroTile5.Size = new System.Drawing.Size(132, 126);
            this.metroTile5.Style = MetroFramework.MetroColorStyle.Orange;
            this.metroTile5.TabIndex = 3;
            this.metroTile5.Text = "Sobre Nós";
            this.metroTile5.TileImage = ((System.Drawing.Image)(resources.GetObject("metroTile5.TileImage")));
            this.metroTile5.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.metroTile5.UseSelectable = true;
            this.metroTile5.UseTileImage = true;
            this.metroTile5.Click += new System.EventHandler(this.metroTile5_Click);
            // 
            // metroTile4
            // 
            this.metroTile4.ActiveControl = null;
            this.metroTile4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.metroTile4.Location = new System.Drawing.Point(434, 336);
            this.metroTile4.Name = "metroTile4";
            this.metroTile4.Size = new System.Drawing.Size(132, 126);
            this.metroTile4.Style = MetroFramework.MetroColorStyle.Orange;
            this.metroTile4.TabIndex = 5;
            this.metroTile4.Text = "Alugar Carros";
            this.metroTile4.TileImage = ((System.Drawing.Image)(resources.GetObject("metroTile4.TileImage")));
            this.metroTile4.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.metroTile4.UseSelectable = true;
            this.metroTile4.UseTileImage = true;
            this.metroTile4.Click += new System.EventHandler(this.metroTile4_Click);
            // 
            // metroTile2
            // 
            this.metroTile2.ActiveControl = null;
            this.metroTile2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.metroTile2.Location = new System.Drawing.Point(434, 204);
            this.metroTile2.Name = "metroTile2";
            this.metroTile2.Size = new System.Drawing.Size(132, 126);
            this.metroTile2.Style = MetroFramework.MetroColorStyle.Orange;
            this.metroTile2.TabIndex = 3;
            this.metroTile2.Text = "Carteira";
            this.metroTile2.TileImage = ((System.Drawing.Image)(resources.GetObject("metroTile2.TileImage")));
            this.metroTile2.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.metroTile2.UseSelectable = true;
            this.metroTile2.UseTileImage = true;
            this.metroTile2.Click += new System.EventHandler(this.metroTile2_Click);
            // 
            // metroTile1
            // 
            this.metroTile1.ActiveControl = null;
            this.metroTile1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.metroTile1.Location = new System.Drawing.Point(296, 204);
            this.metroTile1.Name = "metroTile1";
            this.metroTile1.Size = new System.Drawing.Size(132, 126);
            this.metroTile1.Style = MetroFramework.MetroColorStyle.Orange;
            this.metroTile1.TabIndex = 2;
            this.metroTile1.Text = "Perfil";
            this.metroTile1.TileImage = ((System.Drawing.Image)(resources.GetObject("metroTile1.TileImage")));
            this.metroTile1.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.metroTile1.UseSelectable = true;
            this.metroTile1.UseTileImage = true;
            this.metroTile1.Click += new System.EventHandler(this.metroTile1_Click);
            // 
            // metroLinkLogout
            // 
            this.metroLinkLogout.Image = ((System.Drawing.Image)(resources.GetObject("metroLinkLogout.Image")));
            this.metroLinkLogout.ImageSize = 40;
            this.metroLinkLogout.Location = new System.Drawing.Point(1136, 28);
            this.metroLinkLogout.Name = "metroLinkLogout";
            this.metroLinkLogout.Size = new System.Drawing.Size(45, 46);
            this.metroLinkLogout.TabIndex = 2;
            this.metroLinkLogout.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroLinkLogout.UseSelectable = true;
            this.metroLinkLogout.Click += new System.EventHandler(this.metroLinkLogout_Click);
            // 
            // panelSettings2
            // 
            this.panelSettings2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelSettings2.Controls.Add(this.themes);
            this.panelSettings2.Controls.Add(this.metroPanel2);
            this.panelSettings2.HorizontalScrollbarBarColor = true;
            this.panelSettings2.HorizontalScrollbarHighlightOnWheel = false;
            this.panelSettings2.HorizontalScrollbarSize = 10;
            this.panelSettings2.Location = new System.Drawing.Point(872, 3);
            this.panelSettings2.Name = "panelSettings2";
            this.panelSettings2.Size = new System.Drawing.Size(275, 379);
            this.panelSettings2.TabIndex = 11;
            this.panelSettings2.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.panelSettings2.VerticalScrollbarBarColor = true;
            this.panelSettings2.VerticalScrollbarHighlightOnWheel = false;
            this.panelSettings2.VerticalScrollbarSize = 10;
            // 
            // metroPanel2
            // 
            this.metroPanel2.Controls.Add(this.metroLabel6);
            this.metroPanel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.metroPanel2.HorizontalScrollbarBarColor = true;
            this.metroPanel2.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel2.HorizontalScrollbarSize = 10;
            this.metroPanel2.Location = new System.Drawing.Point(0, 0);
            this.metroPanel2.Name = "metroPanel2";
            this.metroPanel2.Size = new System.Drawing.Size(273, 66);
            this.metroPanel2.TabIndex = 3;
            this.metroPanel2.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroPanel2.VerticalScrollbarBarColor = true;
            this.metroPanel2.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel2.VerticalScrollbarSize = 10;
            // 
            // metroLabel6
            // 
            this.metroLabel6.AutoSize = true;
            this.metroLabel6.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel6.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel6.Location = new System.Drawing.Point(20, 19);
            this.metroLabel6.Name = "metroLabel6";
            this.metroLabel6.Size = new System.Drawing.Size(134, 25);
            this.metroLabel6.TabIndex = 25;
            this.metroLabel6.Text = "Configurações";
            this.metroLabel6.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // metroTabPage3
            // 
            this.metroTabPage3.Controls.Add(this.setLight2);
            this.metroTabPage3.Controls.Add(this.setDark2);
            this.metroTabPage3.HorizontalScrollbarBarColor = true;
            this.metroTabPage3.HorizontalScrollbarHighlightOnWheel = false;
            this.metroTabPage3.HorizontalScrollbarSize = 10;
            this.metroTabPage3.Location = new System.Drawing.Point(4, 38);
            this.metroTabPage3.Name = "metroTabPage3";
            this.metroTabPage3.Size = new System.Drawing.Size(263, 245);
            this.metroTabPage3.TabIndex = 0;
            this.metroTabPage3.Text = "Temas";
            this.metroTabPage3.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroTabPage3.VerticalScrollbarBarColor = true;
            this.metroTabPage3.VerticalScrollbarHighlightOnWheel = false;
            this.metroTabPage3.VerticalScrollbarSize = 10;
            // 
            // setDark2
            // 
            this.setDark2.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.setDark2.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.setDark2.FontWeight = MetroFramework.MetroButtonWeight.Light;
            this.setDark2.Location = new System.Drawing.Point(33, 46);
            this.setDark2.Margin = new System.Windows.Forms.Padding(0);
            this.setDark2.Name = "setDark2";
            this.setDark2.Size = new System.Drawing.Size(206, 60);
            this.setDark2.TabIndex = 20;
            this.setDark2.UseCustomBackColor = true;
            this.setDark2.UseSelectable = true;
            this.setDark2.Click += new System.EventHandler(this.metroButton13_Click);
            // 
            // setLight2
            // 
            this.setLight2.BackColor = System.Drawing.Color.White;
            this.setLight2.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.setLight2.FontWeight = MetroFramework.MetroButtonWeight.Light;
            this.setLight2.Location = new System.Drawing.Point(33, 126);
            this.setLight2.Margin = new System.Windows.Forms.Padding(0);
            this.setLight2.Name = "setLight2";
            this.setLight2.Size = new System.Drawing.Size(206, 60);
            this.setLight2.TabIndex = 21;
            this.setLight2.UseCustomBackColor = true;
            this.setLight2.UseSelectable = true;
            this.setLight2.Click += new System.EventHandler(this.setLight2_Click);
            // 
            // themes
            // 
            this.themes.Controls.Add(this.metroTabPage3);
            this.themes.Location = new System.Drawing.Point(2, 67);
            this.themes.Name = "themes";
            this.themes.SelectedIndex = 0;
            this.themes.Size = new System.Drawing.Size(271, 287);
            this.themes.Style = MetroFramework.MetroColorStyle.Orange;
            this.themes.TabIndex = 10;
            this.themes.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.themes.UseSelectable = true;
            // 
            // mostrar2
            // 
            this.mostrar2.Interval = 10;
            this.mostrar2.Tick += new System.EventHandler(this.mostrar2_Tick);
            // 
            // esconder2
            // 
            this.esconder2.Interval = 10;
            this.esconder2.Tick += new System.EventHandler(this.esconder2_Tick);
            // 
            // metroStyleManager2
            // 
            this.metroStyleManager2.Owner = this;
            this.metroStyleManager2.Style = MetroFramework.MetroColorStyle.Orange;
            // 
            // FormClient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackImagePadding = new System.Windows.Forms.Padding(10, 10, 0, 0);
            this.BackMaxSize = 105;
            this.ClientSize = new System.Drawing.Size(1280, 788);
            this.Controls.Add(this.metroLinkLogout);
            this.Controls.Add(this.metroTabControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormClient";
            this.Resizable = false;
            this.Style = MetroFramework.MetroColorStyle.Orange;
            this.Text = "Usuário";
            this.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmUsuario_Load);
            this.metroTabControl1.ResumeLayout(false);
            this.metroTabPage1.ResumeLayout(false);
            this.panelSettings2.ResumeLayout(false);
            this.metroPanel2.ResumeLayout(false);
            this.metroPanel2.PerformLayout();
            this.metroTabPage3.ResumeLayout(false);
            this.themes.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.metroStyleManager2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroTabControl metroTabControl1;
        private MetroFramework.Controls.MetroTabPage metroTabPage1;
        private MetroFramework.Controls.MetroTile metroTile4;
        private MetroFramework.Controls.MetroTile metroTile2;
        private MetroFramework.Controls.MetroTile metroTile1;
        private MetroFramework.Controls.MetroTile metroTile5;
        private MetroFramework.Controls.MetroTile settingsTile2;
        private MetroFramework.Controls.MetroTile metroTile3;
        private MetroFramework.Controls.MetroLink metroLinkLogout;
        private MetroFramework.Controls.MetroPanel panelSettings2;
        private MetroFramework.Controls.MetroTabControl themes;
        private MetroFramework.Controls.MetroTabPage metroTabPage3;
        private MetroFramework.Controls.MetroButton setLight2;
        private MetroFramework.Controls.MetroButton setDark2;
        private MetroFramework.Controls.MetroPanel metroPanel2;
        private MetroFramework.Controls.MetroLabel metroLabel6;
        private System.Windows.Forms.Timer mostrar2;
        private System.Windows.Forms.Timer esconder2;
        private MetroFramework.Components.MetroStyleManager metroStyleManager2;
    }
}