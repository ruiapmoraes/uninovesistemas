using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Configuration;

namespace AcademiaUninove.Sistema.Helpers
{
    public class ADOBase
    {
        public static DataTable RealizaPesquisaSQL(string strQuery, string strStringConexao)
        {
            DataTable objTabela = null;

            try
            {
                using (var objConexao = new SqlConnection(strStringConexao))
                {
                    using (var objComando = new SqlCommand(strQuery, objConexao))
                    {
                        objComando.CommandTimeout = 2400;
                        using (var objAdaptador = new SqlDataAdapter(objComando))
                        {
                            objTabela = new DataTable();
                            objAdaptador.Fill(objTabela);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                objTabela = null;
                throw ex;
            }
            return objTabela;
        }

        public static bool RealizaComandoSQL(string strComandoSQL, string strStringConexao)
        {
            SqlConnection objConexao = null;
            SqlCommand objComando = null;
            bool bRet = true;

            try
            {
                using (objConexao = new SqlConnection(strStringConexao))
                {
                    using (objComando = new SqlCommand(strComandoSQL, objConexao))
                    {
                        objConexao.Open();
                        objComando.CommandTimeout = 2400;
                        bRet = (objComando.ExecuteNonQuery() > 0);
                        objConexao.Close();
                    }
                }
            }
            catch (Exception ex)
            {
                bRet = false;

                throw ex;
            }
            finally
            {
                if (objConexao.State != ConnectionState.Closed)
                    objConexao.Close();
                if (null != objComando)
                    objComando.Dispose();
                if (null != objConexao)
                    objConexao.Dispose();
            }

            return bRet;
        }

        public static string ObterConexao()
        {
           
            try
            {
                #region Tipos de conexões com o banco

                //string strConn = @"Server=ARSENAL-GEAR4\SQLEXPRESS2;Database=AcademiaUninove;Trusted_Connection=True";
                //string strConn = @"Data Source=.\SQLEXPRESS;Initial Catalog=AcademiaUninove;Integrated Security=SSPI";
                //string strConn = @"Provider=sqloledb;Data Source=LOCALHOST\SQLEXPRESS2;Initial Catalog=AcademiaUninove;Integrated Security=SSPI;";

                //return ConfigurationManager.ConnectionStrings["UninoveAcademiaConn"].ConnectionString;

                //return ConfigurationManager.ConnectionStrings["UninoveAcademiaConn"].ConnectionString;
                //return strConn; 
                #endregion

                return ConfigurationSettings.AppSettings["UninoveAcademiaConn"];
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
    }
}
