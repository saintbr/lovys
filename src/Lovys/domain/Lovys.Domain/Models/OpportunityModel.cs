using Lovys.Domain.Core.Models;
using System;

namespace Lovys.Domain.Models
{
    public class OpportunityModel : BaseModel
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public string Department { get; set; }
        public DateTime ValidUntil { get; set; }
    }
}