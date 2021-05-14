using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace Application.Client.Queries.ClientByDocumentQuery
{
    public class ClientByDocumentQueryRequest : IRequest<IEnumerable<ClientByDocumentQueryResponse>>
    {
        public string Document { get; set; }
    }
}
