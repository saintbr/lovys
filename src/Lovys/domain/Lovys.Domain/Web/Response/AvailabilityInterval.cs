using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System;

namespace Lovys.Domain.Web.Response
{
    public partial class AvailabilityInterval
    {
        [JsonConverter(typeof(StringEnumConverter))]
        public DayOfWeek DayOfWeek { get; set; }
        public DateTime Begin { get; set; }
        public DateTime End { get; set; }
        public string Range { get; set; }
    }
}