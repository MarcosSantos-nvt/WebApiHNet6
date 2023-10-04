using AutoMapper;
using Domain.Dtos;
using Domain.Models;

namespace Application.MapperSetup
{
    public class DtoToModel : Profile
    {
        public DtoToModel()
        {
            CreateMap<CursoDto, Curso>();
        }
    }
}
