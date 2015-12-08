using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using AcademiaUninove.Sistema.ADO;

namespace AcademiaUninove.Sistema.Negocio
{
    public class FuncionarioBO
    {
        //FuncionarioADO objFuncionarioADO = new FuncionarioADO();

        public DataTable ObterFuncionario()
        {
            FuncionarioADO objFuncionario = new FuncionarioADO();

            DataTable dtFuncionario = null;

            dtFuncionario = objFuncionario.ConsultaFuncionario();

            return dtFuncionario;
        }

        public bool ExcluiFunc(int codFunc)
        {
            FuncionarioADO objFuncionarioADO = new FuncionarioADO();
            bool bRet = false;
            bRet = objFuncionarioADO.ExcluiFuncionario(codFunc);
            return bRet;
        }

        public bool InseriFuncionario(int codigo, int cargo, string nome, string endereco, string cidade, string cep, string telres, string telcel)
        {
            FuncionarioADO objFuncionarioADO = new FuncionarioADO();

            bool bRet = false;
            bRet = objFuncionarioADO.InsereFuncionario(codigo, cargo, nome, endereco, cidade, cep, telres, telcel);
            return bRet;
        }

        public DataTable ObterFuncionario(int codigo)
        {
            FuncionarioADO objFuncionarioADO = new FuncionarioADO();

            DataTable dtFuncionario = null; ;

            dtFuncionario = objFuncionarioADO.ConsultaFuncionario(codigo);

            return dtFuncionario;
        }

        public bool AtualizaFuncionario(int codigo, int cargo, string nome, string endereco, string cidade, string cep, string telres, string telcel)
        {
            FuncionarioADO objFuncionarioADO = new FuncionarioADO();

            bool bRet = false;
            bRet = objFuncionarioADO.AtualizaFuncionario(codigo, cargo, nome, endereco, cidade, cep, telres, telcel);
            return bRet;
        }
    }
}
