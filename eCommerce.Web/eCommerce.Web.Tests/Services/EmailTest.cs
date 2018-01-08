using eCommerce.Services;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace eCommerce.Web.Tests.Services
{
    [TestClass]
    public class EmailTest
    {
        SendGridService svc = new SendGridService();
        [TestMethod]
        public void ContactUsTest()
        {
            svc.SendContactUsEmail().Wait();
        }
    }
}
