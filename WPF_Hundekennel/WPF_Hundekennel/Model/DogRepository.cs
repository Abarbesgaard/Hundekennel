using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;
using System.Xml.Linq;

namespace WPF_Hundekennel.Model
{
    public class DogRepository

    {
        private string connectionString = "Server=10.56.8.36;Database=DB_F23_TEAM_05;User Id=DB_F23_TEAM_05;Password=TEAMDB_DB_05";

        
        public DogRepository() 
        {
           
        }

        // skal der være en metode, som opreter en hund ud fra bruger-input?
        public void Add(Dog dog) 
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                string INSERTsql = "INSERT INTO Dog (Lineage, Name, Identifier, DateOfBirth, DateAdded, Gender, BreedStatus, Dad, Mom, Color, Image, LastUpdated, IsAlive, HipDysplacia, ElbowDysplacia, Spondylose, HeartCondition)" +
                    "VALUES(@lineage, @name, @identifier, @dateOfBirth, @dateAdded, @gender, @breedStatus, @dad, @mom, @color, @image, @lastUpdated, @isAlive, @hipDysplacia, @elbowDysplacia, @spondylose, @heartCondition)";
                using (SqlCommand cmd = new SqlCommand(INSERTsql, connection)) 
                {
                    string lineage = dog.Lineage;
                    string name = dog.Name;                    
                    string identifier = dog.Identifier;
                    DateTime dateOfBirth = dog.DateOfBirth;
                    DateTime dateAdded = dog.DateAdded;
                    string gender = dog.DogDescription.Gender.ToString();
                    string breedStatus = dog.DogDescription.BreedStatus.ToString();
                    string dad = dog.DogDescription.Dad;
                    string mom = dog.DogDescription.Mom;
                    string color = dog.DogDescription.Color.ToString();
                    string image = dog.Image;
                    DateTime lastUpdated = dog.DogDescription.LastUpdated;
                    Boolean isAlive = dog.DogDescription.IsAlive;

                    
                    cmd.Parameters.AddWithValue ("@lineage", lineage);
                    cmd.Parameters.AddWithValue("@name", name);
                    cmd.Parameters.AddWithValue("@identifier", identifier);
                    cmd.Parameters.AddWithValue("@dateOfBirth", dateOfBirth);
                    cmd.Parameters.AddWithValue("@dateAdded", dateAdded);
                    cmd.Parameters.AddWithValue("@gender", gender);
                    cmd.Parameters.AddWithValue("@breedStatus", breedStatus);
                    cmd.Parameters.AddWithValue("@dad", dad);
                    cmd.Parameters.AddWithValue("@mom", mom);
                    cmd.Parameters.AddWithValue("@color", color);
                    cmd.Parameters.AddWithValue("@image", image);
                    cmd.Parameters.AddWithValue("@lastUpdated", lastUpdated);
                    cmd.Parameters.AddWithValue("@isAlive", isAlive);


                    try
                    {
                        cmd.ExecuteNonQuery();
                    }
                    catch (Exception ex) 
                    {
                        Console.WriteLine(ex.Message);
                    }
                    
                }
            }
            

        }

        public Dog GetById(string id) 
        {
            Dog returnedDog = null;

            using (SqlConnection connection = new SqlConnection(connectionString)) 
            {
                connection.Open();

                string GetByIdSQL = "SELECT Name, Identifier, DateOfBirth, DateAdded, Gender, BreedStatus, Dad, Mom, Color, Image, LastUpdated, IsAlive, HipDysplacia, ElbowDysplacia, Spondylose, HeartCondition FROM Dog WHERE Lineage = @lineage";

                using(SqlCommand cmd = new SqlCommand(GetByIdSQL, connection)) 
                {
                    cmd.Parameters.AddWithValue("@lineage", id);

                    using(SqlDataReader reader = cmd.ExecuteReader()) 
                    {
                        try 
                        {
                            if (reader.Read())
                            {
                                string name = reader.GetString(1);
                                string identifier = reader.GetString(2);
                                DateTime dateOfBirth = reader.GetDateTime(3);
                                DateTime dateAdded = reader.GetDateTime(4);
                                string genderString = reader.GetString(5);
                                EnumGender gender;
                                if (Enum.TryParse<EnumGender>(genderString, out gender)) { }
                                else
                                {
                                    throw new Exception("Fejl ved parsing af string til EnumGender");
                                }
                                string breedStatusString = reader.GetString(6);
                                EnumBreedStatus breedStatus;
                                if (Enum.TryParse<EnumBreedStatus>(breedStatusString, out breedStatus)) { }
                                else
                                {
                                    throw new Exception("Fejl ved parsing af string til EnumBreedStatus");
                                }
                                string dad = reader.GetString(7);
                                string mom = reader.GetString(8);
                                string colorString = reader.GetString(9);
                                EnumColor color;
                                if(Enum.TryParse<EnumColor>(colorString, out color)) { }
                                else
                                {
                                    throw new Exception("Fejl ved parsing af string til EnumColor");
                                }
                                string image = reader.GetString(10);
                                DateTime lastUpdated = reader.GetDateTime(11);
                                Boolean isAlive = reader.GetBoolean(12);
                                string hipDysplacia = reader.GetString(13);
                                string elbowDysplacia = reader.GetString(14);
                                string spondylose = reader.GetString(15);
                                string heartCondition = reader.GetString(16);

                                returnedDog = new Dog(id, name, identifier, dateOfBirth, dateAdded, gender, breedStatus, dad, mom, color, image, lastUpdated, hipDysplacia, elbowDysplacia, spondylose, heartCondition);
                                return returnedDog;
                            }
                        }
                        catch (Exception e) 
                        {
                            Console.WriteLine($"Der kan ikke hentes en hund med id: {id} fra databasen", e.Message);
                           
                        }
                        return null;
                    }
                }
            }
        }

        public List<Dog> GetAll()
        {
            List<Dog> AllDogs = new List<Dog>();

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                string GetAllDogsSQL = "SELECT * FROM Dog";

                using (SqlCommand cmd = new SqlCommand(GetAllDogsSQL, connection))
                {
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        try
                        {
                            while (reader.Read())
                            {
                                string lineage = reader.GetString(0);
                                string name = reader.GetString(1);
                                string identifier = reader.GetString(2);
                                DateTime dateOfBirth = reader.GetDateTime(3);
                                DateTime dateAdded = reader.GetDateTime(4);
                                string genderString = reader.GetString(5);
                                EnumGender gender;
                                if (Enum.TryParse<EnumGender>(genderString, out gender)) { }
                                else
                                {
                                    throw new Exception("Fejl ved parsing af string til EnumGender");
                                }
                                string breedStatusString = reader.GetString(6);
                                EnumBreedStatus breedStatus;
                                if (Enum.TryParse<EnumBreedStatus>(breedStatusString, out breedStatus)) { }
                                else
                                {
                                    throw new Exception("Fejl ved parsing af string til EnumBreedStatus");
                                }
                                string dad = reader.GetString(7);
                                string mom = reader.GetString(8);
                                string colorString = reader.GetString(9);
                                EnumColor color;
                                if (Enum.TryParse<EnumColor>(colorString, out color)) { }
                                else
                                {
                                    throw new Exception("Fejl ved parsing af string til EnumColor");
                                }
                                string image = reader.GetString(10);
                                DateTime lastUpdated = reader.GetDateTime(11);
                                Boolean isAlive = reader.GetBoolean(12);
                                string hipDysplacia = reader.GetString(13);
                                string elbowDysplacia = reader.GetString(14);
                                string spondylose = reader.GetString(15);
                                string heartCondition = reader.GetString(16);

                                Dog returnedDog = new Dog(lineage, name, identifier, dateOfBirth, dateAdded, gender, breedStatus, dad, mom, color, image, lastUpdated, hipDysplacia, elbowDysplacia, spondylose, heartCondition);
                                AllDogs.Add(returnedDog);
                            }
                        }
                        catch (Exception e)
                        {
                            Console.WriteLine("Der kan ikke hentes registrerede hunde fra databasen" + e.Message);

                        }
                       
                    }
                }
            } return AllDogs;
        }

        public void UpdateById(Dog dogWithUpdatedValues) 
        {            
            using(SqlConnection connection = new SqlConnection(connectionString)) 
            {
                connection.Open();

                string UPDATEstring = " UPDATE Dog SET Name = @name, Identifier = @identifier, DateOfBirth = @dateOfBirth, DateAdded = @dateAdded, Gender = @gender, " +
                    "BreedStatus = @breedStatus, Dad = @dad, Mom = @mom, Color = @color, Image = @image, LastUpdated = @lastUpdated, IsAlive = @isAlive, HipDysplacia = @hipDysplacia, " +
                    "ElbowDysplacia = @elbowDysplacia, Spondylose = @spondylose, HeartCondition = @heartCondition WHERE Lineage = @lineage";

                using(SqlCommand cmd = new SqlCommand(UPDATEstring, connection)) 
                {
                    cmd.Parameters.AddWithValue("@name", dogWithUpdatedValues.Name);
                    cmd.Parameters.AddWithValue("@identifier", dogWithUpdatedValues.Identifier);
                    cmd.Parameters.AddWithValue("@dateOfBirth", dogWithUpdatedValues.DateOfBirth);
                    cmd.Parameters.AddWithValue("@dateAdded", dogWithUpdatedValues.DateAdded);
                    cmd.Parameters.AddWithValue("@gender", dogWithUpdatedValues.DogDescription.Gender);
                    cmd.Parameters.AddWithValue("@breedStatus", dogWithUpdatedValues.DogDescription.BreedStatus);
                    cmd.Parameters.AddWithValue("@dad", dogWithUpdatedValues.DogDescription.Dad);
                    cmd.Parameters.AddWithValue("@mom", dogWithUpdatedValues.DogDescription.Mom);
                    cmd.Parameters.AddWithValue("@color", dogWithUpdatedValues.DogDescription.Color);
                    cmd.Parameters.AddWithValue("@image", dogWithUpdatedValues.Image);
                    cmd.Parameters.AddWithValue("@lastUpdated", dogWithUpdatedValues.DogDescription.LastUpdated);
                    cmd.Parameters.AddWithValue("@isAlive", dogWithUpdatedValues.DogDescription.IsAlive);

                    try 
                    {
                        cmd.ExecuteNonQuery();
                    }
                    catch (Exception ex) 
                    {
                        Console.WriteLine(ex.Message);
                    }
                    
                }
            }

        }

        public void UpdateFromDataFile(string dataFileName) 
        {
            DataCSVFileReader dCFR = new DataCSVFileReader();
            List<Dog> DogsFromCSVFil = dCFR.ReadCSVFile(dataFileName);

            
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    foreach (Dog dogWithUpdatedValues in DogsFromCSVFil)
                    {
                       string UPDATEstring = " UPDATE Dog SET Name = @name, Identifier = @identifier, DateOfBirth = @dateOfBirth, DateAdded = @dateAdded, Gender = @gender, " +
                            "BreedStatus = @breedStatus, Dad = @dad, Mom = @mom, Color = @color, Image = @image, LastUpdated = @lastUpdated, IsAlive = @isAlive, HipDysplacia = @hipDysplacia, " +
                            "ElbowDysplacia = @elbowDysplacia, Spondylose = @spondylose, HeartCondition = @heartCondition WHERE Lineage = @lineage";

                        using (SqlCommand cmd = new SqlCommand(UPDATEstring, connection))
                        {
                            cmd.Parameters.AddWithValue("@name", dogWithUpdatedValues.Name);
                            cmd.Parameters.AddWithValue("@identifier", dogWithUpdatedValues.Identifier);
                            cmd.Parameters.AddWithValue("@dateOfBirth", dogWithUpdatedValues.DateOfBirth);
                            cmd.Parameters.AddWithValue("@dateAdded", dogWithUpdatedValues.DateAdded);
                            cmd.Parameters.AddWithValue("@gender", dogWithUpdatedValues.DogDescription.Gender);
                            cmd.Parameters.AddWithValue("@breedStatus", dogWithUpdatedValues.DogDescription.BreedStatus);
                            cmd.Parameters.AddWithValue("@dad", dogWithUpdatedValues.DogDescription.Dad);
                            cmd.Parameters.AddWithValue("@mom", dogWithUpdatedValues.DogDescription.Mom);
                            cmd.Parameters.AddWithValue("@color", dogWithUpdatedValues.DogDescription.Color);
                            cmd.Parameters.AddWithValue("@image", dogWithUpdatedValues.Image);
                            cmd.Parameters.AddWithValue("@lastUpdated", dogWithUpdatedValues.DogDescription.LastUpdated);
                            cmd.Parameters.AddWithValue("@isAlive", dogWithUpdatedValues.DogDescription.IsAlive);

                            try
                            {
                                cmd.ExecuteNonQuery();
                            }
                            catch (Exception ex)
                            {
                                Console.WriteLine(ex.Message);
                            }
                        }
                    }
                }
            
        }

        public void DeleteById(string id) 
        {
            using(SqlConnection connection = new SqlConnection(connectionString)) 
            {
                string DElETESql = "Delete FROM Dog WHERE lineage = @lineage";

                using(SqlCommand cmd = new SqlCommand(DElETESql, connection)) 
                {
                    cmd.Parameters.AddWithValue("@lineage", id);
                    cmd.ExecuteNonQuery();
                }
            }
        }
    }
}
