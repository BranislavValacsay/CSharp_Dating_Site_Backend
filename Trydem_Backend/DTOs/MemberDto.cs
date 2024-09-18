using System;
using Trydem.Models;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Trydem.DTOs
{
    public class MemberDto
    {
        public int Id { get; set; }
        public string UserName { get; set; }
        public int Age { get; set; }
        public string KnownAs { get; set; }
        public DateTime Created { get; set; }
        public DateTime LastActive { get; set; }
        public string Gender { get; set; }
        public string Introduction { get; set; }
        public string LookingFor { get; set; }
        public string Interests { get; set; }
        public string City { get; set; }
        public string Country { get; set; }
        public ICollection<PhotoDto> Photos { get; set; } //one-to-many, one user can have many photos
        public string PhotoUrl { get; set; }
    }
}
