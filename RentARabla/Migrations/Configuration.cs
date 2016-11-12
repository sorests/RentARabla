namespace RentARabla.Migrations
{
    using Enums;
    using Models;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<RentARabla.Contexts.RentARablaDBContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
        }

        protected override void Seed(Contexts.RentARablaDBContext context)
        {
            SeedAdmin(context);
        }

        private void SeedAdmin(Contexts.RentARablaDBContext context)
        {
            var admin = context.Administrators.FirstOrDefault();
            if (admin != null)
                return;

            var person = new Person
            {
                FirstName = "Admin",
                LastName = "Admin",
                UserName = "admin",
                Password = "admin",
                Email = "admin@mail.com",
                Phone = "0721341290"
            };

            context.Administrators.Add(
                new Administrator
                {
                    Role = Role.Admin,
                    Person = person
                });
        }
    }
}
