using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CsvHelper;
using System.IO;
using System.Text;
using SampleProject1.Models;

namespace SampleProject1.Services
{
    public class CsvParserService
    {

        public List<Claims> ReadCsvFileToClaimsModel(string path)
        {
            try
            {
                using (var reader = new StreamReader(path, Encoding.Default))
                using (var csv = new CsvReader(reader, System.Globalization.CultureInfo.CurrentCulture))
                {
                 //   csv.Configuration.RegisterClassMap<EmployeeMap>();
                    var records = csv.GetRecords<Claims>().ToList();
                    return records;
                }
            }
            catch (UnauthorizedAccessException e)
            {
                throw new Exception(e.Message);
            }
            catch (FieldValidationException e)
            {
                throw new Exception(e.Message);
            }
            catch (CsvHelperException e)
            {
                throw new Exception(e.Message);
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        public List<Member> ReadCsvFileToMemberModel(string path)
        {
            try
            {
                using (var reader = new StreamReader(path, Encoding.Default))
                using (var csv = new CsvReader(reader, System.Globalization.CultureInfo.CurrentCulture))
                {
                    //   csv.Configuration.RegisterClassMap<EmployeeMap>();
                    var records = csv.GetRecords<Member>().ToList();
                    return records;
                }
            }
            catch (UnauthorizedAccessException e)
            {
                throw new Exception(e.Message);
            }
            catch (FieldValidationException e)
            {
                throw new Exception(e.Message);
            }
            catch (CsvHelperException e)
            {
                throw new Exception(e.Message);
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }
    }
}
