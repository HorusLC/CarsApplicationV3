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
        private VehicleType type;
        private VehicleType selectedType;

        public ICommand UploadVehicle { get; private set; }
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
       public UploadVehicleVM()
        {
            //TODO refactor Enum init, because of slow initilization through Casting
           Type= Enum.GetValues(typeof(VehicleType)).Cast<VehicleType>().ToList();
            //Consider using ObjectDataProvider in XAML
            
            UploadVehicle = new RelayCommand(() => UploadVehicleF());

        }

       private void UploadVehicleF()
        {
            if (selectedType == VehicleType.CAR) { SelectedType = VehicleType.MOTORCYCLE; }
        }


    }
}
