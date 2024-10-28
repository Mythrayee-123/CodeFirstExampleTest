namespace CodeFirstExampleTest.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Added_newColumn_CustomerCountry : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Customers", "CustomerCountry", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Customers", "CustomerCountry");
        }
    }
}
