using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace SportApp.Models
{
    public class Coach
    {
        
        public int CoachId{ get; set; }
        public string Name { get; set; }
        public string Sport { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }
        public int AdminId { get; set; }

        public virtual Admin Admin { get; set; }
        public virtual List<Client> Clients { get; set; }
    }
}