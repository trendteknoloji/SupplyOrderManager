namespace Supply.Orders.Manager.Entity
{
    using Supply.Orders.Manager.Entity.Main;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<SOMContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
            AutomaticMigrationDataLossAllowed = true;
        }

        protected override void Seed(SOMContext context)
        {
            if (context.Database.CreateIfNotExists())
                DbCostumize(context);
            else
            {
                var version = context.Database.SqlQuery<version>("Select name,value From fn_listextendedproperty ('Version',default,default,default,default,default,default)").ToList();
                if (version.Count == 0)
                    DbCostumize(context);
                else
                    foreach (var item in version.ToList())
                        if (item.name == "Version")
                            if (item.value != "v1.0a")
                                return;
            }
            base.Seed(context);
        }
        private void DbCostumize(SOMContext context)
        {
            new SOMDesc<SOMContext>(context).UpdateDatabaseDescriptions();
            context.Database.ExecuteSqlCommand("EXEC sp_addextendedproperty @name = N'Version', @value = 'v1.1a'");
        }
    }

    class version
    {
        public string name { get; set; }
        public string value { get; set; }
    }



}

