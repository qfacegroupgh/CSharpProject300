﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

	namespace ContactBook.Models
{
	public class Contact
	{
		public int ContactId { get; set; }
		public string  FirstName { get; set; }
		public string LastName { get; set; }
		public string  OtherName { get; set; }
		public string  PhoneNumber { get; set; }
		public string  Group { get; set; }
	}
}
