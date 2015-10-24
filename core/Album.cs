using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core
{
    public class Album
    {
        #region Properties

        public int ID { get; set; }
        public List<Photo> Photos { get; set; }

        #endregion

        #region Methods
        public List<Photo> GetAllPhotos()
        {
            return Photos;
        }

        #endregion
    }
}
