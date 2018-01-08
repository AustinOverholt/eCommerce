using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eCommerce.Services.Interfaces
{
    public interface IConfigurationService
    {
        void GetConfigString();
        void AddConfigString();
        void DeleteConfigString();
        void UpdateConfigString();
    }
}
