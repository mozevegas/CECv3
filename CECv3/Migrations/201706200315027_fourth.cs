namespace CECv3.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class fourth : DbMigration
    {
        public override void Up()
        {
            RenameColumn(table: "dbo.AcctDetails", name: "TypeAcct_Id", newName: "AcctTypes_Id");
            RenameIndex(table: "dbo.AcctDetails", name: "IX_TypeAcct_Id", newName: "IX_AcctTypes_Id");
        }
        
        public override void Down()
        {
            RenameIndex(table: "dbo.AcctDetails", name: "IX_AcctTypes_Id", newName: "IX_TypeAcct_Id");
            RenameColumn(table: "dbo.AcctDetails", name: "AcctTypes_Id", newName: "TypeAcct_Id");
        }
    }
}
