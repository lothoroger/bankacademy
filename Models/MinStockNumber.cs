using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace bankacademy.Models
{
    public class MinStockNumber : ValidationAttribute
    {

        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            var movielist = (Moviemodel)validationContext.ObjectInstance;


            if (movielist.NumberInStock == 0)
                return new ValidationResult("Stock Inventory Required!");

            return (movielist.NumberInStock > 4) ? ValidationResult.Success : new ValidationResult("Stocks should be greater than 5");

        }
    }
}