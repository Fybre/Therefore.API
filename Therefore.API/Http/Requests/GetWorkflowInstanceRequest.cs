using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Therefore.API.Http.Requests
{
    public class GetWorkflowInstanceRequest
    {
        public long InstanceNo { get; set; }
        public long TokenNo { get; set; }
        public bool IsAccessMaskNeeded { get; set; }
        public bool LoadHistory { get; set; }
    }
}
