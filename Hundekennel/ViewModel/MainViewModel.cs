using Hundekennel.Command;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hundekennel.ViewModel
{
    /// <summary>
    ///  Indeholder et Object af main view model, som arver fra observable object
    /// </summary>
    public class MainViewModel : ObservableObject
    {
        #region Commands
        public RelayCommand HomeViewCommand { get; set; }
        public RelayCommand CollectionViewCommand { get; set; }
        #endregion 
        #region Properties

        public HomeViewModel HomeVM { get; set; }

        public CollectionViewModel CollectionVM { get; set; }

        private object _currentView;


        public object CurrentView
        {
            get { return _currentView; }
            set
            {
                _currentView = value;
                OnPropertyChanged();
            }
        }
        #endregion

        /// <summary>
        /// <para> MainView model Constructor, initialiserer de andre view models: Home view model, Collection View Model etc. </para>
        /// Hvis der kommer flere views skal de indsættes her
        /// </summary>

        public MainViewModel()
        {
            #region initialisering af objekter
            HomeVM = new HomeViewModel();
            CollectionVM = new CollectionViewModel();
            CurrentView = HomeVM;
            #endregion


            HomeViewCommand = new RelayCommand(o =>
            {
                CurrentView = HomeVM;
            });
            CollectionViewCommand = new RelayCommand(o =>
            {
                CurrentView = CollectionVM;
            });
        }
    }
}
