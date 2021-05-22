using Lovys.Domain.Core.Models;
using System.Collections.Generic;

namespace Lovys.Domain.Models.Interfaces
{
    public interface IInterviewerModel : IBaseModel
    {
        string Name { get; set; }
        List<IAvailableSlotModel> AvailableSlots { get; set; }
    }
}