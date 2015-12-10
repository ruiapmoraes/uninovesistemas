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
    public class MedidasADO : ADOBase
    {
        string conn = string.Empty;
        ADOBase objConexao = new ADOBase();

        public DataTable ConsultaMedida()
        {
            bool bRet = false;
            DataTable dtMedidas = null;
            string query = AcademiaUninove.Sistema.Queries.Read.QueriesConsulta.qConsultaMedidas;

            try
            {
                conn = ObterConexao();
                dtMedidas = RealizaPesquisaSQL(query, conn);
                bRet = true;
            }
            catch (Exception)
            {
                bRet = false;
                dtMedidas = null;
                
                throw;
            }
            return dtMedidas;
        }

        public DataTable ConsultaMedida(int codigo)
        {
            bool bRet = false;
            DataTable dtMedidas = null;
            string query = string.Format( AcademiaUninove.Sistema.Queries.Read.QueriesConsulta.qConsultaMedidas, codigo);

            try
            {
                conn = ObterConexao();
                dtMedidas = RealizaPesquisaSQL(query, conn);
                bRet = true;
            }
            catch (Exception)
            {
                bRet = false;
                dtMedidas = null;

                throw;
            }
            return dtMedidas;
        }

        public bool InsereMedida(int codigo,
                                       int codAluno,
                                       DateTime dataMedida,
                                       double peso,
                                       double abdomen,
                                       double antBracoDir,
                                       double antBracoEsq,
                                       double bracoDir,
                                       double bracoEsq,
                                       double busto,
                                       double cintura,
                                       double coxaDir,
                                       double coxaEsq,
                                       double ombro,
                                       double pernaDir,
                                       double pernaEsq,
                                       double quadril,
                                       double torax,
                                       double altura,
                                       double imc)
        {
            bool bRet = false;

            string query = string.Format(AcademiaUninove.Sistema.Queries.Insert.QueriesInsert.qInsertMedidas,
                                                codigo,
                                                codAluno,
                                                dataMedida,
                                                peso,
                                                abdomen,
                                                antBracoDir,
                                                antBracoEsq,
                                                bracoDir,
                                                bracoEsq,
                                                busto,
                                                cintura,
                                                coxaDir,
                                                coxaEsq,
                                                ombro,
                                                pernaDir,
                                                pernaEsq,
                                                quadril,
                                                torax,
                                                altura,
                                                imc);
            try
            {
                conn = ObterConexao();
                RealizaComandoSQL(query, conn);
                return true;
            }
            catch (Exception)
            {
                return false;
                throw;
            }

        }

        public bool AtualizaMedida(int codigo,
                                   int codAluno,
                                   DateTime dataMedida,
                                   double peso,
                                   double abdomen,
                                   double antBracoDir,
                                   double antBracoEsq,
                                   double bracoDir,
                                   double bracoEsq,
                                   double busto,
                                   double cintura,
                                   double coxaDir,
                                   double coxaEsq,
                                   double ombro,
                                   double pernaDir,
                                   double pernaEsq,
                                   double quadril,
                                   double torax,
                                   double altura,
                                   double imc)
        {
            bool bRet = false;

            string query = string.Format(AcademiaUninove.Sistema.Queries.Update.QueriesUpdate.qUpdateMedidas,
                                                codigo,
                                                codAluno,
                                                dataMedida,
                                                peso,
                                                abdomen,
                                                antBracoDir,
                                                antBracoEsq,
                                                bracoDir,
                                                bracoEsq,
                                                busto,
                                                cintura,
                                                coxaDir,
                                                coxaEsq,
                                                ombro,
                                                pernaDir,
                                                pernaEsq,
                                                quadril,
                                                torax,
                                                altura,
                                                imc);
            try
            {
                conn = ObterConexao();
                RealizaComandoSQL(query, conn);
                return true;
            }
            catch (Exception)
            {
                return false;
                throw;
            }

        }

        public bool ExcluiMedida(int codigo)
        {
            bool bRet = false;

            string query = string.Format(AcademiaUninove.Sistema.Queries.Delete.QueriesDelete.qDeleteMedidas, codigo);
            try
            {
                conn = ObterConexao();
                RealizaComandoSQL(query, conn);
                return true;
            }
            catch (Exception)
            {
                return false;
                throw;
            }

        }
    }
}
