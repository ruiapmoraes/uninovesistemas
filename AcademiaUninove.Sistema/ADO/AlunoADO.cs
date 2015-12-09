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
    public class AlunoADO : ADOBase
    {
        #region Variáveis globais
        string conn = string.Empty;
        ADOBase objConexao = new ADOBase();
        #endregion

        public DataTable ConsultarAluno(out bool sucesso)
        {
            bool bRet = false;
            DataTable dtAluno = null;
            string query = AcademiaUninove.Sistema.Queries.Read.QueriesConsulta.qConsultaAluno;

            try
            {
                conn = ADOBase.ObterConexao();
                dtAluno = RealizaPesquisaSQL(query, conn);
                if (dtAluno.Rows.Count <= 0 || dtAluno == null)
                {
                    sucesso = false;
                    bRet = false;
                }
                else
                {
                    sucesso = true;
                    bRet = true;
                }

            }
            catch (Exception ex)
            {
                sucesso = false;
                bRet = false;
                dtAluno = null;
                throw ex;
            }

            //TODO ajustar o retorno do método
            return dtAluno;
        }

        public bool InserirAluno(int codigo, int codFunc, string nomeAluno, string cpf, string rg, DateTime dtNasc, string telRes, string telCel, string endereco, string cidade, string cep, string statusAluno, string restricao, string objetivo)
        {
            string query = string.Format(AcademiaUninove.Sistema.Queries.Insert.QueriesInsert.qInsertAluno
                                                , codigo
                                                , codFunc
                                                , nomeAluno
                                                , cpf
                                                , rg
                                                , dtNasc.ToString("yyyy/MM/dd")
                                                , telRes
                                                , telCel
                                                , endereco
                                                , cidade
                                                , cep
                                                , statusAluno
                                                , restricao
                                                , objetivo);
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

        public bool AtualizaAluno(int codigo, int codFunc, string nomeAluno, string cpf, string rg, DateTime dtNasc, string telRes, string telCel, string endereco, string cidade, string cep, string statusAluno, string restricao, string objetivo)
        {
            string query = string.Format(AcademiaUninove.Sistema.Queries.Update.QueriesUpdate.qUpdateAluno
                                                , codigo
                                                , codFunc
                                                , nomeAluno
                                                , cpf
                                                , rg
                                                , dtNasc
                                                , telRes
                                                , telCel
                                                , endereco
                                                , cidade
                                                , cep
                                                , statusAluno
                                                , restricao
                                                , objetivo);
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

        public DataTable ConsultarAluno(int codigo)
        {
            bool bRet = false;
            DataTable dtAluno = null;
            string query = string.Format( AcademiaUninove.Sistema.Queries.Update.QueriesUpdate.qConsultaAulaEdit,codigo);

            try
            {
                conn = ADOBase.ObterConexao();
                dtAluno = RealizaPesquisaSQL(query, conn);
                if (dtAluno.Rows.Count <= 0 || dtAluno == null)
                {
                  
                    bRet = false;
                }
                else
                {
                    
                    bRet = true;
                }

            }
            catch (Exception ex)
            {
              
                bRet = false;
                dtAluno = null;
                throw ex;
            }

            //TODO ajustar o retorno do método
            return dtAluno;
        }
    }
}
