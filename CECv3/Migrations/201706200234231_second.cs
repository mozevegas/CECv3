namespace CECv3.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class second : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.AcctTypes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        AcctType = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            AddColumn("dbo.AcctDetails", "AcctTypesId", c => c.String());
            AddColumn("dbo.AcctDetails", "AcctTypes_Id", c => c.Int());
            CreateIndex("dbo.AcctDetails", "AcctTypes_Id");
            AddForeignKey("dbo.AcctDetails", "AcctTypes_Id", "dbo.AcctTypes", "Id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.AcctDetails", "AcctTypes_Id", "dbo.AcctTypes");
            DropIndex("dbo.AcctDetails", new[] { "AcctTypes_Id" });
            DropColumn("dbo.AcctDetails", "AcctTypes_Id");
            DropColumn("dbo.AcctDetails", "AcctTypesId");
            DropTable("dbo.AcctTypes");
        }
    }
}
