using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using AcademiaUninove.Sistema.Helpers;

namespace AcademiaUninove.Sistema.ADO
{
    public class AulaADO : ADOBase
    {
        string conn = string.Empty;
        ADOBase objConexao = new ADOBase();

        public DataTable ConsultaAula()
        {
            bool bRet = false;
            DataTable dtAula = null;
            string query = AcademiaUninove.Sistema.Queries.Read.QueriesConsulta.qConsultaAula;

            try
            {
                conn = ADOBase.ObterConexao();
                dtAula = RealizaPesquisaSQL(query, conn);

            }
            catch (Exception ex)
            {
                dtAula = null;
                throw ex;
            }

            //TODO ajustar o retorno do método
            return dtAula;
        }

        public bool InsereAula(int codigo, string aula)
        {
            string query = string.Format(AcademiaUninove.Sistema.Queries.Insert.QueriesInsert.qInsertAula, codigo, aula);
            conn = ADOBase.ObterConexao();

            bool bRet = false;


            try
            {
                RealizaComandoSQL(query, conn);
                return true;
            }
            catch (Exception)
            {
                return bRet;
                throw;
            }
        }

        public DataTable ConsultaAula(int codigo)
        {
            bool bRet = false;
            DataTable dtAula = null;
            string query = string.Format( AcademiaUninove.Sistema.Queries.Read.QueriesConsulta.qConsultaAula, codigo);

            try
            {
                conn = ADOBase.ObterConexao();
                dtAula = RealizaPesquisaSQL(query, conn);

            }
            catch (Exception ex)
            {
                dtAula = null;
                throw ex;
            }

            //TODO ajustar o retorno do método
            return dtAula;
        }

        public bool AtualizaAula(int codigo, string aula)
        {
            string query = string.Format(AcademiaUninove.Sistema.Queries.Update.QueriesUpdate.qUpdateAula, aula, codigo);
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

        public bool ExcluiAula(int codigo)
        {
            string query = string.Format(AcademiaUninove.Sistema.Queries.Delete.QueriesDelete.qDeleteAula, codigo);
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
