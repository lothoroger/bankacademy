using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace bankacademy.Models
{
    public class ClientTypes
    {
        public int Id { get; set; }
        public string Name { get; set; }
     
        public Boolean? MemberExpire { get; set; }
        public DateTime? SetupDate { get; set; }

        [RegularExpression(@"^\$?\d+(\.(\d{2}))?$")]
        public decimal? InitialAmt { get; set; }



    }
}