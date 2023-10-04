using Application.ViewModels;
using Domain.Dtos;

namespace Application.ServicesInterfaces
{
    public interface ICursoAppService
    {
        IEnumerable<CursoDto> BuscarTodosCursos();
        void CadastrarNovoCurso(CursoViewModel cursoViewModel);
    }
}
