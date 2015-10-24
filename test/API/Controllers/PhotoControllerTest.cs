using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Web.Controllers;

namespace Test.API.Controllers
{
    [TestClass]
    public class PhotoControllerTest
    {
        public PhotoControllerTest()
        { }

        [TestMethod]
        public void GetAllPhotos()
        {
            var photoController = new PhotoController();
            var result = photoController.GetAllPhotos();
            Assert.IsTrue(result.First().Description == "The first photo in Melbourne");
        }
    }
}
