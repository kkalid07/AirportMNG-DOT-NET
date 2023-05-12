using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AM.ApplicationCore.Domain
{
    //[Owned]
    public class FullName
    {
        [MinLength(3, ErrorMessage = "invalide min length")]
        [MaxLength(25, ErrorMessage = "invalide max length")]
        public string FirstName { get; set; }
        
        public string LastName { get; set; }
    }
}
