using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace SportApp.Models
{
    public class Client
    {
       [Key]
        public int CltId { get; set; }
        public string Image { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public string Sport { get; set; }
        public DateTime Date_entrer { get; set; }
        public int Prix { get; set; }
        public bool Sexe { get; set; }
        public int CoachId { get; set; }

        public virtual Coach Coach { get; set; }
    }
}