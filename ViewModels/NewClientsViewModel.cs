using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using bankacademy.Models;

namespace bankacademy.ViewModels
{
    public class NewClientsViewModel
    {
        
       public Customermodel custmodel { get; set; }
        public MembershipTypes membertypemodel { get; set; }
    }
}