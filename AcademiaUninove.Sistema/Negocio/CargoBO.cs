using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using AcademiaUninove.ADO;

namespace AcademiaUninove.Sistema.Negocio
{
    public class CargoBO
    {
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
    }
}
