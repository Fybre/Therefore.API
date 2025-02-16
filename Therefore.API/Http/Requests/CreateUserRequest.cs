using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Therefore.API.Models;

namespace Therefore.API.Http.Requests
{
    public class CreateUserRequest
    {
        public string Password { get; set; }
        public User User { get; set; }
    }
}
