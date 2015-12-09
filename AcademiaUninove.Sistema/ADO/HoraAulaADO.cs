using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using AcademiaUninove.Sistema.Helpers;


namespace AcademiaUninove.Sistema.ADO
{
    public class HoraAulaADO : ADOBase
    {
        #region Variáveis globais
        string conn = string.Empty;
        ADOBase objConexao = new ADOBase();
        #endregion

        public DataTable ConsultaHoraAula() {
            bool bRet = false;
            DataTable dtHoraAula = new DataTable();
            string query = AcademiaUninove.Sistema.Queries.Read.QueriesConsulta.qConsultaHoraAula;

            try
            {
                conn = ADOBase.ObterConexao();
                dtHoraAula = RealizaPesquisaSQL(query, conn);
            }
            catch (Exception)
            {
                dtHoraAula = null;
                throw;
            }
            return dtHoraAula;
        }

        public DataTable ConsultaHoraAula(int codigo)
        {
            bool bRet = false;
            DataTable dtHoraAula = new DataTable();
            string query = string.Format( AcademiaUninove.Sistema.Queries.Read.QueriesConsulta.qConsultaHoraAula, codigo);

            try
            {
                conn = ADOBase.ObterConexao();
                dtHoraAula = RealizaPesquisaSQL(query, conn);
            }
            catch (Exception)
            {
                dtHoraAula = null;
                throw;
            }
            return dtHoraAula;
        }

        /// <summary>
        /// Insere Hora Aula
        /// </summary>
        /// <param name="codigo"></param>
        /// <param name="codHorario"></param>
        /// <param name="codAula"></param>
        /// <returns></returns>
        public bool InsereHoraAula(int codigo, int codHorario, int codAula)
        {
            string query = string.Format(AcademiaUninove.Sistema.Queries.Insert.QueriesInsert.qInsertHoraAula, codigo, codHorario, codAula);
            conn = ADOBase.ObterConexao();

            try
            {
                RealizaComandoSQL(query, conn);
                return true;
            }
            catch (Exception)
            {
                throw;
                return false;

            }

            return false;
        }

        public bool AtualizaHoraAula(int codigo, int codHorario, int codAula)
        {
            string query = string.Format(AcademiaUninove.Sistema.Queries.Update.QueriesUpdate.qUpdateHoraAula,
                                        codigo,
                                        codHorario,
                                        codAula);
            conn = ADOBase.ObterConexao();

            try
            {
                RealizaComandoSQL(query, conn);
                return true;
            }
            catch (Exception)
            {
                
                throw;
                return false;
            }
        }

        public bool ExcluiHoraAula(int codigo)
        {
            string query = string.Format(AcademiaUninove.Sistema.Queries.Delete.QueriesDelete.qDeleteHoraAula, codigo);
            conn = ADOBase.ObterConexao();

            try
            {
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
