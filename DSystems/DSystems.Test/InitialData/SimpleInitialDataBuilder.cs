using System;
using System.Data.Entity.Migrations;
using DSystems.EntityFramework;

namespace DSystems.Test.InitialData
{
    public class SimpleInitialDataBuilder
    {
        public void Build(DSystemsDbContext context)
        {
            context.Users.AddOrUpdate(x =>
                x.FirstName,
                new DSystems.Domain.User() { FirstName = "Hüseyin", LastName = "Özdemir", IsActive = true, CreationTime = DateTime.Now },
                new DSystems.Domain.User { FirstName = "Osman", LastName = "Bozokluoğlu", IsActive = true, CreationTime = DateTime.Now },
                new DSystems.Domain.User { FirstName = "Erhan", LastName = "Ballıeker", IsActive = true, CreationTime = DateTime.Now },
                new DSystems.Domain.User { FirstName = "Hasan", LastName = "Dögen", IsActive = true, CreationTime = DateTime.Now },
                new DSystems.Domain.User { FirstName = "Emre", LastName = "Kirpiksiz", IsActive = true, CreationTime = DateTime.Now }
                );

            context.SaveChanges();
        }
    }
}
