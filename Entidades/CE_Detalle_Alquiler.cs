using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class CE_Detalle_Alquiler
    {
        private int _Id_Detalle_A;
        private int _Id_Alquiler;
        private int _Id_Producto;
        private int _Duracion;
        private decimal _Precio_Alquiler;
        private decimal _Monto_Total;

        public int Id_Detalle_A { get => _Id_Detalle_A; set => _Id_Detalle_A = value; }
        public int Id_Alquiler { get => _Id_Alquiler; set => _Id_Alquiler = value; }
        public int Id_Producto { get => _Id_Producto; set => _Id_Producto = value; }
        public int Duracion { get => _Duracion; set => _Duracion = value; }
        public decimal Precio_Alquiler { get => _Precio_Alquiler; set => _Precio_Alquiler = value; }
        public decimal Monto_Total { get => _Monto_Total; set => _Monto_Total = value; }
    }
}
