using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hundekennel.Model
{
    public class DogDescription
    {
        #region Properties
        public EnumGender? Gender { get; set; }
        public EnumBreedStatus? BreedStatus { get; set; }
        public string? Dad { get; set; }

        public string? Mom { get; set; }
        public EnumColor? Color { get; set; }
        public Boolean? IsAlive { get; set; }
        public DateTime? LastUpdated { get; set; }
        #endregion
        /// <summary>
        /// Beskrivelse af hunden
        /// </summary>
        /// <param name="gender">hundens køn</param>
        /// <param name="breedStatus">Hundens alve status</param>
        /// <param name="dad"></param>
        /// <param name="mom"></param>
        /// <param name="color"></param>
        /// <param name="picturePath"></param>
        /// <param name="lastUpdated"></param>
        /// <param name="isAlive"></param>
        public DogDescription(EnumGender? gender, EnumBreedStatus? breedStatus, string? dad, string? mom, EnumColor? color, DateTime? lastUpdated, Boolean? isAlive)
        {
            Gender = gender;
            BreedStatus = breedStatus;
            Dad = dad;
            Mom = mom;
            Color = color;
            LastUpdated = lastUpdated;
            IsAlive = isAlive;
        }

        public DogDescription() { }
    }
}
