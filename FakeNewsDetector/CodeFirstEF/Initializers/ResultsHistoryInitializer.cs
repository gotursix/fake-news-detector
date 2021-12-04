using System.Data.Entity;

namespace EntityFramework.Initializers
{
    public class ResultsHistoryInitializer : DropCreateDatabaseAlways<AppDbContext>
    {
        protected override void Seed(AppDbContext context)
        {
            //Initialize results history
        }
    }
}