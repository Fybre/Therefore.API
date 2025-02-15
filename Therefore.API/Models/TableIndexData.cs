using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Therefore.API.Models
{

    public class TableIndexData
    {
        public long FieldNo { get; set; }
        public List<DataValue> DataValue { get; set; }
        public string FieldName { get; set; }
    }


}
