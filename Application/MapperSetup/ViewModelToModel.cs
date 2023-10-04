using Application.ViewModels;
using AutoMapper;
using Domain.Models;

namespace Application.MapperSetup
{
    public class ViewModelToModel : Profile
    {
        public ViewModelToModel()
        {
            CreateMap<CursoViewModel, Curso>();
        }
    }
}
