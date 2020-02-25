namespace cf085115_Mis4200.Migrations.MISContext
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<cf085115_Mis4200.Models.DAL.MIS4200Context>
    {
        public Configuration()
        {
            AutomaticMigrationDataLossAllowed = true;
            AutomaticMigrationsEnabled = true;
            MigrationsDirectory = @"Migrations\MISContext";
            ContextKey = "cf085115_Mis4200.Models.DAL.MIS4200Context";
        }

        protected override void Seed(cf085115_Mis4200.Models.DAL.MIS4200Context context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data.
        }
    }
}
