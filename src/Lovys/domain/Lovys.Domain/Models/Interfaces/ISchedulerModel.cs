using Lovys.Domain.Core.Models;
using System.Collections.Generic;

namespace Lovys.Domain.Models.Interfaces
{
    public interface ISchedulerModel : IBaseModel
    {
        string Name { get; set; }
        List<AvailableSlotModel> AvailableSlots { get; set; }
    }
}