namespace CarLand.Forms.Client
{
    partial class Wallet
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Wallet));
            this.card = new MetroFramework.Controls.MetroRadioButton();
            this.metroButton1 = new MetroFramework.Controls.MetroButton();
            this.metroLink2 = new MetroFramework.Controls.MetroLink();
            this.SuspendLayout();
            // 
            // card
            // 
            this.card.AutoSize = true;
            this.card.Location = new System.Drawing.Point(34, 82);
            this.card.Name = "card";
            this.card.Size = new System.Drawing.Size(46, 15);
            this.card.TabIndex = 0;
            this.card.Text = "card";
            this.card.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.card.UseSelectable = true;
            this.card.Visible = false;
            // 
            // metroButton1
            // 
            this.metroButton1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.metroButton1.Location = new System.Drawing.Point(63, 179);
            this.metroButton1.Name = "metroButton1";
            this.metroButton1.Size = new System.Drawing.Size(182, 40);
            this.metroButton1.TabIndex = 1;
            this.metroButton1.Text = "Adicionar Cartão de Crédito";
            this.metroButton1.UseCustomBackColor = true;
            this.metroButton1.UseSelectable = true;
            this.metroButton1.Click += new System.EventHandler(this.metroButton1_Click);
            // 
            // metroLink2
            // 
            this.metroLink2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("metroLink2.BackgroundImage")));
            this.metroLink2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.metroLink2.Location = new System.Drawing.Point(266, 36);
            this.metroLink2.Name = "metroLink2";
            this.metroLink2.Size = new System.Drawing.Size(25, 25);
            this.metroLink2.TabIndex = 4;
            this.metroLink2.UseSelectable = true;
            this.metroLink2.Click += new System.EventHandler(this.metroLink2_Click);
            // 
            // Wallet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(314, 242);
            this.Controls.Add(this.metroLink2);
            this.Controls.Add(this.metroButton1);
            this.Controls.Add(this.card);
            this.Name = "Wallet";
            this.Resizable = false;
            this.Style = MetroFramework.MetroColorStyle.Orange;
            this.Text = "Carteira";
            this.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.Load += new System.EventHandler(this.Wallet_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroRadioButton card;
        private MetroFramework.Controls.MetroButton metroButton1;
        private MetroFramework.Controls.MetroLink metroLink2;
    }
}