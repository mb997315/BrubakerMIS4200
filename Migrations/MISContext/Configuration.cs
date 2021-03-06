namespace BrubakerMIS4200.Migrations.MISContext
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<BrubakerMIS4200.DAL.MIS4200Context>
    {
        public Configuration()
        {
            AutomaticMigrationDataLossAllowed = true;
            ContextKey = "BrubakerMIS4200.DAL.MIS4200Context";
            AutomaticMigrationsEnabled = true;
            MigrationsDirectory = @"Migrations\MISContext";
        }

        protected override void Seed(BrubakerMIS4200.DAL.MIS4200Context context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data.
        }
    }
}
