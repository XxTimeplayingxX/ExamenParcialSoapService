using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ExamenParcial1.Business_Message
{
    public class Clientes
    {
        public string  NumeroDeCuenta { get; set; }
        public string Nombre { get; set; }
        public TipoDeCuenta TipoCuenta { get; set; }
        public long Saldo { get; set; }
    }
    public enum TipoDeCuenta
    {
        Corriente,
        Ahorros,
        Crédito
    }
}