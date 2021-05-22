using Lovys.Domain.Core.Models;

namespace Lovys.Domain.Models.Interfaces
{
    public interface ICandidateModel : IBaseModel
    {
        string Name { get; set; }
    }
}