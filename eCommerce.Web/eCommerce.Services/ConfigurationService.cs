using eCommerce.Model.Domain;
using eCommerce.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eCommerce.Services
{
    // Service for grabbing configurations
    public class ConfigurationService : BaseService, IConfigurationService
    {
        public List<Configs> GetConfigString()
        {
            List<Configs> ConfigList = new List<Configs>();
            using (SqlConnection conn = new SqlConnection(connString))
            {
                conn.Open();
                using(SqlCommand cmd = new SqlCommand("dbo.Configuration_SelectAll", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    SqlDataReader reader = cmd.ExecuteReader(CommandBehavior.CloseConnection);
                    while (reader.Read())
                    {
                        Configs model = Mapper(reader);
                        ConfigList.Add(model);
                    }
                }
                conn.Close();
            }
            return ConfigList;
        }

        public void AddConfigString()
        {
            throw new NotImplementedException();
        }

        public void DeleteConfigString()
        {
            throw new NotImplementedException();
        }

        public void UpdateConfigString()
        {
            throw new NotImplementedException();
        }

        public Configs Mapper(SqlDataReader reader)
        {
            Configs model = new Configs();
            int index = 0;

            model.Id = reader.GetInt32(index++);
            model.ConfigName = reader.GetString(index++);
            model.ConfigValue = reader.GetString(index++);
            if (!reader.IsDBNull(index))
            {
                model.Description = reader.GetString(index++);
            }
            model.DateCreated = reader.GetDateTime(index++);
            if (!reader.IsDBNull(index))
            {
                model.DateModified = reader.GetDateTime(index++);
            }
            if (!reader.IsDBNull(index))
            {
                model.DataType = reader.GetString(index++);
            }
            if (!reader.IsDBNull(index))
            {
                model.Category = reader.GetString(index++);
            }
            return model;
        }
    }
}
