using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class CE_Empresa
    {
        private int _Id_Empresa;
        private string _Nit;
        private string _Nombre;
        private string _Telefono;
        private string _Direccion;
        private string _Correo;
        private string _Buscar;

        public int Id_Empresa { get => _Id_Empresa; set => _Id_Empresa = value; }
        public string Nit { get => _Nit; set => _Nit = value; }
        public string Nombre { get => _Nombre; set => _Nombre = value; }
        public string Telefono { get => _Telefono; set => _Telefono = value; }
        public string Direccion { get => _Direccion; set => _Direccion = value; }
        public string Correo { get => _Correo; set => _Correo = value; }
        public string Buscar { get => _Buscar; set => _Buscar = value; }
    }
}
