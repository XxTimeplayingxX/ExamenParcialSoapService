using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ExamenParcial1.Business_Message
{
    public class ClientesRequest
    {
        public Clientes _Clientes { get; set; }
        public ClientesRequest()
        {
            _Clientes = new Clientes();
        }
    }
}