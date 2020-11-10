namespace CarLand
{
    partial class FrmUsuario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmUsuario));
            this.metroTabControl1 = new MetroFramework.Controls.MetroTabControl();
            this.metroTabPage1 = new MetroFramework.Controls.MetroTabPage();
            this.metroTile3 = new MetroFramework.Controls.MetroTile();
            this.metroTile6 = new MetroFramework.Controls.MetroTile();
            this.metroTile5 = new MetroFramework.Controls.MetroTile();
            this.metroTile4 = new MetroFramework.Controls.MetroTile();
            this.metroTile2 = new MetroFramework.Controls.MetroTile();
            this.metroTile1 = new MetroFramework.Controls.MetroTile();
            this.metroLinkLogout = new MetroFramework.Controls.MetroLink();
            this.metroTabControl1.SuspendLayout();
            this.metroTabPage1.SuspendLayout();
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
            this.metroTabPage1.Controls.Add(this.metroTile3);
            this.metroTabPage1.Controls.Add(this.metroTile6);
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
            // 
            // metroTile6
            // 
            this.metroTile6.ActiveControl = null;
            this.metroTile6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.metroTile6.BackColor = System.Drawing.Color.Black;
            this.metroTile6.ForeColor = System.Drawing.Color.Black;
            this.metroTile6.Location = new System.Drawing.Point(571, 205);
            this.metroTile6.Name = "metroTile6";
            this.metroTile6.Size = new System.Drawing.Size(132, 258);
            this.metroTile6.Style = MetroFramework.MetroColorStyle.Orange;
            this.metroTile6.TabIndex = 6;
            this.metroTile6.Text = "Configurações";
            this.metroTile6.TileImage = ((System.Drawing.Image)(resources.GetObject("metroTile6.TileImage")));
            this.metroTile6.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.metroTile6.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Regular;
            this.metroTile6.UseMnemonic = false;
            this.metroTile6.UseSelectable = true;
            this.metroTile6.UseTileImage = true;
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
            // FrmUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackImagePadding = new System.Windows.Forms.Padding(10, 10, 0, 0);
            this.BackMaxSize = 105;
            this.ClientSize = new System.Drawing.Size(1280, 788);
            this.Controls.Add(this.metroLinkLogout);
            this.Controls.Add(this.metroTabControl1);
            this.Name = "FrmUsuario";
            this.Resizable = false;
            this.Style = MetroFramework.MetroColorStyle.Orange;
            this.Text = "Usuário";
            this.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmUsuario_Load);
            this.metroTabControl1.ResumeLayout(false);
            this.metroTabPage1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroTabControl metroTabControl1;
        private MetroFramework.Controls.MetroTabPage metroTabPage1;
        private MetroFramework.Controls.MetroTile metroTile4;
        private MetroFramework.Controls.MetroTile metroTile2;
        private MetroFramework.Controls.MetroTile metroTile1;
        private MetroFramework.Controls.MetroTile metroTile5;
        private MetroFramework.Controls.MetroTile metroTile6;
        private MetroFramework.Controls.MetroTile metroTile3;
        private MetroFramework.Controls.MetroLink metroLinkLogout;
    }
}