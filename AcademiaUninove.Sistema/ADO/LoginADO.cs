using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AcademiaUninove.Sistema.Helpers;
using System.Data;
using System.Data.SqlClient;


namespace AcademiaUninove.Sistema.ADO
{
    public class LoginADO
    {
        /// <summary>
        /// Verifica o Login no banco de dados.
        /// </summary>
        /// <param name="usuario">Usuário</param>
        /// <param name="senha">Senha</param>
        /// <returns>Devolver o resultado da consulta do usuário no banco de dados</returns>
        public bool VerificaLoginADO(string usuario, string senha)
        {
            bool resultado = false;
            //string stringConn = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\GitHubUninove\2SEM_2015\UninoveAcademia\UninoveAcademia\AcademiaUninove.mdf;Integrated Security=True;Connect Timeout=30";
            //string stringConn = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\GITUNINOVE\VS2013\UNINOVEACADEMIA\UNINOVEACADEMIASISTEMAS\ACADEMIAUNINOVE.MDF;Integrated Security=True;Connect Timeout=30";
            string stringConn = ADOBase.ObterConexao();
            SqlConnection conn = new SqlConnection(stringConn);
            //OleDbConnection OledbConn = new OleDbConnection();
            //OleDbDataAdapter oledbDa = null;
            SqlDataAdapter da = null;
            //string query = string.Format(Queries.SistemaQueries.qLogin, usuario, senha);
            string query = string.Format(Queries.Read.QueriesConsulta.qLogin, usuario, senha);


            conn.ConnectionString = stringConn;
            //OledbConn.ConnectionString = stringConn;


            try
            {
                //SqlCommand cmd = new SqlCommand("select usuario, senha from Login Where usuario = '" + usuario +
                //    "' and senha = '" + senha + "'", conn);
                SqlCommand cmd = new SqlCommand(query, conn);

                conn.Open();
                da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                if (dt.Rows.Count > 0 && dt != null)
                    resultado = true;
                //OleDbCommand cmd = new OleDbCommand(query, OledbConn);
                //OledbConn.Open();
                //oledbDa = new OleDbDataAdapter(cmd);
                //DataTable dt = new DataTable();
                //oledbDa.Fill(dt);
                //if (dt.Rows.Count > 0 && dt != null)
                //{
                //    resultado = true;
                //}

            }
            catch (Exception)
            {

                throw;
            }
            //OledbConn.Close();
            return resultado;
        }
    }
}
