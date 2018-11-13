namespace EventRegistrationSystem.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class NewAttribute3 : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.AspNetUsers", "StateZipCode");
        }
        
        public override void Down()
        {
            AddColumn("dbo.AspNetUsers", "StateZipCode", c => c.Int());
        }
    }
}
