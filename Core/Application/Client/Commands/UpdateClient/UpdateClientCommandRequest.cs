using Application.Client.Models;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json.Serialization;

namespace Application.Client.Commands.UpdateClient
{
    public class UpdateClientCommandRequest : ClientModel, IRequest<bool>
    {

        [JsonIgnore]
        public Guid Id { get; set; }
    }
}
