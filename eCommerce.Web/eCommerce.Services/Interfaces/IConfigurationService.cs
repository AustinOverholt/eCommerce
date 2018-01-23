using eCommerce.Model.Domain;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace eCommerce.Services.Interfaces
{
    public interface IConfigurationService
    {
        List<Configs> GetConfigString();
        void AddConfigString();
        void DeleteConfigString();
        void UpdateConfigString();
        Configs Mapper(SqlDataReader reader);
    }
}
