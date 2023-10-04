using Application.ServicesInterfaces;
using Application.ViewModels;
using AutoMapper;
using Domain.Dtos;
using Domain.Interfaces.Repositories;
using Domain.Interfaces.UnitOfWork;
using Domain.Models;

namespace Application.Services
{
    public class CursoAppSercice : ICursoAppService
    {
        private readonly ICursoRepository _cursoRepository;
        private readonly IMapper _mapper;
        private readonly IUnitOfWorkPersistence _unitOfWorkPersistence;

        public CursoAppSercice(ICursoRepository cursoRepository, IMapper mapper, IUnitOfWorkPersistence unitOfWorkPersistence) => (_cursoRepository, _mapper, _unitOfWorkPersistence) = (cursoRepository, mapper, unitOfWorkPersistence);
        public IEnumerable<CursoDto> BuscarTodosCursos()
        {            
            return _mapper.Map<IEnumerable<CursoDto>>(_cursoRepository.BuscarTodosRegistros());
        }

        public void CadastrarNovoCurso(CursoViewModel cursoViewModel)
        {
            var curso = _mapper.Map<Curso>(cursoViewModel);
            curso.CadastrarNovoCurso(curso);

            _cursoRepository.Inserir(curso);

            _unitOfWorkPersistence.Commit();
        }
    }
}
