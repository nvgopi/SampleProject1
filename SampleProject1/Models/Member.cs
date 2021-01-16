using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SampleProject1.Models
{
    public class Member
    {
        [CsvHelper.Configuration.Attributes.Name("MemberID")]
        public int MemberId { get; set; }
        [CsvHelper.Configuration.Attributes.Name("EnrollmentDate")]
        public DateTime EnrollmentDate { get; set; }
        [CsvHelper.Configuration.Attributes.Name("FirstName")]
        public string FirstName { get; set; }
        [CsvHelper.Configuration.Attributes.Name("LastName")]
        public string LastName { get; set; }
    }
}
