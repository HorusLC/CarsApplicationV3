using CarsApplicationV3.Models;
using GalaSoft.MvvmLight;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarsApplicationV3.ViewModel
{

    class UploadVehicleVM : ViewModelBase
    {
        private VehicleType type;
        private VehicleType selectedType;
        public VehicleType SelectedType
        {
            get { return selectedType; }
            set { selectedType = value; RaisePropertyChanged("SelectedType"); }
        }
        public List<VehicleType> Type
        {
            get;// { /*return type;*/ }
            set; //{ /*type = value;*/ }
        }
       public UploadVehicleVM()
        {
           Type= Enum.GetValues(typeof(VehicleType)).Cast<VehicleType>().ToList();


        }
    }
}
