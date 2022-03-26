using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos.Entidades
{
    public class Pedidos
    {
        public int Id { get; set; }
        public int IdentidadCliente { get; set; }
        public int Cliente { get; set; }
        public DateTime Fecha { get; set; }
        public decimal SubTotal { get; set; }
        public decimal ISV { get; set; }
        public decimal Total { get; set; }

        public Pedidos()
        {
        }

        public Pedidos(int id, int identidadCliente, int cliente, DateTime fecha, decimal subTotal, decimal iSV, decimal total)
        {
            Id = id;
            IdentidadCliente = identidadCliente;
            Cliente = cliente;
            Fecha = fecha;
            SubTotal = subTotal;
            ISV = iSV;
            Total = total;
        }
    }
}
