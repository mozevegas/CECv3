namespace CECv3.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddedCouponType : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.CouponTypes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        CouponTypeName = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            AddColumn("dbo.Coupons", "CouponTypeId", c => c.Int());
            CreateIndex("dbo.Coupons", "CouponTypeId");
            AddForeignKey("dbo.Coupons", "CouponTypeId", "dbo.CouponTypes", "Id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Coupons", "CouponTypeId", "dbo.CouponTypes");
            DropIndex("dbo.Coupons", new[] { "CouponTypeId" });
            DropColumn("dbo.Coupons", "CouponTypeId");
            DropTable("dbo.CouponTypes");
        }
    }
}
