using Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Repositories
{
    public class PhotoRepository : BaseRepository
    {
        public PhotoRepository()
        {
        }

        public List<Photo> GetAllPhotos()
        {
            return DataContext.Photos.ToList();
        }

    }
}
