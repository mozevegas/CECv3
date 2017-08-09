namespace CECv3.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class changedFields : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Coupons", "COUP_GS1", c => c.String());
            AddColumn("dbo.Coupons", "COUP_MFG_ID", c => c.String());
            AddColumn("dbo.Coupons", "COUP_TYPE", c => c.String());
            AddColumn("dbo.Coupons", "COUP_VALUE", c => c.String());
            AddColumn("dbo.Coupons", "COUP_DROPDATE", c => c.String());
            AddColumn("dbo.Coupons", "COUP_ENDDATE", c => c.String());
            AddColumn("dbo.Coupons", "COUP_UPC_FREE", c => c.String());
            AddColumn("dbo.Coupons", "COUP_QTY_FREE", c => c.String());
            AddColumn("dbo.Coupons", "COUP_UPC_ONE", c => c.String());
            AddColumn("dbo.Coupons", "COUP_QTY_ONE", c => c.String());
            AddColumn("dbo.Coupons", "COUP_UPC_TWO", c => c.String());
            AddColumn("dbo.Coupons", "COUP_QTY_TWO", c => c.String());
            AddColumn("dbo.Coupons", "COUP_UPC_THREE", c => c.String());
            AddColumn("dbo.Coupons", "COUP_QTY_THREE", c => c.String());
            DropColumn("dbo.Coupons", "GS1Data");
            DropColumn("dbo.Coupons", "CouponNum");
            DropColumn("dbo.Coupons", "DropDate");
            DropColumn("dbo.Coupons", "Expiration");
            DropColumn("dbo.Coupons", "Value");
            DropColumn("dbo.Coupons", "Quantity");
            DropColumn("dbo.Coupons", "UPC");
            DropColumn("dbo.Coupons", "FreeItem");
            DropColumn("dbo.Coupons", "FreeItem2");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Coupons", "FreeItem2", c => c.String());
            AddColumn("dbo.Coupons", "FreeItem", c => c.String());
            AddColumn("dbo.Coupons", "UPC", c => c.String());
            AddColumn("dbo.Coupons", "Quantity", c => c.Int());
            AddColumn("dbo.Coupons", "Value", c => c.Decimal(precision: 18, scale: 2));
            AddColumn("dbo.Coupons", "Expiration", c => c.DateTime(nullable: false));
            AddColumn("dbo.Coupons", "DropDate", c => c.DateTime(nullable: false));
            AddColumn("dbo.Coupons", "CouponNum", c => c.String());
            AddColumn("dbo.Coupons", "GS1Data", c => c.String());
            DropColumn("dbo.Coupons", "COUP_QTY_THREE");
            DropColumn("dbo.Coupons", "COUP_UPC_THREE");
            DropColumn("dbo.Coupons", "COUP_QTY_TWO");
            DropColumn("dbo.Coupons", "COUP_UPC_TWO");
            DropColumn("dbo.Coupons", "COUP_QTY_ONE");
            DropColumn("dbo.Coupons", "COUP_UPC_ONE");
            DropColumn("dbo.Coupons", "COUP_QTY_FREE");
            DropColumn("dbo.Coupons", "COUP_UPC_FREE");
            DropColumn("dbo.Coupons", "COUP_ENDDATE");
            DropColumn("dbo.Coupons", "COUP_DROPDATE");
            DropColumn("dbo.Coupons", "COUP_VALUE");
            DropColumn("dbo.Coupons", "COUP_TYPE");
            DropColumn("dbo.Coupons", "COUP_MFG_ID");
            DropColumn("dbo.Coupons", "COUP_GS1");
        }
    }
}
