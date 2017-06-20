using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CECv3.Models
{
    public class Coupons
    {
        public int Id { get; set; }

        public string GS1Data { get; set; }
        public string CouponNum { get; set; }
        public DateTime DropDate { get; set; }
        public DateTime Expiration { get; set; }

        // Cents Off
        public Decimal? Value { get; set; }
        public int? Quantity { get; set; }
        public string UPC { get; set; }

        // Free Item
        public string FreeItem { get; set; }
        public string FreeItem2 { get; set; }

        // Foreign Key here

        public string UserId { get; set; }
        public ApplicationUser User { get; set; }

        // Coupon Type (Cents off or Free Item)
        //public int CouponTypeId { get; set; }
        //public CouponType CouponType { get; set; }
    }
}