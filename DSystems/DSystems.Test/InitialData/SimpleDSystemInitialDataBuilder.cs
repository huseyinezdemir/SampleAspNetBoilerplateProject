using DSystems.EntityFramework;

namespace DSystems.Test.InitialData
{
    public class SimpleDSystemInitialDataBuilder
    {
        public void Build(DSystemsDbContext context)
        {
            context.Users.Add(new Domain.User { FirstName = "Huseyin" });
            context.Users.Add(new Domain.User { FirstName = "Mustafa" });
            context.Users.Add(new Domain.User { FirstName = "Osman" });
            context.Users.Add(new Domain.User { FirstName = "Hasan" });
            context.Users.Add(new Domain.User { FirstName = "Ozgur" });

            context.SaveChanges();
        }
    }
}
