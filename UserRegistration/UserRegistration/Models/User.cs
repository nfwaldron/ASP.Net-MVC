using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace UserRegistration.Models
{

    /* Create a User Registration Form that includes the following form fields:
     * Username - Must be unique in the database.
     * FirstName – Required
     * LastName – Required, Must be more than 5 characters
     * CreditCard – Must be valid credit card number
     * Password – Required, Must be the same as ConfirmPassword
     * ConfirmPassword -- Required
     * Social Security Number – Must be valid social security number format
     * Comments - Must be less than 50 characters.
     * Use StackOverflow for regular expressions.
     */ 

    public class User
    {
        // UserName must be unique to the database.
        // Remote[ Name of action/method you will create in controller, name of the contoller, ErrorMessage, Http Method="Post"
        [Remote("ValidateUsername", "Users", ErrorMessage="This Username has been taken", HttpMethod="Post" )]
        [Required(ErrorMessage = "A username is required")]
        public string UserName { get; set; }
        
        //First Name is required
        [Required(ErrorMessage="First name is required")]
        public string FirstName { get; set; }

        //Last Name is required
        [Required(ErrorMessage="Last name is required")]
        [MinLength(5, ErrorMessage="Your last name must be more than 5 letters. Sorry.")]
        public string LastName { get; set; }

        //Credit card number must be valid
        [Required, CreditCard]
        public string CreditCard { get; set; }

        // Password required
        // Use the Datatype attribute in order to ensure that the password shows up as dots
        [DataType(DataType.Password)]
        [Required(ErrorMessage="Password required")]
        public string Password { get; set; }

        // Confirm password required
        // Use the Datatype attribute in order to ensure that the password shows up as dots
        [DataType(DataType.Password)]

        // Compare Password with COnfirmPassword
        [System.ComponentModel.DataAnnotations.Compare("Password")]
        [Required(ErrorMessage = "Confirm password required")]
        public string ConfirmPassword { get; set; }

        [Required(ErrorMessage="SSN required")]
        [RegularExpression(@"^\d{3}-\d{2}-\d{4}$", ErrorMessage="Please enter SSN with dashes")]
        public string SocialSecurityNumber { get; set; }

        [DataType(DataType.MultilineText)]
        // Make sure that comments cannot exceed 50 characters
        [MaxLength(50, ErrorMessage = "Comments cannot exceed 50 characters")]
        public string Comments { get; set; }
    }
}