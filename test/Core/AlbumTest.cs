using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using Core;
using System.Linq;

namespace Test
{
    [TestClass]
    public class AlbumTest
    {
        [TestMethod]
        public void Album_Must_Have_Photos()
        {
            //arrange 
            var album = new Album();

            //act
            album.Photos = new List<Photo>() { new Photo() { ID = 1 } };

            //result 
            Assert.IsTrue(album.GetAllPhotos().Any(), "Album must have at least one photo");
        }
    }
}
