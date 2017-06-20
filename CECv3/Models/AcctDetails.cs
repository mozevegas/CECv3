using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CECv3.Models
{
    public class AcctDetails
    {
        public int Id { get; set; }
        public string AccountType { get; set; }
        public string AcctNumber { get; set; }
        public string Name { get; set; }
        public string ShortName { get; set; }
        public string StoreNum { get; set; }
        public string Address1 { get; set; }
        public string Address2 { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public int? ZipCode { get; set; }
        public Decimal? RedemptionFees { get; set; }
        public bool Approval { get; set; } = false;
        public string ContactName { get; set; }
        public string ContactPhone { get; set; }
        public string Email { get; set; }
        public string ACHBankName { get; set; }
        public string ACHRouting { get; set; }
        public string ACHAccount { get; set; }

        public string UserId { get; set; }
        public ApplicationUser User { get; set; }

    }
}