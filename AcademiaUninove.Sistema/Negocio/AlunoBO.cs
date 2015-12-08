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
        public DataTable ObterAluno()
        {
            AlunoADO objAlunoADO = new AlunoADO();
            DataTable dtAluno = null;

            dtAluno = objAlunoADO.ConsultarAluno();
            return dtAluno;
        }
    }
}
