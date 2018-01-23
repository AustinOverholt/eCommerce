using eCommerce.Model.Domain;
using eCommerce.Services;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace eCommerce.Web.Tests.Services
{
    [TestClass]
    public class ConfigTest
    {
        ConfigurationService svc = new ConfigurationService();
        [TestMethod]
        public void SelectAll()
        {
            List<Configs> model = svc.GetConfigString();
            Assert.IsNotNull(model);
        }
    }
}
