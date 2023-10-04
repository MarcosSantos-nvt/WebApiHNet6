using AutoMapper;
using Domain.Dtos;
using Domain.Models;

namespace Application.MapperSetup
{
    public class ModelToDto : Profile
    {
        public ModelToDto()
        {
            CreateMap<Curso, CursoDto>();
        }
    }
}
