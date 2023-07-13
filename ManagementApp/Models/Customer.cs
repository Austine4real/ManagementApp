using System.Collections.Generic;
using System;
using System.ComponentModel.DataAnnotations;

namespace ManagementApp.Models
{
	public class Customer
	{
		
		[ScaffoldColumn(false)]
		public Guid Id { get; set; }
		[Required(ErrorMessage = "FirstName is required")]
		public string FirstName { get; set; }
		[Required(ErrorMessage = "LastName is required")]
		public string LastName { get; set; }
		[Required(ErrorMessage = "Email is required")]
		[EmailAddress(ErrorMessage = "Invalid email address")]
		public string EmailAddress { get; set; }
		[Required(ErrorMessage = "Password is required")]
		[DataType(DataType.Password)]
		[RegularExpression(@"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d)(?=.*\W).{8,}$", ErrorMessage = "least 8 characters")]
		public string Password { get; set; }

		[Display(Name = "Confirm password")]
		[Required(ErrorMessage = "Confirm password is required")]
		[DataType(DataType.Password)]
		[Compare("Password", ErrorMessage = "Passwords do not match")]
		public string ConfirmPassword { get; set; }

		[ScaffoldColumn(false)]
		public List<Order> Orders { get; set; }
	}
}

