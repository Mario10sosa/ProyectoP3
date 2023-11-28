using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class CE_Productos
    { 
        private int _Id_Producto;
        private string _Codigo;
        private string _CodigoBarra;
        private string _Nombre;
        private string _Descripcion;
        private decimal _Costo_Unitario;
        private decimal _Costo_Alquiler;
        private int _Stock;
        private string _Buscar;

        public int Id_Producto { get => _Id_Producto; set => _Id_Producto = value; }
        public string Codigo { get => _Codigo; set => _Codigo = value; }
        public string CodigoBarra { get => _CodigoBarra; set => _CodigoBarra = value; }
        public string Nombre { get => _Nombre; set => _Nombre = value; }
        public string Descripcion { get => _Descripcion; set => _Descripcion = value; }
        public decimal Costo_Unitario { get => _Costo_Unitario; set => _Costo_Unitario = value; }
        public decimal Costo_Alquiler { get => _Costo_Alquiler; set => _Costo_Alquiler = value; }
        public int Stock { get => _Stock; set => _Stock = value; }
        public string Buscar { get => _Buscar; set => _Buscar = value; }
    }
}
