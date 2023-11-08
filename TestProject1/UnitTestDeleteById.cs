using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Hundekennel.Model;

namespace TestProject
{
    [TestClass]
    public class UnitTestDeleteById
    {
        [TestMethod]
        public void TestDeleteById() 
        {
            // Arrange
            DogRepository dogRepo = new DogRepository();
            dogRepo.Add(new Dog("QWE123", "Lilly", "uu", new DateTime(2021, 21, 1, 0, 0, 0), new DateTime(2022, 2, 2, 12, 0, 0), EnumGender.T, EnumBreedStatus.Aktiv,
                "UIO456", "OPI786", EnumColor.T, "HJU", new DateTime(2022, 12, 13, 0, 0, 0), "B1", "B", "B", "ikke diagn"));
            dogRepo.Add(new Dog("QWE124", "Bongo", "uu", new DateTime(2021, 21, 1, 0, 0, 0), new DateTime(2022, 2, 2, 12, 0, 0), EnumGender.T, EnumBreedStatus.Aktiv,
                "UIO456", "OPI786", EnumColor.T, "HJU", new DateTime(2022, 12, 13, 0, 0, 0), "B1", "B", "B", "ikke diagn"));
            List<Dog> listTwoDogs = dogRepo.GetAll();
            int startCount = listTwoDogs.Count;

            // Act
            dogRepo.DeleteById("QWE124");
            List<Dog> list = dogRepo.GetAll();
            int AfterDeletion = list.Count;

            // Assert
            Assert.AreEqual(startCount-1, list.Count);

        }
    }
}
