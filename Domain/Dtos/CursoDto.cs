namespace Domain.Dtos
{
    public class CursoDto
    {
        public int Id { get; set; }
        public string Nomenclatura { get; set; }
        public int CargaHoraria { get; set; }
        public short Dependencia { get; set; }
        public string PreRequisito { get; set; }
    }
}
