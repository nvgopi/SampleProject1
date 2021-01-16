using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SampleProject1.Models
{
    public class Claims
    {
        [CsvHelper.Configuration.Attributes.Name("MemberID")]
        public int MemberId { get; set; }
        [CsvHelper.Configuration.Attributes.Name("ClaimDate")]
        public DateTime ClaimDate { get; set; }
        [CsvHelper.Configuration.Attributes.Name("ClaimAmount")]
        public decimal ClaimAmount { get; set; }
       
       
    }
}
