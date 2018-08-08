using Microsoft.VisualStudio.TestTools.UnitTesting;
using ContinuousWeb.Controllers;


namespace ContinuosWeb.Tests
{
    [TestClass]
    public class HomeControllerTests
    {
        [TestMethod]
        public void AboutPageTest()
        {
            var homeController = new HomeController();
            var result = homeController.About();
        }
    }
}
