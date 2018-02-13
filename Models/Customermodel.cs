using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace bankacademy.Models
{
    public class Customermodel
    {
        public int Id { get; set;}

        [Required]
        [StringLength(100)]
        public string Name { get; set; }
        public bool IsSubscribedToNewsletter { get; set; }

        public DateTime? Birthdate { get; set; }

        [Display(Name = "Membership Type")]
        public MembershipTypes MembershipType { get; set; }
        public byte MembershipTypeID { get; set; }

    }
}