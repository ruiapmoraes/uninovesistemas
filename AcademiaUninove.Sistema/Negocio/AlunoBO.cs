using AcademiaUninove.Sistema.ADO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcademiaUninove.Sistema.Negocio
{
    public class AlunoBO
    {
        public DataTable ObterAluno(out bool sucesso)
        {
            AlunoADO objAlunoADO = new AlunoADO();
            DataTable dtAluno = null;

            dtAluno = objAlunoADO.ConsultarAluno(out sucesso);
            return dtAluno;
        }

        public bool AtualizaAluno(int codigo
                                , int codFunc
                                , string nomeAluno
                                , string cpf
                                , string rg
                                , DateTime dtNasc
                                , string telRes
                                , string telCel
                                , string endereco
                                , string cidade
                                , string cep
                                , string statusAluno
                                , string restricao
                                , string objetivo)
        {
            AlunoADO objAlunoADO = new AlunoADO();
            bool bRet = false;
            bRet = objAlunoADO.AtualizaAluno(codigo
                                           ,codFunc
                                           ,nomeAluno
                                           ,cpf
                                           ,rg
                                           ,dtNasc
                                           ,telRes
                                           ,telCel
                                           ,endereco
                                           ,cidade
                                           ,cep
                                           ,statusAluno
                                           ,restricao
                                           ,objetivo);              
                                       
            return bRet;
        }

        public bool InserirAluno(int codigo
                                , int codFunc
                                , string nomeAluno
                                , string cpf
                                , string rg
                                , DateTime dtNasc
                                , string telRes
                                , string telCel
                                , string endereco
                                , string cidade
                                , string cep
                                , string statusAluno
                                , string restricao
                                , string objetivo)
        {
            AlunoADO objAlunoADO = new AlunoADO();
            bool bRet = false;
            bRet = objAlunoADO.InserirAluno(codigo
                                           , codFunc
                                           , nomeAluno
                                           , cpf
                                           , rg
                                           , dtNasc
                                           , telRes
                                           , telCel
                                           , endereco
                                           , cidade
                                           , cep
                                           , statusAluno
                                           , restricao
                                           , objetivo);

            return bRet;
        }

        public DataTable ObterAluno(int codigo)
        {
            AlunoADO objAlunoADO = new AlunoADO();
            DataTable dtAluno = null;

            dtAluno = objAlunoADO.ConsultarAluno(codigo);
            return dtAluno;
        }
    }
}
