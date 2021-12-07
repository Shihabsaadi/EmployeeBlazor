using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AuthBlazor.Data
{
    public class AspNetUsers:IdentityUser
    {
        public string School { get; set; }
    }
}
