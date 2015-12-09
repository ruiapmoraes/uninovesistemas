using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using AcademiaUninove.Sistema.ADO;

namespace AcademiaUninove.Sistema.Negocio
{
    public class FrequenciaBO
    {
        public DataTable ObterFrequencia()
        {
            FrequenciaADO objFrequenciaADO = new FrequenciaADO();
            DataTable dtFrequencia = null;
            dtFrequencia = objFrequenciaADO.ConsultaFrequencia();
            return dtFrequencia;
        }

        public DataTable ObterFrequencia(int codigo)
        {

            FrequenciaADO objFrequenciaADO = new FrequenciaADO();
            DataTable dtFrequencia = null;
            dtFrequencia = objFrequenciaADO.ConsultaFrequencia(codigo);
            return dtFrequencia;
        }

        public bool InserirFrequencia(int codigo, int codAluno, DateTime dataHora)
        {
            FrequenciaADO objFrequencia = new FrequenciaADO();
            bool bRet = false;
            bRet = objFrequencia.InsereFrequencia(codigo,
                                                  codAluno,
                                                  dataHora);
            return bRet;
        }

        public bool AtualizaFrequencia(int codigo, int codAluno, DateTime dataHora)
        {
            FrequenciaADO objFrequencia = new FrequenciaADO();
            bool bRet = false;
            bRet = objFrequencia.AtualizaFrequencia(codigo,
                                                  codAluno,
                                                  dataHora);
            return bRet;
        }

        public bool ExcluirFrequencia(int codigo)
        {
            FrequenciaADO objFrequencia = new FrequenciaADO();
            bool bRet = false;
            bRet = objFrequencia.ExcluiFrequencia(codigo);
            return bRet;
        }
    }
}
