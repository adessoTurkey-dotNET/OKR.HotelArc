﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelAdesso.Application.Dto
{
    public class GuestDto : BaseEntityDto
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Address { get; set; }
        public string Address2 { get; set; }
        public string City { get; set; }
        public string ZipCode { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }
        public string Gender { get; set; }
        public double MinBudget { get; set; }
        public double MaxBudget { get; set; }
    }
}
