using Application.ServicesInterfaces;
using Application.ViewModels;
using Domain.Dtos;
using Microsoft.AspNetCore.Mvc;
using System.Net;

namespace Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CursoController : ControllerBase
    {        
        private readonly ICursoAppService _cursoAppService;

        public CursoController(ICursoAppService cursoAppService) => (_cursoAppService) = (cursoAppService);        

        [ProducesResponseType(typeof(CursoDto), (int)HttpStatusCode.OK)]
        [HttpGet, Route("todos-cursos")]
        public IActionResult TodosOsCursos()
        {
            try
            {
                return Ok(_cursoAppService.BuscarTodosCursos());
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
            
        }    
        
        [ProducesResponseType(typeof(string),(int)HttpStatusCode.OK)]
        [HttpPost, Route("cadastrar-curso")]
        public IActionResult CadastrarNovoCurso([FromQuery] CursoViewModel cursoViewModel)
        {
            if (cursoViewModel == null) throw new ArgumentException("As informações devem ser preenchidas");

            _cursoAppService.CadastrarNovoCurso(cursoViewModel);
            return Ok();
        }
    }
}
