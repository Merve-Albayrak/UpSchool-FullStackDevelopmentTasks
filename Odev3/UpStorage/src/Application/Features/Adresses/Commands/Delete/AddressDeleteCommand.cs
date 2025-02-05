﻿using Domain.Common;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Features.Adresses.Commands.Delete
{
    public class AddressDeleteCommand : IRequest<Response<Guid>>
    {
        public Guid Id { get; set; }
    }
}
