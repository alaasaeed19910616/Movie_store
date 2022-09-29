using Movie_store.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Movie_store.ViewModels
{
    public class CustomerFormViewModel
    {
        public IEnumerable<MembershipType> MembershipTypes { get; set; }
        public Customer Customer { get; set; }
    }
}