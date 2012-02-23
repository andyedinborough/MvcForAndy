using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Globalization;
using System.Web.Mvc;
using System.Web.Security;

namespace MvcForAndy.Models
{
    public class Registration : IValidatableObject
    {
        public int RegistrationId { get; set; }

        [Required(ErrorMessage = "Please enter a valid e-mail address.")]
        [RegularExpression("^[a-zA-Z0-9!#$%&'*+/=?^_`{|}~-]+(?:\\.[a-zA-Z0-9!#$%&'*+/=?^_`{|}~-]+)*@(?:[a-zA-Z0-9](?:[a-zA-Z0-9-]*[a-zA-Z0-9])?\\.)+[a-zA-Z0-9](?:[a-zA-Z0-9-]*[a-zA-Z0-9])?$", ErrorMessage = "Invalid e-mail address.")]
        [DataType(DataType.EmailAddress)]
        [Display(Name = "Get your life on Tracky by entering your e-mail address:")]
        public string Email { get; set; }

        #region IValidatableObject Members

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        {
            if (Email == "email@address.com")
            {
                yield return new ValidationResult("Please enter a valid e-mail address.", new string[] { "Email" });
            }
        }

        #endregion
    }
}