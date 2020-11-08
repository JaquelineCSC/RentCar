using System.Drawing;
using System.Windows.Forms;

namespace CarLand.Forms
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.datetime = new MetroFramework.Controls.MetroLabel();
            this.metroTextBox1 = new MetroFramework.Controls.MetroTextBox();
            this.metroTextBox2 = new MetroFramework.Controls.MetroTextBox();
            this.metroButton1 = new MetroFramework.Controls.MetroButton();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.panelSettings = new MetroFramework.Controls.MetroPanel();
            this.metroTabControl1 = new MetroFramework.Controls.MetroTabControl();
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
            this.settings = new MetroFramework.Controls.MetroTabControl();
            this.metroTabPage1 = new MetroFramework.Controls.MetroTabPage();
            this.metroButton12 = new MetroFramework.Controls.MetroButton();
            this.metroButton13 = new MetroFramework.Controls.MetroButton();
            this.metroPanel2 = new MetroFramework.Controls.MetroPanel();
            this.metroLabel6 = new MetroFramework.Controls.MetroLabel();
            this.metroLinkVoltar = new MetroFramework.Controls.MetroLink();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.mostrar = new System.Windows.Forms.Timer(this.components);
            this.esconder = new System.Windows.Forms.Timer(this.components);
            this.manager = new MetroFramework.Components.MetroStyleManager(this.components);
            this.relogio = new System.Windows.Forms.Timer(this.components);
            this.metroLink1 = new MetroFramework.Controls.MetroLink();
            this.error = new System.Windows.Forms.ErrorProvider(this.components);
            this.panelSettings.SuspendLayout();
            this.metroTabControl1.SuspendLayout();
            this.metroTabPage2.SuspendLayout();
            this.settings.SuspendLayout();
            this.metroTabPage1.SuspendLayout();
            this.metroPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.manager)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.error)).BeginInit();
            this.SuspendLayout();
            // 
            // datetime
            // 
            this.datetime.AutoSize = true;
            this.datetime.Location = new System.Drawing.Point(1079, 62);
            this.datetime.Name = "datetime";
            this.datetime.Size = new System.Drawing.Size(12, 19);
            this.datetime.TabIndex = 0;
            this.datetime.Text = ".";
            this.datetime.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // metroTextBox1
            // 
            // 
            // 
            // 
            this.metroTextBox1.CustomButton.Image = null;
            this.metroTextBox1.CustomButton.Location = new System.Drawing.Point(239, 1);
            this.metroTextBox1.CustomButton.Name = "";
            this.metroTextBox1.CustomButton.Size = new System.Drawing.Size(31, 31);
            this.metroTextBox1.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroTextBox1.CustomButton.TabIndex = 1;
            this.metroTextBox1.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroTextBox1.CustomButton.UseSelectable = true;
            this.metroTextBox1.CustomButton.Visible = false;
            this.metroTextBox1.DisplayIcon = true;
            this.metroTextBox1.FontSize = MetroFramework.MetroTextBoxSize.Tall;
            this.metroTextBox1.Icon = ((System.Drawing.Image)(resources.GetObject("metroTextBox1.Icon")));
            this.metroTextBox1.Lines = new string[0];
            this.metroTextBox1.Location = new System.Drawing.Point(507, 298);
            this.metroTextBox1.MaxLength = 20;
            this.metroTextBox1.Multiline = true;
            this.metroTextBox1.Name = "metroTextBox1";
            this.metroTextBox1.PasswordChar = '\0';
            this.metroTextBox1.PromptText = "Usuário";
            this.metroTextBox1.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.metroTextBox1.SelectedText = "";
            this.metroTextBox1.SelectionLength = 0;
            this.metroTextBox1.SelectionStart = 0;
            this.metroTextBox1.ShortcutsEnabled = false;
            this.metroTextBox1.Size = new System.Drawing.Size(271, 33);
            this.metroTextBox1.TabIndex = 3;
            this.metroTextBox1.UseSelectable = true;
            this.metroTextBox1.WaterMark = "Usuário";
            this.metroTextBox1.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.metroTextBox1.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroTextBox2
            // 
            // 
            // 
            // 
            this.metroTextBox2.CustomButton.Image = null;
            this.metroTextBox2.CustomButton.Location = new System.Drawing.Point(239, 1);
            this.metroTextBox2.CustomButton.Name = "";
            this.metroTextBox2.CustomButton.Size = new System.Drawing.Size(31, 31);
            this.metroTextBox2.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroTextBox2.CustomButton.TabIndex = 1;
            this.metroTextBox2.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroTextBox2.CustomButton.UseSelectable = true;
            this.metroTextBox2.CustomButton.Visible = false;
            this.metroTextBox2.DisplayIcon = true;
            this.metroTextBox2.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.metroTextBox2.Icon = ((System.Drawing.Image)(resources.GetObject("metroTextBox2.Icon")));
            this.metroTextBox2.Lines = new string[0];
            this.metroTextBox2.Location = new System.Drawing.Point(507, 347);
            this.metroTextBox2.MaxLength = 12;
            this.metroTextBox2.Multiline = true;
            this.metroTextBox2.Name = "metroTextBox2";
            this.metroTextBox2.PasswordChar = '*';
            this.metroTextBox2.PromptText = "Senha";
            this.metroTextBox2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.metroTextBox2.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.metroTextBox2.SelectedText = "";
            this.metroTextBox2.SelectionLength = 0;
            this.metroTextBox2.SelectionStart = 0;
            this.metroTextBox2.ShortcutsEnabled = true;
            this.metroTextBox2.Size = new System.Drawing.Size(271, 33);
            this.metroTextBox2.TabIndex = 4;
            this.metroTextBox2.UseSelectable = true;
            this.metroTextBox2.WaterMark = "Senha";
            this.metroTextBox2.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.metroTextBox2.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroButton1
            // 
            this.metroButton1.BackColor = System.Drawing.Color.DarkOrange;
            this.metroButton1.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.metroButton1.FontWeight = MetroFramework.MetroButtonWeight.Light;
            this.metroButton1.Location = new System.Drawing.Point(551, 403);
            this.metroButton1.Margin = new System.Windows.Forms.Padding(0);
            this.metroButton1.Name = "metroButton1";
            this.metroButton1.Size = new System.Drawing.Size(193, 31);
            this.metroButton1.Style = MetroFramework.MetroColorStyle.Orange;
            this.metroButton1.TabIndex = 5;
            this.metroButton1.Text = "Entrar";
            this.metroButton1.UseCustomBackColor = true;
            this.metroButton1.UseSelectable = true;
            this.metroButton1.Click += new System.EventHandler(this.metroButton1_Click);
            this.metroButton1.MouseHover += new System.EventHandler(this.hoverCor);
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Location = new System.Drawing.Point(585, 459);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(131, 19);
            this.metroLabel4.TabIndex = 6;
            this.metroLabel4.Text = "Esqueceu sua Senha?";
            this.metroLabel4.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroLabel4.Click += new System.EventHandler(this.metroLabel4_Click);
            this.metroLabel4.MouseHover += new System.EventHandler(this.hoverCor);
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.Location = new System.Drawing.Point(610, 488);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(74, 19);
            this.metroLabel5.TabIndex = 7;
            this.metroLabel5.Text = "Registre-se";
            this.metroLabel5.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroLabel5.Click += new System.EventHandler(this.metroLabel5_Click);
            this.metroLabel5.MouseHover += new System.EventHandler(this.hoverCor);
            // 
            // panelSettings
            // 
            this.panelSettings.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelSettings.Controls.Add(this.metroTabControl1);
            this.panelSettings.Controls.Add(this.settings);
            this.panelSettings.Controls.Add(this.metroPanel2);
            this.panelSettings.HorizontalScrollbarBarColor = true;
            this.panelSettings.HorizontalScrollbarHighlightOnWheel = false;
            this.panelSettings.HorizontalScrollbarSize = 10;
            this.panelSettings.Location = new System.Drawing.Point(798, 22);
            this.panelSettings.Name = "panelSettings";
            this.panelSettings.Size = new System.Drawing.Size(275, 771);
            this.panelSettings.TabIndex = 9;
            this.panelSettings.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.panelSettings.VerticalScrollbarBarColor = true;
            this.panelSettings.VerticalScrollbarHighlightOnWheel = false;
            this.panelSettings.VerticalScrollbarSize = 10;
            // 
            // metroTabControl1
            // 
            this.metroTabControl1.Controls.Add(this.metroTabPage2);
            this.metroTabControl1.Location = new System.Drawing.Point(3, 380);
            this.metroTabControl1.Name = "metroTabControl1";
            this.metroTabControl1.SelectedIndex = 0;
            this.metroTabControl1.Size = new System.Drawing.Size(270, 367);
            this.metroTabControl1.Style = MetroFramework.MetroColorStyle.Orange;
            this.metroTabControl1.TabIndex = 11;
            this.metroTabControl1.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroTabControl1.UseSelectable = true;
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
            this.metroTabPage2.Size = new System.Drawing.Size(262, 325);
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
            this.pink.UseCustomBackColor = true;
            this.pink.UseSelectable = true;
            this.pink.Click += new System.EventHandler(this.pink_Click);
            this.pink.MouseHover += new System.EventHandler(this.hoverCor);
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
            this.lime.UseCustomBackColor = true;
            this.lime.UseSelectable = true;
            this.lime.Click += new System.EventHandler(this.lime_Click);
            this.lime.MouseHover += new System.EventHandler(this.hoverCor);
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
            this.blue.UseCustomBackColor = true;
            this.blue.UseSelectable = true;
            this.blue.Click += new System.EventHandler(this.blue_Click);
            this.blue.MouseHover += new System.EventHandler(this.hoverCor);
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
            this.brown.UseCustomBackColor = true;
            this.brown.UseSelectable = true;
            this.brown.Click += new System.EventHandler(this.brown_Click);
            this.brown.MouseHover += new System.EventHandler(this.hoverCor);
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
            this.magenta.UseCustomBackColor = true;
            this.magenta.UseSelectable = true;
            this.magenta.Click += new System.EventHandler(this.magenta_Click);
            this.magenta.MouseHover += new System.EventHandler(this.hoverCor);
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
            this.yellow.UseCustomBackColor = true;
            this.yellow.UseSelectable = true;
            this.yellow.Click += new System.EventHandler(this.yellow_Click);
            this.yellow.MouseHover += new System.EventHandler(this.hoverCor);
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
            this.red.UseCustomBackColor = true;
            this.red.UseSelectable = true;
            this.red.Click += new System.EventHandler(this.red_Click);
            this.red.MouseHover += new System.EventHandler(this.hoverCor);
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
            this.silver.UseCustomBackColor = true;
            this.silver.UseSelectable = true;
            this.silver.Click += new System.EventHandler(this.silver_Click);
            this.silver.MouseHover += new System.EventHandler(this.hoverCor);
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
            this.orange.UseCustomBackColor = true;
            this.orange.UseSelectable = true;
            this.orange.Click += new System.EventHandler(this.orange_Click);
            this.orange.MouseHover += new System.EventHandler(this.hoverCor);
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
            this.green.UseCustomBackColor = true;
            this.green.UseSelectable = true;
            this.green.Click += new System.EventHandler(this.green_Click);
            this.green.MouseHover += new System.EventHandler(this.hoverCor);
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
            this.purple.UseCustomBackColor = true;
            this.purple.UseSelectable = true;
            this.purple.Click += new System.EventHandler(this.purple_Click);
            this.purple.MouseHover += new System.EventHandler(this.hoverCor);
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
            this.teal.UseCustomBackColor = true;
            this.teal.UseSelectable = true;
            this.teal.Click += new System.EventHandler(this.teal_Click);
            this.teal.MouseHover += new System.EventHandler(this.hoverCor);
            // 
            // settings
            // 
            this.settings.Controls.Add(this.metroTabPage1);
            this.settings.Location = new System.Drawing.Point(2, 67);
            this.settings.Name = "settings";
            this.settings.SelectedIndex = 0;
            this.settings.Size = new System.Drawing.Size(271, 301);
            this.settings.Style = MetroFramework.MetroColorStyle.Orange;
            this.settings.TabIndex = 10;
            this.settings.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.settings.UseSelectable = true;
            // 
            // metroTabPage1
            // 
            this.metroTabPage1.Controls.Add(this.metroButton12);
            this.metroTabPage1.Controls.Add(this.metroButton13);
            this.metroTabPage1.HorizontalScrollbarBarColor = true;
            this.metroTabPage1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroTabPage1.HorizontalScrollbarSize = 10;
            this.metroTabPage1.Location = new System.Drawing.Point(4, 38);
            this.metroTabPage1.Name = "metroTabPage1";
            this.metroTabPage1.Size = new System.Drawing.Size(263, 259);
            this.metroTabPage1.TabIndex = 0;
            this.metroTabPage1.Text = "Temas";
            this.metroTabPage1.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroTabPage1.VerticalScrollbarBarColor = true;
            this.metroTabPage1.VerticalScrollbarHighlightOnWheel = false;
            this.metroTabPage1.VerticalScrollbarSize = 10;
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
            this.metroButton12.Click += new System.EventHandler(this.metroButton12_Click_1);
            this.metroButton12.MouseHover += new System.EventHandler(this.hoverCor);
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
            this.metroButton13.Click += new System.EventHandler(this.metroButton13_Click_1);
            this.metroButton13.MouseHover += new System.EventHandler(this.hoverCor);
            // 
            // metroPanel2
            // 
            this.metroPanel2.Controls.Add(this.metroLabel6);
            this.metroPanel2.Controls.Add(this.metroLinkVoltar);
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
            this.metroLabel6.Location = new System.Drawing.Point(57, 20);
            this.metroLabel6.Name = "metroLabel6";
            this.metroLabel6.Size = new System.Drawing.Size(134, 25);
            this.metroLabel6.TabIndex = 25;
            this.metroLabel6.Text = "Configurações";
            this.metroLabel6.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // metroLinkVoltar
            // 
            this.metroLinkVoltar.Image = ((System.Drawing.Image)(resources.GetObject("metroLinkVoltar.Image")));
            this.metroLinkVoltar.ImageSize = 45;
            this.metroLinkVoltar.Location = new System.Drawing.Point(3, 11);
            this.metroLinkVoltar.Name = "metroLinkVoltar";
            this.metroLinkVoltar.Size = new System.Drawing.Size(48, 43);
            this.metroLinkVoltar.TabIndex = 24;
            this.metroLinkVoltar.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroLinkVoltar.UseSelectable = true;
            this.metroLinkVoltar.Click += new System.EventHandler(this.metroLinkVoltar_Click);
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.metroLabel2.Location = new System.Drawing.Point(470, 249);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(195, 25);
            this.metroLabel2.Style = MetroFramework.MetroColorStyle.Orange;
            this.metroLabel2.TabIndex = 10;
            this.metroLabel2.Text = "Faça login em sua conta";
            this.metroLabel2.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroLabel2.UseStyleColors = true;
            // 
            // mostrar
            // 
            this.mostrar.Interval = 10;
            this.mostrar.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // esconder
            // 
            this.esconder.Interval = 10;
            this.esconder.Tick += new System.EventHandler(this.esconder_Tick);
            // 
            // manager
            // 
            this.manager.Owner = this;
            this.manager.Style = MetroFramework.MetroColorStyle.Orange;
            this.manager.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // relogio
            // 
            this.relogio.Enabled = true;
            this.relogio.Interval = 1000;
            this.relogio.Tick += new System.EventHandler(this.relogio_Tick);
            // 
            // metroLink1
            // 
            this.metroLink1.Image = ((System.Drawing.Image)(resources.GetObject("metroLink1.Image")));
            this.metroLink1.ImageSize = 46;
            this.metroLink1.Location = new System.Drawing.Point(1211, 43);
            this.metroLink1.Name = "metroLink1";
            this.metroLink1.Size = new System.Drawing.Size(46, 52);
            this.metroLink1.TabIndex = 11;
            this.metroLink1.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroLink1.UseSelectable = true;
            this.metroLink1.Click += new System.EventHandler(this.metroLink1_Click);
            // 
            // error
            // 
            this.error.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.error.ContainerControl = this;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1280, 788);
            this.Controls.Add(this.metroLink1);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.panelSettings);
            this.Controls.Add(this.metroLabel5);
            this.Controls.Add(this.metroLabel4);
            this.Controls.Add(this.metroButton1);
            this.Controls.Add(this.metroTextBox2);
            this.Controls.Add(this.metroTextBox1);
            this.Controls.Add(this.datetime);
            this.Name = "Login";
            this.Resizable = false;
            this.Style = MetroFramework.MetroColorStyle.Orange;
            this.Text = "Login";
            this.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Login_Load);
            this.panelSettings.ResumeLayout(false);
            this.metroTabControl1.ResumeLayout(false);
            this.metroTabPage2.ResumeLayout(false);
            this.settings.ResumeLayout(false);
            this.metroTabPage1.ResumeLayout(false);
            this.metroPanel2.ResumeLayout(false);
            this.metroPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.manager)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.error)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroLabel datetime;
        private MetroFramework.Controls.MetroTextBox metroTextBox1;
        private MetroFramework.Controls.MetroTextBox metroTextBox2;
        private MetroFramework.Controls.MetroButton metroButton1;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private MetroFramework.Controls.MetroPanel panelSettings;
        private MetroFramework.Controls.MetroPanel metroPanel2;
        private MetroFramework.Controls.MetroTabControl settings;
        private MetroFramework.Controls.MetroLabel metroLabel6;
        private MetroFramework.Controls.MetroLink metroLinkVoltar;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroTabPage metroTabPage1;
        private MetroFramework.Controls.MetroButton metroButton12;
        private MetroFramework.Controls.MetroButton metroButton13;
        private MetroFramework.Controls.MetroButton orange;
        private MetroFramework.Controls.MetroButton green;
        private MetroFramework.Controls.MetroButton teal;
        private MetroFramework.Controls.MetroButton silver;
        private MetroFramework.Controls.MetroButton red;
        private MetroFramework.Controls.MetroButton purple;
        private MetroFramework.Controls.MetroButton brown;
        private MetroFramework.Controls.MetroButton magenta;
        private MetroFramework.Controls.MetroButton yellow;
        private MetroFramework.Controls.MetroTabControl metroTabControl1;
        private MetroFramework.Controls.MetroTabPage metroTabPage2;
        private MetroFramework.Controls.MetroButton pink;
        private MetroFramework.Controls.MetroButton lime;
        private MetroFramework.Controls.MetroButton blue;
        private Timer mostrar;
        private Timer esconder;
        private MetroFramework.Components.MetroStyleManager manager;
        private Timer relogio;
        private MetroFramework.Controls.MetroLink metroLink1;
        private ErrorProvider error;
    }
}