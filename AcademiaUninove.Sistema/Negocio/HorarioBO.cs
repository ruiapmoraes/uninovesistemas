using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AcademiaUninove.Sistema.ADO;

namespace AcademiaUninove.Sistema.Negocio
{
    public class HorarioBO
    {
        HorarioADO objHorarioADO = new HorarioADO();

        public DataTable ObterHorario()
        {
            HorarioADO objHorarioADO = new HorarioADO();
            DataTable dtHorario = null;
            dtHorario = objHorarioADO.ConsultaHorario();
            return dtHorario;
        }

        public bool InsereHorario(int codigo, DateTime dataHorario, DateTime hora)
        {
            HorarioADO objHorarioADO = new HorarioADO();
            bool bRet = false;
            bRet = objHorarioADO.InsereHorario(codigo, dataHorario, hora);
            return bRet;
        }

        public bool AtualizaHorario(int codigo, DateTime dataHorario, DateTime hora)
        {
            HorarioADO objHorarioADO = new HorarioADO();
            bool bRet = false;
            bRet = objHorarioADO.AtualizaHorario(codigo, dataHorario, hora);
            return bRet;

        }

        public DataTable ObterHorario(int codigo)
        {
            HorarioADO objHorarioADO = new HorarioADO();
            DataTable dtHorario = null;
            dtHorario = objHorarioADO.ConsultaHorario(codigo);
            return dtHorario;
        }
    }
}
