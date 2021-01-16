using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SampleProject1.Models
{
    public class MemberClaimDetails
    {
        public int MemberId { get; set; }

        public DateTime EnrollmentDate { get; set; }

        public string FirstName { get; set; }
        public string LastName { get; set; }

        public Claims[] ClaimDetails { get; set; }
}
}
