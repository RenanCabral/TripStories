using Infrastructure.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Web.Models;

namespace Web.Controllers
{
    public class PhotoController : Controller
    {
        public List<Photo> GetAllPhotos()
        {
            var repository = new PhotoRepository();
            var photoList = new List<Photo>();

            repository.GetAllPhotos().ForEach(x => photoList.Add(new Photo() { ID = x.ID, Description = x.Description }));

            return photoList;
        }
    }
}