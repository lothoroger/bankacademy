using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using bankacademy.Models;

namespace bankacademy.ViewModels
{
    public class NewCustomerViewModel
    {
        public IEnumerable<MembershipTypes> MemberListType { get; set; }
        public Customermodel customermodellist { get; set; }

    }
}