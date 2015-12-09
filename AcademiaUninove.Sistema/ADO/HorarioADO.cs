using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using AcademiaUninove.Sistema.Helpers;
using System.Globalization;
using System.Threading;

namespace AcademiaUninove.Sistema.ADO
{
    public class HorarioADO : ADOBase
    {
        string conn = string.Empty;
        ADOBase objConexao = new ADOBase();
       

        public DataTable ConsultaHorario()
        {
            bool bRet = false;
            DataTable dtHorario = null;
            string query = AcademiaUninove.Sistema.Queries.Read.QueriesConsulta.qConsultaHorario;

            try
            {
                conn = ADOBase.ObterConexao();
                dtHorario = RealizaPesquisaSQL(query, conn);

            }
            catch (Exception ex)
            {
                dtHorario = null;
                throw ex;
            }

            //TODO ajustar o retorno do método
            return dtHorario;
        }

        public bool InsereHorario(int codigo, DateTime dataHorario, DateTime hora)
        {
            CultureInfo culture = (CultureInfo)CultureInfo.CurrentCulture.Clone();
            culture.DateTimeFormat.ShortDatePattern = "yyyy/MM/dd HH:mm:ss";
            culture.DateTimeFormat.LongTimePattern = "";
            Thread.CurrentThread.CurrentCulture = culture;

            string query = string.Format(AcademiaUninove.Sistema.Queries.Insert.QueriesInsert.qInsertHorario, codigo, dataHorario, hora);
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

        public bool AtualizaHorario(int codigo, DateTime dataHorario, DateTime hora)
        {
            CultureInfo culture = (CultureInfo)CultureInfo.CurrentCulture.Clone();
            culture.DateTimeFormat.ShortDatePattern = "yyyy-MM-dd HH:mm:ss";
            culture.DateTimeFormat.LongTimePattern = "";
            Thread.CurrentThread.CurrentCulture = culture;

            string query = string.Format(AcademiaUninove.Sistema.Queries.Update.QueriesUpdate.qUpdateHorario, dataHorario, hora, codigo);
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

        public DataTable ConsultaHorario(int codigo)
        {
            bool bRet = false;
            DataTable dtHorario = null;
            string query = string.Format( AcademiaUninove.Sistema.Queries.Update.QueriesUpdate.qConsultaHorarioEdit, codigo);

            try
            {
                conn = ADOBase.ObterConexao();
                dtHorario = RealizaPesquisaSQL(query, conn);

            }
            catch (Exception ex)
            {
                dtHorario = null;
                throw ex;
            }

            //TODO ajustar o retorno do método
            return dtHorario;
        }

        public bool ExcluiHorario(int codigo)
        {
            string query = string.Format(AcademiaUninove.Sistema.Queries.Delete.QueriesDelete.qDeleteHorario, codigo);
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
