using CarLand.Domain;
using CarLand.Domain.Interface;
using CarLand.Forms.DataSets.Paulo;
using MetroFramework;
using MetroFramework.Components;
using MetroFramework.Forms;
using Microsoft.Build.Framework.XamlTypes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarLand.Forms.Admin
{
    public partial class Reports : MetroForm
    {
        private int i;
        public Database.DBCar Car { get; set; }
        public Database.DBRent Rent { get; set; }
        public Colors IColors { get; set; }

        public Reports(MetroStyleManager manager)
        {
            InitializeComponent();
            this.StyleManager = manager;
            IColors = new Colors();
            Load_Page();
            Rent = new Database.DBRent();
            Car = new Database.DBCar();
        }

        public void Load_Page()
        {
            //Theme
            metroComboBox1.Theme = this.StyleManager.Theme;

            //Style
            metroComboBox1.Style = this.StyleManager.Style;
            metroButton1.BackColor = IColors.GetColor(this.StyleManager.Style);
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            PrintDocument pd = new PrintDocument();
            pd.BeginPrint += Pd_BeginPrint;
            var report = (string)metroComboBox1.SelectedItem;
            if (report is null)
            {
                MetroMessageBox.Show(this, "Selecione um relatorio", "", MessageBoxButtons.OK, MessageBoxIcon.Warning, 100);
            }
            else
            {
                if (report == "Carros")
                {
                    pd.DocumentName = "Relatório de Carros";
                    pd.PrintPage += PrintCars;
                }
                else
                {

                    pd.DocumentName = "Relatório de Alugueis";
                    pd.PrintPage += PrintRents;
                }
                PrintPreviewDialog ppd = new PrintPreviewDialog();
                ppd.Document = pd;
                ppd.ShowDialog();
            }
        }

        private void Pd_BeginPrint(object sender, PrintEventArgs e)
        {
            //O que deve ocorrer antes de iniciar a impressão
            i = 0;
        }

        private void PrintRents(object sender, PrintPageEventArgs ev)
        {
            //Configurações da página
            float linhaPorPagina = 0;
            float posicaoVertical = 0;
            float contador = 0;
            float margemEsqueda = 20;
            float margemSuperior = 20;
            float alturaFonte = 0;
            string linha = "";
            Font fonte = new Font("Arial", 14);
            alturaFonte = fonte.GetHeight(ev.Graphics);
            linhaPorPagina = Convert.ToInt32(ev.MarginBounds.Height / alturaFonte);
            //Título
            linha = "Lista de Alugueis";
            posicaoVertical = margemSuperior + contador * alturaFonte;
            ev.Graphics.DrawString(linha, fonte, Brushes.Black, margemEsqueda, posicaoVertical);
            contador += 4;
            linha = "Código Aluguel";
            posicaoVertical = margemSuperior + contador * alturaFonte;
            ev.Graphics.DrawString(linha, fonte, Brushes.Black, margemEsqueda, posicaoVertical);
            linha = "Código Carro";
            ev.Graphics.DrawString(linha, fonte, Brushes.Black, margemEsqueda + 200, posicaoVertical);
            contador += 1;
            linha = "Código Cliente";
            ev.Graphics.DrawString(linha, fonte, Brushes.Black, margemEsqueda + 200, posicaoVertical);
            contador += 1;
            linha = "Data Retirada";
            ev.Graphics.DrawString(linha, fonte, Brushes.Black, margemEsqueda + 200, posicaoVertical);
            contador += 1;
            linha = "Data Devolução";
            ev.Graphics.DrawString(linha, fonte, Brushes.Black, margemEsqueda + 200, posicaoVertical);
            contador += 1;
            linha = "Valor";
            ev.Graphics.DrawString(linha, fonte, Brushes.Black, margemEsqueda + 200, posicaoVertical);
            contador += 1;
            linha = "-------------------------------------------------------------------------------------------------";
            posicaoVertical = margemSuperior + contador * alturaFonte;
            ev.Graphics.DrawString(linha, fonte, Brushes.Black, margemEsqueda, posicaoVertical);
            contador++;
            DataSet ds = new DataSet();
            ds = Rent.Report();
            if (ds.Tables[0] != null)
            {
                while (i < ds.Tables[0].Rows.Count && contador < linhaPorPagina)
                {
                    DataRow item = ds.Tables[0].Rows[i];
                    linha = item["idRent"].ToString();
                    posicaoVertical = margemSuperior + contador * alturaFonte;
                    ev.Graphics.DrawString(linha, fonte, Brushes.Black, margemEsqueda, posicaoVertical);
                    linha = item["idCar"].ToString();
                    posicaoVertical = margemSuperior + contador * alturaFonte;
                    ev.Graphics.DrawString(linha, fonte, Brushes.Black, margemEsqueda + 200, posicaoVertical);
                    linha = item["idClient"].ToString();
                    posicaoVertical = margemSuperior + contador * alturaFonte;
                    ev.Graphics.DrawString(linha, fonte, Brushes.Black, margemEsqueda + 200, posicaoVertical);
                    linha = item["PickUpTime"].ToString();
                    posicaoVertical = margemSuperior + contador * alturaFonte;
                    ev.Graphics.DrawString(linha, fonte, Brushes.Black, margemEsqueda + 200, posicaoVertical);
                    linha = item["DropOfTime"].ToString();
                    posicaoVertical = margemSuperior + contador * alturaFonte;
                    ev.Graphics.DrawString(linha, fonte, Brushes.Black, margemEsqueda + 200, posicaoVertical);
                    linha = item["Amount"].ToString();
                    posicaoVertical = margemSuperior + contador * alturaFonte;
                    ev.Graphics.DrawString(linha, fonte, Brushes.Black, margemEsqueda + 200, posicaoVertical);
                    linha = item["PaymentType"].ToString();
                    posicaoVertical = margemSuperior + contador * alturaFonte;
                    ev.Graphics.DrawString(linha, fonte, Brushes.Black, margemEsqueda + 200, posicaoVertical);
                    contador += 2;
                    i++;
                }
            }
            if (contador < linhaPorPagina)
            {
                linha = "Total de Alugueis: " + i.ToString();
                posicaoVertical = margemSuperior + contador * alturaFonte;
                ev.Graphics.DrawString(linha, fonte, Brushes.Black, margemEsqueda + 100, posicaoVertical);
            }
            else MessageBox.Show("Não existe Aluguel cadastrada!");
            if (contador > linhaPorPagina)
            {
                ev.HasMorePages = true;
            }
            else
            {
                ev.HasMorePages = false;
            }
        }

        private void PrintCars(object sender, PrintPageEventArgs ev)
        {
            //Configurações da página
            float linhaPorPagina = 0;
            float posicaoVertical = 0;
            float contador = 0;
            float margemEsqueda = 20;
            float margemSuperior = 20;
            float alturaFonte = 0;
            string linha = "";
            Font fonte = new Font("Arial", 14);
            alturaFonte = fonte.GetHeight(ev.Graphics);
            linhaPorPagina = Convert.ToInt32(ev.MarginBounds.Height / alturaFonte);
            //Título
            linha = "Lista de Carros";
            posicaoVertical = margemSuperior + contador * alturaFonte;
            ev.Graphics.DrawString(linha, fonte, Brushes.Black, margemEsqueda, posicaoVertical);
            contador += 4;
            linha = "Código";
            posicaoVertical = margemSuperior + contador * alturaFonte;
            ev.Graphics.DrawString(linha, fonte, Brushes.Black, margemEsqueda, posicaoVertical);
            linha = "Marca";
            ev.Graphics.DrawString(linha, fonte, Brushes.Black, margemEsqueda + 200, posicaoVertical);
            contador += 1;
            linha = "Modelo";
            ev.Graphics.DrawString(linha, fonte, Brushes.Black, margemEsqueda + 200, posicaoVertical);
            contador += 1;
            linha = "Ano";
            ev.Graphics.DrawString(linha, fonte, Brushes.Black, margemEsqueda + 200, posicaoVertical);
            contador += 1;
            linha = "Placa";
            ev.Graphics.DrawString(linha, fonte, Brushes.Black, margemEsqueda + 200, posicaoVertical);
            contador += 1;
            linha = "Combustivel";
            ev.Graphics.DrawString(linha, fonte, Brushes.Black, margemEsqueda + 200, posicaoVertical);
            contador += 1;
            linha = "Portas";
            ev.Graphics.DrawString(linha, fonte, Brushes.Black, margemEsqueda + 200, posicaoVertical);
            contador += 1;
            linha = "-------------------------------------------------------------------------------------------------";
            posicaoVertical = margemSuperior + contador * alturaFonte;
            ev.Graphics.DrawString(linha, fonte, Brushes.Black, margemEsqueda, posicaoVertical);
            contador++;
            DataSet ds = new DataSet();
            ds = Car.Report();
            if (ds.Tables[0] != null)
            {
                while (i < ds.Tables[0].Rows.Count && contador < linhaPorPagina)
                {
                    DataRow item = ds.Tables[0].Rows[i];
                    linha = item["idCar"].ToString();
                    posicaoVertical = margemSuperior + contador * alturaFonte;
                    ev.Graphics.DrawString(linha, fonte, Brushes.Black, margemEsqueda, posicaoVertical);
                    linha = item["Branch"].ToString();
                    posicaoVertical = margemSuperior + contador * alturaFonte;
                    ev.Graphics.DrawString(linha, fonte, Brushes.Black, margemEsqueda + 200, posicaoVertical);
                    linha = item["Model"].ToString();
                    posicaoVertical = margemSuperior + contador * alturaFonte;
                    ev.Graphics.DrawString(linha, fonte, Brushes.Black, margemEsqueda + 200, posicaoVertical);
                    linha = item["Year"].ToString();
                    posicaoVertical = margemSuperior + contador * alturaFonte;
                    ev.Graphics.DrawString(linha, fonte, Brushes.Black, margemEsqueda + 200, posicaoVertical);
                    linha = item["Board"].ToString();
                    posicaoVertical = margemSuperior + contador * alturaFonte;
                    ev.Graphics.DrawString(linha, fonte, Brushes.Black, margemEsqueda + 200, posicaoVertical);
                    linha = item["Fuel"].ToString();
                    posicaoVertical = margemSuperior + contador * alturaFonte;
                    ev.Graphics.DrawString(linha, fonte, Brushes.Black, margemEsqueda + 200, posicaoVertical);
                    linha = item["Doors"].ToString();
                    posicaoVertical = margemSuperior + contador * alturaFonte;
                    ev.Graphics.DrawString(linha, fonte, Brushes.Black, margemEsqueda + 200, posicaoVertical);
                    contador += 2;
                    i++;
                }
            }
            if (contador < linhaPorPagina)
            {
                linha = "Total de Carros: " + i.ToString();
                posicaoVertical = margemSuperior + contador * alturaFonte;
                ev.Graphics.DrawString(linha, fonte, Brushes.Black, margemEsqueda + 100, posicaoVertical);
            }
            else MessageBox.Show("Não existe Carro cadastrado!");
            if (contador > linhaPorPagina)
            {
                ev.HasMorePages = true;
            }
            else
            {
                ev.HasMorePages = false;
            }
        }

        private void Reports_Load(object sender, EventArgs e)
        {

        }
    }
}
