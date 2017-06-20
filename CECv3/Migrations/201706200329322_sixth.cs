namespace CECv3.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class sixth : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.AcctDetails", "AccountType", c => c.String());
            DropColumn("dbo.AcctDetails", "AcctType");
        }
        
        public override void Down()
        {
            AddColumn("dbo.AcctDetails", "AcctType", c => c.String());
            DropColumn("dbo.AcctDetails", "AccountType");
        }
    }
}
