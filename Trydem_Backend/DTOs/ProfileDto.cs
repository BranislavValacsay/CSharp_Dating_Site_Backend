using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace UdemyLogin.DTOs
{
    public class ProfileDto
    {
        public string UserName { get; set; }
        public string StageName { get; set; }
        public string Country { get; set; }
    }
}
