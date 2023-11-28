using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class CE_Clientes
    {
        private int _Id_Cliente;
        private string _Cedula;
        private string _Nombre;
        private string _Apellido;
        private string _Telefono;
        private string _Direccion;
        private string _Buscar;

        public int Id_Cliente { get => _Id_Cliente; set => _Id_Cliente = value; }
        public string Cedula { get => _Cedula; set => _Cedula = value; }
        public string Nombre { get => _Nombre; set => _Nombre = value; }
        public string Apellido { get => _Apellido; set => _Apellido = value; }
        public string Telefono { get => _Telefono; set => _Telefono = value; }
        public string Direccion { get => _Direccion; set => _Direccion = value; }
        public string Buscar { get => _Buscar; set => _Buscar = value; }
    }
}
