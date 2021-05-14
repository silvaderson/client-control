using Application.Common.Exceptions;
using Application.Common.Interfaces;
using MediatR;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Application.Client.Commands.UpdateClient
{
    class UpdateClientCommandHandler : IRequestHandler<UpdateClientCommandRequest, bool>
    {
        private readonly IClientControlContext _context;

        public UpdateClientCommandHandler(IClientControlContext context)
        {
            _context = context;
        }

        public async Task<bool> Handle(UpdateClientCommandRequest request, CancellationToken cancellationToken)
        {
            var getclient = await _context.Clients.FirstOrDefaultAsync(x => x.Id == request.Id);

            if (getclient == null)
                throw new BadRequestException("Client already exists");

            getclient.UpdateClient(request.FirstName, request.LastName, request.PhoneNumber, request.Email, request.DocumentNumber, request.BirthDate.Value);
            getclient.Address.UpdateAddress(request.Address.PostalCode,request.Address.AddressLine,request.Address.Number,request.Address.Complement,request.Address.Neighborhood,request.Address.City,request.Address.State);

            _context.Clients.Update(getclient);
            await _context.SaveChangesAsync(cancellationToken);

            return true;
        }
    }
}
