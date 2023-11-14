using Hundekennel.Command;
using Hundekennel.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Hundekennel.ViewModel
{
    /// <summary>
    /// Indeholder et object af Collection View model
    /// </summary>
    public class CollectionViewModel : ObservableObject, INotifyPropertyChanged
    {
        #region Properties
        
        public readonly DogRepository _dogRepository;

        private List<Dog> _allDogs;
        public List<Dog> AllDogs
        {
            get { return _allDogs; }
            set
            {
                if (_allDogs != value)
                {
                    _allDogs = value;
                    OnPropertyChanged(nameof(AllDogs));
                }
            }
        }

        public ICommand AddDogCommand { get; }
       
        public Dog SelectedDog { get; set; }

        #endregion

        #region Collection View Model
        /// <summary>
        /// Constructor på Collection view model. Denne har en DogRepository som variable
        /// </summary>
        /// <param name="dogRepository">Dog Repository variabel</param>
        public CollectionViewModel( DogRepository dogRepository)
        {
            _dogRepository = dogRepository;
            AllDogs = _dogRepository.GetAll();
            _dogRepository.GetById("153");
            AddDogCommand = new RelayCommand(AddDog, CanAddDog);
        }

        public CollectionViewModel()
        {
        }
        #endregion

        #region Metoder til Relay COmmand i Collection View Model Constructor
        /// <summary>
        /// Metoden tillader relay Command at tilføje hund til database
        /// </summary>
        /// <param name="parameter">Det er en generisk parameter af typen object, <br />hvilket betyder, at det kan acceptere værdier af enhver type, da alle typer i C# arver fra object</param>
        /// <returns>True</returns>
        private bool CanAddDog(object parameter)
        { return true; }

        /// <summary>
        /// Metoden tillader relay Command at tilføje hund til database
        /// </summary>
        /// <param name="parameter">Det er en generisk parameter af typen object, <br />hvilket betyder, at det kan acceptere værdier af enhver type, da alle typer i C# arver fra object</param>
        private void AddDog(object parameter)
        {
            var random = new Random();
            int x = random.Next(1,1000);
            string DogName = parameter as string;
            _dogRepository.Add(new Dog(x.ToString(), DogName, "EMPTY TATTOO", DateTime.Now, DateTime.Now, EnumGender.H, EnumBreedStatus.Aktiv, "DADNR", "MOMNR", EnumColor.RG, "IMG", DateTime.Now, null, null, null, null, true));
        }
        #endregion
    }


}
