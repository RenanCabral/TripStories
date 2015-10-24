using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;

namespace Infrastructure.Repositories
{
    public class BaseRepository
    {
        #region Properties
        protected TripStoryContext DataContext { get; set; }
        #endregion

        #region Constructors
        public BaseRepository()
        {
            DataContext = new TripStoryContext(ConfigurationManager.ConnectionStrings["TripStoryConnection"].ConnectionString);
        }
        #endregion
    }
}
