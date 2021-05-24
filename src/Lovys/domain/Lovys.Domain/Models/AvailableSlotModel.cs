using Lovys.Domain.Core.Models;
using Lovys.Domain.Models.Interfaces;
using Lovys.Domain.Web.Common;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System;

namespace Lovys.Domain.Models
{
    public partial class AvailableSlotModel : BaseModel, IAvailableSlotModel
    {
        [JsonConverter(typeof(StringEnumConverter))]
        public DayOfWeek DayOfWeek { get; set; }

        [JsonConverter(typeof(StringEnumConverter))]
        public TimeInterval Begin { get; set; }

        [JsonConverter(typeof(StringEnumConverter))]
        public TimeInterval End { get; set; }
    }
}