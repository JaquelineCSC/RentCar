﻿using CarLand.Database;
using MetroFramework.Components;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarLand.Forms.Aluguel
{
    public partial class RentDetails : MetroFramework.Forms.MetroForm
    {
        public Domain.Entities.Rent Rent { get; set; }
        public List<Domain.Entities.Image> Images { get; set; }

        public RentDetails(MetroStyleManager manager)
        {
            InitializeComponent();
            this.StyleManager = manager;
            Load_Page();
            Rent = new Domain.Entities.Rent();
            Images = new List<Domain.Entities.Image>();
        }

        public void Load_Page()
        {
            //Style
            metroLabel1.Style = this.StyleManager.Style;
            metroLabel3.Style = this.StyleManager.Style;
            metroLabel4.Style = this.StyleManager.Style;
            metroLabel5.Style = this.StyleManager.Style;
            metroLabel6.Style = this.StyleManager.Style;
            metroLabel7.Style = this.StyleManager.Style;
            metroLabel8.Style = this.StyleManager.Style;
            metroLabel16.Style = this.StyleManager.Style;
            metroLabel18.Style = this.StyleManager.Style;
            metroLabel20.Style = this.StyleManager.Style;
            metroLabel21.Style = this.StyleManager.Style;
            metroLabel22.Style = this.StyleManager.Style;
            metroLabel23.Style = this.StyleManager.Style;
            metroLabel12.Style = this.StyleManager.Style;
            metroLabel13.Style = this.StyleManager.Style;
            client.Style = this.StyleManager.Style;
            email.Style = this.StyleManager.Style;
            employee.Style = this.StyleManager.Style;
            employeeTitle.Style = this.StyleManager.Style;
            metroLinkVoltar.Style = this.StyleManager.Style;
            pickUp.Style = this.StyleManager.Style;
            dropOff.Style = this.StyleManager.Style;
            status.Style = this.StyleManager.Style;
            amount.Style = this.StyleManager.Style;
            payment.Style = this.StyleManager.Style;
            branch.Style = this.StyleManager.Style;
            model.Style = this.StyleManager.Style;
            year.Style = this.StyleManager.Style;
            board.Style = this.StyleManager.Style;
            fuel.Style = this.StyleManager.Style;
            doors.Style = this.StyleManager.Style;
            color.Style = this.StyleManager.Style;

            //Style
            metroLabel1.Style = this.StyleManager.Style;
            metroLabel3.Style = this.StyleManager.Style;
            metroLabel4.Style = this.StyleManager.Style;
            metroLabel5.Style = this.StyleManager.Style;
            metroLabel6.Style = this.StyleManager.Style;
            metroLabel7.Style = this.StyleManager.Style;
            metroLabel8.Style = this.StyleManager.Style;
            metroLabel16.Style = this.StyleManager.Style;
            metroLabel18.Style = this.StyleManager.Style;
            metroLabel20.Style = this.StyleManager.Style;
            metroLabel21.Style = this.StyleManager.Style;
            metroLabel22.Style = this.StyleManager.Style;
            metroLabel23.Style = this.StyleManager.Style;
            metroLabel12.Style = this.StyleManager.Style;
            metroLabel13.Style = this.StyleManager.Style;
            client.Style = this.StyleManager.Style;
            email.Style = this.StyleManager.Style;
            employee.Style = this.StyleManager.Style;
            employeeTitle.Style = this.StyleManager.Style;
            metroLinkVoltar.Style = this.StyleManager.Style;
            pickUp.Style = this.StyleManager.Style;
            dropOff.Style = this.StyleManager.Style;
            status.Style = this.StyleManager.Style;
            amount.Style = this.StyleManager.Style;
            payment.Style = this.StyleManager.Style;
            branch.Style = this.StyleManager.Style;
            model.Style = this.StyleManager.Style;
            year.Style = this.StyleManager.Style;
            board.Style = this.StyleManager.Style;
            fuel.Style = this.StyleManager.Style;
            doors.Style = this.StyleManager.Style;
            color.Style = this.StyleManager.Style;

        }

        private void DetalheAluguel_Load(object sender, EventArgs e)
        {
            Images = Load_Image();
            Domain.Entities.Car car = Load_Car();
            Domain.Entities.Client client = Load_Client();
            if (Rent.idEmployee != 0)
            {
                Domain.Entities.Employee employee = Load_Employee();
                this.employee.Text = employee.Name;
                this.employee.Visible = true;
                employeeTitle.Visible = true;
            }
            this.client.Text = client.Name;
            email.Text = client.Email;
            pickUp.Text = Rent.PickUpDate.ToString("dd/MM/yyyy HH:mm");
            dropOff.Text = Rent.DropOffDate.ToString("dd/MM/yyyy HH:mm");
            status.Text = car.Status == true ? "Disponível" : "Indisponível";
            amount.Text = Rent.Value.ToString("C2", CultureInfo.CurrentCulture);
            
            if (Rent.PaymentType == Domain.Entities.PaymentTypeEnum.Billet)
                payment.Text = "Boleto";
            else if (Rent.PaymentType == Domain.Entities.PaymentTypeEnum.Card)
                payment.Text = "Cartão";
            else
                payment.Text = "Dinheiro";

            branch.Text = car.Branch;
            model.Text = car.Model;
            board.Text = car.Board;
            doors.Text = car.Doors.ToString();
            board.Text = car.Board;
            fuel.Text = car.Fuel;
            color.Text = car.Color;
            year.Text = car.Year.ToString();
            if(Images.Any())
                image.Image = Image.FromFile(Servers.path + Images.Where(x=> x.Main == true).Select(x=> x.Path).FirstOrDefault() + Images.Where(x => x.Main == true).Select(x => x.Name).FirstOrDefault());
        }

        private List<Domain.Entities.Image> Load_Image()
        {
            Database.DBImage _appImage = new Database.DBImage();
            return _appImage.GetImages(Rent.idCar);
        }

        private Domain.Entities.Car Load_Car()
        {
            Database.DBCar _appCar= new Database.DBCar();
            return _appCar.GetCar(Rent.idCar);
        }

        private Domain.Entities.Client Load_Client()
        {
            Database.DBClient _appClient = new Database.DBClient();
            return _appClient.GetClientById(Rent.idClient);
        }

        private Domain.Entities.Employee Load_Employee()
        {
            Database.DBEmployee _appEmployee = new Database.DBEmployee();
            return _appEmployee.GetEmployee(idEmployee: Rent.idEmployee);
        }

        private void metroLinkVoltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
