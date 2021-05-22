using Lovys.Domain.Core.Models;
using Lovys.Domain.Models.Interfaces;

namespace Lovys.Domain.Models
{
    public partial class CandidateModel : BaseModel, ICandidateModel
    {
        public string Name { get; set; }
    }
}