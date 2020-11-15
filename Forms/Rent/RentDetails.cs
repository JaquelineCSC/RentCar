using CarLand.Database;
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

        public RentDetails()
        {
            InitializeComponent();
            Rent = new Domain.Entities.Rent();
            Images = new List<Domain.Entities.Image>();
        }

        private void DetalheAluguel_Load(object sender, EventArgs e)
        {
            Images = Load_Image();
            Domain.Entities.Car car = Load_Car();
            Domain.Entities.Client client = Load_Client();
            if (Rent.idEmployee != 0)
            {
                Domain.Entities.Employee employee = Load_Employee();
                employeeTxt.Text = employee.Name;
                employeeTxt.Visible = true;
                employeeTitle.Visible = true;
            }
            clientTxt.Text = client.Name;
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
            return _appEmployee.GetEmployee(idEmployee: Rent.idCar);
        }
    }
}
