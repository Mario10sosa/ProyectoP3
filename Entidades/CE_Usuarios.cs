using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class CE_Usuarios
    {
        private int _Id_Usuario;
        private string _Nombre;
        private string _Apellido;
        private string _Usuario;
        private string _Password;
        private string _Buscar;

        public int Id_Usuario { get => _Id_Usuario; set => _Id_Usuario = value; }
        public string Nombre { get => _Nombre; set => _Nombre = value; }
        public string Apellido { get => _Apellido; set => _Apellido = value; }
        public string Usuario { get => _Usuario; set => _Usuario = value; }
        public string Password { get => _Password; set => _Password = value; }
        public string Buscar { get => _Buscar; set => _Buscar = value; }
    }
}
