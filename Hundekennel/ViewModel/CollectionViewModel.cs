using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hundekennel.ViewModel
{
    /// <summary>
    /// Indeholder et object af Collection View model
    /// </summary>

    public class CollectionViewModel
    {

        #region ListeAfPersoner
        public List<Dog> Dogs { get; set; }
            = new List<Dog>
            {
            new Dog{ DogName = "Buster", DogGender = "Han"},
            new Dog{ DogName = "Medister", DogGender = "Han"},
            new Dog{ DogName = "Kaffe", DogGender = "Tæve"},
            };
        #endregion

        #region SelectedDog
        public Dog SelectedDog { get; set; }

        #endregion
        public CollectionViewModel()
        {

        }
    }
    // OBS FØLGENDE KLASSE ER EN TEST KLASSE OG IKKE ENDELIG IMPLEMENTERING
    public class Dog
    {
        public string DogName { get; set; }
        public string DogGender { get; set; }


    }
}
