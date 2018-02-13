using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace bankacademy.Models
{
    public class Clients
    {

        public int Id { get; set; }
        public string Name { get; set; }
        public ClientTypes ClientType { get; set; }

        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString ="{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime? WithdrawnDate { get; set; }

        public decimal? WithdrawnAmt { get; set; }

        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime? DepositDate { get; set; }

        [DataType(DataType.Currency)]
        [DisplayFormat(DataFormatString ="{0:C}", ApplyFormatInEditMode = true)]
        public decimal? DepositAmt { get; set; }
        public string TransactionDesc { get; set; }
        public byte ClientTypeId { get; set; }
        


    }
}