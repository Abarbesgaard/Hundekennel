
using System;
using Hundekennel.Model;

namespace TestProject
{
    [TestClass]
    public class UnitTestDogClass
    {
        [TestMethod]
        public void TestOfDogClass()
        {
            // Arrange
            string lineage = "ABC123";
            string name = "Fido";
            string identifier = "111";
            DateTime dateOfBirth = new DateTime(2020, 1, 1, 12, 12, 12);
            DateTime dateAdded = new DateTime(2023, 2, 3, 13, 13, 13);
            EnumGender gender = EnumGender.T;
            EnumBreedStatus breedStatus = EnumBreedStatus.Aktiv;
            string dad = "DEF123";
            string mom = "GHI123";
            EnumColor color = EnumColor.T;
            string image = "path";
            DateTime lastUpdated = new DateTime(2023, 4, 4, 14, 14, 14);
            string hipDysplacia = "A2";
            string elbowDysplacia = "2";
            string spondylose = "2";
            string heartCondition = "Negative";
            Boolean isAlive = true;


            // Act
            Dog testDog = new Dog(lineage, name, identifier, dateOfBirth, dateAdded, gender, breedStatus, dad, mom, color, image, lastUpdated, hipDysplacia, elbowDysplacia, spondylose, heartCondition, isAlive); 

            //Assert
            Assert.AreEqual(testDog.Lineage, lineage);
            Assert.AreEqual(testDog.Name, name);
            Assert.AreEqual(testDog.Identifier, identifier);
            Assert.AreEqual(testDog.DateOfBirth, dateOfBirth);
            Assert.AreEqual(testDog.DateAdded, dateAdded);
            Assert.AreEqual(testDog.DogDescription.Gender, gender);
            Assert.AreEqual(testDog.DogDescription.BreedStatus, breedStatus);
            Assert.AreEqual(testDog.DogDescription.Dad, dad);
            Assert.AreEqual(testDog.DogDescription.Mom, mom);
            Assert.AreEqual(testDog.DogDescription.Color, color);
            Assert.AreEqual(testDog.Image, image);  
            Assert.AreEqual(testDog.DogDescription.LastUpdated, lastUpdated);
            Assert.AreEqual(testDog.Health.HipDysplacia, hipDysplacia);
            Assert.AreEqual(testDog.Health.ElbowDysplacia, elbowDysplacia);
            Assert.AreEqual(testDog.Health.Spondylose, spondylose);
            Assert.AreEqual(testDog.Health.HeartCondition, heartCondition);
            Assert.AreEqual(testDog.DogDescription.IsAlive, isAlive);

        }
    }
}