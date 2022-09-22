using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PycApi
{
    public class Account
    {
        public virtual long Id { get; set; }
        public virtual string Email { get; set; }
        public virtual string Password { get; set; }
        public virtual string Role { get; set; }
        public virtual DateTime LastActivity { get; set; }
    }
}
