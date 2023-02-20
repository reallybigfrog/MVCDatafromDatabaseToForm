using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MVCDemoApp3.Models
{
    public class EmployeeModel
    {
        [Display(Name = "Employee ID"), Required, Range(100000, 999999, ErrorMessage = "Please enter a valid Employee ID")]
        public int EmployeeId { get; set;}
        [Display(Name = "First Name"), Required(ErrorMessage = "You must enter your first name."), MaxLength(100)]
        public string FirstName { get; set; }
        [Display(Name = "Last Name"), Required(ErrorMessage = "You must enter your last name."), MaxLength(100)]
        public string LastName { get; set; }
        [Display(Name = "Email Address"), Required, DataType(DataType.EmailAddress, ErrorMessage = "Please enter a valid email address")]
        public string EmailAddress { get; set; }
        [Display(Name = "Confirm Email Address"), Required, Compare("EmailAddress", ErrorMessage = "Your email address does not match")]
        public string ConfirmEmailAddress { get; set; }
        [Display(Name = "Password"), Required(ErrorMessage = "You must provide a password"), DataType(DataType.Password, ErrorMessage = "You must enter a valid password")]
        public string Password { get; set;}
        [Display(Name = "Confirm Password"), Required(ErrorMessage = "You must confirm your password."), Compare("Password", ErrorMessage = "Your passwords do not match.")]
        public string ConfirmPassword { get; set; }
    }
}