using Lovys.Domain.Core.Models;
using Lovys.Domain.Models.Interfaces;
using System.Collections.Generic;

namespace Lovys.Domain.Models
{
    public partial class InterviewerModel : BaseModel, IInterviewerModel
    {
        public string Name { get; set; }
        public List<IAvailableSlotModel> AvailableSlots { get; set; }
    }
}