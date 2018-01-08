using System.Configuration;

namespace eCommerce.Services
{
    // Service for storing connection strings
    public class BaseService
    {
        protected string connString = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;
        protected string SgApiKey = ConfigurationManager.ConnectionStrings["SendGridKey"].ConnectionString;
    }
}
