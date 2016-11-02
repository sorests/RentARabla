namespace RentARabla.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class _20161102initial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Addresses",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Street = c.String(),
                        StreetNumber = c.Int(nullable: false),
                        City = c.String(),
                        Country = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.People",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        FirstName = c.String(),
                        LastName = c.String(),
                        Email = c.String(),
                        Phone = c.String(),
                        UserName = c.String(),
                        Password = c.String(),
                        Role = c.Int(),
                        Age = c.Int(),
                        NationalId = c.String(),
                        Discriminator = c.String(nullable: false, maxLength: 128),
                        Address_Id = c.Int(),
                        Person_Id = c.Int(),
                        Person_Id1 = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Addresses", t => t.Address_Id)
                .ForeignKey("dbo.People", t => t.Person_Id)
                .ForeignKey("dbo.People", t => t.Person_Id1)
                .Index(t => t.Address_Id)
                .Index(t => t.Person_Id)
                .Index(t => t.Person_Id1);
            
            CreateTable(
                "dbo.Cars",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        PricePerDay = c.Double(nullable: false),
                        ManufactureDate = c.DateTime(nullable: false),
                        FuelType = c.Int(nullable: false),
                        Type = c.Int(nullable: false),
                        Brand = c.Int(nullable: false),
                        Model = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Rentals",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        RentDate = c.DateTime(nullable: false),
                        ReturnDate = c.DateTime(nullable: false),
                        Car_Id = c.Int(),
                        Client_Id = c.Int(),
                        StartLocation_Id = c.Int(),
                        StopLocation_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Cars", t => t.Car_Id)
                .ForeignKey("dbo.People", t => t.Client_Id)
                .ForeignKey("dbo.Addresses", t => t.StartLocation_Id)
                .ForeignKey("dbo.Addresses", t => t.StopLocation_Id)
                .Index(t => t.Car_Id)
                .Index(t => t.Client_Id)
                .Index(t => t.StartLocation_Id)
                .Index(t => t.StopLocation_Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Rentals", "StopLocation_Id", "dbo.Addresses");
            DropForeignKey("dbo.Rentals", "StartLocation_Id", "dbo.Addresses");
            DropForeignKey("dbo.Rentals", "Client_Id", "dbo.People");
            DropForeignKey("dbo.Rentals", "Car_Id", "dbo.Cars");
            DropForeignKey("dbo.People", "Person_Id1", "dbo.People");
            DropForeignKey("dbo.People", "Person_Id", "dbo.People");
            DropForeignKey("dbo.People", "Address_Id", "dbo.Addresses");
            DropIndex("dbo.Rentals", new[] { "StopLocation_Id" });
            DropIndex("dbo.Rentals", new[] { "StartLocation_Id" });
            DropIndex("dbo.Rentals", new[] { "Client_Id" });
            DropIndex("dbo.Rentals", new[] { "Car_Id" });
            DropIndex("dbo.People", new[] { "Person_Id1" });
            DropIndex("dbo.People", new[] { "Person_Id" });
            DropIndex("dbo.People", new[] { "Address_Id" });
            DropTable("dbo.Rentals");
            DropTable("dbo.Cars");
            DropTable("dbo.People");
            DropTable("dbo.Addresses");
        }
    }
}
