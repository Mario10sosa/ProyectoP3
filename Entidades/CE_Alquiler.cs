using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class CE_Alquiler
    {

        private int _Id_Alquiler;
        private int _Id_Cliente;
        private string _No_Factura;
        private DateTime _Fecha_Alquiler;
        private DateTime _Fecha_Validez;
        private decimal _Monto_Total;
        private string _Metodo_Pago;
        private string _Estado;
        private string _Buscar;

        public int Id_Alquiler { get => _Id_Alquiler; set => _Id_Alquiler = value; }
        public int Id_Cliente { get => _Id_Cliente; set => _Id_Cliente = value; }
        public string No_Factura { get => _No_Factura; set => _No_Factura = value; }
        public DateTime Fecha_Alquiler { get => _Fecha_Alquiler; set => _Fecha_Alquiler = value; }
        public DateTime Fecha_Validez { get => _Fecha_Validez; set => _Fecha_Validez = value; }
        public decimal Monto_Total { get => _Monto_Total; set => _Monto_Total = value; }
        public string Metodo_Pago { get => _Metodo_Pago; set => _Metodo_Pago = value; }
        public string Estado { get => _Estado; set => _Estado = value; }
        public string Buscar { get => _Buscar; set => _Buscar = value; }
        
    }
}
