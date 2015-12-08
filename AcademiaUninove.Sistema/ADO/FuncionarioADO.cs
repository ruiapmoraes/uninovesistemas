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
    public class FuncionarioADO : ADOBase
    {
        string conn = string.Empty;
        ADOBase objConexao = new ADOBase();


        public DataTable ConsultaFuncionario()
        {
            bool bRet = false;
            DataTable dtFuncionario = null;
            string query = AcademiaUninove.Sistema.Queries.Read.QueriesConsulta.qConsultaFuncionario;

            try
            {
                conn = ADOBase.ObterConexao();
                dtFuncionario = RealizaPesquisaSQL(query, conn);
                bRet = true;

            }
            catch (Exception ex)
            {
                bRet = false;
                dtFuncionario = null;
                throw ex;
            }

            //TODO ajustar o retorno do método
            return dtFuncionario;
        }

        public bool ExcluiFuncionario(int codigo)
        {
            string query = string.Format(AcademiaUninove.Sistema.Queries.Delete.QueriesDelete.qDeleteFuncionario, codigo);
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

        public bool InsereFuncionario(int codigo, int cargo, string nome, string endereco, string cidade, string cep, string telres, string telcel)
        {
            string query = string.Format(AcademiaUninove.Sistema.Queries.Insert.QueriesInsert.qInsertFuncionario, codigo, cargo,nome,
                                                    endereco,cidade, cep, telres, telcel);
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

        public DataTable ConsultaFuncionario(int codigo)
        {
            bool bRet = false;
            DataTable dtFuncionario = null;
            string query = string.Format(AcademiaUninove.Sistema.Queries.Update.QueriesUpdate.qConsultaFuncionarioEdit, codigo);

            try
            {
                conn = ADOBase.ObterConexao();
                dtFuncionario = RealizaPesquisaSQL(query, conn);

            }
            catch (Exception ex)
            {
                dtFuncionario = null;
                throw ex;
            }

            //TODO ajustar o retorno do método
            return dtFuncionario;
        }

        public bool AtualizaFuncionario(int codigo, int cargo, string nome, string endereco, string cidade, string cep, string telres, string telcel)
        {
            string query = string.Format(AcademiaUninove.Sistema.Queries.Update.QueriesUpdate.qUpdateFuncionario, codigo, cargo,nome,
                                                    endereco, cidade, cep, telres, telcel);
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
                //throw;
                return bRet;
            }
        }
    }
}
