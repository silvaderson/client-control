using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace Application.Client.Queries.ClientByDocumentQuery
{
    public class ClientByDocumentQueryRequest : IRequest<ClientByDocumentQueryResponse>
    {
        public string Document { get; set; }

    }
}

