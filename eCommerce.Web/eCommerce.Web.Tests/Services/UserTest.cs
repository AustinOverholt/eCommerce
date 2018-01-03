using eCommerce.Model.Domain;
using eCommerce.Services;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace eCommerce.Web.Tests.Services
{
    [TestClass]
    public class UserTest
    {
        UserService svc = new UserService();
        [TestMethod]
        public void SelectAll()
        {
            List<Users> model = svc.SelectAll();
            Assert.IsNotNull(model);
        }
    }
}
