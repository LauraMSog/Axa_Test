using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApi.Models
{
    public class ClientModel
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public bool Email { get; set; }
        public bool Role { get; set; }
    }
}
