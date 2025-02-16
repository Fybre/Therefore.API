using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Therefore.API.Http.Requests
{
    public class ExecuteSingleQueryRequest
    {
        public long CategoryNo { get; set; }
        public string Condition { get; set; }
        public long FieldNo { get; set; }
        public long OrderByFieldNo { get; set; }
    }
}
