using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using AcademiaUninove.Sistema.ADO;

namespace AcademiaUninove.Sistema.Negocio
{
    public class FichaExerciciosBO : FichaExercicioADO
    {
        public DataTable ObterFicha()
        {
            FichaExercicioADO objFichaADO = new FichaExercicioADO();
            DataTable dtFicha = new DataTable();
            dtFicha = objFichaADO.ConsultarFicha();
            return dtFicha;
        }

        public DataTable ObterFicha(int codigo)
        {
            FichaExercicioADO objFichaADO = new FichaExercicioADO();
            DataTable dtFicha = new DataTable();
            dtFicha = objFichaADO.ConsultarFicha(codigo);
            return dtFicha;
        }

        public bool InsereFicha(int codigo,
                                           int codigoAluno,
                                           string nomeExercicio,
                                           string repeticoes,
                                           string series,
                                           string treino,
                                           DateTime dataInicio)
        {
            bool resultado = false;
            resultado = InsereFichaExercicio(codigo,
                                            codigoAluno,
                                            nomeExercicio,
                                            repeticoes,
                                            series,
                                            treino,
                                            dataInicio);
            return resultado;

        }
        /// <summary>
        /// Chamada para atualização de ficha
        /// </summary>
        /// <param name="codigo"></param>
        /// <param name="codigoAluno"></param>
        /// <param name="nomeExercicio"></param>
        /// <param name="repeticoes"></param>
        /// <param name="series"></param>
        /// <param name="treino"></param>
        /// <param name="dataInicio"></param>
        /// <returns></returns>
        public bool AtualizaFicha(int codigo,
                                           int codigoAluno,
                                           string nomeExercicio,
                                           string repeticoes,
                                           string series,
                                           string treino,
                                           DateTime dataInicio)
        {
            bool resultado = false;
            resultado = AtualizaFichaExercicio(codigo,
                                            codigoAluno,
                                            nomeExercicio,
                                            repeticoes,
                                            series,
                                            treino,
                                            dataInicio);
            return resultado;

        }

        /// <summary>
        /// Chamada para excluir ficha de exercício
        /// </summary>
        /// <param name="codigo"></param>
        /// <returns></returns>
        public bool ExcluiFicha(int codigo)
        {
            bool resultado = false;
            resultado = ExcluiFichaExercicio(codigo);
            return resultado;

        }
    }
}
