using Therefore.API.Models;

namespace Therefore.API.Http.Requests
{
    public class FinishCurrentWorkflowTaskRequest
    {
        public long InstanceNo { get; set; }
        public long NextTaskNo { get; set; }
        public string TextInformation { get; set; }
        public long TokenNo { get; set; }
        public NextUsers NextUsers { get; set; }
    }
}
