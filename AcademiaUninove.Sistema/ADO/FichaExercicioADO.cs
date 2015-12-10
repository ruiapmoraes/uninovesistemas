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

        /// <summary>
        /// Busca Ficha do Aluno
        /// </summary>
        /// <returns>Retorna os dados</returns>
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

        /// <summary>
        /// Buscar ficha do aluno até do código da ficha
        /// </summary>
        /// <param name="codigo"></param>
        /// <returns>Retirna os dados</returns>
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

        /// <summary>
        /// Insere a ficha de exercício
        /// </summary>
        /// <param name="codigo"></param>
        /// <param name="codigoAluno"></param>
        /// <param name="nomeExercicio"></param>
        /// <param name="repeticoes"></param>
        /// <param name="series"></param>
        /// <param name="treino"></param>
        /// <param name="dataInicio"></param>
        /// <returns></returns>
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

        /// <summary>
        /// Atualiza a ficha de exercício
        /// </summary>
        /// <param name="codigo"></param>
        /// <param name="codigoAluno"></param>
        /// <param name="nomeExercicio"></param>
        /// <param name="repeticoes"></param>
        /// <param name="series"></param>
        /// <param name="treino"></param>
        /// <param name="dataInicio"></param>
        /// <returns>Retorna o resultado do comando de atualização</returns>
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


        /// <summary>
        /// Exclui ficha de exercício
        /// </summary>
        /// <param name="codigo"></param>
        /// <returns>Retorna o resultado do comando de exclusão do registro</returns>
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
