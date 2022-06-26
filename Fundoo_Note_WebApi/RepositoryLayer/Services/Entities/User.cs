using System;
using System.Collections.Generic;
using System.Text;

namespace RepositoryLayer.Services.Entities
{
    public class User
    {
        [key]
        public int UserId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }   
        public string Email { get; set; }   
        public string Password { get; set; }
        public DateTime CreatedDateTime { get; set; }
        public DateTime ModifiedDateTime { get; set; }

    }
}
