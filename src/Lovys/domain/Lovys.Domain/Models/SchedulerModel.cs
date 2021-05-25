using Lovys.Domain.Core.Models;
using Lovys.Domain.Models.Interfaces;
using System.Collections.Generic;

namespace Lovys.Domain.Models
{
    public partial class SchedulerModel : BaseModel, ISchedulerModel
    {
        public string Name { get; set; }
        public List<AvailableSlotModel> AvailableSlots { get; set; }
    }
}