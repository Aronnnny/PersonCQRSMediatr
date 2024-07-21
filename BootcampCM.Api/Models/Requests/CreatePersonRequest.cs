using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BootcampCM.Api.Models.Requests
{
    public class CreatePersonRequest
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public string TaxId { get; set; }
    }
}
