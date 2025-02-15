using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Therefore.API.Http.Responses
{
    public class CreateDocumentResponse
    {
        public long DocNo { get; set; }
        public DateTime LastChangeTime { get; set; }
        public long VersionNo { get; set; }
        public string LastChangeTimeISO8601 { get; set; }
    }
}
