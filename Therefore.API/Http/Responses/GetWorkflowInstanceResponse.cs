using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Therefore.API.Models;

namespace Therefore.API.Http.Responses
{

    public class GetWorkflowInstanceResponse
    {
        public List<ChecklistItem> ChecklistItems { get; set; }
        public List<HistoryEntry>? HistoryEntries { get; set; }
        public List<LinkedDocument> LinkedDocuments { get; set; }
        public List<NextTask> NextTasks { get; set; }
        public List<Transition> Transitions { get; set; }
        public WorkflowInstance WorkflowInstance { get; set; }
        public WFProcessRoleAccessMask? WFProcessRoleAccessMask { get; set; }
    }


}
