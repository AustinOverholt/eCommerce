using System.Configuration;

namespace eCommerce.Services
{
    public class BaseService
    {
        protected string connString = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;
    }
}
