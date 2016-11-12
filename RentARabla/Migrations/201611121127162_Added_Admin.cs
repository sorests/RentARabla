namespace RentARabla.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Added_Admin : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Cars", "PricePerDay_PriceValue", c => c.Double(nullable: false));
            AddColumn("dbo.Cars", "PricePerDay_Currency", c => c.Int(nullable: false));
            DropColumn("dbo.Cars", "PricePerDay");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Cars", "PricePerDay", c => c.Double(nullable: false));
            DropColumn("dbo.Cars", "PricePerDay_Currency");
            DropColumn("dbo.Cars", "PricePerDay_PriceValue");
        }
    }
}
