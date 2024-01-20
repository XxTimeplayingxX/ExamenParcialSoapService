using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ExamenParcial1.Business_Message
{
    public class ClientesResponse
    {
        public List<Clientes> _Clientes { get; set; }
        public bool ActionResult { get; set; }
        public string Error { get; set; }
    }
}