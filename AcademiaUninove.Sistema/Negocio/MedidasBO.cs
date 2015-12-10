using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using AcademiaUninove.Sistema.ADO;

namespace AcademiaUninove.Sistema.Negocio
{
    public class MedidasBO
    {
        public DataTable ObterMedidas()
        {
            MedidasADO objMedidas = new MedidasADO();
            DataTable dtMedidas = null;
            dtMedidas = objMedidas.ConsultaMedida();
            return dtMedidas;
        }

        public DataTable ObterMedidas(int codigo)
        {
            MedidasADO objMedidas = new MedidasADO();
            DataTable dtMedidas = null;
            dtMedidas = objMedidas.ConsultaMedida(codigo);
            return dtMedidas;
        }

        public bool InserirMedidas(int codigo,
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
            MedidasADO objMedidas = new MedidasADO();
            bool bRet = false;
            bRet = objMedidas.InsereMedida(codigo,
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
            return bRet;
        }

        public bool AlterarMedidas(int codigo,
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
            MedidasADO objMedidas = new MedidasADO();
            bool bRet = false;
            bRet = objMedidas.AtualizaMedida(codigo,
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
            return bRet;

        }

        public bool ExcluirMedidas(int codigo)
        {
            MedidasADO objMedidas = new MedidasADO();
            bool bRet = false;
            bRet = objMedidas.ExcluiMedida(codigo);
            return bRet;
        }
    }
}
