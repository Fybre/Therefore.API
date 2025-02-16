using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Therefore.API.Http.Requests
{
    public class GetWorkflowProcessRequest
    {
        public long ProcessNo { get; set; }
        public long VersionNo { get; set; }
        public bool LoadTasks { get; set; }
        public bool IsAccessMaskNeeded { get; set; }
    }
}
