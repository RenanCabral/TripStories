using System.Data.Entity;
using Core;
using Core.Common;
using Infrastructure.Configurations;

namespace Infrastructure
{
    public class TripStoryContext : DbContext
    {
        #region Constructors
        public TripStoryContext(string nameOrConnectionString) :base(nameOrConnectionString)
        { }
        #endregion

        #region Properties
        public DbSet<Photo> Photos { get; set; }
        public DbSet<City> Cities { get; set; }
        #endregion

        #region Protected Methods
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new PhotoConfiguration());
            modelBuilder.Configurations.Add(new CityConfiguration());

            base.OnModelCreating(modelBuilder);
        }
        #endregion
    }
}
