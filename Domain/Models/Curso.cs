using Domain.Enums;
using Domain.Utils;

namespace Domain.Models
{
    public class Curso : Entity<int>
    {
        public string Nomenclatura { get; private set; }
        public int CargaHoraria { get; private set; }
        public Dependencia Dependencia { get; private set; }
        public string PreRequisito { get; private set; }

        public Curso(string nomenclatura, int cargaHoraria, Dependencia dependencia, string preRequisito) => (Nomenclatura, CargaHoraria, Dependencia, PreRequisito) = (nomenclatura, cargaHoraria, dependencia, preRequisito);
        protected Curso()
        { }

        public void CadastrarNovoCurso(Curso curso)
        {
            Nomenclatura = curso.Nomenclatura;
            CargaHoraria = curso.CargaHoraria;
            Dependencia = curso.Dependencia;
            PreRequisito = curso.PreRequisito;
        }
    }
}
