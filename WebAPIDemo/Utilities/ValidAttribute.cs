using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebAPIDemo.Utilities
{
    public class ValidAttribute : ValidationAttribute
    {
        public override bool IsValid(object value)
        {
            return base.IsValid(value);
        }
    }
}