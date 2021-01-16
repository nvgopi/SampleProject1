using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SampleProject1.Models;
using System.IO;
using CsvHelper;
using SampleProject1.Services;

namespace SampleProject1.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ClaimsController : ControllerBase
    {
       

        [HttpGet]
        public IEnumerable<MemberClaimDetails> Get(DateTime dt)
        {
            var csvParserService = new CsvParserService();
            var path = @"C:\\Users\\gopin\\Downloads\\WebAPI-SampleProject\\Claim.csv";
            var path1 = @"C:\\Users\\gopin\\Downloads\\WebAPI-SampleProject\\Member.csv";
            var allClaims = csvParserService.ReadCsvFileToClaimsModel(path);
            var allMembers = csvParserService.ReadCsvFileToMemberModel(path1);
          //  List<Claims> q = allClaims.FindAll(t => t.ClaimDate <= dt.Date);
            var mcDetails = allMembers.Select(s =>
    new MemberClaimDetails
    {
        MemberId = s.MemberId,
        FirstName = s.FirstName,
        LastName = s.LastName,
        EnrollmentDate = s.EnrollmentDate,
        ClaimDetails = allClaims.Where(g => g.MemberId == s.MemberId && g.ClaimDate <= dt.Date).ToArray()
    });

            return mcDetails.ToArray();     // 

        }
    }
}
