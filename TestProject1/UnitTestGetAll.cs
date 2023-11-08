using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using Hundekennel.Model;

namespace TestProject
{
    [TestClass]
    public class UnitTestGetAll
    {
        [TestMethod]
        public void TestGetAll() 
        {
            // Arrange
            string connectionString = "Server=10.56.8.36;Database=DB_F23_TEAM_05;User Id=DB_F23_TEAM_05;Password=TEAMDB_DB_05";

            int tableCount;

            using (SqlConnection conn = new SqlConnection(connectionString)) 
            {
                conn.Open();

                string SELECTSql = "SELECT COUNT (*) FROM Dog";

                using(SqlCommand cmd = new SqlCommand(SELECTSql, conn)) 
                {
                    tableCount = (int)cmd.ExecuteScalar();
                }
            }

            DogRepository dogRepo = new DogRepository();
 
            // Act
            int ReturnedDogsCount = dogRepo.GetAll().Count;

            // Assert
            Assert.AreEqual(tableCount, ReturnedDogsCount);

        }
    }
}
