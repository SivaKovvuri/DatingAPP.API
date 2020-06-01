using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace DatingApp.API.Dto
{
    public class UserForRegisterDto
    {

        [Required]
        [StringLength(8, MinimumLength = 4, ErrorMessage ="Password must be between 4 and 8 Characters")]
        public string UserName { get; set; }
        public string Password { get; set; }
    }
}
