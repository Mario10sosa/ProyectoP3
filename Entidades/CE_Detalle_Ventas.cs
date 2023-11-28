using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class CE_Detalle_Ventas
    {
        private int _Id_Detalle;
        private int _Id_Venta;
        private int _Id_Producto;
        private int _Cantidad;
        private decimal _Precio_venta;
        private decimal _Sub_Total;
        private decimal _Monto_Total;

        public int Id_Detalle { get => _Id_Detalle; set => _Id_Detalle = value; }
        public int Id_Venta { get => _Id_Venta; set => _Id_Venta = value; }
        public int Id_Producto { get => _Id_Producto; set => _Id_Producto = value; }
        public int Cantidad { get => _Cantidad; set => _Cantidad = value; }
        public decimal Precio_venta { get => _Precio_venta; set => _Precio_venta = value; }
        public decimal Sub_Total { get => _Sub_Total; set => _Sub_Total = value; }
        public decimal Monto_Total { get => _Monto_Total; set => _Monto_Total = value; }
    }
}
