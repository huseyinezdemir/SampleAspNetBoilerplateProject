using DSystems.EntityFramework;

namespace DSystems.Test.InitialData
{
    public class SimpleInitialDataBuilder
    {
        public void Build(DSystemsDbContext context)
        {
            context.Users.Add(new DSystems.Domain.User() { FirstName = "Hüseyin", LastName = "Özdemir" });
            context.Users.Add(new DSystems.Domain.User { FirstName = "Osman", LastName = "Bozokluoğlu" });
            context.Users.Add(new DSystems.Domain.User { FirstName = "Erhan", LastName = "Ballıeker" });
            context.Users.Add(new DSystems.Domain.User { FirstName = "Hasan", LastName = "Dögen" });
            context.Users.Add(new DSystems.Domain.User { FirstName = "Emre", LastName = "Kirpiksiz" });

            context.SaveChanges();
        }
    }
}
