using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media.Imaging;

namespace CarsApplicationV3.Models
{
    class Vehicle
    {
        public VehicleType Type { get; set; }
        public string Color { get; set; }
        public int Seats { get; set;}
        public double Height { get; set; }
        public double Width { get; set; }
        public double Length { get; set; }
        public string Brand { get; set; }
        public string Model { get; set; }
        public string Description { get; set; }
        public int Year { get; set; }
        //public byte[] Image { get; set; }
        public BitmapImage Image { get; set; }
        public Vehicle(VehicleType _type,string _color, int _seats, double _height, double _width, double _length, string _brand, string _model, string _description, int _year, BitmapImage _image)
        {

            Type = _type;
            Color = _color;
            Seats = _seats;
            Height = _height;
            Width = _width;
            Length = _length;
            Brand = _brand;
            Model = _model;
            Description = _description;
            Year = _year;
            Image = _image;



        }
        //public override string ToString()
        //{
        //    return string.Format("{0},{1},{2},{3}", Enum.GetName(typeof(VehicleType), Type), Brand, Model, Year);
        //}







    }
}
