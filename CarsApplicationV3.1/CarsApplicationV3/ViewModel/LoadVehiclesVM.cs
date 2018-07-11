using CarsApplicationV3.Models;
using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Media.Imaging;

namespace CarsApplicationV3.ViewModel
{
    class LoadVehiclesVM:ViewModelBase
    {
        #region Definitions
        private ObservableCollection<Vehicle> vehicles;
        private string type;
        private string brand;
        private string model;
        private int numOfSeats;
        private int year;
        private string color;
        private Vehicle selectedVehicle;
        private Visibility visible;
        #endregion
        #region Properties
        public Visibility Visible { get { return visible; } set { visible = value; RaisePropertyChanged("Visible"); } }
        public Vehicle SelectedVehicle { get { return selectedVehicle; }
            set {
                if (selectedVehicle == null) { Visible = Visibility.Visible; }
                selectedVehicle = value;
                RaisePropertyChanged("SelectedVehicle");

            } }
        public ObservableCollection<Vehicle> Vehicles { get { return vehicles; }

            set { vehicles = value; RaisePropertyChanged("Vehicles"); }
        }

        public string Type { get { return type; }
        set { type = value;RaisePropertyChanged("Type"); }
        }
public string Brand { get { return brand; }

            set { brand = value;
                RaisePropertyChanged("Brand");
            }
        }
        public string Model { get { return model; }
        set { model = value;
                RaisePropertyChanged("Model");
            }
        }
        public int NumOfSeats
        {
            get { return numOfSeats; }
            set { numOfSeats = value;
                RaisePropertyChanged("NumOfSeats");
            }
        }
        public int Year { get { return year; }
        set {
                year = value;
                RaisePropertyChanged("Year"); }
        }
        public string Color { get { return color; }
        set { color = value; RaisePropertyChanged("Color"); }
        }
        #endregion
        #region Constructors
        public LoadVehiclesVM(){
            vehicles = new ObservableCollection<Vehicle>();
            BitmapImage img = new BitmapImage(new Uri(@"/images/shelby.jpg",UriKind.Relative));
            BitmapImage img2 = new BitmapImage(new Uri(@"/images/mazda3.jpg",UriKind.Relative));
            BitmapImage img3 = new BitmapImage(new Uri(@"/images/nissangtr.jpg", UriKind.Relative));
            BitmapImage img4 = new BitmapImage(new Uri(@"/images/chevroletcamaro.jpg", UriKind.Relative));
            //  BitmapImage img5= new BitmapImage(new Uri())
            // img.UriSource=
          //  BitmapImage img = new BitmapImage();
           // img.UriSource = new Uri( @"/images/shelby.jpg");

            vehicles.Add(new Models.Vehicle(VehicleType.CAR,"Син", 2, 2, 4, 3, "Ford", "Shelby", "New, very nice, cosmetic issues", 2015, img));
            vehicles.Add(new Models.Vehicle(VehicleType.CAR, "Бял",1, 3.3, 4.2, 3, "Mazda", "3", "New, very nice", 2010, img2));
            vehicles.Add(new Models.Vehicle(VehicleType.CAR, "Оранжев", 2, 3.5, 4.6, 4, "Nissan", "GTR", "Нов внос, пълен пакет екстри", 2014, img3));
            vehicles.Add(new Models.Vehicle(VehicleType.CAR, "Син", 4, 3.1, 4.2, 4, "Chevrolet", "Camaro", "Нов внос, пълен пакет екстри,прекрасен ретро автомобил", 1969, img4));
            Visible = Visibility.Hidden;
        }
        #endregion
        // private ShowInformation() { }


    }
}
