using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
namespace Hundekennel.Model
{
    public class DogRepository

    {
        private string connectionString = "Server=10.56.8.36;Database=DB_F23_TEAM_05;User Id=DB_F23_TEAM_05;Password=TEAMDB_DB_05";
        private List<Dog> dogList;

        public DogRepository()
        {

        }

        // skal der være en metode, som opreter en hund ud fra bruger-input?

        public void Add(Dog dog)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                using (SqlCommand cmd = new SqlCommand("EXEC sp_Add @lineage, @name, @identifier, @dateOfBirth, @dateAdded, @image", connection))
                {
                    string lineage = dog.Lineage;
                    string name = dog.Name;
                    string identifier = dog.Identifier;
                    DateTime dateOfBirth = dog.DateOfBirth;
                    DateTime dateAdded = dog.DateAdded;
                    string image = dog.Image;

                    cmd.Parameters.AddWithValue("@lineage", lineage);
                    cmd.Parameters.AddWithValue("@name", name);
                    cmd.Parameters.AddWithValue("@identifier", identifier);
                    cmd.Parameters.AddWithValue("@dateOfBirth", dateOfBirth);
                    cmd.Parameters.AddWithValue("@dateAdded", dateAdded);
                    cmd.Parameters.AddWithValue("@image", image);


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
            GetAll();
            Dog returnedDog = dogList.FirstOrDefault(x => x.Lineage == id);


            return returnedDog;
        }

        public List<Dog> GetAll()
        {
            List<Dog> AllDogs = new List<Dog>();
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                SqlCommand cmd = new SqlCommand(@"SELECT * FROM DOG 
                                        LEFT JOIN DOG_DESCRIPTION
                                        ON DOG.Lineage = DOG_DESCRIPTION.DogLineage
                                        "

                , connection);



                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        DogDescription dd = new();
                        string imageTemp = null;
                        if (!Convert.IsDBNull(reader[nameof(Dog.Image)]))
                        {
                            imageTemp = Convert.ToString(reader[nameof(Dog.Image)]);
                        } 

                        if (!Convert.IsDBNull(reader[nameof(DogDescription.Gender)]))
                        {
                            dd.Gender = (EnumGender)Convert.ToInt32(reader[nameof(DogDescription.Gender)]);
                        }

                        if (!Convert.IsDBNull(reader[nameof(DogDescription.BreedStatus)]))
                        {
                            dd.BreedStatus = (EnumBreedStatus)Convert.ToInt32(reader[nameof(DogDescription.BreedStatus)]);
                        }

                        if (!Convert.IsDBNull(reader[nameof(DogDescription.Color)]))
                        {
                            dd.Color = (EnumColor)Convert.ToInt32(reader[nameof(DogDescription.Color)]);
                        }

                        if (!Convert.IsDBNull(reader[nameof(DogDescription.IsAlive)]))
                        {
                            dd.IsAlive = Convert.ToBoolean(reader[nameof(DogDescription.IsAlive)]);
                        }

                        if (!Convert.IsDBNull(reader[nameof(DogDescription.LastUpdated)]))
                        {
                            dd.LastUpdated = Convert.ToDateTime(reader[nameof(DogDescription.LastUpdated)]);
                        }

                        if (!Convert.IsDBNull(reader[nameof(DogDescription.Dad)]))
                        {
                            dd.Dad = Convert.ToString(reader[nameof(DogDescription.Dad)]);
                        }

                        if (!Convert.IsDBNull(reader[nameof(DogDescription.Mom)]))
                        {
                            dd.Mom = Convert.ToString(reader[nameof(DogDescription.Mom)]);
                        }


                        Dog tempDog = new(
                            reader[nameof(Dog.Lineage)].ToString(),
                            reader[nameof(Dog.Name)].ToString(),
                            reader[nameof(Dog.Identifier)].ToString(),
                            Convert.ToDateTime(reader[nameof(Dog.DateOfBirth)]),
                            Convert.ToDateTime(reader[nameof(Dog.DateAdded)]),
                            imageTemp,
                            dd.Gender,
                            dd.BreedStatus,
                            dd.Color,
                            dd.IsAlive,
                            dd.LastUpdated,
                            dd.Dad,
                            dd.Mom
                            );
                        AllDogs.Add(tempDog);

                    }
                    
                }
                dogList = AllDogs;
                return AllDogs;

            }



        }

        public void UpdateById(Dog dogWithUpdatedValues)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

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
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string DElETESql = "Delete FROM Dog WHERE lineage = @lineage";

                using (SqlCommand cmd = new SqlCommand(DElETESql, connection))
                {
                    cmd.Parameters.AddWithValue("@lineage", id);
                    cmd.ExecuteNonQuery();
                }
            }
        }
    }
}
