using Therefore.API.Models;

namespace Therefore.API.Http.Responses
{
    // Root myDeserializedClass = JsonConvert.DeserializeObject<Root>(myJsonResponse);


    public class GetWorkflowProcessResponse
    {
        public WorkflowProcess WorkflowProcess { get; set; }
        public RoleAccessMask? RoleAccessMask { get; set; }
    }


}
