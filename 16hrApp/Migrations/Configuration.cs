namespace _16hrApp.Migrations
{
    using _16hrApp.Models;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<_16hrApp.Models.ToDoListDb>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
        }

        protected override void Seed(_16hrApp.Models.ToDoListDb context)
        {
            context.Days.AddOrUpdate(t => t.Name,
                new Day { Name = "Monday" }, new Day { Name = "Tuesday" }, new Day { Name = "Wednesday" });
        }
    }
}
