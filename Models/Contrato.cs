namespace lubee_web_api.Models
{
    public class Contrato
    {

        [Key]
        public int Id { get; set; }
        public string CourseCode { get; set; }
        public DateTime FechaAlta { get; set; }
        public int Estado { get; set; }
        public int CantidadEgresados { get; set; }
        public DateTime FechaEntrega { get; set; }
        public string MedioEntrega { get; set; }
        public string Vendedor { get; set; }
        public string ColegioNivel { get; set; }
        public string ColegioNombre { get; set; }
        public string ColegioCurso { get; set; }
        public string ColegioLocalidad { get; set; }
        public decimal Comision { get; set; }
        public decimal Total { get; set; }

        // Propiedad de navegación para la relación con Curso
        public Curso Curso { get; set; }
    }
}
