using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ProductsValidation.Models
{
    public class DescriptionAttribute : ValidationAttribute
    {
        
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            var product = (Product)validationContext.ObjectInstance;
            string val = (string)value;
            if (val == null) return ValidationResult.Success;
            if (!val.StartsWith(product.Name) || val.Length == product.Name.Length)
            {
                return new ValidationResult(GetError());
            }
            return ValidationResult.Success;
        }
        public string GetError()
        {
            return "Error, product description should starts with the product name and not be equal to that";
        }      
    }
}
