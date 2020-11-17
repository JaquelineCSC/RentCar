namespace CarLand.Forms.Car
{
    partial class SetValueCar
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
            this.value = new MetroFramework.Controls.MetroTextBox();
            this.metroButton1 = new MetroFramework.Controls.MetroButton();
            this.SuspendLayout();
            // 
            // value
            // 
            // 
            // 
            // 
            this.value.CustomButton.Image = null;
            this.value.CustomButton.Location = new System.Drawing.Point(120, 1);
            this.value.CustomButton.Name = "";
            this.value.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.value.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.value.CustomButton.TabIndex = 1;
            this.value.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.value.CustomButton.UseSelectable = true;
            this.value.CustomButton.Visible = false;
            this.value.Lines = new string[0];
            this.value.Location = new System.Drawing.Point(47, 78);
            this.value.MaxLength = 32767;
            this.value.Name = "value";
            this.value.PasswordChar = '\0';
            this.value.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.value.SelectedText = "";
            this.value.SelectionLength = 0;
            this.value.SelectionStart = 0;
            this.value.ShortcutsEnabled = true;
            this.value.Size = new System.Drawing.Size(142, 23);
            this.value.TabIndex = 0;
            this.value.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.value.UseSelectable = true;
            this.value.WaterMark = "R$ 0,00";
            this.value.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.value.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroButton1
            // 
            this.metroButton1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.metroButton1.Location = new System.Drawing.Point(82, 121);
            this.metroButton1.Name = "metroButton1";
            this.metroButton1.Size = new System.Drawing.Size(75, 23);
            this.metroButton1.TabIndex = 1;
            this.metroButton1.Text = "Adicionar";
            this.metroButton1.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroButton1.UseCustomBackColor = true;
            this.metroButton1.UseSelectable = true;
            this.metroButton1.Click += new System.EventHandler(this.metroButton1_Click);
            // 
            // SetValueCar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(238, 183);
            this.Controls.Add(this.metroButton1);
            this.Controls.Add(this.value);
            this.Name = "SetValueCar";
            this.Resizable = false;
            this.Style = MetroFramework.MetroColorStyle.Orange;
            this.Text = "Adicionar Valor";
            this.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroTextBox value;
        private MetroFramework.Controls.MetroButton metroButton1;
    }
}