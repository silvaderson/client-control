using Application.Common.Exceptions;
using Application.Common.Interfaces;
using MediatR;
using System;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace Application.Client.Commands.UpdateClient
{
    public class UpdateClientCommandHandler : IRequestHandler<UpdateClientCommandRequest, Guid>
    {
        private readonly IClientControlContext _context;

        public UpdateClientCommandHandler(IClientControlContext context)
        {
            _context = context;
        }

        public async Task<Guid> Handle(UpdateClientCommandRequest request, CancellationToken cancellationToken)
        {
            var client = _context.Clients.Where(x => x.Id == request.Id).FirstOrDefault();

            if (client == null)
                throw new BadRequestException("Client not found");

            client.UpdateData(request.FirstName, request.LastName, request.PhoneNumber, request.Email, request.DocumentNumber, request.BirthDate);
            client.UpdateAddress(request.Address.PostalCode, request.Address.AddressLine, request.Address.Number, request.Address.Complement, request.Address.Neighborhood, request.Address.City, request.Address.State);

            _context.SetModifiedState(client);
            await _context.SaveChangesAsync(cancellationToken);

            return client.Id;
        }
    }
}
