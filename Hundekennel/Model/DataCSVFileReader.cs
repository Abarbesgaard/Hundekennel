using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hundekennel.Model
{
    public class DataCSVFileReader
    {

        public List<Dog> ReadCSVFile(string dataFileName)
        {
            List<Dog> DogsFromCSVFile = new();

            List<string> lines = File.ReadAllLines(dataFileName).Skip(1).ToList();
            foreach (string line in lines)
                try
                {
                    List<string> felter = line.Split(';').ToList();

                    string lineage = felter[2];
                    string name = felter[4];
                    string identifier = felter[3];
                    string dateOfBirthString = felter[12];
                    DateTime dateOfBirth;
                    if (DateTime.TryParse(dateOfBirthString, out dateOfBirth)) { }
                    else { throw new Exception("Fejl ved parsing af DOB til DateTime"); }
                    string dateAddedString = felter[40];
                    DateTime dateAdded;
                    if (DateTime.TryParse(dateAddedString, out dateAdded)) { }
                    else { throw new Exception("Fejl ved parsing af DateAdded til DateTime"); }
                    string genderString = felter[19];
                    EnumGender gender;
                    if (Enum.TryParse<EnumGender>(genderString, out gender)) { }
                    else
                    {
                        throw new Exception("Fejl ved parsing af string til EnumGender");
                    }
                    string breedStatusString = felter[23];
                    EnumBreedStatus breedStatus;
                    if (Enum.TryParse<EnumBreedStatus>(breedStatusString, out breedStatus)) { }
                    else
                    {
                        throw new Exception("Fejl ved parsing af string til EnumBreedStatus");
                    }
                    string dad = felter[6];
                    string mom = felter[7];
                    string colorString = felter[20].Replace("/", "").ToUpper();
                    EnumColor color;
                    if (Enum.TryParse<EnumColor>(colorString, out color)) { }
                    else
                    {
                        throw new Exception("Fejl ved parsing af string til EnumColor");
                    }
                    string image = felter[25];
                    string lastUpdatedString = felter[36];
                    DateTime lastUpdated;
                    if (DateTime.TryParse(lastUpdatedString, out lastUpdated)) { }
                    else { throw new Exception("Fejl ved parsing af DateAdded til DateTime"); }
                    string hipDysplacia = felter[13];
                    string elbowDysplacia = felter[14];
                    string spondylose = felter[16];
                    string heartCondition = felter[15];
                    string isAliveString = felter[21];
                    bool isAlive = (isAliveString == "1");

                    Dog dog = new Dog(lineage, name, identifier, dateOfBirth, dateAdded, gender, breedStatus, dad, mom, color, image, lastUpdated, hipDysplacia, elbowDysplacia, spondylose, heartCondition, isAlive);
                    DogsFromCSVFile.Add(dog);

                }

                catch (Exception e)
                {
                    Console.WriteLine("Der opstod en fejl ved læsning af hund fra CSVfil", e);
                    continue;
                }
            return DogsFromCSVFile;
        }
    }
}
