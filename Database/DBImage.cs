using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using CarLand.Domain.Entities;
using System.Data;
using System.IO;
using System.Windows.Forms;

namespace CarLand.Database
{
    public class DBImage
    {
        Connection _context = new Connection();
        private string query;

        public void Insert(Image image)
        {
            query = $"Insert into [Image] (idCar,Path,Name) values ({image.idCar} , '{image.Path}' , '{image.Name}')";
            _context.CommandWithoutReturn(query);
        }

        public void Update(Image image)
        {
            query = $@"Update [Image] 
                    set Name = '{image.Name}
                    WHERE idImage = {image.Id}";
            _context.CommandWithoutReturn(query);
        }
        public void Delete(int idCar)
        {
            query = $"Delete from [Image] WHERE idCar = '{idCar}'";
            _context.CommandWithoutReturn(query);
        }

        public List<Image> GetImages(int carId)
        {
            query = $"Select * from [Image] where idCar = {carId}";
            return _context.GetImages(query); 
        }

        public void SetImage(int carId, PictureBox image)
        {
            Image img = new Image();
            img.idCar = carId;
            img.Name = DateTime.Now.Ticks + "_" + Path.GetFileName(image.Name);
            img.Path = Servers.PathImages;
            var extensions = Path.GetExtension(image.Name);
            if (extensions.Contains(".jp"))
            {
                image.Image.Save(Servers.path + img.Path + img.Name, System.Drawing.Imaging.ImageFormat.Jpeg);
            }
            else if (extensions.Contains(".png"))
            {
                image.Image.Save(Servers.path + img.Path + img.Name, System.Drawing.Imaging.ImageFormat.Png);
            }
            Insert(img);
        }

        public PictureBox GeneratePictureBox( string img, int x, int y )
        {
            PictureBox pic = new PictureBox();
            pic.Image = System.Drawing.Image.FromFile(img);
            pic.Name = img;
            pic.Size = new System.Drawing.Size(121, 61);
            pic.Location = new System.Drawing.Point(x, y);
            pic.SizeMode = PictureBoxSizeMode.StretchImage;

            return pic;
        }
    }
}
