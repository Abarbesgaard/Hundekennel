using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WPF_Hundekennel.Model;

namespace TestProject
{
    [TestClass]
    public class UnitTestUpdateById
    {
        [TestMethod]

        public void UpdateById() 
        {
            // Arrange
            Dog dog = new Dog("UIO987", "Mini", "uu", new DateTime(2021, 21, 1, 0, 0, 0), new DateTime(2022, 2, 2, 12, 0, 0), EnumGender.T, EnumBreedStatus.Aktiv,
                "UIO456", "OPI786", EnumColor.T, "HJU", new DateTime(2022, 12, 13, 0, 0, 0), "B1", "B", "B", "ikke diagn");
            Dog updatedDog = new Dog("UIO987", "Maxi", "uu", new DateTime(2021, 21, 1, 0, 0, 0), new DateTime(2022, 2, 2, 12, 0, 0), EnumGender.T, EnumBreedStatus.Aktiv,
                "UIO456", "OPI786", EnumColor.T, "HJU", new DateTime(2022, 12, 13, 0, 0, 0), "B1", "B", "B", "ikke diagn");
            DogRepository dogRepo = new DogRepository();
            dogRepo.Add(dog);


            // Act
            dogRepo.UpdateById(updatedDog);
            Dog? testDog = dogRepo.GetById("UIO987");


            // Assert
            Assert.AreEqual("Maxi", testDog?.Name);
        }
    }
}
