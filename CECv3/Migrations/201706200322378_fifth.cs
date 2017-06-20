namespace CECv3.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class fifth : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.AcctDetails", "AcctTypes_Id", "dbo.AcctTypes");
            DropIndex("dbo.AcctDetails", new[] { "AcctTypes_Id" });
            AddColumn("dbo.AcctDetails", "AcctType", c => c.String());
            DropColumn("dbo.AcctDetails", "AcctTypesId");
            DropColumn("dbo.AcctDetails", "AcctTypes_Id");
            DropTable("dbo.AcctTypes");
        }
        
        public override void Down()
        {
            CreateTable(
                "dbo.AcctTypes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        AcctType = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            AddColumn("dbo.AcctDetails", "AcctTypes_Id", c => c.Int());
            AddColumn("dbo.AcctDetails", "AcctTypesId", c => c.String());
            DropColumn("dbo.AcctDetails", "AcctType");
            CreateIndex("dbo.AcctDetails", "AcctTypes_Id");
            AddForeignKey("dbo.AcctDetails", "AcctTypes_Id", "dbo.AcctTypes", "Id");
        }
    }
}
