using System.Collections.Generic;

namespace GSAPP.Models
{
    public class UserInformation
    {
        public IEnumerable<User> User { get; set; }
        public IEnumerable<Address> Address { get; set; }
    }
}