using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Aplikacija1.Models;

namespace Aplikacija1.ViewModels
{
    public class CustomerFormViewModel
    {
        public IEnumerable<MembershipType> MembershipTypes { get; set; }
        public Customer Customer { get; set; }
    }
}