using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hundekennel.Model
{
    public class Dog
    {
        #region properties
        public string Lineage { get; private set; }
        public string Name { get; private set; }
        public string Identifier { get; private set; }
        public DateTime DateOfBirth { get; private set; }
        public DateTime DateAdded { get; private set; }
        public string Image { get; private set; }
        public DogDescription DogDescription { get; private set; }
        public Health Health { get; private set; }
        #endregion

        /// <summary>
        /// Constructoren for hundeklassen
        /// </summary>
        /// <param name="lineage">Stamtavle nummeret, med eller uden bogstaver, på hunden</param>
        /// <param name="name">navnet på hunden</param>
        /// <param name="identifier"> Identifikations nummeret, chip eller tattoo</param>
        /// <param name="dateOfBirth">Fødselsdato på hunden</param>
        /// <param name="dateAdded">hvornår er den tilføjet til systemet</param>
        /// <param name="gender">Hundens køn</param>
        /// <param name="breedStatus">Status på om hunden kan avles på: aktiv eller passiv</param>
        /// <param name="dad">Hundens fader's stamnummer</param>
        /// <param name="mom">Hundens Moder's stamnummer</param>
        /// <param name="color">Hundens farve</param>
        /// <param name="image">billede af hunden</param>
        /// <param name="lastUpdated">Senest opdateret</param>
        /// <param name="hipDysplacia">Om hunden har Hoftedysplasi</param>
        /// <param name="elbowDysplacia">Om hunden har albue dysplasi</param>
        /// <param name="spondylose">Om hunden har spondylose</param>
        /// <param name="heartCondition">Om hunden har hjerte problemet</param>
        /// <param name="isAlive">Om hunden lever</param>
        public Dog(string lineage, string name, string identifier, DateTime dateOfBirth, DateTime dateAdded, EnumGender gender, EnumBreedStatus breedStatus, string dad, string mom, EnumColor color, string image, DateTime lastUpdated, string hipDysplacia, string elbowDysplacia, string spondylose, string heartCondition, Boolean isAlive = true)

        {

            Lineage = lineage;
            Name = name;
            Identifier = identifier;
            DateOfBirth = dateOfBirth;
            DateAdded = dateAdded;
            Image = image;
            DogDescription = new DogDescription(gender, breedStatus, dad, mom, color, image, lastUpdated);
            Health = new Health(hipDysplacia, elbowDysplacia, spondylose, heartCondition);

        }


    }
}
