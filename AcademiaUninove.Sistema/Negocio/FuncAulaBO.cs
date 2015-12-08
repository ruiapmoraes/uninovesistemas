using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using AcademiaUninove.Sistema.ADO;

namespace AcademiaUninove.Sistema.Negocio
{
    public class FuncAulaBO
    {
        public DataTable ObterAulaFunc()
        {
            FuncAulaADO objFuncAulaADO = new FuncAulaADO();

            DataTable dtFuncAula = null;

            dtFuncAula = objFuncAulaADO.ConsultaAulaInstrutor();

            return dtFuncAula;
        }

        public DataTable ObterAulaFunc(int codigo)
        {
            FuncAulaADO objFuncAulaADO = new FuncAulaADO();

            DataTable dtFuncAula = null;

            dtFuncAula = objFuncAulaADO.ConsultaAulaInstrutor(codigo);

            return dtFuncAula;
        }

        public bool ExcluirAulaInstrutor(int codigo)
        {
            FuncAulaADO objFuncAulaADO = new FuncAulaADO();
            bool bRet = false;
            bRet = objFuncAulaADO.ExcluiAulaInstrutor(codigo);
            return bRet;
        }

        public bool InserirAulaInstruitor(int codigo, int codigoFunc, int codAula) 
        {
            FuncAulaADO objFuncAulaADO = new FuncAulaADO();

            bool bRet = false;
            bRet = objFuncAulaADO.InsereAulaInstrutor(codigo, codigoFunc, codAula);
            return bRet;
        }

        public bool AtualizaAulaInstrutor(int codigo, int codigoFunc, int codAula)
        {
            FuncAulaADO objFuncAulaADO = new FuncAulaADO();

            bool bRet = false;
            bRet = objFuncAulaADO.AtualizaAulaInstrutor(codigo, codigoFunc, codAula);
            return bRet;
        }
    }
}
