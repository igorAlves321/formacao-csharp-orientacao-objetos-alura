using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex03ProblemaEscola
{
    public class Diciplina
    {
        public string NomeDisciplina { get; set; }
        public List<Aluno> AlunosMatriculados { get; set; } = new List<Aluno>();

    }
}
