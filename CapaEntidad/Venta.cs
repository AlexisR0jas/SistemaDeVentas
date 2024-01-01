﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class Venta
    {
        public int IdVenta{ get; set; }
        public Usuario Usuario{ get; set; }
        public string TipoDocumento{ get; set; }
        public string NumeroDocumento{ get; set; }
        public string DocumentoCliente{ get; set; }
        public string NombreCliente{ get; set; }
        public decimal MontoPago{ get; set; }
        public decimal MontoCambio{ get; set; }
        public decimal MontoTotal{ get; set; }
        public List<DetalleVenta> DetalleVenta { get; set; }
        public string FechaRegistro{ get; set; }
    }
}
