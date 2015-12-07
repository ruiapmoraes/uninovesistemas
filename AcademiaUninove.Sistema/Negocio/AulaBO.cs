using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using AcademiaUninove.Sistema.ADO;

namespace AcademiaUninove.Sistema.Negocio
{
    public class AulaBO
    {
        AulaADO objAulaADO = new AulaADO();

            
        public DataTable ObterAula()
        {
            AulaADO objAulaADO = new AulaADO();

            DataTable dtAula = null; 

            dtAula = objAulaADO.ConsultaAula();

            return dtAula;
        }

        public bool InserirAula(int codigo, string aula)
        {
            bool bRet = false;
            bRet = objAulaADO.InsereAula(codigo, aula);
            return bRet;
        }

        public DataTable ObterAula(int codigo)
        {
            AulaADO objAulaADO = new AulaADO();

            DataTable dtAula = null; ;

            dtAula = objAulaADO.ConsultaAula(codigo);

            return dtAula;
        }

        public bool AtualizaAula(int codigo, string aula)
        {
            bool bRet = false;
            bRet = objAulaADO.AtualizaAula(codigo, aula);
            return bRet;
        }

        public bool ExcluiAula(int codigo)
        {
            bool bRet = false;
            bRet = objAulaADO.ExcluiAula(codigo);
            return bRet;
        }
    }
}
