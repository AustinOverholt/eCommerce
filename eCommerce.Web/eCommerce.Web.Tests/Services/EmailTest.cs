using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using eCommerce.Services;

namespace eCommerce.Web.Tests.Services
{
    [TestClass]
    public class EmailTest
    {
        SendGridService svc = new SendGridService();
        [TestMethod]
        public void ContactUsTest()
        {
            svc.SendContactUsEmail();
        }
    }
}
