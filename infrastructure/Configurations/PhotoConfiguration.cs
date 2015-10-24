using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using Core;


namespace Infrastructure.Configurations
{
    public class PhotoConfiguration : EntityTypeConfiguration<Photo>
    {
        public PhotoConfiguration()
        {
            ToTable("Photos");
        } 
    }
}
