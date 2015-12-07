using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace AcademiaUninove.Sistema.Helpers
{
    public class Validacao
    {
        /// <summary>
        /// Campos Preenchidos
        /// </summary>
        /// <param name="campo">Campo</param>
        /// <returns>Retorna se o campo está nulo</returns>
        public bool CamposPreechidos(string campo)
        {
            if (!string.IsNullOrEmpty(campo))
            {
                return false;
            }
            else
                return true;
        }

        public int ConvertInteiro(string numero)
        {
            throw new NotImplementedException();
        }

        internal bool NumeroPreenchido(int codigo)
        {
            if (codigo < 0 || codigo == null)
            {
                return false;
            }
            else
                return true;
        }
    }
}
