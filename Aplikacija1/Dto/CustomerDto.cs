using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using Aplikacija1.Models;

namespace Aplikacija1.Dto
{
    public class CustomerDto
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Please enter customer's name.")]
        [StringLength(255)]
        public string Name { get; set; }

        public bool isSubscribedToNewsletter { get; set; }

        //[Min18YearsIfAMember]
        public DateTime? Birthdate { get; set; }

        public byte MembershipTypeId { get; set; }
    }
}