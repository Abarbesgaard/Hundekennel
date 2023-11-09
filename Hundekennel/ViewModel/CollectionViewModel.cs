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

    public class CollectionViewModel : INotifyPropertyChanged
    {
        private readonly DogRepository _dogRepository;

        public event PropertyChangedEventHandler? PropertyChanged;

        public ICommand AddDogCommand { get; }
       
        #region SelectedDog
        public Dog SelectedDog { get; set; }

        #endregion
        public CollectionViewModel( DogRepository dogRepository)
        {
            _dogRepository = dogRepository;
            _dogRepository.GetById("153");
            AddDogCommand = new RelayCommand(AddDog, CanAddDog);
        }

        private bool CanAddDog(object parameter)
        { return true; }

        private void AddDog(object parameter)
        {
            var random = new Random();
            int x = random.Next(1,1000);
            string DogName = parameter as string;
            _dogRepository.Add(new Dog(x.ToString(), DogName, "EMPTY TATTOO", DateTime.Now, DateTime.Now, EnumGender.H, EnumBreedStatus.Aktiv, "DADNR", "MOMNR", EnumColor.RG, "IMG", DateTime.Now, null, null, null, null, true));
        }
    }
    
   
}
