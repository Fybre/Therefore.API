using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Therefore.API.Models
{
    public class User
    {
        public string Description { get; set; }
        public string DisplayName { get; set; }
        public string DomainName { get; set; }
        public string InFolder { get; set; }
        public string SMTP { get; set; }
        public string UserName { get; set; }
        public int UserType { get; set; }
        public bool Disabled { get; set; }
        public bool OneTimePwd { get; set; }
    }
}
