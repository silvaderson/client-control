using Application.Client.Models;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace Application.Client.Commands.EditClient
{
    public class EditClientCommandRequest : ClientModel, IRequest<Guid>
    {
    }
}
