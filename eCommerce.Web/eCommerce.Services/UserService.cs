using eCommerce.Model.Domain;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace eCommerce.Services
{
    // Class for accessing users
    public class UserService : BaseService
    {
        // Select All Users
        public List<Users> SelectAll()
        {
            List<Users> UserList = new List<Users>();
            using(SqlConnection conn = new SqlConnection(connString))
            {
                conn.Open();
                using(SqlCommand cmd = new SqlCommand("dbo.AspNetUsers_SelectAll", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    SqlDataReader reader = cmd.ExecuteReader(CommandBehavior.CloseConnection);
                    while (reader.Read())
                    {
                        Users model = Mapper(reader);
                        UserList.Add(model);
                    }
                }
                conn.Close();
            }
            return UserList;
        }

        private Users Mapper(SqlDataReader reader)
        {
            Users model = new Users();
            int index = 0;

            model.Id = reader.GetString(index++);
            model.Email = reader.GetString(index++);
            model.EmailConfirmed = reader.GetBoolean(index++);
            model.PasswordHash = reader.GetString(index++);
            model.SecurityStamp = reader.GetString(index++);
            if (!reader.IsDBNull(index)) // Because value can be null
            {
                model.PhoneNumber = reader.GetString(index++);
            }
            else
            {
                index++;
            }
            
            model.PhoneNumberConfirmed = reader.GetBoolean(index++);
            model.TwoFactorEnabled = reader.GetBoolean(index++);
            if (!reader.IsDBNull(index))
            {
                model.LockoutEndDateUtc = reader.GetDateTime(index++);
            }
            else
            {
                index++;
            }
            model.LockoutEnabled = reader.GetBoolean(index++);
            model.AccessFailedCount = reader.GetInt32(index++);
            model.UserName = reader.GetString(index++);

            return model;
        }
    }
}
