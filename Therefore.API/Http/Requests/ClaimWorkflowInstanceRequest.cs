﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Therefore.API.Http.Requests
{
    public class ClaimWorkflowInstanceRequest
    {
        public long InstanceNo { get; set; }
        public long TokenNo { get; set; }
    }
}
