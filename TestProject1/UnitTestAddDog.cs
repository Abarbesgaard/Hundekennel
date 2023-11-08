using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;
using Hundekennel;
using Hundekennel.Model;

namespace TestProject
{
    [TestClass]
    public class UnitTestAddDog
    {
        [TestMethod]

        public void UnitTestOfAddDog() 
        {
           
            using(TransactionScope scope = new TransactionScope()) 
            {
                // Arrange
                DogRepository dogRepo = new DogRepository();
                List<Dog> dogList = dogRepo.GetAll();
                int count = dogList.Count;

                Dog dog = new Dog("QWE123", "Lilly", "uu", new DateTime(2021, 21, 1, 0, 0, 0), new DateTime(2022, 2, 2, 12, 0, 0), EnumGender.T, EnumBreedStatus.Aktiv,
                "UIO456", "OPI786", EnumColor.T, "HJU", new DateTime(2022, 12, 13, 0, 0, 0), "B1", "B", "B", "ikke diagn");

                // Act
                dogRepo.Add(dog);
                List<Dog> newList = dogRepo.GetAll();   
                int newCount = newList.Count;

                // Assert
                Assert.AreEqual(newCount, count+1);

            }

        }

    }
}
