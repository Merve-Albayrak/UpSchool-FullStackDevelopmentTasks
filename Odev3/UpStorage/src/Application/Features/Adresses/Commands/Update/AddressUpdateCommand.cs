﻿using Domain.Common;
using Domain.Enums;
using MediatR;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Features.Adresses.Commands.Update
{
    public class AddressUpdateCommand:IRequest<Response<Guid>>
    {

 
        public string? Name { get; set; }


        public Guid Id { get; set; }
        public string? District { get; set; }
      
        public string? PostCode { get; set; }
      
        public string? AddressLine1 { get; set; }
        public string? AddressLine2 { get; set; }

        public AddressType? AddressType { get; set; }
    }
}
