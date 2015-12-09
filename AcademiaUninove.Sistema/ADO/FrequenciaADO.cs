using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using AcademiaUninove.Sistema.Helpers;

namespace AcademiaUninove.Sistema.ADO
{
    public class FrequenciaADO :ADOBase
    {
        #region Variáveis Globais
        string conn = string.Empty;
        ADOBase objConexao = new ADOBase(); 
        #endregion

        public DataTable ConsultaFrequencia()
        {
            DataTable dtFrequencia = null;
            string query = AcademiaUninove.Sistema.Queries.Read.QueriesConsulta.qConsultaFrequencia;
            bool bRet = false;

            try
            {
                conn = ADOBase.ObterConexao();
                dtFrequencia = RealizaPesquisaSQL(query, conn);
                bRet = true;
            }
            catch (Exception)
            {
                bRet = false;
                throw;

            }
            return dtFrequencia;
        }

        public DataTable ConsultaFrequencia(int codigo)
        {
            bool bRet = false;
            DataTable dtFrequencia = null;
            string query = string.Format( AcademiaUninove.Sistema.Queries.Read.QueriesConsulta.qConsultaFrequencia, codigo);

            try
            {
                conn = ADOBase.ObterConexao();
                dtFrequencia = RealizaPesquisaSQL(query, conn);
                bRet = true;
            }
            catch (Exception)
            {
                bRet = false;
                throw;

            }
            return dtFrequencia;

        }

        public bool InsereFrequencia(int codigo, int codAluno, DateTime dataHora)
        {
            string query = string.Format(AcademiaUninove.Sistema.Queries.Insert.QueriesInsert.qInsertFrequencia,
                                        codigo,
                                        codAluno,
                                        dataHora);
            try
            {
                conn = ObterConexao();
                RealizaComandoSQL(query, conn);
                return true;
            }
            catch (Exception)
            {
                throw;
                return false;
            }

        }

        public bool AtualizaFrequencia(int codigo, int codAluno, DateTime dataHora)
        {
            string query = string.Format(AcademiaUninove.Sistema.Queries.Update.QueriesUpdate.qUpdateFrequencia,
                                     codigo,
                                     codAluno,
                                     dataHora);
            try
            {
                conn = ObterConexao();
                RealizaComandoSQL(query, conn);
                return true;
            }
            catch (Exception)
            {
                throw;
                return false;
            }
        }

        public bool ExcluiFrequencia(int codigo)
        {
            string query = string.Format(AcademiaUninove.Sistema.Queries.Delete.QueriesDelete.qDeleteFrequencia,
                                     codigo);
            try
            {
                conn = ObterConexao();
                RealizaComandoSQL(query, conn);
                return true;
            }
            catch (Exception)
            {
                throw;
                return false;
            }
        }


    }
}
