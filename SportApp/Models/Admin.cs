using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace SportApp.Models
{
    public class Admin
    {
     
        public int AdminId { get; set; }
        
        public string Login { get; set; }
        public string Password { get; set; }

        public virtual List<Coach> Coaches { get; set; }
    }
}