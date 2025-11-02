using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using zhFelkeszito2.Model;

namespace zhFelkeszito2.Dao
{
    internal class AdoPetDao : IPetDao
    {
        private readonly string connectionString =
            @"Data Source=C:\Users\TheArtist\Desktop\Programing\VisualStudio\zhFelkeszito2\Pet.db";

        public bool AddPet(Pet pet)
        {
            using (SQLiteConnection connection = new SQLiteConnection(connectionString))
            {
                connection.Open();
                using (SQLiteCommand command = connection.CreateCommand())
                {
                    command.CommandText = "INSERT INTO " +
                        "pets(id,name,gender,age,weight,species) VALUES " +
                        "(@Id, @name, @gender, @age, @weight, @species)";

                    command.Parameters.Add("@Id", System.Data.DbType.String).Value = pet.Id;
                    command.Parameters.Add("@name", System.Data.DbType.String).Value = pet.name;
                    command.Parameters.Add("@gender", System.Data.DbType.String).Value = pet.gender;
                    command.Parameters.Add("@age", System.Data.DbType.String).Value = pet.age;
                    command.Parameters.Add("@weight", System.Data.DbType.String).Value = pet.weight;
                    command.Parameters.Add("@species", System.Data.DbType.String).Value = pet.species;

                    int affectedRows = command.ExecuteNonQuery();
                    if(affectedRows > 0)
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
            }
        }

        public IEnumerable<Pet> GetAllPets()
        {
            using (SQLiteConnection connection = new SQLiteConnection(connectionString))
            {
                connection.Open(); // Close() -> Dispose() -> using miatt nem kell

                using (SQLiteCommand command = connection.CreateCommand())
                {
                    command.CommandText = "SELECT * FROM pets";

                    using (SQLiteDataReader reader = command.ExecuteReader())
                    {
                        List<Pet> list = [];


                        while (reader.Read())
                        {
                            var tmpId = reader.GetInt32(reader.GetOrdinal("id"));
                            var tmpName = reader.GetString(reader.GetOrdinal("name"));
                            var tmpGender = reader.GetString(reader.GetOrdinal("gender"));
                            bool gend = tmpGender.ToLower() == "true" ? true : false;
                            var tmpAge = reader.GetInt32(reader.GetOrdinal("age"));
                            var tmpWeight = reader.GetInt32(reader.GetOrdinal("weight"));
                            var tmpspecies = reader.GetString(reader.GetOrdinal("species"));
                            Pet pet = new Pet(tmpId,tmpName,gend,tmpAge,tmpWeight,tmpspecies);

                            list.Add(pet);
                        }

                        return list;
                    }
                }
            }
        }

        public bool UpdatePet(Pet pet)
        {
            using (SQLiteConnection connection = new SQLiteConnection(connectionString))
            {
                connection.Open(); // Close() -> Dispose() -> using miatt nem kell

                using (SQLiteCommand command = connection.CreateCommand())
                {
                    command.CommandText = "UPDATE pets SET " +
                                            "id=@Id,"+
                                            "name=@name," +
                                            "gender=@gender," +
                                            "age=@age," +
                                            "weight=@weight" +
                                            "species=@species" +
                                            "WHERE id=@Id";

                    command.Parameters.Add("@id", System.Data.DbType.Int32).Value = pet.Id;
                    command.Parameters.Add("@name", System.Data.DbType.String).Value = pet.name;
                    command.Parameters.Add("@gender", System.Data.DbType.Boolean).Value = pet.gender;
                    command.Parameters.Add("@age", System.Data.DbType.Int32).Value = pet.age;
                    command.Parameters.Add("@weight", System.Data.DbType.Int32).Value = pet.weight;
                    command.Parameters.Add("@species", System.Data.DbType.String).Value = pet.species;

                    int affectedRows = command.ExecuteNonQuery();
                    if (affectedRows > 0)
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
            }
        }
    }
}
