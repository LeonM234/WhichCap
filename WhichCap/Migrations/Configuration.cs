namespace WhichCap.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<WhichCap.Context.WhichContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
            ContextKey = "WhichCap.Context.WhichContext";
        }

        protected override void Seed(WhichCap.Context.WhichContext context)
        {
            
        }
    }
}
