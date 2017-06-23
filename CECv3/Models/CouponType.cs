using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace CECv3.Models
{
    public class CouponType
    {
        [Key]
        public int Id { get; set; }
        public string CouponTypeName { get; set; }

        public virtual ICollection<Coupons> Coupons { get; set; }
    }
}