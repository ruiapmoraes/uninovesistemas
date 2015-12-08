using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using AcademiaUninove.Sistema.ADO;

namespace AcademiaUninove.Sistema.Negocio
{
    public class CargoBO
    {
        CargoADO objCargoADO = new CargoADO();

        public bool InserirCargo()
        {
            bool bRet = false;

            return bRet;
        }

        public DataTable ObterCargo()
        {
            CargoADO objCargoADO = new CargoADO();

            DataTable dtCargo = null; ;

            dtCargo = objCargoADO.ConsultaCargo();

            return dtCargo;
        }

        public bool InserirCargo(int codigo, string cargo)
        {
            bool bRet = false;
            bRet = objCargoADO.InsereCargo(codigo, cargo);
            return bRet;
        }

        public DataTable ObterCargo(int _codCargo)
        {
            CargoADO objCargoADO = new CargoADO();

            DataTable dtCargo = null; ;

            dtCargo = objCargoADO.ConsultaCargo(_codCargo);

            return dtCargo;
        }

        public bool AtualizaCargo(int codigo, string cargo)
        {
            bool bRet = false;
            bRet = objCargoADO.AtualizaCargo(codigo, cargo);
            return bRet;
        }

        public bool ExcluiCargo(int codigo)
        {
            bool bRet = false;
            bRet = objCargoADO.ExcluiCargo(codigo);
            return bRet;
        }

        public DataTable ObterCargoCombo(int codigo)
        {
            CargoADO objCargoADO = new CargoADO();

            DataTable dtCargo = null; ;

            dtCargo = objCargoADO.ConsultaCargo(codigo);

            return dtCargo;
        }
    }
}
