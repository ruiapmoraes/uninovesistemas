using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using AcademiaUninove.Sistema.Helpers;

namespace AcademiaUninove.Sistema.ADO
{

    public class FuncAulaADO : ADOBase
    {
        string conn = string.Empty;
        ADOBase objConexao = new ADOBase();

        public DataTable ConsultaAulaInstrutor() 
        {
            bool bRet = false;
            DataTable dtFuncAula = null;
            string query = AcademiaUninove.Sistema.Queries.Read.QueriesConsulta.qConsultaFuncAula;

            try
            {
                conn = ADOBase.ObterConexao();
                dtFuncAula = RealizaPesquisaSQL(query, conn);
                bRet = true;

            }
            catch (Exception ex)
            {
                bRet = false;
                dtFuncAula = null;
                throw ex;
            }

            //TODO ajustar o retorno do método
            return dtFuncAula;
        }

        public DataTable ConsultaAulaInstrutor(int codigo)
        {
            bool bRet = false;
            DataTable dtFuncAula = null;
            string query = string.Format( AcademiaUninove.Sistema.Queries.Update.QueriesUpdate.qConsultaFuncAulaEdit, codigo);

            try
            {
                conn = ADOBase.ObterConexao();
                dtFuncAula = RealizaPesquisaSQL(query, conn);
                bRet = true;

            }
            catch (Exception ex)
            {
                bRet = false;
                dtFuncAula = null;
                throw ex;
            }

            //TODO ajustar o retorno do método
            return dtFuncAula; 
        }

        public bool InsereAulaInstrutor(int codigo, int codigoFunc, int codAula)
        {
            string query = string.Format(AcademiaUninove.Sistema.Queries.Insert.QueriesInsert.qInsertFuncAula, codigo, codigoFunc, codAula);

            conn = ADOBase.ObterConexao();

           
            try
            {
                RealizaComandoSQL(query, conn);
                return true;
            }
            catch (Exception)
            {
                return false;
                throw;
            }
          
        }

        public bool AtualizaAulaInstrutor(int codigo, int codigoFunc, int codAula)
        {
            string query = string.Format(AcademiaUninove.Sistema.Queries.Update.QueriesUpdate.qUpdateFuncAula, codigo, codigoFunc, codAula);

            conn = ADOBase.ObterConexao();


            try
            {
                RealizaComandoSQL(query, conn);
                return true;
            }
            catch (Exception)
            {
                return false;
                throw;
            }
        }

        public bool ExcluiAulaInstrutor(int codigo)
        {
            string query = string.Format(AcademiaUninove.Sistema.Queries.Delete.QueriesDelete.qDeleteFuncAula, codigo);
            conn = ADOBase.ObterConexao();

            bool bRet = false;
            try
            {
                RealizaComandoSQL(query, conn);
                return true;
            }
            catch (Exception)
            {
                bRet = false;
                throw;
                return bRet;
            }
        }
    }
}
