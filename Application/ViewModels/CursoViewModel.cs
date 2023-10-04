using System.ComponentModel.DataAnnotations;

namespace Application.ViewModels
{
    public class CursoViewModel
    {
       
        public string? Nomenclatura { get;  set; }
        
        public int CargaHoraria { get;  set; }
       
        public short Dependencia { get;  set; }
       
        public string? PreRequisito { get;  set; }
    }
}
