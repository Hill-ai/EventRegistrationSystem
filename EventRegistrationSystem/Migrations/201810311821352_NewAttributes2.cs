namespace EventRegistrationSystem.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class NewAttributes2 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.AspNetUsers", "StateZipCode", c => c.Int());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.AspNetUsers", "StateZipCode", c => c.Int(nullable: false));
        }
    }
}
