using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Movie_store.Models
{
    public class MembershipType
    {
        public byte Id { get; set; }
        public short SignUpFee { get; set; }
        public byte DurationInMonths { get; set; }
        public byte DiscountRate { get; set; }
        [StringLength(255)]
        public string Name { get; set; }

        // Defining these two Id's because they are used in validation
        public static readonly byte Unkown = 0;
        public static readonly byte PayAsYouGo = 0;
    }
}