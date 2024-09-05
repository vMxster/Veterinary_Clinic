using MySql.Data.MySqlClient;
using System.Data;
using Veterinary_Clinic.Models;

namespace Veterinary_Clinic._Repositories
{
    public class PetRepository : BaseRepository, IPetRepository
    {
        public PetRepository(string connectionString)
        {
            this.connectionString = connectionString;
        }

        public IEnumerable<PetModel> GetAll()
        {
            var petList = new List<PetModel>();
            string query = "SELECT * " +
                "FROM PET " +
                "ORDER BY ID DESC";
            using (var connection = new MySqlConnection(connectionString))
            using (var command = new MySqlCommand(query, connection))
            {
                connection.Open();
                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        var petModel = new PetModel
                        {
                            Id = reader.GetInt32(0),
                            Name = reader.GetString(1),
                            Type = reader.GetString(2),
                            Colour = reader.GetString(3)
                        };
                        petList.Add(petModel);
                    }
                }
            }
            return petList;
        }

        public IEnumerable<PetModel> GetByValue(string value)
        {
            var petList = new List<PetModel>();
            int petId = int.TryParse(value, out _) ? Convert.ToInt32(value) : 0;
            string petName = value;
            string query = @"SELECT * " +
                @"FROM PET " +
                @"WHERE ID=@id OR Name like @name " +
                @"ORDER BY ID DESC";
            using (var connection = new MySqlConnection(connectionString))
            using (var command = new MySqlCommand(query, connection))
            {
                connection.Open();
                command.Parameters.Add("@id", MySqlDbType.Int32).Value = petId;
                command.Parameters.Add("@name", MySqlDbType.VarChar).Value = petName + "%";
                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        var petModel = new PetModel
                        {
                            Id = reader.GetInt32(0),
                            Name = reader.GetString(1),
                            Type = reader.GetString(2),
                            Colour = reader.GetString(3)
                        };
                        petList.Add(petModel);
                    }
                }
            }
            return petList;
        }

        public void Add(PetModel petModel)
        {
            string query = @"INSERT INTO PET (Name, Type, Colour) " +
                @"VALUES (@name, @type, @colour)";
            using var connection = new MySqlConnection(connectionString);
            using var command = new MySqlCommand(query, connection);
            connection.Open();
            command.Parameters.Add("@name", MySqlDbType.VarChar).Value = petModel.Name;
            command.Parameters.Add("@type", MySqlDbType.VarChar).Value = petModel.Type;
            command.Parameters.Add("@colour", MySqlDbType.VarChar).Value = petModel.Colour;
            command.ExecuteNonQuery();
        }

        public void Delete(int id)
        {
            string query = @"DELETE FROM PET " +
                @"WHERE ID=@id";
            using var connection = new MySqlConnection(connectionString);
            using var command = new MySqlCommand(query, connection);
            connection.Open();
            command.Parameters.Add("@id", MySqlDbType.Int32).Value = id;
            command.ExecuteNonQuery();
        }

        public void Edit(PetModel petModel)
        {
            string query = @"UPDATE PET " +
                @"SET Name=@name, Type=@type, Colour=@colour " +
                @"WHERE ID=@id";
            using var connection = new MySqlConnection(connectionString);
            using var command = new MySqlCommand(query, connection);
            connection.Open();
            command.Parameters.Add("@name", MySqlDbType.VarChar).Value = petModel.Name;
            command.Parameters.Add("@type", MySqlDbType.VarChar).Value = petModel.Type;
            command.Parameters.Add("@colour", MySqlDbType.VarChar).Value = petModel.Colour;
            command.Parameters.Add("@id", MySqlDbType.Int32).Value = petModel.Id;
            command.ExecuteNonQuery();
        }
    }
}
