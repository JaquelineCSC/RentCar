using CarLand.Domain.Interface;
using MetroFramework;
using MetroFramework.Components;
using MetroFramework.Forms;
using System;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Windows.Forms;

namespace CarLand.Forms.Admin
{
    public partial class Reports : MetroForm
    {
        public readonly Database.DBCar Car = new Database.DBCar();
        public readonly Database.DBRent Rent = new Database.DBRent();
        public Colors IColors = new Colors();
        private int i;

        public Reports(MetroStyleManager manager)
        {
            InitializeComponent();
            this.StyleManager = manager;
            Load_Page();
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
            linha = "Cod";
            posicaoVertical = margemSuperior + contador * alturaFonte;
            ev.Graphics.DrawString(linha, fonte, Brushes.Black, margemEsqueda, posicaoVertical);
            linha = "| Cod Carro";
            ev.Graphics.DrawString(linha, fonte, Brushes.Black, margemEsqueda + 50, posicaoVertical);
            contador += 1;
            linha = "| Cod Cliente";
            ev.Graphics.DrawString(linha, fonte, Brushes.Black, margemEsqueda + 160, posicaoVertical);
            contador += 1;
            linha = "| Data Retirada";
            ev.Graphics.DrawString(linha, fonte, Brushes.Black, margemEsqueda + 290, posicaoVertical);
            contador += 1;
            linha = "| Data Devolução";
            ev.Graphics.DrawString(linha, fonte, Brushes.Black, margemEsqueda + 428, posicaoVertical);
            contador += 1;
            linha = "| Valor";
            ev.Graphics.DrawString(linha, fonte, Brushes.Black, margemEsqueda + 588, posicaoVertical);
            contador += 1;
            linha = "| Pagamento";
            ev.Graphics.DrawString(linha, fonte, Brushes.Black, margemEsqueda + 652, posicaoVertical);
            contador += 1;
            linha = "-------------------------------------------------------------------------------------------------------------------";
            posicaoVertical = margemSuperior + contador * alturaFonte;
            ev.Graphics.DrawString(linha, fonte, Brushes.Black, margemEsqueda, 140);
            contador++;
            DataSet ds = new DataSet();
            ds = Rent.Report();
            if (ds.Tables[0] != null)
            {
                posicaoVertical = 120;
                while (i < ds.Tables[0].Rows.Count && contador < linhaPorPagina)
                {
                    DataRow item = ds.Tables[0].Rows[i];
                    linha = item["idRent"].ToString();
                    posicaoVertical = posicaoVertical + 40;
                    ev.Graphics.DrawString(linha, fonte, Brushes.Black, margemEsqueda, posicaoVertical);
                    linha = item["idCar"].ToString();
                    ev.Graphics.DrawString(linha, fonte, Brushes.Black, margemEsqueda + 50, posicaoVertical);
                    linha = item["idClient"].ToString();
                    ev.Graphics.DrawString(linha, fonte, Brushes.Black, margemEsqueda + 160, posicaoVertical);
                    linha = DateTime.Parse(item["PickUpTime"].ToString()).ToString("dd/MM/yyyy");
                    ev.Graphics.DrawString(linha, fonte, Brushes.Black, margemEsqueda + 290, posicaoVertical);
                    linha = DateTime.Parse(item["DropOfTime"].ToString()).ToString("dd/MM/yyyy");
                    ev.Graphics.DrawString(linha, fonte, Brushes.Black, margemEsqueda + 428, posicaoVertical);
                    linha = item["Amount"].ToString().Substring(0, item["Amount"].ToString().Length - 2);
                    ev.Graphics.DrawString(linha, fonte, Brushes.Black, margemEsqueda + 600, posicaoVertical);
                    switch (item["PaymentType"].ToString())
                    {
                        case "1":
                            linha = "Boleto";
                            break;
                        case "2":
                            linha = "Dinheiro";
                            break;
                        case "3":
                            linha = "Cartão";
                            break;
                    }
                    ev.Graphics.DrawString(linha, fonte, Brushes.Black, margemEsqueda + 700, posicaoVertical);
                    contador += 2;
                    i++;
                }
            }
            if (contador < linhaPorPagina)
            {
                linha = "Total de Alugueis: " + i.ToString();
                posicaoVertical = margemSuperior + contador * alturaFonte;
                ev.Graphics.DrawString(linha, fonte, Brushes.Black, margemEsqueda, posicaoVertical);
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
            float margemEsquerda = 20;
            float margemSuperior = 20;
            float alturaFonte = 0;
            string linha = "";
            Font fonte = new Font("Arial", 14);
            alturaFonte = fonte.GetHeight(ev.Graphics);
            linhaPorPagina = Convert.ToInt32(ev.MarginBounds.Height / alturaFonte);
            //Título
            linha = "Lista de Carros";
            posicaoVertical = margemSuperior + contador;
            ev.Graphics.DrawString(linha, fonte, Brushes.Black, margemEsquerda, posicaoVertical);
            contador += 4;
            linha = "Código";
            posicaoVertical = margemSuperior + contador * alturaFonte;
            ev.Graphics.DrawString(linha, fonte, Brushes.Black, margemEsquerda, posicaoVertical);
            linha = "Marca";
            ev.Graphics.DrawString(linha, fonte, Brushes.Black, margemEsquerda + 80, posicaoVertical);
            contador += 1;
            linha = "Modelo";
            ev.Graphics.DrawString(linha, fonte, Brushes.Black, margemEsquerda + 200, posicaoVertical);
            contador += 1;
            linha = "Ano";
            ev.Graphics.DrawString(linha, fonte, Brushes.Black, margemEsquerda + 300, posicaoVertical);
            contador += 1;
            linha = "Placa";
            ev.Graphics.DrawString(linha, fonte, Brushes.Black, margemEsquerda + 370, posicaoVertical);
            contador += 1;
            linha = "Combustivel";
            ev.Graphics.DrawString(linha, fonte, Brushes.Black, margemEsquerda + 480, posicaoVertical);
            contador += 1;
            linha = "Portas";
            ev.Graphics.DrawString(linha, fonte, Brushes.Black, margemEsquerda + 610, posicaoVertical);
            contador += 1;
            linha = "-----------------------------------------------------------------------------------------------------------";
            posicaoVertical = margemSuperior + contador * alturaFonte;
            ev.Graphics.DrawString(linha, fonte, Brushes.Black, margemEsquerda, 140);
            contador++;
            DataSet ds = new DataSet();
            ds = Car.Report();
            if (ds.Tables[0] != null)
            {
                posicaoVertical = 120;
                while (i < ds.Tables[0].Rows.Count && contador < linhaPorPagina)
                {
                    DataRow item = ds.Tables[0].Rows[i];
                    linha = item["idCar"].ToString();
                    posicaoVertical = posicaoVertical + 40;
                    ev.Graphics.DrawString(linha, fonte, Brushes.Black, margemEsquerda, posicaoVertical);
                    linha = item["Branch"].ToString();
                    ev.Graphics.DrawString(linha, fonte, Brushes.Black, margemEsquerda + 80, posicaoVertical);
                    linha = item["Model"].ToString();
                    ev.Graphics.DrawString(linha, fonte, Brushes.Black, margemEsquerda + 200, posicaoVertical);
                    linha = item["Year"].ToString();
                    ev.Graphics.DrawString(linha, fonte, Brushes.Black, margemEsquerda + 300, posicaoVertical);
                    linha = item["Board"].ToString();
                    ev.Graphics.DrawString(linha, fonte, Brushes.Black, margemEsquerda + 370, posicaoVertical);
                    linha = item["Fuel"].ToString();
                    ev.Graphics.DrawString(linha, fonte, Brushes.Black, margemEsquerda + 480, posicaoVertical);
                    linha = item["Doors"].ToString();
                    ev.Graphics.DrawString(linha, fonte, Brushes.Black, margemEsquerda + 610, posicaoVertical);
                    contador += 2;
                    i++;
                }
            }
            if (contador < linhaPorPagina)
            {
                linha = "Total de Carros: " + i.ToString();
                posicaoVertical = margemSuperior + contador * alturaFonte;
                ev.Graphics.DrawString(linha, fonte, Brushes.Black, margemEsquerda, posicaoVertical);
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
    }
}
