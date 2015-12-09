using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using AcademiaUninove.Sistema.ADO;

namespace AcademiaUninove.Sistema.Negocio
{
    public class HoraAulaBO
    {
        HoraAulaADO objHoraAulaADO = new HoraAulaADO();

        public DataTable ObterHoraAula()
        {
            HoraAulaADO objHoraAulaADO = new HoraAulaADO();
            DataTable dtHoraAula = new DataTable();

            dtHoraAula = objHoraAulaADO.ConsultaHoraAula();
            return dtHoraAula;
        }

        public DataTable ObterHoraAula(int codigo)
        {
            HoraAulaADO objHoraAulaADO = new HoraAulaADO();
            DataTable dtHoraAula = new DataTable();

            dtHoraAula = objHoraAulaADO.ConsultaHoraAula(codigo);
            return dtHoraAula;
        }

        public bool InsereHoraAula(int codigo, int coHorario, int codAula)
        {
            bool bRet = false;
            bRet = objHoraAulaADO.InsereHoraAula(codigo,
                                                 coHorario,
                                                 codAula);
            return bRet;
        }

        public bool AtualizaHoraAula(int codigo, int coHorario, int codAula)
        {
            bool bRet = false;
            bRet = objHoraAulaADO.AtualizaHoraAula(codigo,
                                                 coHorario,
                                                 codAula);
            return bRet;
        }

        public bool ExcluiHoraAula(int codigo)
        {
            bool bRet = false;
            bRet = objHoraAulaADO.ExcluiHoraAula(codigo);
            return bRet;
        }
       
    }
}
