using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using AcademiaUninove.Sistema.Helpers;

namespace AcademiaUninove.Sistema.ADO
{
    public class FichaExercicioADO : ADOBase
    {

        #region Variáveis globais
        string conn = string.Empty;
        ADOBase objConexao = new ADOBase();
        #endregion


        public DataTable ConsultarFicha()
        {
            
            DataTable dtFicha = null;
            string query = AcademiaUninove.Sistema.Queries.Read.QueriesConsulta.qConsultaFicha;

            try
            {
                conn = ObterConexao();
                dtFicha = RealizaPesquisaSQL(query, conn);
            }
            catch (Exception)
            {
                dtFicha = null;
                throw;
            }
            return dtFicha;
        }

        public DataTable ConsultarFicha(int codigo)
        {
            DataTable dtFicha = null;
            string query = string.Format( AcademiaUninove.Sistema.Queries.Read.QueriesConsulta.qConsultaFicha, codigo);

            try
            {
                conn = ObterConexao();
                dtFicha = RealizaPesquisaSQL(query, conn);
            }
            catch (Exception)
            {
                dtFicha = null;
                throw;
            }
            return dtFicha;

        }

        public bool InsereFichaExercicio(int codigo,
                                           int codigoAluno,
                                           string nomeExercicio,
                                           string repeticoes,
                                           string series,
                                           string treino,
                                           DateTime dataInicio)
        {
            string query = string.Format(AcademiaUninove.Sistema.Queries.Insert.QueriesInsert.qInsertFicha,
                                                                        codigo,
                                                                        codigoAluno,
                                                                        nomeExercicio,
                                                                        repeticoes,
                                                                        series,
                                                                        treino,
                                                                        dataInicio);
            conn = ObterConexao();

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

        public bool AtualizaFichaExercicio(int codigo,
                                           int codigoAluno,
                                           string nomeExercicio,
                                           string repeticoes,
                                           string series,
                                           string treino,
                                           DateTime dataInicio)
        {
            string query = string.Format(AcademiaUninove.Sistema.Queries.Update.QueriesUpdate.qUpdateFicha,
                                                                        codigo,
                                                                        codigoAluno,
                                                                        nomeExercicio,
                                                                        repeticoes,
                                                                        series,
                                                                        treino,
                                                                        dataInicio);
            conn = ObterConexao();

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

        public bool ExcluiFichaExercicio(int codigo)
        {
            string query = string.Format(AcademiaUninove.Sistema.Queries.Delete.QueriesDelete.qDeleteFicha,
                                                                        codigo);
            conn = ObterConexao();

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
