﻿using Domain.Entities;
using Domain.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Features.Adresses.Queries.GetAll
{
    public class AddressGetAllDto
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string UserId { get; set; }
        public int CountryId { get; set; }
      

        public int CityId { get; set; }
       

        public string District { get; set; }
        public string PostCode { get; set; }

        public string AddressLine1 { get; set; }
        public string? AddressLine2 { get; set; }
        public bool IsDeleted { get; set; }
        public AddressType AddressType { get; set; }
    }
}
