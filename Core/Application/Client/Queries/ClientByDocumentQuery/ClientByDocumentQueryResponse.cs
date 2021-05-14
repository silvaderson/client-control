using Application.Client.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Application.Client.Queries.ClientByDocumentQuery
{
   public class ClientByDocumentQueryResponse : ClientModel
    {
        public Guid Id { get; set; }
        public DateTime CreatedAt { get; set; }
    }
}
