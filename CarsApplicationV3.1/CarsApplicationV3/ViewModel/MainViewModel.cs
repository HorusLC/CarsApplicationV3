using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;
using System.Windows.Input;

namespace CarsApplicationV3.ViewModel
{
    /// <summary>
    /// This class contains properties that the main View can data bind to.
    /// <para>
    /// Use the <strong>mvvminpc</strong> snippet to add bindable properties to this ViewModel.
    /// </para>
    /// <para>
    /// You can also use Blend to data bind with the tool's support.
    /// </para>
    /// <para>
    /// See http://www.galasoft.ch/mvvm
    /// </para>
    /// </summary>
    public class MainViewModel : ViewModelBase
    {
        private ViewModelBase _currentViewModel;

        readonly static UploadVehicleVM _uploadVehicle = new UploadVehicleVM();
        readonly static LoadVehiclesVM _loadVehicles = new LoadVehiclesVM();
        /// <summary>
        /// Initializes a new instance of the MainViewModel class.
        /// </summary>
        ///  
        public ICommand UploadVehicleViewCommand { get; private set; }
        public ICommand LoadVehiclesViewCommand { get; private set; }
        public MainViewModel()
        {


            CurrentViewModel = MainViewModel._loadVehicles;

            UploadVehicleViewCommand = new RelayCommand(() => ExecuteUploadVehicleViewCommand());
            LoadVehiclesViewCommand = new RelayCommand(() => ExecuteVehicleDetailsViewCommand());


            


            ////if (IsInDesignMode)
            ////{
            ////    // Code runs in Blend --> create design time data.
            ////}
            ////else
            ////{
            ////    // Code runs "for real"

            ////}
        }
        private void ExecuteVehicleDetailsViewCommand()
        {
            CurrentViewModel = MainViewModel._loadVehicles;
        }

        private void ExecuteUploadVehicleViewCommand()
        {
            CurrentViewModel = MainViewModel._uploadVehicle;
        }


        public ViewModelBase CurrentViewModel
        {
            get
            {
                return _currentViewModel;
            }
            set
            {
                if (_currentViewModel == value)
                    return;
                _currentViewModel = value;
                RaisePropertyChanged("CurrentViewModel");
            }
        }


    }
    }


