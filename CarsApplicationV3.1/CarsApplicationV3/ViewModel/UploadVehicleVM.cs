using CarsApplicationV3.Models;
using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace CarsApplicationV3.ViewModel
{

    class UploadVehicleVM : ViewModelBase
    {
        #region Definitions
        private VehicleType type;
        private VehicleType selectedType;
        private string brand;
        private string model;
        private string color;
        private string description;
        private int year;
        private int numOfSeats;
        private double length, width, height;

        #endregion
        #region Properties
        private ICommand UploadVehicle { get; set; }
        public VehicleType SelectedType
        {
            get { return selectedType; }
            set { selectedType = value; RaisePropertyChanged("SelectedType"); }
        }
        public List<VehicleType> Type
        {
            get;
            set; 
        }

        public int Year { get { return year; } set { year = value; } }
        public int NumOfSeats { get { return numOfSeats; } set { numOfSeats = value; } }
        public double  Length { get { return length; } set { length = value; } }
        public double  Width { get { return width; } set { width = value; } }
        public double Height { get { return height; } set { height = value; } }
        public string Description { get { return description; } set { description = value; } }
        public string Model { get { return model; } set { description = value; } }
        public string Brand { get { return brand; } set { brand = value; } }
        public string Color { get { return color; } set { color = value; } }
        #endregion
        #region Constructors
        public UploadVehicleVM()
        {
            // TODO Reconsider combobox init without Casting because of slow processing
           Type= Enum.GetValues(typeof(VehicleType)).Cast<VehicleType>().ToList();
            //Consider using ObjectDataProvider in XAML 
            
            UploadVehicle = new RelayCommand(() => UploadVehicleF());


        }
        #endregion
        #region Methods
        private void UploadVehicleF()
        {

        }
        #endregion

    }
}
