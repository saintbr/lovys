namespace Lovys.Domain.Web.Response
{
    public partial class AvailabilityResponse
    {
        public string Interviewer { get; set; }
        public AvailabilitySlot[] AvailabilityIntervals { get; set; }
    }
}