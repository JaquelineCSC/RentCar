namespace CarLand.Forms
{
    partial class FrmPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPrincipal));
            this.tabControl = new MetroFramework.Controls.MetroTabControl();
            this.tabControlPrincipal = new MetroFramework.Controls.MetroTabPage();
            this.reportTile = new MetroFramework.Controls.MetroTile();
            this.listRentTile = new MetroFramework.Controls.MetroTile();
            this.rentTile = new MetroFramework.Controls.MetroTile();
            this.paymentTile = new MetroFramework.Controls.MetroTile();
            this.clientsTile = new MetroFramework.Controls.MetroTile();
            this.employeeTile = new MetroFramework.Controls.MetroTile();
            this.settingsTile = new MetroFramework.Controls.MetroTile();
            this.carsTile = new MetroFramework.Controls.MetroTile();
            this.metroLinkLogout = new MetroFramework.Controls.MetroLink();
            this.panelSettings = new MetroFramework.Controls.MetroPanel();
            this.styles = new MetroFramework.Controls.MetroTabControl();
            this.metroTabPage2 = new MetroFramework.Controls.MetroTabPage();
            this.pink = new MetroFramework.Controls.MetroButton();
            this.lime = new MetroFramework.Controls.MetroButton();
            this.blue = new MetroFramework.Controls.MetroButton();
            this.brown = new MetroFramework.Controls.MetroButton();
            this.magenta = new MetroFramework.Controls.MetroButton();
            this.yellow = new MetroFramework.Controls.MetroButton();
            this.red = new MetroFramework.Controls.MetroButton();
            this.silver = new MetroFramework.Controls.MetroButton();
            this.orange = new MetroFramework.Controls.MetroButton();
            this.green = new MetroFramework.Controls.MetroButton();
            this.purple = new MetroFramework.Controls.MetroButton();
            this.teal = new MetroFramework.Controls.MetroButton();
            this.themes = new MetroFramework.Controls.MetroTabControl();
            this.metroTabPage3 = new MetroFramework.Controls.MetroTabPage();
            this.metroButton12 = new MetroFramework.Controls.MetroButton();
            this.metroButton13 = new MetroFramework.Controls.MetroButton();
            this.metroPanel2 = new MetroFramework.Controls.MetroPanel();
            this.metroLabel6 = new MetroFramework.Controls.MetroLabel();
            this.mostrar = new System.Windows.Forms.Timer(this.components);
            this.esconder = new System.Windows.Forms.Timer(this.components);
            this.metroStyleManager1 = new MetroFramework.Components.MetroStyleManager(this.components);
            this.tabControl.SuspendLayout();
            this.tabControlPrincipal.SuspendLayout();
            this.panelSettings.SuspendLayout();
            this.styles.SuspendLayout();
            this.metroTabPage2.SuspendLayout();
            this.themes.SuspendLayout();
            this.metroTabPage3.SuspendLayout();
            this.metroPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.metroStyleManager1)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tabControlPrincipal);
            this.tabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl.Location = new System.Drawing.Point(20, 60);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(1240, 708);
            this.tabControl.Style = MetroFramework.MetroColorStyle.Orange;
            this.tabControl.TabIndex = 0;
            this.tabControl.Tag = "";
            this.tabControl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.tabControl.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.tabControl.UseSelectable = true;
            // 
            // tabControlPrincipal
            // 
            this.tabControlPrincipal.Controls.Add(this.reportTile);
            this.tabControlPrincipal.Controls.Add(this.listRentTile);
            this.tabControlPrincipal.Controls.Add(this.rentTile);
            this.tabControlPrincipal.Controls.Add(this.paymentTile);
            this.tabControlPrincipal.Controls.Add(this.clientsTile);
            this.tabControlPrincipal.Controls.Add(this.employeeTile);
            this.tabControlPrincipal.Controls.Add(this.settingsTile);
            this.tabControlPrincipal.Controls.Add(this.carsTile);
            this.tabControlPrincipal.HorizontalScrollbarBarColor = true;
            this.tabControlPrincipal.HorizontalScrollbarHighlightOnWheel = false;
            this.tabControlPrincipal.HorizontalScrollbarSize = 10;
            this.tabControlPrincipal.Location = new System.Drawing.Point(4, 38);
            this.tabControlPrincipal.Name = "tabControlPrincipal";
            this.tabControlPrincipal.Size = new System.Drawing.Size(1232, 666);
            this.tabControlPrincipal.TabIndex = 0;
            this.tabControlPrincipal.Text = "Home";
            this.tabControlPrincipal.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.tabControlPrincipal.VerticalScrollbarBarColor = true;
            this.tabControlPrincipal.VerticalScrollbarHighlightOnWheel = false;
            this.tabControlPrincipal.VerticalScrollbarSize = 10;
            // 
            // reportTile
            // 
            this.reportTile.ActiveControl = null;
            this.reportTile.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.reportTile.Location = new System.Drawing.Point(783, 354);
            this.reportTile.Name = "reportTile";
            this.reportTile.Size = new System.Drawing.Size(129, 130);
            this.reportTile.Style = MetroFramework.MetroColorStyle.Orange;
            this.reportTile.TabIndex = 10;
            this.reportTile.Text = "Relatórios";
            this.reportTile.TileImage = ((System.Drawing.Image)(resources.GetObject("reportTile.TileImage")));
            this.reportTile.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.reportTile.UseSelectable = true;
            this.reportTile.UseTileImage = true;
            // 
            // listRentTile
            // 
            this.listRentTile.ActiveControl = null;
            this.listRentTile.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.listRentTile.Location = new System.Drawing.Point(648, 218);
            this.listRentTile.Name = "listRentTile";
            this.listRentTile.Size = new System.Drawing.Size(129, 130);
            this.listRentTile.Style = MetroFramework.MetroColorStyle.Orange;
            this.listRentTile.TabIndex = 9;
            this.listRentTile.Text = "Aluguel";
            this.listRentTile.TileImage = ((System.Drawing.Image)(resources.GetObject("listRentTile.TileImage")));
            this.listRentTile.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.listRentTile.UseSelectable = true;
            this.listRentTile.UseTileImage = true;
            // 
            // rentTile
            // 
            this.rentTile.ActiveControl = null;
            this.rentTile.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.rentTile.Location = new System.Drawing.Point(375, 218);
            this.rentTile.Name = "rentTile";
            this.rentTile.Size = new System.Drawing.Size(129, 130);
            this.rentTile.Style = MetroFramework.MetroColorStyle.Orange;
            this.rentTile.TabIndex = 8;
            this.rentTile.Text = "Alugar Carros";
            this.rentTile.TileImage = ((System.Drawing.Image)(resources.GetObject("rentTile.TileImage")));
            this.rentTile.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.rentTile.UseSelectable = true;
            this.rentTile.UseTileImage = true;
            this.rentTile.Click += new System.EventHandler(this.ShowCars);
            // 
            // paymentTile
            // 
            this.paymentTile.ActiveControl = null;
            this.paymentTile.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.paymentTile.Location = new System.Drawing.Point(648, 354);
            this.paymentTile.Name = "paymentTile";
            this.paymentTile.Size = new System.Drawing.Size(129, 130);
            this.paymentTile.Style = MetroFramework.MetroColorStyle.Orange;
            this.paymentTile.TabIndex = 7;
            this.paymentTile.Text = "Pagamentos";
            this.paymentTile.TileImage = ((System.Drawing.Image)(resources.GetObject("paymentTile.TileImage")));
            this.paymentTile.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.paymentTile.UseSelectable = true;
            this.paymentTile.UseTileImage = true;
            // 
            // clientsTile
            // 
            this.clientsTile.ActiveControl = null;
            this.clientsTile.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.clientsTile.BackColor = System.Drawing.Color.Black;
            this.clientsTile.Location = new System.Drawing.Point(375, 354);
            this.clientsTile.Name = "clientsTile";
            this.clientsTile.Size = new System.Drawing.Size(129, 130);
            this.clientsTile.Style = MetroFramework.MetroColorStyle.Orange;
            this.clientsTile.TabIndex = 5;
            this.clientsTile.Text = "Clientes";
            this.clientsTile.TileImage = ((System.Drawing.Image)(resources.GetObject("clientsTile.TileImage")));
            this.clientsTile.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.clientsTile.UseSelectable = true;
            this.clientsTile.UseTileImage = true;
            // 
            // employeeTile
            // 
            this.employeeTile.ActiveControl = null;
            this.employeeTile.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.employeeTile.BackColor = System.Drawing.Color.Black;
            this.employeeTile.Location = new System.Drawing.Point(240, 354);
            this.employeeTile.Name = "employeeTile";
            this.employeeTile.Size = new System.Drawing.Size(129, 130);
            this.employeeTile.Style = MetroFramework.MetroColorStyle.Orange;
            this.employeeTile.TabIndex = 4;
            this.employeeTile.Text = "Funionários";
            this.employeeTile.TileImage = ((System.Drawing.Image)(resources.GetObject("employeeTile.TileImage")));
            this.employeeTile.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.employeeTile.UseSelectable = true;
            this.employeeTile.UseTileImage = true;
            // 
            // settingsTile
            // 
            this.settingsTile.ActiveControl = null;
            this.settingsTile.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.settingsTile.BackColor = System.Drawing.Color.Black;
            this.settingsTile.ForeColor = System.Drawing.Color.Black;
            this.settingsTile.Location = new System.Drawing.Point(510, 218);
            this.settingsTile.Name = "settingsTile";
            this.settingsTile.Size = new System.Drawing.Size(132, 266);
            this.settingsTile.Style = MetroFramework.MetroColorStyle.Orange;
            this.settingsTile.TabIndex = 3;
            this.settingsTile.Text = "Configurações";
            this.settingsTile.TileImage = ((System.Drawing.Image)(resources.GetObject("settingsTile.TileImage")));
            this.settingsTile.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.settingsTile.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Regular;
            this.settingsTile.UseMnemonic = false;
            this.settingsTile.UseSelectable = true;
            this.settingsTile.UseTileImage = true;
            this.settingsTile.Click += new System.EventHandler(this.settingsShowAndHide);
            // 
            // carsTile
            // 
            this.carsTile.ActiveControl = null;
            this.carsTile.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.carsTile.BackColor = System.Drawing.Color.Black;
            this.carsTile.Location = new System.Drawing.Point(240, 218);
            this.carsTile.Name = "carsTile";
            this.carsTile.Size = new System.Drawing.Size(129, 130);
            this.carsTile.Style = MetroFramework.MetroColorStyle.Orange;
            this.carsTile.TabIndex = 2;
            this.carsTile.Text = "Carros";
            this.carsTile.Theme = MetroFramework.MetroThemeStyle.Light;
            this.carsTile.TileImage = ((System.Drawing.Image)(resources.GetObject("carsTile.TileImage")));
            this.carsTile.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.carsTile.UseSelectable = true;
            this.carsTile.UseTileImage = true;
            this.carsTile.Click += new System.EventHandler(this.ShowListCar);
            // 
            // metroLinkLogout
            // 
            this.metroLinkLogout.Image = ((System.Drawing.Image)(resources.GetObject("metroLinkLogout.Image")));
            this.metroLinkLogout.ImageSize = 40;
            this.metroLinkLogout.Location = new System.Drawing.Point(1193, 36);
            this.metroLinkLogout.Name = "metroLinkLogout";
            this.metroLinkLogout.Size = new System.Drawing.Size(49, 46);
            this.metroLinkLogout.TabIndex = 1;
            this.metroLinkLogout.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroLinkLogout.UseSelectable = true;
            this.metroLinkLogout.Click += new System.EventHandler(this.ShowLogin);
            // 
            // panelSettings
            // 
            this.panelSettings.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelSettings.Controls.Add(this.styles);
            this.panelSettings.Controls.Add(this.themes);
            this.panelSettings.Controls.Add(this.metroPanel2);
            this.panelSettings.HorizontalScrollbarBarColor = true;
            this.panelSettings.HorizontalScrollbarHighlightOnWheel = false;
            this.panelSettings.HorizontalScrollbarSize = 10;
            this.panelSettings.Location = new System.Drawing.Point(922, 28);
            this.panelSettings.Name = "panelSettings";
            this.panelSettings.Size = new System.Drawing.Size(275, 761);
            this.panelSettings.TabIndex = 10;
            this.panelSettings.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.panelSettings.VerticalScrollbarBarColor = true;
            this.panelSettings.VerticalScrollbarHighlightOnWheel = false;
            this.panelSettings.VerticalScrollbarSize = 10;
            // 
            // styles
            // 
            this.styles.Controls.Add(this.metroTabPage2);
            this.styles.Location = new System.Drawing.Point(3, 380);
            this.styles.Name = "styles";
            this.styles.SelectedIndex = 0;
            this.styles.Size = new System.Drawing.Size(270, 359);
            this.styles.Style = MetroFramework.MetroColorStyle.Orange;
            this.styles.TabIndex = 11;
            this.styles.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.styles.UseSelectable = true;
            // 
            // metroTabPage2
            // 
            this.metroTabPage2.Controls.Add(this.pink);
            this.metroTabPage2.Controls.Add(this.lime);
            this.metroTabPage2.Controls.Add(this.blue);
            this.metroTabPage2.Controls.Add(this.brown);
            this.metroTabPage2.Controls.Add(this.magenta);
            this.metroTabPage2.Controls.Add(this.yellow);
            this.metroTabPage2.Controls.Add(this.red);
            this.metroTabPage2.Controls.Add(this.silver);
            this.metroTabPage2.Controls.Add(this.orange);
            this.metroTabPage2.Controls.Add(this.green);
            this.metroTabPage2.Controls.Add(this.purple);
            this.metroTabPage2.Controls.Add(this.teal);
            this.metroTabPage2.HorizontalScrollbarBarColor = true;
            this.metroTabPage2.HorizontalScrollbarHighlightOnWheel = false;
            this.metroTabPage2.HorizontalScrollbarSize = 10;
            this.metroTabPage2.Location = new System.Drawing.Point(4, 38);
            this.metroTabPage2.Name = "metroTabPage2";
            this.metroTabPage2.Size = new System.Drawing.Size(262, 317);
            this.metroTabPage2.TabIndex = 0;
            this.metroTabPage2.Text = "Estilos";
            this.metroTabPage2.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroTabPage2.VerticalScrollbarBarColor = true;
            this.metroTabPage2.VerticalScrollbarHighlightOnWheel = false;
            this.metroTabPage2.VerticalScrollbarSize = 10;
            // 
            // pink
            // 
            this.pink.BackColor = System.Drawing.Color.Pink;
            this.pink.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.pink.FontWeight = MetroFramework.MetroButtonWeight.Light;
            this.pink.Location = new System.Drawing.Point(182, 38);
            this.pink.Margin = new System.Windows.Forms.Padding(0);
            this.pink.Name = "pink";
            this.pink.Size = new System.Drawing.Size(80, 60);
            this.pink.TabIndex = 22;
            this.pink.Tag = "Pink";
            this.pink.UseCustomBackColor = true;
            this.pink.UseSelectable = true;
            this.pink.Click += new System.EventHandler(this.setColor);
            // 
            // lime
            // 
            this.lime.BackColor = System.Drawing.Color.Lime;
            this.lime.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.lime.FontWeight = MetroFramework.MetroButtonWeight.Light;
            this.lime.Location = new System.Drawing.Point(92, 254);
            this.lime.Margin = new System.Windows.Forms.Padding(0);
            this.lime.Name = "lime";
            this.lime.Size = new System.Drawing.Size(80, 60);
            this.lime.TabIndex = 21;
            this.lime.Tag = "Lime";
            this.lime.UseCustomBackColor = true;
            this.lime.UseSelectable = true;
            this.lime.Click += new System.EventHandler(this.setColor);
            // 
            // blue
            // 
            this.blue.BackColor = System.Drawing.Color.Blue;
            this.blue.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.blue.FontWeight = MetroFramework.MetroButtonWeight.Light;
            this.blue.Location = new System.Drawing.Point(2, 254);
            this.blue.Margin = new System.Windows.Forms.Padding(0);
            this.blue.Name = "blue";
            this.blue.Size = new System.Drawing.Size(80, 60);
            this.blue.Style = MetroFramework.MetroColorStyle.Silver;
            this.blue.TabIndex = 20;
            this.blue.Tag = "Blue";
            this.blue.UseCustomBackColor = true;
            this.blue.UseSelectable = true;
            this.blue.Click += new System.EventHandler(this.setColor);
            // 
            // brown
            // 
            this.brown.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(51)))), ((int)(((byte)(23)))));
            this.brown.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.brown.FontWeight = MetroFramework.MetroButtonWeight.Light;
            this.brown.Location = new System.Drawing.Point(92, 182);
            this.brown.Margin = new System.Windows.Forms.Padding(0);
            this.brown.Name = "brown";
            this.brown.Size = new System.Drawing.Size(80, 60);
            this.brown.TabIndex = 19;
            this.brown.Tag = "Brown";
            this.brown.UseCustomBackColor = true;
            this.brown.UseSelectable = true;
            this.brown.Click += new System.EventHandler(this.setColor);
            // 
            // magenta
            // 
            this.magenta.BackColor = System.Drawing.Color.Magenta;
            this.magenta.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.magenta.FontWeight = MetroFramework.MetroButtonWeight.Light;
            this.magenta.Location = new System.Drawing.Point(182, 182);
            this.magenta.Margin = new System.Windows.Forms.Padding(0);
            this.magenta.Name = "magenta";
            this.magenta.Size = new System.Drawing.Size(80, 60);
            this.magenta.TabIndex = 18;
            this.magenta.Tag = "Magenta";
            this.magenta.UseCustomBackColor = true;
            this.magenta.UseSelectable = true;
            this.magenta.Click += new System.EventHandler(this.setColor);
            // 
            // yellow
            // 
            this.yellow.BackColor = System.Drawing.Color.Yellow;
            this.yellow.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.yellow.FontWeight = MetroFramework.MetroButtonWeight.Light;
            this.yellow.Location = new System.Drawing.Point(2, 182);
            this.yellow.Margin = new System.Windows.Forms.Padding(0);
            this.yellow.Name = "yellow";
            this.yellow.Size = new System.Drawing.Size(80, 60);
            this.yellow.Style = MetroFramework.MetroColorStyle.Silver;
            this.yellow.TabIndex = 17;
            this.yellow.Tag = "Yellow";
            this.yellow.UseCustomBackColor = true;
            this.yellow.UseSelectable = true;
            this.yellow.Click += new System.EventHandler(this.setColor);
            // 
            // red
            // 
            this.red.BackColor = System.Drawing.Color.Red;
            this.red.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.red.FontWeight = MetroFramework.MetroButtonWeight.Light;
            this.red.Location = new System.Drawing.Point(92, 111);
            this.red.Margin = new System.Windows.Forms.Padding(0);
            this.red.Name = "red";
            this.red.Size = new System.Drawing.Size(80, 60);
            this.red.TabIndex = 15;
            this.red.Tag = "Red";
            this.red.UseCustomBackColor = true;
            this.red.UseSelectable = true;
            this.red.Click += new System.EventHandler(this.setColor);
            // 
            // silver
            // 
            this.silver.BackColor = System.Drawing.Color.Gray;
            this.silver.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.silver.FontWeight = MetroFramework.MetroButtonWeight.Light;
            this.silver.Location = new System.Drawing.Point(182, 111);
            this.silver.Margin = new System.Windows.Forms.Padding(0);
            this.silver.Name = "silver";
            this.silver.Size = new System.Drawing.Size(80, 60);
            this.silver.TabIndex = 16;
            this.silver.Tag = "Silver";
            this.silver.UseCustomBackColor = true;
            this.silver.UseSelectable = true;
            this.silver.Click += new System.EventHandler(this.setColor);
            // 
            // orange
            // 
            this.orange.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.orange.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.orange.FontWeight = MetroFramework.MetroButtonWeight.Light;
            this.orange.Location = new System.Drawing.Point(2, 38);
            this.orange.Margin = new System.Windows.Forms.Padding(0);
            this.orange.Name = "orange";
            this.orange.Size = new System.Drawing.Size(80, 60);
            this.orange.TabIndex = 11;
            this.orange.Tag = "Orange";
            this.orange.UseCustomBackColor = true;
            this.orange.UseSelectable = true;
            this.orange.Click += new System.EventHandler(this.setColor);
            // 
            // green
            // 
            this.green.BackColor = System.Drawing.Color.Green;
            this.green.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.green.FontWeight = MetroFramework.MetroButtonWeight.Light;
            this.green.Location = new System.Drawing.Point(92, 38);
            this.green.Margin = new System.Windows.Forms.Padding(0);
            this.green.Name = "green";
            this.green.Size = new System.Drawing.Size(80, 60);
            this.green.Style = MetroFramework.MetroColorStyle.Black;
            this.green.TabIndex = 12;
            this.green.Tag = "Green";
            this.green.UseCustomBackColor = true;
            this.green.UseSelectable = true;
            this.green.Click += new System.EventHandler(this.setColor);
            // 
            // purple
            // 
            this.purple.BackColor = System.Drawing.Color.Purple;
            this.purple.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.purple.FontWeight = MetroFramework.MetroButtonWeight.Light;
            this.purple.Location = new System.Drawing.Point(2, 111);
            this.purple.Margin = new System.Windows.Forms.Padding(0);
            this.purple.Name = "purple";
            this.purple.Size = new System.Drawing.Size(80, 60);
            this.purple.Style = MetroFramework.MetroColorStyle.White;
            this.purple.TabIndex = 14;
            this.purple.Tag = "Purple";
            this.purple.UseCustomBackColor = true;
            this.purple.UseSelectable = true;
            this.purple.Click += new System.EventHandler(this.setColor);
            // 
            // teal
            // 
            this.teal.BackColor = System.Drawing.Color.Teal;
            this.teal.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.teal.FontWeight = MetroFramework.MetroButtonWeight.Light;
            this.teal.Location = new System.Drawing.Point(182, 254);
            this.teal.Margin = new System.Windows.Forms.Padding(0);
            this.teal.Name = "teal";
            this.teal.Size = new System.Drawing.Size(80, 60);
            this.teal.TabIndex = 13;
            this.teal.Tag = "Teal";
            this.teal.UseCustomBackColor = true;
            this.teal.UseSelectable = true;
            this.teal.Click += new System.EventHandler(this.setColor);
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
            // metroTabPage3
            // 
            this.metroTabPage3.Controls.Add(this.metroButton12);
            this.metroTabPage3.Controls.Add(this.metroButton13);
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
            // metroButton12
            // 
            this.metroButton12.BackColor = System.Drawing.Color.White;
            this.metroButton12.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.metroButton12.FontWeight = MetroFramework.MetroButtonWeight.Light;
            this.metroButton12.Location = new System.Drawing.Point(33, 126);
            this.metroButton12.Margin = new System.Windows.Forms.Padding(0);
            this.metroButton12.Name = "metroButton12";
            this.metroButton12.Size = new System.Drawing.Size(206, 60);
            this.metroButton12.TabIndex = 21;
            this.metroButton12.UseCustomBackColor = true;
            this.metroButton12.UseSelectable = true;
            this.metroButton12.Click += new System.EventHandler(this.setLight);
            // 
            // metroButton13
            // 
            this.metroButton13.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.metroButton13.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.metroButton13.FontWeight = MetroFramework.MetroButtonWeight.Light;
            this.metroButton13.Location = new System.Drawing.Point(33, 46);
            this.metroButton13.Margin = new System.Windows.Forms.Padding(0);
            this.metroButton13.Name = "metroButton13";
            this.metroButton13.Size = new System.Drawing.Size(206, 60);
            this.metroButton13.TabIndex = 20;
            this.metroButton13.UseCustomBackColor = true;
            this.metroButton13.UseSelectable = true;
            this.metroButton13.Click += new System.EventHandler(this.setDark);
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
            // mostrar
            // 
            this.mostrar.Interval = 10;
            this.mostrar.Tick += new System.EventHandler(this.mostrar_Tick);
            // 
            // esconder
            // 
            this.esconder.Interval = 10;
            this.esconder.Tick += new System.EventHandler(this.esconder_Tick);
            // 
            // metroStyleManager1
            // 
            this.metroStyleManager1.Owner = this;
            this.metroStyleManager1.Style = MetroFramework.MetroColorStyle.Orange;
            this.metroStyleManager1.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // FrmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1280, 788);
            this.Controls.Add(this.panelSettings);
            this.Controls.Add(this.metroLinkLogout);
            this.Controls.Add(this.tabControl);
            this.Name = "FrmPrincipal";
            this.Resizable = false;
            this.Style = MetroFramework.MetroColorStyle.Orange;
            this.Text = "Administrador";
            this.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.tabControl.ResumeLayout(false);
            this.tabControlPrincipal.ResumeLayout(false);
            this.panelSettings.ResumeLayout(false);
            this.styles.ResumeLayout(false);
            this.metroTabPage2.ResumeLayout(false);
            this.themes.ResumeLayout(false);
            this.metroTabPage3.ResumeLayout(false);
            this.metroPanel2.ResumeLayout(false);
            this.metroPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.metroStyleManager1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroTabControl tabControl;
        private MetroFramework.Controls.MetroTabPage tabControlPrincipal;
        private MetroFramework.Controls.MetroTile employeeTile;
        private MetroFramework.Controls.MetroTile settingsTile;
        private MetroFramework.Controls.MetroTile carsTile;
        private MetroFramework.Controls.MetroTile clientsTile;
        private MetroFramework.Controls.MetroTile paymentTile;
        private MetroFramework.Controls.MetroLink metroLinkLogout;
        private MetroFramework.Controls.MetroTile rentTile;
        private MetroFramework.Controls.MetroTile listRentTile;
        private MetroFramework.Controls.MetroPanel panelSettings;
        private MetroFramework.Controls.MetroTabControl styles;
        private MetroFramework.Controls.MetroTabPage metroTabPage2;
        private MetroFramework.Controls.MetroButton pink;
        private MetroFramework.Controls.MetroButton lime;
        private MetroFramework.Controls.MetroButton blue;
        private MetroFramework.Controls.MetroButton brown;
        private MetroFramework.Controls.MetroButton magenta;
        private MetroFramework.Controls.MetroButton yellow;
        private MetroFramework.Controls.MetroButton red;
        private MetroFramework.Controls.MetroButton silver;
        private MetroFramework.Controls.MetroButton orange;
        private MetroFramework.Controls.MetroButton green;
        private MetroFramework.Controls.MetroButton purple;
        private MetroFramework.Controls.MetroButton teal;
        private MetroFramework.Controls.MetroTabControl themes;
        private MetroFramework.Controls.MetroTabPage metroTabPage3;
        private MetroFramework.Controls.MetroButton metroButton12;
        private MetroFramework.Controls.MetroButton metroButton13;
        private MetroFramework.Controls.MetroPanel metroPanel2;
        private MetroFramework.Controls.MetroLabel metroLabel6;
        private System.Windows.Forms.Timer mostrar;
        private System.Windows.Forms.Timer esconder;
        private MetroFramework.Controls.MetroTile reportTile;
        private MetroFramework.Components.MetroStyleManager metroStyleManager1;
    }
}