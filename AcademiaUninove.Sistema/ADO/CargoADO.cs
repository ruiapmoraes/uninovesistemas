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
    public class CargoADO : ADOBase
    {
        string conn = string.Empty;
        ADOBase objConexao = new ADOBase();

        public bool InsereCargo(int codigo, string cargo)
        {
            string query = string.Format(AcademiaUninove.Sistema.Queries.Insert.QueriesInsert.qInsertCargo, codigo, cargo);
            conn = ADOBase.ObterConexao();
            
            bool bRet = false;
            RealizaComandoSQL(query, conn);
            return bRet;
        }

        public bool ConsultaCargoOld()
        {
            bool bRet = false;
            DataTable dtCargo = null;
            string query = AcademiaUninove.Sistema.Queries.Read.QueriesConsulta.qConsultaCargo;

            try
            {
                conn = ADOBase.ObterConexao();
                dtCargo = RealizaPesquisaSQL(query, conn);

            }
            catch (Exception ex)
            {

                throw ex;
            }

            //TODO ajustar o retorno do método
            return bRet;
        }

        public DataTable ConsultaCargo()
        {
            bool bRet = false;
            DataTable dtCargo = null;
            string query = AcademiaUninove.Sistema.Queries.Read.QueriesConsulta.qConsultaCargo;

            try
            {
                conn = ADOBase.ObterConexao();
                dtCargo = RealizaPesquisaSQL(query, conn);

            }
            catch (Exception ex)
            {
                dtCargo = null;
                throw ex;
            }

            //TODO ajustar o retorno do método
            return dtCargo;
        }
    }
}
