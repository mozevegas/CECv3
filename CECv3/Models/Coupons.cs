using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace CECv3.Models
{
    public class Coupons
    {
        public int Id { get; set; }

        public string COUP_GS1 { get; set; }
        public string COUP_MFG_ID { get; set; }
        public string COUP_TYPE { get; set; }
        public string COUP_VALUE { get; set; }
        public string COUP_DROPDATE { get; set; }
        public string COUP_ENDDATE { get; set; }
        public string COUP_UPC_FREE { get; set; }
        public string COUP_QTY_FREE { get; set; }
        public string COUP_UPC_ONE { get; set; }
        public string COUP_QTY_ONE { get; set; }
        public string COUP_UPC_TWO { get; set; }
        public string COUP_QTY_TWO { get; set; }
        public string COUP_UPC_THREE { get; set; }
        public string COUP_QTY_THREE { get; set; }

        // Foreign Key here

        public string UserId { get; set; }
        public ApplicationUser User { get; set; }

        // Coupon Type (Cents off or Free Item)
        public int? CouponTypeId { get; set; }
        [ForeignKey("CouponTypeId")]
        public CouponType CouponType { get; set; }
    }
}