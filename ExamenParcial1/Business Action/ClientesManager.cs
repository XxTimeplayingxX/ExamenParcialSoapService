using ExamenParcial1.Business_Message;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ExamenParcial1.Business_Action
{
    public class ClientesManager
    {
        public static ClientesResponse GetAllPlayers()
        {
            Random random = new Random();
            var clientes = new List<Clientes>() { new Clientes()
            {
                NumeroDeCuenta = Convert.ToString(random.Next(10000000, 99999999)),
                Nombre = "David Sánchez",
                TipoCuenta = TipoDeCuenta.Crédito,
                Saldo = 500
            },
            new Clientes()
            {
                NumeroDeCuenta = Convert.ToString(random.Next(10000000, 99999999)),
                Nombre = "Daniel Olivo",
                TipoCuenta = TipoDeCuenta.Corriente,
                Saldo = 600
            },
            new Clientes()
            {
                NumeroDeCuenta = Convert.ToString(random.Next(10000000, 99999999)),
                Nombre = "Edwin Falconez",
                TipoCuenta = TipoDeCuenta.Ahorros,
                Saldo = 800
            },
            new Clientes()
            {
                NumeroDeCuenta = Convert.ToString(random.Next(10000000, 99999999)),
                Nombre = "Carlos Dimitrakis",
                TipoCuenta = TipoDeCuenta.Corriente,
                Saldo =300
            }
            };
            return new ClientesResponse()
            {
                _Clientes = clientes,
                ActionResult = true
            };
        }
    }
}