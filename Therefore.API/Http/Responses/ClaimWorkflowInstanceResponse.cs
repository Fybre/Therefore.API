using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Therefore.API.Http.Responses
{
    public class ClaimWorkflowInstanceResponse
    {
        public string ClaimedByUserName { get; set; }
        public bool IsAlreadyClaimed { get; set; }
    }
}
