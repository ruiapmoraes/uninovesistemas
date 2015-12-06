using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UninoveAcademia.Sistemas.Classes
{
    class Login
    {
        public int Codigo { get; set; }
        public string Usuario { get; set; }
        public string Senha { get; set; }
        public string TipoUsuario { get; set; }
        public DateTime DataCriacao { get; set; }
    }
}
